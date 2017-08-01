namespace projet_6_nimmt_saing_sundara
{
    partial class Game
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
            this.btAccueil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAccueil
            // 
            this.btAccueil.Location = new System.Drawing.Point(401, 352);
            this.btAccueil.Name = "btAccueil";
            this.btAccueil.Size = new System.Drawing.Size(155, 23);
            this.btAccueil.TabIndex = 0;
            this.btAccueil.Text = "Retour à la page d\'accueil";
            this.btAccueil.UseVisualStyleBackColor = true;
            this.btAccueil.Click += new System.EventHandler(this.btAccueil_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 387);
            this.Controls.Add(this.btAccueil);
            this.Name = "Game";
            this.Text = "Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAccueil;
    }
}