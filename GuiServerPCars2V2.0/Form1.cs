using System;
using System.Windows.Forms;
using System.Threading;

namespace GuiServerPCars2V2._0
{
    public partial class Form1 : Form
    {

         
        public static Form1 choiceServer;
        public static int serverNumber = 0;
        public static string workFolder = "";
        private readonly ValuesLoad valuesLoad = new ValuesLoad();
        private readonly ValuesSave valuesSave = new ValuesSave();
        private readonly LocateFolder locateFolder = new LocateFolder();
        private readonly OpenForm2 openForm2 = new OpenForm2();

        public Form1()
        {         
            InitializeComponent();
            choiceServer = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // We recover the paths in the backup file
            valuesLoad.Load_Folder_Loaction();
        }

        private void PicBx_Server1_Click(object sender, EventArgs e)
        {
            // We choose the folder where the executable "Dedicated Server Cmd.exe" is located
            locateFolder.Choice_Folder();
            TxtBx_Server1.Text = locateFolder.folderLocation;
            valuesSave.Save_Folder_Location();
        }

        private void PicBx_Server2_Click(object sender, EventArgs e)
        {
            // We choose the folder where the executable "Dedicated Server Cmd.exe" is located
            locateFolder.Choice_Folder();
            TxtBx_Server2.Text = locateFolder.folderLocation;
            valuesSave.Save_Folder_Location();
        }

        private void PicBx_Server3_Click(object sender, EventArgs e)
        {
            // We choose the folder where the executable "Dedicated Server Cmd.exe" is located
            locateFolder.Choice_Folder();
            TxtBx_Server3.Text = locateFolder.folderLocation;
            valuesSave.Save_Folder_Location();
        }

        private void PicBx_Server4_Click(object sender, EventArgs e)
        {
            // We choose the folder where the executable "Dedicated Server Cmd.exe" is located
            locateFolder.Choice_Folder();
            TxtBx_Server4.Text = locateFolder.folderLocation;
            valuesSave.Save_Folder_Location();
        }

        private void PicBx_Server5_Click(object sender, EventArgs e)
        {
            // We choose the folder where the executable "Dedicated Server Cmd.exe" is located
            locateFolder.Choice_Folder();
            TxtBx_Server5.Text = locateFolder.folderLocation;
            valuesSave.Save_Folder_Location();
        }

        private void PicBx_Server6_Click(object sender, EventArgs e)
        {
            // We choose the folder where the executable "Dedicated Server Cmd.exe" is located
            locateFolder.Choice_Folder();
            TxtBx_Server6.Text = locateFolder.folderLocation;
            valuesSave.Save_Folder_Location();
        }

        private void Btn_Server1_Click(object sender, EventArgs e)
        {
            openForm2.serverLocation = TxtBx_Server1.Text;
            serverNumber = 1;
            openForm2.Verification();
            workFolder = TxtBx_Server1.Text;
            valuesLoad.Dispose();
        }

        private void Btn_Server2_Click(object sender, EventArgs e)
        {
            openForm2.serverLocation = TxtBx_Server2.Text;
            serverNumber = 2;
            openForm2.Verification();
            workFolder = TxtBx_Server2.Text;
            valuesLoad.Dispose();
        }

        private void Btn_Server3_Click(object sender, EventArgs e)
        {
            openForm2.serverLocation = TxtBx_Server3.Text;
            serverNumber = 3;
            openForm2.Verification();
            workFolder = TxtBx_Server3.Text;
            valuesLoad.Dispose();
        }

        private void Btn_Server4_Click(object sender, EventArgs e)
        {
            openForm2.serverLocation = TxtBx_Server4.Text;
            serverNumber = 4;
            openForm2.Verification();
            workFolder = TxtBx_Server4.Text;
            valuesLoad.Dispose();
        }

        private void Btn_Server5_Click(object sender, EventArgs e)
        {
            openForm2.serverLocation = TxtBx_Server5.Text;
            serverNumber = 5;
            openForm2.Verification();
            workFolder = TxtBx_Server5.Text;
            valuesLoad.Dispose();
        }

        private void Btn_Server6_Click(object sender, EventArgs e)
        {
            openForm2.serverLocation = TxtBx_Server6.Text;
            serverNumber = 6;
            openForm2.Verification();
            workFolder = TxtBx_Server6.Text;
            valuesLoad.Dispose();
        }
    }
}
