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

namespace projet_6_nimmt_saing_sundara
{
    public partial class Form1 : Form
    {
        NewGame pageNewGame;

        public Form1()
        {
            InitializeComponent();
            pageNewGame = new NewGame(this);
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(File.Exists(Application.StartupPath + "donneesPartieEnCours.txt") == true)
            {
                btChargeGame.Enabled = true;
            }
        }

        private void btChargeGame_Click(object sender, EventArgs e)
        {
            DialogResult chargerPartie = MessageBox.Show("La dernière partie en cours va être chargée", "Message administrateur", MessageBoxButtons.OKCancel);
            if(chargerPartie == DialogResult.OK)
            {
                //ouverture fenêtre
            }
        }

        private void btNewGame_Click(object sender, EventArgs e)
        {
            //à optimiser ( on vérifie 2 fois que le fichier existe ) 
            if(File.Exists(Application.StartupPath + "donneesPartieEnCours.txt") == true)
            {
                DialogResult nouvellePartie = MessageBox.Show("Une partie en cours a été trouvée. Etes-vous sûr de vouloir démarrer une nouvelle partie ?", "Message administrateur", MessageBoxButtons.YesNo);
                if(nouvellePartie == DialogResult.Yes)
                {
                    pageNewGame.Show();
                    this.Hide();
                }
            }
            else
            {
                pageNewGame.Show();
                this.Hide();
            }
        }

    }
}
