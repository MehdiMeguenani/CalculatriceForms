
namespace Calculatrice_Simplfifié
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
            this.TBXNb1 = new System.Windows.Forms.TextBox();
            this.TBXNb2 = new System.Windows.Forms.TextBox();
            this.BTNAddition = new System.Windows.Forms.Button();
            this.BTNSoustraction = new System.Windows.Forms.Button();
            this.BTNMulti = new System.Windows.Forms.Button();
            this.BTNDiv = new System.Windows.Forms.Button();
            this.LABResultat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBXNb1
            // 
            this.TBXNb1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TBXNb1.Location = new System.Drawing.Point(50, 39);
            this.TBXNb1.Name = "TBXNb1";
            this.TBXNb1.Size = new System.Drawing.Size(129, 20);
            this.TBXNb1.TabIndex = 0;
            this.TBXNb1.Text = "Entrez un premier Nombre";
            this.TBXNb1.Click += new System.EventHandler(this.TBXNb1_TextChanged);
            // 
            // TBXNb2
            // 
            this.TBXNb2.Location = new System.Drawing.Point(50, 91);
            this.TBXNb2.Name = "TBXNb2";
            this.TBXNb2.Size = new System.Drawing.Size(129, 20);
            this.TBXNb2.TabIndex = 1;
            this.TBXNb2.Text = "Entrez un second Nombre";
            this.TBXNb2.Click += new System.EventHandler(this.TBXNb2_TextChanged);
            // 
            // BTNAddition
            // 
            this.BTNAddition.Location = new System.Drawing.Point(252, 39);
            this.BTNAddition.Name = "BTNAddition";
            this.BTNAddition.Size = new System.Drawing.Size(39, 29);
            this.BTNAddition.TabIndex = 2;
            this.BTNAddition.Text = "+";
            this.BTNAddition.UseVisualStyleBackColor = true;
            this.BTNAddition.Click += new System.EventHandler(this.BTNAddition_Click);
            // 
            // BTNSoustraction
            // 
            this.BTNSoustraction.Location = new System.Drawing.Point(252, 82);
            this.BTNSoustraction.Name = "BTNSoustraction";
            this.BTNSoustraction.Size = new System.Drawing.Size(39, 29);
            this.BTNSoustraction.TabIndex = 3;
            this.BTNSoustraction.Text = "-";
            this.BTNSoustraction.UseVisualStyleBackColor = true;
            this.BTNSoustraction.Click += new System.EventHandler(this.BTNSoustraction_Click);
            // 
            // BTNMulti
            // 
            this.BTNMulti.Location = new System.Drawing.Point(333, 39);
            this.BTNMulti.Name = "BTNMulti";
            this.BTNMulti.Size = new System.Drawing.Size(39, 29);
            this.BTNMulti.TabIndex = 5;
            this.BTNMulti.Text = "*";
            this.BTNMulti.UseVisualStyleBackColor = true;
            this.BTNMulti.Click += new System.EventHandler(this.BTNMulti_Click);
            // 
            // BTNDiv
            // 
            this.BTNDiv.Location = new System.Drawing.Point(333, 82);
            this.BTNDiv.Name = "BTNDiv";
            this.BTNDiv.Size = new System.Drawing.Size(39, 29);
            this.BTNDiv.TabIndex = 6;
            this.BTNDiv.Text = "/";
            this.BTNDiv.UseVisualStyleBackColor = true;
            this.BTNDiv.Click += new System.EventHandler(this.BTNDiv_Click);
            // 
            // LABResultat
            // 
            this.LABResultat.AutoSize = true;
            this.LABResultat.Location = new System.Drawing.Point(47, 136);
            this.LABResultat.Name = "LABResultat";
            this.LABResultat.Size = new System.Drawing.Size(137, 13);
            this.LABResultat.TabIndex = 7;
            this.LABResultat.Text = "Résultat de votre Opération";
            this.LABResultat.Click += new System.EventHandler(this.LABResultat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 172);
            this.Controls.Add(this.LABResultat);
            this.Controls.Add(this.BTNDiv);
            this.Controls.Add(this.BTNMulti);
            this.Controls.Add(this.BTNSoustraction);
            this.Controls.Add(this.BTNAddition);
            this.Controls.Add(this.TBXNb2);
            this.Controls.Add(this.TBXNb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBXNb1;
        private System.Windows.Forms.TextBox TBXNb2;
        private System.Windows.Forms.Button BTNAddition;
        private System.Windows.Forms.Button BTNSoustraction;
        private System.Windows.Forms.Button BTNMulti;
        private System.Windows.Forms.Button BTNDiv;
        private System.Windows.Forms.Label LABResultat;
    }
}

