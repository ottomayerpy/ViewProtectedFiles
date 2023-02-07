using System.Linq;

namespace ViewProtectedFiles
{
    public static class Session
    {
        public static string CurrentCatalogPath { get; set; }

        public static string GetLastDirectoryPath(string path)
        {
            if (!string.IsNullOrEmpty(path) && path.Length > 3)
            {
                int lastindex = path.LastIndexOf('\\');

                if (lastindex == path.Length - 1)
                {
                    path = path.Remove(lastindex, 1);
                    lastindex = path.LastIndexOf('\\');
                }

                if (!path.Remove(lastindex).Contains('\\'))
                {
                    return $"{path.Remove(lastindex)}\\";
                }

                return path.Remove(lastindex + 1);
            }

            return null;
        }

        public static string GetDirectoryName(string path)
        {
            if (!string.IsNullOrEmpty(path))
            {
                int lastindex = path.LastIndexOf('\\');

                if (lastindex == path.Length - 1)
                {
                    path = path.Remove(lastindex, 1);
                    lastindex = path.LastIndexOf('\\');
                }

                path = path.Substring(1);

                return path.Substring(lastindex);
            }

            return null;
        }
    }
}
