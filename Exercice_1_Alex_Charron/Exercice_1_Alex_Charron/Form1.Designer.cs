namespace Exercice_1_Alex_Charron
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
            this.txtType = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtValeur = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtType
            // 
            this.txtType.AutoSize = true;
            this.txtType.Location = new System.Drawing.Point(8, 9);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(67, 13);
            this.txtType.TabIndex = 0;
            this.txtType.Text = "Type du dé: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Brasser un nouveau dé";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtValeur
            // 
            this.txtValeur.AutoSize = true;
            this.txtValeur.Location = new System.Drawing.Point(2, 35);
            this.txtValeur.Name = "txtValeur";
            this.txtValeur.Size = new System.Drawing.Size(73, 13);
            this.txtValeur.TabIndex = 2;
            this.txtValeur.Text = "Valeur du dé: ";
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Location = new System.Drawing.Point(38, 63);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(37, 13);
            this.txtTotal.TabIndex = 3;
            this.txtTotal.Text = "Total: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(147, 122);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtValeur);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Exercice 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtValeur;
        private System.Windows.Forms.Label txtTotal;
    }
}

