using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inquisitor
{
    public partial class Inquisitor : Form
    {
        int Lvl3Bonus;
        int Lvl5Bonus;


        public Inquisitor()
        {
            InitializeComponent();
        }

        private void Inquisitor_Load(object sender, EventArgs e)
        {
            Lvl3Bonus = (int)(1 + (nupLevel.Value / 5));
            Lvl5Bonus = (int)(1 + (nupLevel.Value / 3));
            nupLv3.Value = Lvl3Bonus;
            nupLv5.Value = Lvl5Bonus;
        }

        public int D(int Die)
        {
            Random rnd = new Random();
            int max = Die + 1;
            int dice = rnd.Next(1, max);
            return dice;
        }

        private void btnD20_Click(object sender, EventArgs e)
        {
            txtD20.Text = (D(20)).ToString();
        }
    }
}
