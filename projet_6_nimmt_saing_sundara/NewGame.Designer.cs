namespace projet_6_nimmt_saing_sundara
{
    partial class NewGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btBack = new System.Windows.Forms.Button();
            this.btValidate = new System.Windows.Forms.Button();
            this.labelNbJoueurs = new System.Windows.Forms.Label();
            this.lbNbJoueurs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(202, 161);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(75, 23);
            this.btBack.TabIndex = 0;
            this.btBack.Text = "Retour";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btValidate
            // 
            this.btValidate.Location = new System.Drawing.Point(121, 161);
            this.btValidate.Name = "btValidate";
            this.btValidate.Size = new System.Drawing.Size(75, 23);
            this.btValidate.TabIndex = 1;
            this.btValidate.Text = "Valider";
            this.btValidate.UseVisualStyleBackColor = true;
            this.btValidate.Click += new System.EventHandler(this.btValidate_Click);
            // 
            // labelNbJoueurs
            // 
            this.labelNbJoueurs.AutoSize = true;
            this.labelNbJoueurs.Location = new System.Drawing.Point(12, 9);
            this.labelNbJoueurs.Name = "labelNbJoueurs";
            this.labelNbJoueurs.Size = new System.Drawing.Size(102, 13);
            this.labelNbJoueurs.TabIndex = 2;
            this.labelNbJoueurs.Text = "Nombre de joueurs :";
            // 
            // lbNbJoueurs
            // 
            this.lbNbJoueurs.FormattingEnabled = true;
            this.lbNbJoueurs.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.lbNbJoueurs.Location = new System.Drawing.Point(15, 25);
            this.lbNbJoueurs.Name = "lbNbJoueurs";
            this.lbNbJoueurs.Size = new System.Drawing.Size(99, 121);
            this.lbNbJoueurs.TabIndex = 3;
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 196);
            this.Controls.Add(this.lbNbJoueurs);
            this.Controls.Add(this.labelNbJoueurs);
            this.Controls.Add(this.btValidate);
            this.Controls.Add(this.btBack);
            this.Name = "NewGame";
            this.Text = "Nouvelle partie";
            this.Load += new System.EventHandler(this.NewGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btValidate;
        private System.Windows.Forms.Label labelNbJoueurs;
        private System.Windows.Forms.ListBox lbNbJoueurs;
    }
}