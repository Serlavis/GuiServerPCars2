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

        
        private int numOfRace = Form2.mainWindow.CbBox_NumerOfRace.SelectedIndex + 1;
        private string choiceCar1;
        private string penaltiesRace1;
        private string pitLinePenaltiesRace1;
        private string driveThroughPenaltyRace1;

        private string manualPitStopRace1;
        private string manualPitStopRace2;
        private string manualPitStopRace3;
        private string manualPitStopRace4;
        private string manualPitStopRace5;
        private string manualPitStopRace6;
        private string manualPitStopRace7;
        private string manualPitStopRace8;


        private string raceMandatoryPitStops1;
        private string raceMandatoryPitStops2;
        private string raceMandatoryPitStops3;
        private string raceMandatoryPitStops4;
        private string raceMandatoryPitStops5;
        private string raceMandatoryPitStops6;
        private string raceMandatoryPitStops7;
        private string raceMandatoryPitStops8;

        private string raceRollingStart1;
        private string raceRollingStart2;
        private string raceRollingStart3;
        private string raceRollingStart4;
        private string raceRollingStart5;
        private string raceRollingStart6;
        private string raceRollingStart7;
        private string raceRollingStart8;

        private string manualRollingStarts1;
        private string manualRollingStarts2;
        private string manualRollingStarts3;
        private string manualRollingStarts4;
        private string manualRollingStarts5;
        private string manualRollingStarts6;
        private string manualRollingStarts7;
        private string manualRollingStarts8;

        private string raceFormationLap1;
        private string raceFormationLap2;
        private string raceFormationLap3;
        private string raceFormationLap4;
        private string raceFormationLap5;
        private string raceFormationLap6;
        private string raceFormationLap7;
        private string raceFormationLap8;

       

        private string persistIndex;

        Flags flags = new Flags();

        private void RaceFormationLap()
        {
            if (Form2.mainWindow.CheckBox_RaceFormationLapRace1.Checked)
            {
                raceFormationLap1 = "\"RaceFormationLap\" : 1,";
            }
            else
            {
                raceFormationLap1 = "\"RaceFormationLap\" : 0,";
            }
        }

        private void ManualRollingStarts()
        {
            if (Form2.mainWindow.CheckBox_ManualRollingStartsRace1.Checked)
            {
                manualRollingStarts1 = "\"ManualRollingStarts\" : 1,";
            }
            else
            {
                manualRollingStarts1 = "\"ManualRollingStarts\" : 0,";
            }
        }

        private void RaceRollingStart()
        {
            if (Form2.mainWindow.CheckBox_RaceRollingStartRace1.Checked)
            {
               raceRollingStart1 = "\"RaceRollingStart\" : 1,"; 
            }
            else
            {
                raceRollingStart1 = "\"RaceRollingStart\" : 0,";
            }

    
        }

        private void RaceMandatoryPitStop()
        {
            if (Form2.mainWindow.CheckBox_RaceMandatoryPitStopsRace1.Checked)
            {
                raceMandatoryPitStops1 = "\"RaceMandatoryPitStops\" : 1,";
            }
            else
            {
                raceMandatoryPitStops1 = "\"RaceMandatoryPitStops\" : 0,";
            }
        }
        private void ManualPitStop()
        {
            if (Form2.mainWindow.CheckBox_ManualPitStopRace1.Checked)
            {
                manualPitStopRace1 = "\"ManualPitStops\" : 2,";
            }
            else
            {
                manualPitStopRace1 = "\"ManualPitStops\" : 0,";
            }
            if (Form2.mainWindow.CheckBox_SameRules.Checked == false)
            {
                if (Form2.mainWindow.CheckBox_ManualPitStopRace2.Checked)
                {
                    manualPitStopRace2 = "\"ManualPitStops\" : 2,";
                }
                else
                {
                    manualPitStopRace2 = "\"ManualPitStops\" : 0,";
                }
            }
            else
            {
                manualPitStopRace2 = "";
            }
        }

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

            

            if (Form2.mainWindow.RadioButton_Race1CarByClass.Checked)
            {
                // choice of vehicle classes

                if (Form2.mainWindow.CbBox_Race1ClassSlots.SelectedIndex == 0)
                {
                    choiceCar1 = "        \"VehicleClassId\" : \"" + Form2.mainWindow.CbBox_Race1Class1.Text + "\", \r\n";
                }
                else if (Form2.mainWindow.CbBox_Race1ClassSlots.SelectedIndex == 1)
                {
                    choiceCar1 =
                    "        \"VehicleClassId\" : \"" + Form2.mainWindow.CbBox_Race1Class1.Text + "\", \r\n" +
                    "        \"MultiClassSlots\" : " + Form2.mainWindow.CbBox_Race1ClassSlots.SelectedIndex + "," + "\r\n" +
                    "        \"MultiClassSlot1\" : \"" + Form2.mainWindow.CbBox_Race1Class2.Text + "\", \r\n";
                }
                else if (Form2.mainWindow.CbBox_Race1ClassSlots.SelectedIndex == 2)
                {
                    choiceCar1 =
                    "        \"VehicleClassId\" : \"" + Form2.mainWindow.CbBox_Race1Class1.Text + "\", \r\n" +
                    "        \"MultiClassSlots\" : " + Form2.mainWindow.CbBox_Race1ClassSlots.SelectedIndex + "," + "\r\n" +
                    "        \"MultiClassSlot1\" : \"" + Form2.mainWindow.CbBox_Race1Class2.Text + "\", \r\n" +
                    "        \"MultiClassSlot2\" : \"" + Form2.mainWindow.CbBox_Race1Class3.Text + "\", \r\n";
                }
                else if (Form2.mainWindow.CbBox_Race1ClassSlots.SelectedIndex == 3)
                {
                    choiceCar1 =
                    "        \"VehicleClassId\" : \"" + Form2.mainWindow.CbBox_Race1Class1.Text + "\", \r\n" +
                    "        \"MultiClassSlots\" : " + Form2.mainWindow.CbBox_Race1ClassSlots.SelectedIndex + "," + "\r\n" +
                    "        \"MultiClassSlot1\" : \"" + Form2.mainWindow.CbBox_Race1Class2.Text + "\", \r\n" +
                    "        \"MultiClassSlot2\" : \"" + Form2.mainWindow.CbBox_Race1Class3.Text + "\", \r\n" +
                    "        \"MultiClassSlot3\" : \"" + Form2.mainWindow.CbBox_Race1Class4.Text + "\", \r\n"; 

                }
            }

            else if (Form2.mainWindow.RadioButton_Race1UniqueCar.Checked)
            {
                choiceCar1 = "        \"VehicleModelId\" : " + "\"" + Form2.mainWindow.CbBox_Race1Cars.Text + "\",";


            }
        }

       

    


    //Création du rotate

    public void EditOrCreateFileRotate()
        {
            PersistIndex();
            string fileRotate = Form1.workFolder + "\\lua_config\\sms_rotate_config.json";
            string removeFlags1 = "        \"RemoveFlags\" : \"" + string.Join(",", flags.choixFlagsRace1.ToArray()) + "\"";

            ChoiceOfUniqueCarOrclassRace1();
            PitLinePenaltie();
            Penalties();
            DriveThroughPenalty();
            ManualPitStop();
            RaceMandatoryPitStop();
            RaceRollingStart();
            ManualRollingStarts();
            RaceFormationLap();
            flags.SaveFlags1();

            //Creation de la course 1






            string course1 =
                "\r\n{" +
                "\r\n" +
                "\r\n" +
                "        \"TrackId\" : \"" + Form2.mainWindow.CbBox_Race1Tracks.Text + "\",\r\n" +

                choiceCar1 +
                "\r\n" +
                "\r\n" +
                removeFlags1 +
                "\r\n}";


            var streamFile = new StreamWriter(new FileStream(fileRotate, FileMode.OpenOrCreate));
            string rotate = "version : 7  \r\n" +
                            "config : {  \r\n" +
                            "    \"persist_index\" : "  + persistIndex + "\r\n" + "\r\n" +
                            "    \"default\": { \r\n" +
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
                            "        \"DamageType\" : " + "\"" + Form2.mainWindow.damage1 + "\"," + "\r\n" +
                            "        \"TireWearType\" : " + "\"" + Form2.mainWindow.CbBox_TireWearRace1.SelectedValue + "\", \r\n" +
                            "        \"FuelUsageType\" : " + "\"" + Form2.mainWindow.CbBox_FuelUsageRace1.SelectedValue + "\", \r\n" +
                            "        \"AllowedViews\" : " + "\"" + Form2.mainWindow.CbBox_AllowedViewsRace1.SelectedValue + "\", \r\n" +
                            "        \"PenaltiesType\" : "  + penaltiesRace1 + "\r\n" +
                            "        " + pitLinePenaltiesRace1 +  "\r\n" +
                            "        \"DriveThroughPenalty\" : " + driveThroughPenaltyRace1 + "\r\n" +
                            "        \"AllowablePenaltyTime\" : " + Form2.mainWindow.CbBox_PenaltyTimeRace1.Text + ", \r\n" +
                            "        " + manualPitStopRace1 + "\r\n" +
                            "\r\n" +
                            "\r\n" +
                            "        " + raceMandatoryPitStops1 + "\r\n" +
                            "        " + raceRollingStart1 + "\r\n" +
                            "        " + manualRollingStarts1 + "\r\n" +
                            "        " + raceFormationLap1 + "\r\n" +
                            "\r\n" +
                            "\r\n" +
                            "        \"RaceDateYear\" : " + Form2.mainWindow.dateTimePicker_Race1.Value.Year.ToString() + ",\r\n" +
                            "        \"RaceDateMonth\" : " + Form2.mainWindow.dateTimePicker_Race1.Value.Month.ToString() + ",\r\n" +
                            "        \"RaceDateDay\" : " + Form2.mainWindow.dateTimePicker_Race1.Value.Day.ToString() + ",\r\n" +
                            "\r\n" +
                            "\r\n" +
                            "        \"PracticeDateHour\" : " + Form2.mainWindow.dateTimePicker_Race1.Value.Hour.ToString() + ",\r\n" +
                            "        \"QualifyDateHour\" : " + Form2.mainWindow.dateTimePicker_Race1.Value.Hour.ToString() + ",\r\n" +
                            "        \"RaceDateHour\" : " + Form2.mainWindow.dateTimePicker_Race1.Value.Hour.ToString() + ",\r\n" +
                            "\r\n" +
                            "\r\n" +
                            "        \"PracticeDateProgression\" : " + Form2.mainWindow.CbBox_PracticeProgressionRace1.Text + ",\r\n" +
                            "        \"QualifyDateProgression\" : " + Form2.mainWindow.CbBox_QualifyProgressionRace1.Text + ",\r\n" +
                            "        \"RaceDateProgression\" : " + Form2.mainWindow.CbBox_RaceProgressionRace1.Text + ",\r\n" +
                            "\r\n" +
                            "\r\n" +
                            "        \"PracticeWeatherSlots\" : " + Form2.mainWindow.CbBox_PracticeWeatherSlotsRace1.Text + ",\r\n" +
                            "        \"PracticeWeatherSlot1\" : \"" + Form2.mainWindow.practiceWeatherSlot1Race1 + "\",\r\n" +
                            "        \"PracticeWeatherSlot2\" : \"" + Form2.mainWindow.practiceWeatherSlot2Race1 + "\",\r\n" +
                            "        \"PracticeWeatherSlot3\" : \"" + Form2.mainWindow.practiceWeatherSlot3Race1 + "\",\r\n" +
                            "        \"PracticeWeatherSlot4\" : \"" + Form2.mainWindow.practiceWeatherSlot4Race1 + "\",\r\n" +
                            "        \"PracticeWeatherProgression\" : " + Form2.mainWindow.CbBox_SpeedPratcticeWeatherRace1.Text + ",\r\n" +
                            "\r\n" +
                            "\r\n" +
                            "        \"QualifyWeatherSlots\" : " + Form2.mainWindow.CbBox_QualifWeatherSlotsRace1.Text + ",\r\n" +
                            "        \"QualifyWeatherSlot1\" : \"" + Form2.mainWindow.qualifyWeatherSlot1Race1 + "\",\r\n" +
                            "        \"QualifyWeatherSlot2\" : \"" + Form2.mainWindow.qualifyWeatherSlot2Race1 + "\",\r\n" +
                            "        \"QualifyWeatherSlot3\" : \"" + Form2.mainWindow.qualifyWeatherSlot3Race1 + "\",\r\n" +
                            "        \"QualifyWeatherSlot4\" : \"" + Form2.mainWindow.qualifyWeatherSlot4Race1 + "\",\r\n" +
                            "        \"QualifyWeatherProgression\" : " + Form2.mainWindow.CbBox_SpeedQualifWeatherRace1.Text + ",\r\n" +
                            "\r\n" +
                            "\r\n" +
                            "        \"RaceWeatherSlots\" : " + Form2.mainWindow.CbBox_RaceWeatherSlotsRace1.Text + ",\r\n" +
                            "        \"RaceWeatherSlot1\" : \"" + Form2.mainWindow.raceWeatherSlot1Race1 + "\",\r\n" +
                            "        \"RaceWeatherSlot2\" : \"" + Form2.mainWindow.raceWeatherSlot2Race1 + "\",\r\n" +
                            "        \"RaceWeatherSlot3\" : \"" + Form2.mainWindow.raceWeatherSlot3Race1 + "\",\r\n" +
                            "        \"RaceWeatherSlot4\" : \"" + Form2.mainWindow.raceWeatherSlot4Race1 + "\",\r\n" +
                            "        \"RaceWeatherProgression\" : " + Form2.mainWindow.CbBox_SpeedRaceWeatherRace1.Text + ",\r\n" +
                            "\r\n" +
                            "\r\n" +
                            "        \"MinimumOnlineRank\" : \"" + Form2.mainWindow.CbBox_RankRace1.Text + "\",\r\n" +
                            "        \"MinimumOnlineStrength\" : " + Form2.mainWindow.TxtBox_RankRace1.Text + ",\r\n" +
                            "},\r\n" +
                            "\r\n" +
                            "\"rotation\" : [" +
                            "\r\n" +
                            "\r\n" +
                            course1 +

                            "\r\n]" +
                            "\r\n}";




            
                
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
