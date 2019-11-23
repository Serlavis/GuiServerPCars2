using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiServerPCars2V2._0
{
    class DamagesList
    {
        
        readonly public List<Damages> damages1 = new List<Damages>();
        readonly public List<Damages> damages2 = new List<Damages>();
        readonly public List<Damages> damages3 = new List<Damages>();
        readonly public List<Damages> damages4 = new List<Damages>();
        readonly public List<Damages> damages5 = new List<Damages>();
        readonly public List<Damages> damages6 = new List<Damages>();
        readonly public List<Damages> damages7 = new List<Damages>();
        readonly public List<Damages> damages8 = new List<Damages>();

        public void FillCbBoxDamage1()
        {
            damages1.Add(new Damages() { Name = "OFF", Trad = "Non" });
            damages1.Add(new Damages() { Name = "VISUAL_ONLY", Trad = "Visuel Uniquement" });
            damages1.Add(new Damages() { Name = "PERFORMANCEIMPACTING", Trad = "Impact sur les performances" });
            damages1.Add(new Damages() { Name = "FULL", Trad = "Complet" });

            Form2.mainWindow.CbBox_DamageTypeRace1.DataSource = damages1;
            Form2.mainWindow.CbBox_DamageTypeRace1.DisplayMember = "Trad";
            
        }
    }
}
