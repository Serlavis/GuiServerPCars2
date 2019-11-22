using System;
namespace GuiServerPCars2V2._0
{
    class DataLoad : IDisposable
    {
        readonly ValuesLoad valuesLoad = new ValuesLoad();

        public void Data_Load()
        {
            if (Form1.serverNumber == 1)
            {
                valuesLoad.Loader_Server1_Cfg();
                valuesLoad.Loader_Server1_Races_Rotate();
            }
            else if (Form1.serverNumber == 2)
            {
                valuesLoad.Loader_Server2_Cfg();
                valuesLoad.Loader_Server2_Races_Rotate();
            }
            else if (Form1.serverNumber == 3)
            {
                valuesLoad.Loader_Server3_Cfg();
                valuesLoad.Loader_Server3_Races_Rotate();
            }
            else if (Form1.serverNumber == 4)
            {
                valuesLoad.Loader_Server4_Cfg();
                valuesLoad.Loader_Server4_Races_Rotate();
            }
            else if (Form1.serverNumber == 5)
            {
                valuesLoad.Loader_Server5_Cfg();
                valuesLoad.Loader_Server5_Races_Rotate();
            }
            else if (Form1.serverNumber == 6)
            {
                valuesLoad.Loader_Server6_Cfg();
                valuesLoad.Loader_Server6_Races_Rotate();
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
