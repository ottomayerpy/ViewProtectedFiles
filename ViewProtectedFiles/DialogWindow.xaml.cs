using System.Windows;
using System.Windows.Input;
using ViewProtectedFiles.Properties;

namespace ViewProtectedFiles
{
    public partial class DialogWindow
    {
        public bool Result { get; set; }
        public string DirectoryName { get; set; }

        public DialogWindow(string mode)
        {
            InitializeComponent();

            switch (mode)
            {
                case "Login":
                    GridDialogLogin.Visibility = Visibility.Visible;
                    break;
                case "Directory":
                    GridDialogCreateDirectory.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void ButtonContinue_Click(object sender, RoutedEventArgs e)
        {
            Continue();
        }

        private void PasswordBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Continue();
            }
        }

        private void Continue()
        {
            if (GridDialogLogin.Visibility == Visibility.Visible)
            {
                if (Settings.Default.Password == PasswordBoxPassword.Password)
                {
                    Result = true;
                    Close();
                }
                else
                {
                    MessageBox.Show("Не правильный пароль. Повторите попытку.", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    PasswordBoxPassword.Password = string.Empty;
                }
            }
            else
            {
                DirectoryName = TextBoxDirectoryName.Text;
                Close();
            }
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
