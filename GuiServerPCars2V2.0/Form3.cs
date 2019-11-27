using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GuiServerPCars2V2._0
{
    public partial class Form3 : Form
    {
        public static Form3 dialWindow;
        
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dialWindow = this;
            
        }

        private void Button_Yes_Click(object sender, EventArgs e)
        {
            string data = Form1.workFolder + "\\lua_config\\sms_stats_data.json";
            
            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "backup Data"));
           if (File.Exists(data))
            {
                string backup =  Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)) + "\\backup Data\\" + DateTime.Now.ToString(" yyyy_MM_dd_HH") + "h" + DateTime.Now.ToString("mm") + ".json";
                MessageBox.Show(backup);
                File.Move(data, backup);
                File.Delete(data);
            }
            Form2.mainWindow.Enabled = true;
            this.Close();
        }

        private void Button_No_Click(object sender, EventArgs e)
        {
            Form2.mainWindow.Enabled = true;
            this.Close();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2.mainWindow.Enabled = true;
        }
    }
}
