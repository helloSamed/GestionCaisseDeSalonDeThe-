namespace GestionCaisseDeSalonDeThé
{
    partial class GestionServeurs
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Elephant", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.Location = new System.Drawing.Point(167, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(408, 55);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "Gestion des serveurs :";
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::GestionCaisseDeSalonDeThé.Properties.Resources._55;
            this.button5.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button5.Location = new System.Drawing.Point(442, 274);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 128);
            this.button5.TabIndex = 21;
            this.button5.Text = "supprimer un serveur";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::GestionCaisseDeSalonDeThé.Properties.Resources._55;
            this.button4.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Location = new System.Drawing.Point(167, 274);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 128);
            this.button4.TabIndex = 20;
            this.button4.Text = "Lister les serveurs";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::GestionCaisseDeSalonDeThé.Properties.Resources._55;
            this.button2.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(445, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 128);
            this.button2.TabIndex = 18;
            this.button2.Text = "Rechercher   un serveur";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::GestionCaisseDeSalonDeThé.Properties.Resources._55;
            this.button1.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(167, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 128);
            this.button1.TabIndex = 17;
            this.button1.Text = "Ajouter un serveur";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GestionServeurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 538);
            //this.Controls.Add(this.button5);
            //this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "GestionServeurs";
            this.Text = "GestionServeurs";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.GestionServeurs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}