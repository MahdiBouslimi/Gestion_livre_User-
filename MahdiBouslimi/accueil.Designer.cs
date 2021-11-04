namespace MahdiBouslimi
{
    partial class accueil
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mDIFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionLivreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authentificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mDIFormToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mDIFormToolStripMenuItem
            // 
            this.mDIFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionLivreToolStripMenuItem,
            this.authentificationToolStripMenuItem});
            this.mDIFormToolStripMenuItem.Name = "mDIFormToolStripMenuItem";
            this.mDIFormToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.mDIFormToolStripMenuItem.Text = "MDI_Form";
            // 
            // gestionLivreToolStripMenuItem
            // 
            this.gestionLivreToolStripMenuItem.Name = "gestionLivreToolStripMenuItem";
            this.gestionLivreToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.gestionLivreToolStripMenuItem.Text = "Gestion_Livre";
            this.gestionLivreToolStripMenuItem.Click += new System.EventHandler(this.gestionLivreToolStripMenuItem_Click_1);
            // 
            // authentificationToolStripMenuItem
            // 
            this.authentificationToolStripMenuItem.Name = "authentificationToolStripMenuItem";
            this.authentificationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.authentificationToolStripMenuItem.Text = "Gestion_User";
            this.authentificationToolStripMenuItem.Click += new System.EventHandler(this.authentificationToolStripMenuItem_Click_1);
            // 
            // accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.Name = "accueil";
            this.Text = "accueil";
            this.Load += new System.EventHandler(this.accueil_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mDIFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionLivreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authentificationToolStripMenuItem;
    }
}