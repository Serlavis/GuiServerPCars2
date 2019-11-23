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
        readonly DamagesList damagesList = new DamagesList();
        readonly NumberOfRotate numberOfRotate = new NumberOfRotate();

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
            damagesList.FillCbBoxDamage1();
            

        }

        public void DamagesValuesRace1()
        {
            int i;
            i = Form2.mainWindow.CbBox_DamageTypeRace1.SelectedIndex;
            Form2.mainWindow.damage1 = damagesList.damages1[i].Name;
        }

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

       
    }
}
