using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;



namespace GuiServerPCars2V2._0
{
    public partial class Form2 : Form
    {
        private int _ticks;

        public static Form2 mainWindow;
        public static string ip;
        public static string value;
        public static string valueTemp;

        public int track2 = 0;
        public int track3 = 0;
        public int track4 = 0;
        public int track5 = 0;
        public int track6 = 0;
        public int track7 = 0;
        public int track8 = 0;

        public bool uniqueCar2;
        public bool uniqueCar3;
        public bool uniqueCar4;
        public bool uniqueCar5;
        public bool uniqueCar6;
        public bool uniqueCar7;
        public bool uniqueCar8;

        public bool classCar2;
        public bool classCar3;
        public bool classCar4;
        public bool classCar5;
        public bool classCar6;
        public bool classCar7;
        public bool classCar8;

        public int ClassSlots2;
        public int ClassSlots3;
        public int ClassSlots4;
        public int ClassSlots5;
        public int ClassSlots6;
        public int ClassSlots7;
        public int ClassSlots8;

        public int Car2;
        public int Car3;
        public int Car4;
        public int Car5;
        public int Car6;
        public int Car7;
        public int Car8;

        public int Class1R2;
        public int Class1R3;
        public int Class1R4;
        public int Class1R5;
        public int Class1R6;
        public int Class1R7;
        public int Class1R8;
        public int Class2R2;
        public int Class2R3;
        public int Class2R4;
        public int Class2R5;
        public int Class2R6;
        public int Class2R7;
        public int Class2R8;
        public int Class3R2;
        public int Class3R3;
        public int Class3R4;
        public int Class3R5;
        public int Class3R6;
        public int Class3R7;
        public int Class3R8;
        public int Class4R2;
        public int Class4R3;
        public int Class4R4;
        public int Class4R5;
        public int Class4R6;
        public int Class4R7;
        public int Class4R8;

        public string damage1;
        public string damage2;
        public string damage3;
        public string damage4;
        public string damage5;
        public string damage6;
        public string damage7;
        public string damage8;

        public string tire1;
        public string tire2;
        public string tire3;
        public string tire4;
        public string tire5;
        public string tire6;
        public string tire7;
        public string tire8;

        public string views1;
        public string views2;
        public string views3;
        public string views4;
        public string views5;
        public string views6;
        public string views7;
        public string views8;

        public string practiceWeatherSlot1Race1;
        public string practiceWeatherSlot2Race1;
        public string practiceWeatherSlot3Race1;
        public string practiceWeatherSlot4Race1;
        public string practiceWeatherSlot1Race2;
        public string practiceWeatherSlot2Race2;
        public string practiceWeatherSlot3Race2;
        public string practiceWeatherSlot4Race2;
        public string practiceWeatherSlot1Race3;
        public string practiceWeatherSlot2Race3;
        public string practiceWeatherSlot3Race3;
        public string practiceWeatherSlot4Race3;
        public string practiceWeatherSlot1Race4;
        public string practiceWeatherSlot2Race4;
        public string practiceWeatherSlot3Race4;
        public string practiceWeatherSlot4Race4;
        public string practiceWeatherSlot1Race5;
        public string practiceWeatherSlot2Race5;
        public string practiceWeatherSlot3Race5;
        public string practiceWeatherSlot4Race5;
        public string practiceWeatherSlot1Race6;
        public string practiceWeatherSlot2Race6;
        public string practiceWeatherSlot3Race6;
        public string practiceWeatherSlot4Race6;
        public string practiceWeatherSlot1Race7;
        public string practiceWeatherSlot2Race7;
        public string practiceWeatherSlot3Race7;
        public string practiceWeatherSlot4Race7;
        public string practiceWeatherSlot1Race8;
        public string practiceWeatherSlot2Race8;
        public string practiceWeatherSlot3Race8;
        public string practiceWeatherSlot4Race8;

        public string qualifyWeatherSlot1Race1;
        public string qualifyWeatherSlot2Race1;
        public string qualifyWeatherSlot3Race1;
        public string qualifyWeatherSlot4Race1;
        public string qualifyWeatherSlot1Race2;
        public string qualifyWeatherSlot2Race2;
        public string qualifyWeatherSlot3Race2;
        public string qualifyWeatherSlot4Race2;
        public string qualifyWeatherSlot1Race3;
        public string qualifyWeatherSlot2Race3;
        public string qualifyWeatherSlot3Race3;
        public string qualifyWeatherSlot4Race3;
        public string qualifyWeatherSlot1Race4;
        public string qualifyWeatherSlot2Race4;
        public string qualifyWeatherSlot3Race4;
        public string qualifyWeatherSlot4Race4;
        public string qualifyWeatherSlot1Race5;
        public string qualifyWeatherSlot2Race5;
        public string qualifyWeatherSlot3Race5;
        public string qualifyWeatherSlot4Race5;
        public string qualifyWeatherSlot1Race6;
        public string qualifyWeatherSlot2Race6;
        public string qualifyWeatherSlot3Race6;
        public string qualifyWeatherSlot4Race6;
        public string qualifyWeatherSlot1Race7;
        public string qualifyWeatherSlot2Race7;
        public string qualifyWeatherSlot3Race7;
        public string qualifyWeatherSlot4Race7;
        public string qualifyWeatherSlot1Race8;
        public string qualifyWeatherSlot2Race8;
        public string qualifyWeatherSlot3Race8;
        public string qualifyWeatherSlot4Race8;

        public string raceWeatherSlot1Race1;
        public string raceWeatherSlot2Race1;
        public string raceWeatherSlot3Race1;
        public string raceWeatherSlot4Race1;
        public string raceWeatherSlot1Race2;
        public string raceWeatherSlot2Race2;
        public string raceWeatherSlot3Race2;
        public string raceWeatherSlot4Race2;
        public string raceWeatherSlot1Race3;
        public string raceWeatherSlot2Race3;
        public string raceWeatherSlot3Race3;
        public string raceWeatherSlot4Race3;
        public string raceWeatherSlot1Race4;
        public string raceWeatherSlot2Race4;
        public string raceWeatherSlot3Race4;
        public string raceWeatherSlot4Race4;
        public string raceWeatherSlot1Race5;
        public string raceWeatherSlot2Race5;
        public string raceWeatherSlot3Race5;
        public string raceWeatherSlot4Race5;
        public string raceWeatherSlot1Race6;
        public string raceWeatherSlot2Race6;
        public string raceWeatherSlot3Race6;
        public string raceWeatherSlot4Race6;
        public string raceWeatherSlot1Race7;
        public string raceWeatherSlot2Race7;
        public string raceWeatherSlot3Race7;
        public string raceWeatherSlot4Race7;
        public string raceWeatherSlot1Race8;
        public string raceWeatherSlot2Race8;
        public string raceWeatherSlot3Race8;
        public string raceWeatherSlot4Race8;


