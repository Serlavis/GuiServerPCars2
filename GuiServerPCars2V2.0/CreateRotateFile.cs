using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GuiServerPCars2V2._0
{
    class CreateRotateFile : IDisposable
    {

        private string ChoiceClassRace1;
        private readonly int numOfRace = Form2.mainWindow.CbBox_NumerOfRace.SelectedIndex + 1;
        private string choiceCar1;
        private string penaltiesRace1;
        private string pitLinePenaltiesRace1;
        private string driveThroughPenaltyRace1;
        private string manualPitStopRace1;



        private string persistIndex;


        private void DriveThroughPenalty()
        {
            if(Form2.mainWindow.CheckBox_DriveThroughPenaltyRace1.Checked)
            {
                driveThroughPenaltyRace1 = "1,";
            }
            else
            {
                driveThroughPenaltyRace1 = "0,";
            }
        }



        private void Penalties()
        {
            if(Form2.mainWindow.CheckBox_PenaltiesRace1.Checked)
            {
                penaltiesRace1 = "\"FULL\",";
            }
            else
            {
                penaltiesRace1 = "\"NONE\",";
            }
            
        }

        private void PitLinePenaltie()
        {
            if(Form2.mainWindow.CheckBox_PitLinePenaltyRace1.Checked)
            {
                pitLinePenaltiesRace1 = "\"PitWhiteLinePenalty\" : 1,"; 
            }
            else
            {
                pitLinePenaltiesRace1 = "\"PitWhiteLinePenalty\" : 0,";
            }
        }

        private void PersistIndex()
        {
            if(Form2.mainWindow.CheckBox_PersistIndex.Checked)
            {
                persistIndex = "true,";
            }
            else
            {
                persistIndex = "false,";
            }
        }

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
                    ChoiceClassRace1 = "        \"VehicleClassId\" : " + "\"" + Form2.mainWindow.CbBox_Race1Class1.Text + "\"," + "\r\n";
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
            int indexDamages1 = Form2.mainWindow.CbBox_DamageTypeRace1.SelectedIndex;
            PersistIndex();
            string fileRotate = Form1.workFolder + "\\lua_config\\sms_rotate_config.json";
            
            MulticlassSlotsRace1();
            ChoiceOfUniqueCarOrclassRace1();
            PitLinePenaltie();
            Penalties();
            DriveThroughPenalty();


            var streamFile = new StreamWriter(new FileStream(fileRotate, FileMode.Create));
            string rotate = "version : 7  \r\n" +
                            "config : {  \r\n" +
                            "    \"persist_index\" : "  + persistIndex + "\r\n" + "\r\n" +
                            "    \"default \": { \r\n" +
                            "\r\n" +
                            "        \"VehicleClassId\" : \"LMP1\",\r\n" +
                            "        \"MultiClassSlots\" : 0,\r\n" +
                            "        \"MultiClassSlot1\" : 0,\r\n" +
                            "        \"MultiClassSlot2\" : 0,\r\n" +
                            "        \"MultiClassSlot3\" : 0,\r\n" +
                            "\r\n" +
                            "\r\n" +
                            "       \"OpponentDifficulty\" :" + Form2.mainWindow.trackBar_IA.Value.ToString() + ",\r\n" +
                            "\r\n" +
                            "\r\n" +
                            "        \"PracticeLength\" : " + Form2.mainWindow.TxtBx_PracticeLengthRace1.Text + ",\r\n" +
                            "        \"QualifyLength\" : " + Form2.mainWindow.TxtBx_QualifyLengthRace1.Text + ",\r\n" +
                            "        \"RaceLength\" : " + Form2.mainWindow.TxtBx_RaceLengthRace1.Text + ",\r\n" +
                            "        \"Flags\" : \"ABS_ALLOWED,ALLOW_CUSTOM_VEHICLE_SETUP,ANTI_GRIEFING_COLLISIONS,AUTO_START_ENGINE,COOLDOWNLAP,DISABLE_DRIVING_LINE,FILL_SESSION_WITH_AI,FORCE_MANUAL,FORCE_REALISTIC_DRIVING_AIDS,HAS_BROADCASTER,HAS_RACE_DIRECTOR,MECHANICAL_FAILURES,ONLINE_REPUTATION_ENABLED,PASSWORD_PROTECTED,PIT_SPEED_LIMITER,PIT_STOP_ERRORS_ALLOWED,SC_ALLOWED,TCS_ALLOWED,TIMED_RACE,WAIT_FOR_RACE_READY_INPUT\"," +
                            "\r\n" +

                            // Cette section ne fonctionne pas 

                            "        \"DamageType\" : " + "\"" +   Form2.mainWindow.damage1 + "\"," + "\r\n" +
                            "        \"TireWearType\" : " + "\"" + Form2.mainWindow.CbBox_TireWearRace1.SelectedValue + "\", \r\n" +
                            "        \"FuelUsageType\" : " + "\"" + Form2.mainWindow.CbBox_FuelUsageRace1.SelectedValue + "\", \r\n" +
                            "        \"AllowedViews\" : " + "\"" + Form2.mainWindow.CbBox_AllowedViewsRace1.SelectedValue + "\", \r\n" +
                            // Fin de section à corriger

                            "        \"PenaltiesType\" : "  + penaltiesRace1 + "\r\n" +
                            "        " + pitLinePenaltiesRace1 +  "\r\n" +
                            "        \"DriveThroughPenalty\" : " + driveThroughPenaltyRace1 + "\r\n" +
                            "        \"AllowablePenaltyTime\" : " + Form2.mainWindow.CbBox_PenaltyTimeRace1.Text + ", \r\n" +
                            // Coder une méthode 
                            
                            "        " + manualPitStopRace1 + "\r\n" 

                             ;
                
            streamFile.Write(rotate);
            streamFile.Close();
            streamFile.Dispose();



        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
