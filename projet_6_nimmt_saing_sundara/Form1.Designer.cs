namespace projet_6_nimmt_saing_sundara
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btNewGame = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btChargeGame = new System.Windows.Forms.Button();
            this.pb6nimmt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb6nimmt)).BeginInit();
            this.SuspendLayout();
            // 
            // btNewGame
            // 
            this.btNewGame.Location = new System.Drawing.Point(427, 96);
            this.btNewGame.Name = "btNewGame";
            this.btNewGame.Size = new System.Drawing.Size(130, 50);
            this.btNewGame.TabIndex = 0;
            this.btNewGame.Text = "Nouvelle partie";
            this.btNewGame.UseVisualStyleBackColor = true;
            this.btNewGame.Click += new System.EventHandler(this.btNewGame_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(427, 369);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(130, 50);
            this.btExit.TabIndex = 1;
            this.btExit.Text = "Quitter";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btChargeGame
            // 
            this.btChargeGame.Enabled = false;
            this.btChargeGame.Location = new System.Drawing.Point(427, 233);
            this.btChargeGame.Name = "btChargeGame";
            this.btChargeGame.Size = new System.Drawing.Size(130, 50);
            this.btChargeGame.TabIndex = 2;
            this.btChargeGame.Text = "Charger une partie";
            this.btChargeGame.UseVisualStyleBackColor = true;
            this.btChargeGame.Click += new System.EventHandler(this.btChargeGame_Click);
            // 
            // pb6nimmt
            // 
            this.pb6nimmt.Image = global::projet_6_nimmt_saing_sundara.Properties.Resources._6_nimmt;
            this.pb6nimmt.Location = new System.Drawing.Point(12, 12);
            this.pb6nimmt.Name = "pb6nimmt";
            this.pb6nimmt.Size = new System.Drawing.Size(364, 492);
            this.pb6nimmt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb6nimmt.TabIndex = 3;
            this.pb6nimmt.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 516);
            this.Controls.Add(this.btNewGame);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btChargeGame);
            this.Controls.Add(this.pb6nimmt);
            this.Name = "Form1";
            this.Text = "6 nimmt !";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb6nimmt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btNewGame;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btChargeGame;
        private System.Windows.Forms.PictureBox pb6nimmt;
    }
}

