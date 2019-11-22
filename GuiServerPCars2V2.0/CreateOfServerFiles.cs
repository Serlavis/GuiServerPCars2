using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;

namespace GuiServerPCars2V2._0
{

    class CreateOfServerFiles : IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public void EditServerFiles()
        {
            //HideProgressBar();

            Form3.dialWindow.progressBar.Value = 0;
            using (DataBackup dataBackup = new DataBackup())
            {
                dataBackup.Data_Backup();
                Form3.dialWindow.progressBar.PerformStep();
            }

            using (CreateCfgFile createCfgFile = new CreateCfgFile())
            {
                createCfgFile.EditOrCreateFileCfg();
                Form3.dialWindow.progressBar.PerformStep();

            }
            using (CreateRotateFile createRotateFile = new CreateRotateFile())
            {
                createRotateFile.EditOrCreateFileRotate();
                Form3.dialWindow.progressBar.PerformStep();
            }

        }

    }

}

