using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ViewProtectedFiles.Properties;

namespace ViewProtectedFiles
{
    public partial class MainWindow
    {
        private MainViewModel MainViewModel;

        public MainWindow()
        {
            InitializeComponent();
            DialogWindow dialog = new DialogWindow("Login");
            dialog.ShowDialog();

            if (dialog.Result)
                OpenCatalog(Settings.Default.DefaultCatalogPath);
            else
                Close();
        }

        private void OpenCatalog(string catalog)
        {
            try 
            {
                if (!string.IsNullOrEmpty(catalog))
                {
                    string[] catalogs = Directory.GetDirectories(catalog);
                    ListViewCatalog.Items.Clear();
                    Session.CurrentCatalogPath = catalog;
                    LabelPathCurrentCatalog.Content = catalog;

                    foreach (string catl in catalogs)
                    {
                        ListViewCatalog.Items.Add(Session.GetDirectoryName(catl));
                    }

                    MainViewModel = new MainViewModel(catalog, "*.vpfile");
                    DataContext = MainViewModel;
                }
            }
            catch (DirectoryNotFoundException) 
            {
                MessageBox.Show("Каталог не найден.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                OpenCatalog(Session.CurrentCatalogPath);
            }
        }

        private void ListViewCatalog_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                OpenCatalog($"{Session.CurrentCatalogPath}{ListViewCatalog.SelectedItem.ToString()}\\");
            }
            catch (NullReferenceException)
            { }
        }

        private void ButtonBackCatalog_Click(object sender, RoutedEventArgs e)
        {
            OpenCatalog(Session.GetLastDirectoryPath(Session.CurrentCatalogPath));
        }

        private void ButtonCreateCatalog_Click(object sender, RoutedEventArgs e)
        {
            DialogWindow dialog = new DialogWindow("Directory");
            dialog.ShowDialog();

            if (!string.IsNullOrEmpty(dialog.DirectoryName))
            {
                Directory.CreateDirectory($"{Session.CurrentCatalogPath}{dialog.DirectoryName}\\");
                OpenCatalog(Session.CurrentCatalogPath);
            }
        }

        private void ButtonNextCatalog_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MetroWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Back)
            {
                OpenCatalog(Session.GetLastDirectoryPath(Session.CurrentCatalogPath));
            }
        }

        private void ButtonOpen_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ImageViewModel name = (ImageViewModel)ListViewImage.SelectedItem;
                Process.Start(name.Path);
            }
            catch (NullReferenceException) { }
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = @"JPG (*.jpg)|*.jpg",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };

            if ((bool)dialog.ShowDialog())
            {
                using (FileStream fs = new FileStream($"{Session.CurrentCatalogPath}{Session.GetDirectoryName(dialog.FileName)}.vpfile", FileMode.Create))
                {
                    byte[] file = Convert.FromBase64String(Encryption.EncryptStringAES(Convert.ToBase64String(File.ReadAllBytes(dialog.FileName)), Settings.Default.Password));
                    fs.Write(file, 0, file.Length);
                }

                OpenCatalog(Session.CurrentCatalogPath);
            }
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ImageViewModel name = (ImageViewModel)ListViewImage.SelectedItem;
                File.Delete(name.Path);
                OpenCatalog(Session.CurrentCatalogPath);
            }
            catch (NullReferenceException) { }
        }

        private void ButtonCopyTo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog
                {
                    CheckPathExists = true,
                    Filter = @"JPG (*.jpg)|*.jpg",
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                };

                if ((bool)dialog.ShowDialog())
                {
                    ImageViewModel name = (ImageViewModel)ListViewImage.SelectedItem;
                    File.WriteAllBytes(dialog.FileName, Convert.FromBase64String(Encryption.DecryptStringAES(Convert.ToBase64String(File.ReadAllBytes(name.Path)), Settings.Default.Password)));
                }
            }
            catch (NullReferenceException) { }
        }
    }
}
