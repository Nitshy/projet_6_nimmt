using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_6_nimmt_saing_sundara
{
    public partial class Game : Form
    {
        Form1 pageForm1;

        public Game(Form1 unePageForm1)
        {
            InitializeComponent();
            pageForm1 = unePageForm1;
        }

        private void btAccueil_Click(object sender, EventArgs e)
        {
            this.Hide();
            pageForm1.Show();
        }
    }
}
