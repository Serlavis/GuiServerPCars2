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


        private string choiceCar1;
        private string choiceCar2;
        private string choiceCar3;
        private string choiceCar4;
        private string choiceCar5;
        private string choiceCar6;
        private string choiceCar7;
        private string choiceCar8;

        private string penaltiesRace1;
        private string penaltiesRace2;
        private string penaltiesRace3;
        private string penaltiesRace4;
        private string penaltiesRace5;
        private string penaltiesRace6;
        private string penaltiesRace7;
        private string penaltiesRace8;

        private string pitLinePenaltiesRace1;
        private string pitLinePenaltiesRace2;
        private string pitLinePenaltiesRace3;
        private string pitLinePenaltiesRace4;
        private string pitLinePenaltiesRace5;
        private string pitLinePenaltiesRace6;
        private string pitLinePenaltiesRace7;
        private string pitLinePenaltiesRace8;

        private string driveThroughPenaltyRace1;
        private string driveThroughPenaltyRace2;
        private string driveThroughPenaltyRace3;
        private string driveThroughPenaltyRace4;
        private string driveThroughPenaltyRace5;
        private string driveThroughPenaltyRace6;
        private string driveThroughPenaltyRace7;
        private string driveThroughPenaltyRace8;

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

        private string race1;
        private string race2;
        private string race3;
        private string race4;
        private string race5;
        private string race6;
        private string race7;
        private string race8;

        private string removeFlags1;
        private string removeFlags2;
        private string removeFlags3;
        private string removeFlags4;
        private string removeFlags5;
        private string removeFlags6;
        private string removeFlags7;
        private string removeFlags8;



        string rulesRace2;
        string rulesRace3;
        string rulesRace4;
        string rulesRace5;
        string rulesRace6;
        string rulesRace7;
        string rulesRace8;



        private string persistIndex;
        readonly Flags flags = new Flags();


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
            if (Form2.mainWindow.CheckBox_SameRules.Checked == false)
            {
                if (Form2.mainWindow.CheckBox_RaceFormationLapRace2.Checked)
                {
                    raceFormationLap2 = "\"RaceFormationLap\" : 1,";
                }
                else
                {
                    raceFormationLap2 = "\"RaceFormationLap\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_RaceFormationLapRace3.Checked)
                {
                    raceFormationLap3 = "\"RaceFormationLap\" : 1,";
                }
                else
                {
                    raceFormationLap3 = "\"RaceFormationLap\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_RaceFormationLapRace4.Checked)
                {
                    raceFormationLap4 = "\"RaceFormationLap\" : 1,";
                }
                else
                {
                    raceFormationLap4 = "\"RaceFormationLap\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_RaceFormationLapRace5.Checked)
                {
                    raceFormationLap5 = "\"RaceFormationLap\" : 1,";
                }
                else
                {
                    raceFormationLap5 = "\"RaceFormationLap\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_RaceFormationLapRace6.Checked)
                {
                    raceFormationLap6 = "\"RaceFormationLap\" : 1,";
                }
                else
                {
                    raceFormationLap6 = "\"RaceFormationLap\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_RaceFormationLapRace7.Checked)
                {
                    raceFormationLap7 = "\"RaceFormationLap\" : 1,";
                }
                else
                {
                    raceFormationLap7 = "\"RaceFormationLap\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_RaceFormationLapRace8.Checked)
                {
                    raceFormationLap8 = "\"RaceFormationLap\" : 1,";
                }
                else
                {
                    raceFormationLap8 = "\"RaceFormationLap\" : 0,";
                }
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
            if (Form2.mainWindow.CheckBox_SameRules.Checked == false)
            {
                if (Form2.mainWindow.CheckBox_ManualRollingStartsRace2.Checked)
                {
                    manualRollingStarts2 = "\"ManualRollingStarts\" : 1,";
                }
                else
                {
                    manualRollingStarts2 = "\"ManualRollingStarts\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_ManualRollingStartsRace3.Checked)
                {
                    manualRollingStarts3 = "\"ManualRollingStarts\" : 1,";
                }
                else
                {
                    manualRollingStarts3 = "\"ManualRollingStarts\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_ManualRollingStartsRace4.Checked)
                {
                    manualRollingStarts4 = "\"ManualRollingStarts\" : 1,";
                }
                else
                {
                    manualRollingStarts4 = "\"ManualRollingStarts\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_ManualRollingStartsRace5.Checked)
                {
                    manualRollingStarts5 = "\"ManualRollingStarts\" : 1,";
                }
                else
                {
                    manualRollingStarts5 = "\"ManualRollingStarts\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_ManualRollingStartsRace6.Checked)
                {
                    manualRollingStarts6 = "\"ManualRollingStarts\" : 1,";
                }
                else
                {
                    manualRollingStarts6 = "\"ManualRollingStarts\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_ManualRollingStartsRace7.Checked)
                {
                    manualRollingStarts7 = "\"ManualRollingStarts\" : 1,";
                }
                else
                {
                    manualRollingStarts7 = "\"ManualRollingStarts\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_ManualRollingStartsRace6.Checked)
                {
                    manualRollingStarts8 = "\"ManualRollingStarts\" : 1,";
                }
                else
                {
                    manualRollingStarts8 = "\"ManualRollingStarts\" : 0,";
                }
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
            if (Form2.mainWindow.CheckBox_SameRules.Checked == false)
            {
                if (Form2.mainWindow.CheckBox_RaceRollingStartRace2.Checked)
                {
                    raceRollingStart2 = "\"RaceRollingStart\" : 1,";
                }
                else
                {
                    raceRollingStart2 = "\"RaceRollingStart\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_RaceRollingStartRace3.Checked)
                {
                    raceRollingStart3 = "\"RaceRollingStart\" : 1,";
                }
                else
                {
                    raceRollingStart3 = "\"RaceRollingStart\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_RaceRollingStartRace4.Checked)
                {
                    raceRollingStart4 = "\"RaceRollingStart\" : 1,";
                }
                else
                {
                    raceRollingStart4 = "\"RaceRollingStart\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_RaceRollingStartRace5.Checked)
                {
                    raceRollingStart5 = "\"RaceRollingStart\" : 1,";
                }
                else
                {
                    raceRollingStart5 = "\"RaceRollingStart\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_RaceRollingStartRace6.Checked)
                {
                    raceRollingStart6 = "\"RaceRollingStart\" : 1,";
                }
                else
                {
                    raceRollingStart6 = "\"RaceRollingStart\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_RaceRollingStartRace7.Checked)
                {
                    raceRollingStart7 = "\"RaceRollingStart\" : 1,";
                }
                else
                {
                    raceRollingStart7 = "\"RaceRollingStart\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_RaceRollingStartRace8.Checked)
                {
                    raceRollingStart8 = "\"RaceRollingStart\" : 1,";
                }
                else
                {
                    raceRollingStart8 = "\"RaceRollingStart\" : 0,";
                }
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
            if (Form2.mainWindow.CheckBox_SameRules.Checked == false)
            {
                if (Form2.mainWindow.CheckBox_RaceMandatoryPitStopsRace2.Checked)
                {
                    raceMandatoryPitStops2 = "\"RaceMandatoryPitStops\" : 1,";
                }
                else
                {
                    raceMandatoryPitStops2 = "\"RaceMandatoryPitStops\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_RaceMandatoryPitStopsRace3.Checked)
                {
                    raceMandatoryPitStops3 = "\"RaceMandatoryPitStops\" : 1,";
                }
                else
                {
                    raceMandatoryPitStops3 = "\"RaceMandatoryPitStops\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_RaceMandatoryPitStopsRace4.Checked)
                {
                    raceMandatoryPitStops4 = "\"RaceMandatoryPitStops\" : 1,";
                }
                else
                {
                    raceMandatoryPitStops4 = "\"RaceMandatoryPitStops\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_RaceMandatoryPitStopsRace5.Checked)
                {
                    raceMandatoryPitStops5 = "\"RaceMandatoryPitStops\" : 1,";
                }
                else
                {
                    raceMandatoryPitStops5 = "\"RaceMandatoryPitStops\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_RaceMandatoryPitStopsRace6.Checked)
                {
                    raceMandatoryPitStops6 = "\"RaceMandatoryPitStops\" : 1,";
                }
                else
                {
                    raceMandatoryPitStops6 = "\"RaceMandatoryPitStops\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_RaceMandatoryPitStopsRace7.Checked)
                {
                    raceMandatoryPitStops7 = "\"RaceMandatoryPitStops\" : 1,";
                }
                else
                {
                    raceMandatoryPitStops7 = "\"RaceMandatoryPitStops\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_RaceMandatoryPitStopsRace8.Checked)
                {
                    raceMandatoryPitStops8 = "\"RaceMandatoryPitStops\" : 1,";
                }
                else
                {
                    raceMandatoryPitStops8 = "\"RaceMandatoryPitStops\" : 0,";
                }
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
                if (Form2.mainWindow.CheckBox_ManualPitStopRace3.Checked)
                {
                    manualPitStopRace3 = "\"ManualPitStops\" : 2,";
                }
                else
                {
                    manualPitStopRace3 = "\"ManualPitStops\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_ManualPitStopRace4.Checked)
                {
                    manualPitStopRace4 = "\"ManualPitStops\" : 2,";
                }
                else
                {
                    manualPitStopRace4 = "\"ManualPitStops\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_ManualPitStopRace5.Checked)
                {
                    manualPitStopRace5 = "\"ManualPitStops\" : 2,";
                }
                else
                {
                    manualPitStopRace5 = "\"ManualPitStops\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_ManualPitStopRace6.Checked)
                {
                    manualPitStopRace6 = "\"ManualPitStops\" : 2,";
                }
                else
                {
                    manualPitStopRace6 = "\"ManualPitStops\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_ManualPitStopRace7.Checked)
                {
                    manualPitStopRace7 = "\"ManualPitStops\" : 2,";
                }
                else
                {
                    manualPitStopRace7 = "\"ManualPitStops\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_ManualPitStopRace8.Checked)
                {
                    manualPitStopRace8 = "\"ManualPitStops\" : 2,";
                }
                else
                {
                    manualPitStopRace8 = "\"ManualPitStops\" : 0,";
                }
            }
            
        }

        private void DriveThroughPenalty()
        {
            if (Form2.mainWindow.CheckBox_DriveThroughPenaltyRace1.Checked)
            {
                driveThroughPenaltyRace1 = "1,";
            }
            else
            {
                driveThroughPenaltyRace1 = "0,";
            }
            if (Form2.mainWindow.CheckBox_SameRules.Checked == false)
            {
                if (Form2.mainWindow.CheckBox_DriveThroughPenaltyRace2.Checked)
                {
                    driveThroughPenaltyRace2 = "        \"DriveThroughPenalty\" : 1,";
                }
                else
                {
                    driveThroughPenaltyRace2 = "        \"DriveThroughPenalty\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_DriveThroughPenaltyRace3.Checked)
                {
                    driveThroughPenaltyRace3 = "        \"DriveThroughPenalty\" : 1,";
                }
                else
                {
                    driveThroughPenaltyRace3 = "        \"DriveThroughPenalty\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_DriveThroughPenaltyRace4.Checked)
                {
                    driveThroughPenaltyRace4 = "        \"DriveThroughPenalty\" : 1,";
                }
                else
                {
                    driveThroughPenaltyRace4 = "        \"DriveThroughPenalty\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_DriveThroughPenaltyRace5.Checked)
                {
                    driveThroughPenaltyRace5 = "        \"DriveThroughPenalty\" : 1,";
                }
                else
                {
                    driveThroughPenaltyRace5 = "        \"DriveThroughPenalty\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_DriveThroughPenaltyRace6.Checked)
                {
                    driveThroughPenaltyRace6 = "        \"DriveThroughPenalty\" : 1,";
                }
                else
                {
                    driveThroughPenaltyRace6 = "        \"DriveThroughPenalty\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_DriveThroughPenaltyRace7.Checked)
                {
                    driveThroughPenaltyRace7 = "        \"DriveThroughPenalty\" : 1,";
                }
                else
                {
                    driveThroughPenaltyRace7 = "        \"DriveThroughPenalty\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_DriveThroughPenaltyRace8.Checked)
                {
                    driveThroughPenaltyRace8 = "        \"DriveThroughPenalty\" : 1,";
                }
                else
                {
                    driveThroughPenaltyRace8 = "        \"DriveThroughPenalty\" : 0,";
                }
            }
            
        }



        private void Penalties()
        {
            if (Form2.mainWindow.CheckBox_PenaltiesRace1.Checked)
            {
                penaltiesRace1 = "\"FULL\",";
            }
            else
            {
                penaltiesRace1 = "\"NONE\",";
            }
            if (Form2.mainWindow.CheckBox_SameRules.Checked == false)
            {
                if (Form2.mainWindow.CheckBox_PenaltiesRace2.Checked)
                {
                    penaltiesRace2 = "        \"PenaltiesType\" : \"FULL\",";
                }
                else
                {
                    penaltiesRace2 = "        \"PenaltiesType\" : \"NONE\",";
                }
                if (Form2.mainWindow.CheckBox_PenaltiesRace3.Checked)
                {
                    penaltiesRace3 = "        \"PenaltiesType\" : \"FULL\",";
                }
                else
                {
                    penaltiesRace3 = "        \"PenaltiesType\" : \"NONE\",";
                }
                if (Form2.mainWindow.CheckBox_PenaltiesRace4.Checked)
                {
                    penaltiesRace4 = "        \"PenaltiesType\" : \"FULL\",";
                }
                else
                {
                    penaltiesRace4 = "        \"PenaltiesType\" : \"NONE\",";
                }
                if (Form2.mainWindow.CheckBox_PenaltiesRace5.Checked)
                {
                    penaltiesRace5 = "        \"PenaltiesType\" : \"FULL\",";
                }
                else
                {
                    penaltiesRace5 = "        \"PenaltiesType\" : \"NONE\",";
                }
                if (Form2.mainWindow.CheckBox_PenaltiesRace6.Checked)
                {
                    penaltiesRace6 = "        \"PenaltiesType\" : \"FULL\",";
                }
                else
                {
                    penaltiesRace6 = "        \"PenaltiesType\" : \"NONE\",";
                }
                if (Form2.mainWindow.CheckBox_PenaltiesRace7.Checked)
                {
                    penaltiesRace7 = "        \"PenaltiesType\" : \"FULL\",";
                }
                else
                {
                    penaltiesRace7 = "        \"PenaltiesType\" : \"NONE\",";
                }
                if (Form2.mainWindow.CheckBox_PenaltiesRace8.Checked)
                {
                    penaltiesRace8 = "        \"PenaltiesType\" : \"FULL\",";
                }
                else
                {
                    penaltiesRace8 = "        \"PenaltiesType\" : \"NONE\",";
                }
            }
            

        }

        private void PitLinePenaltie()
        {
            if (Form2.mainWindow.CheckBox_PitLinePenaltyRace1.Checked)
            {
                pitLinePenaltiesRace1 = "\"PitWhiteLinePenalty\" : 1,";
            }
            else
            {
                pitLinePenaltiesRace1 = "\"PitWhiteLinePenalty\" : 0,";
            }

            if (Form2.mainWindow.CheckBox_SameRules.Checked == false)
            {
                if (Form2.mainWindow.CheckBox_PitLinePenaltyRace2.Checked)
                {
                    pitLinePenaltiesRace2 = "\"PitWhiteLinePenalty\" : 1,";
                }
                else
                {
                    pitLinePenaltiesRace2 = "\"PitWhiteLinePenalty\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_PitLinePenaltyRace3.Checked)
                {
                    pitLinePenaltiesRace3 = "\"PitWhiteLinePenalty\" : 1,";
                }
                else
                {
                    pitLinePenaltiesRace3 = "\"PitWhiteLinePenalty\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_PitLinePenaltyRace4.Checked)
                {
                    pitLinePenaltiesRace4 = "\"PitWhiteLinePenalty\" : 1,";
                }
                else
                {
                    pitLinePenaltiesRace4 = "\"PitWhiteLinePenalty\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_PitLinePenaltyRace5.Checked)
                {
                    pitLinePenaltiesRace5 = "\"PitWhiteLinePenalty\" : 1,";
                }
                else
                {
                    pitLinePenaltiesRace5 = "\"PitWhiteLinePenalty\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_PitLinePenaltyRace6.Checked)
                {
                    pitLinePenaltiesRace6 = "\"PitWhiteLinePenalty\" : 1,";
                }
                else
                {
                    pitLinePenaltiesRace6 = "\"PitWhiteLinePenalty\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_PitLinePenaltyRace7.Checked)
                {
                    pitLinePenaltiesRace7 = "\"PitWhiteLinePenalty\" : 1,";
                }
                else
                {
                    pitLinePenaltiesRace7 = "\"PitWhiteLinePenalty\" : 0,";
                }
                if (Form2.mainWindow.CheckBox_PitLinePenaltyRace8.Checked)
                {
                    pitLinePenaltiesRace8 = "\"PitWhiteLinePenalty\" : 1,";
                }
                else
                {
                    pitLinePenaltiesRace8 = "\"PitWhiteLinePenalty\" : 0,";
                }
            }
        }

        private void PersistIndex()
        {
            if (Form2.mainWindow.CheckBox_PersistIndex.Checked)
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

        public void ChoiceOfUniqueCarOrclassRace2()
        {
            //choice class Race 2



            if (Form2.mainWindow.RadioButton_Race2CarByClass.Checked)
            {
                // choice of vehicle classes

                if (Form2.mainWindow.CbBox_Race2ClassSlots.SelectedIndex == 0)
                {
                    choiceCar2 = "        \"VehicleClassId\" : \"" + Form2.mainWindow.CbBox_Race2Class1.Text + "\", \r\n";
                }
                else if (Form2.mainWindow.CbBox_Race2ClassSlots.SelectedIndex == 1)
                {
                    choiceCar2 =
                    "        \"VehicleClassId\" : \"" + Form2.mainWindow.CbBox_Race2Class1.Text + "\", \r\n" +
                    "        \"MultiClassSlots\" : " + Form2.mainWindow.CbBox_Race2ClassSlots.SelectedIndex + "," + "\r\n" +
                    "        \"MultiClassSlot1\" : \"" + Form2.mainWindow.CbBox_Race2Class2.Text + "\", \r\n";
                }
                else if (Form2.mainWindow.CbBox_Race2ClassSlots.SelectedIndex == 2)
                {
                    choiceCar2 =
                    "        \"VehicleClassId\" : \"" + Form2.mainWindow.CbBox_Race2Class1.Text + "\", \r\n" +
                    "        \"MultiClassSlots\" : " + Form2.mainWindow.CbBox_Race2ClassSlots.SelectedIndex + "," + "\r\n" +
                    "        \"MultiClassSlot1\" : \"" + Form2.mainWindow.CbBox_Race2Class2.Text + "\", \r\n" +
                    "        \"MultiClassSlot2\" : \"" + Form2.mainWindow.CbBox_Race2Class3.Text + "\", \r\n";
                }
                else if (Form2.mainWindow.CbBox_Race2ClassSlots.SelectedIndex == 3)
                {
                    choiceCar2 =
                    "        \"VehicleClassId\" : \"" + Form2.mainWindow.CbBox_Race2Class1.Text + "\", \r\n" +
                    "        \"MultiClassSlots\" : " + Form2.mainWindow.CbBox_Race2ClassSlots.SelectedIndex + "," + "\r\n" +
                    "        \"MultiClassSlot1\" : \"" + Form2.mainWindow.CbBox_Race2Class2.Text + "\", \r\n" +
                    "        \"MultiClassSlot2\" : \"" + Form2.mainWindow.CbBox_Race2Class3.Text + "\", \r\n" +
                    "        \"MultiClassSlot3\" : \"" + Form2.mainWindow.CbBox_Race2Class4.Text + "\", \r\n";

                }
            }

            else if (Form2.mainWindow.RadioButton_Race2UniqueCar.Checked)
            {
                choiceCar2 = "        \"VehicleModelId\" : " + "\"" + Form2.mainWindow.CbBox_Race2Cars.Text + "\",";
            }
        }

        public void ChoiceOfUniqueCarOrclassRace3()
        {
            //choice class Race 3
            if (Form2.mainWindow.RadioButton_Race3CarByClass.Checked)
            {
                // choice of vehicle classes

                if (Form2.mainWindow.CbBox_Race3ClassSlots.SelectedIndex == 0)
                {
                    choiceCar3 = "        \"VehicleClassId\" : \"" + Form2.mainWindow.CbBox_Race3Class1.Text + "\", \r\n";
                }
                else if (Form2.mainWindow.CbBox_Race3ClassSlots.SelectedIndex == 1)
                {
                    choiceCar3 =
                    "        \"VehicleClassId\" : \"" + Form2.mainWindow.CbBox_Race3Class1.Text + "\", \r\n" +
                    "        \"MultiClassSlots\" : " + Form2.mainWindow.CbBox_Race3ClassSlots.SelectedIndex + "," + "\r\n" +
                    "        \"MultiClassSlot1\" : \"" + Form2.mainWindow.CbBox_Race3Class2.Text + "\", \r\n";
                }
                else if (Form2.mainWindow.CbBox_Race3ClassSlots.SelectedIndex == 2)
                {
                    choiceCar3 =
                    "        \"VehicleClassId\" : \"" + Form2.mainWindow.CbBox_Race3Class1.Text + "\", \r\n" +
                    "        \"MultiClassSlots\" : " + Form2.mainWindow.CbBox_Race3ClassSlots.SelectedIndex + "," + "\r\n" +
                    "        \"MultiClassSlot1\" : \"" + Form2.mainWindow.CbBox_Race3Class2.Text + "\", \r\n" +
                    "        \"MultiClassSlot2\" : \"" + Form2.mainWindow.CbBox_Race3Class3.Text + "\", \r\n";
                }
                else if (Form2.mainWindow.CbBox_Race3ClassSlots.SelectedIndex == 3)
                {
                    choiceCar3 =
                    "        \"VehicleClassId\" : \"" + Form2.mainWindow.CbBox_Race3Class1.Text + "\", \r\n" +
                    "        \"MultiClassSlots\" : " + Form2.mainWindow.CbBox_Race3ClassSlots.SelectedIndex + "," + "\r\n" +
                    "        \"MultiClassSlot1\" : \"" + Form2.mainWindow.CbBox_Race3Class2.Text + "\", \r\n" +
                    "        \"MultiClassSlot2\" : \"" + Form2.mainWindow.CbBox_Race3Class3.Text + "\", \r\n" +
                    "        \"MultiClassSlot3\" : \"" + Form2.mainWindow.CbBox_Race3Class4.Text + "\", \r\n";

                }
            }

            else if (Form2.mainWindow.RadioButton_Race3UniqueCar.Checked)
            {
                choiceCar3 = "        \"VehicleModelId\" : " + "\"" + Form2.mainWindow.CbBox_Race3Cars.Text + "\",";
            }
        }

        public void ChoiceOfUniqueCarOrclassRace4()
        {
            //choice class Race 4



            if (Form2.mainWindow.RadioButton_Race4CarByClass.Checked)
            {
                // choice of vehicle classes

                if (Form2.mainWindow.CbBox_Race4ClassSlots.SelectedIndex == 0)
                {
                    choiceCar4 = "        \"VehicleClassId\" : \"" + Form2.mainWindow.CbBox_Race4Class1.Text + "\", \r\n";
                }
                else if (Form2.mainWindow.CbBox_Race4ClassSlots.SelectedIndex == 1)
                {
                    choiceCar4 =
                    "        \"VehicleClassId\" : \"" + Form2.mainWindow.CbBox_Race4Class1.Text + "\", \r\n" +
                    "        \"MultiClassSlots\" : " + Form2.mainWindow.CbBox_Race4ClassSlots.SelectedIndex + "," + "\r\n" +
                    "        \"MultiClassSlot1\" : \"" + Form2.mainWindow.CbBox_Race4Class2.Text + "\", \r\n";
                }
                else if (Form2.mainWindow.CbBox_Race4ClassSlots.SelectedIndex == 2)
                {
                    choiceCar4 =
                    "        \"VehicleClassId\" : \"" + Form2.mainWindow.CbBox_Race4Class1.Text + "\", \r\n" +
                    "        \"MultiClassSlots\" : " + Form2.mainWindow.CbBox_Race4ClassSlots.SelectedIndex + "," + "\r\n" +
                    "        \"MultiClassSlot1\" : \"" + Form2.mainWindow.CbBox_Race4Class2.Text + "\", \r\n" +
                    "        \"MultiClassSlot2\" : \"" + Form2.mainWindow.CbBox_Race4Class3.Text + "\", \r\n";
                }
                else if (Form2.mainWindow.CbBox_Race4ClassSlots.SelectedIndex == 3)
                {
                    choiceCar4 =
                    "        \"VehicleClassId\" : \"" + Form2.mainWindow.CbBox_Race4Class1.Text + "\", \r\n" +
                    "        \"MultiClassSlots\" : " + Form2.mainWindow.CbBox_Race4ClassSlots.SelectedIndex + "," + "\r\n" +
                    "        \"MultiClassSlot1\" : \"" + Form2.mainWindow.CbBox_Race4Class2.Text + "\", \r\n" +
                    "        \"MultiClassSlot2\" : \"" + Form2.mainWindow.CbBox_Race4Class3.Text + "\", \r\n" +
                    "        \"MultiClassSlot3\" : \"" + Form2.mainWindow.CbBox_Race4Class4.Text + "\", \r\n";

                }
            }

            else if (Form2.mainWindow.RadioButton_Race4UniqueCar.Checked)
            {
                choiceCar4 = "        \"VehicleModelId\" : " + "\"" + Form2.mainWindow.CbBox_Race4Cars.Text + "\",";
            }
        }

        public void ChoiceOfUniqueCarOrclassRace5()
        {
            //choice class Race 5
            if (Form2.mainWindow.RadioButton_Race5CarByClass.Checked)
            {
                // choice of vehicle classes

                if (Form2.mainWindow.CbBox_Race5ClassSlots.SelectedIndex == 0)
                {
                    choiceCar5 = "        \"VehicleClassId\" : \"" + Form2.mainWindow.CbBox_Race5Class1.Text + "\", \r\n";
                }
                else if (Form2.mainWindow.CbBox_Race5ClassSlots.SelectedIndex == 1)
                {
                    choiceCar5 =
                    "        \"VehicleClassId\" : \"" + Form2.mainWindow.CbBox_Race5Class1.Text + "\", \r\n" +
                    "        \"MultiClassSlots\" : " + Form2.mainWindow.CbBox_Race5ClassSlots.SelectedIndex + "," + "\r\n" +
                    "        \"MultiClassSlot1\" : \"" + Form2.mainWindow.CbBox_Race5Class2.Text + "\", \r\n";
                }
                else if (Form2.mainWindow.CbBox_Race5ClassSlots.SelectedIndex == 2)
                {
                    choiceCar5 =
                    "        \"VehicleClassId\" : \"" + Form2.mainWindow.CbBox_Race5Class1.Text + "\", \r\n" +
                    "        \"MultiClassSlots\" : " + Form2.mainWindow.CbBox_Race5ClassSlots.SelectedIndex + "," + "\r\n" +
                    "        \"MultiClassSlot1\" : \"" + Form2.mainWindow.CbBox_Race5Class2.Text + "\", \r\n" +
                    "        \"MultiClassSlot2\" : \"" + Form2.mainWindow.CbBox_Race5Class3.Text + "\", \r\n";
                }
                else if (Form2.mainWindow.CbBox_Race5ClassSlots.SelectedIndex == 3)
                {
                    choiceCar5 =
                    "        \"VehicleClassId\" : \"" + Form2.mainWindow.CbBox_Race5Class1.Text + "\", \r\n" +
                    "        \"MultiClassSlots\" : " + Form2.mainWindow.CbBox_Race5ClassSlots.SelectedIndex + "," + "\r\n" +
                    "        \"MultiClassSlot1\" : \"" + Form2.mainWindow.CbBox_Race5Class2.Text + "\", \r\n" +
                    "        \"MultiClassSlot2\" : \"" + Form2.mainWindow.CbBox_Race5Class3.Text + "\", \r\n" +
                    "        \"MultiClassSlot3\" : \"" + Form2.mainWindow.CbBox_Race5Class4.Text + "\", \r\n";
                }
            }

            else if (Form2.mainWindow.RadioButton_Race5UniqueCar.Checked)
            {
                choiceCar5 = "        \"VehicleModelId\" : " + "\"" + Form2.mainWindow.CbBox_Race5Cars.Text + "\",";
            }
        }

        public void ChoiceOfUniqueCarOrclassRace6()
        {
            //choice class Race 3



            if (Form2.mainWindow.RadioButton_Race6CarByClass.Checked)
            {
                // choice of vehicle classes

                if (Form2.mainWindow.CbBox_Race6ClassSlots.SelectedIndex == 0)
                {
                    choiceCar6 = "        \"VehicleClassId\" : \"" + Form2.mainWindow.CbBox_Race6Class1.Text + "\", \r\n";
                }
                else if (Form2.mainWindow.CbBox_Race6ClassSlots.SelectedIndex == 1)
                {
                    choiceCar6 =
                    "        \"VehicleClassId\" : \"" + Form2.mainWindow.CbBox_Race6Class1.Text + "\", \r\n" +
                    "        \"MultiClassSlots\" : " + Form2.mainWindow.CbBox_Race6ClassSlots.SelectedIndex + "," + "\r\n" +
                    "        \"MultiClassSlot1\" : \"" + Form2.mainWindow.CbBox_Race6Class2.Text + "\", \r\n";
                }
                else if (Form2.mainWindow.CbBox_Race6ClassSlots.SelectedIndex == 2)
                {
                    choiceCar6 =
                    "        \"VehicleClassId\" : \"" + Form2.mainWindow.CbBox_Race6Class1.Text + "\", \r\n" +
                    "        \"MultiClassSlots\" : " + Form2.mainWindow.CbBox_Race6ClassSlots.SelectedIndex + "," + "\r\n" +
                    "        \"MultiClassSlot1\" : \"" + Form2.mainWindow.CbBox_Race6Class2.Text + "\", \r\n" +
                    "        \"MultiClassSlot2\" : \"" + Form2.mainWindow.CbBox_Race6Class3.Text + "\", \r\n";
                }
                else if (Form2.mainWindow.CbBox_Race6ClassSlots.SelectedIndex == 3)
                {
                    choiceCar6 =
                    "        \"VehicleClassId\" : \"" + Form2.mainWindow.CbBox_Race6Class1.Text + "\", \r\n" +
                    "        \"MultiClassSlots\" : " + Form2.mainWindow.CbBox_Race6ClassSlots.SelectedIndex + "," + "\r\n" +
                    "        \"MultiClassSlot1\" : \"" + Form2.mainWindow.CbBox_Race6Class2.Text + "\", \r\n" +
                    "        \"MultiClassSlot2\" : \"" + Form2.mainWindow.CbBox_Race6Class3.Text + "\", \r\n" +
                    "        \"MultiClassSlot3\" : \"" + Form2.mainWindow.CbBox_Race6Class4.Text + "\", \r\n";

                }
            }

            else if (Form2.mainWindow.RadioButton_Race6UniqueCar.Checked)
            {
                choiceCar6 = "        \"VehicleModelId\" : " + "\"" + Form2.mainWindow.CbBox_Race6Cars.Text + "\",";


            }
        }

        public void ChoiceOfUniqueCarOrclassRace7()
        {
            //choice class Race 7



            if (Form2.mainWindow.RadioButton_Race7CarByClass.Checked)
            {
                // choice of vehicle classes

                if (Form2.mainWindow.CbBox_Race7ClassSlots.SelectedIndex == 0)
                {
                    choiceCar7 = "        \"VehicleClassId\" : \"" + Form2.mainWindow.CbBox_Race7Class1.Text + "\", \r\n";
                }
                else if (Form2.mainWindow.CbBox_Race7ClassSlots.SelectedIndex == 1)
                {
                    choiceCar7 =
                    "        \"VehicleClassId\" : \"" + Form2.mainWindow.CbBox_Race7Class1.Text + "\", \r\n" +
                    "        \"MultiClassSlots\" : " + Form2.mainWindow.CbBox_Race7ClassSlots.SelectedIndex + "," + "\r\n" +
                    "        \"MultiClassSlot1\" : \"" + Form2.mainWindow.CbBox_Race7Class2.Text + "\", \r\n";
                }
                else if (Form2.mainWindow.CbBox_Race7ClassSlots.SelectedIndex == 2)
                {
                    choiceCar7 =
                    "        \"VehicleClassId\" : \"" + Form2.mainWindow.CbBox_Race7Class1.Text + "\", \r\n" +
                    "        \"MultiClassSlots\" : " + Form2.mainWindow.CbBox_Race7ClassSlots.SelectedIndex + "," + "\r\n" +
                    "        \"MultiClassSlot1\" : \"" + Form2.mainWindow.CbBox_Race7Class2.Text + "\", \r\n" +
                    "        \"MultiClassSlot2\" : \"" + Form2.mainWindow.CbBox_Race7Class3.Text + "\", \r\n";
                }
                else if (Form2.mainWindow.CbBox_Race7ClassSlots.SelectedIndex == 3)
                {
                    choiceCar7 =
                    "        \"VehicleClassId\" : \"" + Form2.mainWindow.CbBox_Race7Class1.Text + "\", \r\n" +
                    "        \"MultiClassSlots\" : " + Form2.mainWindow.CbBox_Race7ClassSlots.SelectedIndex + "," + "\r\n" +
                    "        \"MultiClassSlot1\" : \"" + Form2.mainWindow.CbBox_Race7Class2.Text + "\", \r\n" +
                    "        \"MultiClassSlot2\" : \"" + Form2.mainWindow.CbBox_Race7Class3.Text + "\", \r\n" +
                    "        \"MultiClassSlot3\" : \"" + Form2.mainWindow.CbBox_Race7Class4.Text + "\", \r\n";

                }
            }

            else if (Form2.mainWindow.RadioButton_Race7UniqueCar.Checked)
            {
                choiceCar7 = "        \"VehicleModelId\" : " + "\"" + Form2.mainWindow.CbBox_Race7Cars.Text + "\",";


            }
        }
        public void ChoiceOfUniqueCarOrclassRace8()
        {
            //choice class Race 8



            if (Form2.mainWindow.RadioButton_Race8CarByClass.Checked)
            {
                // choice of vehicle classes

                if (Form2.mainWindow.CbBox_Race8ClassSlots.SelectedIndex == 0)
                {
                    choiceCar8 = "        \"VehicleClassId\" : \"" + Form2.mainWindow.CbBox_Race8Class1.Text + "\", \r\n";
                }
                else if (Form2.mainWindow.CbBox_Race8ClassSlots.SelectedIndex == 1)
                {
                    choiceCar8 =
                    "        \"VehicleClassId\" : \"" + Form2.mainWindow.CbBox_Race8Class1.Text + "\", \r\n" +
                    "        \"MultiClassSlots\" : " + Form2.mainWindow.CbBox_Race8ClassSlots.SelectedIndex + "," + "\r\n" +
                    "        \"MultiClassSlot1\" : \"" + Form2.mainWindow.CbBox_Race8Class2.Text + "\", \r\n";
                }
                else if (Form2.mainWindow.CbBox_Race8ClassSlots.SelectedIndex == 2)
                {
                    choiceCar8 =
                    "        \"VehicleClassId\" : \"" + Form2.mainWindow.CbBox_Race8Class1.Text + "\", \r\n" +
                    "        \"MultiClassSlots\" : " + Form2.mainWindow.CbBox_Race8ClassSlots.SelectedIndex + "," + "\r\n" +
                    "        \"MultiClassSlot1\" : \"" + Form2.mainWindow.CbBox_Race8Class2.Text + "\", \r\n" +
                    "        \"MultiClassSlot2\" : \"" + Form2.mainWindow.CbBox_Race8Class3.Text + "\", \r\n";
                }
                else if (Form2.mainWindow.CbBox_Race8ClassSlots.SelectedIndex == 3)
                {
                    choiceCar8 =
                    "        \"VehicleClassId\" : \"" + Form2.mainWindow.CbBox_Race8Class1.Text + "\", \r\n" +
                    "        \"MultiClassSlots\" : " + Form2.mainWindow.CbBox_Race8ClassSlots.SelectedIndex + "," + "\r\n" +
                    "        \"MultiClassSlot1\" : \"" + Form2.mainWindow.CbBox_Race8Class2.Text + "\", \r\n" +
                    "        \"MultiClassSlot2\" : \"" + Form2.mainWindow.CbBox_Race8Class3.Text + "\", \r\n" +
                    "        \"MultiClassSlot3\" : \"" + Form2.mainWindow.CbBox_Race8Class4.Text + "\", \r\n";

                }
            }

            else if (Form2.mainWindow.RadioButton_Race8UniqueCar.Checked)
            {
                choiceCar8 = "        \"VehicleModelId\" : " + "\"" + Form2.mainWindow.CbBox_Race8Cars.Text + "\",";

            }
        }

        private void RulesRace2()
        {


            if (Form2.mainWindow.CheckBox_SameRules.Checked)
            {
                rulesRace2 = "";
            }
            else
            {
                rulesRace2 =

                "        \"MinimumOnlineRank\" : \"" + Form2.mainWindow.CbBox_RankRace2.Text + "\",\r\n" +
                "        \"MinimumOnlineStrength\" : " + Form2.mainWindow.TxtBox_RankRace2.Text + ",\r\n" +
                "\r\n" +
                "        \"DamageType\" : " + "\"" + Form2.mainWindow.damage2 + "\"," + "\r\n" +
                "        \"TireWearType\" : " + "\"" + Form2.mainWindow.CbBox_TireWearRace2.SelectedValue + "\", \r\n" +
                "        \"FuelUsageType\" : " + "\"" + Form2.mainWindow.CbBox_FuelUsageRace2.SelectedValue + "\", \r\n" +
                "        \"AllowedViews\" : " + "\"" + Form2.mainWindow.CbBox_AllowedViewsRace2.SelectedValue + "\", \r\n" +
                penaltiesRace2 + "\r\n" +
                "        " + pitLinePenaltiesRace2 + "\r\n" +
                driveThroughPenaltyRace2 + "\r\n" +
                "        \"AllowablePenaltyTime\" : " + Form2.mainWindow.CbBox_PenaltyTimeRace2.Text + ", \r\n" +
                "        " + manualPitStopRace2 + "\r\n" +
                "\r\n" +
                "\r\n" +
                "        " + raceMandatoryPitStops2 + "\r\n" +
                "        " + raceRollingStart2 + "\r\n" +
                "        " + manualRollingStarts2 + "\r\n" +
                "        " + raceFormationLap2 + "\r\n";
            }
        }

        private void RulesRace3()
        {


            if (Form2.mainWindow.CheckBox_SameRules.Checked)
            {
                rulesRace3 = "";
            }
            else
            {
                rulesRace3 =

                "        \"MinimumOnlineRank\" : \"" + Form2.mainWindow.CbBox_RankRace3.Text + "\",\r\n" +
                "        \"MinimumOnlineStrength\" : " + Form2.mainWindow.TxtBox_RankRace3.Text + ",\r\n" +
                "\r\n" +
                "        \"DamageType\" : " + "\"" + Form2.mainWindow.damage2 + "\"," + "\r\n" +
                "        \"TireWearType\" : " + "\"" + Form2.mainWindow.CbBox_TireWearRace3.SelectedValue + "\", \r\n" +
                "        \"FuelUsageType\" : " + "\"" + Form2.mainWindow.CbBox_FuelUsageRace3.SelectedValue + "\", \r\n" +
                "        \"AllowedViews\" : " + "\"" + Form2.mainWindow.CbBox_AllowedViewsRace3.SelectedValue + "\", \r\n" +
                penaltiesRace3 + "\r\n" +
                "        " + pitLinePenaltiesRace3 + "\r\n" +
                driveThroughPenaltyRace3 + "\r\n" +
                "        \"AllowablePenaltyTime\" : " + Form2.mainWindow.CbBox_PenaltyTimeRace3.Text + ", \r\n" +
                "        " + manualPitStopRace3 + "\r\n" +
                "\r\n" +
                "\r\n" +
                "        " + raceMandatoryPitStops3 + "\r\n" +
                "        " + raceRollingStart3 + "\r\n" +
                "        " + manualRollingStarts3 + "\r\n" +
                "        " + raceFormationLap3 + "\r\n";
            }
        }

        private void RulesRace4()
        {


            if (Form2.mainWindow.CheckBox_SameRules.Checked)
            {
                rulesRace4 = "";
            }
            else
            {
                rulesRace4 =

                "        \"MinimumOnlineRank\" : \"" + Form2.mainWindow.CbBox_RankRace4.Text + "\",\r\n" +
                "        \"MinimumOnlineStrength\" : " + Form2.mainWindow.TxtBox_RankRace4.Text + ",\r\n" +
                "\r\n" +
                "        \"DamageType\" : " + "\"" + Form2.mainWindow.damage2 + "\"," + "\r\n" +
                "        \"TireWearType\" : " + "\"" + Form2.mainWindow.CbBox_TireWearRace4.SelectedValue + "\", \r\n" +
                "        \"FuelUsageType\" : " + "\"" + Form2.mainWindow.CbBox_FuelUsageRace4.SelectedValue + "\", \r\n" +
                "        \"AllowedViews\" : " + "\"" + Form2.mainWindow.CbBox_AllowedViewsRace4.SelectedValue + "\", \r\n" +
                penaltiesRace4 + "\r\n" +
                "        " + pitLinePenaltiesRace4 + "\r\n" +
                driveThroughPenaltyRace4 + "\r\n" +
                "        \"AllowablePenaltyTime\" : " + Form2.mainWindow.CbBox_PenaltyTimeRace4.Text + ", \r\n" +
                "        " + manualPitStopRace4 + "\r\n" +
                "\r\n" +
                "\r\n" +
                "        " + raceMandatoryPitStops4 + "\r\n" +
                "        " + raceRollingStart4 + "\r\n" +
                "        " + manualRollingStarts4 + "\r\n" +
                "        " + raceFormationLap4 + "\r\n";
            }
        }

        private void RulesRace5()
        {


            if (Form2.mainWindow.CheckBox_SameRules.Checked)
            {
                rulesRace5 = "";
            }
            else
            {
                rulesRace5 =

                "        \"MinimumOnlineRank\" : \"" + Form2.mainWindow.CbBox_RankRace5.Text + "\",\r\n" +
                "        \"MinimumOnlineStrength\" : " + Form2.mainWindow.TxtBox_RankRace5.Text + ",\r\n" +
                "\r\n" +
                "        \"DamageType\" : " + "\"" + Form2.mainWindow.damage2 + "\"," + "\r\n" +
                "        \"TireWearType\" : " + "\"" + Form2.mainWindow.CbBox_TireWearRace5.SelectedValue + "\", \r\n" +
                "        \"FuelUsageType\" : " + "\"" + Form2.mainWindow.CbBox_FuelUsageRace5.SelectedValue + "\", \r\n" +
                "        \"AllowedViews\" : " + "\"" + Form2.mainWindow.CbBox_AllowedViewsRace5.SelectedValue + "\", \r\n" +
                penaltiesRace5 + "\r\n" +
                "        " + pitLinePenaltiesRace5 + "\r\n" +
                driveThroughPenaltyRace5 + "\r\n" +
                "        \"AllowablePenaltyTime\" : " + Form2.mainWindow.CbBox_PenaltyTimeRace5.Text + ", \r\n" +
                "        " + manualPitStopRace5 + "\r\n" +
                "\r\n" +
                "\r\n" +
                "        " + raceMandatoryPitStops5 + "\r\n" +
                "        " + raceRollingStart5 + "\r\n" +
                "        " + manualRollingStarts5 + "\r\n" +
                "        " + raceFormationLap5 + "\r\n";
            }
        }

        private void RulesRace6()
        {


            if (Form2.mainWindow.CheckBox_SameRules.Checked)
            {
                rulesRace6 = "";
            }
            else
            {
                rulesRace6 =

                "        \"MinimumOnlineRank\" : \"" + Form2.mainWindow.CbBox_RankRace6.Text + "\",\r\n" +
                "        \"MinimumOnlineStrength\" : " + Form2.mainWindow.TxtBox_RankRace6.Text + ",\r\n" +
                "\r\n" +
                "        \"DamageType\" : " + "\"" + Form2.mainWindow.damage2 + "\"," + "\r\n" +
                "        \"TireWearType\" : " + "\"" + Form2.mainWindow.CbBox_TireWearRace6.SelectedValue + "\", \r\n" +
                "        \"FuelUsageType\" : " + "\"" + Form2.mainWindow.CbBox_FuelUsageRace6.SelectedValue + "\", \r\n" +
                "        \"AllowedViews\" : " + "\"" + Form2.mainWindow.CbBox_AllowedViewsRace6.SelectedValue + "\", \r\n" +
                penaltiesRace6 + "\r\n" +
                "        " + pitLinePenaltiesRace6 + "\r\n" +
                driveThroughPenaltyRace6 + "\r\n" +
                "        \"AllowablePenaltyTime\" : " + Form2.mainWindow.CbBox_PenaltyTimeRace6.Text + ", \r\n" +
                "        " + manualPitStopRace6 + "\r\n" +
                "\r\n" +
                "\r\n" +
                "        " + raceMandatoryPitStops6 + "\r\n" +
                "        " + raceRollingStart6 + "\r\n" +
                "        " + manualRollingStarts6 + "\r\n" +
                "        " + raceFormationLap6 + "\r\n";
            }
        }

        private void RulesRace7()
        {


            if (Form2.mainWindow.CheckBox_SameRules.Checked)
            {
                rulesRace7 = "";
            }
            else
            {
                rulesRace7 =

                "        \"MinimumOnlineRank\" : \"" + Form2.mainWindow.CbBox_RankRace7.Text + "\",\r\n" +
                "        \"MinimumOnlineStrength\" : " + Form2.mainWindow.TxtBox_RankRace7.Text + ",\r\n" +
                "\r\n" +
                "        \"DamageType\" : " + "\"" + Form2.mainWindow.damage2 + "\"," + "\r\n" +
                "        \"TireWearType\" : " + "\"" + Form2.mainWindow.CbBox_TireWearRace7.SelectedValue + "\", \r\n" +
                "        \"FuelUsageType\" : " + "\"" + Form2.mainWindow.CbBox_FuelUsageRace7.SelectedValue + "\", \r\n" +
                "        \"AllowedViews\" : " + "\"" + Form2.mainWindow.CbBox_AllowedViewsRace7.SelectedValue + "\", \r\n" +
                penaltiesRace7 + "\r\n" +
                "        " + pitLinePenaltiesRace7 + "\r\n" +
                driveThroughPenaltyRace7 + "\r\n" +
                "        \"AllowablePenaltyTime\" : " + Form2.mainWindow.CbBox_PenaltyTimeRace7.Text + ", \r\n" +
                "        " + manualPitStopRace7 + "\r\n" +
                "\r\n" +
                "\r\n" +
                "        " + raceMandatoryPitStops7 + "\r\n" +
                "        " + raceRollingStart7 + "\r\n" +
                "        " + manualRollingStarts7 + "\r\n" +
                "        " + raceFormationLap7 + "\r\n";
            }
        }

        private void RulesRace8()
        {


            if (Form2.mainWindow.CheckBox_SameRules.Checked)
            {
                rulesRace8 = "";
            }
            else
            {
                rulesRace8 =

                "        \"MinimumOnlineRank\" : \"" + Form2.mainWindow.CbBox_RankRace8.Text + "\",\r\n" +
                "        \"MinimumOnlineStrength\" : " + Form2.mainWindow.TxtBox_RankRace8.Text + ",\r\n" +
                "\r\n" +
                "        \"DamageType\" : " + "\"" + Form2.mainWindow.damage2 + "\"," + "\r\n" +
                "        \"TireWearType\" : " + "\"" + Form2.mainWindow.CbBox_TireWearRace8.SelectedValue + "\", \r\n" +
                "        \"FuelUsageType\" : " + "\"" + Form2.mainWindow.CbBox_FuelUsageRace8.SelectedValue + "\", \r\n" +
                "        \"AllowedViews\" : " + "\"" + Form2.mainWindow.CbBox_AllowedViewsRace8.SelectedValue + "\", \r\n" +
                penaltiesRace8 + "\r\n" +
                "        " + pitLinePenaltiesRace8 + "\r\n" +
                driveThroughPenaltyRace8 + "\r\n" +
                "        \"AllowablePenaltyTime\" : " + Form2.mainWindow.CbBox_PenaltyTimeRace8.Text + ", \r\n" +
                "        " + manualPitStopRace8 + "\r\n" +
                "\r\n" +
                "\r\n" +
                "        " + raceMandatoryPitStops8 + "\r\n" +
                "        " + raceRollingStart8 + "\r\n" +
                "        " + manualRollingStarts8 + "\r\n" +
                "        " + raceFormationLap8 + "\r\n";
            }
        }


        private void EditRaces()
        {

            ChoiceOfUniqueCarOrclassRace1();
            ChoiceOfUniqueCarOrclassRace2();
            ChoiceOfUniqueCarOrclassRace3();
            ChoiceOfUniqueCarOrclassRace4();
            ChoiceOfUniqueCarOrclassRace5();
            ChoiceOfUniqueCarOrclassRace6();
            ChoiceOfUniqueCarOrclassRace7();
            ChoiceOfUniqueCarOrclassRace8();
            Penalties();
            DriveThroughPenalty();
            ManualPitStop();
            RaceMandatoryPitStop();
            RaceRollingStart();
            ManualRollingStarts();
            RaceFormationLap();
            PitLinePenaltie();
            RulesRace2();
            RulesRace3();
            RulesRace4();
            RulesRace5();
            RulesRace6();
            RulesRace7();
            RulesRace8();


            flags.SaveFlags1();
            flags.SaveFlags2();
            flags.SaveFlags3();
            flags.SaveFlags4();
            flags.SaveFlags5();
            flags.SaveFlags6();
            flags.SaveFlags7();
            flags.SaveFlags8();
            removeFlags1 = "        \"RemoveFlags\" : \"" + string.Join(",", flags.choixFlagsRace1.ToArray()) + "\"";
            removeFlags2 = "        \"RemoveFlags\" : \"" + string.Join(",", flags.choixFlagsRace2.ToArray()) + "\"";
            removeFlags3 = "        \"RemoveFlags\" : \"" + string.Join(",", flags.choixFlagsRace3.ToArray()) + "\"";
            removeFlags4 = "        \"RemoveFlags\" : \"" + string.Join(",", flags.choixFlagsRace3.ToArray()) + "\"";
            removeFlags5 = "        \"RemoveFlags\" : \"" + string.Join(",", flags.choixFlagsRace3.ToArray()) + "\"";
            removeFlags6 = "        \"RemoveFlags\" : \"" + string.Join(",", flags.choixFlagsRace3.ToArray()) + "\"";
            removeFlags7 = "        \"RemoveFlags\" : \"" + string.Join(",", flags.choixFlagsRace3.ToArray()) + "\"";
            removeFlags8 = "        \"RemoveFlags\" : \"" + string.Join(",", flags.choixFlagsRace3.ToArray()) + "\"";


            int i;
            i = Form2.mainWindow.CbBox_NumerOfRace.SelectedIndex;
            // Param for Race1
            race1 =
               "\r\n{" +
               "\r\n" +
               "\r\n" +
               "        \"TrackId\" : \"" + Form2.mainWindow.CbBox_Race1Tracks.Text + "\",\r\n" +

               choiceCar1 +
               "\r\n" +
               "\r\n" +
               removeFlags1 +
               "\r\n}";

            //Param for race2

            if (i < 1)
            {
                race2 = "";
            }
            else
            {
                race2 =
                ",\r\n{" +
                "\r\n" +
                "\r\n" +
                "        \"TrackId\" : \"" + Form2.mainWindow.CbBox_Race2Tracks.Text + "\",\r\n" +
                choiceCar2 +
               "\r\n" +
               "\r\n" +
               "\r\n" +
               "        \"PracticeLength\" : " + Form2.mainWindow.TxtBx_PracticeLengthRace2.Text + ",\r\n" +
               "        \"QualifyLength\" : " + Form2.mainWindow.TxtBx_QualifyLengthRace2.Text + ",\r\n" +
               "        \"RaceLength\" : " + Form2.mainWindow.TxtBx_RaceLengthRace2.Text + ",\r\n" +
               "\r\n" +
               "\r\n" +
                "        \"RaceDateYear\" : " + Form2.mainWindow.dateTimePicker_Race2.Value.Year.ToString() + ",\r\n" +
                "        \"RaceDateMonth\" : " + Form2.mainWindow.dateTimePicker_Race2.Value.Month.ToString() + ",\r\n" +
                "        \"RaceDateDay\" : " + Form2.mainWindow.dateTimePicker_Race2.Value.Day.ToString() + ",\r\n" +
                "\r\n" +
                "\r\n" +
                "        \"PracticeDateHour\" : " + Form2.mainWindow.dateTimePicker_Race2.Value.Hour.ToString() + ",\r\n" +
                "        \"QualifyDateHour\" : " + Form2.mainWindow.dateTimePicker_Race2.Value.Hour.ToString() + ",\r\n" +
                "        \"RaceDateHour\" : " + Form2.mainWindow.dateTimePicker_Race2.Value.Hour.ToString() + ",\r\n" +
                "\r\n" +
                "\r\n" +
                "        \"PracticeDateProgression\" : " + Form2.mainWindow.CbBox_PracticeProgressionRace2.Text + ",\r\n" +
                "        \"QualifyDateProgression\" : " + Form2.mainWindow.CbBox_QualifyProgressionRace2.Text + ",\r\n" +
                "        \"RaceDateProgression\" : " + Form2.mainWindow.CbBox_RaceProgressionRace2.Text + ",\r\n" +
                "\r\n" +
                "\r\n" +
                rulesRace2 +
                "\r\n" +
                "\r\n" +
                "        \"PracticeWeatherSlots\" : " + Form2.mainWindow.CbBox_PracticeWeatherSlotsRace2.Text + ",\r\n" +
                "        \"PracticeWeatherSlot1\" : \"" + Form2.mainWindow.practiceWeatherSlot1Race2 + "\",\r\n" +
                "        \"PracticeWeatherSlot2\" : \"" + Form2.mainWindow.practiceWeatherSlot2Race2 + "\",\r\n" +
                "        \"PracticeWeatherSlot3\" : \"" + Form2.mainWindow.practiceWeatherSlot3Race2 + "\",\r\n" +
                "        \"PracticeWeatherSlot4\" : \"" + Form2.mainWindow.practiceWeatherSlot4Race2 + "\",\r\n" +
                "        \"PracticeWeatherProgression\" : " + Form2.mainWindow.CbBox_SpeedPratcticeWeatherRace2.Text + ",\r\n" +
                "\r\n" +
                "\r\n" +
                "        \"QualifyWeatherSlots\" : " + Form2.mainWindow.CbBox_QualifWeatherSlotsRace2.Text + ",\r\n" +
                "        \"QualifyWeatherSlot1\" : \"" + Form2.mainWindow.qualifyWeatherSlot1Race2 + "\",\r\n" +
                "        \"QualifyWeatherSlot2\" : \"" + Form2.mainWindow.qualifyWeatherSlot2Race2 + "\",\r\n" +
                "        \"QualifyWeatherSlot3\" : \"" + Form2.mainWindow.qualifyWeatherSlot3Race2 + "\",\r\n" +
                "        \"QualifyWeatherSlot4\" : \"" + Form2.mainWindow.qualifyWeatherSlot4Race2 + "\",\r\n" +
                "        \"QualifyWeatherProgression\" : " + Form2.mainWindow.CbBox_SpeedQualifWeatherRace2.Text + ",\r\n" +
                "\r\n" +
                "\r\n" +
                "        \"RaceWeatherSlots\" : " + Form2.mainWindow.CbBox_RaceWeatherSlotsRace2.Text + ",\r\n" +
                "        \"RaceWeatherSlot1\" : \"" + Form2.mainWindow.raceWeatherSlot1Race2 + "\",\r\n" +
                "        \"RaceWeatherSlot2\" : \"" + Form2.mainWindow.raceWeatherSlot2Race2 + "\",\r\n" +
                "        \"RaceWeatherSlot3\" : \"" + Form2.mainWindow.raceWeatherSlot3Race2 + "\",\r\n" +
                "        \"RaceWeatherSlot4\" : \"" + Form2.mainWindow.raceWeatherSlot4Race2 + "\",\r\n" +
                "        \"RaceWeatherProgression\" : " + Form2.mainWindow.CbBox_SpeedRaceWeatherRace2.Text + ",\r\n" +
                "\r\n" +
                "\r\n" +
                "\r\n" +
                removeFlags2 +
                "\r\n}";
            }
            if (i < 2)
            {
                race3 = "";
            }
            else
            {
                race3 =
                ",\r\n{" +
                "\r\n" +
                "\r\n" +
                "        \"TrackId\" : \"" + Form2.mainWindow.CbBox_Race3Tracks.Text + "\",\r\n" +
                choiceCar3 +
               "\r\n" +
               "\r\n" +
               "\r\n" +
               "        \"PracticeLength\" : " + Form2.mainWindow.TxtBx_PracticeLengthRace3.Text + ",\r\n" +
               "        \"QualifyLength\" : " + Form2.mainWindow.TxtBx_QualifyLengthRace3.Text + ",\r\n" +
               "        \"RaceLength\" : " + Form2.mainWindow.TxtBx_RaceLengthRace3.Text + ",\r\n" +
               "\r\n" +
               "\r\n" +
                "        \"RaceDateYear\" : " + Form2.mainWindow.dateTimePicker_Race3.Value.Year.ToString() + ",\r\n" +
                "        \"RaceDateMonth\" : " + Form2.mainWindow.dateTimePicker_Race3.Value.Month.ToString() + ",\r\n" +
                "        \"RaceDateDay\" : " + Form2.mainWindow.dateTimePicker_Race3.Value.Day.ToString() + ",\r\n" +
                "\r\n" +
                "\r\n" +
                "        \"PracticeDateHour\" : " + Form2.mainWindow.dateTimePicker_Race3.Value.Hour.ToString() + ",\r\n" +
                "        \"QualifyDateHour\" : " + Form2.mainWindow.dateTimePicker_Race3.Value.Hour.ToString() + ",\r\n" +
                "        \"RaceDateHour\" : " + Form2.mainWindow.dateTimePicker_Race3.Value.Hour.ToString() + ",\r\n" +
                "\r\n" +
                "\r\n" +
                "        \"PracticeDateProgression\" : " + Form2.mainWindow.CbBox_PracticeProgressionRace3.Text + ",\r\n" +
                "        \"QualifyDateProgression\" : " + Form2.mainWindow.CbBox_QualifyProgressionRace3.Text + ",\r\n" +
                "        \"RaceDateProgression\" : " + Form2.mainWindow.CbBox_RaceProgressionRace3.Text + ",\r\n" +
                "\r\n" +
                "\r\n" +
                rulesRace3 +
                "\r\n" +
                "\r\n" +
                "        \"PracticeWeatherSlots\" : " + Form2.mainWindow.CbBox_PracticeWeatherSlotsRace3.Text + ",\r\n" +
                "        \"PracticeWeatherSlot1\" : \"" + Form2.mainWindow.practiceWeatherSlot1Race3 + "\",\r\n" +
                "        \"PracticeWeatherSlot2\" : \"" + Form2.mainWindow.practiceWeatherSlot2Race3 + "\",\r\n" +
                "        \"PracticeWeatherSlot3\" : \"" + Form2.mainWindow.practiceWeatherSlot3Race3 + "\",\r\n" +
                "        \"PracticeWeatherSlot4\" : \"" + Form2.mainWindow.practiceWeatherSlot4Race3 + "\",\r\n" +
                "        \"PracticeWeatherProgression\" : " + Form2.mainWindow.CbBox_SpeedPratcticeWeatherRace3.Text + ",\r\n" +
                "\r\n" +
                "\r\n" +
                "        \"QualifyWeatherSlots\" : " + Form2.mainWindow.CbBox_QualifWeatherSlotsRace3.Text + ",\r\n" +
                "        \"QualifyWeatherSlot1\" : \"" + Form2.mainWindow.qualifyWeatherSlot1Race3 + "\",\r\n" +
                "        \"QualifyWeatherSlot2\" : \"" + Form2.mainWindow.qualifyWeatherSlot2Race3 + "\",\r\n" +
                "        \"QualifyWeatherSlot3\" : \"" + Form2.mainWindow.qualifyWeatherSlot3Race3 + "\",\r\n" +
                "        \"QualifyWeatherSlot4\" : \"" + Form2.mainWindow.qualifyWeatherSlot4Race3 + "\",\r\n" +
                "        \"QualifyWeatherProgression\" : " + Form2.mainWindow.CbBox_SpeedQualifWeatherRace3.Text + ",\r\n" +
                "\r\n" +
                "\r\n" +
                "        \"RaceWeatherSlots\" : " + Form2.mainWindow.CbBox_RaceWeatherSlotsRace3.Text + ",\r\n" +
                "        \"RaceWeatherSlot1\" : \"" + Form2.mainWindow.raceWeatherSlot1Race3 + "\",\r\n" +
                "        \"RaceWeatherSlot2\" : \"" + Form2.mainWindow.raceWeatherSlot2Race3 + "\",\r\n" +
                "        \"RaceWeatherSlot3\" : \"" + Form2.mainWindow.raceWeatherSlot3Race3 + "\",\r\n" +
                "        \"RaceWeatherSlot4\" : \"" + Form2.mainWindow.raceWeatherSlot4Race3 + "\",\r\n" +
                "        \"RaceWeatherProgression\" : " + Form2.mainWindow.CbBox_SpeedRaceWeatherRace3.Text + ",\r\n" +
                "\r\n" +
                "\r\n" +
                "\r\n" +
                removeFlags3 +
                "\r\n}";
                if (i < 3)
                {
                    race4 = "";
                }
                else
                {
                    race4 =
                    ",\r\n{" +
                    "\r\n" +
                    "\r\n" +
                    "        \"TrackId\" : \"" + Form2.mainWindow.CbBox_Race4Tracks.Text + "\",\r\n" +
                    choiceCar4 +
                   "\r\n" +
                   "\r\n" +
                   "\r\n" +
                   "        \"PracticeLength\" : " + Form2.mainWindow.TxtBx_PracticeLengthRace4.Text + ",\r\n" +
                   "        \"QualifyLength\" : " + Form2.mainWindow.TxtBx_QualifyLengthRace4.Text + ",\r\n" +
                   "        \"RaceLength\" : " + Form2.mainWindow.TxtBx_RaceLengthRace4.Text + ",\r\n" +
                   "\r\n" +
                   "\r\n" +
                    "        \"RaceDateYear\" : " + Form2.mainWindow.dateTimePicker_Race4.Value.Year.ToString() + ",\r\n" +
                    "        \"RaceDateMonth\" : " + Form2.mainWindow.dateTimePicker_Race4.Value.Month.ToString() + ",\r\n" +
                    "        \"RaceDateDay\" : " + Form2.mainWindow.dateTimePicker_Race4.Value.Day.ToString() + ",\r\n" +
                    "\r\n" +
                    "\r\n" +
                    "        \"PracticeDateHour\" : " + Form2.mainWindow.dateTimePicker_Race4.Value.Hour.ToString() + ",\r\n" +
                    "        \"QualifyDateHour\" : " + Form2.mainWindow.dateTimePicker_Race4.Value.Hour.ToString() + ",\r\n" +
                    "        \"RaceDateHour\" : " + Form2.mainWindow.dateTimePicker_Race4.Value.Hour.ToString() + ",\r\n" +
                    "\r\n" +
                    "\r\n" +
                    "        \"PracticeDateProgression\" : " + Form2.mainWindow.CbBox_PracticeProgressionRace4.Text + ",\r\n" +
                    "        \"QualifyDateProgression\" : " + Form2.mainWindow.CbBox_QualifyProgressionRace4.Text + ",\r\n" +
                    "        \"RaceDateProgression\" : " + Form2.mainWindow.CbBox_RaceProgressionRace4.Text + ",\r\n" +
                    "\r\n" +
                    "\r\n" +
                    rulesRace4 +
                    "\r\n" +
                    "\r\n" +
                    "        \"PracticeWeatherSlots\" : " + Form2.mainWindow.CbBox_PracticeWeatherSlotsRace4.Text + ",\r\n" +
                    "        \"PracticeWeatherSlot1\" : \"" + Form2.mainWindow.practiceWeatherSlot1Race4 + "\",\r\n" +
                    "        \"PracticeWeatherSlot2\" : \"" + Form2.mainWindow.practiceWeatherSlot2Race4 + "\",\r\n" +
                    "        \"PracticeWeatherSlot3\" : \"" + Form2.mainWindow.practiceWeatherSlot3Race4 + "\",\r\n" +
                    "        \"PracticeWeatherSlot4\" : \"" + Form2.mainWindow.practiceWeatherSlot4Race4 + "\",\r\n" +
                    "        \"PracticeWeatherProgression\" : " + Form2.mainWindow.CbBox_SpeedPratcticeWeatherRace4.Text + ",\r\n" +
                    "\r\n" +
                    "\r\n" +
                    "        \"QualifyWeatherSlots\" : " + Form2.mainWindow.CbBox_QualifWeatherSlotsRace4.Text + ",\r\n" +
                    "        \"QualifyWeatherSlot1\" : \"" + Form2.mainWindow.qualifyWeatherSlot1Race4 + "\",\r\n" +
                    "        \"QualifyWeatherSlot2\" : \"" + Form2.mainWindow.qualifyWeatherSlot2Race4 + "\",\r\n" +
                    "        \"QualifyWeatherSlot3\" : \"" + Form2.mainWindow.qualifyWeatherSlot3Race4 + "\",\r\n" +
                    "        \"QualifyWeatherSlot4\" : \"" + Form2.mainWindow.qualifyWeatherSlot4Race4 + "\",\r\n" +
                    "        \"QualifyWeatherProgression\" : " + Form2.mainWindow.CbBox_SpeedQualifWeatherRace4.Text + ",\r\n" +
                    "\r\n" +
                    "\r\n" +
                    "        \"RaceWeatherSlots\" : " + Form2.mainWindow.CbBox_RaceWeatherSlotsRace4.Text + ",\r\n" +
                    "        \"RaceWeatherSlot1\" : \"" + Form2.mainWindow.raceWeatherSlot1Race4 + "\",\r\n" +
                    "        \"RaceWeatherSlot2\" : \"" + Form2.mainWindow.raceWeatherSlot2Race4 + "\",\r\n" +
                    "        \"RaceWeatherSlot3\" : \"" + Form2.mainWindow.raceWeatherSlot3Race4 + "\",\r\n" +
                    "        \"RaceWeatherSlot4\" : \"" + Form2.mainWindow.raceWeatherSlot4Race4 + "\",\r\n" +
                    "        \"RaceWeatherProgression\" : " + Form2.mainWindow.CbBox_SpeedRaceWeatherRace4.Text + ",\r\n" +
                    "\r\n" +
                    "\r\n" +
                    "\r\n" +
                    removeFlags4 +
                    "\r\n}";
                }
                if (i < 4)
                {
                    race5 = "";
                }
                else
                {
                    race5 =
                    ",\r\n{" +
                    "\r\n" +
                    "\r\n" +
                    "        \"TrackId\" : \"" + Form2.mainWindow.CbBox_Race5Tracks.Text + "\",\r\n" +
                    choiceCar5 +
                   "\r\n" +
                   "\r\n" +
                   "\r\n" +
                   "        \"PracticeLength\" : " + Form2.mainWindow.TxtBx_PracticeLengthRace5.Text + ",\r\n" +
                   "        \"QualifyLength\" : " + Form2.mainWindow.TxtBx_QualifyLengthRace5.Text + ",\r\n" +
                   "        \"RaceLength\" : " + Form2.mainWindow.TxtBx_RaceLengthRace5.Text + ",\r\n" +
                   "\r\n" +
                   "\r\n" +
                    "        \"RaceDateYear\" : " + Form2.mainWindow.dateTimePicker_Race5.Value.Year.ToString() + ",\r\n" +
                    "        \"RaceDateMonth\" : " + Form2.mainWindow.dateTimePicker_Race5.Value.Month.ToString() + ",\r\n" +
                    "        \"RaceDateDay\" : " + Form2.mainWindow.dateTimePicker_Race5.Value.Day.ToString() + ",\r\n" +
                    "\r\n" +
                    "\r\n" +
                    "        \"PracticeDateHour\" : " + Form2.mainWindow.dateTimePicker_Race5.Value.Hour.ToString() + ",\r\n" +
                    "        \"QualifyDateHour\" : " + Form2.mainWindow.dateTimePicker_Race5.Value.Hour.ToString() + ",\r\n" +
                    "        \"RaceDateHour\" : " + Form2.mainWindow.dateTimePicker_Race5.Value.Hour.ToString() + ",\r\n" +
                    "\r\n" +
                    "\r\n" +
                    "        \"PracticeDateProgression\" : " + Form2.mainWindow.CbBox_PracticeProgressionRace5.Text + ",\r\n" +
                    "        \"QualifyDateProgression\" : " + Form2.mainWindow.CbBox_QualifyProgressionRace5.Text + ",\r\n" +
                    "        \"RaceDateProgression\" : " + Form2.mainWindow.CbBox_RaceProgressionRace5.Text + ",\r\n" +
                    "\r\n" +
                    "\r\n" +
                    rulesRace5 +
                    "\r\n" +
                    "\r\n" +
                    "        \"PracticeWeatherSlots\" : " + Form2.mainWindow.CbBox_PracticeWeatherSlotsRace5.Text + ",\r\n" +
                    "        \"PracticeWeatherSlot1\" : \"" + Form2.mainWindow.practiceWeatherSlot1Race5 + "\",\r\n" +
                    "        \"PracticeWeatherSlot2\" : \"" + Form2.mainWindow.practiceWeatherSlot2Race5 + "\",\r\n" +
                    "        \"PracticeWeatherSlot3\" : \"" + Form2.mainWindow.practiceWeatherSlot3Race5 + "\",\r\n" +
                    "        \"PracticeWeatherSlot4\" : \"" + Form2.mainWindow.practiceWeatherSlot4Race5 + "\",\r\n" +
                    "        \"PracticeWeatherProgression\" : " + Form2.mainWindow.CbBox_SpeedPratcticeWeatherRace5.Text + ",\r\n" +
                    "\r\n" +
                    "\r\n" +
                    "        \"QualifyWeatherSlots\" : " + Form2.mainWindow.CbBox_QualifWeatherSlotsRace5.Text + ",\r\n" +
                    "        \"QualifyWeatherSlot1\" : \"" + Form2.mainWindow.qualifyWeatherSlot1Race5 + "\",\r\n" +
                    "        \"QualifyWeatherSlot2\" : \"" + Form2.mainWindow.qualifyWeatherSlot2Race5 + "\",\r\n" +
                    "        \"QualifyWeatherSlot3\" : \"" + Form2.mainWindow.qualifyWeatherSlot3Race5 + "\",\r\n" +
                    "        \"QualifyWeatherSlot4\" : \"" + Form2.mainWindow.qualifyWeatherSlot4Race5 + "\",\r\n" +
                    "        \"QualifyWeatherProgression\" : " + Form2.mainWindow.CbBox_SpeedQualifWeatherRace5.Text + ",\r\n" +
                    "\r\n" +
                    "\r\n" +
                    "        \"RaceWeatherSlots\" : " + Form2.mainWindow.CbBox_RaceWeatherSlotsRace5.Text + ",\r\n" +
                    "        \"RaceWeatherSlot1\" : \"" + Form2.mainWindow.raceWeatherSlot1Race5 + "\",\r\n" +
                    "        \"RaceWeatherSlot2\" : \"" + Form2.mainWindow.raceWeatherSlot2Race5 + "\",\r\n" +
                    "        \"RaceWeatherSlot3\" : \"" + Form2.mainWindow.raceWeatherSlot3Race5 + "\",\r\n" +
                    "        \"RaceWeatherSlot4\" : \"" + Form2.mainWindow.raceWeatherSlot4Race5 + "\",\r\n" +
                    "        \"RaceWeatherProgression\" : " + Form2.mainWindow.CbBox_SpeedRaceWeatherRace5.Text + ",\r\n" +
                    "\r\n" +
                    "\r\n" +
                    "\r\n" +
                    removeFlags5 +
                    "\r\n}";
                    if (i < 5)
                    {
                        race6 = "";
                    }
                    else
                    {
                        race6 =
                        ",\r\n{" +
                        "\r\n" +
                        "\r\n" +
                        "        \"TrackId\" : \"" + Form2.mainWindow.CbBox_Race6Tracks.Text + "\",\r\n" +
                        choiceCar6 +
                       "\r\n" +
                       "\r\n" +
                       "\r\n" +
                       "        \"PracticeLength\" : " + Form2.mainWindow.TxtBx_PracticeLengthRace6.Text + ",\r\n" +
                       "        \"QualifyLength\" : " + Form2.mainWindow.TxtBx_QualifyLengthRace6.Text + ",\r\n" +
                       "        \"RaceLength\" : " + Form2.mainWindow.TxtBx_RaceLengthRace6.Text + ",\r\n" +
                       "\r\n" +
                       "\r\n" +
                        "        \"RaceDateYear\" : " + Form2.mainWindow.dateTimePicker_Race6.Value.Year.ToString() + ",\r\n" +
                        "        \"RaceDateMonth\" : " + Form2.mainWindow.dateTimePicker_Race6.Value.Month.ToString() + ",\r\n" +
                        "        \"RaceDateDay\" : " + Form2.mainWindow.dateTimePicker_Race6.Value.Day.ToString() + ",\r\n" +
                        "\r\n" +
                        "\r\n" +
                        "        \"PracticeDateHour\" : " + Form2.mainWindow.dateTimePicker_Race6.Value.Hour.ToString() + ",\r\n" +
                        "        \"QualifyDateHour\" : " + Form2.mainWindow.dateTimePicker_Race6.Value.Hour.ToString() + ",\r\n" +
                        "        \"RaceDateHour\" : " + Form2.mainWindow.dateTimePicker_Race6.Value.Hour.ToString() + ",\r\n" +
                        "\r\n" +
                        "\r\n" +
                        "        \"PracticeDateProgression\" : " + Form2.mainWindow.CbBox_PracticeProgressionRace6.Text + ",\r\n" +
                        "        \"QualifyDateProgression\" : " + Form2.mainWindow.CbBox_QualifyProgressionRace6.Text + ",\r\n" +
                        "        \"RaceDateProgression\" : " + Form2.mainWindow.CbBox_RaceProgressionRace6.Text + ",\r\n" +
                        "\r\n" +
                        "\r\n" +
                        rulesRace6 +
                        "\r\n" +
                        "\r\n" +
                        "        \"PracticeWeatherSlots\" : " + Form2.mainWindow.CbBox_PracticeWeatherSlotsRace6.Text + ",\r\n" +
                        "        \"PracticeWeatherSlot1\" : \"" + Form2.mainWindow.practiceWeatherSlot1Race6 + "\",\r\n" +
                        "        \"PracticeWeatherSlot2\" : \"" + Form2.mainWindow.practiceWeatherSlot2Race6 + "\",\r\n" +
                        "        \"PracticeWeatherSlot3\" : \"" + Form2.mainWindow.practiceWeatherSlot3Race6 + "\",\r\n" +
                        "        \"PracticeWeatherSlot4\" : \"" + Form2.mainWindow.practiceWeatherSlot4Race6 + "\",\r\n" +
                        "        \"PracticeWeatherProgression\" : " + Form2.mainWindow.CbBox_SpeedPratcticeWeatherRace6.Text + ",\r\n" +
                        "\r\n" +
                        "\r\n" +
                        "        \"QualifyWeatherSlots\" : " + Form2.mainWindow.CbBox_QualifWeatherSlotsRace6.Text + ",\r\n" +
                        "        \"QualifyWeatherSlot1\" : \"" + Form2.mainWindow.qualifyWeatherSlot1Race6 + "\",\r\n" +
                        "        \"QualifyWeatherSlot2\" : \"" + Form2.mainWindow.qualifyWeatherSlot2Race6 + "\",\r\n" +
                        "        \"QualifyWeatherSlot3\" : \"" + Form2.mainWindow.qualifyWeatherSlot3Race6 + "\",\r\n" +
                        "        \"QualifyWeatherSlot4\" : \"" + Form2.mainWindow.qualifyWeatherSlot4Race6 + "\",\r\n" +
                        "        \"QualifyWeatherProgression\" : " + Form2.mainWindow.CbBox_SpeedQualifWeatherRace6.Text + ",\r\n" +
                        "\r\n" +
                        "\r\n" +
                        "        \"RaceWeatherSlots\" : " + Form2.mainWindow.CbBox_RaceWeatherSlotsRace6.Text + ",\r\n" +
                        "        \"RaceWeatherSlot1\" : \"" + Form2.mainWindow.raceWeatherSlot1Race6 + "\",\r\n" +
                        "        \"RaceWeatherSlot2\" : \"" + Form2.mainWindow.raceWeatherSlot2Race6 + "\",\r\n" +
                        "        \"RaceWeatherSlot3\" : \"" + Form2.mainWindow.raceWeatherSlot3Race6 + "\",\r\n" +
                        "        \"RaceWeatherSlot4\" : \"" + Form2.mainWindow.raceWeatherSlot4Race6 + "\",\r\n" +
                        "        \"RaceWeatherProgression\" : " + Form2.mainWindow.CbBox_SpeedRaceWeatherRace6.Text + ",\r\n" +
                        "\r\n" +
                        "\r\n" +
                        "\r\n" +
                        removeFlags6 +
                        "\r\n}";
                    }
                    if (i < 6)
                    {
                        race7 = "";
                    }
                    else
                    {
                        race7 =
                        ",\r\n{" +
                        "\r\n" +
                        "\r\n" +
                        "        \"TrackId\" : \"" + Form2.mainWindow.CbBox_Race7Tracks.Text + "\",\r\n" +
                        choiceCar7 +
                       "\r\n" +
                       "\r\n" +
                       "\r\n" +
                       "        \"PracticeLength\" : " + Form2.mainWindow.TxtBx_PracticeLengthRace7.Text + ",\r\n" +
                       "        \"QualifyLength\" : " + Form2.mainWindow.TxtBx_QualifyLengthRace7.Text + ",\r\n" +
                       "        \"RaceLength\" : " + Form2.mainWindow.TxtBx_RaceLengthRace7.Text + ",\r\n" +
                       "\r\n" +
                       "\r\n" +
                        "        \"RaceDateYear\" : " + Form2.mainWindow.dateTimePicker_Race7.Value.Year.ToString() + ",\r\n" +
                        "        \"RaceDateMonth\" : " + Form2.mainWindow.dateTimePicker_Race7.Value.Month.ToString() + ",\r\n" +
                        "        \"RaceDateDay\" : " + Form2.mainWindow.dateTimePicker_Race7.Value.Day.ToString() + ",\r\n" +
                        "\r\n" +
                        "\r\n" +
                        "        \"PracticeDateHour\" : " + Form2.mainWindow.dateTimePicker_Race7.Value.Hour.ToString() + ",\r\n" +
                        "        \"QualifyDateHour\" : " + Form2.mainWindow.dateTimePicker_Race7.Value.Hour.ToString() + ",\r\n" +
                        "        \"RaceDateHour\" : " + Form2.mainWindow.dateTimePicker_Race7.Value.Hour.ToString() + ",\r\n" +
                        "\r\n" +
                        "\r\n" +
                        "        \"PracticeDateProgression\" : " + Form2.mainWindow.CbBox_PracticeProgressionRace7.Text + ",\r\n" +
                        "        \"QualifyDateProgression\" : " + Form2.mainWindow.CbBox_QualifyProgressionRace7.Text + ",\r\n" +
                        "        \"RaceDateProgression\" : " + Form2.mainWindow.CbBox_RaceProgressionRace7.Text + ",\r\n" +
                        "\r\n" +
                        "\r\n" +
                        rulesRace7 +
                        "\r\n" +
                        "\r\n" +
                        "        \"PracticeWeatherSlots\" : " + Form2.mainWindow.CbBox_PracticeWeatherSlotsRace7.Text + ",\r\n" +
                        "        \"PracticeWeatherSlot1\" : \"" + Form2.mainWindow.practiceWeatherSlot1Race7 + "\",\r\n" +
                        "        \"PracticeWeatherSlot2\" : \"" + Form2.mainWindow.practiceWeatherSlot2Race7 + "\",\r\n" +
                        "        \"PracticeWeatherSlot3\" : \"" + Form2.mainWindow.practiceWeatherSlot3Race7 + "\",\r\n" +
                        "        \"PracticeWeatherSlot4\" : \"" + Form2.mainWindow.practiceWeatherSlot4Race7 + "\",\r\n" +
                        "        \"PracticeWeatherProgression\" : " + Form2.mainWindow.CbBox_SpeedPratcticeWeatherRace7.Text + ",\r\n" +
                        "\r\n" +
                        "\r\n" +
                        "        \"QualifyWeatherSlots\" : " + Form2.mainWindow.CbBox_QualifWeatherSlotsRace7.Text + ",\r\n" +
                        "        \"QualifyWeatherSlot1\" : \"" + Form2.mainWindow.qualifyWeatherSlot1Race7 + "\",\r\n" +
                        "        \"QualifyWeatherSlot2\" : \"" + Form2.mainWindow.qualifyWeatherSlot2Race7 + "\",\r\n" +
                        "        \"QualifyWeatherSlot3\" : \"" + Form2.mainWindow.qualifyWeatherSlot3Race7 + "\",\r\n" +
                        "        \"QualifyWeatherSlot4\" : \"" + Form2.mainWindow.qualifyWeatherSlot4Race7 + "\",\r\n" +
                        "        \"QualifyWeatherProgression\" : " + Form2.mainWindow.CbBox_SpeedQualifWeatherRace7.Text + ",\r\n" +
                        "\r\n" +
                        "\r\n" +
                        "        \"RaceWeatherSlots\" : " + Form2.mainWindow.CbBox_RaceWeatherSlotsRace7.Text + ",\r\n" +
                        "        \"RaceWeatherSlot1\" : \"" + Form2.mainWindow.raceWeatherSlot1Race7 + "\",\r\n" +
                        "        \"RaceWeatherSlot2\" : \"" + Form2.mainWindow.raceWeatherSlot2Race7 + "\",\r\n" +
                        "        \"RaceWeatherSlot3\" : \"" + Form2.mainWindow.raceWeatherSlot3Race7 + "\",\r\n" +
                        "        \"RaceWeatherSlot4\" : \"" + Form2.mainWindow.raceWeatherSlot4Race7 + "\",\r\n" +
                        "        \"RaceWeatherProgression\" : " + Form2.mainWindow.CbBox_SpeedRaceWeatherRace7.Text + ",\r\n" +
                        "\r\n" +
                        "\r\n" +
                        "\r\n" +
                        removeFlags7 +
                        "\r\n}";
                    }
                    if (i < 7)
                    {
                        race8 = "";
                    }
                    else
                    {
                        race8 =
                        ",\r\n{" +
                        "\r\n" +
                        "\r\n" +
                        "        \"TrackId\" : \"" + Form2.mainWindow.CbBox_Race8Tracks.Text + "\",\r\n" +
                        choiceCar8 +
                       "\r\n" +
                       "\r\n" +
                       "\r\n" +
                       "        \"PracticeLength\" : " + Form2.mainWindow.TxtBx_PracticeLengthRace8.Text + ",\r\n" +
                       "        \"QualifyLength\" : " + Form2.mainWindow.TxtBx_QualifyLengthRace8.Text + ",\r\n" +
                       "        \"RaceLength\" : " + Form2.mainWindow.TxtBx_RaceLengthRace8.Text + ",\r\n" +
                       "\r\n" +
                       "\r\n" +
                        "        \"RaceDateYear\" : " + Form2.mainWindow.dateTimePicker_Race8.Value.Year.ToString() + ",\r\n" +
                        "        \"RaceDateMonth\" : " + Form2.mainWindow.dateTimePicker_Race8.Value.Month.ToString() + ",\r\n" +
                        "        \"RaceDateDay\" : " + Form2.mainWindow.dateTimePicker_Race8.Value.Day.ToString() + ",\r\n" +
                        "\r\n" +
                        "\r\n" +
                        "        \"PracticeDateHour\" : " + Form2.mainWindow.dateTimePicker_Race8.Value.Hour.ToString() + ",\r\n" +
                        "        \"QualifyDateHour\" : " + Form2.mainWindow.dateTimePicker_Race8.Value.Hour.ToString() + ",\r\n" +
                        "        \"RaceDateHour\" : " + Form2.mainWindow.dateTimePicker_Race8.Value.Hour.ToString() + ",\r\n" +
                        "\r\n" +
                        "\r\n" +
                        "        \"PracticeDateProgression\" : " + Form2.mainWindow.CbBox_PracticeProgressionRace8.Text + ",\r\n" +
                        "        \"QualifyDateProgression\" : " + Form2.mainWindow.CbBox_QualifyProgressionRace8.Text + ",\r\n" +
                        "        \"RaceDateProgression\" : " + Form2.mainWindow.CbBox_RaceProgressionRace8.Text + ",\r\n" +
                        "\r\n" +
                        "\r\n" +
                        rulesRace8 +
                        "\r\n" +
                        "\r\n" +
                        "        \"PracticeWeatherSlots\" : " + Form2.mainWindow.CbBox_PracticeWeatherSlotsRace8.Text + ",\r\n" +
                        "        \"PracticeWeatherSlot1\" : \"" + Form2.mainWindow.practiceWeatherSlot1Race8 + "\",\r\n" +
                        "        \"PracticeWeatherSlot2\" : \"" + Form2.mainWindow.practiceWeatherSlot2Race8 + "\",\r\n" +
                        "        \"PracticeWeatherSlot3\" : \"" + Form2.mainWindow.practiceWeatherSlot3Race8 + "\",\r\n" +
                        "        \"PracticeWeatherSlot4\" : \"" + Form2.mainWindow.practiceWeatherSlot4Race8 + "\",\r\n" +
                        "        \"PracticeWeatherProgression\" : " + Form2.mainWindow.CbBox_SpeedPratcticeWeatherRace8.Text + ",\r\n" +
                        "\r\n" +
                        "\r\n" +
                        "        \"QualifyWeatherSlots\" : " + Form2.mainWindow.CbBox_QualifWeatherSlotsRace8.Text + ",\r\n" +
                        "        \"QualifyWeatherSlot1\" : \"" + Form2.mainWindow.qualifyWeatherSlot1Race8 + "\",\r\n" +
                        "        \"QualifyWeatherSlot2\" : \"" + Form2.mainWindow.qualifyWeatherSlot2Race8 + "\",\r\n" +
                        "        \"QualifyWeatherSlot3\" : \"" + Form2.mainWindow.qualifyWeatherSlot3Race8 + "\",\r\n" +
                        "        \"QualifyWeatherSlot4\" : \"" + Form2.mainWindow.qualifyWeatherSlot4Race8 + "\",\r\n" +
                        "        \"QualifyWeatherProgression\" : " + Form2.mainWindow.CbBox_SpeedQualifWeatherRace8.Text + ",\r\n" +
                        "\r\n" +
                        "\r\n" +
                        "        \"RaceWeatherSlots\" : " + Form2.mainWindow.CbBox_RaceWeatherSlotsRace8.Text + ",\r\n" +
                        "        \"RaceWeatherSlot1\" : \"" + Form2.mainWindow.raceWeatherSlot1Race8 + "\",\r\n" +
                        "        \"RaceWeatherSlot2\" : \"" + Form2.mainWindow.raceWeatherSlot2Race8 + "\",\r\n" +
                        "        \"RaceWeatherSlot3\" : \"" + Form2.mainWindow.raceWeatherSlot3Race8 + "\",\r\n" +
                        "        \"RaceWeatherSlot4\" : \"" + Form2.mainWindow.raceWeatherSlot4Race8 + "\",\r\n" +
                        "        \"RaceWeatherProgression\" : " + Form2.mainWindow.CbBox_SpeedRaceWeatherRace8.Text + ",\r\n" +
                        "\r\n" +
                        "\r\n" +
                        "\r\n" +
                        removeFlags8 +
                        "\r\n}";
                    }
                }
            }
        }




        //Création du rotate

        public void EditOrCreateFileRotate()
        {
            PersistIndex();
            string fileRotate = Form1.workFolder + "\\lua_config\\sms_rotate_config.json";

            EditRaces();

            //Creation de la course 1

            var streamFile = new StreamWriter(new FileStream(fileRotate, FileMode.Truncate));
            string rotate = "version : 7  \r\n" +
                            "config : {  \r\n" +
                            "    \"persist_index\" : " + persistIndex + "\r\n" + "\r\n" +
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
                            "        \"PenaltiesType\" : " + penaltiesRace1 + "\r\n" +
                            "        " + pitLinePenaltiesRace1 + "\r\n" +
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
                            race1 +
                            race2 +
                            race3 +
                            race4 +
                            race5 +
                            race6 +
                            race7 +
                            race8 +
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
