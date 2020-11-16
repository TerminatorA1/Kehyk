
namespace WindowsFormsApp1
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
            this.EtusivuPainike = new System.Windows.Forms.Button();
            this.TekstiTahan = new System.Windows.Forms.Label();
            this.Tekstilaatikko = new System.Windows.Forms.TextBox();
            this.ViestiLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EtusivuPainike
            // 
            this.EtusivuPainike.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtusivuPainike.Location = new System.Drawing.Point(248, 332);
            this.EtusivuPainike.Name = "EtusivuPainike";
            this.EtusivuPainike.Size = new System.Drawing.Size(232, 49);
            this.EtusivuPainike.TabIndex = 0;
            this.EtusivuPainike.Text = "Paina minua";
            this.EtusivuPainike.UseVisualStyleBackColor = true;
            this.EtusivuPainike.Click += new System.EventHandler(this.EtusivuPainike_Click);
            // 
            // TekstiTahan
            // 
            this.TekstiTahan.AutoSize = true;
            this.TekstiTahan.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TekstiTahan.Location = new System.Drawing.Point(105, 88);
            this.TekstiTahan.Name = "TekstiTahan";
            this.TekstiTahan.Size = new System.Drawing.Size(247, 37);
            this.TekstiTahan.TabIndex = 1;
            this.TekstiTahan.Text = "Anna etunimesi:";
            this.TekstiTahan.Click += new System.EventHandler(this.TekstiTahan_Click);
            // 
            // Tekstilaatikko
            // 
            this.Tekstilaatikko.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tekstilaatikko.Location = new System.Drawing.Point(530, 84);
            this.Tekstilaatikko.Name = "Tekstilaatikko";
            this.Tekstilaatikko.Size = new System.Drawing.Size(199, 44);
            this.Tekstilaatikko.TabIndex = 2;
            this.Tekstilaatikko.Text = "te";
            // 
            // ViestiLabel
            // 
            this.ViestiLabel.AutoSize = true;
            this.ViestiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViestiLabel.Location = new System.Drawing.Point(92, 201);
            this.ViestiLabel.Name = "ViestiLabel";
            this.ViestiLabel.Size = new System.Drawing.Size(305, 37);
            this.ViestiLabel.TabIndex = 3;
            this.ViestiLabel.Text = "Tähän tulee vastaus";
            this.ViestiLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViestiLabel);
            this.Controls.Add(this.Tekstilaatikko);
            this.Controls.Add(this.TekstiTahan);
            this.Controls.Add(this.EtusivuPainike);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EtusivuPainike;
        private System.Windows.Forms.Label TekstiTahan;
        private System.Windows.Forms.TextBox Tekstilaatikko;
        private System.Windows.Forms.Label ViestiLabel;
    }
}

