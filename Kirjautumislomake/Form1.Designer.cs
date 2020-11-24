
namespace Kirjautumislomake
{
    partial class Form1
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
            this.Kirjautumislomake = new System.Windows.Forms.Label();
            this.kayttajaLB = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kayttajaTB = new System.Windows.Forms.TextBox();
            this.salasanaLB = new System.Windows.Forms.Label();
            this.salasanaTB = new System.Windows.Forms.TextBox();
            this.kirjaudu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Kirjautumislomake
            // 
            this.Kirjautumislomake.AutoSize = true;
            this.Kirjautumislomake.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kirjautumislomake.Location = new System.Drawing.Point(208, 60);
            this.Kirjautumislomake.Name = "Kirjautumislomake";
            this.Kirjautumislomake.Size = new System.Drawing.Size(235, 31);
            this.Kirjautumislomake.TabIndex = 0;
            this.Kirjautumislomake.Text = "Kirjautumislomake";
            // 
            // kayttajaLB
            // 
            this.kayttajaLB.AutoSize = true;
            this.kayttajaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayttajaLB.Location = new System.Drawing.Point(196, 199);
            this.kayttajaLB.Name = "kayttajaLB";
            this.kayttajaLB.Size = new System.Drawing.Size(130, 24);
            this.kayttajaLB.TabIndex = 1;
            this.kayttajaLB.Text = "Käyttäjätunnus";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(304, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // kayttajaTB
            // 
            this.kayttajaTB.Location = new System.Drawing.Point(373, 199);
            this.kayttajaTB.Name = "kayttajaTB";
            this.kayttajaTB.Size = new System.Drawing.Size(100, 20);
            this.kayttajaTB.TabIndex = 3;
            // 
            // salasanaLB
            // 
            this.salasanaLB.AutoSize = true;
            this.salasanaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salasanaLB.Location = new System.Drawing.Point(196, 244);
            this.salasanaLB.Name = "salasanaLB";
            this.salasanaLB.Size = new System.Drawing.Size(86, 24);
            this.salasanaLB.TabIndex = 4;
            this.salasanaLB.Text = "Salasana";
            // 
            // salasanaTB
            // 
            this.salasanaTB.Location = new System.Drawing.Point(373, 249);
            this.salasanaTB.Name = "salasanaTB";
            this.salasanaTB.Size = new System.Drawing.Size(100, 20);
            this.salasanaTB.TabIndex = 5;
            // 
            // kirjaudu
            // 
            this.kirjaudu.Location = new System.Drawing.Point(394, 316);
            this.kirjaudu.Name = "kirjaudu";
            this.kirjaudu.Size = new System.Drawing.Size(75, 23);
            this.kirjaudu.TabIndex = 6;
            this.kirjaudu.Text = "Kirjaudu";
            this.kirjaudu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 411);
            this.Controls.Add(this.kirjaudu);
            this.Controls.Add(this.salasanaTB);
            this.Controls.Add(this.salasanaLB);
            this.Controls.Add(this.kayttajaTB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kayttajaLB);
            this.Controls.Add(this.Kirjautumislomake);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Kirjautumislomake;
        private System.Windows.Forms.Label kayttajaLB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox kayttajaTB;
        private System.Windows.Forms.Label salasanaLB;
        private System.Windows.Forms.TextBox salasanaTB;
        private System.Windows.Forms.Button kirjaudu;
    }
}

