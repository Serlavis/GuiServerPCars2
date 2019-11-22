using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Configuration;

namespace GuiServerPCars2V2._0
{
    class LocateFolder
    {
        /// <summary>
        /// this class set the location of a folder
        /// </summary>     

        public string folderLocation = "";
        public void Choice_Folder()
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    folderLocation = folderBrowserDialog.SelectedPath;
                }
                folderBrowserDialog.Dispose();
            }
        }


    }
}
