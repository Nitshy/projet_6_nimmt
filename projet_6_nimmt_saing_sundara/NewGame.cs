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
    public partial class NewGame : Form
    {
        Form1 pageForm1;
        PlayersName pagePlayersName;

        public NewGame(Form1 unePageForm1)
        {
            InitializeComponent();
            pageForm1 = unePageForm1;
            pagePlayersName = new PlayersName(pageForm1, this);
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            pageForm1.Show();
            this.Hide();
        }

        private void NewGame_Load(object sender, EventArgs e)
        {
            lbNbJoueurs.SelectedItem = lbNbJoueurs.Items[0];
        }

        private void btValidate_Click(object sender, EventArgs e)
        {
            pagePlayersName.ShowDialog();

        }

    }
}
