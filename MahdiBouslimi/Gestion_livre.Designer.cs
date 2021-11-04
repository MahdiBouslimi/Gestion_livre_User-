namespace MahdiBouslimi
{
    partial class Gestion_livre
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titre_Livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autheur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annee_de_sortier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type_livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iditeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.Titre_Livre,
            this.Autheur,
            this.annee_de_sortier,
            this.Type_livre,
            this.Iditeur});
            this.dataGridView1.Location = new System.Drawing.Point(23, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(650, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            // 
            // Titre_Livre
            // 
            this.Titre_Livre.HeaderText = "Titre";
            this.Titre_Livre.Name = "Titre_Livre";
            // 
            // Autheur
            // 
            this.Autheur.HeaderText = "Autheur";
            this.Autheur.Name = "Autheur";
            // 
            // annee_de_sortier
            // 
            this.annee_de_sortier.HeaderText = "annee_sortie";
            this.annee_de_sortier.Name = "annee_de_sortier";
            // 
            // Type_livre
            // 
            this.Type_livre.HeaderText = "type";
            this.Type_livre.Name = "Type_livre";
            // 
            // Iditeur
            // 
            this.Iditeur.HeaderText = "Iditeur";
            this.Iditeur.Name = "Iditeur";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(232, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "supprimer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(23, 312);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouter.TabIndex = 5;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click_1);
            // 
            // Gestion_livre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_ajouter);
            this.Name = "Gestion_livre";
            this.Text = "Gestion_livre";
            this.Load += new System.EventHandler(this.Gestion_livre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titre_Livre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autheur;
        private System.Windows.Forms.DataGridViewTextBoxColumn annee_de_sortier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type_livre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iditeur;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_ajouter;

    }
}