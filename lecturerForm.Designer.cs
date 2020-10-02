namespace SPM
{
    partial class lecturerForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxLevel = new System.Windows.Forms.ComboBox();
            this.comboBoxBuilding = new System.Windows.Forms.ComboBox();
            this.comboBoxCenter = new System.Windows.Forms.ComboBox();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.comboBoxFaculty = new System.Windows.Forms.ComboBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxLectureName = new System.Windows.Forms.TextBox();
            this.textBoxRank = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewLecturer = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLecturer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.textBoxNo);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.comboBoxLevel);
            this.panel2.Controls.Add(this.comboBoxBuilding);
            this.panel2.Controls.Add(this.comboBoxCenter);
            this.panel2.Controls.Add(this.comboBoxDepartment);
            this.panel2.Controls.Add(this.comboBoxFaculty);
            this.panel2.Controls.Add(this.buttonClear);
            this.panel2.Controls.Add(this.buttonDelete);
            this.panel2.Controls.Add(this.buttonUpdate);
            this.panel2.Controls.Add(this.buttonAdd);
            this.panel2.Controls.Add(this.textBoxLectureName);
            this.panel2.Controls.Add(this.textBoxRank);
            this.panel2.Controls.Add(this.textBoxEmployeeID);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1059, 287);
            this.panel2.TabIndex = 4;
            // 
            // textBoxNo
            // 
            this.textBoxNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNo.Location = new System.Drawing.Point(166, 7);
            this.textBoxNo.Name = "textBoxNo";
            this.textBoxNo.ReadOnly = true;
            this.textBoxNo.Size = new System.Drawing.Size(280, 30);
            this.textBoxNo.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "No :";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // comboBoxLevel
            // 
            this.comboBoxLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLevel.FormattingEnabled = true;
            this.comboBoxLevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBoxLevel.Location = new System.Drawing.Point(735, 129);
            this.comboBoxLevel.Name = "comboBoxLevel";
            this.comboBoxLevel.Size = new System.Drawing.Size(280, 28);
            this.comboBoxLevel.TabIndex = 24;
            this.comboBoxLevel.SelectedIndexChanged += new System.EventHandler(this.comboBoxLevel_SelectedIndexChanged);
            // 
            // comboBoxBuilding
            // 
            this.comboBoxBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBuilding.FormattingEnabled = true;
            this.comboBoxBuilding.Items.AddRange(new object[] {
            "New Building",
            "D-block",
            "E-block"});
            this.comboBoxBuilding.Location = new System.Drawing.Point(735, 89);
            this.comboBoxBuilding.Name = "comboBoxBuilding";
            this.comboBoxBuilding.Size = new System.Drawing.Size(280, 28);
            this.comboBoxBuilding.TabIndex = 23;
            // 
            // comboBoxCenter
            // 
            this.comboBoxCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCenter.FormattingEnabled = true;
            this.comboBoxCenter.Items.AddRange(new object[] {
            "Malabe",
            "Matara",
            "Jaffna",
            "Metro",
            "Kandy"});
            this.comboBoxCenter.Location = new System.Drawing.Point(735, 45);
            this.comboBoxCenter.Name = "comboBoxCenter";
            this.comboBoxCenter.Size = new System.Drawing.Size(280, 28);
            this.comboBoxCenter.TabIndex = 22;
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Items.AddRange(new object[] {
            "SE",
            "IT",
            "CSSN",
            "CS"});
            this.comboBoxDepartment.Location = new System.Drawing.Point(166, 169);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(280, 28);
            this.comboBoxDepartment.TabIndex = 21;
            // 
            // comboBoxFaculty
            // 
            this.comboBoxFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFaculty.FormattingEnabled = true;
            this.comboBoxFaculty.Items.AddRange(new object[] {
            "Faculty of Computing",
            "Faculty of Engineering",
            "Faculty of Buiness",
            "Faculty of Humanities & Science"});
            this.comboBoxFaculty.Location = new System.Drawing.Point(166, 131);
            this.comboBoxFaculty.Name = "comboBoxFaculty";
            this.comboBoxFaculty.Size = new System.Drawing.Size(280, 28);
            this.comboBoxFaculty.TabIndex = 20;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(704, 217);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(119, 43);
            this.buttonClear.TabIndex = 19;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(548, 217);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(119, 43);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(400, 217);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(119, 43);
            this.buttonUpdate.TabIndex = 17;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(249, 217);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(119, 43);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxLectureName
            // 
            this.textBoxLectureName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLectureName.Location = new System.Drawing.Point(166, 82);
            this.textBoxLectureName.Name = "textBoxLectureName";
            this.textBoxLectureName.Size = new System.Drawing.Size(280, 30);
            this.textBoxLectureName.TabIndex = 15;
            // 
            // textBoxRank
            // 
            this.textBoxRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRank.Location = new System.Drawing.Point(735, 164);
            this.textBoxRank.Name = "textBoxRank";
            this.textBoxRank.ReadOnly = true;
            this.textBoxRank.Size = new System.Drawing.Size(280, 30);
            this.textBoxRank.TabIndex = 9;
            this.textBoxRank.TextChanged += new System.EventHandler(this.textBoxRank_TextChanged);
            // 
            // textBoxEmployeeID
            // 
            this.textBoxEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmployeeID.Location = new System.Drawing.Point(166, 44);
            this.textBoxEmployeeID.MaxLength = 6;
            this.textBoxEmployeeID.Name = "textBoxEmployeeID";
            this.textBoxEmployeeID.Size = new System.Drawing.Size(280, 30);
            this.textBoxEmployeeID.TabIndex = 8;
            this.textBoxEmployeeID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEmployeeID_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(649, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Rank :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(649, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Level :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(649, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Building :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(649, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Center :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Department :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Faculty :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lecturer Name :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(458, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 32);
            this.label9.TabIndex = 16;
            this.label9.Text = "LECTURER(S)";
            // 
            // dataGridViewLecturer
            // 
            this.dataGridViewLecturer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLecturer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLecturer.Location = new System.Drawing.Point(1, 381);
            this.dataGridViewLecturer.Name = "dataGridViewLecturer";
            this.dataGridViewLecturer.RowHeadersWidth = 51;
            this.dataGridViewLecturer.RowTemplate.Height = 24;
            this.dataGridViewLecturer.Size = new System.Drawing.Size(1059, 225);
            this.dataGridViewLecturer.TabIndex = 17;
            this.dataGridViewLecturer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLecturer_CellContentClick);
            this.dataGridViewLecturer.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewLecturer_RowHeaderMouseClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(295, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Lecturer ";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(378, 337);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(382, 27);
            this.textBoxSearch.TabIndex = 20;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // lecturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1062, 618);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridViewLecturer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Name = "lecturerForm";
            this.Text = "ABC Institute";
            this.Load += new System.EventHandler(this.lecturerForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLecturer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxLectureName;
        private System.Windows.Forms.TextBox textBoxRank;
        private System.Windows.Forms.TextBox textBoxEmployeeID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridViewLecturer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxLevel;
        private System.Windows.Forms.ComboBox comboBoxBuilding;
        private System.Windows.Forms.ComboBox comboBoxCenter;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.ComboBox comboBoxFaculty;
        private System.Windows.Forms.TextBox textBoxNo;
    }
}