
namespace Hotellisysteemi
{
    partial class HallitseVarauksiaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HallitseVarauksiaForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePickerOUT = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerIN = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxHnumero = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAsiakasID = new System.Windows.Forms.TextBox();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.textBoxVarausID = new System.Windows.Forms.TextBox();
            this.labelRoomNumber = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonRemoveReserv = new System.Windows.Forms.Button();
            this.buttonEditReserv = new System.Windows.Forms.Button();
            this.buttonAddReserv = new System.Windows.Forms.Button();
            this.labelRoomType = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePickerOUT);
            this.panel1.Controls.Add(this.dateTimePickerIN);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBoxHnumero);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxAsiakasID);
            this.panel1.Controls.Add(this.comboBoxRoomType);
            this.panel1.Controls.Add(this.textBoxVarausID);
            this.panel1.Controls.Add(this.labelRoomNumber);
            this.panel1.Controls.Add(this.dataGridView3);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.buttonRemoveReserv);
            this.panel1.Controls.Add(this.buttonEditReserv);
            this.panel1.Controls.Add(this.buttonAddReserv);
            this.panel1.Controls.Add(this.labelRoomType);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-6, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 509);
            this.panel1.TabIndex = 2;
            // 
            // dateTimePickerOUT
            // 
            this.dateTimePickerOUT.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerOUT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerOUT.Location = new System.Drawing.Point(147, 363);
            this.dateTimePickerOUT.Name = "dateTimePickerOUT";
            this.dateTimePickerOUT.Size = new System.Drawing.Size(215, 29);
            this.dateTimePickerOUT.TabIndex = 35;
            // 
            // dateTimePickerIN
            // 
            this.dateTimePickerIN.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerIN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerIN.Location = new System.Drawing.Point(147, 311);
            this.dateTimePickerIN.Name = "dateTimePickerIN";
            this.dateTimePickerIN.Size = new System.Drawing.Size(215, 29);
            this.dateTimePickerIN.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 24);
            this.label5.TabIndex = 33;
            this.label5.Text = "Huone Out:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 24);
            this.label4.TabIndex = 32;
            this.label4.Text = "Huone In:";
            // 
            // comboBoxHnumero
            // 
            this.comboBoxHnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxHnumero.FormattingEnabled = true;
            this.comboBoxHnumero.Location = new System.Drawing.Point(147, 253);
            this.comboBoxHnumero.Name = "comboBoxHnumero";
            this.comboBoxHnumero.Size = new System.Drawing.Size(215, 32);
            this.comboBoxHnumero.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "Huone nro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "Asiakas nro:";
            // 
            // textBoxAsiakasID
            // 
            this.textBoxAsiakasID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAsiakasID.Location = new System.Drawing.Point(147, 148);
            this.textBoxAsiakasID.Name = "textBoxAsiakasID";
            this.textBoxAsiakasID.Size = new System.Drawing.Size(215, 29);
            this.textBoxAsiakasID.TabIndex = 28;
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Location = new System.Drawing.Point(147, 199);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(215, 32);
            this.comboBoxRoomType.TabIndex = 27;
            this.comboBoxRoomType.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoomType_SelectedIndexChanged);
            // 
            // textBoxVarausID
            // 
            this.textBoxVarausID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVarausID.Location = new System.Drawing.Point(147, 96);
            this.textBoxVarausID.Name = "textBoxVarausID";
            this.textBoxVarausID.ReadOnly = true;
            this.textBoxVarausID.Size = new System.Drawing.Size(215, 29);
            this.textBoxVarausID.TabIndex = 26;
            // 
            // labelRoomNumber
            // 
            this.labelRoomNumber.AutoSize = true;
            this.labelRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomNumber.Location = new System.Drawing.Point(28, 96);
            this.labelRoomNumber.Name = "labelRoomNumber";
            this.labelRoomNumber.Size = new System.Drawing.Size(107, 24);
            this.labelRoomNumber.TabIndex = 25;
            this.labelRoomNumber.Text = "Varaus nro:";
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
            // buttonRemoveReserv
            // 
            this.buttonRemoveReserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveReserv.Location = new System.Drawing.Point(245, 414);
            this.buttonRemoveReserv.Name = "buttonRemoveReserv";
            this.buttonRemoveReserv.Size = new System.Drawing.Size(98, 34);
            this.buttonRemoveReserv.TabIndex = 20;
            this.buttonRemoveReserv.Text = "Poista";
            this.buttonRemoveReserv.UseVisualStyleBackColor = true;
            this.buttonRemoveReserv.Click += new System.EventHandler(this.buttonRemoveReserv_Click);
            // 
            // buttonEditReserv
            // 
            this.buttonEditReserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditReserv.Location = new System.Drawing.Point(141, 414);
            this.buttonEditReserv.Name = "buttonEditReserv";
            this.buttonEditReserv.Size = new System.Drawing.Size(98, 34);
            this.buttonEditReserv.TabIndex = 19;
            this.buttonEditReserv.Text = "Muokkaa";
            this.buttonEditReserv.UseVisualStyleBackColor = true;
            this.buttonEditReserv.Click += new System.EventHandler(this.buttonEditReserv_Click);
            // 
            // buttonAddReserv
            // 
            this.buttonAddReserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddReserv.Location = new System.Drawing.Point(10, 414);
            this.buttonAddReserv.Name = "buttonAddReserv";
            this.buttonAddReserv.Size = new System.Drawing.Size(125, 34);
            this.buttonAddReserv.TabIndex = 3;
            this.buttonAddReserv.Text = "Uusi varaus";
            this.buttonAddReserv.UseVisualStyleBackColor = true;
            this.buttonAddReserv.Click += new System.EventHandler(this.buttonAddReserv_Click);
            // 
            // labelRoomType
            // 
            this.labelRoomType.AutoSize = true;
            this.labelRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomType.Location = new System.Drawing.Point(20, 199);
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
            this.label1.Size = new System.Drawing.Size(335, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hallitse Varauksia";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HallitseVarauksiaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1278, 508);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HallitseVarauksiaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HallitseVarauksiaForm";
            this.Load += new System.EventHandler(this.HallitseVarauksiaForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.TextBox textBoxVarausID;
        private System.Windows.Forms.Label labelRoomNumber;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonRemoveReserv;
        private System.Windows.Forms.Button buttonEditReserv;
        private System.Windows.Forms.Button buttonAddReserv;
        private System.Windows.Forms.Label labelRoomType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAsiakasID;
        private System.Windows.Forms.ComboBox comboBoxHnumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerOUT;
        private System.Windows.Forms.DateTimePicker dateTimePickerIN;
    }
}