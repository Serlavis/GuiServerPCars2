using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiServerPCars2V2._0
{
    class Flags
    {
        public List<string> choixFlagsRace1 = new List<string> { "COOLDOWNLAP", "FILL_SESSION_WITH_AI", "ANTI_GRIEFING_COLLISIONS", "FORCE_MANUAL", "HAS_BROADCASTER", "HAS_RACE_DIRECTOR", "PIT_STOP_ERRORS_ALLOWED" };
        public List<string> choixFlagsRace2 = new List<string> { "COOLDOWNLAP", "FILL_SESSION_WITH_AI", "ANTI_GRIEFING_COLLISIONS", "FORCE_MANUAL", "HAS_BROADCASTER", "HAS_RACE_DIRECTOR", "PIT_STOP_ERRORS_ALLOWED" };
        public List<string> choixFlagsRace3 = new List<string> { "COOLDOWNLAP", "FILL_SESSION_WITH_AI", "ANTI_GRIEFING_COLLISIONS", "FORCE_MANUAL", "HAS_BROADCASTER", "HAS_RACE_DIRECTOR", "PIT_STOP_ERRORS_ALLOWED" };
        public List<string> choixFlagsRace4 = new List<string> { "COOLDOWNLAP", "FILL_SESSION_WITH_AI", "ANTI_GRIEFING_COLLISIONS", "FORCE_MANUAL", "HAS_BROADCASTER", "HAS_RACE_DIRECTOR", "PIT_STOP_ERRORS_ALLOWED" };
        public List<string> choixFlagsRace5 = new List<string> { "COOLDOWNLAP", "FILL_SESSION_WITH_AI", "ANTI_GRIEFING_COLLISIONS", "FORCE_MANUAL", "HAS_BROADCASTER", "HAS_RACE_DIRECTOR", "PIT_STOP_ERRORS_ALLOWED" };
        public List<string> choixFlagsRace6 = new List<string> { "COOLDOWNLAP", "FILL_SESSION_WITH_AI", "ANTI_GRIEFING_COLLISIONS", "FORCE_MANUAL", "HAS_BROADCASTER", "HAS_RACE_DIRECTOR", "PIT_STOP_ERRORS_ALLOWED" };
        public List<string> choixFlagsRace7 = new List<string> { "COOLDOWNLAP", "FILL_SESSION_WITH_AI", "ANTI_GRIEFING_COLLISIONS", "FORCE_MANUAL", "HAS_BROADCASTER", "HAS_RACE_DIRECTOR", "PIT_STOP_ERRORS_ALLOWED" };
        public List<string> choixFlagsRace8 = new List<string> { "COOLDOWNLAP", "FILL_SESSION_WITH_AI", "ANTI_GRIEFING_COLLISIONS", "FORCE_MANUAL", "HAS_BROADCASTER", "HAS_RACE_DIRECTOR", "PIT_STOP_ERRORS_ALLOWED" };

        public void SaveFlags1()
        {
            //CoolDownLap
            if (Form2.mainWindow.CheckBox_CoolDownLapRace1.Checked)
            {
                if (choixFlagsRace1.Contains("COOLDOWNLAP"))
                {
                    choixFlagsRace1.Remove("COOLDOWNLAP");
                }
            }
            else
            {
                if (choixFlagsRace1.Contains("COOLDOWNLAP"))
                {
                    choixFlagsRace1.Remove("COOLDOWNLAP");
                }
                choixFlagsRace1.Add("COOLDOWNLAP");

            }

            //AbsAllowed
            if (Form2.mainWindow.CheckBox_AbsAllowedRace1.Checked)
            {
                if (choixFlagsRace1.Contains("ABS_ALLOWED"))
                {
                    choixFlagsRace1.Remove("ABS_ALLOWED");
                }
            }
            else
            {
                if (choixFlagsRace1.Contains("ABS_ALLOWED"))
                {
                    choixFlagsRace1.Remove("ABS_ALLOWED");
                }
                choixFlagsRace1.Add("ABS_ALLOWED");
            }

            //ScAllowed
            if (Form2.mainWindow.CheckBox_ScAllowedRace1.Checked)
            {
                if (choixFlagsRace1.Contains("SC_ALLOWED"))
                {
                    choixFlagsRace1.Remove("SC_ALLOWED");
                }
            }
            else
            {
                if (choixFlagsRace1.Contains("SC_ALLOWED"))
                {
                    choixFlagsRace1.Remove("SC_ALLOWED");
                }
                choixFlagsRace1.Add("SC_ALLOWED");
            }

            //TcsAllowed
            if (Form2.mainWindow.CheckBox_TcsAllowedRace1.Checked)
            {
                if (choixFlagsRace1.Contains("TCS_ALLOWED"))
                {
                    choixFlagsRace1.Remove("TCS_ALLOWED");
                }
            }
            else
            {
                if (choixFlagsRace1.Contains("TCS_ALLOWED"))
                {
                    choixFlagsRace1.Remove("TCS_ALLOWED");
                }
                choixFlagsRace1.Add("TCS_ALLOWED");
            }

            //FillSessionWithAi
            if (Form2.mainWindow.CheckBox_FillSessionWithAiRace1.Checked)
            {
                if (choixFlagsRace1.Contains("FILL_SESSION_WITH_AI"))
                {
                    choixFlagsRace1.Remove("FILL_SESSION_WITH_AI");
                }
            }
            else
            {
                if (choixFlagsRace1.Contains("FILL_SESSION_WITH_AI"))
                {
                    choixFlagsRace1.Remove("FILL_SESSION_WITH_AI");
                }
                choixFlagsRace1.Add("FILL_SESSION_WITH_AI");
            }


            //MechanicalFailures
            if (Form2.mainWindow.CheckBox_MechanicalFailuresRace1.Checked)
            {
                if (choixFlagsRace1.Contains("MECHANICAL_FAILURES"))
                {
                    choixFlagsRace1.Remove("MECHANICAL_FAILURES");
                }
            }
            else
            {
                if (choixFlagsRace1.Contains("MECHANICAL_FAILURES"))
                {
                    choixFlagsRace1.Remove("MECHANICAL_FAILURES");
                }
                choixFlagsRace1.Add("MECHANICAL_FAILURES");
            }

            //AutoStartEngine
            if (Form2.mainWindow.CheckBox_AutoStartEngineRace1.Checked)
            {
                if (choixFlagsRace1.Contains("AUTO_START_ENGINE"))
                {
                    choixFlagsRace1.Remove("AUTO_START_ENGINE");
                }
            }
            else
            {
                if (choixFlagsRace1.Contains("AUTO_START_ENGINE"))
                {
                    choixFlagsRace1.Remove("AUTO_START_ENGINE");
                }
                choixFlagsRace1.Add("AUTO_START_ENGINE");
            }


            //WaitForRaceReady
            if (Form2.mainWindow.CheckBox_WaitForRaceReadyRace1.Checked)
            {
                if (choixFlagsRace1.Contains("WAIT_FOR_RACE_READY_INPUT"))
                {
                    choixFlagsRace1.Remove("WAIT_FOR_RACE_READY_INPUT");
                }
            }
            else
            {
                if (choixFlagsRace1.Contains("WAIT_FOR_RACE_READY_INPUT"))
                {
                    choixFlagsRace1.Remove("WAIT_FOR_RACE_READY_INPUT");
                }
                choixFlagsRace1.Add("WAIT_FOR_RACE_READY_INPUT");
            }

            //DisableDriveLine
            if (Form2.mainWindow.CheckBox_DisableDriveLineRace1.Checked)
            {
                if (choixFlagsRace1.Contains("DISABLE_DRIVING_LINE"))
                {
                    choixFlagsRace1.Remove("DISABLE_DRIVING_LINE");
                }
            }
            else
            {
                if (choixFlagsRace1.Contains("DISABLE_DRIVING_LINE"))
                {
                    choixFlagsRace1.Remove("DISABLE_DRIVING_LINE");
                }
                choixFlagsRace1.Add("DISABLE_DRIVING_LINE");
            }

            //CustomSetup
            if (Form2.mainWindow.CheckBox_CustomSetupRace1.Checked)
            {
                if (choixFlagsRace1.Contains("ALLOW_CUSTOM_VEHICLE_SETUP"))
                {
                    choixFlagsRace1.Remove("ALLOW_CUSTOM_VEHICLE_SETUP");
                }
            }
            else
            {
                if (choixFlagsRace1.Contains("ALLOW_CUSTOM_VEHICLE_SETUP"))
                {
                    choixFlagsRace1.Remove("ALLOW_CUSTOM_VEHICLE_SETUP");
                }
                choixFlagsRace1.Add("ALLOW_CUSTOM_VEHICLE_SETUP");
            }

            //Rank
            if (Form2.mainWindow.CheckBox_RankRace1.Checked == false)
            {
                if (choixFlagsRace1.Contains("ONLINE_REPUTATION_ENABLED"))
                {
                    choixFlagsRace1.Remove("ONLINE_REPUTATION_ENABLED");
                }
                choixFlagsRace1.Add("ONLINE_REPUTATION_ENABLED");
            }

            // Timed Races or Laps

            if (Form2.mainWindow.RadioButton_LapsRace1.Checked)
            {
                if (choixFlagsRace1.Contains("TIMED_RACE"))
                {
                    choixFlagsRace1.Remove("TIMED_RACE");
                }
                choixFlagsRace1.Add("TIMED_RACE");
            }


        }
        public void SaveFlags2()
        {
            if (Form2.mainWindow.CheckBox_SameRules.Checked)
            {
                //CoolDownLap
                if (Form2.mainWindow.CheckBox_CoolDownLapRace1.Checked)
                {
                    if (choixFlagsRace2.Contains("COOLDOWNLAP"))
                    {
                        choixFlagsRace2.Remove("COOLDOWNLAP");
                    }
                }
                else
                {
                    if (choixFlagsRace2.Contains("COOLDOWNLAP"))
                    {
                        choixFlagsRace2.Remove("COOLDOWNLAP");
                    }
                    choixFlagsRace2.Add("COOLDOWNLAP");

                }

                //AbsAllowed
                if (Form2.mainWindow.CheckBox_AbsAllowedRace1.Checked)
                {
                    if (choixFlagsRace2.Contains("ABS_ALLOWED"))
                    {
                        choixFlagsRace2.Remove("ABS_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace2.Contains("ABS_ALLOWED"))
                    {
                        choixFlagsRace2.Remove("ABS_ALLOWED");
                    }
                    choixFlagsRace2.Add("ABS_ALLOWED");
                }

                //ScAllowed
                if (Form2.mainWindow.CheckBox_ScAllowedRace1.Checked)
                {
                    if (choixFlagsRace2.Contains("SC_ALLOWED"))
                    {
                        choixFlagsRace2.Remove("SC_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace2.Contains("SC_ALLOWED"))
                    {
                        choixFlagsRace2.Remove("SC_ALLOWED");
                    }
                    choixFlagsRace2.Add("SC_ALLOWED");
                }

                //TcsAllowed
                if (Form2.mainWindow.CheckBox_TcsAllowedRace1.Checked)
                {
                    if (choixFlagsRace2.Contains("TCS_ALLOWED"))
                    {
                        choixFlagsRace2.Remove("TCS_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace2.Contains("TCS_ALLOWED"))
                    {
                        choixFlagsRace2.Remove("TCS_ALLOWED");
                    }
                    choixFlagsRace2.Add("TCS_ALLOWED");
                }

                //FillSessionWithAi
                if (Form2.mainWindow.CheckBox_FillSessionWithAiRace1.Checked)
                {
                    if (choixFlagsRace2.Contains("FILL_SESSION_WITH_AI"))
                    {
                        choixFlagsRace2.Remove("FILL_SESSION_WITH_AI");
                    }
                }
                else
                {
                    if (choixFlagsRace2.Contains("FILL_SESSION_WITH_AI"))
                    {
                        choixFlagsRace2.Remove("FILL_SESSION_WITH_AI");
                    }
                    choixFlagsRace2.Add("FILL_SESSION_WITH_AI");
                }


                //MechanicalFailures
                if (Form2.mainWindow.CheckBox_MechanicalFailuresRace1.Checked)
                {
                    if (choixFlagsRace2.Contains("MECHANICAL_FAILURES"))
                    {
                        choixFlagsRace2.Remove("MECHANICAL_FAILURES");
                    }
                }
                else
                {
                    if (choixFlagsRace2.Contains("MECHANICAL_FAILURES"))
                    {
                        choixFlagsRace2.Remove("MECHANICAL_FAILURES");
                    }
                    choixFlagsRace2.Add("MECHANICAL_FAILURES");
                }

                //AutoStartEngine
                if (Form2.mainWindow.CheckBox_AutoStartEngineRace1.Checked)
                {
                    if (choixFlagsRace2.Contains("AUTO_START_ENGINE"))
                    {
                        choixFlagsRace2.Remove("AUTO_START_ENGINE");
                    }
                }
                else
                {
                    if (choixFlagsRace2.Contains("AUTO_START_ENGINE"))
                    {
                        choixFlagsRace2.Remove("AUTO_START_ENGINE");
                    }
                    choixFlagsRace2.Add("AUTO_START_ENGINE");
                }


                //WaitForRaceReady
                if (Form2.mainWindow.CheckBox_WaitForRaceReadyRace1.Checked)
                {
                    if (choixFlagsRace2.Contains("WAIT_FOR_RACE_READY_INPUT"))
                    {
                        choixFlagsRace2.Remove("WAIT_FOR_RACE_READY_INPUT");
                    }
                }
                else
                {
                    if (choixFlagsRace2.Contains("WAIT_FOR_RACE_READY_INPUT"))
                    {
                        choixFlagsRace2.Remove("WAIT_FOR_RACE_READY_INPUT");
                    }
                    choixFlagsRace2.Add("WAIT_FOR_RACE_READY_INPUT");
                }

                //DisableDriveLine
                if (Form2.mainWindow.CheckBox_DisableDriveLineRace1.Checked)
                {
                    if (choixFlagsRace2.Contains("DISABLE_DRIVING_LINE"))
                    {
                        choixFlagsRace2.Remove("DISABLE_DRIVING_LINE");
                    }
                }
                else
                {
                    if (choixFlagsRace2.Contains("DISABLE_DRIVING_LINE"))
                    {
                        choixFlagsRace2.Remove("DISABLE_DRIVING_LINE");
                    }
                    choixFlagsRace2.Add("DISABLE_DRIVING_LINE");
                }

                //CustomSetup
                if (Form2.mainWindow.CheckBox_CustomSetupRace1.Checked)
                {
                    if (choixFlagsRace2.Contains("ALLOW_CUSTOM_VEHICLE_SETUP"))
                    {
                        choixFlagsRace2.Remove("ALLOW_CUSTOM_VEHICLE_SETUP");
                    }
                }
                else
                {
                    if (choixFlagsRace2.Contains("ALLOW_CUSTOM_VEHICLE_SETUP"))
                    {
                        choixFlagsRace2.Remove("ALLOW_CUSTOM_VEHICLE_SETUP");
                    }
                    choixFlagsRace2.Add("ALLOW_CUSTOM_VEHICLE_SETUP");
                }

                //Rank
                if (Form2.mainWindow.CheckBox_RankRace1.Checked == false)
                {
                    if (choixFlagsRace2.Contains("ONLINE_REPUTATION_ENABLED"))
                    {
                        choixFlagsRace2.Remove("ONLINE_REPUTATION_ENABLED");
                    }
                    choixFlagsRace2.Add("ONLINE_REPUTATION_ENABLED");
                }
            }
            else
            {
                //CoolDownLap
                if (Form2.mainWindow.CheckBox_CoolDownLapRace2.Checked)
                {
                    if (choixFlagsRace2.Contains("COOLDOWNLAP"))
                    {
                        choixFlagsRace2.Remove("COOLDOWNLAP");
                    }
                }
                else
                {
                    if (choixFlagsRace2.Contains("COOLDOWNLAP"))
                    {
                        choixFlagsRace2.Remove("COOLDOWNLAP");
                    }
                    choixFlagsRace2.Add("COOLDOWNLAP");
                }

                //AbsAllowed
                if (Form2.mainWindow.CheckBox_AbsAllowedRace2.Checked)
                {
                    if (choixFlagsRace2.Contains("ABS_ALLOWED"))
                    {
                        choixFlagsRace2.Remove("ABS_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace2.Contains("ABS_ALLOWED"))
                    {
                        choixFlagsRace2.Remove("ABS_ALLOWED");
                    }
                    choixFlagsRace2.Add("ABS_ALLOWED");
                }

                //ScAllowed
                if (Form2.mainWindow.CheckBox_ScAllowedRace2.Checked)
                {
                    if (choixFlagsRace2.Contains("SC_ALLOWED"))
                    {
                        choixFlagsRace2.Remove("SC_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace2.Contains("SC_ALLOWED"))
                    {
                        choixFlagsRace2.Remove("SC_ALLOWED");
                    }
                    choixFlagsRace2.Add("SC_ALLOWED");
                }

                //TcsAllowed
                if (Form2.mainWindow.CheckBox_TcsAllowedRace2.Checked)
                {
                    if (choixFlagsRace2.Contains("TCS_ALLOWED"))
                    {
                        choixFlagsRace2.Remove("TCS_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace2.Contains("TCS_ALLOWED"))
                    {
                        choixFlagsRace2.Remove("TCS_ALLOWED");
                    }
                    choixFlagsRace2.Add("TCS_ALLOWED");
                }

                //FillSessionWithAi
                if (Form2.mainWindow.CheckBox_FillSessionWithAiRace2.Checked)
                {
                    if (choixFlagsRace2.Contains("FILL_SESSION_WITH_AI"))
                    {
                        choixFlagsRace2.Remove("FILL_SESSION_WITH_AI");
                    }
                }
                else
                {
                    if (choixFlagsRace2.Contains("FILL_SESSION_WITH_AI"))
                    {
                        choixFlagsRace2.Remove("FILL_SESSION_WITH_AI");
                    }
                    choixFlagsRace2.Add("FILL_SESSION_WITH_AI");
                }


                //MechanicalFailures
                if (Form2.mainWindow.CheckBox_MechanicalFailuresRace2.Checked)
                {
                    if (choixFlagsRace2.Contains("MECHANICAL_FAILURES"))
                    {
                        choixFlagsRace2.Remove("MECHANICAL_FAILURES");
                    }
                }
                else
                {
                    if (choixFlagsRace2.Contains("MECHANICAL_FAILURES"))
                    {
                        choixFlagsRace2.Remove("MECHANICAL_FAILURES");
                    }
                    choixFlagsRace2.Add("MECHANICAL_FAILURES");
                }

                //AutoStartEngine
                if (Form2.mainWindow.CheckBox_AutoStartEngineRace2.Checked)
                {
                    if (choixFlagsRace2.Contains("AUTO_START_ENGINE"))
                    {
                        choixFlagsRace2.Remove("AUTO_START_ENGINE");
                    }
                }
                else
                {
                    if (choixFlagsRace2.Contains("AUTO_START_ENGINE"))
                    {
                        choixFlagsRace2.Remove("AUTO_START_ENGINE");
                    }
                    choixFlagsRace2.Add("AUTO_START_ENGINE");
                }


                //WaitForRaceReady
                if (Form2.mainWindow.CheckBox_WaitForRaceReadyRace2.Checked)
                {
                    if (choixFlagsRace2.Contains("WAIT_FOR_RACE_READY_INPUT"))
                    {
                        choixFlagsRace2.Remove("WAIT_FOR_RACE_READY_INPUT");
                    }
                }
                else
                {
                    if (choixFlagsRace2.Contains("WAIT_FOR_RACE_READY_INPUT"))
                    {
                        choixFlagsRace2.Remove("WAIT_FOR_RACE_READY_INPUT");
                    }
                    choixFlagsRace2.Add("WAIT_FOR_RACE_READY_INPUT");
                }

                //DisableDriveLine
                if (Form2.mainWindow.CheckBox_DisableDriveLineRace2.Checked)
                {
                    if (choixFlagsRace2.Contains("DISABLE_DRIVING_LINE"))
                    {
                        choixFlagsRace2.Remove("DISABLE_DRIVING_LINE");
                    }
                }
                else
                {
                    if (choixFlagsRace2.Contains("DISABLE_DRIVING_LINE"))
                    {
                        choixFlagsRace2.Remove("DISABLE_DRIVING_LINE");
                    }
                    choixFlagsRace2.Add("DISABLE_DRIVING_LINE");
                }

                //CustomSetup
                if (Form2.mainWindow.CheckBox_CustomSetupRace2.Checked)
                {
                    if (choixFlagsRace2.Contains("ALLOW_CUSTOM_VEHICLE_SETUP"))
                    {
                        choixFlagsRace2.Remove("ALLOW_CUSTOM_VEHICLE_SETUP");
                    }
                }
                else
                {
                    if (choixFlagsRace2.Contains("ALLOW_CUSTOM_VEHICLE_SETUP"))
                    {
                        choixFlagsRace2.Remove("ALLOW_CUSTOM_VEHICLE_SETUP");
                    }
                    choixFlagsRace2.Add("ALLOW_CUSTOM_VEHICLE_SETUP");
                }

                //Rank
                if (Form2.mainWindow.CheckBox_RankRace2.Checked == false)
                {
                    if (choixFlagsRace2.Contains("ONLINE_REPUTATION_ENABLED"))
                    {
                        choixFlagsRace2.Remove("ONLINE_REPUTATION_ENABLED");
                    }
                    choixFlagsRace2.Add("ONLINE_REPUTATION_ENABLED");
                }
            }
            // Timed Races or Laps

            if (Form2.mainWindow.RadioButton_LapsRace2.Checked)
            {
                if (choixFlagsRace2.Contains("TIMED_RACE"))
                {
                    choixFlagsRace2.Remove("TIMED_RACE");
                }
                choixFlagsRace2.Add("TIMED_RACE");
            }



        }

        public void SaveFlags3()
        {
            if (Form2.mainWindow.CheckBox_SameRules.Checked)
            {
                //CoolDownLap
                if (Form2.mainWindow.CheckBox_CoolDownLapRace1.Checked)
                {
                    if (choixFlagsRace3.Contains("COOLDOWNLAP"))
                    {
                        choixFlagsRace3.Remove("COOLDOWNLAP");
                    }
                }
                else
                {
                    if (choixFlagsRace3.Contains("COOLDOWNLAP"))
                    {
                        choixFlagsRace3.Remove("COOLDOWNLAP");
                    }
                    choixFlagsRace3.Add("COOLDOWNLAP");

                }

                //AbsAllowed
                if (Form2.mainWindow.CheckBox_AbsAllowedRace1.Checked)
                {
                    if (choixFlagsRace3.Contains("ABS_ALLOWED"))
                    {
                        choixFlagsRace3.Remove("ABS_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace3.Contains("ABS_ALLOWED"))
                    {
                        choixFlagsRace3.Remove("ABS_ALLOWED");
                    }
                    choixFlagsRace3.Add("ABS_ALLOWED");
                }

                //ScAllowed
                if (Form2.mainWindow.CheckBox_ScAllowedRace1.Checked)
                {
                    if (choixFlagsRace3.Contains("SC_ALLOWED"))
                    {
                        choixFlagsRace3.Remove("SC_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace3.Contains("SC_ALLOWED"))
                    {
                        choixFlagsRace3.Remove("SC_ALLOWED");
                    }
                    choixFlagsRace3.Add("SC_ALLOWED");
                }

                //TcsAllowed
                if (Form2.mainWindow.CheckBox_TcsAllowedRace1.Checked)
                {
                    if (choixFlagsRace3.Contains("TCS_ALLOWED"))
                    {
                        choixFlagsRace3.Remove("TCS_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace3.Contains("TCS_ALLOWED"))
                    {
                        choixFlagsRace3.Remove("TCS_ALLOWED");
                    }
                    choixFlagsRace3.Add("TCS_ALLOWED");
                }

                //FillSessionWithAi
                if (Form2.mainWindow.CheckBox_FillSessionWithAiRace1.Checked)
                {
                    if (choixFlagsRace3.Contains("FILL_SESSION_WITH_AI"))
                    {
                        choixFlagsRace3.Remove("FILL_SESSION_WITH_AI");
                    }
                }
                else
                {
                    if (choixFlagsRace3.Contains("FILL_SESSION_WITH_AI"))
                    {
                        choixFlagsRace3.Remove("FILL_SESSION_WITH_AI");
                    }
                    choixFlagsRace3.Add("FILL_SESSION_WITH_AI");
                }


                //MechanicalFailures
                if (Form2.mainWindow.CheckBox_MechanicalFailuresRace1.Checked)
                {
                    if (choixFlagsRace3.Contains("MECHANICAL_FAILURES"))
                    {
                        choixFlagsRace3.Remove("MECHANICAL_FAILURES");
                    }
                }
                else
                {
                    if (choixFlagsRace3.Contains("MECHANICAL_FAILURES"))
                    {
                        choixFlagsRace3.Remove("MECHANICAL_FAILURES");
                    }
                    choixFlagsRace3.Add("MECHANICAL_FAILURES");
                }

                //AutoStartEngine
                if (Form2.mainWindow.CheckBox_AutoStartEngineRace1.Checked)
                {
                    if (choixFlagsRace3.Contains("AUTO_START_ENGINE"))
                    {
                        choixFlagsRace3.Remove("AUTO_START_ENGINE");
                    }
                }
                else
                {
                    if (choixFlagsRace3.Contains("AUTO_START_ENGINE"))
                    {
                        choixFlagsRace3.Remove("AUTO_START_ENGINE");
                    }
                    choixFlagsRace3.Add("AUTO_START_ENGINE");
                }


                //WaitForRaceReady
                if (Form2.mainWindow.CheckBox_WaitForRaceReadyRace1.Checked)
                {
                    if (choixFlagsRace3.Contains("WAIT_FOR_RACE_READY_INPUT"))
                    {
                        choixFlagsRace3.Remove("WAIT_FOR_RACE_READY_INPUT");
                    }
                }
                else
                {
                    if (choixFlagsRace3.Contains("WAIT_FOR_RACE_READY_INPUT"))
                    {
                        choixFlagsRace3.Remove("WAIT_FOR_RACE_READY_INPUT");
                    }
                    choixFlagsRace3.Add("WAIT_FOR_RACE_READY_INPUT");
                }

                //DisableDriveLine
                if (Form2.mainWindow.CheckBox_DisableDriveLineRace1.Checked)
                {
                    if (choixFlagsRace3.Contains("DISABLE_DRIVING_LINE"))
                    {
                        choixFlagsRace3.Remove("DISABLE_DRIVING_LINE");
                    }
                }
                else
                {
                    if (choixFlagsRace3.Contains("DISABLE_DRIVING_LINE"))
                    {
                        choixFlagsRace3.Remove("DISABLE_DRIVING_LINE");
                    }
                    choixFlagsRace3.Add("DISABLE_DRIVING_LINE");
                }

                //CustomSetup
                if (Form2.mainWindow.CheckBox_CustomSetupRace1.Checked)
                {
                    if (choixFlagsRace3.Contains("ALLOW_CUSTOM_VEHICLE_SETUP"))
                    {
                        choixFlagsRace3.Remove("ALLOW_CUSTOM_VEHICLE_SETUP");
                    }
                }
                else
                {
                    if (choixFlagsRace3.Contains("ALLOW_CUSTOM_VEHICLE_SETUP"))
                    {
                        choixFlagsRace3.Remove("ALLOW_CUSTOM_VEHICLE_SETUP");
                    }
                    choixFlagsRace3.Add("ALLOW_CUSTOM_VEHICLE_SETUP");
                }

                //Rank
                if (Form2.mainWindow.CheckBox_RankRace1.Checked == false)
                {
                    if (choixFlagsRace3.Contains("ONLINE_REPUTATION_ENABLED"))
                    {
                        choixFlagsRace3.Remove("ONLINE_REPUTATION_ENABLED");
                    }
                    choixFlagsRace3.Add("ONLINE_REPUTATION_ENABLED");
                }
            }
            else
            {

                //CoolDownLap
                if (Form2.mainWindow.CheckBox_CoolDownLapRace3.Checked)
                {
                    if (choixFlagsRace3.Contains("COOLDOWNLAP"))
                    {
                        choixFlagsRace3.Remove("COOLDOWNLAP");
                    }
                }
                else
                {
                    if (choixFlagsRace3.Contains("COOLDOWNLAP"))
                    {
                        choixFlagsRace3.Remove("COOLDOWNLAP");
                    }
                    choixFlagsRace3.Add("COOLDOWNLAP");

                }

                //AbsAllowed
                if (Form2.mainWindow.CheckBox_AbsAllowedRace3.Checked)
                {
                    if (choixFlagsRace3.Contains("ABS_ALLOWED"))
                    {
                        choixFlagsRace3.Remove("ABS_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace3.Contains("ABS_ALLOWED"))
                    {
                        choixFlagsRace3.Remove("ABS_ALLOWED");
                    }
                    choixFlagsRace3.Add("ABS_ALLOWED");
                }

                //ScAllowed
                if (Form2.mainWindow.CheckBox_ScAllowedRace3.Checked)
                {
                    if (choixFlagsRace3.Contains("SC_ALLOWED"))
                    {
                        choixFlagsRace3.Remove("SC_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace3.Contains("SC_ALLOWED"))
                    {
                        choixFlagsRace3.Remove("SC_ALLOWED");
                    }
                    choixFlagsRace3.Add("SC_ALLOWED");
                }

                //TcsAllowed
                if (Form2.mainWindow.CheckBox_TcsAllowedRace3.Checked)
                {
                    if (choixFlagsRace3.Contains("TCS_ALLOWED"))
                    {
                        choixFlagsRace3.Remove("TCS_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace3.Contains("TCS_ALLOWED"))
                    {
                        choixFlagsRace3.Remove("TCS_ALLOWED");
                    }
                    choixFlagsRace3.Add("TCS_ALLOWED");
                }

                //FillSessionWithAi
                if (Form2.mainWindow.CheckBox_FillSessionWithAiRace3.Checked)
                {
                    if (choixFlagsRace3.Contains("FILL_SESSION_WITH_AI"))
                    {
                        choixFlagsRace3.Remove("FILL_SESSION_WITH_AI");
                    }
                }
                else
                {
                    if (choixFlagsRace3.Contains("FILL_SESSION_WITH_AI"))
                    {
                        choixFlagsRace3.Remove("FILL_SESSION_WITH_AI");
                    }
                    choixFlagsRace3.Add("FILL_SESSION_WITH_AI");
                }


                //MechanicalFailures
                if (Form2.mainWindow.CheckBox_MechanicalFailuresRace3.Checked)
                {
                    if (choixFlagsRace3.Contains("MECHANICAL_FAILURES"))
                    {
                        choixFlagsRace3.Remove("MECHANICAL_FAILURES");
                    }
                }
                else
                {
                    if (choixFlagsRace3.Contains("MECHANICAL_FAILURES"))
                    {
                        choixFlagsRace3.Remove("MECHANICAL_FAILURES");
                    }
                    choixFlagsRace3.Add("MECHANICAL_FAILURES");
                }

                //AutoStartEngine
                if (Form2.mainWindow.CheckBox_AutoStartEngineRace3.Checked)
                {
                    if (choixFlagsRace3.Contains("AUTO_START_ENGINE"))
                    {
                        choixFlagsRace3.Remove("AUTO_START_ENGINE");
                    }
                }
                else
                {
                    if (choixFlagsRace3.Contains("AUTO_START_ENGINE"))
                    {
                        choixFlagsRace3.Remove("AUTO_START_ENGINE");
                    }
                    choixFlagsRace3.Add("AUTO_START_ENGINE");
                }


                //WaitForRaceReady
                if (Form2.mainWindow.CheckBox_WaitForRaceReadyRace3.Checked)
                {
                    if (choixFlagsRace3.Contains("WAIT_FOR_RACE_READY_INPUT"))
                    {
                        choixFlagsRace3.Remove("WAIT_FOR_RACE_READY_INPUT");
                    }
                }
                else
                {
                    if (choixFlagsRace3.Contains("WAIT_FOR_RACE_READY_INPUT"))
                    {
                        choixFlagsRace3.Remove("WAIT_FOR_RACE_READY_INPUT");
                    }
                    choixFlagsRace3.Add("WAIT_FOR_RACE_READY_INPUT");
                }

                //DisableDriveLine
                if (Form2.mainWindow.CheckBox_DisableDriveLineRace3.Checked)
                {
                    if (choixFlagsRace3.Contains("DISABLE_DRIVING_LINE"))
                    {
                        choixFlagsRace3.Remove("DISABLE_DRIVING_LINE");
                    }
                }
                else
                {
                    if (choixFlagsRace3.Contains("DISABLE_DRIVING_LINE"))
                    {
                        choixFlagsRace3.Remove("DISABLE_DRIVING_LINE");
                    }
                    choixFlagsRace3.Add("DISABLE_DRIVING_LINE");
                }

                //CustomSetup
                if (Form2.mainWindow.CheckBox_CustomSetupRace3.Checked)
                {
                    if (choixFlagsRace3.Contains("ALLOW_CUSTOM_VEHICLE_SETUP"))
                    {
                        choixFlagsRace3.Remove("ALLOW_CUSTOM_VEHICLE_SETUP");
                    }
                }
                else
                {
                    if (choixFlagsRace3.Contains("ALLOW_CUSTOM_VEHICLE_SETUP"))
                    {
                        choixFlagsRace3.Remove("ALLOW_CUSTOM_VEHICLE_SETUP");
                    }
                    choixFlagsRace3.Add("ALLOW_CUSTOM_VEHICLE_SETUP");
                }

                //Rank
                if (Form2.mainWindow.CheckBox_RankRace3.Checked == false)
                {
                    if (choixFlagsRace3.Contains("ONLINE_REPUTATION_ENABLED"))
                    {
                        choixFlagsRace3.Remove("ONLINE_REPUTATION_ENABLED");
                    }
                    choixFlagsRace3.Add("ONLINE_REPUTATION_ENABLED");
                }
            }
            // Timed Races or Laps

            if (Form2.mainWindow.RadioButton_LapsRace3.Checked)
            {
                if (choixFlagsRace3.Contains("TIMED_RACE"))
                {
                    choixFlagsRace3.Remove("TIMED_RACE");
                }
                choixFlagsRace3.Add("TIMED_RACE");
            }
        }
        public void SaveFlags4()
        {
            if (Form2.mainWindow.CheckBox_SameRules.Checked)
            {
                //CoolDownLap
                if (Form2.mainWindow.CheckBox_CoolDownLapRace1.Checked)
                {
                    if (choixFlagsRace4.Contains("COOLDOWNLAP"))
                    {
                        choixFlagsRace4.Remove("COOLDOWNLAP");
                    }
                }
                else
                {
                    if (choixFlagsRace4.Contains("COOLDOWNLAP"))
                    {
                        choixFlagsRace4.Remove("COOLDOWNLAP");
                    }
                    choixFlagsRace4.Add("COOLDOWNLAP");

                }

                //AbsAllowed
                if (Form2.mainWindow.CheckBox_AbsAllowedRace1.Checked)
                {
                    if (choixFlagsRace4.Contains("ABS_ALLOWED"))
                    {
                        choixFlagsRace4.Remove("ABS_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace4.Contains("ABS_ALLOWED"))
                    {
                        choixFlagsRace4.Remove("ABS_ALLOWED");
                    }
                    choixFlagsRace4.Add("ABS_ALLOWED");
                }

                //ScAllowed
                if (Form2.mainWindow.CheckBox_ScAllowedRace1.Checked)
                {
                    if (choixFlagsRace4.Contains("SC_ALLOWED"))
                    {
                        choixFlagsRace4.Remove("SC_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace4.Contains("SC_ALLOWED"))
                    {
                        choixFlagsRace4.Remove("SC_ALLOWED");
                    }
                    choixFlagsRace4.Add("SC_ALLOWED");
                }

                //TcsAllowed
                if (Form2.mainWindow.CheckBox_TcsAllowedRace1.Checked)
                {
                    if (choixFlagsRace4.Contains("TCS_ALLOWED"))
                    {
                        choixFlagsRace4.Remove("TCS_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace4.Contains("TCS_ALLOWED"))
                    {
                        choixFlagsRace4.Remove("TCS_ALLOWED");
                    }
                    choixFlagsRace4.Add("TCS_ALLOWED");
                }

                //FillSessionWithAi
                if (Form2.mainWindow.CheckBox_FillSessionWithAiRace1.Checked)
                {
                    if (choixFlagsRace4.Contains("FILL_SESSION_WITH_AI"))
                    {
                        choixFlagsRace4.Remove("FILL_SESSION_WITH_AI");
                    }
                }
                else
                {
                    if (choixFlagsRace4.Contains("FILL_SESSION_WITH_AI"))
                    {
                        choixFlagsRace4.Remove("FILL_SESSION_WITH_AI");
                    }
                    choixFlagsRace4.Add("FILL_SESSION_WITH_AI");
                }


                //MechanicalFailures
                if (Form2.mainWindow.CheckBox_MechanicalFailuresRace1.Checked)
                {
                    if (choixFlagsRace4.Contains("MECHANICAL_FAILURES"))
                    {
                        choixFlagsRace4.Remove("MECHANICAL_FAILURES");
                    }
                }
                else
                {
                    if (choixFlagsRace4.Contains("MECHANICAL_FAILURES"))
                    {
                        choixFlagsRace4.Remove("MECHANICAL_FAILURES");
                    }
                    choixFlagsRace4.Add("MECHANICAL_FAILURES");
                }

                //AutoStartEngine
                if (Form2.mainWindow.CheckBox_AutoStartEngineRace1.Checked)
                {
                    if (choixFlagsRace4.Contains("AUTO_START_ENGINE"))
                    {
                        choixFlagsRace4.Remove("AUTO_START_ENGINE");
                    }
                }
                else
                {
                    if (choixFlagsRace4.Contains("AUTO_START_ENGINE"))
                    {
                        choixFlagsRace4.Remove("AUTO_START_ENGINE");
                    }
                    choixFlagsRace4.Add("AUTO_START_ENGINE");
                }


                //WaitForRaceReady
                if (Form2.mainWindow.CheckBox_WaitForRaceReadyRace1.Checked)
                {
                    if (choixFlagsRace4.Contains("WAIT_FOR_RACE_READY_INPUT"))
                    {
                        choixFlagsRace4.Remove("WAIT_FOR_RACE_READY_INPUT");
                    }
                }
                else
                {
                    if (choixFlagsRace4.Contains("WAIT_FOR_RACE_READY_INPUT"))
                    {
                        choixFlagsRace4.Remove("WAIT_FOR_RACE_READY_INPUT");
                    }
                    choixFlagsRace4.Add("WAIT_FOR_RACE_READY_INPUT");
                }

                //DisableDriveLine
                if (Form2.mainWindow.CheckBox_DisableDriveLineRace1.Checked)
                {
                    if (choixFlagsRace4.Contains("DISABLE_DRIVING_LINE"))
                    {
                        choixFlagsRace4.Remove("DISABLE_DRIVING_LINE");
                    }
                }
                else
                {
                    if (choixFlagsRace4.Contains("DISABLE_DRIVING_LINE"))
                    {
                        choixFlagsRace4.Remove("DISABLE_DRIVING_LINE");
                    }
                    choixFlagsRace4.Add("DISABLE_DRIVING_LINE");
                }

                //CustomSetup
                if (Form2.mainWindow.CheckBox_CustomSetupRace1.Checked)
                {
                    if (choixFlagsRace4.Contains("ALLOW_CUSTOM_VEHICLE_SETUP"))
                    {
                        choixFlagsRace4.Remove("ALLOW_CUSTOM_VEHICLE_SETUP");
                    }
                }
                else
                {
                    if (choixFlagsRace4.Contains("ALLOW_CUSTOM_VEHICLE_SETUP"))
                    {
                        choixFlagsRace4.Remove("ALLOW_CUSTOM_VEHICLE_SETUP");
                    }
                    choixFlagsRace4.Add("ALLOW_CUSTOM_VEHICLE_SETUP");
                }

                //Rank
                if (Form2.mainWindow.CheckBox_RankRace1.Checked == false)
                {
                    if (choixFlagsRace4.Contains("ONLINE_REPUTATION_ENABLED"))
                    {
                        choixFlagsRace4.Remove("ONLINE_REPUTATION_ENABLED");
                    }
                    choixFlagsRace4.Add("ONLINE_REPUTATION_ENABLED");
                }
            }
            else
            {


                //CoolDownLap
                if (Form2.mainWindow.CheckBox_CoolDownLapRace4.Checked)
                {
                    if (choixFlagsRace4.Contains("COOLDOWNLAP"))
                    {
                        choixFlagsRace4.Remove("COOLDOWNLAP");
                    }
                }
                else
                {
                    if (choixFlagsRace4.Contains("COOLDOWNLAP"))
                    {
                        choixFlagsRace4.Remove("COOLDOWNLAP");
                    }
                    choixFlagsRace4.Add("COOLDOWNLAP");

                }

                //AbsAllowed
                if (Form2.mainWindow.CheckBox_AbsAllowedRace4.Checked)
                {
                    if (choixFlagsRace4.Contains("ABS_ALLOWED"))
                    {
                        choixFlagsRace4.Remove("ABS_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace4.Contains("ABS_ALLOWED"))
                    {
                        choixFlagsRace4.Remove("ABS_ALLOWED");
                    }
                    choixFlagsRace4.Add("ABS_ALLOWED");
                }

                //ScAllowed
                if (Form2.mainWindow.CheckBox_ScAllowedRace4.Checked)
                {
                    if (choixFlagsRace4.Contains("SC_ALLOWED"))
                    {
                        choixFlagsRace4.Remove("SC_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace4.Contains("SC_ALLOWED"))
                    {
                        choixFlagsRace4.Remove("SC_ALLOWED");
                    }
                    choixFlagsRace4.Add("SC_ALLOWED");
                }

                //TcsAllowed
                if (Form2.mainWindow.CheckBox_TcsAllowedRace4.Checked)
                {
                    if (choixFlagsRace4.Contains("TCS_ALLOWED"))
                    {
                        choixFlagsRace4.Remove("TCS_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace4.Contains("TCS_ALLOWED"))
                    {
                        choixFlagsRace4.Remove("TCS_ALLOWED");
                    }
                    choixFlagsRace4.Add("TCS_ALLOWED");
                }

                //FillSessionWithAi
                if (Form2.mainWindow.CheckBox_FillSessionWithAiRace4.Checked)
                {
                    if (choixFlagsRace4.Contains("FILL_SESSION_WITH_AI"))
                    {
                        choixFlagsRace4.Remove("FILL_SESSION_WITH_AI");
                    }
                }
                else
                {
                    if (choixFlagsRace4.Contains("FILL_SESSION_WITH_AI"))
                    {
                        choixFlagsRace4.Remove("FILL_SESSION_WITH_AI");
                    }
                    choixFlagsRace4.Add("FILL_SESSION_WITH_AI");
                }


                //MechanicalFailures
                if (Form2.mainWindow.CheckBox_MechanicalFailuresRace4.Checked)
                {
                    if (choixFlagsRace4.Contains("MECHANICAL_FAILURES"))
                    {
                        choixFlagsRace4.Remove("MECHANICAL_FAILURES");
                    }
                }
                else
                {
                    if (choixFlagsRace4.Contains("MECHANICAL_FAILURES"))
                    {
                        choixFlagsRace4.Remove("MECHANICAL_FAILURES");
                    }
                    choixFlagsRace4.Add("MECHANICAL_FAILURES");
                }

                //AutoStartEngine
                if (Form2.mainWindow.CheckBox_AutoStartEngineRace4.Checked)
                {
                    if (choixFlagsRace4.Contains("AUTO_START_ENGINE"))
                    {
                        choixFlagsRace4.Remove("AUTO_START_ENGINE");
                    }
                }
                else
                {
                    if (choixFlagsRace4.Contains("AUTO_START_ENGINE"))
                    {
                        choixFlagsRace4.Remove("AUTO_START_ENGINE");
                    }
                    choixFlagsRace4.Add("AUTO_START_ENGINE");
                }


                //WaitForRaceReady
                if (Form2.mainWindow.CheckBox_WaitForRaceReadyRace4.Checked)
                {
                    if (choixFlagsRace4.Contains("WAIT_FOR_RACE_READY_INPUT"))
                    {
                        choixFlagsRace4.Remove("WAIT_FOR_RACE_READY_INPUT");
                    }
                }
                else
                {
                    if (choixFlagsRace4.Contains("WAIT_FOR_RACE_READY_INPUT"))
                    {
                        choixFlagsRace4.Remove("WAIT_FOR_RACE_READY_INPUT");
                    }
                    choixFlagsRace4.Add("WAIT_FOR_RACE_READY_INPUT");
                }

                //DisableDriveLine
                if (Form2.mainWindow.CheckBox_DisableDriveLineRace4.Checked)
                {
                    if (choixFlagsRace4.Contains("DISABLE_DRIVING_LINE"))
                    {
                        choixFlagsRace4.Remove("DISABLE_DRIVING_LINE");
                    }
                }
                else
                {
                    if (choixFlagsRace4.Contains("DISABLE_DRIVING_LINE"))
                    {
                        choixFlagsRace4.Remove("DISABLE_DRIVING_LINE");
                    }
                    choixFlagsRace4.Add("DISABLE_DRIVING_LINE");
                }

                //CustomSetup
                if (Form2.mainWindow.CheckBox_CustomSetupRace4.Checked)
                {
                    if (choixFlagsRace4.Contains("ALLOW_CUSTOM_VEHICLE_SETUP"))
                    {
                        choixFlagsRace4.Remove("ALLOW_CUSTOM_VEHICLE_SETUP");
                    }
                }
                else
                {
                    if (choixFlagsRace4.Contains("ALLOW_CUSTOM_VEHICLE_SETUP"))
                    {
                        choixFlagsRace4.Remove("ALLOW_CUSTOM_VEHICLE_SETUP");
                    }
                    choixFlagsRace4.Add("ALLOW_CUSTOM_VEHICLE_SETUP");
                }

                //Rank
                if (Form2.mainWindow.CheckBox_RankRace4.Checked == false)
                {
                    if (choixFlagsRace4.Contains("ONLINE_REPUTATION_ENABLED"))
                    {
                        choixFlagsRace4.Remove("ONLINE_REPUTATION_ENABLED");
                    }
                    choixFlagsRace4.Add("ONLINE_REPUTATION_ENABLED");
                }
            }
            // Timed Races or Laps

            if (Form2.mainWindow.RadioButton_LapsRace4.Checked)
            {
                if (choixFlagsRace4.Contains("TIMED_RACE"))
                {
                    choixFlagsRace4.Remove("TIMED_RACE");
                }
                choixFlagsRace4.Add("TIMED_RACE");
            }
        }

        public void SaveFlags5()
        {
            if (Form2.mainWindow.CheckBox_SameRules.Checked)
            {
                //CoolDownLap
                if (Form2.mainWindow.CheckBox_CoolDownLapRace1.Checked)
                {
                    if (choixFlagsRace5.Contains("COOLDOWNLAP"))
                    {
                        choixFlagsRace5.Remove("COOLDOWNLAP");
                    }
                }
                else
                {
                    if (choixFlagsRace5.Contains("COOLDOWNLAP"))
                    {
                        choixFlagsRace5.Remove("COOLDOWNLAP");
                    }
                    choixFlagsRace5.Add("COOLDOWNLAP");

                }

                //AbsAllowed
                if (Form2.mainWindow.CheckBox_AbsAllowedRace1.Checked)
                {
                    if (choixFlagsRace5.Contains("ABS_ALLOWED"))
                    {
                        choixFlagsRace5.Remove("ABS_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace5.Contains("ABS_ALLOWED"))
                    {
                        choixFlagsRace5.Remove("ABS_ALLOWED");
                    }
                    choixFlagsRace5.Add("ABS_ALLOWED");
                }

                //ScAllowed
                if (Form2.mainWindow.CheckBox_ScAllowedRace1.Checked)
                {
                    if (choixFlagsRace5.Contains("SC_ALLOWED"))
                    {
                        choixFlagsRace5.Remove("SC_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace5.Contains("SC_ALLOWED"))
                    {
                        choixFlagsRace5.Remove("SC_ALLOWED");
                    }
                    choixFlagsRace5.Add("SC_ALLOWED");
                }

                //TcsAllowed
                if (Form2.mainWindow.CheckBox_TcsAllowedRace1.Checked)
                {
                    if (choixFlagsRace5.Contains("TCS_ALLOWED"))
                    {
                        choixFlagsRace5.Remove("TCS_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace5.Contains("TCS_ALLOWED"))
                    {
                        choixFlagsRace5.Remove("TCS_ALLOWED");
                    }
                    choixFlagsRace5.Add("TCS_ALLOWED");
                }

                //FillSessionWithAi
                if (Form2.mainWindow.CheckBox_FillSessionWithAiRace1.Checked)
                {
                    if (choixFlagsRace5.Contains("FILL_SESSION_WITH_AI"))
                    {
                        choixFlagsRace5.Remove("FILL_SESSION_WITH_AI");
                    }
                }
                else
                {
                    if (choixFlagsRace5.Contains("FILL_SESSION_WITH_AI"))
                    {
                        choixFlagsRace5.Remove("FILL_SESSION_WITH_AI");
                    }
                    choixFlagsRace5.Add("FILL_SESSION_WITH_AI");
                }


                //MechanicalFailures
                if (Form2.mainWindow.CheckBox_MechanicalFailuresRace1.Checked)
                {
                    if (choixFlagsRace5.Contains("MECHANICAL_FAILURES"))
                    {
                        choixFlagsRace5.Remove("MECHANICAL_FAILURES");
                    }
                }
                else
                {
                    if (choixFlagsRace5.Contains("MECHANICAL_FAILURES"))
                    {
                        choixFlagsRace5.Remove("MECHANICAL_FAILURES");
                    }
                    choixFlagsRace5.Add("MECHANICAL_FAILURES");
                }

                //AutoStartEngine
                if (Form2.mainWindow.CheckBox_AutoStartEngineRace1.Checked)
                {
                    if (choixFlagsRace5.Contains("AUTO_START_ENGINE"))
                    {
                        choixFlagsRace5.Remove("AUTO_START_ENGINE");
                    }
                }
                else
                {
                    if (choixFlagsRace5.Contains("AUTO_START_ENGINE"))
                    {
                        choixFlagsRace5.Remove("AUTO_START_ENGINE");
                    }
                    choixFlagsRace5.Add("AUTO_START_ENGINE");
                }


                //WaitForRaceReady
                if (Form2.mainWindow.CheckBox_WaitForRaceReadyRace1.Checked)
                {
                    if (choixFlagsRace5.Contains("WAIT_FOR_RACE_READY_INPUT"))
                    {
                        choixFlagsRace5.Remove("WAIT_FOR_RACE_READY_INPUT");
                    }
                }
                else
                {
                    if (choixFlagsRace5.Contains("WAIT_FOR_RACE_READY_INPUT"))
                    {
                        choixFlagsRace5.Remove("WAIT_FOR_RACE_READY_INPUT");
                    }
                    choixFlagsRace5.Add("WAIT_FOR_RACE_READY_INPUT");
                }

                //DisableDriveLine
                if (Form2.mainWindow.CheckBox_DisableDriveLineRace1.Checked)
                {
                    if (choixFlagsRace5.Contains("DISABLE_DRIVING_LINE"))
                    {
                        choixFlagsRace5.Remove("DISABLE_DRIVING_LINE");
                    }
                }
                else
                {
                    if (choixFlagsRace5.Contains("DISABLE_DRIVING_LINE"))
                    {
                        choixFlagsRace5.Remove("DISABLE_DRIVING_LINE");
                    }
                    choixFlagsRace5.Add("DISABLE_DRIVING_LINE");
                }

                //CustomSetup
                if (Form2.mainWindow.CheckBox_CustomSetupRace1.Checked)
                {
                    if (choixFlagsRace5.Contains("ALLOW_CUSTOM_VEHICLE_SETUP"))
                    {
                        choixFlagsRace5.Remove("ALLOW_CUSTOM_VEHICLE_SETUP");
                    }
                }
                else
                {
                    if (choixFlagsRace5.Contains("ALLOW_CUSTOM_VEHICLE_SETUP"))
                    {
                        choixFlagsRace5.Remove("ALLOW_CUSTOM_VEHICLE_SETUP");
                    }
                    choixFlagsRace5.Add("ALLOW_CUSTOM_VEHICLE_SETUP");
                }

                //Rank
                if (Form2.mainWindow.CheckBox_RankRace1.Checked == false)
                {
                    if (choixFlagsRace5.Contains("ONLINE_REPUTATION_ENABLED"))
                    {
                        choixFlagsRace5.Remove("ONLINE_REPUTATION_ENABLED");
                    }
                    choixFlagsRace5.Add("ONLINE_REPUTATION_ENABLED");
                }
            }
            else
            {


                //CoolDownLap
                if (Form2.mainWindow.CheckBox_CoolDownLapRace5.Checked)
                {
                    if (choixFlagsRace5.Contains("COOLDOWNLAP"))
                    {
                        choixFlagsRace5.Remove("COOLDOWNLAP");
                    }
                }
                else
                {
                    if (choixFlagsRace5.Contains("COOLDOWNLAP"))
                    {
                        choixFlagsRace5.Remove("COOLDOWNLAP");
                    }
                    choixFlagsRace5.Add("COOLDOWNLAP");

                }

                //AbsAllowed
                if (Form2.mainWindow.CheckBox_AbsAllowedRace5.Checked)
                {
                    if (choixFlagsRace5.Contains("ABS_ALLOWED"))
                    {
                        choixFlagsRace5.Remove("ABS_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace5.Contains("ABS_ALLOWED"))
                    {
                        choixFlagsRace5.Remove("ABS_ALLOWED");
                    }
                    choixFlagsRace5.Add("ABS_ALLOWED");
                }

                //ScAllowed
                if (Form2.mainWindow.CheckBox_ScAllowedRace5.Checked)
                {
                    if (choixFlagsRace5.Contains("SC_ALLOWED"))
                    {
                        choixFlagsRace5.Remove("SC_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace5.Contains("SC_ALLOWED"))
                    {
                        choixFlagsRace5.Remove("SC_ALLOWED");
                    }
                    choixFlagsRace5.Add("SC_ALLOWED");
                }

                //TcsAllowed
                if (Form2.mainWindow.CheckBox_TcsAllowedRace5.Checked)
                {
                    if (choixFlagsRace5.Contains("TCS_ALLOWED"))
                    {
                        choixFlagsRace5.Remove("TCS_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace5.Contains("TCS_ALLOWED"))
                    {
                        choixFlagsRace5.Remove("TCS_ALLOWED");
                    }
                    choixFlagsRace5.Add("TCS_ALLOWED");
                }

                //FillSessionWithAi
                if (Form2.mainWindow.CheckBox_FillSessionWithAiRace5.Checked)
                {
                    if (choixFlagsRace5.Contains("FILL_SESSION_WITH_AI"))
                    {
                        choixFlagsRace5.Remove("FILL_SESSION_WITH_AI");
                    }
                }
                else
                {
                    if (choixFlagsRace5.Contains("FILL_SESSION_WITH_AI"))
                    {
                        choixFlagsRace5.Remove("FILL_SESSION_WITH_AI");
                    }
                    choixFlagsRace5.Add("FILL_SESSION_WITH_AI");
                }


                //MechanicalFailures
                if (Form2.mainWindow.CheckBox_MechanicalFailuresRace5.Checked)
                {
                    if (choixFlagsRace5.Contains("MECHANICAL_FAILURES"))
                    {
                        choixFlagsRace5.Remove("MECHANICAL_FAILURES");
                    }
                }
                else
                {
                    if (choixFlagsRace5.Contains("MECHANICAL_FAILURES"))
                    {
                        choixFlagsRace5.Remove("MECHANICAL_FAILURES");
                    }
                    choixFlagsRace5.Add("MECHANICAL_FAILURES");
                }

                //AutoStartEngine
                if (Form2.mainWindow.CheckBox_AutoStartEngineRace5.Checked)
                {
                    if (choixFlagsRace5.Contains("AUTO_START_ENGINE"))
                    {
                        choixFlagsRace5.Remove("AUTO_START_ENGINE");
                    }
                }
                else
                {
                    if (choixFlagsRace5.Contains("AUTO_START_ENGINE"))
                    {
                        choixFlagsRace5.Remove("AUTO_START_ENGINE");
                    }
                    choixFlagsRace5.Add("AUTO_START_ENGINE");
                }


                //WaitForRaceReady
                if (Form2.mainWindow.CheckBox_WaitForRaceReadyRace5.Checked)
                {
                    if (choixFlagsRace5.Contains("WAIT_FOR_RACE_READY_INPUT"))
                    {
                        choixFlagsRace5.Remove("WAIT_FOR_RACE_READY_INPUT");
                    }
                }
                else
                {
                    if (choixFlagsRace5.Contains("WAIT_FOR_RACE_READY_INPUT"))
                    {
                        choixFlagsRace5.Remove("WAIT_FOR_RACE_READY_INPUT");
                    }
                    choixFlagsRace5.Add("WAIT_FOR_RACE_READY_INPUT");
                }

                //DisableDriveLine
                if (Form2.mainWindow.CheckBox_DisableDriveLineRace5.Checked)
                {
                    if (choixFlagsRace5.Contains("DISABLE_DRIVING_LINE"))
                    {
                        choixFlagsRace5.Remove("DISABLE_DRIVING_LINE");
                    }
                }
                else
                {
                    if (choixFlagsRace5.Contains("DISABLE_DRIVING_LINE"))
                    {
                        choixFlagsRace5.Remove("DISABLE_DRIVING_LINE");
                    }
                    choixFlagsRace5.Add("DISABLE_DRIVING_LINE");
                }

                //CustomSetup
                if (Form2.mainWindow.CheckBox_CustomSetupRace5.Checked)
                {
                    if (choixFlagsRace5.Contains("ALLOW_CUSTOM_VEHICLE_SETUP"))
                    {
                        choixFlagsRace5.Remove("ALLOW_CUSTOM_VEHICLE_SETUP");
                    }
                }
                else
                {
                    if (choixFlagsRace5.Contains("ALLOW_CUSTOM_VEHICLE_SETUP"))
                    {
                        choixFlagsRace5.Remove("ALLOW_CUSTOM_VEHICLE_SETUP");
                    }
                    choixFlagsRace5.Add("ALLOW_CUSTOM_VEHICLE_SETUP");
                }

                //Rank
                if (Form2.mainWindow.CheckBox_RankRace5.Checked == false)
                {
                    if (choixFlagsRace5.Contains("ONLINE_REPUTATION_ENABLED"))
                    {
                        choixFlagsRace5.Remove("ONLINE_REPUTATION_ENABLED");
                    }
                    choixFlagsRace5.Add("ONLINE_REPUTATION_ENABLED");
                }
            }
            // Timed Races or Laps

            if (Form2.mainWindow.RadioButton_LapsRace5.Checked)
            {
                if (choixFlagsRace5.Contains("TIMED_RACE"))
                {
                    choixFlagsRace5.Remove("TIMED_RACE");
                }
                choixFlagsRace5.Add("TIMED_RACE");
            }
        }

        public void SaveFlags6()
        {
            if (Form2.mainWindow.CheckBox_SameRules.Checked)
            {
                //CoolDownLap
                if (Form2.mainWindow.CheckBox_CoolDownLapRace1.Checked)
                {
                    if (choixFlagsRace6.Contains("COOLDOWNLAP"))
                    {
                        choixFlagsRace6.Remove("COOLDOWNLAP");
                    }
                }
                else
                {
                    if (choixFlagsRace6.Contains("COOLDOWNLAP"))
                    {
                        choixFlagsRace6.Remove("COOLDOWNLAP");
                    }
                    choixFlagsRace6.Add("COOLDOWNLAP");

                }

                //AbsAllowed
                if (Form2.mainWindow.CheckBox_AbsAllowedRace1.Checked)
                {
                    if (choixFlagsRace6.Contains("ABS_ALLOWED"))
                    {
                        choixFlagsRace6.Remove("ABS_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace6.Contains("ABS_ALLOWED"))
                    {
                        choixFlagsRace6.Remove("ABS_ALLOWED");
                    }
                    choixFlagsRace6.Add("ABS_ALLOWED");
                }

                //ScAllowed
                if (Form2.mainWindow.CheckBox_ScAllowedRace1.Checked)
                {
                    if (choixFlagsRace6.Contains("SC_ALLOWED"))
                    {
                        choixFlagsRace6.Remove("SC_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace6.Contains("SC_ALLOWED"))
                    {
                        choixFlagsRace6.Remove("SC_ALLOWED");
                    }
                    choixFlagsRace6.Add("SC_ALLOWED");
                }

                //TcsAllowed
                if (Form2.mainWindow.CheckBox_TcsAllowedRace1.Checked)
                {
                    if (choixFlagsRace6.Contains("TCS_ALLOWED"))
                    {
                        choixFlagsRace6.Remove("TCS_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace6.Contains("TCS_ALLOWED"))
                    {
                        choixFlagsRace6.Remove("TCS_ALLOWED");
                    }
                    choixFlagsRace6.Add("TCS_ALLOWED");
                }

                //FillSessionWithAi
                if (Form2.mainWindow.CheckBox_FillSessionWithAiRace1.Checked)
                {
                    if (choixFlagsRace6.Contains("FILL_SESSION_WITH_AI"))
                    {
                        choixFlagsRace6.Remove("FILL_SESSION_WITH_AI");
                    }
                }
                else
                {
                    if (choixFlagsRace6.Contains("FILL_SESSION_WITH_AI"))
                    {
                        choixFlagsRace6.Remove("FILL_SESSION_WITH_AI");
                    }
                    choixFlagsRace6.Add("FILL_SESSION_WITH_AI");
                }


                //MechanicalFailures
                if (Form2.mainWindow.CheckBox_MechanicalFailuresRace1.Checked)
                {
                    if (choixFlagsRace6.Contains("MECHANICAL_FAILURES"))
                    {
                        choixFlagsRace6.Remove("MECHANICAL_FAILURES");
                    }
                }
                else
                {
                    if (choixFlagsRace6.Contains("MECHANICAL_FAILURES"))
                    {
                        choixFlagsRace6.Remove("MECHANICAL_FAILURES");
                    }
                    choixFlagsRace6.Add("MECHANICAL_FAILURES");
                }

                //AutoStartEngine
                if (Form2.mainWindow.CheckBox_AutoStartEngineRace1.Checked)
                {
                    if (choixFlagsRace6.Contains("AUTO_START_ENGINE"))
                    {
                        choixFlagsRace6.Remove("AUTO_START_ENGINE");
                    }
                }
                else
                {
                    if (choixFlagsRace6.Contains("AUTO_START_ENGINE"))
                    {
                        choixFlagsRace6.Remove("AUTO_START_ENGINE");
                    }
                    choixFlagsRace6.Add("AUTO_START_ENGINE");
                }


                //WaitForRaceReady
                if (Form2.mainWindow.CheckBox_WaitForRaceReadyRace1.Checked)
                {
                    if (choixFlagsRace6.Contains("WAIT_FOR_RACE_READY_INPUT"))
                    {
                        choixFlagsRace6.Remove("WAIT_FOR_RACE_READY_INPUT");
                    }
                }
                else
                {
                    if (choixFlagsRace6.Contains("WAIT_FOR_RACE_READY_INPUT"))
                    {
                        choixFlagsRace6.Remove("WAIT_FOR_RACE_READY_INPUT");
                    }
                    choixFlagsRace6.Add("WAIT_FOR_RACE_READY_INPUT");
                }

                //DisableDriveLine
                if (Form2.mainWindow.CheckBox_DisableDriveLineRace1.Checked)
                {
                    if (choixFlagsRace6.Contains("DISABLE_DRIVING_LINE"))
                    {
                        choixFlagsRace6.Remove("DISABLE_DRIVING_LINE");
                    }
                }
                else
                {
                    if (choixFlagsRace6.Contains("DISABLE_DRIVING_LINE"))
                    {
                        choixFlagsRace6.Remove("DISABLE_DRIVING_LINE");
                    }
                    choixFlagsRace6.Add("DISABLE_DRIVING_LINE");
                }

                //CustomSetup
                if (Form2.mainWindow.CheckBox_CustomSetupRace1.Checked)
                {
                    if (choixFlagsRace6.Contains("ALLOW_CUSTOM_VEHICLE_SETUP"))
                    {
                        choixFlagsRace6.Remove("ALLOW_CUSTOM_VEHICLE_SETUP");
                    }
                }
                else
                {
                    if (choixFlagsRace6.Contains("ALLOW_CUSTOM_VEHICLE_SETUP"))
                    {
                        choixFlagsRace6.Remove("ALLOW_CUSTOM_VEHICLE_SETUP");
                    }
                    choixFlagsRace6.Add("ALLOW_CUSTOM_VEHICLE_SETUP");
                }

                //Rank
                if (Form2.mainWindow.CheckBox_RankRace1.Checked == false)
                {
                    if (choixFlagsRace6.Contains("ONLINE_REPUTATION_ENABLED"))
                    {
                        choixFlagsRace6.Remove("ONLINE_REPUTATION_ENABLED");
                    }
                    choixFlagsRace6.Add("ONLINE_REPUTATION_ENABLED");
                }
            }
            else
            {


                //CoolDownLap
                if (Form2.mainWindow.CheckBox_CoolDownLapRace6.Checked)
                {
                    if (choixFlagsRace6.Contains("COOLDOWNLAP"))
                    {
                        choixFlagsRace6.Remove("COOLDOWNLAP");
                    }
                }
                else
                {
                    if (choixFlagsRace6.Contains("COOLDOWNLAP"))
                    {
                        choixFlagsRace6.Remove("COOLDOWNLAP");
                    }
                    choixFlagsRace6.Add("COOLDOWNLAP");

                }

                //AbsAllowed
                if (Form2.mainWindow.CheckBox_AbsAllowedRace6.Checked)
                {
                    if (choixFlagsRace6.Contains("ABS_ALLOWED"))
                    {
                        choixFlagsRace6.Remove("ABS_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace6.Contains("ABS_ALLOWED"))
                    {
                        choixFlagsRace6.Remove("ABS_ALLOWED");
                    }
                    choixFlagsRace6.Add("ABS_ALLOWED");
                }

                //ScAllowed
                if (Form2.mainWindow.CheckBox_ScAllowedRace6.Checked)
                {
                    if (choixFlagsRace6.Contains("SC_ALLOWED"))
                    {
                        choixFlagsRace6.Remove("SC_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace6.Contains("SC_ALLOWED"))
                    {
                        choixFlagsRace6.Remove("SC_ALLOWED");
                    }
                    choixFlagsRace6.Add("SC_ALLOWED");
                }

                //TcsAllowed
                if (Form2.mainWindow.CheckBox_TcsAllowedRace6.Checked)
                {
                    if (choixFlagsRace6.Contains("TCS_ALLOWED"))
                    {
                        choixFlagsRace6.Remove("TCS_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace6.Contains("TCS_ALLOWED"))
                    {
                        choixFlagsRace6.Remove("TCS_ALLOWED");
                    }
                    choixFlagsRace6.Add("TCS_ALLOWED");
                }

                //FillSessionWithAi
                if (Form2.mainWindow.CheckBox_FillSessionWithAiRace6.Checked)
                {
                    if (choixFlagsRace6.Contains("FILL_SESSION_WITH_AI"))
                    {
                        choixFlagsRace6.Remove("FILL_SESSION_WITH_AI");
                    }
                }
                else
                {
                    if (choixFlagsRace6.Contains("FILL_SESSION_WITH_AI"))
                    {
                        choixFlagsRace6.Remove("FILL_SESSION_WITH_AI");
                    }
                    choixFlagsRace6.Add("FILL_SESSION_WITH_AI");
                }


                //MechanicalFailures
                if (Form2.mainWindow.CheckBox_MechanicalFailuresRace6.Checked)
                {
                    if (choixFlagsRace6.Contains("MECHANICAL_FAILURES"))
                    {
                        choixFlagsRace6.Remove("MECHANICAL_FAILURES");
                    }
                }
                else
                {
                    if (choixFlagsRace6.Contains("MECHANICAL_FAILURES"))
                    {
                        choixFlagsRace6.Remove("MECHANICAL_FAILURES");
                    }
                    choixFlagsRace6.Add("MECHANICAL_FAILURES");
                }

                //AutoStartEngine
                if (Form2.mainWindow.CheckBox_AutoStartEngineRace6.Checked)
                {
                    if (choixFlagsRace6.Contains("AUTO_START_ENGINE"))
                    {
                        choixFlagsRace6.Remove("AUTO_START_ENGINE");
                    }
                }
                else
                {
                    if (choixFlagsRace6.Contains("AUTO_START_ENGINE"))
                    {
                        choixFlagsRace6.Remove("AUTO_START_ENGINE");
                    }
                    choixFlagsRace6.Add("AUTO_START_ENGINE");
                }


                //WaitForRaceReady
                if (Form2.mainWindow.CheckBox_WaitForRaceReadyRace6.Checked)
                {
                    if (choixFlagsRace6.Contains("WAIT_FOR_RACE_READY_INPUT"))
                    {
                        choixFlagsRace6.Remove("WAIT_FOR_RACE_READY_INPUT");
                    }
                }
                else
                {
                    if (choixFlagsRace6.Contains("WAIT_FOR_RACE_READY_INPUT"))
                    {
                        choixFlagsRace6.Remove("WAIT_FOR_RACE_READY_INPUT");
                    }
                    choixFlagsRace6.Add("WAIT_FOR_RACE_READY_INPUT");
                }

                //DisableDriveLine
                if (Form2.mainWindow.CheckBox_DisableDriveLineRace6.Checked)
                {
                    if (choixFlagsRace6.Contains("DISABLE_DRIVING_LINE"))
                    {
                        choixFlagsRace6.Remove("DISABLE_DRIVING_LINE");
                    }
                }
                else
                {
                    if (choixFlagsRace6.Contains("DISABLE_DRIVING_LINE"))
                    {
                        choixFlagsRace6.Remove("DISABLE_DRIVING_LINE");
                    }
                    choixFlagsRace6.Add("DISABLE_DRIVING_LINE");
                }

                //CustomSetup
                if (Form2.mainWindow.CheckBox_CustomSetupRace6.Checked)
                {
                    if (choixFlagsRace6.Contains("ALLOW_CUSTOM_VEHICLE_SETUP"))
                    {
                        choixFlagsRace6.Remove("ALLOW_CUSTOM_VEHICLE_SETUP");
                    }
                }
                else
                {
                    if (choixFlagsRace6.Contains("ALLOW_CUSTOM_VEHICLE_SETUP"))
                    {
                        choixFlagsRace6.Remove("ALLOW_CUSTOM_VEHICLE_SETUP");
                    }
                    choixFlagsRace6.Add("ALLOW_CUSTOM_VEHICLE_SETUP");
                }

                //Rank
                if (Form2.mainWindow.CheckBox_RankRace6.Checked == false)
                {
                    if (choixFlagsRace6.Contains("ONLINE_REPUTATION_ENABLED"))
                    {
                        choixFlagsRace6.Remove("ONLINE_REPUTATION_ENABLED");
                    }
                    choixFlagsRace6.Add("ONLINE_REPUTATION_ENABLED");
                }
            }
            // Timed Races or Laps

            if (Form2.mainWindow.RadioButton_LapsRace6.Checked)
            {
                if (choixFlagsRace6.Contains("TIMED_RACE"))
                {
                    choixFlagsRace6.Remove("TIMED_RACE");
                }
                choixFlagsRace6.Add("TIMED_RACE");
            }
        }

        public void SaveFlags7()
        {
            if (Form2.mainWindow.CheckBox_SameRules.Checked)
            {
                //CoolDownLap
                if (Form2.mainWindow.CheckBox_CoolDownLapRace1.Checked)
                {
                    if (choixFlagsRace7.Contains("COOLDOWNLAP"))
                    {
                        choixFlagsRace7.Remove("COOLDOWNLAP");
                    }
                }
                else
                {
                    if (choixFlagsRace7.Contains("COOLDOWNLAP"))
                    {
                        choixFlagsRace7.Remove("COOLDOWNLAP");
                    }
                    choixFlagsRace7.Add("COOLDOWNLAP");

                }

                //AbsAllowed
                if (Form2.mainWindow.CheckBox_AbsAllowedRace1.Checked)
                {
                    if (choixFlagsRace7.Contains("ABS_ALLOWED"))
                    {
                        choixFlagsRace7.Remove("ABS_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace7.Contains("ABS_ALLOWED"))
                    {
                        choixFlagsRace7.Remove("ABS_ALLOWED");
                    }
                    choixFlagsRace7.Add("ABS_ALLOWED");
                }

                //ScAllowed
                if (Form2.mainWindow.CheckBox_ScAllowedRace1.Checked)
                {
                    if (choixFlagsRace7.Contains("SC_ALLOWED"))
                    {
                        choixFlagsRace7.Remove("SC_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace7.Contains("SC_ALLOWED"))
                    {
                        choixFlagsRace7.Remove("SC_ALLOWED");
                    }
                    choixFlagsRace7.Add("SC_ALLOWED");
                }

                //TcsAllowed
                if (Form2.mainWindow.CheckBox_TcsAllowedRace1.Checked)
                {
                    if (choixFlagsRace7.Contains("TCS_ALLOWED"))
                    {
                        choixFlagsRace7.Remove("TCS_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace7.Contains("TCS_ALLOWED"))
                    {
                        choixFlagsRace7.Remove("TCS_ALLOWED");
                    }
                    choixFlagsRace7.Add("TCS_ALLOWED");
                }

                //FillSessionWithAi
                if (Form2.mainWindow.CheckBox_FillSessionWithAiRace1.Checked)
                {
                    if (choixFlagsRace7.Contains("FILL_SESSION_WITH_AI"))
                    {
                        choixFlagsRace7.Remove("FILL_SESSION_WITH_AI");
                    }
                }
                else
                {
                    if (choixFlagsRace7.Contains("FILL_SESSION_WITH_AI"))
                    {
                        choixFlagsRace7.Remove("FILL_SESSION_WITH_AI");
                    }
                    choixFlagsRace7.Add("FILL_SESSION_WITH_AI");
                }


                //MechanicalFailures
                if (Form2.mainWindow.CheckBox_MechanicalFailuresRace1.Checked)
                {
                    if (choixFlagsRace7.Contains("MECHANICAL_FAILURES"))
                    {
                        choixFlagsRace7.Remove("MECHANICAL_FAILURES");
                    }
                }
                else
                {
                    if (choixFlagsRace7.Contains("MECHANICAL_FAILURES"))
                    {
                        choixFlagsRace7.Remove("MECHANICAL_FAILURES");
                    }
                    choixFlagsRace7.Add("MECHANICAL_FAILURES");
                }

                //AutoStartEngine
                if (Form2.mainWindow.CheckBox_AutoStartEngineRace1.Checked)
                {
                    if (choixFlagsRace7.Contains("AUTO_START_ENGINE"))
                    {
                        choixFlagsRace7.Remove("AUTO_START_ENGINE");
                    }
                }
                else
                {
                    if (choixFlagsRace7.Contains("AUTO_START_ENGINE"))
                    {
                        choixFlagsRace7.Remove("AUTO_START_ENGINE");
                    }
                    choixFlagsRace7.Add("AUTO_START_ENGINE");
                }


                //WaitForRaceReady
                if (Form2.mainWindow.CheckBox_WaitForRaceReadyRace1.Checked)
                {
                    if (choixFlagsRace7.Contains("WAIT_FOR_RACE_READY_INPUT"))
                    {
                        choixFlagsRace7.Remove("WAIT_FOR_RACE_READY_INPUT");
                    }
                }
                else
                {
                    if (choixFlagsRace7.Contains("WAIT_FOR_RACE_READY_INPUT"))
                    {
                        choixFlagsRace7.Remove("WAIT_FOR_RACE_READY_INPUT");
                    }
                    choixFlagsRace7.Add("WAIT_FOR_RACE_READY_INPUT");
                }

                //DisableDriveLine
                if (Form2.mainWindow.CheckBox_DisableDriveLineRace1.Checked)
                {
                    if (choixFlagsRace7.Contains("DISABLE_DRIVING_LINE"))
                    {
                        choixFlagsRace7.Remove("DISABLE_DRIVING_LINE");
                    }
                }
                else
                {
                    if (choixFlagsRace7.Contains("DISABLE_DRIVING_LINE"))
                    {
                        choixFlagsRace7.Remove("DISABLE_DRIVING_LINE");
                    }
                    choixFlagsRace7.Add("DISABLE_DRIVING_LINE");
                }

                //CustomSetup
                if (Form2.mainWindow.CheckBox_CustomSetupRace1.Checked)
                {
                    if (choixFlagsRace7.Contains("ALLOW_CUSTOM_VEHICLE_SETUP"))
                    {
                        choixFlagsRace7.Remove("ALLOW_CUSTOM_VEHICLE_SETUP");
                    }
                }
                else
                {
                    if (choixFlagsRace7.Contains("ALLOW_CUSTOM_VEHICLE_SETUP"))
                    {
                        choixFlagsRace7.Remove("ALLOW_CUSTOM_VEHICLE_SETUP");
                    }
                    choixFlagsRace7.Add("ALLOW_CUSTOM_VEHICLE_SETUP");
                }

                //Rank
                if (Form2.mainWindow.CheckBox_RankRace1.Checked == false)
                {
                    if (choixFlagsRace7.Contains("ONLINE_REPUTATION_ENABLED"))
                    {
                        choixFlagsRace7.Remove("ONLINE_REPUTATION_ENABLED");
                    }
                    choixFlagsRace7.Add("ONLINE_REPUTATION_ENABLED");
                }
            }
            else
            {


                //CoolDownLap
                if (Form2.mainWindow.CheckBox_CoolDownLapRace7.Checked)
                {
                    if (choixFlagsRace7.Contains("COOLDOWNLAP"))
                    {
                        choixFlagsRace7.Remove("COOLDOWNLAP");
                    }
                }
                else
                {
                    if (choixFlagsRace7.Contains("COOLDOWNLAP"))
                    {
                        choixFlagsRace7.Remove("COOLDOWNLAP");
                    }
                    choixFlagsRace7.Add("COOLDOWNLAP");

                }

                //AbsAllowed
                if (Form2.mainWindow.CheckBox_AbsAllowedRace7.Checked)
                {
                    if (choixFlagsRace7.Contains("ABS_ALLOWED"))
                    {
                        choixFlagsRace7.Remove("ABS_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace7.Contains("ABS_ALLOWED"))
                    {
                        choixFlagsRace7.Remove("ABS_ALLOWED");
                    }
                    choixFlagsRace7.Add("ABS_ALLOWED");
                }

                //ScAllowed
                if (Form2.mainWindow.CheckBox_ScAllowedRace7.Checked)
                {
                    if (choixFlagsRace7.Contains("SC_ALLOWED"))
                    {
                        choixFlagsRace7.Remove("SC_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace7.Contains("SC_ALLOWED"))
                    {
                        choixFlagsRace7.Remove("SC_ALLOWED");
                    }
                    choixFlagsRace7.Add("SC_ALLOWED");
                }

                //TcsAllowed
                if (Form2.mainWindow.CheckBox_TcsAllowedRace7.Checked)
                {
                    if (choixFlagsRace7.Contains("TCS_ALLOWED"))
                    {
                        choixFlagsRace7.Remove("TCS_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace7.Contains("TCS_ALLOWED"))
                    {
                        choixFlagsRace7.Remove("TCS_ALLOWED");
                    }
                    choixFlagsRace7.Add("TCS_ALLOWED");
                }

                //FillSessionWithAi
                if (Form2.mainWindow.CheckBox_FillSessionWithAiRace7.Checked)
                {
                    if (choixFlagsRace7.Contains("FILL_SESSION_WITH_AI"))
                    {
                        choixFlagsRace7.Remove("FILL_SESSION_WITH_AI");
                    }
                }
                else
                {
                    if (choixFlagsRace7.Contains("FILL_SESSION_WITH_AI"))
                    {
                        choixFlagsRace7.Remove("FILL_SESSION_WITH_AI");
                    }
                    choixFlagsRace7.Add("FILL_SESSION_WITH_AI");
                }


                //MechanicalFailures
                if (Form2.mainWindow.CheckBox_MechanicalFailuresRace7.Checked)
                {
                    if (choixFlagsRace7.Contains("MECHANICAL_FAILURES"))
                    {
                        choixFlagsRace7.Remove("MECHANICAL_FAILURES");
                    }
                }
                else
                {
                    if (choixFlagsRace7.Contains("MECHANICAL_FAILURES"))
                    {
                        choixFlagsRace7.Remove("MECHANICAL_FAILURES");
                    }
                    choixFlagsRace7.Add("MECHANICAL_FAILURES");
                }

                //AutoStartEngine
                if (Form2.mainWindow.CheckBox_AutoStartEngineRace7.Checked)
                {
                    if (choixFlagsRace7.Contains("AUTO_START_ENGINE"))
                    {
                        choixFlagsRace7.Remove("AUTO_START_ENGINE");
                    }
                }
                else
                {
                    if (choixFlagsRace7.Contains("AUTO_START_ENGINE"))
                    {
                        choixFlagsRace7.Remove("AUTO_START_ENGINE");
                    }
                    choixFlagsRace7.Add("AUTO_START_ENGINE");
                }


                //WaitForRaceReady
                if (Form2.mainWindow.CheckBox_WaitForRaceReadyRace7.Checked)
                {
                    if (choixFlagsRace7.Contains("WAIT_FOR_RACE_READY_INPUT"))
                    {
                        choixFlagsRace7.Remove("WAIT_FOR_RACE_READY_INPUT");
                    }
                }
                else
                {
                    if (choixFlagsRace7.Contains("WAIT_FOR_RACE_READY_INPUT"))
                    {
                        choixFlagsRace7.Remove("WAIT_FOR_RACE_READY_INPUT");
                    }
                    choixFlagsRace7.Add("WAIT_FOR_RACE_READY_INPUT");
                }

                //DisableDriveLine
                if (Form2.mainWindow.CheckBox_DisableDriveLineRace7.Checked)
                {
                    if (choixFlagsRace7.Contains("DISABLE_DRIVING_LINE"))
                    {
                        choixFlagsRace7.Remove("DISABLE_DRIVING_LINE");
                    }
                }
                else
                {
                    if (choixFlagsRace7.Contains("DISABLE_DRIVING_LINE"))
                    {
                        choixFlagsRace7.Remove("DISABLE_DRIVING_LINE");
                    }
                    choixFlagsRace7.Add("DISABLE_DRIVING_LINE");
                }

                //CustomSetup
                if (Form2.mainWindow.CheckBox_CustomSetupRace7.Checked)
                {
                    if (choixFlagsRace7.Contains("ALLOW_CUSTOM_VEHICLE_SETUP"))
                    {
                        choixFlagsRace7.Remove("ALLOW_CUSTOM_VEHICLE_SETUP");
                    }
                }
                else
                {
                    if (choixFlagsRace7.Contains("ALLOW_CUSTOM_VEHICLE_SETUP"))
                    {
                        choixFlagsRace7.Remove("ALLOW_CUSTOM_VEHICLE_SETUP");
                    }
                    choixFlagsRace7.Add("ALLOW_CUSTOM_VEHICLE_SETUP");
                }

                //Rank
                if (Form2.mainWindow.CheckBox_RankRace7.Checked == false)
                {
                    if (choixFlagsRace7.Contains("ONLINE_REPUTATION_ENABLED"))
                    {
                        choixFlagsRace7.Remove("ONLINE_REPUTATION_ENABLED");
                    }
                    choixFlagsRace7.Add("ONLINE_REPUTATION_ENABLED");
                }
            }
            // Timed Races or Laps

            if (Form2.mainWindow.RadioButton_LapsRace7.Checked)
            {
                if (choixFlagsRace7.Contains("TIMED_RACE"))
                {
                    choixFlagsRace7.Remove("TIMED_RACE");
                }
                choixFlagsRace7.Add("TIMED_RACE");
            }
        }

        public void SaveFlags8()
        {
            if (Form2.mainWindow.CheckBox_SameRules.Checked)
            {
                //CoolDownLap
                if (Form2.mainWindow.CheckBox_CoolDownLapRace1.Checked)
                {
                    if (choixFlagsRace8.Contains("COOLDOWNLAP"))
                    {
                        choixFlagsRace8.Remove("COOLDOWNLAP");
                    }
                }
                else
                {
                    if (choixFlagsRace8.Contains("COOLDOWNLAP"))
                    {
                        choixFlagsRace8.Remove("COOLDOWNLAP");
                    }
                    choixFlagsRace8.Add("COOLDOWNLAP");

                }

                //AbsAllowed
                if (Form2.mainWindow.CheckBox_AbsAllowedRace1.Checked)
                {
                    if (choixFlagsRace8.Contains("ABS_ALLOWED"))
                    {
                        choixFlagsRace8.Remove("ABS_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace8.Contains("ABS_ALLOWED"))
                    {
                        choixFlagsRace8.Remove("ABS_ALLOWED");
                    }
                    choixFlagsRace8.Add("ABS_ALLOWED");
                }

                //ScAllowed
                if (Form2.mainWindow.CheckBox_ScAllowedRace1.Checked)
                {
                    if (choixFlagsRace8.Contains("SC_ALLOWED"))
                    {
                        choixFlagsRace8.Remove("SC_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace8.Contains("SC_ALLOWED"))
                    {
                        choixFlagsRace8.Remove("SC_ALLOWED");
                    }
                    choixFlagsRace8.Add("SC_ALLOWED");
                }

                //TcsAllowed
                if (Form2.mainWindow.CheckBox_TcsAllowedRace1.Checked)
                {
                    if (choixFlagsRace8.Contains("TCS_ALLOWED"))
                    {
                        choixFlagsRace8.Remove("TCS_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace8.Contains("TCS_ALLOWED"))
                    {
                        choixFlagsRace8.Remove("TCS_ALLOWED");
                    }
                    choixFlagsRace8.Add("TCS_ALLOWED");
                }

                //FillSessionWithAi
                if (Form2.mainWindow.CheckBox_FillSessionWithAiRace1.Checked)
                {
                    if (choixFlagsRace8.Contains("FILL_SESSION_WITH_AI"))
                    {
                        choixFlagsRace8.Remove("FILL_SESSION_WITH_AI");
                    }
                }
                else
                {
                    if (choixFlagsRace8.Contains("FILL_SESSION_WITH_AI"))
                    {
                        choixFlagsRace8.Remove("FILL_SESSION_WITH_AI");
                    }
                    choixFlagsRace8.Add("FILL_SESSION_WITH_AI");
                }


                //MechanicalFailures
                if (Form2.mainWindow.CheckBox_MechanicalFailuresRace1.Checked)
                {
                    if (choixFlagsRace8.Contains("MECHANICAL_FAILURES"))
                    {
                        choixFlagsRace8.Remove("MECHANICAL_FAILURES");
                    }
                }
                else
                {
                    if (choixFlagsRace8.Contains("MECHANICAL_FAILURES"))
                    {
                        choixFlagsRace8.Remove("MECHANICAL_FAILURES");
                    }
                    choixFlagsRace8.Add("MECHANICAL_FAILURES");
                }

                //AutoStartEngine
                if (Form2.mainWindow.CheckBox_AutoStartEngineRace1.Checked)
                {
                    if (choixFlagsRace8.Contains("AUTO_START_ENGINE"))
                    {
                        choixFlagsRace8.Remove("AUTO_START_ENGINE");
                    }
                }
                else
                {
                    if (choixFlagsRace8.Contains("AUTO_START_ENGINE"))
                    {
                        choixFlagsRace8.Remove("AUTO_START_ENGINE");
                    }
                    choixFlagsRace8.Add("AUTO_START_ENGINE");
                }


                //WaitForRaceReady
                if (Form2.mainWindow.CheckBox_WaitForRaceReadyRace1.Checked)
                {
                    if (choixFlagsRace8.Contains("WAIT_FOR_RACE_READY_INPUT"))
                    {
                        choixFlagsRace8.Remove("WAIT_FOR_RACE_READY_INPUT");
                    }
                }
                else
                {
                    if (choixFlagsRace8.Contains("WAIT_FOR_RACE_READY_INPUT"))
                    {
                        choixFlagsRace8.Remove("WAIT_FOR_RACE_READY_INPUT");
                    }
                    choixFlagsRace8.Add("WAIT_FOR_RACE_READY_INPUT");
                }

                //DisableDriveLine
                if (Form2.mainWindow.CheckBox_DisableDriveLineRace1.Checked)
                {
                    if (choixFlagsRace8.Contains("DISABLE_DRIVING_LINE"))
                    {
                        choixFlagsRace8.Remove("DISABLE_DRIVING_LINE");
                    }
                }
                else
                {
                    if (choixFlagsRace8.Contains("DISABLE_DRIVING_LINE"))
                    {
                        choixFlagsRace8.Remove("DISABLE_DRIVING_LINE");
                    }
                    choixFlagsRace8.Add("DISABLE_DRIVING_LINE");
                }

                //CustomSetup
                if (Form2.mainWindow.CheckBox_CustomSetupRace1.Checked)
                {
                    if (choixFlagsRace8.Contains("ALLOW_CUSTOM_VEHICLE_SETUP"))
                    {
                        choixFlagsRace8.Remove("ALLOW_CUSTOM_VEHICLE_SETUP");
                    }
                }
                else
                {
                    if (choixFlagsRace8.Contains("ALLOW_CUSTOM_VEHICLE_SETUP"))
                    {
                        choixFlagsRace8.Remove("ALLOW_CUSTOM_VEHICLE_SETUP");
                    }
                    choixFlagsRace8.Add("ALLOW_CUSTOM_VEHICLE_SETUP");
                }

                //Rank
                if (Form2.mainWindow.CheckBox_RankRace1.Checked == false)
                {
                    if (choixFlagsRace8.Contains("ONLINE_REPUTATION_ENABLED"))
                    {
                        choixFlagsRace8.Remove("ONLINE_REPUTATION_ENABLED");
                    }
                    choixFlagsRace8.Add("ONLINE_REPUTATION_ENABLED");
                }
            }
            else
            {


                //CoolDownLap
                if (Form2.mainWindow.CheckBox_CoolDownLapRace8.Checked)
                {
                    if (choixFlagsRace8.Contains("COOLDOWNLAP"))
                    {
                        choixFlagsRace8.Remove("COOLDOWNLAP");
                    }
                }
                else
                {
                    if (choixFlagsRace8.Contains("COOLDOWNLAP"))
                    {
                        choixFlagsRace8.Remove("COOLDOWNLAP");
                    }
                    choixFlagsRace8.Add("COOLDOWNLAP");

                }

                //AbsAllowed
                if (Form2.mainWindow.CheckBox_AbsAllowedRace8.Checked)
                {
                    if (choixFlagsRace8.Contains("ABS_ALLOWED"))
                    {
                        choixFlagsRace8.Remove("ABS_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace8.Contains("ABS_ALLOWED"))
                    {
                        choixFlagsRace8.Remove("ABS_ALLOWED");
                    }
                    choixFlagsRace8.Add("ABS_ALLOWED");
                }

                //ScAllowed
                if (Form2.mainWindow.CheckBox_ScAllowedRace8.Checked)
                {
                    if (choixFlagsRace8.Contains("SC_ALLOWED"))
                    {
                        choixFlagsRace8.Remove("SC_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace8.Contains("SC_ALLOWED"))
                    {
                        choixFlagsRace8.Remove("SC_ALLOWED");
                    }
                    choixFlagsRace8.Add("SC_ALLOWED");
                }

                //TcsAllowed
                if (Form2.mainWindow.CheckBox_TcsAllowedRace8.Checked)
                {
                    if (choixFlagsRace8.Contains("TCS_ALLOWED"))
                    {
                        choixFlagsRace8.Remove("TCS_ALLOWED");
                    }
                }
                else
                {
                    if (choixFlagsRace8.Contains("TCS_ALLOWED"))
                    {
                        choixFlagsRace8.Remove("TCS_ALLOWED");
                    }
                    choixFlagsRace8.Add("TCS_ALLOWED");
                }

                //FillSessionWithAi
                if (Form2.mainWindow.CheckBox_FillSessionWithAiRace8.Checked)
                {
                    if (choixFlagsRace8.Contains("FILL_SESSION_WITH_AI"))
                    {
                        choixFlagsRace8.Remove("FILL_SESSION_WITH_AI");
                    }
                }
                else
                {
                    if (choixFlagsRace8.Contains("FILL_SESSION_WITH_AI"))
                    {
                        choixFlagsRace8.Remove("FILL_SESSION_WITH_AI");
                    }
                    choixFlagsRace8.Add("FILL_SESSION_WITH_AI");
                }


                //MechanicalFailures
                if (Form2.mainWindow.CheckBox_MechanicalFailuresRace8.Checked)
                {
                    if (choixFlagsRace8.Contains("MECHANICAL_FAILURES"))
                    {
                        choixFlagsRace8.Remove("MECHANICAL_FAILURES");
                    }
                }
                else
                {
                    if (choixFlagsRace8.Contains("MECHANICAL_FAILURES"))
                    {
                        choixFlagsRace8.Remove("MECHANICAL_FAILURES");
                    }
                    choixFlagsRace8.Add("MECHANICAL_FAILURES");
                }

                //AutoStartEngine
                if (Form2.mainWindow.CheckBox_AutoStartEngineRace8.Checked)
                {
                    if (choixFlagsRace8.Contains("AUTO_START_ENGINE"))
                    {
                        choixFlagsRace8.Remove("AUTO_START_ENGINE");
                    }
                }
                else
                {
                    if (choixFlagsRace8.Contains("AUTO_START_ENGINE"))
                    {
                        choixFlagsRace8.Remove("AUTO_START_ENGINE");
                    }
                    choixFlagsRace8.Add("AUTO_START_ENGINE");
                }


                //WaitForRaceReady
                if (Form2.mainWindow.CheckBox_WaitForRaceReadyRace8.Checked)
                {
                    if (choixFlagsRace8.Contains("WAIT_FOR_RACE_READY_INPUT"))
                    {
                        choixFlagsRace8.Remove("WAIT_FOR_RACE_READY_INPUT");
                    }
                }
                else
                {
                    if (choixFlagsRace8.Contains("WAIT_FOR_RACE_READY_INPUT"))
                    {
                        choixFlagsRace8.Remove("WAIT_FOR_RACE_READY_INPUT");
                    }
                    choixFlagsRace8.Add("WAIT_FOR_RACE_READY_INPUT");
                }

                //DisableDriveLine
                if (Form2.mainWindow.CheckBox_DisableDriveLineRace8.Checked)
                {
                    if (choixFlagsRace8.Contains("DISABLE_DRIVING_LINE"))
                    {
                        choixFlagsRace8.Remove("DISABLE_DRIVING_LINE");
                    }
                }
                else
                {
                    if (choixFlagsRace8.Contains("DISABLE_DRIVING_LINE"))
                    {
                        choixFlagsRace8.Remove("DISABLE_DRIVING_LINE");
                    }
                    choixFlagsRace8.Add("DISABLE_DRIVING_LINE");
                }

                //CustomSetup
                if (Form2.mainWindow.CheckBox_CustomSetupRace8.Checked)
                {
                    if (choixFlagsRace8.Contains("ALLOW_CUSTOM_VEHICLE_SETUP"))
                    {
                        choixFlagsRace8.Remove("ALLOW_CUSTOM_VEHICLE_SETUP");
                    }
                }
                else
                {
                    if (choixFlagsRace8.Contains("ALLOW_CUSTOM_VEHICLE_SETUP"))
                    {
                        choixFlagsRace8.Remove("ALLOW_CUSTOM_VEHICLE_SETUP");
                    }
                    choixFlagsRace8.Add("ALLOW_CUSTOM_VEHICLE_SETUP");
                }

                //Rank
                if (Form2.mainWindow.CheckBox_RankRace8.Checked == false)
                {
                    if (choixFlagsRace8.Contains("ONLINE_REPUTATION_ENABLED"))
                    {
                        choixFlagsRace8.Remove("ONLINE_REPUTATION_ENABLED");
                    }
                    choixFlagsRace8.Add("ONLINE_REPUTATION_ENABLED");
                }
            }
            // Timed Races or Laps

            if (Form2.mainWindow.RadioButton_LapsRace8.Checked)
            {
                if (choixFlagsRace8.Contains("TIMED_RACE"))
                {
                    choixFlagsRace8.Remove("TIMED_RACE");
                }
                choixFlagsRace8.Add("TIMED_RACE");
            }
        }
    }
}
