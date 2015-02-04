namespace GestionCliniqueVeteriniaire
{
    partial class Veterinaires
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAjouterVeto = new System.Windows.Forms.Button();
            this.btnSupprimerVeto = new System.Windows.Forms.Button();
            this.btnReinitVeto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 90);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(436, 368);
            this.listBox1.TabIndex = 0;
            // 
            // btnAjouterVeto
            // 
            this.btnAjouterVeto.Location = new System.Drawing.Point(12, 42);
            this.btnAjouterVeto.Name = "btnAjouterVeto";
            this.btnAjouterVeto.Size = new System.Drawing.Size(110, 32);
            this.btnAjouterVeto.TabIndex = 1;
            this.btnAjouterVeto.Text = "Ajouter";
            this.btnAjouterVeto.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerVeto
            // 
            this.btnSupprimerVeto.Location = new System.Drawing.Point(175, 42);
            this.btnSupprimerVeto.Name = "btnSupprimerVeto";
            this.btnSupprimerVeto.Size = new System.Drawing.Size(110, 32);
            this.btnSupprimerVeto.TabIndex = 2;
            this.btnSupprimerVeto.Text = "Supprimer";
            this.btnSupprimerVeto.UseVisualStyleBackColor = true;
            // 
            // btnReinitVeto
            // 
            this.btnReinitVeto.Location = new System.Drawing.Point(338, 42);
            this.btnReinitVeto.Name = "btnReinitVeto";
            this.btnReinitVeto.Size = new System.Drawing.Size(110, 32);
            this.btnReinitVeto.TabIndex = 3;
            this.btnReinitVeto.Text = "Reinitialiser";
            this.btnReinitVeto.UseVisualStyleBackColor = true;
            // 
            // Veterinaires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 470);
            this.Controls.Add(this.btnReinitVeto);
            this.Controls.Add(this.btnSupprimerVeto);
            this.Controls.Add(this.btnAjouterVeto);
            this.Controls.Add(this.listBox1);
            this.Name = "Veterinaires";
            this.Text = "Veterinaires";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAjouterVeto;
        private System.Windows.Forms.Button btnSupprimerVeto;
        private System.Windows.Forms.Button btnReinitVeto;
    }
}