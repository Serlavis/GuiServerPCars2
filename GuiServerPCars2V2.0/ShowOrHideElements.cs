using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiServerPCars2V2._0
{
    class ShowOrHideElements
    {

        //Section For class Or Unique Car
        public void ShowOrHideComboBoxClassRace1()
        {

            if (Form2.mainWindow.CbBox_Race1ClassSlots.SelectedIndex == 0)
            {
                Form2.mainWindow.CbBox_Race1Class2.Visible = false;
                Form2.mainWindow.CbBox_Race1Class3.Visible = false;
                Form2.mainWindow.CbBox_Race1Class4.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_Race1ClassSlots.SelectedIndex == 1)
            {
                Form2.mainWindow.CbBox_Race1Class1.Visible = true;
                Form2.mainWindow.CbBox_Race1Class2.Visible = true;
                Form2.mainWindow.CbBox_Race1Class3.Visible = false;
                Form2.mainWindow.CbBox_Race1Class4.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_Race1ClassSlots.SelectedIndex == 2)
            {
                Form2.mainWindow.CbBox_Race1Class1.Visible = true;
                Form2.mainWindow.CbBox_Race1Class2.Visible = true;
                Form2.mainWindow.CbBox_Race1Class3.Visible = true;
                Form2.mainWindow.CbBox_Race1Class4.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_Race1ClassSlots.SelectedIndex == 3)
            {
                Form2.mainWindow.CbBox_Race1Class1.Visible = true;
                Form2.mainWindow.CbBox_Race1Class2.Visible = true;
                Form2.mainWindow.CbBox_Race1Class3.Visible = true;
                Form2.mainWindow.CbBox_Race1Class4.Visible = true;
            }

        }


        public void ShowOrHideComboBoxClassRace2()
        {
            if (Form2.mainWindow.CbBox_Race2ClassSlots.SelectedIndex == 0)
            {
                Form2.mainWindow.CbBox_Race2Class2.Visible = false;
                Form2.mainWindow.CbBox_Race2Class3.Visible = false;
                Form2.mainWindow.CbBox_Race2Class4.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_Race2ClassSlots.SelectedIndex == 1)
            {
                Form2.mainWindow.CbBox_Race2Class1.Visible = true;
                Form2.mainWindow.CbBox_Race2Class2.Visible = true;
                Form2.mainWindow.CbBox_Race2Class3.Visible = false;
                Form2.mainWindow.CbBox_Race2Class4.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_Race2ClassSlots.SelectedIndex == 2)
            {
                Form2.mainWindow.CbBox_Race2Class1.Visible = true;
                Form2.mainWindow.CbBox_Race2Class2.Visible = true;
                Form2.mainWindow.CbBox_Race2Class3.Visible = true;
                Form2.mainWindow.CbBox_Race2Class4.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_Race2ClassSlots.SelectedIndex == 3)
            {
                Form2.mainWindow.CbBox_Race2Class1.Visible = true;
                Form2.mainWindow.CbBox_Race2Class2.Visible = true;
                Form2.mainWindow.CbBox_Race2Class3.Visible = true;
                Form2.mainWindow.CbBox_Race2Class4.Visible = true;
            }

        }

        public void ShowOrHideComboBoxClassRace3()
        {
            if (Form2.mainWindow.CbBox_Race3ClassSlots.SelectedIndex == 0)
            {
                Form2.mainWindow.CbBox_Race3Class2.Visible = false;
                Form2.mainWindow.CbBox_Race3Class3.Visible = false;
                Form2.mainWindow.CbBox_Race3Class4.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_Race3ClassSlots.SelectedIndex == 1)
            {
                Form2.mainWindow.CbBox_Race3Class1.Visible = true;
                Form2.mainWindow.CbBox_Race3Class2.Visible = true;
                Form2.mainWindow.CbBox_Race3Class3.Visible = false;
                Form2.mainWindow.CbBox_Race3Class4.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_Race3ClassSlots.SelectedIndex == 2)
            {
                Form2.mainWindow.CbBox_Race3Class1.Visible = true;
                Form2.mainWindow.CbBox_Race3Class2.Visible = true;
                Form2.mainWindow.CbBox_Race3Class3.Visible = true;
                Form2.mainWindow.CbBox_Race3Class4.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_Race3ClassSlots.SelectedIndex == 3)
            {
                Form2.mainWindow.CbBox_Race3Class1.Visible = true;
                Form2.mainWindow.CbBox_Race3Class2.Visible = true;
                Form2.mainWindow.CbBox_Race3Class3.Visible = true;
                Form2.mainWindow.CbBox_Race3Class4.Visible = true;
            }

        }

        public void ShowOrHideComboBoxClassRace4()
        {
            if (Form2.mainWindow.CbBox_Race4ClassSlots.SelectedIndex == 0)
            {
                Form2.mainWindow.CbBox_Race4Class2.Visible = false;
                Form2.mainWindow.CbBox_Race4Class3.Visible = false;
                Form2.mainWindow.CbBox_Race4Class4.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_Race4ClassSlots.SelectedIndex == 1)
            {
                Form2.mainWindow.CbBox_Race4Class1.Visible = true;
                Form2.mainWindow.CbBox_Race4Class2.Visible = true;
                Form2.mainWindow.CbBox_Race4Class3.Visible = false;
                Form2.mainWindow.CbBox_Race4Class4.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_Race4ClassSlots.SelectedIndex == 2)
            {
                Form2.mainWindow.CbBox_Race4Class1.Visible = true;
                Form2.mainWindow.CbBox_Race4Class2.Visible = true;
                Form2.mainWindow.CbBox_Race4Class3.Visible = true;
                Form2.mainWindow.CbBox_Race4Class4.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_Race4ClassSlots.SelectedIndex == 3)
            {
                Form2.mainWindow.CbBox_Race4Class1.Visible = true;
                Form2.mainWindow.CbBox_Race4Class2.Visible = true;
                Form2.mainWindow.CbBox_Race4Class3.Visible = true;
                Form2.mainWindow.CbBox_Race4Class4.Visible = true;
            }

        }

        public void ShowOrHideComboBoxClassRace5()
        {
            if (Form2.mainWindow.CbBox_Race5ClassSlots.SelectedIndex == 0)
            {
                Form2.mainWindow.CbBox_Race5Class2.Visible = false;
                Form2.mainWindow.CbBox_Race5Class3.Visible = false;
                Form2.mainWindow.CbBox_Race5Class4.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_Race5ClassSlots.SelectedIndex == 1)
            {
                Form2.mainWindow.CbBox_Race5Class1.Visible = true;
                Form2.mainWindow.CbBox_Race5Class2.Visible = true;
                Form2.mainWindow.CbBox_Race5Class3.Visible = false;
                Form2.mainWindow.CbBox_Race5Class4.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_Race5ClassSlots.SelectedIndex == 2)
            {
                Form2.mainWindow.CbBox_Race5Class1.Visible = true;
                Form2.mainWindow.CbBox_Race5Class2.Visible = true;
                Form2.mainWindow.CbBox_Race5Class3.Visible = true;
                Form2.mainWindow.CbBox_Race5Class4.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_Race5ClassSlots.SelectedIndex == 3)
            {
                Form2.mainWindow.CbBox_Race5Class1.Visible = true;
                Form2.mainWindow.CbBox_Race5Class2.Visible = true;
                Form2.mainWindow.CbBox_Race5Class3.Visible = true;
                Form2.mainWindow.CbBox_Race5Class4.Visible = true;
            }

        }

        public void ShowOrHideComboBoxClassRace6()
        {
            if (Form2.mainWindow.CbBox_Race6ClassSlots.SelectedIndex == 0)
            {
                Form2.mainWindow.CbBox_Race6Class2.Visible = false;
                Form2.mainWindow.CbBox_Race6Class3.Visible = false;
                Form2.mainWindow.CbBox_Race6Class4.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_Race6ClassSlots.SelectedIndex == 1)
            {
                Form2.mainWindow.CbBox_Race6Class1.Visible = true;
                Form2.mainWindow.CbBox_Race6Class2.Visible = true;
                Form2.mainWindow.CbBox_Race6Class3.Visible = false;
                Form2.mainWindow.CbBox_Race6Class4.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_Race6ClassSlots.SelectedIndex == 2)
            {
                Form2.mainWindow.CbBox_Race6Class1.Visible = true;
                Form2.mainWindow.CbBox_Race6Class2.Visible = true;
                Form2.mainWindow.CbBox_Race6Class3.Visible = true;
                Form2.mainWindow.CbBox_Race6Class4.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_Race6ClassSlots.SelectedIndex == 3)
            {
                Form2.mainWindow.CbBox_Race6Class1.Visible = true;
                Form2.mainWindow.CbBox_Race6Class2.Visible = true;
                Form2.mainWindow.CbBox_Race6Class3.Visible = true;
                Form2.mainWindow.CbBox_Race6Class4.Visible = true;
            }

        }

        public void ShowOrHideComboBoxClassRace7()
        {
            if (Form2.mainWindow.CbBox_Race7ClassSlots.SelectedIndex == 0)
            {
                Form2.mainWindow.CbBox_Race7Class2.Visible = false;
                Form2.mainWindow.CbBox_Race7Class3.Visible = false;
                Form2.mainWindow.CbBox_Race7Class4.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_Race7ClassSlots.SelectedIndex == 1)
            {
                Form2.mainWindow.CbBox_Race7Class1.Visible = true;
                Form2.mainWindow.CbBox_Race7Class2.Visible = true;
                Form2.mainWindow.CbBox_Race7Class3.Visible = false;
                Form2.mainWindow.CbBox_Race7Class4.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_Race7ClassSlots.SelectedIndex == 2)
            {
                Form2.mainWindow.CbBox_Race7Class1.Visible = true;
                Form2.mainWindow.CbBox_Race7Class2.Visible = true;
                Form2.mainWindow.CbBox_Race7Class3.Visible = true;
                Form2.mainWindow.CbBox_Race7Class4.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_Race7ClassSlots.SelectedIndex == 3)
            {
                Form2.mainWindow.CbBox_Race7Class1.Visible = true;
                Form2.mainWindow.CbBox_Race7Class2.Visible = true;
                Form2.mainWindow.CbBox_Race7Class3.Visible = true;
                Form2.mainWindow.CbBox_Race7Class4.Visible = true;
            }

        }

        public void ShowOrHideComboBoxClassRace8()
        {
            if (Form2.mainWindow.CbBox_Race8ClassSlots.SelectedIndex == 0)
            {
                Form2.mainWindow.CbBox_Race8Class2.Visible = false;
                Form2.mainWindow.CbBox_Race8Class3.Visible = false;
                Form2.mainWindow.CbBox_Race8Class4.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_Race8ClassSlots.SelectedIndex == 1)
            {
                Form2.mainWindow.CbBox_Race8Class1.Visible = true;
                Form2.mainWindow.CbBox_Race8Class2.Visible = true;
                Form2.mainWindow.CbBox_Race8Class3.Visible = false;
                Form2.mainWindow.CbBox_Race8Class4.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_Race8ClassSlots.SelectedIndex == 2)
            {
                Form2.mainWindow.CbBox_Race8Class1.Visible = true;
                Form2.mainWindow.CbBox_Race8Class2.Visible = true;
                Form2.mainWindow.CbBox_Race8Class3.Visible = true;
                Form2.mainWindow.CbBox_Race8Class4.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_Race8ClassSlots.SelectedIndex == 3)
            {
                Form2.mainWindow.CbBox_Race8Class1.Visible = true;
                Form2.mainWindow.CbBox_Race8Class2.Visible = true;
                Form2.mainWindow.CbBox_Race8Class3.Visible = true;
                Form2.mainWindow.CbBox_Race8Class4.Visible = true;
            }

        }

        //End Section For class Or Unique Car

        // Section for Weather

        public void ShowOrHideComboBoxPracticeWeatherRace1()
        {
            if (Form2.mainWindow.CbBox_PracticeWeatherSlotsRace1.SelectedIndex == 0)
            {
                Form2.mainWindow.CbBox_PracticeWeatherSlot2Race1.Visible = false;
                Form2.mainWindow.CbBox_PracticeWeatherSlot3Race1.Visible = false;
                Form2.mainWindow.CbBox_PracticeWeatherSlot4Race1.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_PracticeWeatherSlotsRace1.SelectedIndex == 1)
            {
                Form2.mainWindow.CbBox_PracticeWeatherSlot2Race1.Visible = true;
                Form2.mainWindow.CbBox_PracticeWeatherSlot3Race1.Visible = false;
                Form2.mainWindow.CbBox_PracticeWeatherSlot4Race1.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_PracticeWeatherSlotsRace1.SelectedIndex == 2)
            {
                Form2.mainWindow.CbBox_PracticeWeatherSlot2Race1.Visible = true;
                Form2.mainWindow.CbBox_PracticeWeatherSlot3Race1.Visible = true;
                Form2.mainWindow.CbBox_PracticeWeatherSlot4Race1.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_PracticeWeatherSlotsRace1.SelectedIndex == 3)
            {
                Form2.mainWindow.CbBox_PracticeWeatherSlot2Race1.Visible = true;
                Form2.mainWindow.CbBox_PracticeWeatherSlot3Race1.Visible = true;
                Form2.mainWindow.CbBox_PracticeWeatherSlot4Race1.Visible = true;
            }
        }

        public void ShowOrHideComboBoxPracticeWeatherRace2()
        {
            if (Form2.mainWindow.CbBox_PracticeWeatherSlotsRace2.SelectedIndex == 0)
            {
                Form2.mainWindow.CbBox_PracticeWeatherSlot2Race2.Visible = false;
                Form2.mainWindow.CbBox_PracticeWeatherSlot3Race2.Visible = false;
                Form2.mainWindow.CbBox_PracticeWeatherSlot4Race2.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_PracticeWeatherSlotsRace2.SelectedIndex == 1)
            {
                Form2.mainWindow.CbBox_PracticeWeatherSlot2Race2.Visible = true;
                Form2.mainWindow.CbBox_PracticeWeatherSlot3Race2.Visible = false;
                Form2.mainWindow.CbBox_PracticeWeatherSlot4Race2.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_PracticeWeatherSlotsRace2.SelectedIndex == 2)
            {
                Form2.mainWindow.CbBox_PracticeWeatherSlot2Race2.Visible = true;
                Form2.mainWindow.CbBox_PracticeWeatherSlot3Race2.Visible = true;
                Form2.mainWindow.CbBox_PracticeWeatherSlot4Race2.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_PracticeWeatherSlotsRace2.SelectedIndex == 3)
            {
                Form2.mainWindow.CbBox_PracticeWeatherSlot2Race2.Visible = true;
                Form2.mainWindow.CbBox_PracticeWeatherSlot3Race2.Visible = true;
                Form2.mainWindow.CbBox_PracticeWeatherSlot4Race2.Visible = true;
            }
        }

        public void ShowOrHideComboBoxPracticeWeatherRace3()
        {
            if (Form2.mainWindow.CbBox_PracticeWeatherSlotsRace3.SelectedIndex == 0)
            {
                Form2.mainWindow.CbBox_PracticeWeatherSlot2Race3.Visible = false;
                Form2.mainWindow.CbBox_PracticeWeatherSlot3Race3.Visible = false;
                Form2.mainWindow.CbBox_PracticeWeatherSlot4Race3.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_PracticeWeatherSlotsRace3.SelectedIndex == 1)
            {
                Form2.mainWindow.CbBox_PracticeWeatherSlot2Race3.Visible = true;
                Form2.mainWindow.CbBox_PracticeWeatherSlot3Race3.Visible = false;
                Form2.mainWindow.CbBox_PracticeWeatherSlot4Race3.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_PracticeWeatherSlotsRace3.SelectedIndex == 2)
            {
                Form2.mainWindow.CbBox_PracticeWeatherSlot2Race3.Visible = true;
                Form2.mainWindow.CbBox_PracticeWeatherSlot3Race3.Visible = true;
                Form2.mainWindow.CbBox_PracticeWeatherSlot4Race3.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_PracticeWeatherSlotsRace3.SelectedIndex == 3)
            {
                Form2.mainWindow.CbBox_PracticeWeatherSlot2Race3.Visible = true;
                Form2.mainWindow.CbBox_PracticeWeatherSlot3Race3.Visible = true;
                Form2.mainWindow.CbBox_PracticeWeatherSlot4Race3.Visible = true;
            }
        }

        public void ShowOrHideComboBoxPracticeWeatherRace4()
        {
            if (Form2.mainWindow.CbBox_PracticeWeatherSlotsRace4.SelectedIndex == 0)
            {
                Form2.mainWindow.CbBox_PracticeWeatherSlot2Race4.Visible = false;
                Form2.mainWindow.CbBox_PracticeWeatherSlot3Race4.Visible = false;
                Form2.mainWindow.CbBox_PracticeWeatherSlot4Race4.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_PracticeWeatherSlotsRace4.SelectedIndex == 1)
            {
                Form2.mainWindow.CbBox_PracticeWeatherSlot2Race4.Visible = true;
                Form2.mainWindow.CbBox_PracticeWeatherSlot3Race4.Visible = false;
                Form2.mainWindow.CbBox_PracticeWeatherSlot4Race4.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_PracticeWeatherSlotsRace4.SelectedIndex == 2)
            {
                Form2.mainWindow.CbBox_PracticeWeatherSlot2Race4.Visible = true;
                Form2.mainWindow.CbBox_PracticeWeatherSlot3Race4.Visible = true;
                Form2.mainWindow.CbBox_PracticeWeatherSlot4Race4.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_PracticeWeatherSlotsRace4.SelectedIndex == 3)
            {
                Form2.mainWindow.CbBox_PracticeWeatherSlot2Race4.Visible = true;
                Form2.mainWindow.CbBox_PracticeWeatherSlot3Race4.Visible = true;
                Form2.mainWindow.CbBox_PracticeWeatherSlot4Race4.Visible = true;
            }
        }

        public void ShowOrHideComboBoxPracticeWeatherRace5()
        {
            if (Form2.mainWindow.CbBox_PracticeWeatherSlotsRace5.SelectedIndex == 0)
            {
                Form2.mainWindow.CbBox_PracticeWeatherSlot2Race5.Visible = false;
                Form2.mainWindow.CbBox_PracticeWeatherSlot3Race5.Visible = false;
                Form2.mainWindow.CbBox_PracticeWeatherSlot4Race5.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_PracticeWeatherSlotsRace5.SelectedIndex == 1)
            {
                Form2.mainWindow.CbBox_PracticeWeatherSlot2Race5.Visible = true;
                Form2.mainWindow.CbBox_PracticeWeatherSlot3Race5.Visible = false;
                Form2.mainWindow.CbBox_PracticeWeatherSlot4Race5.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_PracticeWeatherSlotsRace5.SelectedIndex == 2)
            {
                Form2.mainWindow.CbBox_PracticeWeatherSlot2Race5.Visible = true;
                Form2.mainWindow.CbBox_PracticeWeatherSlot3Race5.Visible = true;
                Form2.mainWindow.CbBox_PracticeWeatherSlot4Race5.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_PracticeWeatherSlotsRace5.SelectedIndex == 3)
            {
                Form2.mainWindow.CbBox_PracticeWeatherSlot2Race5.Visible = true;
                Form2.mainWindow.CbBox_PracticeWeatherSlot3Race5.Visible = true;
                Form2.mainWindow.CbBox_PracticeWeatherSlot4Race5.Visible = true;
            }
        }

        public void ShowOrHideComboBoxPracticeWeatherRace6()
        {
            if (Form2.mainWindow.CbBox_PracticeWeatherSlotsRace6.SelectedIndex == 0)
            {
                Form2.mainWindow.CbBox_PracticeWeatherSlot2Race6.Visible = false;
                Form2.mainWindow.CbBox_PracticeWeatherSlot3Race6.Visible = false;
                Form2.mainWindow.CbBox_PracticeWeatherSlot4Race6.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_PracticeWeatherSlotsRace6.SelectedIndex == 1)
            {
                Form2.mainWindow.CbBox_PracticeWeatherSlot2Race6.Visible = true;
                Form2.mainWindow.CbBox_PracticeWeatherSlot3Race6.Visible = false;
                Form2.mainWindow.CbBox_PracticeWeatherSlot4Race6.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_PracticeWeatherSlotsRace6.SelectedIndex == 2)
            {
                Form2.mainWindow.CbBox_PracticeWeatherSlot2Race6.Visible = true;
                Form2.mainWindow.CbBox_PracticeWeatherSlot3Race6.Visible = true;
                Form2.mainWindow.CbBox_PracticeWeatherSlot4Race6.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_PracticeWeatherSlotsRace6.SelectedIndex == 3)
            {
                Form2.mainWindow.CbBox_PracticeWeatherSlot2Race6.Visible = true;
                Form2.mainWindow.CbBox_PracticeWeatherSlot3Race6.Visible = true;
                Form2.mainWindow.CbBox_PracticeWeatherSlot4Race6.Visible = true;
            }
        }
        public void ShowOrHideComboBoxPracticeWeatherRace7()
        {
            if (Form2.mainWindow.CbBox_PracticeWeatherSlotsRace7.SelectedIndex == 0)
            {
                Form2.mainWindow.CbBox_PracticeWeatherSlot2Race7.Visible = false;
                Form2.mainWindow.CbBox_PracticeWeatherSlot3Race7.Visible = false;
                Form2.mainWindow.CbBox_PracticeWeatherSlot4Race7.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_PracticeWeatherSlotsRace7.SelectedIndex == 1)
            {
                Form2.mainWindow.CbBox_PracticeWeatherSlot2Race7.Visible = true;
                Form2.mainWindow.CbBox_PracticeWeatherSlot3Race7.Visible = false;
                Form2.mainWindow.CbBox_PracticeWeatherSlot4Race7.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_PracticeWeatherSlotsRace7.SelectedIndex == 2)
            {
                Form2.mainWindow.CbBox_PracticeWeatherSlot2Race7.Visible = true;
                Form2.mainWindow.CbBox_PracticeWeatherSlot3Race7.Visible = true;
                Form2.mainWindow.CbBox_PracticeWeatherSlot4Race7.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_PracticeWeatherSlotsRace7.SelectedIndex == 3)
            {
                Form2.mainWindow.CbBox_PracticeWeatherSlot2Race7.Visible = true;
                Form2.mainWindow.CbBox_PracticeWeatherSlot3Race7.Visible = true;
                Form2.mainWindow.CbBox_PracticeWeatherSlot4Race7.Visible = true;
            }
        }

        public void ShowOrHideComboBoxPracticeWeatherRace8()
        {
            if (Form2.mainWindow.CbBox_PracticeWeatherSlotsRace8.SelectedIndex == 0)
            {
                Form2.mainWindow.CbBox_PracticeWeatherSlot2Race8.Visible = false;
                Form2.mainWindow.CbBox_PracticeWeatherSlot3Race8.Visible = false;
                Form2.mainWindow.CbBox_PracticeWeatherSlot4Race8.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_PracticeWeatherSlotsRace8.SelectedIndex == 1)
            {
                Form2.mainWindow.CbBox_PracticeWeatherSlot2Race8.Visible = true;
                Form2.mainWindow.CbBox_PracticeWeatherSlot3Race8.Visible = false;
                Form2.mainWindow.CbBox_PracticeWeatherSlot4Race8.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_PracticeWeatherSlotsRace8.SelectedIndex == 2)
            {
                Form2.mainWindow.CbBox_PracticeWeatherSlot2Race8.Visible = true;
                Form2.mainWindow.CbBox_PracticeWeatherSlot3Race8.Visible = true;
                Form2.mainWindow.CbBox_PracticeWeatherSlot4Race8.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_PracticeWeatherSlotsRace8.SelectedIndex == 3)
            {
                Form2.mainWindow.CbBox_PracticeWeatherSlot2Race8.Visible = true;
                Form2.mainWindow.CbBox_PracticeWeatherSlot3Race8.Visible = true;
                Form2.mainWindow.CbBox_PracticeWeatherSlot4Race8.Visible = true;
            }

        }

        public void ShowOrHideComboBoxQualifWeatherRace1()
        {
            if (Form2.mainWindow.CbBox_QualifWeatherSlotsRace1.SelectedIndex == 0)
            {
                Form2.mainWindow.CbBox_QualifWeatherSlot2Race1.Visible = false;
                Form2.mainWindow.CbBox_QualifWeatherSlot3Race1.Visible = false;
                Form2.mainWindow.CbBox_QualifWeatherSlot4Race1.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_QualifWeatherSlotsRace1.SelectedIndex == 1)
            {
                Form2.mainWindow.CbBox_QualifWeatherSlot2Race1.Visible = true;
                Form2.mainWindow.CbBox_QualifWeatherSlot3Race1.Visible = false;
                Form2.mainWindow.CbBox_QualifWeatherSlot4Race1.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_QualifWeatherSlotsRace1.SelectedIndex == 2)
            {
                Form2.mainWindow.CbBox_QualifWeatherSlot2Race1.Visible = true;
                Form2.mainWindow.CbBox_QualifWeatherSlot3Race1.Visible = true;
                Form2.mainWindow.CbBox_QualifWeatherSlot4Race1.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_QualifWeatherSlotsRace1.SelectedIndex == 3)
            {
                Form2.mainWindow.CbBox_QualifWeatherSlot2Race1.Visible = true;
                Form2.mainWindow.CbBox_QualifWeatherSlot3Race1.Visible = true;
                Form2.mainWindow.CbBox_QualifWeatherSlot4Race1.Visible = true;
            }
        }

        public void ShowOrHideComboBoxQualifWeatherRace2()
        {
            if (Form2.mainWindow.CbBox_QualifWeatherSlotsRace2.SelectedIndex == 0)
            {
                Form2.mainWindow.CbBox_QualifWeatherSlot2Race2.Visible = false;
                Form2.mainWindow.CbBox_QualifWeatherSlot3Race2.Visible = false;
                Form2.mainWindow.CbBox_QualifWeatherSlot4Race2.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_QualifWeatherSlotsRace2.SelectedIndex == 1)
            {
                Form2.mainWindow.CbBox_QualifWeatherSlot2Race2.Visible = true;
                Form2.mainWindow.CbBox_QualifWeatherSlot3Race2.Visible = false;
                Form2.mainWindow.CbBox_QualifWeatherSlot4Race2.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_QualifWeatherSlotsRace2.SelectedIndex == 2)
            {
                Form2.mainWindow.CbBox_QualifWeatherSlot2Race2.Visible = true;
                Form2.mainWindow.CbBox_QualifWeatherSlot3Race2.Visible = true;
                Form2.mainWindow.CbBox_QualifWeatherSlot4Race2.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_QualifWeatherSlotsRace2.SelectedIndex == 3)
            {
                Form2.mainWindow.CbBox_QualifWeatherSlot2Race2.Visible = true;
                Form2.mainWindow.CbBox_QualifWeatherSlot3Race2.Visible = true;
                Form2.mainWindow.CbBox_QualifWeatherSlot4Race2.Visible = true;
            }
        }

        public void ShowOrHideComboBoxQualifWeatherRace3()
        {
            if (Form2.mainWindow.CbBox_QualifWeatherSlotsRace3.SelectedIndex == 0)
            {
                Form2.mainWindow.CbBox_QualifWeatherSlot2Race3.Visible = false;
                Form2.mainWindow.CbBox_QualifWeatherSlot3Race3.Visible = false;
                Form2.mainWindow.CbBox_QualifWeatherSlot4Race3.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_QualifWeatherSlotsRace3.SelectedIndex == 1)
            {
                Form2.mainWindow.CbBox_QualifWeatherSlot2Race3.Visible = true;
                Form2.mainWindow.CbBox_QualifWeatherSlot3Race3.Visible = false;
                Form2.mainWindow.CbBox_QualifWeatherSlot4Race3.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_QualifWeatherSlotsRace3.SelectedIndex == 2)
            {
                Form2.mainWindow.CbBox_QualifWeatherSlot2Race3.Visible = true;
                Form2.mainWindow.CbBox_QualifWeatherSlot3Race3.Visible = true;
                Form2.mainWindow.CbBox_QualifWeatherSlot4Race3.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_QualifWeatherSlotsRace3.SelectedIndex == 3)
            {
                Form2.mainWindow.CbBox_QualifWeatherSlot2Race3.Visible = true;
                Form2.mainWindow.CbBox_QualifWeatherSlot3Race3.Visible = true;
                Form2.mainWindow.CbBox_QualifWeatherSlot4Race3.Visible = true;
            }
        }
        public void ShowOrHideComboBoxQualifWeatherRace4()
        {
            if (Form2.mainWindow.CbBox_QualifWeatherSlotsRace4.SelectedIndex == 0)
            {
                Form2.mainWindow.CbBox_QualifWeatherSlot2Race4.Visible = false;
                Form2.mainWindow.CbBox_QualifWeatherSlot3Race4.Visible = false;
                Form2.mainWindow.CbBox_QualifWeatherSlot4Race4.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_QualifWeatherSlotsRace4.SelectedIndex == 1)
            {
                Form2.mainWindow.CbBox_QualifWeatherSlot2Race4.Visible = true;
                Form2.mainWindow.CbBox_QualifWeatherSlot3Race4.Visible = false;
                Form2.mainWindow.CbBox_QualifWeatherSlot4Race4.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_QualifWeatherSlotsRace4.SelectedIndex == 2)
            {
                Form2.mainWindow.CbBox_QualifWeatherSlot2Race4.Visible = true;
                Form2.mainWindow.CbBox_QualifWeatherSlot3Race4.Visible = true;
                Form2.mainWindow.CbBox_QualifWeatherSlot4Race4.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_QualifWeatherSlotsRace4.SelectedIndex == 3)
            {
                Form2.mainWindow.CbBox_QualifWeatherSlot2Race4.Visible = true;
                Form2.mainWindow.CbBox_QualifWeatherSlot3Race4.Visible = true;
                Form2.mainWindow.CbBox_QualifWeatherSlot4Race4.Visible = true;
            }
        }

        public void ShowOrHideComboBoxQualifWeatherRace5()
        {
            if (Form2.mainWindow.CbBox_QualifWeatherSlotsRace5.SelectedIndex == 0)
            {
                Form2.mainWindow.CbBox_QualifWeatherSlot2Race5.Visible = false;
                Form2.mainWindow.CbBox_QualifWeatherSlot3Race5.Visible = false;
                Form2.mainWindow.CbBox_QualifWeatherSlot4Race5.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_QualifWeatherSlotsRace5.SelectedIndex == 1)
            {
                Form2.mainWindow.CbBox_QualifWeatherSlot2Race5.Visible = true;
                Form2.mainWindow.CbBox_QualifWeatherSlot3Race5.Visible = false;
                Form2.mainWindow.CbBox_QualifWeatherSlot4Race5.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_QualifWeatherSlotsRace5.SelectedIndex == 2)
            {
                Form2.mainWindow.CbBox_QualifWeatherSlot2Race5.Visible = true;
                Form2.mainWindow.CbBox_QualifWeatherSlot3Race5.Visible = true;
                Form2.mainWindow.CbBox_QualifWeatherSlot4Race5.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_QualifWeatherSlotsRace5.SelectedIndex == 3)
            {
                Form2.mainWindow.CbBox_QualifWeatherSlot2Race5.Visible = true;
                Form2.mainWindow.CbBox_QualifWeatherSlot3Race5.Visible = true;
                Form2.mainWindow.CbBox_QualifWeatherSlot4Race5.Visible = true;
            }
        }

        public void ShowOrHideComboBoxQualifWeatherRace6()
        {
            if (Form2.mainWindow.CbBox_QualifWeatherSlotsRace6.SelectedIndex == 0)
            {
                Form2.mainWindow.CbBox_QualifWeatherSlot2Race6.Visible = false;
                Form2.mainWindow.CbBox_QualifWeatherSlot3Race6.Visible = false;
                Form2.mainWindow.CbBox_QualifWeatherSlot4Race6.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_QualifWeatherSlotsRace6.SelectedIndex == 1)
            {
                Form2.mainWindow.CbBox_QualifWeatherSlot2Race6.Visible = true;
                Form2.mainWindow.CbBox_QualifWeatherSlot3Race6.Visible = false;
                Form2.mainWindow.CbBox_QualifWeatherSlot4Race6.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_QualifWeatherSlotsRace6.SelectedIndex == 2)
            {
                Form2.mainWindow.CbBox_QualifWeatherSlot2Race6.Visible = true;
                Form2.mainWindow.CbBox_QualifWeatherSlot3Race6.Visible = true;
                Form2.mainWindow.CbBox_QualifWeatherSlot4Race6.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_QualifWeatherSlotsRace6.SelectedIndex == 3)
            {
                Form2.mainWindow.CbBox_QualifWeatherSlot2Race6.Visible = true;
                Form2.mainWindow.CbBox_QualifWeatherSlot3Race6.Visible = true;
                Form2.mainWindow.CbBox_QualifWeatherSlot4Race6.Visible = true;
            }
        }

        public void ShowOrHideComboBoxQualifWeatherRace7()
        {
            if (Form2.mainWindow.CbBox_QualifWeatherSlotsRace7.SelectedIndex == 0)
            {
                Form2.mainWindow.CbBox_QualifWeatherSlot2Race7.Visible = false;
                Form2.mainWindow.CbBox_QualifWeatherSlot3Race7.Visible = false;
                Form2.mainWindow.CbBox_QualifWeatherSlot4Race7.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_QualifWeatherSlotsRace7.SelectedIndex == 1)
            {
                Form2.mainWindow.CbBox_QualifWeatherSlot2Race7.Visible = true;
                Form2.mainWindow.CbBox_QualifWeatherSlot3Race7.Visible = false;
                Form2.mainWindow.CbBox_QualifWeatherSlot4Race7.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_QualifWeatherSlotsRace7.SelectedIndex == 2)
            {
                Form2.mainWindow.CbBox_QualifWeatherSlot2Race7.Visible = true;
                Form2.mainWindow.CbBox_QualifWeatherSlot3Race7.Visible = true;
                Form2.mainWindow.CbBox_QualifWeatherSlot4Race7.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_QualifWeatherSlotsRace7.SelectedIndex == 3)
            {
                Form2.mainWindow.CbBox_QualifWeatherSlot2Race7.Visible = true;
                Form2.mainWindow.CbBox_QualifWeatherSlot3Race7.Visible = true;
                Form2.mainWindow.CbBox_QualifWeatherSlot4Race7.Visible = true;
            }
        }

        public void ShowOrHideComboBoxQualifWeatherRace8()
        {
            if (Form2.mainWindow.CbBox_QualifWeatherSlotsRace8.SelectedIndex == 0)
            {
                Form2.mainWindow.CbBox_QualifWeatherSlot2Race8.Visible = false;
                Form2.mainWindow.CbBox_QualifWeatherSlot3Race8.Visible = false;
                Form2.mainWindow.CbBox_QualifWeatherSlot4Race8.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_QualifWeatherSlotsRace8.SelectedIndex == 1)
            {
                Form2.mainWindow.CbBox_QualifWeatherSlot2Race8.Visible = true;
                Form2.mainWindow.CbBox_QualifWeatherSlot3Race8.Visible = false;
                Form2.mainWindow.CbBox_QualifWeatherSlot4Race8.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_QualifWeatherSlotsRace8.SelectedIndex == 2)
            {
                Form2.mainWindow.CbBox_QualifWeatherSlot2Race8.Visible = true;
                Form2.mainWindow.CbBox_QualifWeatherSlot3Race8.Visible = true;
                Form2.mainWindow.CbBox_QualifWeatherSlot4Race8.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_QualifWeatherSlotsRace8.SelectedIndex == 3)
            {
                Form2.mainWindow.CbBox_QualifWeatherSlot2Race8.Visible = true;
                Form2.mainWindow.CbBox_QualifWeatherSlot3Race8.Visible = true;
                Form2.mainWindow.CbBox_QualifWeatherSlot4Race8.Visible = true;
            }
        }
        public void ShowOrHideComboBoxRaceWeatherRace1()
        {
            if (Form2.mainWindow.CbBox_RaceWeatherSlotsRace1.SelectedIndex == 0)
            {
                Form2.mainWindow.CbBox_RaceWeatherSlot2Race1.Visible = false;
                Form2.mainWindow.CbBox_RaceWeatherSlot3Race1.Visible = false;
                Form2.mainWindow.CbBox_RaceWeatherSlot4Race1.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_RaceWeatherSlotsRace1.SelectedIndex == 1)
            {
                Form2.mainWindow.CbBox_RaceWeatherSlot2Race1.Visible = true;
                Form2.mainWindow.CbBox_RaceWeatherSlot3Race1.Visible = false;
                Form2.mainWindow.CbBox_RaceWeatherSlot4Race1.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_RaceWeatherSlotsRace1.SelectedIndex == 2)
            {
                Form2.mainWindow.CbBox_RaceWeatherSlot2Race1.Visible = true;
                Form2.mainWindow.CbBox_RaceWeatherSlot3Race1.Visible = true;
                Form2.mainWindow.CbBox_RaceWeatherSlot4Race1.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_RaceWeatherSlotsRace1.SelectedIndex == 3)
            {
                Form2.mainWindow.CbBox_RaceWeatherSlot2Race1.Visible = true;
                Form2.mainWindow.CbBox_RaceWeatherSlot3Race1.Visible = true;
                Form2.mainWindow.CbBox_RaceWeatherSlot4Race1.Visible = true;
            }
        }

        public void ShowOrHideComboBoxRaceWeatherRace2()
        {
            if (Form2.mainWindow.CbBox_RaceWeatherSlotsRace2.SelectedIndex == 0)
            {
                Form2.mainWindow.CbBox_RaceWeatherSlot2Race2.Visible = false;
                Form2.mainWindow.CbBox_RaceWeatherSlot3Race2.Visible = false;
                Form2.mainWindow.CbBox_RaceWeatherSlot4Race2.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_RaceWeatherSlotsRace2.SelectedIndex == 1)
            {
                Form2.mainWindow.CbBox_RaceWeatherSlot2Race2.Visible = true;
                Form2.mainWindow.CbBox_RaceWeatherSlot3Race2.Visible = false;
                Form2.mainWindow.CbBox_RaceWeatherSlot4Race2.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_RaceWeatherSlotsRace2.SelectedIndex == 2)
            {
                Form2.mainWindow.CbBox_RaceWeatherSlot2Race2.Visible = true;
                Form2.mainWindow.CbBox_RaceWeatherSlot3Race2.Visible = true;
                Form2.mainWindow.CbBox_RaceWeatherSlot4Race2.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_RaceWeatherSlotsRace2.SelectedIndex == 3)
            {
                Form2.mainWindow.CbBox_RaceWeatherSlot2Race2.Visible = true;
                Form2.mainWindow.CbBox_RaceWeatherSlot3Race2.Visible = true;
                Form2.mainWindow.CbBox_RaceWeatherSlot4Race2.Visible = true;
            }
        }

        public void ShowOrHideComboBoxRaceWeatherRace3()
        {
            if (Form2.mainWindow.CbBox_RaceWeatherSlotsRace3.SelectedIndex == 0)
            {
                Form2.mainWindow.CbBox_RaceWeatherSlot2Race3.Visible = false;
                Form2.mainWindow.CbBox_RaceWeatherSlot3Race3.Visible = false;
                Form2.mainWindow.CbBox_RaceWeatherSlot4Race3.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_RaceWeatherSlotsRace3.SelectedIndex == 1)
            {
                Form2.mainWindow.CbBox_RaceWeatherSlot2Race3.Visible = true;
                Form2.mainWindow.CbBox_RaceWeatherSlot3Race3.Visible = false;
                Form2.mainWindow.CbBox_RaceWeatherSlot4Race3.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_RaceWeatherSlotsRace3.SelectedIndex == 2)
            {
                Form2.mainWindow.CbBox_RaceWeatherSlot2Race3.Visible = true;
                Form2.mainWindow.CbBox_RaceWeatherSlot3Race3.Visible = true;
                Form2.mainWindow.CbBox_RaceWeatherSlot4Race3.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_RaceWeatherSlotsRace3.SelectedIndex == 3)
            {
                Form2.mainWindow.CbBox_RaceWeatherSlot2Race3.Visible = true;
                Form2.mainWindow.CbBox_RaceWeatherSlot3Race3.Visible = true;
                Form2.mainWindow.CbBox_RaceWeatherSlot4Race3.Visible = true;
            }
        }

        public void ShowOrHideComboBoxRaceWeatherRace4()
        {
            if (Form2.mainWindow.CbBox_RaceWeatherSlotsRace4.SelectedIndex == 0)
            {
                Form2.mainWindow.CbBox_RaceWeatherSlot2Race4.Visible = false;
                Form2.mainWindow.CbBox_RaceWeatherSlot3Race4.Visible = false;
                Form2.mainWindow.CbBox_RaceWeatherSlot4Race4.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_RaceWeatherSlotsRace4.SelectedIndex == 1)
            {
                Form2.mainWindow.CbBox_RaceWeatherSlot2Race4.Visible = true;
                Form2.mainWindow.CbBox_RaceWeatherSlot3Race4.Visible = false;
                Form2.mainWindow.CbBox_RaceWeatherSlot4Race4.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_RaceWeatherSlotsRace4.SelectedIndex == 2)
            {
                Form2.mainWindow.CbBox_RaceWeatherSlot2Race4.Visible = true;
                Form2.mainWindow.CbBox_RaceWeatherSlot3Race4.Visible = true;
                Form2.mainWindow.CbBox_RaceWeatherSlot4Race4.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_RaceWeatherSlotsRace4.SelectedIndex == 3)
            {
                Form2.mainWindow.CbBox_RaceWeatherSlot2Race4.Visible = true;
                Form2.mainWindow.CbBox_RaceWeatherSlot3Race4.Visible = true;
                Form2.mainWindow.CbBox_RaceWeatherSlot4Race4.Visible = true;
            }
        }

        public void ShowOrHideComboBoxRaceWeatherRace5()
        {
            if (Form2.mainWindow.CbBox_RaceWeatherSlotsRace5.SelectedIndex == 0)
            {
                Form2.mainWindow.CbBox_RaceWeatherSlot2Race5.Visible = false;
                Form2.mainWindow.CbBox_RaceWeatherSlot3Race5.Visible = false;
                Form2.mainWindow.CbBox_RaceWeatherSlot4Race5.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_RaceWeatherSlotsRace5.SelectedIndex == 1)
            {
                Form2.mainWindow.CbBox_RaceWeatherSlot2Race5.Visible = true;
                Form2.mainWindow.CbBox_RaceWeatherSlot3Race5.Visible = false;
                Form2.mainWindow.CbBox_RaceWeatherSlot4Race5.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_RaceWeatherSlotsRace5.SelectedIndex == 2)
            {
                Form2.mainWindow.CbBox_RaceWeatherSlot2Race5.Visible = true;
                Form2.mainWindow.CbBox_RaceWeatherSlot3Race5.Visible = true;
                Form2.mainWindow.CbBox_RaceWeatherSlot4Race5.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_RaceWeatherSlotsRace5.SelectedIndex == 3)
            {
                Form2.mainWindow.CbBox_RaceWeatherSlot2Race5.Visible = true;
                Form2.mainWindow.CbBox_RaceWeatherSlot3Race5.Visible = true;
                Form2.mainWindow.CbBox_RaceWeatherSlot4Race5.Visible = true;
            }
        }

        public void ShowOrHideComboBoxRaceWeatherRace6()
        {
            if (Form2.mainWindow.CbBox_RaceWeatherSlotsRace6.SelectedIndex == 0)
            {
                Form2.mainWindow.CbBox_RaceWeatherSlot2Race6.Visible = false;
                Form2.mainWindow.CbBox_RaceWeatherSlot3Race6.Visible = false;
                Form2.mainWindow.CbBox_RaceWeatherSlot4Race6.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_RaceWeatherSlotsRace6.SelectedIndex == 1)
            {
                Form2.mainWindow.CbBox_RaceWeatherSlot2Race6.Visible = true;
                Form2.mainWindow.CbBox_RaceWeatherSlot3Race6.Visible = false;
                Form2.mainWindow.CbBox_RaceWeatherSlot4Race6.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_RaceWeatherSlotsRace6.SelectedIndex == 2)
            {
                Form2.mainWindow.CbBox_RaceWeatherSlot2Race6.Visible = true;
                Form2.mainWindow.CbBox_RaceWeatherSlot3Race6.Visible = true;
                Form2.mainWindow.CbBox_RaceWeatherSlot4Race6.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_RaceWeatherSlotsRace6.SelectedIndex == 3)
            {
                Form2.mainWindow.CbBox_RaceWeatherSlot2Race6.Visible = true;
                Form2.mainWindow.CbBox_RaceWeatherSlot3Race6.Visible = true;
                Form2.mainWindow.CbBox_RaceWeatherSlot4Race6.Visible = true;
            }
        }

        public void ShowOrHideComboBoxRaceWeatherRace7()
        {
            if (Form2.mainWindow.CbBox_RaceWeatherSlotsRace7.SelectedIndex == 0)
            {
                Form2.mainWindow.CbBox_RaceWeatherSlot2Race7.Visible = false;
                Form2.mainWindow.CbBox_RaceWeatherSlot3Race7.Visible = false;
                Form2.mainWindow.CbBox_RaceWeatherSlot4Race7.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_RaceWeatherSlotsRace7.SelectedIndex == 1)
            {
                Form2.mainWindow.CbBox_RaceWeatherSlot2Race7.Visible = true;
                Form2.mainWindow.CbBox_RaceWeatherSlot3Race7.Visible = false;
                Form2.mainWindow.CbBox_RaceWeatherSlot4Race7.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_RaceWeatherSlotsRace7.SelectedIndex == 2)
            {
                Form2.mainWindow.CbBox_RaceWeatherSlot2Race7.Visible = true;
                Form2.mainWindow.CbBox_RaceWeatherSlot3Race7.Visible = true;
                Form2.mainWindow.CbBox_RaceWeatherSlot4Race7.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_RaceWeatherSlotsRace7.SelectedIndex == 3)
            {
                Form2.mainWindow.CbBox_RaceWeatherSlot2Race7.Visible = true;
                Form2.mainWindow.CbBox_RaceWeatherSlot3Race7.Visible = true;
                Form2.mainWindow.CbBox_RaceWeatherSlot4Race7.Visible = true;
            }
        }

        public void ShowOrHideComboBoxRaceWeatherRace8()
        {
            if (Form2.mainWindow.CbBox_RaceWeatherSlotsRace8.SelectedIndex == 0)
            {
                Form2.mainWindow.CbBox_RaceWeatherSlot2Race8.Visible = false;
                Form2.mainWindow.CbBox_RaceWeatherSlot3Race8.Visible = false;
                Form2.mainWindow.CbBox_RaceWeatherSlot4Race8.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_RaceWeatherSlotsRace8.SelectedIndex == 1)
            {
                Form2.mainWindow.CbBox_RaceWeatherSlot2Race8.Visible = true;
                Form2.mainWindow.CbBox_RaceWeatherSlot3Race8.Visible = false;
                Form2.mainWindow.CbBox_RaceWeatherSlot4Race8.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_RaceWeatherSlotsRace8.SelectedIndex == 2)
            {
                Form2.mainWindow.CbBox_RaceWeatherSlot2Race8.Visible = true;
                Form2.mainWindow.CbBox_RaceWeatherSlot3Race8.Visible = true;
                Form2.mainWindow.CbBox_RaceWeatherSlot4Race8.Visible = false;
            }
            else if (Form2.mainWindow.CbBox_RaceWeatherSlotsRace8.SelectedIndex == 3)
            {
                Form2.mainWindow.CbBox_RaceWeatherSlot2Race8.Visible = true;
                Form2.mainWindow.CbBox_RaceWeatherSlot3Race8.Visible = true;
                Form2.mainWindow.CbBox_RaceWeatherSlot4Race8.Visible = true;
            }
        }
        //End Section for Weather

        //Section Penalties

        public void ShowOrHideCbBox_Penalties()
        {
            if (Form2.mainWindow.CheckBox_PenaltiesRace1.Checked == false)
            {
                Form2.mainWindow.CbBox_PenaltyTimeRace1.Visible = false;
            }
            else
            {
                Form2.mainWindow.CbBox_PenaltyTimeRace1.Visible = true;
            }

            if (Form2.mainWindow.CheckBox_PenaltiesRace2.Checked == false)
            {
                Form2.mainWindow.CbBox_PenaltyTimeRace2.Visible = false;
            }
            else
            {
                Form2.mainWindow.CbBox_PenaltyTimeRace2.Visible = true;
            }

            if (Form2.mainWindow.CheckBox_PenaltiesRace3.Checked == false)
            {
                Form2.mainWindow.CbBox_PenaltyTimeRace3.Visible = false;
            }
            else
            {
                Form2.mainWindow.CbBox_PenaltyTimeRace3.Visible = true;
            }

            if (Form2.mainWindow.CheckBox_PenaltiesRace4.Checked == false)
            {
                Form2.mainWindow.CbBox_PenaltyTimeRace4.Visible = false;
            }
            else
            {
                Form2.mainWindow.CbBox_PenaltyTimeRace4.Visible = true;
            }

            if (Form2.mainWindow.CheckBox_PenaltiesRace5.Checked == false)
            {
                Form2.mainWindow.CbBox_PenaltyTimeRace5.Visible = false;
            }
            else
            {
                Form2.mainWindow.CbBox_PenaltyTimeRace5.Visible = true;
            }

            if (Form2.mainWindow.CheckBox_PenaltiesRace6.Checked == false)
            {
                Form2.mainWindow.CbBox_PenaltyTimeRace6.Visible = false;
            }
            else
            {
                Form2.mainWindow.CbBox_PenaltyTimeRace6.Visible = true;
            }

            if (Form2.mainWindow.CheckBox_PenaltiesRace7.Checked == false)
            {
                Form2.mainWindow.CbBox_PenaltyTimeRace7.Visible = false;
            }
            else
            {
                Form2.mainWindow.CbBox_PenaltyTimeRace7.Visible = true;
            }

            if (Form2.mainWindow.CheckBox_PenaltiesRace8.Checked == false)
            {
                Form2.mainWindow.CbBox_PenaltyTimeRace8.Visible = false;
            }
            else
            {
                Form2.mainWindow.CbBox_PenaltyTimeRace8.Visible = true;
            }
        }
        //end section of penalties

        //Section For Same Cars and Tracks in all Race.
        public void ApplySameTrackForAllRace()
        {
            if (Form2.mainWindow.CheckBox_SameTrack.Checked == true)
            {
                //I get the value of the index of the combobox of the race 1 and I apply it to the other races and I block the combobox
                Form2.mainWindow.track2 = Form2.mainWindow.CbBox_Race2Tracks.SelectedIndex;
                Form2.mainWindow.CbBox_Race2Tracks.SelectedIndex = Form2.mainWindow.CbBox_Race1Tracks.SelectedIndex;
                Form2.mainWindow.CbBox_Race2Tracks.Enabled = false;
                Form2.mainWindow.track3 = Form2.mainWindow.CbBox_Race3Tracks.SelectedIndex;
                Form2.mainWindow.CbBox_Race3Tracks.SelectedIndex = Form2.mainWindow.CbBox_Race1Tracks.SelectedIndex;
                Form2.mainWindow.CbBox_Race3Tracks.Enabled = false;
                Form2.mainWindow.track4 = Form2.mainWindow.CbBox_Race4Tracks.SelectedIndex;
                Form2.mainWindow.CbBox_Race4Tracks.SelectedIndex = Form2.mainWindow.CbBox_Race1Tracks.SelectedIndex;
                Form2.mainWindow.CbBox_Race4Tracks.Enabled = false;
                Form2.mainWindow.track5 = Form2.mainWindow.CbBox_Race5Tracks.SelectedIndex;
                Form2.mainWindow.CbBox_Race5Tracks.SelectedIndex = Form2.mainWindow.CbBox_Race1Tracks.SelectedIndex;
                Form2.mainWindow.CbBox_Race5Tracks.Enabled = false;
                Form2.mainWindow.track6 = Form2.mainWindow.CbBox_Race6Tracks.SelectedIndex;
                Form2.mainWindow.CbBox_Race6Tracks.SelectedIndex = Form2.mainWindow.CbBox_Race1Tracks.SelectedIndex;
                Form2.mainWindow.CbBox_Race6Tracks.Enabled = false;
                Form2.mainWindow.track7 = Form2.mainWindow.CbBox_Race7Tracks.SelectedIndex;
                Form2.mainWindow.CbBox_Race7Tracks.SelectedIndex = Form2.mainWindow.CbBox_Race1Tracks.SelectedIndex;
                Form2.mainWindow.CbBox_Race7Tracks.Enabled = false;
                Form2.mainWindow.track8 = Form2.mainWindow.CbBox_Race8Tracks.SelectedIndex;
                Form2.mainWindow.CbBox_Race8Tracks.SelectedIndex = Form2.mainWindow.CbBox_Race1Tracks.SelectedIndex;
                Form2.mainWindow.CbBox_Race8Tracks.Enabled = false;
                Form2.mainWindow.TxtBx_Race2TracksID.Text = Form2.mainWindow.TxtBx_Race1TracksID.Text;
                Form2.mainWindow.TxtBx_Race3TracksID.Text = Form2.mainWindow.TxtBx_Race1TracksID.Text;
                Form2.mainWindow.TxtBx_Race4TracksID.Text = Form2.mainWindow.TxtBx_Race1TracksID.Text;
                Form2.mainWindow.TxtBx_Race5TracksID.Text = Form2.mainWindow.TxtBx_Race1TracksID.Text;
                Form2.mainWindow.TxtBx_Race6TracksID.Text = Form2.mainWindow.TxtBx_Race1TracksID.Text;
                Form2.mainWindow.TxtBx_Race7TracksID.Text = Form2.mainWindow.TxtBx_Race1TracksID.Text;
                Form2.mainWindow.TxtBx_Race8TracksID.Text = Form2.mainWindow.TxtBx_Race1TracksID.Text;
            }
            else
            {
                //I release the combobox and give them their initial value
                Form2.mainWindow.CbBox_Race2Tracks.Enabled = true;
                Form2.mainWindow.CbBox_Race2Tracks.SelectedIndex = Form2.mainWindow.track2;
                Form2.mainWindow.CbBox_Race3Tracks.Enabled = true;
                Form2.mainWindow.CbBox_Race3Tracks.SelectedIndex = Form2.mainWindow.track3;
                Form2.mainWindow.CbBox_Race4Tracks.Enabled = true;
                Form2.mainWindow.CbBox_Race4Tracks.SelectedIndex = Form2.mainWindow.track4;
                Form2.mainWindow.CbBox_Race5Tracks.Enabled = true;
                Form2.mainWindow.CbBox_Race5Tracks.SelectedIndex = Form2.mainWindow.track5;
                Form2.mainWindow.CbBox_Race6Tracks.Enabled = true;
                Form2.mainWindow.CbBox_Race6Tracks.SelectedIndex = Form2.mainWindow.track6;
                Form2.mainWindow.CbBox_Race7Tracks.Enabled = true;
                Form2.mainWindow.CbBox_Race7Tracks.SelectedIndex = Form2.mainWindow.track7;
                Form2.mainWindow.CbBox_Race8Tracks.Enabled = true;
                Form2.mainWindow.CbBox_Race8Tracks.SelectedIndex = Form2.mainWindow.track8;
            }
        }

        public void ApplySameCarForAllRaces()
        {
            if (Form2.mainWindow.CheckBox_SameCars.Checked == true)
            {
                // If the same car box is checked I apply the same settings for the other races and I block the controls

                if (Form2.mainWindow.RadioButton_Race1UniqueCar.Checked == true)
                {
                    Form2.mainWindow.CbBox_Race2Cars.SelectedIndex = Form2.mainWindow.CbBox_Race1Cars.SelectedIndex;
                    Form2.mainWindow.CbBox_Race3Cars.SelectedIndex = Form2.mainWindow.CbBox_Race1Cars.SelectedIndex;
                    Form2.mainWindow.CbBox_Race4Cars.SelectedIndex = Form2.mainWindow.CbBox_Race1Cars.SelectedIndex;
                    Form2.mainWindow.CbBox_Race5Cars.SelectedIndex = Form2.mainWindow.CbBox_Race1Cars.SelectedIndex;
                    Form2.mainWindow.CbBox_Race6Cars.SelectedIndex = Form2.mainWindow.CbBox_Race1Cars.SelectedIndex;
                    Form2.mainWindow.CbBox_Race7Cars.SelectedIndex = Form2.mainWindow.CbBox_Race1Cars.SelectedIndex;
                    Form2.mainWindow.CbBox_Race8Cars.SelectedIndex = Form2.mainWindow.CbBox_Race1Cars.SelectedIndex;

                    Form2.mainWindow.RadioButton_Race2UniqueCar.Checked = Form2.mainWindow.RadioButton_Race1UniqueCar.Checked;
                    Form2.mainWindow.RadioButton_Race3UniqueCar.Checked = Form2.mainWindow.RadioButton_Race1UniqueCar.Checked;
                    Form2.mainWindow.RadioButton_Race4UniqueCar.Checked = Form2.mainWindow.RadioButton_Race1UniqueCar.Checked;
                    Form2.mainWindow.RadioButton_Race5UniqueCar.Checked = Form2.mainWindow.RadioButton_Race1UniqueCar.Checked;
                    Form2.mainWindow.RadioButton_Race6UniqueCar.Checked = Form2.mainWindow.RadioButton_Race1UniqueCar.Checked;
                    Form2.mainWindow.RadioButton_Race7UniqueCar.Checked = Form2.mainWindow.RadioButton_Race1UniqueCar.Checked;
                    Form2.mainWindow.RadioButton_Race8UniqueCar.Checked = Form2.mainWindow.RadioButton_Race1UniqueCar.Checked;

                    Form2.mainWindow.CbBox_Race2Cars.Enabled = false;
                    Form2.mainWindow.CbBox_Race3Cars.Enabled = false;
                    Form2.mainWindow.CbBox_Race4Cars.Enabled = false;
                    Form2.mainWindow.CbBox_Race5Cars.Enabled = false;
                    Form2.mainWindow.CbBox_Race6Cars.Enabled = false;
                    Form2.mainWindow.CbBox_Race7Cars.Enabled = false;
                    Form2.mainWindow.CbBox_Race8Cars.Enabled = false;
                }
                else if (Form2.mainWindow.RadioButton_Race1CarByClass.Checked == true)
                {
                    Form2.mainWindow.CbBox_Race2ClassSlots.SelectedIndex = Form2.mainWindow.CbBox_Race1ClassSlots.SelectedIndex;
                    Form2.mainWindow.CbBox_Race3ClassSlots.SelectedIndex = Form2.mainWindow.CbBox_Race1ClassSlots.SelectedIndex;
                    Form2.mainWindow.CbBox_Race4ClassSlots.SelectedIndex = Form2.mainWindow.CbBox_Race1ClassSlots.SelectedIndex;
                    Form2.mainWindow.CbBox_Race5ClassSlots.SelectedIndex = Form2.mainWindow.CbBox_Race1ClassSlots.SelectedIndex;
                    Form2.mainWindow.CbBox_Race6ClassSlots.SelectedIndex = Form2.mainWindow.CbBox_Race1ClassSlots.SelectedIndex;
                    Form2.mainWindow.CbBox_Race7ClassSlots.SelectedIndex = Form2.mainWindow.CbBox_Race1ClassSlots.SelectedIndex;
                    Form2.mainWindow.CbBox_Race8ClassSlots.SelectedIndex = Form2.mainWindow.CbBox_Race1ClassSlots.SelectedIndex;

                    Form2.mainWindow.CbBox_Race2ClassSlots.Enabled = false;
                    Form2.mainWindow.CbBox_Race3ClassSlots.Enabled = false;
                    Form2.mainWindow.CbBox_Race4ClassSlots.Enabled = false;
                    Form2.mainWindow.CbBox_Race5ClassSlots.Enabled = false;
                    Form2.mainWindow.CbBox_Race6ClassSlots.Enabled = false;
                    Form2.mainWindow.CbBox_Race7ClassSlots.Enabled = false;
                    Form2.mainWindow.CbBox_Race8ClassSlots.Enabled = false;

                    Form2.mainWindow.CbBox_Race2Class1.SelectedIndex = Form2.mainWindow.CbBox_Race1Class1.SelectedIndex;
                    Form2.mainWindow.CbBox_Race3Class1.SelectedIndex = Form2.mainWindow.CbBox_Race1Class1.SelectedIndex;
                    Form2.mainWindow.CbBox_Race4Class1.SelectedIndex = Form2.mainWindow.CbBox_Race1Class1.SelectedIndex;
                    Form2.mainWindow.CbBox_Race5Class1.SelectedIndex = Form2.mainWindow.CbBox_Race1Class1.SelectedIndex;
                    Form2.mainWindow.CbBox_Race6Class1.SelectedIndex = Form2.mainWindow.CbBox_Race1Class1.SelectedIndex;
                    Form2.mainWindow.CbBox_Race7Class1.SelectedIndex = Form2.mainWindow.CbBox_Race1Class1.SelectedIndex;
                    Form2.mainWindow.CbBox_Race8Class1.SelectedIndex = Form2.mainWindow.CbBox_Race1Class1.SelectedIndex;

                    Form2.mainWindow.CbBox_Race2Class1.Enabled = false;
                    Form2.mainWindow.CbBox_Race3Class1.Enabled = false;
                    Form2.mainWindow.CbBox_Race4Class1.Enabled = false;
                    Form2.mainWindow.CbBox_Race5Class1.Enabled = false;
                    Form2.mainWindow.CbBox_Race6Class1.Enabled = false;
                    Form2.mainWindow.CbBox_Race7Class1.Enabled = false;
                    Form2.mainWindow.CbBox_Race8Class1.Enabled = false;

                    Form2.mainWindow.CbBox_Race2Class2.SelectedIndex = Form2.mainWindow.CbBox_Race1Class2.SelectedIndex;
                    Form2.mainWindow.CbBox_Race3Class2.SelectedIndex = Form2.mainWindow.CbBox_Race1Class2.SelectedIndex;
                    Form2.mainWindow.CbBox_Race4Class2.SelectedIndex = Form2.mainWindow.CbBox_Race1Class2.SelectedIndex;
                    Form2.mainWindow.CbBox_Race5Class2.SelectedIndex = Form2.mainWindow.CbBox_Race1Class2.SelectedIndex;
                    Form2.mainWindow.CbBox_Race6Class2.SelectedIndex = Form2.mainWindow.CbBox_Race1Class2.SelectedIndex;
                    Form2.mainWindow.CbBox_Race7Class2.SelectedIndex = Form2.mainWindow.CbBox_Race1Class2.SelectedIndex;
                    Form2.mainWindow.CbBox_Race8Class2.SelectedIndex = Form2.mainWindow.CbBox_Race1Class2.SelectedIndex;

                    Form2.mainWindow.CbBox_Race2Class2.Enabled = false;
                    Form2.mainWindow.CbBox_Race3Class2.Enabled = false;
                    Form2.mainWindow.CbBox_Race4Class2.Enabled = false;
                    Form2.mainWindow.CbBox_Race5Class2.Enabled = false;
                    Form2.mainWindow.CbBox_Race6Class2.Enabled = false;
                    Form2.mainWindow.CbBox_Race7Class2.Enabled = false;
                    Form2.mainWindow.CbBox_Race8Class2.Enabled = false;

                    Form2.mainWindow.CbBox_Race2Class3.SelectedIndex = Form2.mainWindow.CbBox_Race1Class3.SelectedIndex;
                    Form2.mainWindow.CbBox_Race3Class3.SelectedIndex = Form2.mainWindow.CbBox_Race1Class3.SelectedIndex;
                    Form2.mainWindow.CbBox_Race4Class3.SelectedIndex = Form2.mainWindow.CbBox_Race1Class3.SelectedIndex;
                    Form2.mainWindow.CbBox_Race5Class3.SelectedIndex = Form2.mainWindow.CbBox_Race1Class3.SelectedIndex;
                    Form2.mainWindow.CbBox_Race6Class3.SelectedIndex = Form2.mainWindow.CbBox_Race1Class3.SelectedIndex;
                    Form2.mainWindow.CbBox_Race7Class3.SelectedIndex = Form2.mainWindow.CbBox_Race1Class3.SelectedIndex;
                    Form2.mainWindow.CbBox_Race8Class3.SelectedIndex = Form2.mainWindow.CbBox_Race1Class3.SelectedIndex;

                    Form2.mainWindow.CbBox_Race2Class3.Enabled = false;
                    Form2.mainWindow.CbBox_Race3Class3.Enabled = false;
                    Form2.mainWindow.CbBox_Race4Class3.Enabled = false;
                    Form2.mainWindow.CbBox_Race5Class3.Enabled = false;
                    Form2.mainWindow.CbBox_Race6Class3.Enabled = false;
                    Form2.mainWindow.CbBox_Race7Class3.Enabled = false;
                    Form2.mainWindow.CbBox_Race8Class3.Enabled = false;

                    Form2.mainWindow.CbBox_Race2Class4.SelectedIndex = Form2.mainWindow.CbBox_Race1Class4.SelectedIndex;
                    Form2.mainWindow.CbBox_Race3Class4.SelectedIndex = Form2.mainWindow.CbBox_Race1Class4.SelectedIndex;
                    Form2.mainWindow.CbBox_Race4Class4.SelectedIndex = Form2.mainWindow.CbBox_Race1Class4.SelectedIndex;
                    Form2.mainWindow.CbBox_Race5Class4.SelectedIndex = Form2.mainWindow.CbBox_Race1Class4.SelectedIndex;
                    Form2.mainWindow.CbBox_Race6Class4.SelectedIndex = Form2.mainWindow.CbBox_Race1Class4.SelectedIndex;
                    Form2.mainWindow.CbBox_Race7Class4.SelectedIndex = Form2.mainWindow.CbBox_Race1Class4.SelectedIndex;
                    Form2.mainWindow.CbBox_Race8Class4.SelectedIndex = Form2.mainWindow.CbBox_Race1Class4.SelectedIndex;

                    Form2.mainWindow.CbBox_Race2Class4.Enabled = false;
                    Form2.mainWindow.CbBox_Race3Class4.Enabled = false;
                    Form2.mainWindow.CbBox_Race4Class4.Enabled = false;
                    Form2.mainWindow.CbBox_Race5Class4.Enabled = false;
                    Form2.mainWindow.CbBox_Race6Class4.Enabled = false;
                    Form2.mainWindow.CbBox_Race7Class4.Enabled = false;
                    Form2.mainWindow.CbBox_Race8Class4.Enabled = false;

                    Form2.mainWindow.RadioButton_Race2CarByClass.Checked = Form2.mainWindow.RadioButton_Race1CarByClass.Checked;
                    Form2.mainWindow.RadioButton_Race3CarByClass.Checked = Form2.mainWindow.RadioButton_Race1CarByClass.Checked;
                    Form2.mainWindow.RadioButton_Race4CarByClass.Checked = Form2.mainWindow.RadioButton_Race1CarByClass.Checked;
                    Form2.mainWindow.RadioButton_Race5CarByClass.Checked = Form2.mainWindow.RadioButton_Race1CarByClass.Checked;
                    Form2.mainWindow.RadioButton_Race6CarByClass.Checked = Form2.mainWindow.RadioButton_Race1CarByClass.Checked;
                    Form2.mainWindow.RadioButton_Race7CarByClass.Checked = Form2.mainWindow.RadioButton_Race1CarByClass.Checked;
                    Form2.mainWindow.RadioButton_Race8CarByClass.Checked = Form2.mainWindow.RadioButton_Race1CarByClass.Checked;
                }
                
                Form2.mainWindow.RadioButton_Race2CarByClass.Enabled = false;
                Form2.mainWindow.RadioButton_Race3CarByClass.Enabled = false;
                Form2.mainWindow.RadioButton_Race4CarByClass.Enabled = false;
                Form2.mainWindow.RadioButton_Race5CarByClass.Enabled = false;
                Form2.mainWindow.RadioButton_Race6CarByClass.Enabled = false;
                Form2.mainWindow.RadioButton_Race7CarByClass.Enabled = false;
                Form2.mainWindow.RadioButton_Race8CarByClass.Enabled = false;

                Form2.mainWindow.RadioButton_Race2UniqueCar.Enabled = false;
                Form2.mainWindow.RadioButton_Race3UniqueCar.Enabled = false;
                Form2.mainWindow.RadioButton_Race4UniqueCar.Enabled = false;
                Form2.mainWindow.RadioButton_Race5UniqueCar.Enabled = false;
                Form2.mainWindow.RadioButton_Race6UniqueCar.Enabled = false;
                Form2.mainWindow.RadioButton_Race7UniqueCar.Enabled = false;
                Form2.mainWindow.RadioButton_Race8UniqueCar.Enabled = false;
            }
            else
            {
                // If the same car box is unchecked I apply the settings that were previously set and I release the controls

                Form2.mainWindow.CbBox_Race2Class1.SelectedIndex = Form2.mainWindow.Class1R2;
                Form2.mainWindow.CbBox_Race3Class1.SelectedIndex = Form2.mainWindow.Class1R3;
                Form2.mainWindow.CbBox_Race4Class1.SelectedIndex = Form2.mainWindow.Class1R4;
                Form2.mainWindow.CbBox_Race5Class1.SelectedIndex = Form2.mainWindow.Class1R5;
                Form2.mainWindow.CbBox_Race6Class1.SelectedIndex = Form2.mainWindow.Class1R6;
                Form2.mainWindow.CbBox_Race7Class1.SelectedIndex = Form2.mainWindow.Class1R7;
                Form2.mainWindow.CbBox_Race8Class1.SelectedIndex = Form2.mainWindow.Class1R8;

                Form2.mainWindow.CbBox_Race2Class1.Enabled = true;
                Form2.mainWindow.CbBox_Race3Class1.Enabled = true;
                Form2.mainWindow.CbBox_Race4Class1.Enabled = true;
                Form2.mainWindow.CbBox_Race5Class1.Enabled = true;
                Form2.mainWindow.CbBox_Race6Class1.Enabled = true;
                Form2.mainWindow.CbBox_Race7Class1.Enabled = true;
                Form2.mainWindow.CbBox_Race8Class1.Enabled = true;

                Form2.mainWindow.CbBox_Race2Class2.SelectedIndex = Form2.mainWindow.Class2R2;
                Form2.mainWindow.CbBox_Race3Class2.SelectedIndex = Form2.mainWindow.Class2R3;
                Form2.mainWindow.CbBox_Race4Class2.SelectedIndex = Form2.mainWindow.Class2R4;
                Form2.mainWindow.CbBox_Race5Class2.SelectedIndex = Form2.mainWindow.Class2R5;
                Form2.mainWindow.CbBox_Race6Class2.SelectedIndex = Form2.mainWindow.Class2R6;
                Form2.mainWindow.CbBox_Race7Class2.SelectedIndex = Form2.mainWindow.Class2R7;
                Form2.mainWindow.CbBox_Race8Class2.SelectedIndex = Form2.mainWindow.Class2R8;

                Form2.mainWindow.CbBox_Race2Class2.Enabled = true;
                Form2.mainWindow.CbBox_Race3Class2.Enabled = true;
                Form2.mainWindow.CbBox_Race4Class2.Enabled = true;
                Form2.mainWindow.CbBox_Race5Class2.Enabled = true;
                Form2.mainWindow.CbBox_Race6Class2.Enabled = true;
                Form2.mainWindow.CbBox_Race7Class2.Enabled = true;
                Form2.mainWindow.CbBox_Race8Class2.Enabled = true;

                Form2.mainWindow.CbBox_Race2Class3.SelectedIndex = Form2.mainWindow.Class3R2;
                Form2.mainWindow.CbBox_Race3Class3.SelectedIndex = Form2.mainWindow.Class3R3;
                Form2.mainWindow.CbBox_Race4Class3.SelectedIndex = Form2.mainWindow.Class3R4;
                Form2.mainWindow.CbBox_Race5Class3.SelectedIndex = Form2.mainWindow.Class3R5;
                Form2.mainWindow.CbBox_Race6Class3.SelectedIndex = Form2.mainWindow.Class3R6;
                Form2.mainWindow.CbBox_Race7Class3.SelectedIndex = Form2.mainWindow.Class3R7;
                Form2.mainWindow.CbBox_Race8Class3.SelectedIndex = Form2.mainWindow.Class3R8;

                Form2.mainWindow.CbBox_Race2Class3.Enabled = true;
                Form2.mainWindow.CbBox_Race3Class3.Enabled = true;
                Form2.mainWindow.CbBox_Race4Class3.Enabled = true;
                Form2.mainWindow.CbBox_Race5Class3.Enabled = true;
                Form2.mainWindow.CbBox_Race6Class3.Enabled = true;
                Form2.mainWindow.CbBox_Race7Class3.Enabled = true;
                Form2.mainWindow.CbBox_Race8Class3.Enabled = true;

                Form2.mainWindow.CbBox_Race2Class4.SelectedIndex = Form2.mainWindow.Class4R2;
                Form2.mainWindow.CbBox_Race3Class4.SelectedIndex = Form2.mainWindow.Class4R3;
                Form2.mainWindow.CbBox_Race4Class4.SelectedIndex = Form2.mainWindow.Class4R4;
                Form2.mainWindow.CbBox_Race5Class4.SelectedIndex = Form2.mainWindow.Class4R5;
                Form2.mainWindow.CbBox_Race6Class4.SelectedIndex = Form2.mainWindow.Class4R6;
                Form2.mainWindow.CbBox_Race7Class4.SelectedIndex = Form2.mainWindow.Class4R7;
                Form2.mainWindow.CbBox_Race8Class4.SelectedIndex = Form2.mainWindow.Class4R8;

                Form2.mainWindow.CbBox_Race2Class4.Enabled = true;
                Form2.mainWindow.CbBox_Race3Class4.Enabled = true;
                Form2.mainWindow.CbBox_Race4Class4.Enabled = true;
                Form2.mainWindow.CbBox_Race5Class4.Enabled = true;
                Form2.mainWindow.CbBox_Race6Class4.Enabled = true;
                Form2.mainWindow.CbBox_Race7Class4.Enabled = true;
                Form2.mainWindow.CbBox_Race8Class4.Enabled = true;


                Form2.mainWindow.RadioButton_Race2UniqueCar.Checked = Form2.mainWindow.uniqueCar2;
                Form2.mainWindow.RadioButton_Race3UniqueCar.Checked = Form2.mainWindow.uniqueCar3;
                Form2.mainWindow.RadioButton_Race4UniqueCar.Checked = Form2.mainWindow.uniqueCar4;
                Form2.mainWindow.RadioButton_Race5UniqueCar.Checked = Form2.mainWindow.uniqueCar5;
                Form2.mainWindow.RadioButton_Race6UniqueCar.Checked = Form2.mainWindow.uniqueCar6;
                Form2.mainWindow.RadioButton_Race7UniqueCar.Checked = Form2.mainWindow.uniqueCar7;
                Form2.mainWindow.RadioButton_Race8UniqueCar.Checked = Form2.mainWindow.uniqueCar8;

                Form2.mainWindow.RadioButton_Race2UniqueCar.Enabled = true;
                Form2.mainWindow.RadioButton_Race3UniqueCar.Enabled = true;
                Form2.mainWindow.RadioButton_Race4UniqueCar.Enabled = true;
                Form2.mainWindow.RadioButton_Race5UniqueCar.Enabled = true;
                Form2.mainWindow.RadioButton_Race6UniqueCar.Enabled = true;
                Form2.mainWindow.RadioButton_Race7UniqueCar.Enabled = true;
                Form2.mainWindow.RadioButton_Race8UniqueCar.Enabled = true;

                Form2.mainWindow.RadioButton_Race2CarByClass.Checked = Form2.mainWindow.classCar2;
                Form2.mainWindow.RadioButton_Race3CarByClass.Checked = Form2.mainWindow.classCar3;
                Form2.mainWindow.RadioButton_Race4CarByClass.Checked = Form2.mainWindow.classCar4;
                Form2.mainWindow.RadioButton_Race5CarByClass.Checked = Form2.mainWindow.classCar5;
                Form2.mainWindow.RadioButton_Race6CarByClass.Checked = Form2.mainWindow.classCar6;
                Form2.mainWindow.RadioButton_Race7CarByClass.Checked = Form2.mainWindow.classCar7;
                Form2.mainWindow.RadioButton_Race8CarByClass.Checked = Form2.mainWindow.classCar8;

                Form2.mainWindow.RadioButton_Race2CarByClass.Enabled = true;
                Form2.mainWindow.RadioButton_Race3CarByClass.Enabled = true;
                Form2.mainWindow.RadioButton_Race4CarByClass.Enabled = true;
                Form2.mainWindow.RadioButton_Race5CarByClass.Enabled = true;
                Form2.mainWindow.RadioButton_Race6CarByClass.Enabled = true;
                Form2.mainWindow.RadioButton_Race7CarByClass.Enabled = true;
                Form2.mainWindow.RadioButton_Race8CarByClass.Enabled = true;

                Form2.mainWindow.CbBox_Race2ClassSlots.SelectedIndex = Form2.mainWindow.ClassSlots2;
                Form2.mainWindow.CbBox_Race3ClassSlots.SelectedIndex = Form2.mainWindow.ClassSlots3;
                Form2.mainWindow.CbBox_Race4ClassSlots.SelectedIndex = Form2.mainWindow.ClassSlots4;
                Form2.mainWindow.CbBox_Race5ClassSlots.SelectedIndex = Form2.mainWindow.ClassSlots5;
                Form2.mainWindow.CbBox_Race6ClassSlots.SelectedIndex = Form2.mainWindow.ClassSlots6;
                Form2.mainWindow.CbBox_Race7ClassSlots.SelectedIndex = Form2.mainWindow.ClassSlots7;
                Form2.mainWindow.CbBox_Race8ClassSlots.SelectedIndex = Form2.mainWindow.ClassSlots8;

                Form2.mainWindow.CbBox_Race2ClassSlots.Enabled = true;
                Form2.mainWindow.CbBox_Race3ClassSlots.Enabled = true;
                Form2.mainWindow.CbBox_Race4ClassSlots.Enabled = true;
                Form2.mainWindow.CbBox_Race5ClassSlots.Enabled = true;
                Form2.mainWindow.CbBox_Race6ClassSlots.Enabled = true;
                Form2.mainWindow.CbBox_Race7ClassSlots.Enabled = true;
                Form2.mainWindow.CbBox_Race8ClassSlots.Enabled = true;

                Form2.mainWindow.CbBox_Race2Cars.SelectedIndex = Form2.mainWindow.Car2;
                Form2.mainWindow.CbBox_Race3Cars.SelectedIndex = Form2.mainWindow.Car3;
                Form2.mainWindow.CbBox_Race4Cars.SelectedIndex = Form2.mainWindow.Car4;
                Form2.mainWindow.CbBox_Race5Cars.SelectedIndex = Form2.mainWindow.Car5;
                Form2.mainWindow.CbBox_Race6Cars.SelectedIndex = Form2.mainWindow.Car6;
                Form2.mainWindow.CbBox_Race7Cars.SelectedIndex = Form2.mainWindow.Car7;
                Form2.mainWindow.CbBox_Race8Cars.SelectedIndex = Form2.mainWindow.Car8;

                Form2.mainWindow.CbBox_Race2Cars.Enabled = true;
                Form2.mainWindow.CbBox_Race3Cars.Enabled = true;
                Form2.mainWindow.CbBox_Race4Cars.Enabled = true;
                Form2.mainWindow.CbBox_Race5Cars.Enabled = true;
                Form2.mainWindow.CbBox_Race6Cars.Enabled = true;
                Form2.mainWindow.CbBox_Race7Cars.Enabled = true;
                Form2.mainWindow.CbBox_Race8Cars.Enabled = true;

            }
        }
        
        public void ShowOrHideRank()
        {
            if (Form2.mainWindow.CheckBox_RankRace1.Checked == true)
            {
                Form2.mainWindow.CbBox_RankRace1.Visible = true;
                Form2.mainWindow.TxtBox_RankRace1.Visible = true;
            }
            else
            {
                Form2.mainWindow.CbBox_RankRace1.Visible = false;
                Form2.mainWindow.TxtBox_RankRace1.Visible = false;
            }

            if (Form2.mainWindow.CheckBox_RankRace2.Checked == true)
            {
                Form2.mainWindow.CbBox_RankRace2.Visible = true;
                Form2.mainWindow.TxtBox_RankRace2.Visible = true;
            }
            else
            {
                Form2.mainWindow.CbBox_RankRace2.Visible = false;
                Form2.mainWindow.TxtBox_RankRace2.Visible = false;
            }

            if (Form2.mainWindow.CheckBox_RankRace3.Checked == true)
            {
                Form2.mainWindow.CbBox_RankRace3.Visible = true;
                Form2.mainWindow.TxtBox_RankRace3.Visible = true;
            }
            else
            {
                Form2.mainWindow.CbBox_RankRace3.Visible = false;
                Form2.mainWindow.TxtBox_RankRace3.Visible = false;
            }

            if (Form2.mainWindow.CheckBox_RankRace4.Checked == true)
            {
                Form2.mainWindow.CbBox_RankRace4.Visible = true;
                Form2.mainWindow.TxtBox_RankRace4.Visible = true;
            }
            else
            {
                Form2.mainWindow.CbBox_RankRace4.Visible = false;
                Form2.mainWindow.TxtBox_RankRace4.Visible = false;
            }

            if (Form2.mainWindow.CheckBox_RankRace5.Checked == true)
            {
                Form2.mainWindow.CbBox_RankRace5.Visible = true;
                Form2.mainWindow.TxtBox_RankRace5.Visible = true;
            }
            else
            {
                Form2.mainWindow.CbBox_RankRace5.Visible = false;
                Form2.mainWindow.TxtBox_RankRace5.Visible = false;
            }

            if (Form2.mainWindow.CheckBox_RankRace6.Checked == true)
            {
                Form2.mainWindow.CbBox_RankRace6.Visible = true;
                Form2.mainWindow.TxtBox_RankRace6.Visible = true;
            }
            else
            {
                Form2.mainWindow.CbBox_RankRace6.Visible = false;
                Form2.mainWindow.TxtBox_RankRace6.Visible = false;
            }

            if (Form2.mainWindow.CheckBox_RankRace7.Checked == true)
            {
                Form2.mainWindow.CbBox_RankRace7.Visible = true;
                Form2.mainWindow.TxtBox_RankRace7.Visible = true;
            }
            else
            {
                Form2.mainWindow.CbBox_RankRace7.Visible = false;
                Form2.mainWindow.TxtBox_RankRace7.Visible = false;
            }

            if (Form2.mainWindow.CheckBox_RankRace8.Checked == true)
            {
                Form2.mainWindow.CbBox_RankRace8.Visible = true;
                Form2.mainWindow.TxtBox_RankRace8.Visible = true;
            }
            else
            {
                Form2.mainWindow.CbBox_RankRace8.Visible = false;
                Form2.mainWindow.TxtBox_RankRace8.Visible = false;
            }
        }

    }

}

