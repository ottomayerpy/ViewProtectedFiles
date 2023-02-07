using System.Collections.ObjectModel;
using System.IO;

namespace ViewProtectedFiles
{
    public class ImageViewModel
    {
        public ImageViewModel(string name, string path)
        {
            Name = name;
            Path = path;
        }

        public string Name { get; set; }
        public string Path { get; set; }
    }

    public class MainViewModel
    {
        public ObservableCollection<ImageViewModel> Images { get; set; } = new ObservableCollection<ImageViewModel>();

        public MainViewModel(string path, string format)
        {
            string[] dir = Directory.GetFiles(path, format);
            foreach (string file in dir)
            {
                FileInfo fileInfo = new FileInfo(file);
                Images.Add(new ImageViewModel(fileInfo.Name, fileInfo.FullName));
            }
        }
    }
}
