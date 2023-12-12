namespace Responsi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TbNama = new TextBox();
            RbHR = new RadioButton();
            RbENG = new RadioButton();
            RbDEV = new RadioButton();
            RbPM = new RadioButton();
            RbFIN = new RadioButton();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            BtnInsert = new Button();
            BtnEdit = new Button();
            BtnDelete = new Button();
            dgvDataTable = new DataGridView();
            label100 = new Label();
            LbSelected = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDataTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 0;
            label1.Text = "LOGO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 1;
            label2.Text = "Nama Karyawan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "Departemen";
            // 
            // TbNama
            // 
            TbNama.Location = new Point(111, 62);
            TbNama.Name = "TbNama";
            TbNama.Size = new Size(229, 23);
            TbNama.TabIndex = 3;
            // 
            // RbHR
            // 
            RbHR.AutoSize = true;
            RbHR.Location = new Point(111, 95);
            RbHR.Name = "RbHR";
            RbHR.Size = new Size(41, 19);
            RbHR.TabIndex = 5;
            RbHR.TabStop = true;
            RbHR.Text = "HR";
            RbHR.UseVisualStyleBackColor = true;
            // 
            // RbENG
            // 
            RbENG.AutoSize = true;
            RbENG.Location = new Point(158, 95);
            RbENG.Name = "RbENG";
            RbENG.Size = new Size(48, 19);
            RbENG.TabIndex = 6;
            RbENG.TabStop = true;
            RbENG.Text = "ENG";
            RbENG.UseVisualStyleBackColor = true;
            // 
            // RbDEV
            // 
            RbDEV.AutoSize = true;
            RbDEV.Location = new Point(212, 95);
            RbDEV.Name = "RbDEV";
            RbDEV.Size = new Size(46, 19);
            RbDEV.TabIndex = 7;
            RbDEV.TabStop = true;
            RbDEV.Text = "DEV";
            RbDEV.UseVisualStyleBackColor = true;
            // 
            // RbPM
            // 
            RbPM.AutoSize = true;
            RbPM.Location = new Point(264, 95);
            RbPM.Name = "RbPM";
            RbPM.Size = new Size(43, 19);
            RbPM.TabIndex = 8;
            RbPM.TabStop = true;
            RbPM.Text = "PM";
            RbPM.UseVisualStyleBackColor = true;
            // 
            // RbFIN
            // 
            RbFIN.AutoSize = true;
            RbFIN.Location = new Point(313, 95);
            RbFIN.Name = "RbFIN";
            RbFIN.Size = new Size(43, 19);
            RbFIN.TabIndex = 9;
            RbFIN.TabStop = true;
            RbFIN.Text = "FIN";
            RbFIN.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(382, 17);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 10;
            label4.Text = "ID Dep:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(382, 32);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 11;
            label5.Text = "HR: HR";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(382, 47);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 12;
            label6.Text = "ENG: Engineer";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(382, 62);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 13;
            label7.Text = "DEV: Developer";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(382, 77);
            label8.Name = "label8";
            label8.Size = new Size(123, 15);
            label8.TabIndex = 14;
            label8.Text = "PM: Product Manager";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(382, 92);
            label9.Name = "label9";
            label9.Size = new Size(72, 15);
            label9.TabIndex = 15;
            label9.Text = "FIN: Finance";
            // 
            // BtnInsert
            // 
            BtnInsert.Location = new Point(12, 134);
            BtnInsert.Name = "BtnInsert";
            BtnInsert.Size = new Size(75, 23);
            BtnInsert.TabIndex = 16;
            BtnInsert.Text = "Insert";
            BtnInsert.UseVisualStyleBackColor = true;
            BtnInsert.Click += BtnInsert_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.Location = new Point(93, 134);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(75, 23);
            BtnEdit.TabIndex = 17;
            BtnEdit.Text = "Edit";
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(174, 134);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(75, 23);
            BtnDelete.TabIndex = 18;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // dgvDataTable
            // 
            dgvDataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataTable.Location = new Point(12, 204);
            dgvDataTable.Name = "dgvDataTable";
            dgvDataTable.RowTemplate.Height = 25;
            dgvDataTable.Size = new Size(718, 234);
            dgvDataTable.TabIndex = 19;
            dgvDataTable.CellClick += dgvDataTable_CellClick;
            // 
            // label100
            // 
            label100.AutoSize = true;
            label100.Location = new Point(12, 171);
            label100.Name = "label100";
            label100.Size = new Size(101, 15);
            label100.TabIndex = 20;
            label100.Text = "Karyawan terpilih:";
            // 
            // LbSelected
            // 
            LbSelected.AutoSize = true;
            LbSelected.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LbSelected.Location = new Point(119, 171);
            LbSelected.Name = "LbSelected";
            LbSelected.Size = new Size(27, 15);
            LbSelected.TabIndex = 21;
            LbSelected.Text = "null";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 450);
            Controls.Add(LbSelected);
            Controls.Add(label100);
            Controls.Add(dgvDataTable);
            Controls.Add(BtnDelete);
            Controls.Add(BtnEdit);
            Controls.Add(BtnInsert);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(RbFIN);
            Controls.Add(RbPM);
            Controls.Add(RbDEV);
            Controls.Add(RbENG);
            Controls.Add(RbHR);
            Controls.Add(TbNama);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(758, 489);
            MinimumSize = new Size(758, 489);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDataTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TbNama;
        private RadioButton RbHR;
        private RadioButton RbENG;
        private RadioButton RbDEV;
        private RadioButton RbPM;
        private RadioButton RbFIN;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button BtnInsert;
        private Button BtnEdit;
        private Button BtnDelete;
        private DataGridView dgvDataTable;
        private Label label100;
        private Label LbSelected;
    }
}