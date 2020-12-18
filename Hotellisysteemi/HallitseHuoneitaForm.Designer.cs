
namespace Hotellisysteemi
{
    partial class HallitseHuoneitaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HallitseHuoneitaForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.textBoxHuoneNumero = new System.Windows.Forms.TextBox();
            this.labelRoomNumber = new System.Windows.Forms.Label();
            this.labelHvapaa = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonRemoveRoom = new System.Windows.Forms.Button();
            this.buttonEditRoom = new System.Windows.Forms.Button();
            this.labelHpuhelin = new System.Windows.Forms.Label();
            this.textBoxPuhelin = new System.Windows.Forms.TextBox();
            this.buttonAddRoom = new System.Windows.Forms.Button();
            this.labelRoomType = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.comboBoxRoomType);
            this.panel1.Controls.Add(this.textBoxHuoneNumero);
            this.panel1.Controls.Add(this.labelRoomNumber);
            this.panel1.Controls.Add(this.labelHvapaa);
            this.panel1.Controls.Add(this.dataGridView3);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.buttonRemoveRoom);
            this.panel1.Controls.Add(this.buttonEditRoom);
            this.panel1.Controls.Add(this.labelHpuhelin);
            this.panel1.Controls.Add(this.textBoxPuhelin);
            this.panel1.Controls.Add(this.buttonAddRoom);
            this.panel1.Controls.Add(this.labelRoomType);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 509);
            this.panel1.TabIndex = 1;
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Location = new System.Drawing.Point(147, 270);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(215, 32);
            this.comboBoxRoomType.TabIndex = 27;
            // 
            // textBoxHuoneNumero
            // 
            this.textBoxHuoneNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHuoneNumero.Location = new System.Drawing.Point(147, 217);
            this.textBoxHuoneNumero.Name = "textBoxHuoneNumero";
            this.textBoxHuoneNumero.Size = new System.Drawing.Size(215, 29);
            this.textBoxHuoneNumero.TabIndex = 26;
            // 
            // labelRoomNumber
            // 
            this.labelRoomNumber.AutoSize = true;
            this.labelRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomNumber.Location = new System.Drawing.Point(1, 217);
            this.labelRoomNumber.Name = "labelRoomNumber";
            this.labelRoomNumber.Size = new System.Drawing.Size(139, 24);
            this.labelRoomNumber.TabIndex = 25;
            this.labelRoomNumber.Text = "Huonenumero:";
            // 
            // labelHvapaa
            // 
            this.labelHvapaa.AutoSize = true;
            this.labelHvapaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHvapaa.Location = new System.Drawing.Point(50, 369);
            this.labelHvapaa.Name = "labelHvapaa";
            this.labelHvapaa.Size = new System.Drawing.Size(90, 24);
            this.labelHvapaa.TabIndex = 23;
            this.labelHvapaa.Text = "Vapaana:";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(386, 56);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(910, 392);
            this.dataGridView3.TabIndex = 22;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(10, 454);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(333, 34);
            this.buttonClear.TabIndex = 21;
            this.buttonClear.Text = "Tyhjää kentät";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonRemoveRoom
            // 
            this.buttonRemoveRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveRoom.Location = new System.Drawing.Point(245, 414);
            this.buttonRemoveRoom.Name = "buttonRemoveRoom";
            this.buttonRemoveRoom.Size = new System.Drawing.Size(98, 34);
            this.buttonRemoveRoom.TabIndex = 20;
            this.buttonRemoveRoom.Text = "Poista";
            this.buttonRemoveRoom.UseVisualStyleBackColor = true;
            this.buttonRemoveRoom.Click += new System.EventHandler(this.buttonRemoveRoom_Click);
            // 
            // buttonEditRoom
            // 
            this.buttonEditRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditRoom.Location = new System.Drawing.Point(141, 414);
            this.buttonEditRoom.Name = "buttonEditRoom";
            this.buttonEditRoom.Size = new System.Drawing.Size(98, 34);
            this.buttonEditRoom.TabIndex = 19;
            this.buttonEditRoom.Text = "Muokkaa";
            this.buttonEditRoom.UseVisualStyleBackColor = true;
            this.buttonEditRoom.Click += new System.EventHandler(this.buttonEditRoom_Click);
            // 
            // labelHpuhelin
            // 
            this.labelHpuhelin.AutoSize = true;
            this.labelHpuhelin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHpuhelin.Location = new System.Drawing.Point(6, 324);
            this.labelHpuhelin.Name = "labelHpuhelin";
            this.labelHpuhelin.Size = new System.Drawing.Size(136, 24);
            this.labelHpuhelin.TabIndex = 18;
            this.labelHpuhelin.Text = "Huonepuhelin:";
            // 
            // textBoxPuhelin
            // 
            this.textBoxPuhelin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPuhelin.Location = new System.Drawing.Point(147, 324);
            this.textBoxPuhelin.Name = "textBoxPuhelin";
            this.textBoxPuhelin.Size = new System.Drawing.Size(215, 29);
            this.textBoxPuhelin.TabIndex = 17;
            // 
            // buttonAddRoom
            // 
            this.buttonAddRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddRoom.Location = new System.Drawing.Point(10, 414);
            this.buttonAddRoom.Name = "buttonAddRoom";
            this.buttonAddRoom.Size = new System.Drawing.Size(125, 34);
            this.buttonAddRoom.TabIndex = 3;
            this.buttonAddRoom.Text = "Uusi huone";
            this.buttonAddRoom.UseVisualStyleBackColor = true;
            this.buttonAddRoom.Click += new System.EventHandler(this.buttonAddRoom_Click);
            // 
            // labelRoomType
            // 
            this.labelRoomType.AutoSize = true;
            this.labelRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomType.Location = new System.Drawing.Point(19, 270);
            this.labelRoomType.Name = "labelRoomType";
            this.labelRoomType.Size = new System.Drawing.Size(121, 24);
            this.labelRoomType.TabIndex = 1;
            this.labelRoomType.Text = "Huonetyyppi:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OliveDrab;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1293, 50);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hallitse Huoneita";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.radioButtonNo);
            this.panel3.Controls.Add(this.radioButtonYes);
            this.panel3.Location = new System.Drawing.Point(147, 369);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(196, 39);
            this.panel3.TabIndex = 28;
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Checked = true;
            this.radioButtonYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonYes.ForeColor = System.Drawing.Color.Green;
            this.radioButtonYes.Location = new System.Drawing.Point(18, 3);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(90, 28);
            this.radioButtonYes.TabIndex = 0;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "KYLLÄ";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNo.ForeColor = System.Drawing.Color.Red;
            this.radioButtonNo.Location = new System.Drawing.Point(114, 3);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(47, 28);
            this.radioButtonNo.TabIndex = 1;
            this.radioButtonNo.Text = "EI";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // HallitseHuoneitaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1284, 511);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HallitseHuoneitaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HallitseHuoneitaForm";
            this.Load += new System.EventHandler(this.HallitseHuoneitaForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxHuoneNumero;
        private System.Windows.Forms.Label labelRoomNumber;
        private System.Windows.Forms.Label labelHvapaa;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonRemoveRoom;
        private System.Windows.Forms.Button buttonEditRoom;
        private System.Windows.Forms.Label labelHpuhelin;
        private System.Windows.Forms.TextBox textBoxPuhelin;
        private System.Windows.Forms.Button buttonAddRoom;
        private System.Windows.Forms.Label labelRoomType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonYes;
    }
}