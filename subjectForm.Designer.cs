namespace SPM
{
    partial class subjectForm
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
            this.textBoxSearchSubject = new System.Windows.Forms.TextBox();
            this.dataGridViewSubject = new System.Windows.Forms.DataGridView();
            this.textBoxNosubject = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDownEvolution = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLab = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTute = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLecture = new System.Windows.Forms.NumericUpDown();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.comboBoxSemester = new System.Windows.Forms.ComboBox();
            this.buttonClearsubject = new System.Windows.Forms.Button();
            this.buttonDeletesubject = new System.Windows.Forms.Button();
            this.buttonUpdatesubject = new System.Windows.Forms.Button();
            this.buttonAddsubject = new System.Windows.Forms.Button();
            this.textBoxSubjectName = new System.Windows.Forms.TextBox();
            this.textBoxSubjectCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubject)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEvolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLecture)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSearchSubject
            // 
            this.textBoxSearchSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchSubject.Location = new System.Drawing.Point(379, 342);
            this.textBoxSearchSubject.Name = "textBoxSearchSubject";
            this.textBoxSearchSubject.Size = new System.Drawing.Size(382, 27);
            this.textBoxSearchSubject.TabIndex = 24;
            this.textBoxSearchSubject.TextChanged += new System.EventHandler(this.textBoxSearchSubject_TextChanged);
            // 
            // dataGridViewSubject
            // 
            this.dataGridViewSubject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubject.Location = new System.Drawing.Point(2, 383);
            this.dataGridViewSubject.Name = "dataGridViewSubject";
            this.dataGridViewSubject.RowHeadersWidth = 51;
            this.dataGridViewSubject.RowTemplate.Height = 24;
            this.dataGridViewSubject.Size = new System.Drawing.Size(1059, 225);
            this.dataGridViewSubject.TabIndex = 23;
            this.dataGridViewSubject.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSubject_RowHeaderMouseClick);
            // 
            // textBoxNosubject
            // 
            this.textBoxNosubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNosubject.Location = new System.Drawing.Point(166, 7);
            this.textBoxNosubject.Name = "textBoxNosubject";
            this.textBoxNosubject.ReadOnly = true;
            this.textBoxNosubject.Size = new System.Drawing.Size(280, 30);
            this.textBoxNosubject.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(296, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Subject";
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
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(476, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 32);
            this.label9.TabIndex = 22;
            this.label9.Text = "SUBJECT";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.panel2.Controls.Add(this.numericUpDownEvolution);
            this.panel2.Controls.Add(this.numericUpDownLab);
            this.panel2.Controls.Add(this.numericUpDownTute);
            this.panel2.Controls.Add(this.numericUpDownLecture);
            this.panel2.Controls.Add(this.textBoxYear);
            this.panel2.Controls.Add(this.textBoxNosubject);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.comboBoxSemester);
            this.panel2.Controls.Add(this.buttonClearsubject);
            this.panel2.Controls.Add(this.buttonDeletesubject);
            this.panel2.Controls.Add(this.buttonUpdatesubject);
            this.panel2.Controls.Add(this.buttonAddsubject);
            this.panel2.Controls.Add(this.textBoxSubjectName);
            this.panel2.Controls.Add(this.textBoxSubjectCode);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(2, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1059, 287);
            this.panel2.TabIndex = 21;
            // 
            // numericUpDownEvolution
            // 
            this.numericUpDownEvolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownEvolution.Location = new System.Drawing.Point(834, 162);
            this.numericUpDownEvolution.Name = "numericUpDownEvolution";
            this.numericUpDownEvolution.Size = new System.Drawing.Size(120, 27);
            this.numericUpDownEvolution.TabIndex = 34;
            // 
            // numericUpDownLab
            // 
            this.numericUpDownLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownLab.Location = new System.Drawing.Point(834, 120);
            this.numericUpDownLab.Name = "numericUpDownLab";
            this.numericUpDownLab.Size = new System.Drawing.Size(120, 27);
            this.numericUpDownLab.TabIndex = 33;
            // 
            // numericUpDownTute
            // 
            this.numericUpDownTute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownTute.Location = new System.Drawing.Point(834, 80);
            this.numericUpDownTute.Name = "numericUpDownTute";
            this.numericUpDownTute.Size = new System.Drawing.Size(120, 27);
            this.numericUpDownTute.TabIndex = 32;
            // 
            // numericUpDownLecture
            // 
            this.numericUpDownLecture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownLecture.Location = new System.Drawing.Point(834, 42);
            this.numericUpDownLecture.Name = "numericUpDownLecture";
            this.numericUpDownLecture.Size = new System.Drawing.Size(120, 27);
            this.numericUpDownLecture.TabIndex = 31;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxYear.Location = new System.Drawing.Point(166, 127);
            this.textBoxYear.MaxLength = 4;
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(280, 30);
            this.textBoxYear.TabIndex = 30;
            this.textBoxYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxYear_KeyPress);
            // 
            // comboBoxSemester
            // 
            this.comboBoxSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSemester.FormattingEnabled = true;
            this.comboBoxSemester.Items.AddRange(new object[] {
            "S1",
            "S2"});
            this.comboBoxSemester.Location = new System.Drawing.Point(166, 169);
            this.comboBoxSemester.Name = "comboBoxSemester";
            this.comboBoxSemester.Size = new System.Drawing.Size(280, 28);
            this.comboBoxSemester.TabIndex = 21;
            // 
            // buttonClearsubject
            // 
            this.buttonClearsubject.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonClearsubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearsubject.ForeColor = System.Drawing.Color.White;
            this.buttonClearsubject.Location = new System.Drawing.Point(700, 217);
            this.buttonClearsubject.Name = "buttonClearsubject";
            this.buttonClearsubject.Size = new System.Drawing.Size(119, 43);
            this.buttonClearsubject.TabIndex = 19;
            this.buttonClearsubject.Text = "Clear";
            this.buttonClearsubject.UseVisualStyleBackColor = false;
            this.buttonClearsubject.Click += new System.EventHandler(this.buttonClearsubject_Click);
            // 
            // buttonDeletesubject
            // 
            this.buttonDeletesubject.BackColor = System.Drawing.Color.Red;
            this.buttonDeletesubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeletesubject.ForeColor = System.Drawing.Color.White;
            this.buttonDeletesubject.Location = new System.Drawing.Point(548, 217);
            this.buttonDeletesubject.Name = "buttonDeletesubject";
            this.buttonDeletesubject.Size = new System.Drawing.Size(119, 43);
            this.buttonDeletesubject.TabIndex = 18;
            this.buttonDeletesubject.Text = "Delete";
            this.buttonDeletesubject.UseVisualStyleBackColor = false;
            this.buttonDeletesubject.Click += new System.EventHandler(this.buttonDeletesubject_Click);
            // 
            // buttonUpdatesubject
            // 
            this.buttonUpdatesubject.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonUpdatesubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdatesubject.ForeColor = System.Drawing.Color.White;
            this.buttonUpdatesubject.Location = new System.Drawing.Point(400, 217);
            this.buttonUpdatesubject.Name = "buttonUpdatesubject";
            this.buttonUpdatesubject.Size = new System.Drawing.Size(119, 43);
            this.buttonUpdatesubject.TabIndex = 17;
            this.buttonUpdatesubject.Text = "Update";
            this.buttonUpdatesubject.UseVisualStyleBackColor = false;
            this.buttonUpdatesubject.Click += new System.EventHandler(this.buttonUpdatesubject_Click);
            // 
            // buttonAddsubject
            // 
            this.buttonAddsubject.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonAddsubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddsubject.ForeColor = System.Drawing.Color.White;
            this.buttonAddsubject.Location = new System.Drawing.Point(249, 217);
            this.buttonAddsubject.Name = "buttonAddsubject";
            this.buttonAddsubject.Size = new System.Drawing.Size(119, 43);
            this.buttonAddsubject.TabIndex = 16;
            this.buttonAddsubject.Text = "Add";
            this.buttonAddsubject.UseVisualStyleBackColor = false;
            this.buttonAddsubject.Click += new System.EventHandler(this.buttonAddsubject_Click);
            // 
            // textBoxSubjectName
            // 
            this.textBoxSubjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubjectName.Location = new System.Drawing.Point(166, 82);
            this.textBoxSubjectName.Name = "textBoxSubjectName";
            this.textBoxSubjectName.Size = new System.Drawing.Size(280, 30);
            this.textBoxSubjectName.TabIndex = 15;
            // 
            // textBoxSubjectCode
            // 
            this.textBoxSubjectCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubjectCode.Location = new System.Drawing.Point(166, 44);
            this.textBoxSubjectCode.Name = "textBoxSubjectCode";
            this.textBoxSubjectCode.Size = new System.Drawing.Size(280, 30);
            this.textBoxSubjectCode.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(559, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(229, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Number of evaluation hours  :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(559, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Number of lab hours  :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(559, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Number of tutorial hours  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(559, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Number of lecture hours  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Offered Semester :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Offered Year :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject Code :";
            // 
            // subjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 618);
            this.Controls.Add(this.textBoxSearchSubject);
            this.Controls.Add(this.dataGridViewSubject);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Name = "subjectForm";
            this.Text = "ABC Institute";
            this.Load += new System.EventHandler(this.subjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubject)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEvolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLecture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearchSubject;
        private System.Windows.Forms.DataGridView dataGridViewSubject;
        private System.Windows.Forms.TextBox textBoxNosubject;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxSemester;
        private System.Windows.Forms.Button buttonClearsubject;
        private System.Windows.Forms.Button buttonDeletesubject;
        private System.Windows.Forms.Button buttonUpdatesubject;
        private System.Windows.Forms.Button buttonAddsubject;
        private System.Windows.Forms.TextBox textBoxSubjectName;
        private System.Windows.Forms.TextBox textBoxSubjectCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.NumericUpDown numericUpDownEvolution;
        private System.Windows.Forms.NumericUpDown numericUpDownLab;
        private System.Windows.Forms.NumericUpDown numericUpDownTute;
        private System.Windows.Forms.NumericUpDown numericUpDownLecture;
    }
}