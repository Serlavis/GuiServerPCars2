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


        }
    }
}
