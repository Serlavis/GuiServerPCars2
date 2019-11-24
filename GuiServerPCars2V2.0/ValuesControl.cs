using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;

namespace GuiServerPCars2V2._0
{
    class ValuesControl
    {
        readonly TrackList trackList = new TrackList();
        readonly RulesList rulesList = new RulesList();
        readonly NumberOfRotate numberOfRotate = new NumberOfRotate();

        

        // Fill All ComboBox

        public void FillAllCbBox()
        {
            trackList.FillCbBoxRace1();
            trackList.FillCbBoxRace2();
            trackList.FillCbBoxRace3();
            trackList.FillCbBoxRace4();
            trackList.FillCbBoxRace5();
            trackList.FillCbBoxRace6();
            trackList.FillCbBoxRace7();
            trackList.FillCbBoxRace8();

            rulesList.FillCbBoxDamage1();
            rulesList.FillCbBoxDamage2();
            rulesList.FillCbBoxDamage3();
            rulesList.FillCbBoxDamage4();
            rulesList.FillCbBoxDamage5();
            rulesList.FillCbBoxDamage6();
            rulesList.FillCbBoxDamage7();
            rulesList.FillCbBoxDamage8();

            rulesList.FillCbBoxTireWear1();
            rulesList.FillCbBoxTireWear2();
            rulesList.FillCbBoxTireWear3();
            rulesList.FillCbBoxTireWear4();
            rulesList.FillCbBoxTireWear5();
            rulesList.FillCbBoxTireWear6();
            rulesList.FillCbBoxTireWear7();
            rulesList.FillCbBoxTireWear8();

            rulesList.FillCbBoxFuelUsage1();
            rulesList.FillCbBoxFuelUsage2();
            rulesList.FillCbBoxFuelUsage3();
            rulesList.FillCbBoxFuelUsage4();
            rulesList.FillCbBoxFuelUsage5();
            rulesList.FillCbBoxFuelUsage6();
            rulesList.FillCbBoxFuelUsage7();
            rulesList.FillCbBoxFuelUsage8();

            rulesList.FillCbBoxAllowedViews1();
            rulesList.FillCbBoxAllowedViews2();
            rulesList.FillCbBoxAllowedViews3();
            rulesList.FillCbBoxAllowedViews4();
            rulesList.FillCbBoxAllowedViews5();
            rulesList.FillCbBoxAllowedViews6();
            rulesList.FillCbBoxAllowedViews7();
            rulesList.FillCbBoxAllowedViews8();

            rulesList.FillCbBoxPracticeWeatherSlot1Race1();
            rulesList.FillCbBoxPracticeWeatherSlot1Race2();
            rulesList.FillCbBoxPracticeWeatherSlot1Race3();
            rulesList.FillCbBoxPracticeWeatherSlot1Race4();
            rulesList.FillCbBoxPracticeWeatherSlot1Race5();
            rulesList.FillCbBoxPracticeWeatherSlot1Race6();
            rulesList.FillCbBoxPracticeWeatherSlot1Race7();
            rulesList.FillCbBoxPracticeWeatherSlot1Race8();

            rulesList.FillCbBoxPracticeWeatherSlot2Race1();
            rulesList.FillCbBoxPracticeWeatherSlot2Race2();
            rulesList.FillCbBoxPracticeWeatherSlot2Race3();
            rulesList.FillCbBoxPracticeWeatherSlot2Race4();
            rulesList.FillCbBoxPracticeWeatherSlot2Race5();
            rulesList.FillCbBoxPracticeWeatherSlot2Race6();
            rulesList.FillCbBoxPracticeWeatherSlot2Race7();
            rulesList.FillCbBoxPracticeWeatherSlot2Race8();

            rulesList.FillCbBoxPracticeWeatherSlot3Race1();
            rulesList.FillCbBoxPracticeWeatherSlot3Race2();
            rulesList.FillCbBoxPracticeWeatherSlot3Race3();
            rulesList.FillCbBoxPracticeWeatherSlot3Race4();
            rulesList.FillCbBoxPracticeWeatherSlot3Race5();
            rulesList.FillCbBoxPracticeWeatherSlot3Race6();
            rulesList.FillCbBoxPracticeWeatherSlot3Race7();
            rulesList.FillCbBoxPracticeWeatherSlot3Race8();

            rulesList.FillCbBoxPracticeWeatherSlot4Race1();
            rulesList.FillCbBoxPracticeWeatherSlot4Race2();
            rulesList.FillCbBoxPracticeWeatherSlot4Race3();
            rulesList.FillCbBoxPracticeWeatherSlot4Race4();
            rulesList.FillCbBoxPracticeWeatherSlot4Race5();
            rulesList.FillCbBoxPracticeWeatherSlot4Race6();
            rulesList.FillCbBoxPracticeWeatherSlot4Race7();
            rulesList.FillCbBoxPracticeWeatherSlot4Race8();

            rulesList.FillCbBoxQualifyWeatherSlot1Race1();
            rulesList.FillCbBoxQualifyWeatherSlot1Race2();
            rulesList.FillCbBoxQualifyWeatherSlot1Race3();
            rulesList.FillCbBoxQualifyWeatherSlot1Race4();
            rulesList.FillCbBoxQualifyWeatherSlot1Race5();
            rulesList.FillCbBoxQualifyWeatherSlot1Race6();
            rulesList.FillCbBoxQualifyWeatherSlot1Race7();
            rulesList.FillCbBoxQualifyWeatherSlot1Race8();

            rulesList.FillCbBoxQualifyWeatherSlot2Race1();
            rulesList.FillCbBoxQualifyWeatherSlot2Race2();
            rulesList.FillCbBoxQualifyWeatherSlot2Race3();
            rulesList.FillCbBoxQualifyWeatherSlot2Race4();
            rulesList.FillCbBoxQualifyWeatherSlot2Race5();
            rulesList.FillCbBoxQualifyWeatherSlot2Race6();
            rulesList.FillCbBoxQualifyWeatherSlot2Race7();
            rulesList.FillCbBoxQualifyWeatherSlot2Race8();

            rulesList.FillCbBoxQualifyWeatherSlot3Race1();
            rulesList.FillCbBoxQualifyWeatherSlot3Race2();
            rulesList.FillCbBoxQualifyWeatherSlot3Race3();
            rulesList.FillCbBoxQualifyWeatherSlot3Race4();
            rulesList.FillCbBoxQualifyWeatherSlot3Race5();
            rulesList.FillCbBoxQualifyWeatherSlot3Race6();
            rulesList.FillCbBoxQualifyWeatherSlot3Race7();
            rulesList.FillCbBoxQualifyWeatherSlot3Race8();

            rulesList.FillCbBoxQualifyWeatherSlot4Race1();
            rulesList.FillCbBoxQualifyWeatherSlot4Race2();
            rulesList.FillCbBoxQualifyWeatherSlot4Race3();
            rulesList.FillCbBoxQualifyWeatherSlot4Race4();
            rulesList.FillCbBoxQualifyWeatherSlot4Race5();
            rulesList.FillCbBoxQualifyWeatherSlot4Race6();
            rulesList.FillCbBoxQualifyWeatherSlot4Race7();
            rulesList.FillCbBoxQualifyWeatherSlot4Race8();

            rulesList.FillCbBoxRaceWeatherSlot1Race1();
            rulesList.FillCbBoxRaceWeatherSlot1Race2();
            rulesList.FillCbBoxRaceWeatherSlot1Race3();
            rulesList.FillCbBoxRaceWeatherSlot1Race4();
            rulesList.FillCbBoxRaceWeatherSlot1Race5();
            rulesList.FillCbBoxRaceWeatherSlot1Race6();
            rulesList.FillCbBoxRaceWeatherSlot1Race7();
            rulesList.FillCbBoxRaceWeatherSlot1Race8();

            rulesList.FillCbBoxRaceWeatherSlot2Race1();
            rulesList.FillCbBoxRaceWeatherSlot2Race2();
            rulesList.FillCbBoxRaceWeatherSlot2Race3();
            rulesList.FillCbBoxRaceWeatherSlot2Race4();
            rulesList.FillCbBoxRaceWeatherSlot2Race5();
            rulesList.FillCbBoxRaceWeatherSlot2Race6();
            rulesList.FillCbBoxRaceWeatherSlot2Race7();
            rulesList.FillCbBoxRaceWeatherSlot2Race8();

            rulesList.FillCbBoxRaceWeatherSlot3Race1();
            rulesList.FillCbBoxRaceWeatherSlot3Race2();
            rulesList.FillCbBoxRaceWeatherSlot3Race3();
            rulesList.FillCbBoxRaceWeatherSlot3Race4();
            rulesList.FillCbBoxRaceWeatherSlot3Race5();
            rulesList.FillCbBoxRaceWeatherSlot3Race6();
            rulesList.FillCbBoxRaceWeatherSlot3Race7();
            rulesList.FillCbBoxRaceWeatherSlot3Race8();

            rulesList.FillCbBoxRaceWeatherSlot4Race1();
            rulesList.FillCbBoxRaceWeatherSlot4Race2();
            rulesList.FillCbBoxRaceWeatherSlot4Race3();
            rulesList.FillCbBoxRaceWeatherSlot4Race4();
            rulesList.FillCbBoxRaceWeatherSlot4Race5();
            rulesList.FillCbBoxRaceWeatherSlot4Race6();
            rulesList.FillCbBoxRaceWeatherSlot4Race7();
            rulesList.FillCbBoxRaceWeatherSlot4Race8();

        }


