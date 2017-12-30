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
        public Inquisitor()
        {
            InitializeComponent();
        }

        private void Inquisitor_Load(object sender, EventArgs e)
        {
            nupLv3.Value = (1 + (nupLevel.Value / 5));
            nupLv5.Value = (1 + (nupLevel.Value / 3));
        }
    }
}
