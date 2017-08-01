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
    public partial class PlayersName : Form
    {
        Form1 pageForm1;
        NewGame pageNewGame;
        Game pageGame;

        public PlayersName(Form1 unePageForm1, NewGame unePageNewGame)
        {
            InitializeComponent();
            pageForm1 = unePageForm1;
            pageNewGame = unePageNewGame;
            pageGame = new Game(pageForm1);
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            if(tbNom.Text != "")
            {
                this.Hide();
                pageNewGame.Hide();
                pageGame.Show();
            }
            else
            {
                MessageBox.Show("Veuillez saisir votre nom !");
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