        readonly ValuesControl valueControl = new ValuesControl();
        readonly NumberOfRotate numberOfRotate = new NumberOfRotate();
        readonly ShowOrHideElements showOrHideElements = new ShowOrHideElements();
        


        public Form2()
        {
            InitializeComponent();
            mainWindow = this;
        }

        //Load Window

        private void Form2_Load(object sender, EventArgs e)
        {
            valueControl.FillAllCbBox();
            using (DataLoad dataLoad = new DataLoad())
            {
                dataLoad.Data_Load();
            }
            pictureBox1.Parent = this;
            pictureBox1.Location = new Point(650, 28);
            showOrHideElements.ShowOrHideCbBox_Penalties();
            showOrHideElements.ShowOrHideRank();
        }

        private void ValueForSameTracks()
        {
            track2 = CbBox_Race2Tracks.SelectedIndex;
            track3 = CbBox_Race3Tracks.SelectedIndex;
            track4 = CbBox_Race4Tracks.SelectedIndex;
            track5 = CbBox_Race5Tracks.SelectedIndex;
            track6 = CbBox_Race6Tracks.SelectedIndex;
            track7 = CbBox_Race7Tracks.SelectedIndex;
            track8 = CbBox_Race8Tracks.SelectedIndex;

        }

        private void ValueForSameCars()
        {
            uniqueCar2 = RadioButton_Race2UniqueCar.Checked;
            uniqueCar3 = RadioButton_Race3UniqueCar.Checked;
            uniqueCar4 = RadioButton_Race4UniqueCar.Checked;
            uniqueCar5 = RadioButton_Race5UniqueCar.Checked;
            uniqueCar6 = RadioButton_Race6UniqueCar.Checked;
            uniqueCar7 = RadioButton_Race7UniqueCar.Checked;
            uniqueCar8 = RadioButton_Race8UniqueCar.Checked;
            classCar2 = RadioButton_Race2CarByClass.Checked;
            classCar3 = RadioButton_Race3CarByClass.Checked;
            classCar4 = RadioButton_Race4CarByClass.Checked;
            classCar5 = RadioButton_Race5CarByClass.Checked;
            classCar6 = RadioButton_Race6CarByClass.Checked;
            classCar7 = RadioButton_Race7CarByClass.Checked;
            classCar8 = RadioButton_Race8CarByClass.Checked;
            ClassSlots2 = CbBox_Race2ClassSlots.SelectedIndex;
            ClassSlots3 = CbBox_Race3ClassSlots.SelectedIndex;
            ClassSlots4 = CbBox_Race4ClassSlots.SelectedIndex;
            ClassSlots5 = CbBox_Race5ClassSlots.SelectedIndex;
            ClassSlots6 = CbBox_Race6ClassSlots.SelectedIndex;
            ClassSlots7 = CbBox_Race7ClassSlots.SelectedIndex;
            ClassSlots8 = CbBox_Race8ClassSlots.SelectedIndex;
            Car2 = CbBox_Race2Cars.SelectedIndex;
            Car3 = CbBox_Race3Cars.SelectedIndex;
            Car4 = CbBox_Race4Cars.SelectedIndex;
            Car5 = CbBox_Race5Cars.SelectedIndex;
            Car6 = CbBox_Race6Cars.SelectedIndex;
            Car7 = CbBox_Race7Cars.SelectedIndex;
            Car8 = CbBox_Race8Cars.SelectedIndex;
            Class1R2 = CbBox_Race2Class1.SelectedIndex;
            Class1R3 = CbBox_Race3Class1.SelectedIndex;
            Class1R4 = CbBox_Race4Class1.SelectedIndex;
            Class1R5 = CbBox_Race5Class1.SelectedIndex;
            Class1R6 = CbBox_Race6Class1.SelectedIndex;
            Class1R7 = CbBox_Race7Class1.SelectedIndex;
            Class1R8 = CbBox_Race8Class1.SelectedIndex;
            Class2R2 = CbBox_Race2Class2.SelectedIndex;
            Class2R3 = CbBox_Race3Class2.SelectedIndex;
            Class2R4 = CbBox_Race4Class2.SelectedIndex;
            Class2R5 = CbBox_Race5Class2.SelectedIndex;
            Class2R6 = CbBox_Race6Class2.SelectedIndex;
            Class2R7 = CbBox_Race7Class2.SelectedIndex;
            Class3R8 = CbBox_Race8Class2.SelectedIndex;
            Class3R2 = CbBox_Race2Class3.SelectedIndex;
            Class3R3 = CbBox_Race3Class3.SelectedIndex;
            Class3R4 = CbBox_Race4Class3.SelectedIndex;
            Class3R5 = CbBox_Race5Class3.SelectedIndex;
            Class3R6 = CbBox_Race6Class3.SelectedIndex;
            Class3R7 = CbBox_Race7Class3.SelectedIndex;
            Class3R8 = CbBox_Race8Class3.SelectedIndex;
            Class4R2 = CbBox_Race2Class4.SelectedIndex;
            Class4R3 = CbBox_Race3Class4.SelectedIndex;
            Class4R4 = CbBox_Race4Class4.SelectedIndex;
            Class4R5 = CbBox_Race5Class4.SelectedIndex;
            Class4R6 = CbBox_Race6Class4.SelectedIndex;
            Class4R7 = CbBox_Race7Class4.SelectedIndex;
            Class4R8 = CbBox_Race8Class4.SelectedIndex;
        }

        // End Load


        // Closing window and show window choiceServer

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.choiceServer.Show();

            this.Dispose();
        }





        // Validation of the fields



        private void TxtBx_LogSize_Click(object sender, EventArgs e)
        {
            valueTemp = TxtBx_LogSize.Text;
        }

