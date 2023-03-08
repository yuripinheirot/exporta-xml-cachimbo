using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exportaXML
{
    public delegate void IncrementProgressBar();
    class Functions
    {
        DataFirebird data = new DataFirebird();
        public List<string> xmlsFromDirectoryOrigin = new List<string>();

        public void loadFilesFromDirectory(string directoryFrom)
        {
            loadFiles(directoryFrom);
            loadSubDirectories(directoryFrom);
        }

        void loadFiles(string diretorio)
        {
            string[] arquivos = Directory.GetFiles(diretorio, "*.xml");
            xmlsFromDirectoryOrigin.AddRange(arquivos);
        }

        void loadSubDirectories(string diretorio)
        {
            string[] subDiretoriosEntradas = Directory.GetDirectories(diretorio);

            foreach (string subDiretorio in subDiretoriosEntradas)
            {
                loadFiles(subDiretorio);
                loadSubDirectories(subDiretorio);
            }
        }

        public async Task handleExport(string year, string month, string lastDay, string directoryTo, IncrementProgressBar incrementProgressBar, frmMain main)
        {
            Dictionary<string, string> xmlsFromDatabase = data.xmlsFromDatabase($"01.{month}.{year}", lastDay);

            await Task.Run(() =>
            {
                foreach (string xml in xmlsFromDirectoryOrigin)
                {
                    FileInfo file = new FileInfo(xml);

                    foreach (KeyValuePair<string, string> item in xmlsFromDatabase)
                    {
                        if (!Directory.Exists(directoryTo + $@"\{item.Value}\"))
                        {
                            Directory.CreateDirectory(directoryTo + $@"\{item.Value}\");
                        }

                        if (file.Name.Substring(0, 44) == item.Key)
                        {
                            File.Copy(file.FullName, directoryTo + $@"\{item.Value}\{file.Name}", true);
                            break;
                        }
                    }

                    main.progressBar.BeginInvoke((MethodInvoker)(() => incrementProgressBar()));
                }
            });

        }
    }
}