        // Checking the ip empty field allowed
        public void Ip_Control()
        {
            if (IPAddress.TryParse(Form2.ip, out IPAddress ipTested) || Form2.ip == "")
            {
                if (Form2.ip != "")
                {
                    Form2.ip = ipTested.ToString();
                }
            }
            else
            {
                MessageBox.Show("IP Invalide", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form2.ip = "";

            }
            //dataBackup.Data_Backup();
        }
        // Checking the ip blank field prohibited
        public void Ip_Control2()
        {
            if (IPAddress.TryParse(Form2.ip, out IPAddress ipTested))
            {
                Form2.ip = ipTested.ToString();
            }
            else
            {
                MessageBox.Show("IP Invalide", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form2.ip = "127.0.0.1";
            }
        }


        //Verifying that the values ​​are numeric
        public void Numeric_Control()
        {
            try
            {
                int integer = int.Parse(Form2.value);

            }
            catch (FormatException) // format invalide
            {
                MessageBox.Show("Insérer une Valeur numérique", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form2.value = Form2.valueTemp;
            }
        }

        public void Empty_Control()
        {
            if (Form2.value == "")
            {
                MessageBox.Show("champ vide", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form2.value = Form2.valueTemp;
            }
        }

        public void Time_Control_Multiple5()
        {
            try
            {
                int integer = int.Parse(Form2.value);
                if (integer > 1440)
                {
                    MessageBox.Show("24H Max", "Erreur ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Form2.value = Form2.valueTemp;
                }
                else if ((integer % 5) != 0)
                {
                    MessageBox.Show("multiple de 5 uniquement", "Erreur ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Form2.value = Form2.valueTemp;
                }
            }
            catch (FormatException) // format invalide
            {
                MessageBox.Show("Insérer une Valeur numérique", "Erreur ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form2.value = Form2.valueTemp;
            }


        }
        // End of vérification

        //Section Rank
        public void RankControl()
        {
            try
            {
                int entier = int.Parse(Form2.value);
                if (entier > 5000 || entier < 100)
                {
                    MessageBox.Show("Insérer une Valeur entre 100 et 5000", "Erreur ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Form2.value = "100";
                }


            }
            catch
            {
                MessageBox.Show("Insérer une Valeur entre 100 et 5000", "Erreur ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form2.value = "100";
            }
        }

        // end  Section Rank 

        //Section for Fuel

        public void FuelUsageValuesRace1()
        {
            int i;
            i = Form2.mainWindow.CbBox_FuelUsageRace1.SelectedIndex;
            Form2.mainWindow.tire1 = rulesList.fuelUsage1[i].Name;
        }

        public void FuelUsageValuesRace2()
        {
            int i;
            i = Form2.mainWindow.CbBox_FuelUsageRace2.SelectedIndex;
            Form2.mainWindow.tire2 = rulesList.fuelUsage2[i].Name;
        }
        public void FuelUsageValuesRace3()
        {
            int i;
            i = Form2.mainWindow.CbBox_FuelUsageRace3.SelectedIndex;
            Form2.mainWindow.tire3 = rulesList.fuelUsage3[i].Name;
        }
        public void FuelUsageValuesRace4()
        {
            int i;
            i = Form2.mainWindow.CbBox_FuelUsageRace4.SelectedIndex;
            Form2.mainWindow.tire4 = rulesList.fuelUsage4[i].Name;
        }
        public void FuelUsageValuesRace5()
        {
            int i;
            i = Form2.mainWindow.CbBox_FuelUsageRace5.SelectedIndex;
            Form2.mainWindow.tire5 = rulesList.fuelUsage5[i].Name;
        }
        public void FuelUsageValuesRace6()
        {
            int i;
            i = Form2.mainWindow.CbBox_FuelUsageRace6.SelectedIndex;
            Form2.mainWindow.tire6 = rulesList.fuelUsage6[i].Name;
        }
        public void FuelUsageValuesRace7()
        {
            int i;
            i = Form2.mainWindow.CbBox_FuelUsageRace7.SelectedIndex;
            Form2.mainWindow.tire7 = rulesList.fuelUsage7[i].Name;
        }
        public void FuelUsageValuesRace8()
        {
            int i;
            i = Form2.mainWindow.CbBox_FuelUsageRace8.SelectedIndex;
            Form2.mainWindow.tire8 = rulesList.fuelUsage8[i].Name;
        }

        //Section for Tires
        public void TireWearValuesRace1()
        {
            int i;
            i = Form2.mainWindow.CbBox_TireWearRace1.SelectedIndex;
            Form2.mainWindow.tire1 = rulesList.tireWear1[i].Name;
        }

        public void TireWearValuesRace2()
        {
            int i;
            i = Form2.mainWindow.CbBox_TireWearRace2.SelectedIndex;
            Form2.mainWindow.tire2 = rulesList.tireWear2[i].Name;
        }
        public void TireWearValuesRace3()
        {
            int i;
            i = Form2.mainWindow.CbBox_TireWearRace3.SelectedIndex;
            Form2.mainWindow.tire3 = rulesList.tireWear3[i].Name;
        }
        public void TireWearValuesRace4()
        {
            int i;
            i = Form2.mainWindow.CbBox_TireWearRace4.SelectedIndex;
            Form2.mainWindow.tire4 = rulesList.tireWear4[i].Name;
        }
        public void TireWearValuesRace5()
        {
            int i;
            i = Form2.mainWindow.CbBox_TireWearRace5.SelectedIndex;
            Form2.mainWindow.tire5 = rulesList.tireWear5[i].Name;
        }
        public void TireWearValuesRace6()
        {
            int i;
            i = Form2.mainWindow.CbBox_TireWearRace6.SelectedIndex;
            Form2.mainWindow.tire6 = rulesList.tireWear6[i].Name;
        }
        public void TireWearValuesRace7()
        {
            int i;
            i = Form2.mainWindow.CbBox_TireWearRace7.SelectedIndex;
            Form2.mainWindow.tire7 = rulesList.tireWear7[i].Name;
        }
        public void TireWearValuesRace8()
        {
            int i;
            i = Form2.mainWindow.CbBox_TireWearRace8.SelectedIndex;
            Form2.mainWindow.tire8 = rulesList.tireWear8[i].Name;
        }
        // End section for Tires


        //section for damages

        public void DamagesValuesRace1()
        {
            int i;
            i = Form2.mainWindow.CbBox_DamageTypeRace1.SelectedIndex;
            Form2.mainWindow.damage1 = rulesList.damages1[i].Name;
        }

        public void DamagesValuesRace2()
        {
            int i;
            i = Form2.mainWindow.CbBox_DamageTypeRace2.SelectedIndex;
            Form2.mainWindow.damage2 = rulesList.damages2[i].Name;
        }

        public void DamagesValuesRace3()
        {
            int i;
            i = Form2.mainWindow.CbBox_DamageTypeRace3.SelectedIndex;
            Form2.mainWindow.damage3 = rulesList.damages3[i].Name;
        }

        public void DamagesValuesRace4()
        {
            int i;
            i = Form2.mainWindow.CbBox_DamageTypeRace4.SelectedIndex;
            Form2.mainWindow.damage4 = rulesList.damages4[i].Name;
        }

        public void DamagesValuesRace5()
        {
            int i;
            i = Form2.mainWindow.CbBox_DamageTypeRace5.SelectedIndex;
            Form2.mainWindow.damage5 = rulesList.damages5[i].Name;
        }

        public void DamagesValuesRace6()
        {
            int i;
            i = Form2.mainWindow.CbBox_DamageTypeRace6.SelectedIndex;
            Form2.mainWindow.damage6 = rulesList.damages6[i].Name;
        }

        public void DamagesValuesRace7()
        {
            int i;
            i = Form2.mainWindow.CbBox_DamageTypeRace7.SelectedIndex;
            Form2.mainWindow.damage7 = rulesList.damages7[i].Name;
        }

        public void DamagesValuesRace8()
        {
            int i;
            i = Form2.mainWindow.CbBox_DamageTypeRace8.SelectedIndex;
            Form2.mainWindow.damage1 = rulesList.damages8[i].Name;
        }

        // End section for damages
        
        // Section for Tracks
        public void TracksValuesRace1()
        {
            int i;
            i = Form2.mainWindow.CbBox_Race1Tracks.SelectedIndex;
            Form2.mainWindow.TxtBx_Race1TracksID.Text = trackList.tracks1[i].Id;
            Form2.mainWindow.TxtBx_Race1MaxCars.Text = trackList.tracks1[i].Grid;
            numberOfRotate.Define_GridSize();

        }

        public void TracksValuesRace2()
        {
            int i;
            i = Form2.mainWindow.CbBox_Race2Tracks.SelectedIndex;
            Form2.mainWindow.TxtBx_Race2TracksID.Text = trackList.tracks2[i].Id;
            Form2.mainWindow.TxtBx_Race2MaxCars.Text = trackList.tracks2[i].Grid;
            numberOfRotate.Define_GridSize();
        }

        public void TracksValuesRace3()
        {
            int i;
            i = Form2.mainWindow.CbBox_Race3Tracks.SelectedIndex;
            Form2.mainWindow.TxtBx_Race3TracksID.Text = trackList.tracks3[i].Id;
            Form2.mainWindow.TxtBx_Race3MaxCars.Text = trackList.tracks3[i].Grid;
            numberOfRotate.Define_GridSize();
        }

        public void TracksValuesRace4()
        {
            int i;
            i = Form2.mainWindow.CbBox_Race4Tracks.SelectedIndex;
            Form2.mainWindow.TxtBx_Race4TracksID.Text = trackList.tracks4[i].Id;
            Form2.mainWindow.TxtBx_Race4MaxCars.Text = trackList.tracks4[i].Grid;
            numberOfRotate.Define_GridSize();
        }

        public void TracksValuesRace5()
        {
            int i;
            i = Form2.mainWindow.CbBox_Race5Tracks.SelectedIndex;
            Form2.mainWindow.TxtBx_Race5TracksID.Text = trackList.tracks5[i].Id;
            Form2.mainWindow.TxtBx_Race5MaxCars.Text = trackList.tracks5[i].Grid;
            numberOfRotate.Define_GridSize();
        }

        public void TracksValuesRace6()
        {
            int i;
            i = Form2.mainWindow.CbBox_Race6Tracks.SelectedIndex;
            Form2.mainWindow.TxtBx_Race6TracksID.Text = trackList.tracks6[i].Id;
            Form2.mainWindow.TxtBx_Race6MaxCars.Text = trackList.tracks6[i].Grid;
            numberOfRotate.Define_GridSize();
        }

        public void TracksValuesRace7()
        {
            int i;
            i = Form2.mainWindow.CbBox_Race7Tracks.SelectedIndex;
            Form2.mainWindow.TxtBx_Race7TracksID.Text = trackList.tracks7[i].Id;
            Form2.mainWindow.TxtBx_Race7MaxCars.Text = trackList.tracks7[i].Grid;
            numberOfRotate.Define_GridSize();
        }

        public void TracksValuesRace8()
        {
            int i;
            i = Form2.mainWindow.CbBox_Race8Tracks.SelectedIndex;
            Form2.mainWindow.TxtBx_Race8TracksID.Text = trackList.tracks8[i].Id;
            Form2.mainWindow.TxtBx_Race8MaxCars.Text = trackList.tracks8[i].Grid;
            numberOfRotate.Define_GridSize();
        }
        //End section for Tracks

        // Section for views

        public void ViewsValuesRace1()
        {
            int i;
            i = Form2.mainWindow.CbBox_AllowedViewsRace1.SelectedIndex;
            Form2.mainWindow.views1 = rulesList.AllowedViews1[i].Name;
        }
        public void ViewsValuesRace2()
        {
            int i;
            i = Form2.mainWindow.CbBox_AllowedViewsRace2.SelectedIndex;
            Form2.mainWindow.views2 = rulesList.AllowedViews2[i].Name;
        }
        public void ViewsValuesRace3()
        {
            int i;
            i = Form2.mainWindow.CbBox_AllowedViewsRace3.SelectedIndex;
            Form2.mainWindow.views3 = rulesList.AllowedViews3[i].Name;
        }
        public void ViewsValuesRace4()
        {
            int i;
            i = Form2.mainWindow.CbBox_AllowedViewsRace4.SelectedIndex;
            Form2.mainWindow.views4 = rulesList.AllowedViews4[i].Name;
        }
        public void ViewsValuesRace5()
        {
            int i;
            i = Form2.mainWindow.CbBox_AllowedViewsRace5.SelectedIndex;
            Form2.mainWindow.views5 = rulesList.AllowedViews5[i].Name;
        }
        public void ViewsValuesRace6()
        {
            int i;
            i = Form2.mainWindow.CbBox_AllowedViewsRace6.SelectedIndex;
            Form2.mainWindow.views6 = rulesList.AllowedViews6[i].Name;
        }
        public void ViewsValuesRace7()
        {
            int i;
            i = Form2.mainWindow.CbBox_AllowedViewsRace7.SelectedIndex;
            Form2.mainWindow.views7 = rulesList.AllowedViews7[i].Name;
        }
        public void ViewsValuesRace8()
        {
            int i;
            i = Form2.mainWindow.CbBox_AllowedViewsRace8.SelectedIndex;
            Form2.mainWindow.views8 = rulesList.AllowedViews8[i].Name;
        }

        //End of section views

        // Section weather

        public void PracticeWeatherSlot1Race1()
        {
            int i;
            i = Form2.mainWindow.CbBox_PracticeWeatherSlot1Race1.SelectedIndex;
            Form2.mainWindow.practiceWeatherSlot1Race1 = rulesList.PracticeWeatherSlot1Race1[i].Name;
        }

        public void PracticeWeatherSlot2Race1()
        {
            int i;
            i = Form2.mainWindow.CbBox_PracticeWeatherSlot2Race1.SelectedIndex;
            Form2.mainWindow.practiceWeatherSlot2Race1 = rulesList.PracticeWeatherSlot2Race1[i].Name;
        }

        public void PracticeWeatherSlot3Race1()
        {
            int i;
            i = Form2.mainWindow.CbBox_PracticeWeatherSlot3Race1.SelectedIndex;
            Form2.mainWindow.practiceWeatherSlot3Race1 = rulesList.PracticeWeatherSlot3Race1[i].Name;
        }
        public void PracticeWeatherSlot4Race1()
        {
            int i;
            i = Form2.mainWindow.CbBox_PracticeWeatherSlot4Race1.SelectedIndex;
            Form2.mainWindow.practiceWeatherSlot4Race1 = rulesList.PracticeWeatherSlot4Race1[i].Name;
        }

        public void PracticeWeatherSlot1Race2()
        {
            int i;
            i = Form2.mainWindow.CbBox_PracticeWeatherSlot1Race2.SelectedIndex;
            Form2.mainWindow.practiceWeatherSlot1Race2 = rulesList.PracticeWeatherSlot1Race2[i].Name;
        }

        public void PracticeWeatherSlot2Race2()
        {
            int i;
            i = Form2.mainWindow.CbBox_PracticeWeatherSlot2Race2.SelectedIndex;
            Form2.mainWindow.practiceWeatherSlot2Race2 = rulesList.PracticeWeatherSlot2Race2[i].Name;
        }

        public void PracticeWeatherSlot3Race2()
        {
            int i;
            i = Form2.mainWindow.CbBox_PracticeWeatherSlot3Race2.SelectedIndex;
            Form2.mainWindow.practiceWeatherSlot3Race2 = rulesList.PracticeWeatherSlot3Race2[i].Name;
        }
        public void PracticeWeatherSlot4Race2()
        {
            int i;
            i = Form2.mainWindow.CbBox_PracticeWeatherSlot4Race2.SelectedIndex;
            Form2.mainWindow.practiceWeatherSlot4Race2 = rulesList.PracticeWeatherSlot4Race2[i].Name;
        }
        public void PracticeWeatherSlot1Race3()
        {
            int i;
            i = Form2.mainWindow.CbBox_PracticeWeatherSlot1Race3.SelectedIndex;
            Form2.mainWindow.practiceWeatherSlot1Race3 = rulesList.PracticeWeatherSlot1Race3[i].Name;
        }

        public void PracticeWeatherSlot2Race3()
        {
            int i;
            i = Form2.mainWindow.CbBox_PracticeWeatherSlot2Race3.SelectedIndex;
            Form2.mainWindow.practiceWeatherSlot2Race3 = rulesList.PracticeWeatherSlot2Race3[i].Name;
        }

        public void PracticeWeatherSlot3Race3()
        {
            int i;
            i = Form2.mainWindow.CbBox_PracticeWeatherSlot3Race3.SelectedIndex;
            Form2.mainWindow.practiceWeatherSlot3Race3 = rulesList.PracticeWeatherSlot3Race3[i].Name;
        }
        public void PracticeWeatherSlot4Race3()
        {
            int i;
            i = Form2.mainWindow.CbBox_PracticeWeatherSlot4Race3.SelectedIndex;
            Form2.mainWindow.practiceWeatherSlot4Race3 = rulesList.PracticeWeatherSlot4Race3[i].Name;
        }
        public void PracticeWeatherSlot1Race4()
        {
            int i;
            i = Form2.mainWindow.CbBox_PracticeWeatherSlot1Race4.SelectedIndex;
            Form2.mainWindow.practiceWeatherSlot1Race4 = rulesList.PracticeWeatherSlot1Race4[i].Name;
        }

        public void PracticeWeatherSlot2Race4()
        {
            int i;
            i = Form2.mainWindow.CbBox_PracticeWeatherSlot2Race4.SelectedIndex;
            Form2.mainWindow.practiceWeatherSlot2Race4 = rulesList.PracticeWeatherSlot2Race4[i].Name;
        }

        public void PracticeWeatherSlot3Race4()
        {
            int i;
            i = Form2.mainWindow.CbBox_PracticeWeatherSlot3Race4.SelectedIndex;
            Form2.mainWindow.practiceWeatherSlot3Race4 = rulesList.PracticeWeatherSlot3Race4[i].Name;
        }
        public void PracticeWeatherSlot4Race4()
        {
            int i;
            i = Form2.mainWindow.CbBox_PracticeWeatherSlot4Race4.SelectedIndex;
            Form2.mainWindow.practiceWeatherSlot4Race4 = rulesList.PracticeWeatherSlot4Race4[i].Name;
        }
        public void PracticeWeatherSlot1Race5()
        {
            int i;
            i = Form2.mainWindow.CbBox_PracticeWeatherSlot1Race5.SelectedIndex;
            Form2.mainWindow.practiceWeatherSlot1Race5 = rulesList.PracticeWeatherSlot1Race5[i].Name;
        }

        public void PracticeWeatherSlot2Race5()
        {
            int i;
            i = Form2.mainWindow.CbBox_PracticeWeatherSlot2Race5.SelectedIndex;
            Form2.mainWindow.practiceWeatherSlot2Race5 = rulesList.PracticeWeatherSlot2Race5[i].Name;
        }

        public void PracticeWeatherSlot3Race5()
        {
            int i;
            i = Form2.mainWindow.CbBox_PracticeWeatherSlot3Race5.SelectedIndex;
            Form2.mainWindow.practiceWeatherSlot3Race5 = rulesList.PracticeWeatherSlot3Race5[i].Name;
        }
        public void PracticeWeatherSlot4Race5()
        {
            int i;
            i = Form2.mainWindow.CbBox_PracticeWeatherSlot4Race5.SelectedIndex;
            Form2.mainWindow.practiceWeatherSlot4Race5 = rulesList.PracticeWeatherSlot4Race5[i].Name;
        }
        public void PracticeWeatherSlot1Race6()
        {
            int i;
            i = Form2.mainWindow.CbBox_PracticeWeatherSlot1Race6.SelectedIndex;
            Form2.mainWindow.practiceWeatherSlot1Race6 = rulesList.PracticeWeatherSlot1Race6[i].Name;
        }

        public void PracticeWeatherSlot2Race6()
        {
            int i;
            i = Form2.mainWindow.CbBox_PracticeWeatherSlot2Race6.SelectedIndex;
            Form2.mainWindow.practiceWeatherSlot2Race6 = rulesList.PracticeWeatherSlot2Race6[i].Name;
        }

        public void PracticeWeatherSlot3Race6()
        {
            int i;
            i = Form2.mainWindow.CbBox_PracticeWeatherSlot3Race6.SelectedIndex;
            Form2.mainWindow.practiceWeatherSlot3Race6 = rulesList.PracticeWeatherSlot3Race6[i].Name;
        }
        public void PracticeWeatherSlot4Race6()
        {
            int i;
            i = Form2.mainWindow.CbBox_PracticeWeatherSlot4Race6.SelectedIndex;
            Form2.mainWindow.practiceWeatherSlot4Race6 = rulesList.PracticeWeatherSlot4Race6[i].Name;
        }
        public void PracticeWeatherSlot1Race7()
        {
            int i;
            i = Form2.mainWindow.CbBox_PracticeWeatherSlot1Race7.SelectedIndex;
            Form2.mainWindow.practiceWeatherSlot1Race7 = rulesList.PracticeWeatherSlot1Race7[i].Name;
        }

        public void PracticeWeatherSlot2Race7()
        {
            int i;
            i = Form2.mainWindow.CbBox_PracticeWeatherSlot2Race7.SelectedIndex;
            Form2.mainWindow.practiceWeatherSlot2Race7 = rulesList.PracticeWeatherSlot2Race7[i].Name;
        }

        public void PracticeWeatherSlot3Race7()
        {
            int i;
            i = Form2.mainWindow.CbBox_PracticeWeatherSlot3Race7.SelectedIndex;
            Form2.mainWindow.practiceWeatherSlot3Race7 = rulesList.PracticeWeatherSlot3Race7[i].Name;
        }
        public void PracticeWeatherSlot4Race7()
        {
            int i;
            i = Form2.mainWindow.CbBox_PracticeWeatherSlot4Race7.SelectedIndex;
            Form2.mainWindow.practiceWeatherSlot4Race7 = rulesList.PracticeWeatherSlot4Race7[i].Name;
        }
        public void PracticeWeatherSlot1Race8()
        {
            int i;
            i = Form2.mainWindow.CbBox_PracticeWeatherSlot1Race8.SelectedIndex;
            Form2.mainWindow.practiceWeatherSlot1Race8 = rulesList.PracticeWeatherSlot1Race8[i].Name;
        }

        public void PracticeWeatherSlot2Race8()
        {
            int i;
            i = Form2.mainWindow.CbBox_PracticeWeatherSlot2Race8.SelectedIndex;
            Form2.mainWindow.practiceWeatherSlot2Race8 = rulesList.PracticeWeatherSlot2Race8[i].Name;
        }

        public void PracticeWeatherSlot3Race8()
        {
            int i;
            i = Form2.mainWindow.CbBox_PracticeWeatherSlot3Race8.SelectedIndex;
            Form2.mainWindow.practiceWeatherSlot3Race8 = rulesList.PracticeWeatherSlot3Race8[i].Name;
        }
        public void PracticeWeatherSlot4Race8()
        {
            int i;
            i = Form2.mainWindow.CbBox_PracticeWeatherSlot4Race8.SelectedIndex;
            Form2.mainWindow.practiceWeatherSlot4Race8 = rulesList.PracticeWeatherSlot4Race8[i].Name;
        }

        public void QualifyWeatherSlot1Race1()
        {
            int i;
            i = Form2.mainWindow.CbBox_QualifWeatherSlot1Race1.SelectedIndex;
            Form2.mainWindow.qualifyWeatherSlot1Race1 = rulesList.QualifyWeatherSlot1Race1[i].Name;
        }

        public void QualifyWeatherSlot2Race1()
        {
            int i;
            i = Form2.mainWindow.CbBox_QualifWeatherSlot2Race1.SelectedIndex;
            Form2.mainWindow.qualifyWeatherSlot2Race1 = rulesList.QualifyWeatherSlot2Race1[i].Name;
        }

        public void QualifyWeatherSlot3Race1()
        {
            int i;
            i = Form2.mainWindow.CbBox_QualifWeatherSlot3Race1.SelectedIndex;
            Form2.mainWindow.qualifyWeatherSlot3Race1 = rulesList.QualifyWeatherSlot3Race1[i].Name;
        }
        public void QualifyWeatherSlot4Race1()
        {
            int i;
            i = Form2.mainWindow.CbBox_QualifWeatherSlot4Race1.SelectedIndex;
            Form2.mainWindow.qualifyWeatherSlot4Race1 = rulesList.QualifyWeatherSlot4Race1[i].Name;
        }

        public void QualifyWeatherSlot1Race2()
        {
            int i;
            i = Form2.mainWindow.CbBox_QualifWeatherSlot1Race2.SelectedIndex;
            Form2.mainWindow.qualifyWeatherSlot1Race2 = rulesList.QualifyWeatherSlot1Race2[i].Name;
        }

        public void QualifyWeatherSlot2Race2()
        {
            int i;
            i = Form2.mainWindow.CbBox_QualifWeatherSlot2Race2.SelectedIndex;
            Form2.mainWindow.qualifyWeatherSlot2Race2 = rulesList.QualifyWeatherSlot2Race2[i].Name;
        }

        public void QualifyWeatherSlot3Race2()
        {
            int i;
            i = Form2.mainWindow.CbBox_QualifWeatherSlot3Race2.SelectedIndex;
            Form2.mainWindow.qualifyWeatherSlot3Race2 = rulesList.QualifyWeatherSlot3Race2[i].Name;
        }
        public void QualifyWeatherSlot4Race2()
        {
            int i;
            i = Form2.mainWindow.CbBox_QualifWeatherSlot4Race2.SelectedIndex;
            Form2.mainWindow.qualifyWeatherSlot4Race2 = rulesList.QualifyWeatherSlot4Race2[i].Name;
        }
        public void QualifyWeatherSlot1Race3()
        {
            int i;
            i = Form2.mainWindow.CbBox_QualifWeatherSlot1Race3.SelectedIndex;
            Form2.mainWindow.qualifyWeatherSlot1Race3 = rulesList.QualifyWeatherSlot1Race3[i].Name;
        }

        public void QualifyWeatherSlot2Race3()
        {
            int i;
            i = Form2.mainWindow.CbBox_QualifWeatherSlot2Race3.SelectedIndex;
            Form2.mainWindow.qualifyWeatherSlot2Race3 = rulesList.QualifyWeatherSlot2Race3[i].Name;
        }

        public void QualifyWeatherSlot3Race3()
        {
            int i;
            i = Form2.mainWindow.CbBox_QualifWeatherSlot3Race3.SelectedIndex;
            Form2.mainWindow.qualifyWeatherSlot3Race3 = rulesList.QualifyWeatherSlot3Race3[i].Name;
        }
        public void QualifyWeatherSlot4Race3()
        {
            int i;
            i = Form2.mainWindow.CbBox_QualifWeatherSlot4Race3.SelectedIndex;
            Form2.mainWindow.qualifyWeatherSlot4Race3 = rulesList.QualifyWeatherSlot4Race3[i].Name;
        }
        public void QualifyWeatherSlot1Race4()
        {
            int i;
            i = Form2.mainWindow.CbBox_QualifWeatherSlot1Race4.SelectedIndex;
            Form2.mainWindow.qualifyWeatherSlot1Race4 = rulesList.QualifyWeatherSlot1Race4[i].Name;
        }

        public void QualifyWeatherSlot2Race4()
        {
            int i;
            i = Form2.mainWindow.CbBox_QualifWeatherSlot2Race4.SelectedIndex;
            Form2.mainWindow.qualifyWeatherSlot2Race4 = rulesList.QualifyWeatherSlot2Race4[i].Name;
        }

        public void QualifyWeatherSlot3Race4()
        {
            int i;
            i = Form2.mainWindow.CbBox_QualifWeatherSlot3Race4.SelectedIndex;
            Form2.mainWindow.qualifyWeatherSlot3Race4 = rulesList.QualifyWeatherSlot3Race4[i].Name;
        }
        public void QualifyWeatherSlot4Race4()
        {
            int i;
            i = Form2.mainWindow.CbBox_QualifWeatherSlot4Race4.SelectedIndex;
            Form2.mainWindow.qualifyWeatherSlot4Race4 = rulesList.QualifyWeatherSlot4Race4[i].Name;
        }
        public void QualifyWeatherSlot1Race5()
        {
            int i;
            i = Form2.mainWindow.CbBox_QualifWeatherSlot1Race5.SelectedIndex;
            Form2.mainWindow.qualifyWeatherSlot1Race5 = rulesList.QualifyWeatherSlot1Race5[i].Name;
        }

        public void QualifyWeatherSlot2Race5()
        {
            int i;
            i = Form2.mainWindow.CbBox_QualifWeatherSlot2Race5.SelectedIndex;
            Form2.mainWindow.qualifyWeatherSlot2Race5 = rulesList.QualifyWeatherSlot2Race5[i].Name;
        }

        public void QualifyWeatherSlot3Race5()
        {
            int i;
            i = Form2.mainWindow.CbBox_QualifWeatherSlot3Race5.SelectedIndex;
            Form2.mainWindow.qualifyWeatherSlot3Race5 = rulesList.QualifyWeatherSlot3Race5[i].Name;
        }
        public void QualifyWeatherSlot4Race5()
        {
            int i;
            i = Form2.mainWindow.CbBox_QualifWeatherSlot4Race5.SelectedIndex;
            Form2.mainWindow.qualifyWeatherSlot4Race5 = rulesList.QualifyWeatherSlot4Race5[i].Name;
        }
        public void QualifyWeatherSlot1Race6()
        {
            int i;
            i = Form2.mainWindow.CbBox_QualifWeatherSlot1Race6.SelectedIndex;
            Form2.mainWindow.qualifyWeatherSlot1Race6 = rulesList.QualifyWeatherSlot1Race6[i].Name;
        }

        public void QualifyWeatherSlot2Race6()
        {
            int i;
            i = Form2.mainWindow.CbBox_QualifWeatherSlot2Race6.SelectedIndex;
            Form2.mainWindow.qualifyWeatherSlot2Race6 = rulesList.QualifyWeatherSlot2Race6[i].Name;
        }

        public void QualifyWeatherSlot3Race6()
        {
            int i;
            i = Form2.mainWindow.CbBox_QualifWeatherSlot3Race6.SelectedIndex;
            Form2.mainWindow.qualifyWeatherSlot3Race6 = rulesList.QualifyWeatherSlot3Race6[i].Name;
        }
        public void QualifyWeatherSlot4Race6()
        {
            int i;
            i = Form2.mainWindow.CbBox_QualifWeatherSlot4Race6.SelectedIndex;
            Form2.mainWindow.qualifyWeatherSlot4Race6 = rulesList.QualifyWeatherSlot4Race6[i].Name;
        }
        public void QualifyWeatherSlot1Race7()
        {
            int i;
            i = Form2.mainWindow.CbBox_QualifWeatherSlot1Race7.SelectedIndex;
            Form2.mainWindow.qualifyWeatherSlot1Race7 = rulesList.QualifyWeatherSlot1Race7[i].Name;
        }

        public void QualifyWeatherSlot2Race7()
        {
            int i;
            i = Form2.mainWindow.CbBox_QualifWeatherSlot2Race7.SelectedIndex;
            Form2.mainWindow.qualifyWeatherSlot2Race7 = rulesList.QualifyWeatherSlot2Race7[i].Name;
        }

        public void QualifyWeatherSlot3Race7()
        {
            int i;
            i = Form2.mainWindow.CbBox_QualifWeatherSlot3Race7.SelectedIndex;
            Form2.mainWindow.qualifyWeatherSlot3Race7 = rulesList.QualifyWeatherSlot3Race7[i].Name;
        }
        public void QualifyWeatherSlot4Race7()
        {
            int i;
            i = Form2.mainWindow.CbBox_QualifWeatherSlot4Race7.SelectedIndex;
            Form2.mainWindow.qualifyWeatherSlot4Race7 = rulesList.QualifyWeatherSlot4Race7[i].Name;
        }
        public void QualifyWeatherSlot1Race8()
        {
            int i;
            i = Form2.mainWindow.CbBox_QualifWeatherSlot1Race8.SelectedIndex;
            Form2.mainWindow.qualifyWeatherSlot1Race8 = rulesList.QualifyWeatherSlot1Race8[i].Name;
        }

        public void QualifyWeatherSlot2Race8()
        {
            int i;
            i = Form2.mainWindow.CbBox_QualifWeatherSlot2Race8.SelectedIndex;
            Form2.mainWindow.qualifyWeatherSlot2Race8 = rulesList.QualifyWeatherSlot2Race8[i].Name;
        }

        public void QualifyWeatherSlot3Race8()
        {
            int i;
            i = Form2.mainWindow.CbBox_QualifWeatherSlot3Race8.SelectedIndex;
            Form2.mainWindow.qualifyWeatherSlot3Race8 = rulesList.QualifyWeatherSlot3Race8[i].Name;
        }
        public void QualifyWeatherSlot4Race8()
        {
            int i;
            i = Form2.mainWindow.CbBox_QualifWeatherSlot4Race8.SelectedIndex;
            Form2.mainWindow.qualifyWeatherSlot4Race8 = rulesList.QualifyWeatherSlot4Race8[i].Name;
        }

        public void RaceWeatherSlot1Race1()
        {
            int i;
            i = Form2.mainWindow.CbBox_RaceWeatherSlot1Race1.SelectedIndex;
            Form2.mainWindow.raceWeatherSlot1Race1 = rulesList.RaceWeatherSlot1Race1[i].Name;
        }

        public void RaceWeatherSlot2Race1()
        {
            int i;
            i = Form2.mainWindow.CbBox_RaceWeatherSlot2Race1.SelectedIndex;
            Form2.mainWindow.raceWeatherSlot2Race1 = rulesList.RaceWeatherSlot2Race1[i].Name;
        }

        public void RaceWeatherSlot3Race1()
        {
            int i;
            i = Form2.mainWindow.CbBox_RaceWeatherSlot3Race1.SelectedIndex;
            Form2.mainWindow.raceWeatherSlot3Race1 = rulesList.RaceWeatherSlot3Race1[i].Name;
        }
        public void RaceWeatherSlot4Race1()
        {
            int i;
            i = Form2.mainWindow.CbBox_RaceWeatherSlot4Race1.SelectedIndex;
            Form2.mainWindow.raceWeatherSlot4Race1 = rulesList.RaceWeatherSlot4Race1[i].Name;
        }

        public void RaceWeatherSlot1Race2()
        {
            int i;
            i = Form2.mainWindow.CbBox_RaceWeatherSlot1Race2.SelectedIndex;
            Form2.mainWindow.raceWeatherSlot1Race2 = rulesList.RaceWeatherSlot1Race2[i].Name;
        }

        public void RaceWeatherSlot2Race2()
        {
            int i;
            i = Form2.mainWindow.CbBox_RaceWeatherSlot2Race2.SelectedIndex;
            Form2.mainWindow.raceWeatherSlot2Race2 = rulesList.RaceWeatherSlot2Race2[i].Name;
        }

        public void RaceWeatherSlot3Race2()
        {
            int i;
            i = Form2.mainWindow.CbBox_RaceWeatherSlot3Race2.SelectedIndex;
            Form2.mainWindow.raceWeatherSlot3Race2 = rulesList.RaceWeatherSlot3Race2[i].Name;
        }
        public void RaceWeatherSlot4Race2()
        {
            int i;
            i = Form2.mainWindow.CbBox_RaceWeatherSlot4Race2.SelectedIndex;
            Form2.mainWindow.raceWeatherSlot4Race2 = rulesList.RaceWeatherSlot4Race2[i].Name;
        }
        public void RaceWeatherSlot1Race3()
        {
            int i;
            i = Form2.mainWindow.CbBox_RaceWeatherSlot1Race3.SelectedIndex;
            Form2.mainWindow.raceWeatherSlot1Race3 = rulesList.RaceWeatherSlot1Race3[i].Name;
        }

        public void RaceWeatherSlot2Race3()
        {
            int i;
            i = Form2.mainWindow.CbBox_RaceWeatherSlot2Race3.SelectedIndex;
            Form2.mainWindow.raceWeatherSlot2Race3 = rulesList.RaceWeatherSlot2Race3[i].Name;
        }

        public void RaceWeatherSlot3Race3()
        {
            int i;
            i = Form2.mainWindow.CbBox_RaceWeatherSlot3Race3.SelectedIndex;
            Form2.mainWindow.raceWeatherSlot3Race3 = rulesList.RaceWeatherSlot3Race3[i].Name;
        }
        public void RaceWeatherSlot4Race3()
        {
            int i;
            i = Form2.mainWindow.CbBox_RaceWeatherSlot4Race3.SelectedIndex;
            Form2.mainWindow.raceWeatherSlot4Race3 = rulesList.RaceWeatherSlot4Race3[i].Name;
        }
        public void RaceWeatherSlot1Race4()
        {
            int i;
            i = Form2.mainWindow.CbBox_RaceWeatherSlot1Race4.SelectedIndex;
            Form2.mainWindow.raceWeatherSlot1Race4 = rulesList.RaceWeatherSlot1Race4[i].Name;
        }

        public void RaceWeatherSlot2Race4()
        {
            int i;
            i = Form2.mainWindow.CbBox_RaceWeatherSlot2Race4.SelectedIndex;
            Form2.mainWindow.raceWeatherSlot2Race4 = rulesList.RaceWeatherSlot2Race4[i].Name;
        }

        public void RaceWeatherSlot3Race4()
        {
            int i;
            i = Form2.mainWindow.CbBox_RaceWeatherSlot3Race4.SelectedIndex;
            Form2.mainWindow.raceWeatherSlot3Race4 = rulesList.RaceWeatherSlot3Race4[i].Name;
        }
        public void RaceWeatherSlot4Race4()
        {
            int i;
            i = Form2.mainWindow.CbBox_RaceWeatherSlot4Race4.SelectedIndex;
            Form2.mainWindow.raceWeatherSlot4Race4 = rulesList.RaceWeatherSlot4Race4[i].Name;
        }
        public void RaceWeatherSlot1Race5()
        {
            int i;
            i = Form2.mainWindow.CbBox_RaceWeatherSlot1Race5.SelectedIndex;
            Form2.mainWindow.raceWeatherSlot1Race5 = rulesList.RaceWeatherSlot1Race5[i].Name;
        }

        public void RaceWeatherSlot2Race5()
        {
            int i;
            i = Form2.mainWindow.CbBox_RaceWeatherSlot2Race5.SelectedIndex;
            Form2.mainWindow.raceWeatherSlot2Race5 = rulesList.RaceWeatherSlot2Race5[i].Name;
        }

        public void RaceWeatherSlot3Race5()
        {
            int i;
            i = Form2.mainWindow.CbBox_RaceWeatherSlot3Race5.SelectedIndex;
            Form2.mainWindow.raceWeatherSlot3Race5 = rulesList.RaceWeatherSlot3Race5[i].Name;
        }
        public void RaceWeatherSlot4Race5()
        {
            int i;
            i = Form2.mainWindow.CbBox_RaceWeatherSlot4Race5.SelectedIndex;
            Form2.mainWindow.raceWeatherSlot4Race5 = rulesList.RaceWeatherSlot4Race5[i].Name;
        }
        public void RaceWeatherSlot1Race6()
        {
            int i;
            i = Form2.mainWindow.CbBox_RaceWeatherSlot1Race6.SelectedIndex;
            Form2.mainWindow.raceWeatherSlot1Race6 = rulesList.RaceWeatherSlot1Race6[i].Name;
        }

        public void RaceWeatherSlot2Race6()
        {
            int i;
            i = Form2.mainWindow.CbBox_RaceWeatherSlot2Race6.SelectedIndex;
            Form2.mainWindow.raceWeatherSlot2Race6 = rulesList.RaceWeatherSlot2Race6[i].Name;
        }

        public void RaceWeatherSlot3Race6()
        {
            int i;
            i = Form2.mainWindow.CbBox_RaceWeatherSlot3Race6.SelectedIndex;
            Form2.mainWindow.raceWeatherSlot3Race6 = rulesList.RaceWeatherSlot3Race6[i].Name;
        }
        public void RaceWeatherSlot4Race6()
        {
            int i;
            i = Form2.mainWindow.CbBox_RaceWeatherSlot4Race6.SelectedIndex;
            Form2.mainWindow.raceWeatherSlot4Race6 = rulesList.RaceWeatherSlot4Race6[i].Name;
        }
        public void RaceWeatherSlot1Race7()
        {
            int i;
            i = Form2.mainWindow.CbBox_RaceWeatherSlot1Race7.SelectedIndex;
            Form2.mainWindow.raceWeatherSlot1Race7 = rulesList.RaceWeatherSlot1Race7[i].Name;
        }

        public void RaceWeatherSlot2Race7()
        {
            int i;
            i = Form2.mainWindow.CbBox_RaceWeatherSlot2Race7.SelectedIndex;
            Form2.mainWindow.raceWeatherSlot2Race7 = rulesList.RaceWeatherSlot2Race7[i].Name;
        }

        public void RaceWeatherSlot3Race7()
        {
            int i;
            i = Form2.mainWindow.CbBox_RaceWeatherSlot3Race7.SelectedIndex;
            Form2.mainWindow.raceWeatherSlot3Race7 = rulesList.RaceWeatherSlot3Race7[i].Name;
        }
        public void RaceWeatherSlot4Race7()
        {
            int i;
            i = Form2.mainWindow.CbBox_RaceWeatherSlot4Race7.SelectedIndex;
            Form2.mainWindow.raceWeatherSlot4Race7 = rulesList.RaceWeatherSlot4Race7[i].Name;
        }
        public void RaceWeatherSlot1Race8()
        {
            int i;
            i = Form2.mainWindow.CbBox_RaceWeatherSlot1Race8.SelectedIndex;
            Form2.mainWindow.raceWeatherSlot1Race8 = rulesList.RaceWeatherSlot1Race8[i].Name;
        }

        public void RaceWeatherSlot2Race8()
        {
            int i;
            i = Form2.mainWindow.CbBox_RaceWeatherSlot2Race8.SelectedIndex;
            Form2.mainWindow.raceWeatherSlot2Race8 = rulesList.RaceWeatherSlot2Race8[i].Name;
        }

        public void RaceWeatherSlot3Race8()
        {
            int i;
            i = Form2.mainWindow.CbBox_RaceWeatherSlot3Race8.SelectedIndex;
            Form2.mainWindow.raceWeatherSlot3Race8 = rulesList.RaceWeatherSlot3Race8[i].Name;
        }
        public void RaceWeatherSlot4Race8()
        {
            int i;
            i = Form2.mainWindow.CbBox_RaceWeatherSlot4Race8.SelectedIndex;
            Form2.mainWindow.raceWeatherSlot4Race8 = rulesList.RaceWeatherSlot4Race8[i].Name;
        }


    }
}
