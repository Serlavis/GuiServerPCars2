using System.IO;
using System.Windows.Forms;

namespace GuiServerPCars2V2._0
{
    /// <summary>
    /// this class verifies that the chosen folder contains the executable of the server.
    /// If everything is ok it opens the next window otherwise it returns an error message.
    /// </summary>
    class OpenForm2
    {

        public string serverLocation = "";
        

        public void Verification()
        {
           
            {
                if (File.Exists(serverLocation + "\\DedicatedServerCmd.exe"))
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                    Form1.choiceServer.Hide();
                }
                else
                {
                    MessageBox.Show("executable du serveur introuvable", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }

}
