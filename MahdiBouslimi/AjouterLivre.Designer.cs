namespace MahdiBouslimi
{
    partial class AjouterLivre
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
            this.txt_isbn = new System.Windows.Forms.TextBox();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.txt_iditeur = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.TextBox();
            this.txt_annee = new System.Windows.Forms.TextBox();
            this.txt_autheur = new System.Windows.Forms.TextBox();
            this.txt_titre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_isbn
            // 
            this.txt_isbn.Location = new System.Drawing.Point(225, 73);
            this.txt_isbn.Name = "txt_isbn";
            this.txt_isbn.Size = new System.Drawing.Size(114, 20);
            this.txt_isbn.TabIndex = 26;
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Location = new System.Drawing.Point(86, 354);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(259, 23);
            this.btn_Ajouter.TabIndex = 25;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // txt_iditeur
            // 
            this.txt_iditeur.Location = new System.Drawing.Point(225, 287);
            this.txt_iditeur.Name = "txt_iditeur";
            this.txt_iditeur.Size = new System.Drawing.Size(120, 20);
            this.txt_iditeur.TabIndex = 24;
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(225, 248);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(120, 20);
            this.type.TabIndex = 23;
            // 
            // txt_annee
            // 
            this.txt_annee.Location = new System.Drawing.Point(225, 201);
            this.txt_annee.Name = "txt_annee";
            this.txt_annee.Size = new System.Drawing.Size(120, 20);
            this.txt_annee.TabIndex = 22;
            // 
            // txt_autheur
            // 
            this.txt_autheur.Location = new System.Drawing.Point(225, 151);
            this.txt_autheur.Name = "txt_autheur";
            this.txt_autheur.Size = new System.Drawing.Size(120, 20);
            this.txt_autheur.TabIndex = 21;
            // 
            // txt_titre
            // 
            this.txt_titre.Location = new System.Drawing.Point(225, 118);
            this.txt_titre.Name = "txt_titre";
            this.txt_titre.Size = new System.Drawing.Size(120, 20);
            this.txt_titre.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Iditeur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Annéee_sortier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Autheur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Titre_Livre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "ISBN";
            // 
            // AjouterLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 451);
            this.Controls.Add(this.txt_isbn);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.txt_iditeur);
            this.Controls.Add(this.type);
            this.Controls.Add(this.txt_annee);
            this.Controls.Add(this.txt_autheur);
            this.Controls.Add(this.txt_titre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AjouterLivre";
            this.Text = "AjouterLivre";
            this.Load += new System.EventHandler(this.AjouterLivre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_isbn;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.TextBox txt_iditeur;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.TextBox txt_annee;
        private System.Windows.Forms.TextBox txt_autheur;
        private System.Windows.Forms.TextBox txt_titre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}