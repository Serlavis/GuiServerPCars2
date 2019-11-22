using System.Linq;

namespace GuiServerPCars2V2._0
{
    class NumberOfRotate
    {

        public void Define_GridSize()
        {

            if (Form2.mainWindow.CbBox_NumerOfRace.Text == "1")
            {
                
                Form2.mainWindow.TxtBx_GridSize.Text = Form2.mainWindow.TxtBx_Race1MaxCars.Text;
                Form2.mainWindow.TxtBx_NumberOfDrivers.Text = Form2.mainWindow.TxtBx_Race1MaxCars.Text;
                
            }
            else if (Form2.mainWindow.CbBox_NumerOfRace.Text == "2")
            {
                
                int value1 = int.Parse(Form2.mainWindow.TxtBx_Race1MaxCars.Text);
                int value2 = int.Parse(Form2.mainWindow.TxtBx_Race2MaxCars.Text);
                int[] array = new int[] { value1, value2 };
                int minValue = array.Min();
                string result = minValue.ToString();
                Form2.mainWindow.TxtBx_GridSize.Text = result;
                Form2.mainWindow.TxtBx_NumberOfDrivers.Text = result;
            }
            else if (Form2.mainWindow.CbBox_NumerOfRace.Text == "3")
            {
                
                int value1 = int.Parse(Form2.mainWindow.TxtBx_Race1MaxCars.Text);
                int value2 = int.Parse(Form2.mainWindow.TxtBx_Race2MaxCars.Text);
                int value3 = int.Parse(Form2.mainWindow.TxtBx_Race3MaxCars.Text);
                int[] array = new int[] { value1, value2, value3 };
                int minValue = array.Min();
                string result = minValue.ToString();
                Form2.mainWindow.TxtBx_GridSize.Text = result;
                Form2.mainWindow.TxtBx_NumberOfDrivers.Text = result;
            }
            else if (Form2.mainWindow.CbBox_NumerOfRace.Text == "4")
            {
                
                int value1 = int.Parse(Form2.mainWindow.TxtBx_Race1MaxCars.Text);
                int value2 = int.Parse(Form2.mainWindow.TxtBx_Race2MaxCars.Text);
                int value3 = int.Parse(Form2.mainWindow.TxtBx_Race3MaxCars.Text);
                int value4 = int.Parse(Form2.mainWindow.TxtBx_Race4MaxCars.Text);
                int[] array = new int[] { value1, value2, value3, value4 };
                int minValue = array.Min();
                string result = minValue.ToString();
                Form2.mainWindow.TxtBx_GridSize.Text = result;
                Form2.mainWindow.TxtBx_NumberOfDrivers.Text = result;
            }
            else if (Form2.mainWindow.CbBox_NumerOfRace.Text == "5")
            {
                
                int value1 = int.Parse(Form2.mainWindow.TxtBx_Race1MaxCars.Text);
                int value2 = int.Parse(Form2.mainWindow.TxtBx_Race2MaxCars.Text);
                int value3 = int.Parse(Form2.mainWindow.TxtBx_Race3MaxCars.Text);
                int value4 = int.Parse(Form2.mainWindow.TxtBx_Race4MaxCars.Text);
                int value5 = int.Parse(Form2.mainWindow.TxtBx_Race5MaxCars.Text);
                int[] array = new int[] { value1, value2, value3, value4, value5 };
                int minValue = array.Min();
                string result = minValue.ToString();
                Form2.mainWindow.TxtBx_GridSize.Text = result;
                Form2.mainWindow.TxtBx_NumberOfDrivers.Text = result;
            }
            else if (Form2.mainWindow.CbBox_NumerOfRace.Text == "6")
            {
                
                int value1 = int.Parse(Form2.mainWindow.TxtBx_Race1MaxCars.Text);
                int value2 = int.Parse(Form2.mainWindow.TxtBx_Race2MaxCars.Text);
                int value3 = int.Parse(Form2.mainWindow.TxtBx_Race3MaxCars.Text);
                int value4 = int.Parse(Form2.mainWindow.TxtBx_Race4MaxCars.Text);
                int value5 = int.Parse(Form2.mainWindow.TxtBx_Race5MaxCars.Text);
                int value6 = int.Parse(Form2.mainWindow.TxtBx_Race6MaxCars.Text);
                int[] array = new int[] { value1, value2, value3, value4, value5, value6 };
                int minValue = array.Min();
                string result = minValue.ToString();
                Form2.mainWindow.TxtBx_GridSize.Text = result;
                Form2.mainWindow.TxtBx_NumberOfDrivers.Text = result;
            }
            else if (Form2.mainWindow.CbBox_NumerOfRace.Text == "7")
            {
                
                int value1 = int.Parse(Form2.mainWindow.TxtBx_Race1MaxCars.Text);
                int value2 = int.Parse(Form2.mainWindow.TxtBx_Race2MaxCars.Text);
                int value3 = int.Parse(Form2.mainWindow.TxtBx_Race3MaxCars.Text);
                int value4 = int.Parse(Form2.mainWindow.TxtBx_Race4MaxCars.Text);
                int value5 = int.Parse(Form2.mainWindow.TxtBx_Race5MaxCars.Text);
                int value6 = int.Parse(Form2.mainWindow.TxtBx_Race6MaxCars.Text);
                int value7 = int.Parse(Form2.mainWindow.TxtBx_Race7MaxCars.Text);
                int[] array = new int[] { value1, value2, value3, value4, value5, value6, value7 };
                int minValue = array.Min();
                string result = minValue.ToString();
                Form2.mainWindow.TxtBx_GridSize.Text = result;
                Form2.mainWindow.TxtBx_NumberOfDrivers.Text = result;
            }
            else if (Form2.mainWindow.CbBox_NumerOfRace.Text == "8")
            {
                
                int value1 = int.Parse(Form2.mainWindow.TxtBx_Race1MaxCars.Text);
                int value2 = int.Parse(Form2.mainWindow.TxtBx_Race2MaxCars.Text);
                int value3 = int.Parse(Form2.mainWindow.TxtBx_Race3MaxCars.Text);
                int value4 = int.Parse(Form2.mainWindow.TxtBx_Race4MaxCars.Text);
                int value5 = int.Parse(Form2.mainWindow.TxtBx_Race5MaxCars.Text);
                int value6 = int.Parse(Form2.mainWindow.TxtBx_Race6MaxCars.Text);
                int value7 = int.Parse(Form2.mainWindow.TxtBx_Race7MaxCars.Text);
                int value8 = int.Parse(Form2.mainWindow.TxtBx_Race8MaxCars.Text);
                int[] array = new int[] { value1, value2, value3, value4, value5, value6, value7, value8 };
                int minValue = array.Min();
                string result = minValue.ToString();
                Form2.mainWindow.TxtBx_GridSize.Text = result;
                Form2.mainWindow.TxtBx_NumberOfDrivers.Text = result;
               
            }

            
        }

