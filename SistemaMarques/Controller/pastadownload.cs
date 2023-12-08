using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMarques.Controller
{
    internal class pastadownload
    {

         public string GetDownloadsPath()
        {
            string downloadsPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            downloadsPath = System.IO.Path.Combine(downloadsPath, "Downloads");
            return downloadsPath;
        }
    }
}
