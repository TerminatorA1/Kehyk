
namespace Hotellisysteemi
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hallitseAsiakkaitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hallitseHuoneitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hallitseVarauksiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lisävalikkoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hallitseAsiakkaitaToolStripMenuItem,
            this.hallitseHuoneitaToolStripMenuItem,
            this.hallitseVarauksiaToolStripMenuItem,
            this.lisävalikkoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hallitseAsiakkaitaToolStripMenuItem
            // 
            this.hallitseAsiakkaitaToolStripMenuItem.Name = "hallitseAsiakkaitaToolStripMenuItem";
            this.hallitseAsiakkaitaToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.hallitseAsiakkaitaToolStripMenuItem.Text = "Hallitse Asiakkaita";
            this.hallitseAsiakkaitaToolStripMenuItem.Click += new System.EventHandler(this.hallitseAsiakkaitaToolStripMenuItem_Click);
            // 
            // hallitseHuoneitaToolStripMenuItem
            // 
            this.hallitseHuoneitaToolStripMenuItem.Name = "hallitseHuoneitaToolStripMenuItem";
            this.hallitseHuoneitaToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.hallitseHuoneitaToolStripMenuItem.Text = "Hallitse Huoneita";
            this.hallitseHuoneitaToolStripMenuItem.Click += new System.EventHandler(this.hallitseHuoneitaToolStripMenuItem_Click);
            // 
            // hallitseVarauksiaToolStripMenuItem
            // 
            this.hallitseVarauksiaToolStripMenuItem.Name = "hallitseVarauksiaToolStripMenuItem";
            this.hallitseVarauksiaToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.hallitseVarauksiaToolStripMenuItem.Text = "Hallitse Varauksia";
            this.hallitseVarauksiaToolStripMenuItem.Click += new System.EventHandler(this.hallitseVarauksiaToolStripMenuItem_Click);
            // 
            // lisävalikkoToolStripMenuItem
            // 
            this.lisävalikkoToolStripMenuItem.Name = "lisävalikkoToolStripMenuItem";
            this.lisävalikkoToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.lisävalikkoToolStripMenuItem.Text = "Poistu Ohjelmasta";
            this.lisävalikkoToolStripMenuItem.Click += new System.EventHandler(this.lisävalikkoToolStripMenuItem_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hotellisysteemi.Properties.Resources.gorgeous_hotel_room_picture_167661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Form";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hallitseAsiakkaitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hallitseHuoneitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hallitseVarauksiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lisävalikkoToolStripMenuItem;
    }
}