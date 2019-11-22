using System;
namespace GuiServerPCars2V2._0
{
    class DataBackup : IDisposable
    {
        /// <summary>
        /// Verification of the server number used and use of the adapted backup method
        /// </summary>
        
        public void Data_Backup()
        {
            ValuesSave valuesSave = new ValuesSave();

            if (Form1.serverNumber == 1)
            {
                valuesSave.Save_Server1_Cfg();
                valuesSave.Save_Server1_Races_Rotate();
            }
            else if (Form1.serverNumber == 2)
            {
                valuesSave.Save_Server2_Cfg();
                valuesSave.Save_Server2_Races_Rotate();
            }
            else if (Form1.serverNumber == 3)
            {
                valuesSave.Save_Server3_Cfg();
                valuesSave.Save_Server3_Races_Rotate();
            }
            else if (Form1.serverNumber == 4)
            {
                valuesSave.Save_Server4_Cfg();
                valuesSave.Save_Server4_Races_Rotate();
            }
            else if (Form1.serverNumber == 5)
            {
                valuesSave.Save_Server5_Cfg();
                valuesSave.Save_Server5_Races_Rotate();
            }
            else if (Form1.serverNumber == 6)
            {
                valuesSave.Save_Server6_Cfg();
                valuesSave.Save_Server6_Races_Rotate();
            }
            
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
