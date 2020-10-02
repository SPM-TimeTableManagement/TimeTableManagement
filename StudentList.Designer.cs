namespace SPM
{
    partial class StudentList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.comboProg = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboSem = new System.Windows.Forms.ComboBox();
            this.comboYear = new System.Windows.Forms.ComboBox();
            this.buttonSaveUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GroupNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProgrammeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtGrpNo = new System.Windows.Forms.TextBox();
            this.textGrpID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(817, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 31);
            this.label3.TabIndex = 36;
            this.label3.Text = "Programme";
            // 
            // comboProg
            // 
            this.comboProg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboProg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboProg.FormattingEnabled = true;
            this.comboProg.Location = new System.Drawing.Point(759, 67);
            this.comboProg.Margin = new System.Windows.Forms.Padding(5);
            this.comboProg.Name = "comboProg";
            this.comboProg.Size = new System.Drawing.Size(283, 33);
            this.comboProg.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(431, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 31);
            this.label2.TabIndex = 34;
            this.label2.Text = "Semester";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 31);
            this.label1.TabIndex = 33;
            this.label1.Text = "Year";
            // 
            // comboSem
            // 
            this.comboSem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboSem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSem.FormattingEnabled = true;
            this.comboSem.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboSem.Location = new System.Drawing.Point(398, 67);
            this.comboSem.Margin = new System.Windows.Forms.Padding(5);
            this.comboSem.Name = "comboSem";
            this.comboSem.Size = new System.Drawing.Size(212, 33);
            this.comboSem.TabIndex = 32;
            // 
            // comboYear
            // 
            this.comboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboYear.FormattingEnabled = true;
            this.comboYear.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboYear.Location = new System.Drawing.Point(41, 67);
            this.comboYear.Margin = new System.Windows.Forms.Padding(5);
            this.comboYear.Name = "comboYear";
            this.comboYear.Size = new System.Drawing.Size(212, 33);
            this.comboYear.TabIndex = 31;
            // 
            // buttonSaveUpdate
            // 
            this.buttonSaveUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSaveUpdate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonSaveUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveUpdate.Location = new System.Drawing.Point(392, 120);
            this.buttonSaveUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSaveUpdate.Name = "buttonSaveUpdate";
            this.buttonSaveUpdate.Size = new System.Drawing.Size(218, 58);
            this.buttonSaveUpdate.TabIndex = 37;
            this.buttonSaveUpdate.Text = "Search ";
            this.buttonSaveUpdate.UseVisualStyleBackColor = false;
            this.buttonSaveUpdate.Click += new System.EventHandler(this.buttonSaveUpdate_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupNumber,
            this.GroupID,
            this.Year,
            this.Semester,
            this.ProgrammeCode});
            this.dataGridView1.Location = new System.Drawing.Point(32, 337);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(823, 305);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // GroupNumber
            // 
            this.GroupNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GroupNumber.HeaderText = "Group Number";
            this.GroupNumber.MinimumWidth = 6;
            this.GroupNumber.Name = "GroupNumber";
            // 
            // GroupID
            // 
            this.GroupID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GroupID.HeaderText = "GroupID";
            this.GroupID.MinimumWidth = 6;
            this.GroupID.Name = "GroupID";
            // 
            // Year
            // 
            this.Year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Year.HeaderText = "Year";
            this.Year.MinimumWidth = 6;
            this.Year.Name = "Year";
            // 
            // Semester
            // 
            this.Semester.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Semester.HeaderText = "Semester";
            this.Semester.MinimumWidth = 6;
            this.Semester.Name = "Semester";
            // 
            // ProgrammeCode
            // 
            this.ProgrammeCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProgrammeCode.HeaderText = "Programme Code";
            this.ProgrammeCode.MinimumWidth = 6;
            this.ProgrammeCode.Name = "ProgrammeCode";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClear.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(865, 402);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(189, 58);
            this.btnClear.TabIndex = 43;
            this.btnClear.Text = "Clear ";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(865, 485);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(189, 58);
            this.btnDelete.TabIndex = 44;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtGrpNo
            // 
            this.txtGrpNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrpNo.Location = new System.Drawing.Point(32, 258);
            this.txtGrpNo.Name = "txtGrpNo";
            this.txtGrpNo.Size = new System.Drawing.Size(235, 34);
            this.txtGrpNo.TabIndex = 45;
            // 
            // textGrpID
            // 
            this.textGrpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGrpID.Location = new System.Drawing.Point(407, 258);
            this.textGrpID.Name = "textGrpID";
            this.textGrpID.Size = new System.Drawing.Size(235, 34);
            this.textGrpID.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 31);
            this.label4.TabIndex = 47;
            this.label4.Text = "Edit Group Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(429, 206);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 31);
            this.label5.TabIndex = 48;
            this.label5.Text = "Edit Group ID";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(753, 234);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(218, 58);
            this.btnUpdate.TabIndex = 49;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // StudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1080, 665);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textGrpID);
            this.Controls.Add(this.txtGrpNo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSaveUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboProg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboSem);
            this.Controls.Add(this.comboYear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentList";
            this.Text = "StudentList";
            this.Load += new System.EventHandler(this.StudentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboProg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboSem;
        private System.Windows.Forms.ComboBox comboYear;
        private System.Windows.Forms.Button buttonSaveUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtGrpNo;
        private System.Windows.Forms.TextBox textGrpID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgrammeCode;
    }
}