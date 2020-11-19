
namespace V1_T1_06kaksilukuayhteen
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
            this.Luku1label = new System.Windows.Forms.Label();
            this.Luku2label = new System.Windows.Forms.Label();
            this.Luku1tekstilaatikko = new System.Windows.Forms.TextBox();
            this.Luku2tekstilaatikko = new System.Windows.Forms.TextBox();
            this.YhteenlaskuPainike = new System.Windows.Forms.Button();
            this.YhteenlaskuLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Luku1label
            // 
            this.Luku1label.AutoSize = true;
            this.Luku1label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Luku1label.Location = new System.Drawing.Point(150, 99);
            this.Luku1label.Name = "Luku1label";
            this.Luku1label.Size = new System.Drawing.Size(112, 37);
            this.Luku1label.TabIndex = 0;
            this.Luku1label.Text = "Luku1:";
            // 
            // Luku2label
            // 
            this.Luku2label.AutoSize = true;
            this.Luku2label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Luku2label.Location = new System.Drawing.Point(150, 178);
            this.Luku2label.Name = "Luku2label";
            this.Luku2label.Size = new System.Drawing.Size(114, 37);
            this.Luku2label.TabIndex = 1;
            this.Luku2label.Text = "Luku2:";
            // 
            // Luku1tekstilaatikko
            // 
            this.Luku1tekstilaatikko.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Luku1tekstilaatikko.Location = new System.Drawing.Point(331, 99);
            this.Luku1tekstilaatikko.Name = "Luku1tekstilaatikko";
            this.Luku1tekstilaatikko.Size = new System.Drawing.Size(100, 44);
            this.Luku1tekstilaatikko.TabIndex = 2;
            this.Luku1tekstilaatikko.Text = "3";
            this.Luku1tekstilaatikko.TextChanged += new System.EventHandler(this.Luku1tekstilaatikko_TextChanged);
            // 
            // Luku2tekstilaatikko
            // 
            this.Luku2tekstilaatikko.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Luku2tekstilaatikko.Location = new System.Drawing.Point(331, 178);
            this.Luku2tekstilaatikko.Name = "Luku2tekstilaatikko";
            this.Luku2tekstilaatikko.Size = new System.Drawing.Size(100, 44);
            this.Luku2tekstilaatikko.TabIndex = 3;
            this.Luku2tekstilaatikko.Text = "5";
            // 
            // YhteenlaskuPainike
            // 
            this.YhteenlaskuPainike.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YhteenlaskuPainike.Location = new System.Drawing.Point(157, 267);
            this.YhteenlaskuPainike.Name = "YhteenlaskuPainike";
            this.YhteenlaskuPainike.Size = new System.Drawing.Size(274, 53);
            this.YhteenlaskuPainike.TabIndex = 4;
            this.YhteenlaskuPainike.Text = "Laske Yhteen";
            this.YhteenlaskuPainike.UseVisualStyleBackColor = true;
            this.YhteenlaskuPainike.Click += new System.EventHandler(this.YhteenlaskuPainike_Click);
            // 
            // YhteenlaskuLabel
            // 
            this.YhteenlaskuLabel.AutoSize = true;
            this.YhteenlaskuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YhteenlaskuLabel.Location = new System.Drawing.Point(150, 349);
            this.YhteenlaskuLabel.Name = "YhteenlaskuLabel";
            this.YhteenlaskuLabel.Size = new System.Drawing.Size(305, 37);
            this.YhteenlaskuLabel.TabIndex = 5;
            this.YhteenlaskuLabel.Text = "Tähän tulee vastaus";
            this.YhteenlaskuLabel.Visible = false;
            this.YhteenlaskuLabel.Click += new System.EventHandler(this.YhteenlaskuLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 452);
            this.Controls.Add(this.YhteenlaskuLabel);
            this.Controls.Add(this.YhteenlaskuPainike);
            this.Controls.Add(this.Luku2tekstilaatikko);
            this.Controls.Add(this.Luku1tekstilaatikko);
            this.Controls.Add(this.Luku2label);
            this.Controls.Add(this.Luku1label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Luku1label;
        private System.Windows.Forms.Label Luku2label;
        private System.Windows.Forms.TextBox Luku1tekstilaatikko;
        private System.Windows.Forms.TextBox Luku2tekstilaatikko;
        private System.Windows.Forms.Button YhteenlaskuPainike;
        private System.Windows.Forms.Label YhteenlaskuLabel;
    }
}

