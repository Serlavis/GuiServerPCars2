using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiServerPCars2V2._0
{
    class CreateRotateFile : IDisposable
    {

        private string ChoiceClassRace1;

        private string choiceCar1;


        public void ChoiceOfUniqueCarOrclassRace1()
        {
            //choice class Race 1

            string choiceUniqueCar1 =
            "        \"VehicleModelId\" : " + "\"" + Form2.mainWindow.CbBox_Race1Cars.Text + "\",";

            if (Form2.mainWindow.RadioButton_Race1CarByClass.Checked)
            {
                choiceCar1 = ChoiceClassRace1;
            }

            else if (Form2.mainWindow.RadioButton_Race1UniqueCar.Checked)
            {
                choiceCar1 = choiceUniqueCar1;
            }
        }

        public void MulticlassSlotsRace1()
        {
            int multiClassSlots;



            bool result = int.TryParse(Form2.mainWindow.CbBox_Race1ClassSlots.Text, out int i);
            if (result)
            {
                multiClassSlots = --i;


                // choice of vehicle classes

                if (multiClassSlots == 0)
                {
                    ChoiceClassRace1 = "        \"VehicleClassId\" : " + Form2.mainWindow.CbBox_Race1Class1.Text + "," + "\r\n";
                }
                else if (multiClassSlots == 1)
                {
                    ChoiceClassRace1 =
                    "        \"VehicleClassId\" :" + Form2.mainWindow.CbBox_Race1Class1.Text + "," + "\r\n" +
                    "        \"MultiClassSlots\" : " + multiClassSlots + "," + "\r\n" +
                    "        \"MultiClassSlot1\" : " + Form2.mainWindow.CbBox_Race1Class2.Text + "," + "\r\n";
                }
                else if (multiClassSlots == 2)
                {
                    ChoiceClassRace1 =
                        "        \"VehicleClassId\" :" + Form2.mainWindow.CbBox_Race1Class1.Text + "," + "\r\n" +
               "        \"MultiClassSlots\" : " + multiClassSlots + "," + "\r\n" +
               "        \"MultiClassSlot1\" : " + Form2.mainWindow.CbBox_Race1Class2.Text + "," + "\r\n" +
               "        \"MultiClassSlot2\" : " + Form2.mainWindow.CbBox_Race1Class3.Text + "," + "\r\n";
                }
                else if (multiClassSlots == 3)
                {
                    ChoiceClassRace1 =
               "        \"VehicleClassId\" :" + Form2.mainWindow.CbBox_Race1Class1.SelectedValue + "," + "\r\n" +
               "        \"MultiClassSlots\" : " + multiClassSlots + "," + "\r\n" +
               "        \"MultiClassSlot1\" : " + Form2.mainWindow.CbBox_Race1Class2.SelectedValue + "," + "\r\n" +
               "        \"MultiClassSlot2\" : " + Form2.mainWindow.CbBox_Race1Class3.SelectedValue + "," + "\r\n" +
               "        \"MultiClassSlot3\" : " + Form2.mainWindow.CbBox_Race1Class4.SelectedValue + ",\r\n";

                }
            }


        }

    


    //Création du rotate

    public void EditOrCreateFileRotate()
        {
            int numOfRace = Form2.mainWindow.CbBox_NumerOfRace.SelectedIndex + 1;
            MulticlassSlotsRace1();
            ChoiceOfUniqueCarOrclassRace1();

        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
