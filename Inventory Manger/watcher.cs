using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Manger
{
    internal class watcher
    {
        string s;
        FileSystemWatcher watcherr;
        public watcher(string path) {
            watcherr = new FileSystemWatcher(path);
            watcherr.Path = path;
            /* Watch for changes in LastAccess and LastWrite times, and 
               the renaming of files or directories. */
            watcherr.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
               | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            // Only watch text files.
            watcherr.Filter = "*.xlsx";

        }
        public void createFileWatcher()
        {
            watcherr.Changed += new FileSystemEventHandler(OnChanged);
            watcherr.Created += new FileSystemEventHandler(OnChanged);
            watcherr.Deleted += new FileSystemEventHandler(OnChanged);
        }
        public static void OnChanged(object source, FileSystemEventArgs e)
        {

        }
    }
}