        public void NumberOfRaces()
        {
            if (Form2.mainWindow.CbBox_NumerOfRace.Text == "1")
            {
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage2);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage3);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage4);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage5);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage6);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage7);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage8);
            }
            else if (Form2.mainWindow.CbBox_NumerOfRace.Text == "2")
            {
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage2);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage3);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage4);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage5);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage6);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage7);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage8);
                Form2.mainWindow.TabControl.TabPages.Add(Form2.mainWindow.tabPage2);
            }
            else if (Form2.mainWindow.CbBox_NumerOfRace.Text == "3")
            {
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage2);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage3);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage4);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage5);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage6);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage7);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage8);
                Form2.mainWindow.TabControl.TabPages.Add(Form2.mainWindow.tabPage2);
                Form2.mainWindow.TabControl.TabPages.Add(Form2.mainWindow.tabPage3);
            }
            else if (Form2.mainWindow.CbBox_NumerOfRace.Text == "4")
            {
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage2);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage3);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage4);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage5);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage6);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage7);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage8);
                Form2.mainWindow.TabControl.TabPages.Add(Form2.mainWindow.tabPage2);
                Form2.mainWindow.TabControl.TabPages.Add(Form2.mainWindow.tabPage3);
                Form2.mainWindow.TabControl.TabPages.Add(Form2.mainWindow.tabPage4);
            }
            else if (Form2.mainWindow.CbBox_NumerOfRace.Text == "5")
            {
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage2);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage3);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage4);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage5);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage6);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage7);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage8);
                Form2.mainWindow.TabControl.TabPages.Add(Form2.mainWindow.tabPage2);
                Form2.mainWindow.TabControl.TabPages.Add(Form2.mainWindow.tabPage3);
                Form2.mainWindow.TabControl.TabPages.Add(Form2.mainWindow.tabPage4);
                Form2.mainWindow.TabControl.TabPages.Add(Form2.mainWindow.tabPage5);
            }
            else if (Form2.mainWindow.CbBox_NumerOfRace.Text == "6")
            {
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage2);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage3);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage4);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage5);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage6);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage7);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage8);
                Form2.mainWindow.TabControl.TabPages.Add(Form2.mainWindow.tabPage2);
                Form2.mainWindow.TabControl.TabPages.Add(Form2.mainWindow.tabPage3);
                Form2.mainWindow.TabControl.TabPages.Add(Form2.mainWindow.tabPage4);
                Form2.mainWindow.TabControl.TabPages.Add(Form2.mainWindow.tabPage5);
                Form2.mainWindow.TabControl.TabPages.Add(Form2.mainWindow.tabPage6);
            }
            else if (Form2.mainWindow.CbBox_NumerOfRace.Text == "7")
            {

                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage2);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage3);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage4);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage5);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage6);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage7);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage8);
                Form2.mainWindow.TabControl.TabPages.Add(Form2.mainWindow.tabPage2);
                Form2.mainWindow.TabControl.TabPages.Add(Form2.mainWindow.tabPage3);
                Form2.mainWindow.TabControl.TabPages.Add(Form2.mainWindow.tabPage4);
                Form2.mainWindow.TabControl.TabPages.Add(Form2.mainWindow.tabPage5);
                Form2.mainWindow.TabControl.TabPages.Add(Form2.mainWindow.tabPage6);
                Form2.mainWindow.TabControl.TabPages.Add(Form2.mainWindow.tabPage7);
            }
            else if (Form2.mainWindow.CbBox_NumerOfRace.Text == "8")
            {

                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage2);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage3);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage4);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage5);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage6);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage7);
                Form2.mainWindow.TabControl.TabPages.Remove(Form2.mainWindow.tabPage8);
                Form2.mainWindow.TabControl.TabPages.Add(Form2.mainWindow.tabPage2);
                Form2.mainWindow.TabControl.TabPages.Add(Form2.mainWindow.tabPage3);
                Form2.mainWindow.TabControl.TabPages.Add(Form2.mainWindow.tabPage4);
                Form2.mainWindow.TabControl.TabPages.Add(Form2.mainWindow.tabPage5);
                Form2.mainWindow.TabControl.TabPages.Add(Form2.mainWindow.tabPage6);
                Form2.mainWindow.TabControl.TabPages.Add(Form2.mainWindow.tabPage7);
                Form2.mainWindow.TabControl.TabPages.Add(Form2.mainWindow.tabPage8);
            }
        }
    }
}