        private void TxtBx_LogSize_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBx_LogSize.Text;
            valueControl.Numeric_Control();
            TxtBx_LogSize.Text = value;

        }


        private void TxtBx_BindIp_Validating(object sender, CancelEventArgs e)
        {
            ip = TxtBx_BindIp.Text;
            valueControl.Ip_Control();
            TxtBx_BindIp.Text = ip;

        }


        private void TxtBx_SteamPort_Click(object sender, EventArgs e)
        {
            valueTemp = TxtBx_SteamPort.Text;

        }

        private void TxtBx_SteamPort_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBx_SteamPort.Text;
            valueControl.Numeric_Control();
            TxtBx_SteamPort.Text = value;
        }

        private void TxtBx_HostPort_Click(object sender, EventArgs e)
        {
            valueTemp = TxtBx_HostPort.Text;
        }

        private void TxtBx_HostPort_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBx_HostPort.Text;
            valueControl.Numeric_Control();
            TxtBx_HostPort.Text = value;
        }

        private void TxtBx_HttpApiPort_Click(object sender, EventArgs e)
        {
            valueTemp = TxtBx_HttpApiPort.Text;
        }

        private void TxtBx_HttpApiPort_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBx_HttpApiPort.Text;
            valueControl.Numeric_Control();
            TxtBx_HttpApiPort.Text = value;
        }

        private void TxtBx_QueryPort_Click(object sender, EventArgs e)
        {
            valueTemp = TxtBx_QueryPort.Text;
        }

        private void TxtBx_QueryPort_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBx_QueryPort.Text;
            valueControl.Numeric_Control();
            TxtBx_QueryPort.Text = value;
        }

        private void TxtBx_SleepWaiting_Click(object sender, EventArgs e)
        {
            valueTemp = TxtBx_SleepWaiting.Text;
        }

        private void TxtBx_SleepWaiting_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBx_SleepWaiting.Text;
            valueControl.Numeric_Control();
            TxtBx_SleepWaiting.Text = value;
        }

        private void TxtBx_SleepActive_Click(object sender, EventArgs e)
        {
            valueTemp = TxtBx_SleepActive.Text;
        }

        private void TxtBx_SleepActive_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBx_SleepActive.Text;
            valueControl.Numeric_Control();
            TxtBx_SleepActive.Text = value;
        }

        private void TxtBx_HttpApiInterface_Validating(object sender, CancelEventArgs e)
        {
            ip = TxtBx_HttpApiInterface.Text;
            valueControl.Ip_Control2();
            TxtBx_HttpApiInterface.Text = ip;
        }

        private void TxtBx_AdminHttpApi_Click(object sender, EventArgs e)
        {
            valueTemp = TxtBx_AdminHttpApi.Text;
        }
        private void TxtBx_AdminHttpApi_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBx_AdminHttpApi.Text;
            valueControl.Empty_Control();
            TxtBx_AdminHttpApi.Text = value;
        }

        private void TxtBx_PassHttpApi_Click(object sender, EventArgs e)
        {
            valueTemp = TxtBx_PassHttpApi.Text;
        }

        private void TxtBx_PassHttpApi_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBx_PassHttpApi.Text;
            valueControl.Empty_Control();
            TxtBx_PassHttpApi.Text = value;
        }
        private void TxtBx_NumberOfDrivers_Click(object sender, EventArgs e)
        {
            valueTemp = TxtBx_NumberOfDrivers.Text;
        }
        private void TxtBx_NumberOfDrivers_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBx_NumberOfDrivers.Text;
            valueControl.Empty_Control();
            valueControl.Numeric_Control();
            int value1 = int.Parse(value);
            int value2 = int.Parse(TxtBx_GridSize.Text);
            if (value1 > value2)
            {
                MessageBox.Show("Plus de Joueurs que la taille de la grille", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtBx_NumberOfDrivers.Text = valueTemp;
            }
            else
            {
                TxtBx_NumberOfDrivers.Text = value;
            }
        }

        // end Of Fields

        // Select Tracks in combobox
        private void CbBox_Race1Tracks_SelectionChangeCommitted(object sender, EventArgs e)
        {
            valueControl.TracksValuesRace1();
            showOrHideElements.ApplySameTrackForAllRace();
        }

        private void CbBox_Race2Tracks_SelectionChangeCommitted(object sender, EventArgs e)
        {
            valueControl.TracksValuesRace2();
            track2 = CbBox_Race2Tracks.SelectedIndex;
        }

        private void CbBox_Race3Tracks_SelectionChangeCommitted(object sender, EventArgs e)
        {
            valueControl.TracksValuesRace3();
            track3 = CbBox_Race3Tracks.SelectedIndex;
        }

        private void CbBox_Race4Tracks_SelectionChangeCommitted(object sender, EventArgs e)
        {
            valueControl.TracksValuesRace4();
            track4 = CbBox_Race4Tracks.SelectedIndex;
        }

        private void CbBox_Race5Tracks_SelectionChangeCommitted(object sender, EventArgs e)
        {
            valueControl.TracksValuesRace5();
            track5 = CbBox_Race5Tracks.SelectedIndex;
        }

        private void CbBox_Race6Tracks_SelectionChangeCommitted(object sender, EventArgs e)
        {
            valueControl.TracksValuesRace6();
            track6 = CbBox_Race6Tracks.SelectedIndex;
        }

        private void CbBox_Race7Tracks_SelectionChangeCommitted(object sender, EventArgs e)
        {
            valueControl.TracksValuesRace7();
            track7 = CbBox_Race7Tracks.SelectedIndex;
        }

        private void CbBox_Race8Tracks_SelectionChangeCommitted(object sender, EventArgs e)
        {
            valueControl.TracksValuesRace8();
            track8 = CbBox_Race8Tracks.SelectedIndex;
        }
        //end of section tracks

        // Define number of race 
        private void CbBox_NumerOfRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            numberOfRotate.NumberOfRaces();
        }

        private void CbBox_NumerOfRace_SelectionChangeCommitted(object sender, EventArgs e)
        {
            numberOfRotate.Define_GridSize();
        }

        // Define Class Or Unique cars  and displays the necessary combobox

        private void RadioButton_Race1CarByClass_CheckedChanged(object sender, EventArgs e)
        {
            CbBox_Race1Class1.Visible = true;
            CbBox_Race1Cars.Visible = false;
            CbBox_Race1ClassSlots.Visible = true;
            showOrHideElements.ApplySameCarForAllRaces();
        }
        private void RadioButton_Race1UniqueCar_CheckedChanged(object sender, EventArgs e)
        {
            CbBox_Race1Class1.Visible = false;
            CbBox_Race1Class2.Visible = false;
            CbBox_Race1Class3.Visible = false;
            CbBox_Race1Class4.Visible = false;
            CbBox_Race1ClassSlots.Text = "1";
            CbBox_Race1ClassSlots.Visible = false;
            CbBox_Race1Cars.Visible = true;
        }

        private void RadioButton_Race2CarByClass_CheckedChanged(object sender, EventArgs e)
        {
            CbBox_Race2Class1.Visible = true;
            CbBox_Race2Cars.Visible = false;
            CbBox_Race2ClassSlots.Visible = true;

        }

        private void RadioButton_Race2UniqueCar_CheckedChanged(object sender, EventArgs e)
        {
            CbBox_Race2Class1.Visible = false;
            CbBox_Race2Class2.Visible = false;
            CbBox_Race2Class3.Visible = false;
            CbBox_Race2Class4.Visible = false;
            CbBox_Race2ClassSlots.Text = "1";
            CbBox_Race2ClassSlots.Visible = false;
            CbBox_Race2Cars.Visible = true;
        }

        private void RadioButton_Race3CarByClass_CheckedChanged(object sender, EventArgs e)
        {
            CbBox_Race3Class1.Visible = true;
            CbBox_Race3Cars.Visible = false;
            CbBox_Race3ClassSlots.Visible = true;
        }

        private void RadioButton_Race3UniqueCar_CheckedChanged(object sender, EventArgs e)
        {
            CbBox_Race3Class1.Visible = false;
            CbBox_Race3Class2.Visible = false;
            CbBox_Race3Class3.Visible = false;
            CbBox_Race3Class4.Visible = false;
            CbBox_Race3ClassSlots.Text = "1";
            CbBox_Race3ClassSlots.Visible = false;
            CbBox_Race3Cars.Visible = true;
        }

        private void RadioButton_Race4CarByClass_CheckedChanged(object sender, EventArgs e)
        {
            CbBox_Race4Class1.Visible = true;
            CbBox_Race4Cars.Visible = false;
            CbBox_Race4ClassSlots.Visible = true;
        }


        private void RadioButton_Race4UniqueCar_CheckedChanged(object sender, EventArgs e)
        {
            CbBox_Race4Class1.Visible = false;
            CbBox_Race4Class2.Visible = false;
            CbBox_Race4Class3.Visible = false;
            CbBox_Race4Class4.Visible = false;
            CbBox_Race4ClassSlots.Text = "1";
            CbBox_Race4ClassSlots.Visible = false;
            CbBox_Race4Cars.Visible = true;
        }

        private void RadioButton_Race5CarByClass_CheckedChanged(object sender, EventArgs e)
        {
            CbBox_Race5Class1.Visible = true;
            CbBox_Race5Cars.Visible = false;
            CbBox_Race5ClassSlots.Visible = true;
        }

        private void RadioButton_Race5UniqueCar_CheckedChanged(object sender, EventArgs e)
        {
            CbBox_Race5Class1.Visible = false;
            CbBox_Race5Class2.Visible = false;
            CbBox_Race5Class3.Visible = false;
            CbBox_Race5Class4.Visible = false;
            CbBox_Race5ClassSlots.Text = "1";
            CbBox_Race5ClassSlots.Visible = false;
            CbBox_Race5Cars.Visible = true;
        }

        private void RadioButton_Race6CarByClass_CheckedChanged(object sender, EventArgs e)
        {
            CbBox_Race6Class1.Visible = true;
            CbBox_Race6Cars.Visible = false;
            CbBox_Race6ClassSlots.Visible = true;
        }

        private void RadioButton_Race6UniqueCar_CheckedChanged(object sender, EventArgs e)
        {
            CbBox_Race6Class1.Visible = false;
            CbBox_Race6Class2.Visible = false;
            CbBox_Race6Class3.Visible = false;
            CbBox_Race6Class4.Visible = false;
            CbBox_Race6ClassSlots.Text = "1";
            CbBox_Race6ClassSlots.Visible = false;
            CbBox_Race6Cars.Visible = true;
        }

        private void RadioButton_Race7CarByClass_CheckedChanged(object sender, EventArgs e)
        {
            CbBox_Race7Class1.Visible = true;
            CbBox_Race7Cars.Visible = false;
            CbBox_Race7ClassSlots.Visible = true;
        }

        private void RadioButton_Race7UniqueCar_CheckedChanged(object sender, EventArgs e)
        {
            CbBox_Race7Class1.Visible = false;
            CbBox_Race7Class2.Visible = false;
            CbBox_Race7Class3.Visible = false;
            CbBox_Race7Class4.Visible = false;
            CbBox_Race7ClassSlots.Text = "1";
            CbBox_Race7ClassSlots.Visible = false;
            CbBox_Race7Cars.Visible = true;
        }

        private void RadioButton_Race8CarByClass_CheckedChanged(object sender, EventArgs e)
        {
            CbBox_Race8Class1.Visible = true;
            CbBox_Race8Cars.Visible = false;
            CbBox_Race8ClassSlots.Visible = true;
        }

        private void RadioButton_Race8UniqueCar_CheckedChanged(object sender, EventArgs e)
        {
            CbBox_Race8Class1.Visible = false;
            CbBox_Race8Class2.Visible = false;
            CbBox_Race8Class3.Visible = false;
            CbBox_Race8Class4.Visible = false;
            CbBox_Race8ClassSlots.Text = "1";
            CbBox_Race8ClassSlots.Visible = false;
            CbBox_Race8Cars.Visible = true;
        }

        // Choice number of  vehicles Class and displays the necessary combobox 
        private void CbBox_Race1ClassSlots_SelectedIndexChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideComboBoxClassRace1();
            if (CheckBox_SameCars.Checked == true)
            {
                showOrHideElements.ApplySameCarForAllRaces();
            }
        }


        private void CbBox_Race2ClassSlots_SelectedIndexChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideComboBoxClassRace2();
        }

        private void CbBox_Race3ClassSlots_SelectedIndexChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideComboBoxClassRace3();
        }

        private void CbBox_Race4ClassSlots_SelectedIndexChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideComboBoxClassRace4();
        }

        private void CbBox_Race5ClassSlots_SelectedIndexChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideComboBoxClassRace5();
        }

        private void CbBox_Race6ClassSlots_SelectedIndexChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideComboBoxClassRace6();
        }

        private void CbBox_Race7ClassSlots_SelectedIndexChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideComboBoxClassRace7();
        }

        private void CbBox_Race8ClassSlots_SelectedIndexChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideComboBoxClassRace8();
        }

        //Validating Duration Of the Race

        private void TxtBx_PracticeLengthRace1_Click(object sender, EventArgs e)
        {
            valueTemp = TxtBx_PracticeLengthRace1.Text;
        }

        private void TxtBx_PracticeLengthRace1_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBx_PracticeLengthRace1.Text;
            valueControl.Time_Control_Multiple5();
            TxtBx_PracticeLengthRace1.Text = value;
            if (TxtBx_PracticeLengthRace1.Text == "0")
            {
                GrpBox_PracticeWeatherRace1.Visible = false;
            }
            else
            {
                GrpBox_PracticeWeatherRace1.Visible = true;
            }
        }

        private void TxtBx_QualifyLengthRace1_Click(object sender, EventArgs e)
        {
            valueTemp = TxtBx_QualifyLengthRace1.Text;
        }

        private void TxtBx_QualifyLengthRace1_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBx_QualifyLengthRace1.Text;
            valueControl.Time_Control_Multiple5();
            TxtBx_QualifyLengthRace1.Text = value;
            if (TxtBx_QualifyLengthRace1.Text == "0")
            {
                GrpBox_QualifyWeatherRace1.Visible = false;
            }
            else
            {
                GrpBox_QualifyWeatherRace1.Visible = true;
            }
        }

        private void TxtBx_RaceLengthRace1_Click(object sender, EventArgs e)
        {
            valueTemp = TxtBx_RaceLengthRace1.Text;
        }

        private void TxtBx_RaceLengthRace1_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBx_RaceLengthRace1.Text;
            if (RadioButton_LapsRace1.Checked == true)
            {
                valueControl.Numeric_Control();
            }
            else
            {
                valueControl.Time_Control_Multiple5();
            }
            TxtBx_RaceLengthRace1.Text = value;
        }

        private void TxtBx_PracticeLengthRace2_Click(object sender, EventArgs e)
        {
            valueTemp = TxtBx_PracticeLengthRace2.Text;
        }

        private void TxtBx_PracticeLengthRace2_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBx_PracticeLengthRace2.Text;
            valueControl.Time_Control_Multiple5();
            TxtBx_PracticeLengthRace2.Text = value;
            if (TxtBx_PracticeLengthRace2.Text == "0")
            {
                GrpBox_PracticeWeatherRace2.Visible = false;
            }
            else
            {
                GrpBox_PracticeWeatherRace2.Visible = true;
            }
        }

        private void TxtBx_QualifyLengthRace2_Click(object sender, EventArgs e)
        {
            valueTemp = TxtBx_QualifyLengthRace2.Text;
        }

        private void TxtBx_QualifyLengthRace2_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBx_QualifyLengthRace2.Text;
            valueControl.Time_Control_Multiple5();
            TxtBx_QualifyLengthRace2.Text = value;
            if (TxtBx_QualifyLengthRace2.Text == "0")
            {
                GrpBox_QualifyWeatherRace2.Visible = false;
            }
            else
            {
                GrpBox_QualifyWeatherRace2.Visible = true;
            }
        }

        private void TxtBx_RaceLengthRace2_Click(object sender, EventArgs e)
        {
            valueTemp = TxtBx_RaceLengthRace2.Text;
        }

        private void TxtBx_RaceLengthRace2_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBx_RaceLengthRace2.Text;
            if (RadioButton_LapsRace2.Checked == true)
            {
                valueControl.Numeric_Control();
            }
            else
            {
                valueControl.Time_Control_Multiple5();
            }
            TxtBx_RaceLengthRace2.Text = value;
        }




        private void TxtBx_PracticeLengthRace3_Click(object sender, EventArgs e)
        {
            valueTemp = TxtBx_PracticeLengthRace3.Text;
        }

        private void TxtBx_PracticeLengthRace3_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBx_PracticeLengthRace3.Text;
            valueControl.Time_Control_Multiple5();
            TxtBx_PracticeLengthRace3.Text = value;
            if (TxtBx_PracticeLengthRace3.Text == "0")
            {
                GrpBox_PracticeWeatherRace3.Visible = false;
            }
            else
            {
                GrpBox_PracticeWeatherRace3.Visible = true;
            }
        }

        private void TxtBx_QualifyLengthRace3_Click(object sender, EventArgs e)
        {
            valueTemp = TxtBx_QualifyLengthRace3.Text;
        }

        private void TxtBx_QualifyLengthRace3_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBx_QualifyLengthRace3.Text;
            valueControl.Time_Control_Multiple5();
            TxtBx_QualifyLengthRace3.Text = value;
            if (TxtBx_QualifyLengthRace3.Text == "0")
            {
                GrpBox_QualifyWeatherRace3.Visible = false;
            }
            else
            {
                GrpBox_QualifyWeatherRace3.Visible = true;
            }
        }

        private void TxtBx_RaceLengthRace3_Click(object sender, EventArgs e)
        {
            valueTemp = TxtBx_RaceLengthRace3.Text;
        }

        private void TxtBx_RaceLengthRace3_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBx_RaceLengthRace3.Text;
            if (RadioButton_LapsRace3.Checked == true)
            {
                valueControl.Numeric_Control();
            }
            else
            {
                valueControl.Time_Control_Multiple5();
            }
            TxtBx_RaceLengthRace3.Text = value;
        }



        private void TxtBx_PracticeLengthRace4_Click(object sender, EventArgs e)
        {
            valueTemp = TxtBx_PracticeLengthRace4.Text;
        }

        private void TxtBx_PracticeLengthRace4_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBx_PracticeLengthRace4.Text;
            valueControl.Time_Control_Multiple5();
            TxtBx_PracticeLengthRace4.Text = value;
            if (TxtBx_PracticeLengthRace4.Text == "0")
            {
                GrpBox_PracticeWeatherRace4.Visible = false;
            }
            else
            {
                GrpBox_PracticeWeatherRace4.Visible = true;
            }
        }

        private void TxtBx_QualifyLengthRace4_Click(object sender, EventArgs e)
        {
            valueTemp = TxtBx_QualifyLengthRace4.Text;
        }

        private void TxtBx_QualifyLengthRace4_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBx_QualifyLengthRace4.Text;
            valueControl.Time_Control_Multiple5();
            TxtBx_QualifyLengthRace4.Text = value;
            if (TxtBx_QualifyLengthRace4.Text == "0")
            {
                GrpBox_QualifyWeatherRace4.Visible = false;
            }
            else
            {
                GrpBox_QualifyWeatherRace4.Visible = true;
            }
        }

        private void TxtBx_RaceLengthRace4_Click(object sender, EventArgs e)
        {
            valueTemp = TxtBx_RaceLengthRace4.Text;
        }

        private void TxtBx_RaceLengthRace4_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBx_RaceLengthRace4.Text;
            if (RadioButton_LapsRace4.Checked == true)
            {
                valueControl.Numeric_Control();
            }
            else
            {
                valueControl.Time_Control_Multiple5();
            }
            TxtBx_RaceLengthRace4.Text = value;

        }

        private void TxtBx_PracticeLengthRace5_Click(object sender, EventArgs e)
        {
            valueTemp = TxtBx_PracticeLengthRace5.Text;
        }

        private void TxtBx_PracticeLengthRace5_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBx_PracticeLengthRace5.Text;
            valueControl.Time_Control_Multiple5();
            TxtBx_PracticeLengthRace5.Text = value;
            if (TxtBx_PracticeLengthRace5.Text == "0")
            {
                GrpBox_PracticeWeatherRace5.Visible = false;
            }
            else
            {
                GrpBox_PracticeWeatherRace5.Visible = true;
            }
        }

        private void TxtBx_QualifyLengthRace5_Click(object sender, EventArgs e)
        {
            valueTemp = TxtBx_QualifyLengthRace5.Text;
        }

        private void TxtBx_QualifyLengthRace5_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBx_QualifyLengthRace5.Text;
            valueControl.Time_Control_Multiple5();
            TxtBx_QualifyLengthRace5.Text = value;
            if (TxtBx_QualifyLengthRace5.Text == "0")
            {
                GrpBox_QualifyWeatherRace5.Visible = false;
            }
            else
            {
                GrpBox_QualifyWeatherRace5.Visible = true;
            }
        }

        private void TxtBx_RaceLengthRace5_Click(object sender, EventArgs e)
        {
            valueTemp = TxtBx_RaceLengthRace5.Text;
        }

        private void TxtBx_RaceLengthRace5_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBx_RaceLengthRace5.Text;
            if (RadioButton_LapsRace5.Checked == true)
            {
                valueControl.Numeric_Control();
            }
            else
            {
                valueControl.Time_Control_Multiple5();
            }
            TxtBx_RaceLengthRace5.Text = value;

        }
        private void TxtBx_PracticeLengthRace6_Click(object sender, EventArgs e)
        {
            valueTemp = TxtBx_PracticeLengthRace6.Text;
        }

        private void TxtBx_PracticeLengthRace6_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBx_PracticeLengthRace6.Text;
            valueControl.Time_Control_Multiple5();
            TxtBx_PracticeLengthRace6.Text = value;
            if (TxtBx_PracticeLengthRace6.Text == "0")
            {
                GrpBox_PracticeWeatherRace6.Visible = false;
            }
            else
            {
                GrpBox_PracticeWeatherRace6.Visible = true;
            }
        }

        private void TxtBx_QualifyLengthRace6_Click(object sender, EventArgs e)
        {
            valueTemp = TxtBx_QualifyLengthRace6.Text;
        }

        private void TxtBx_QualifyLengthRace6_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBx_QualifyLengthRace6.Text;
            valueControl.Time_Control_Multiple5();
            TxtBx_QualifyLengthRace6.Text = value;
            if (TxtBx_QualifyLengthRace6.Text == "0")
            {
                GrpBox_QualifyWeatherRace6.Visible = false;
            }
            else
            {
                GrpBox_QualifyWeatherRace6.Visible = true;
            }
        }

        private void TxtBx_RaceLengthRace6_Click(object sender, EventArgs e)
        {
            valueTemp = TxtBx_RaceLengthRace6.Text;
        }

        private void TxtBx_RaceLengthRace6_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBx_RaceLengthRace6.Text;
            if (RadioButton_LapsRace6.Checked == true)
            {
                valueControl.Numeric_Control();
            }
            else
            {
                valueControl.Time_Control_Multiple5();
            }
            TxtBx_RaceLengthRace6.Text = value;

        }

        private void TxtBx_PracticeLengthRace7_Click(object sender, EventArgs e)
        {
            valueTemp = TxtBx_PracticeLengthRace7.Text;
        }

        private void TxtBx_PracticeLengthRace7_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBx_PracticeLengthRace7.Text;
            valueControl.Time_Control_Multiple5();
            TxtBx_PracticeLengthRace7.Text = value;
            if (TxtBx_PracticeLengthRace7.Text == "0")
            {
                GrpBox_PracticeWeatherRace7.Visible = false;
            }
            else
            {
                GrpBox_PracticeWeatherRace7.Visible = true;
            }
        }

        private void TxtBx_QualifyLengthRace7_Click(object sender, EventArgs e)
        {
            valueTemp = TxtBx_QualifyLengthRace7.Text;
        }

        private void TxtBx_QualifyLengthRace7_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBx_QualifyLengthRace7.Text;
            valueControl.Time_Control_Multiple5();
            TxtBx_QualifyLengthRace7.Text = value;
            if (TxtBx_QualifyLengthRace7.Text == "0")
            {
                GrpBox_QualifyWeatherRace7.Visible = false;
            }
            else
            {
                GrpBox_QualifyWeatherRace7.Visible = true;
            }
        }

        private void TxtBx_RaceLengthRace7_Click(object sender, EventArgs e)
        {
            valueTemp = TxtBx_RaceLengthRace7.Text;
        }

        private void TxtBx_RaceLengthRace7_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBx_RaceLengthRace7.Text;
            if (RadioButton_LapsRace7.Checked == true)
            {
                valueControl.Numeric_Control();
            }
            else
            {
                valueControl.Time_Control_Multiple5();
            }
            TxtBx_RaceLengthRace7.Text = value;

        }

        private void TxtBx_PracticeLengthRace8_Click(object sender, EventArgs e)
        {
            valueTemp = TxtBx_PracticeLengthRace8.Text;
        }

        private void TxtBx_PracticeLengthRace8_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBx_PracticeLengthRace8.Text;
            valueControl.Time_Control_Multiple5();
            TxtBx_PracticeLengthRace8.Text = value;
            if (TxtBx_PracticeLengthRace8.Text == "0")
            {
                GrpBox_PracticeWeatherRace8.Visible = false;
            }
            else
            {
                GrpBox_PracticeWeatherRace8.Visible = true;
            }
        }

        private void TxtBx_QualifyLengthRace8_Click(object sender, EventArgs e)
        {
            valueTemp = TxtBx_QualifyLengthRace8.Text;
        }

        private void TxtBx_QualifyLengthRace8_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBx_QualifyLengthRace8.Text;
            valueControl.Time_Control_Multiple5();
            TxtBx_QualifyLengthRace8.Text = value;
            if (TxtBx_QualifyLengthRace8.Text == "0")
            {
                GrpBox_QualifyWeatherRace8.Visible = false;
            }
            else
            {
                GrpBox_QualifyWeatherRace8.Visible = true;
            }
        }

        private void TxtBx_RaceLengthRace8_Click(object sender, EventArgs e)
        {
            valueTemp = TxtBx_RaceLengthRace8.Text;
        }

        private void TxtBx_RaceLengthRace8_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBx_RaceLengthRace8.Text;
            if (RadioButton_LapsRace8.Checked == true)
            {
                valueControl.Numeric_Control();
            }
            else
            {
                valueControl.Time_Control_Multiple5();
            }
            TxtBx_RaceLengthRace8.Text = value;

        }

        //Button Validate

        private void Button_Validate_Click(object sender, EventArgs e)
        {
            Form3.dialWindow = new Form3();
            Form3.dialWindow.Show();
            Enabled = false;
            timer1.Start();
            using (CreateOfServerFiles createOfServerFiles = new CreateOfServerFiles())
            {
                createOfServerFiles.EditServerFiles();
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            if (_ticks == 3)
            {
                timer1.Stop();
                _ticks = 0;
                Form3.dialWindow.Text = "Terminé !";
                Form3.dialWindow.progressBar.Visible = false;
                Form3.dialWindow.label1.Visible = true;
                Form3.dialWindow.button_No.Visible = true;
                Form3.dialWindow.button_Yes.Visible = true;
            }
        }

        // We display comboboxes weather according to the number of slots chosen
        private void CbBox_PracticeWeatherSlotsRace1_SelectedIndexChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideComboBoxPracticeWeatherRace1();
        }

        private void CbBox_PracticeWeatherSlotsRace2_SelectedIndexChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideComboBoxPracticeWeatherRace2();
        }

        private void CbBox_PracticeWeatherSlotsRace3_SelectedIndexChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideComboBoxPracticeWeatherRace3();
        }

        private void CbBox_PracticeWeatherSlotsRace4_SelectedIndexChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideComboBoxPracticeWeatherRace4();
        }

        private void CbBox_PracticeWeatherSlotsRace5_SelectedIndexChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideComboBoxPracticeWeatherRace5();
        }

        private void CbBox_PracticeWeatherSlotsRace6_SelectedIndexChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideComboBoxPracticeWeatherRace6();
        }

        private void CbBox_PracticeWeatherSlotsRace7_SelectedIndexChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideComboBoxPracticeWeatherRace7();
        }

        private void CbBox_PracticeWeatherSlotsRace8_SelectedIndexChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideComboBoxPracticeWeatherRace8();
        }

        private void CbBox_QualifWeatherSlotsRace1_SelectedIndexChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideComboBoxQualifWeatherRace1();
        }

        private void CbBox_QualifWeatherSlotsRace2_SelectedIndexChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideComboBoxQualifWeatherRace2();
        }

        private void CbBox_QualifWeatherSlotsRace3_SelectedIndexChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideComboBoxQualifWeatherRace3();
        }

        private void CbBox_QualifWeatherSlotsRace4_SelectedIndexChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideComboBoxQualifWeatherRace4();
        }

        private void CbBox_QualifWeatherSlotsRace5_SelectedIndexChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideComboBoxQualifWeatherRace5();
        }
        private void CbBox_QualifWeatherSlotsRace6_SelectedIndexChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideComboBoxQualifWeatherRace6();
        }

        private void CbBox_QualifWeatherSlotsRace7_SelectedIndexChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideComboBoxQualifWeatherRace7();
        }

        private void CbBox_QualifWeatherSlotsRace8_SelectedIndexChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideComboBoxQualifWeatherRace8();
        }

        private void CbBox_RaceWeatherSlotsRace1_SelectedIndexChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideComboBoxRaceWeatherRace1();
        }

        private void CbBox_RaceWeatherSlotsRace2_SelectedIndexChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideComboBoxRaceWeatherRace2();
        }

        private void CbBox_RaceWeatherSlotsRace3_SelectedIndexChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideComboBoxRaceWeatherRace3();
        }

        private void CbBox_RaceWeatherSlotsRace4_SelectedIndexChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideComboBoxRaceWeatherRace4();
        }

        private void CbBox_RaceWeatherSlotsRace5_SelectedIndexChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideComboBoxRaceWeatherRace5();
        }

        private void CbBox_RaceWeatherSlotsRace6_SelectedIndexChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideComboBoxRaceWeatherRace6();
        }

        private void CbBox_RaceWeatherSlotsRace7_SelectedIndexChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideComboBoxRaceWeatherRace7();
        }

        private void CbBox_RaceWeatherSlotsRace8_SelectedIndexChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideComboBoxRaceWeatherRace8();
        }

        private void ParamètresAvancésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GrpBox_Advance.Visible == true)
            {
                GrpBox_Advance.Visible = false;
            }
            else
            {
                GrpBox_Advance.Visible = true;
            }
        }

        //If the checkbock is activated, I display the combobox of the penalty time

        private void CheckBox_PenaltiesRace1_CheckedChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideCbBox_Penalties();
        }

        private void CheckBox_PenaltiesRace2_CheckedChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideCbBox_Penalties();
        }

        private void CheckBox_PenaltiesRace3_CheckedChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideCbBox_Penalties();
        }

        private void CheckBox_PenaltiesRace4_CheckedChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideCbBox_Penalties();
        }

        private void CheckBox_PenaltiesRace5_CheckedChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideCbBox_Penalties();
        }

        private void CheckBox_PenaltiesRace6_CheckedChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideCbBox_Penalties();
        }

        private void CheckBox_PenaltiesRace7_CheckedChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideCbBox_Penalties();
        }

        private void CheckBox_PenaltiesRace8_CheckedChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideCbBox_Penalties();
        }

        //End of section penalties

        //Apply same Car or track for all races

        private void CheckBox_SameTrack_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_SameTrack.Checked == true)
            {
                ValueForSameTracks();
            }

            showOrHideElements.ApplySameTrackForAllRace();
            valueControl.TracksValuesRace1();
            valueControl.TracksValuesRace2();
            valueControl.TracksValuesRace3();
            valueControl.TracksValuesRace4();
            valueControl.TracksValuesRace5();
            valueControl.TracksValuesRace6();
            valueControl.TracksValuesRace7();
            valueControl.TracksValuesRace8();
        }

        private void CheckBox_SameCars_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_SameCars.Checked == true)
            {
                ValueForSameCars();
            }

            showOrHideElements.ApplySameCarForAllRaces();
        }

        private void CbBox_Race2Cars_SelectionChangeCommitted(object sender, EventArgs e)
        {
            showOrHideElements.ApplySameCarForAllRaces();
        }

        private void CbBox_Race1Cars_SelectionChangeCommitted(object sender, EventArgs e)
        {
            showOrHideElements.ApplySameCarForAllRaces();
        }

        private void CbBox_Race1Class1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            showOrHideElements.ApplySameCarForAllRaces();
        }

        private void CbBox_Race1Class2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            showOrHideElements.ApplySameCarForAllRaces();
        }

        private void CbBox_Race1Class3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            showOrHideElements.ApplySameCarForAllRaces();
        }

        private void CbBox_Race1Class4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            showOrHideElements.ApplySameCarForAllRaces();
        }

        //End Section for same traks an cars

        //If the checkbock is activated, I display the combobox and textbox for the Ranking and I check the textbox entries

        private void CheckBox_RankRace1_CheckedChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideRank();
        }

        private void CheckBox_RankRace2_CheckedChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideRank();
        }

        private void CheckBox_RankRace3_CheckedChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideRank();
        }

        private void CheckBox_RankRace4_CheckedChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideRank();
        }

        private void CheckBox_RankRace5_CheckedChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideRank();
        }

        private void CheckBox_RankRace6_CheckedChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideRank();
        }

        private void CheckBox_RankRace7_CheckedChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideRank();
        }

        private void CheckBox_RankRace8_CheckedChanged(object sender, EventArgs e)
        {
            showOrHideElements.ShowOrHideRank();
        }

        private void TxtBox_RankRace1_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBox_RankRace1.Text;
            valueControl.RankControl();
            TxtBox_RankRace1.Text = value;
        }
        private void TxtBox_RankRace2_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBox_RankRace2.Text;
            valueControl.RankControl();
            TxtBox_RankRace2.Text = value;
        }

        private void TxtBox_RankRace3_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBox_RankRace3.Text;
            valueControl.RankControl();
            TxtBox_RankRace3.Text = value;
        }

        private void TxtBox_RankRace4_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBox_RankRace4.Text;
            valueControl.RankControl();
            TxtBox_RankRace4.Text = value;
        }

        private void TxtBox_RankRace5_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBox_RankRace5.Text;
            valueControl.RankControl();
            TxtBox_RankRace5.Text = value;
        }

        private void TxtBox_RankRace6_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBox_RankRace6.Text;
            valueControl.RankControl();
            TxtBox_RankRace6.Text = value;
        }

        private void TxtBox_RankRace7_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBox_RankRace7.Text;
            valueControl.RankControl();
            TxtBox_RankRace7.Text = value;
        }

        private void TabControl_Validating(object sender, CancelEventArgs e)
        {
            value = TxtBox_RankRace8.Text;
            valueControl.RankControl();
            TxtBox_RankRace8.Text = value;
        }

        // End of section Rank


        // Section Broadcaster if the checkbox is activated that of the race director must be
        private void CheckBox_BroadCasterRace1_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckBox_BroadCasterRace1.Checked)
            {
                CheckBox_RaceDirectorRace1.Checked = true;
            }
        }

        private void CheckBox_BroadCasterRace2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_BroadCasterRace2.Checked)
            {
                CheckBox_RaceDirectorRace2.Checked = true;
            }
        }

        private void CheckBox_BroadCasterRace3_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_BroadCasterRace3.Checked)
            {
                CheckBox_RaceDirectorRace3.Checked = true;
            }
        }

        private void CheckBox_BroadCasterRace4_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_BroadCasterRace4.Checked)
            {
                CheckBox_RaceDirectorRace4.Checked = true;
            }
        }

        private void CheckBox_BroadCasterRace5_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_BroadCasterRace5.Checked)
            {
                CheckBox_RaceDirectorRace5.Checked = true;
            }
        }

        private void CheckBox_BroadCasterRace6_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_BroadCasterRace6.Checked)
            {
                CheckBox_RaceDirectorRace6.Checked = true;
            }
        }

        private void CheckBox_BroadCasterRace7_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_BroadCasterRace7.Checked)
            {
                CheckBox_RaceDirectorRace7.Checked = true;
            }
        }

        private void CheckBox_BroadCasterRace8_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_BroadCasterRace8.Checked)
            {
                CheckBox_RaceDirectorRace8.Checked = true;
            }
        }
        //End of section Broadcaster

        // Section for same rule for all races
        private void CheckBox_SameRules_CheckedChanged(object sender, EventArgs e)
        {

        }
        //end section for same rules


        // Section for damages
        private void CbBox_DamageTypeRace1_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.DamagesValuesRace1();
        }

        private void CbBox_DamageTypeRace2_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.DamagesValuesRace2();
        }

        private void CbBox_DamageTypeRace3_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.DamagesValuesRace3();
        }

        private void CbBox_DamageTypeRace4_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.DamagesValuesRace4();
        }

        private void CbBox_DamageTypeRace5_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.DamagesValuesRace5();
        }

        private void CbBox_DamageTypeRace6_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.DamagesValuesRace6();
        }

        private void CbBox_DamageTypeRace7_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.DamagesValuesRace7();
        }

        private void CbBox_DamageTypeRace8_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.DamagesValuesRace8();
        }

        //end Section for damages

        // section for tire wear
        private void CbBox_TireWearRace1_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.TireWearValuesRace1();
        }

        private void CbBox_TireWearRace2_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.TireWearValuesRace2();
        }

        private void CbBox_TireWearRace3_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.TireWearValuesRace3();
        }

        private void CbBox_TireWearRace4_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.TireWearValuesRace4();
        }

        private void CbBox_TireWearRace5_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.TireWearValuesRace5();
        }

        private void CbBox_TireWearRace6_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.TireWearValuesRace6();
        }

        private void CbBox_TireWearRace7_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.TireWearValuesRace7();
        }
        private void CbBox_TireWearRace8_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.TireWearValuesRace8();
        }
        

        //end Section for tires
        
        // Section for fuel
        private void CbBox_FuelUsageRace1_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.FuelUsageValuesRace1();
        }

        private void CbBox_FuelUsageRace2_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.FuelUsageValuesRace2();
        }

        private void CbBox_FuelUsageRace3_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.FuelUsageValuesRace3();
        }

        private void CbBox_FuelUsageRace4_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.FuelUsageValuesRace4();
        }

        private void CbBox_FuelUsageRace5_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.FuelUsageValuesRace5();
        }

        private void CbBox_FuelUsageRace6_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.FuelUsageValuesRace6();
        }

        private void CbBox_FuelUsageRace7_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.FuelUsageValuesRace7();
        }
        private void CbBox_FuelUsageRace8_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.FuelUsageValuesRace8();
        }
        // end of section fuel

        // Section Views
        private void CbBox_AllowedViewsRace1_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.ViewsValuesRace1();
        }

        private void CbBox_AllowedViewsRace2_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.ViewsValuesRace2();
        }

        private void CbBox_AllowedViewsRace3_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.ViewsValuesRace3();
        }

        private void CbBox_AllowedViewsRace4_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.ViewsValuesRace4();
        }

        private void CbBox_AllowedViewsRace5_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.ViewsValuesRace5();
        }

        private void CbBox_AllowedViewsRace6_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.ViewsValuesRace6();
        }

        private void CbBox_AllowedViewsRace7_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.ViewsValuesRace7();
        }

        private void CbBox_AllowedViewsRace8_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.ViewsValuesRace8();
        }
        //End section Views
        
        //Section Weather
        private void CbBox_PracticeWeatherSlot1Race1_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.PracticeWeatherSlot1Race1();
        }

        private void CbBox_PracticeWeatherSlot2Race1_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.PracticeWeatherSlot2Race1();
        }

        private void CbBox_PracticeWeatherSlot3Race1_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.PracticeWeatherSlot3Race1();
        }

        private void CbBox_PracticeWeatherSlot4Race1_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.PracticeWeatherSlot4Race1();
        }

        private void CbBox_QualifWeatherSlot1Race1_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.QualifyWeatherSlot1Race1();
        }

        private void CbBox_QualifWeatherSlot2Race1_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.QualifyWeatherSlot2Race1();
        }

        private void CbBox_QualifWeatherSlot3Race1_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.QualifyWeatherSlot3Race1();
        }

        private void CbBox_QualifWeatherSlot4Race1_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.QualifyWeatherSlot4Race1();
        }

        private void CbBox_RaceWeatherSlot1Race1_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.RaceWeatherSlot1Race1();
        }

        private void CbBox_RaceWeatherSlot2Race1_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.RaceWeatherSlot2Race1();
        }

        private void CbBox_RaceWeatherSlot3Race1_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.RaceWeatherSlot3Race1();
        }

        private void CbBox_RaceWeatherSlot4Race1_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueControl.RaceWeatherSlot4Race1();
        }
    }
}
