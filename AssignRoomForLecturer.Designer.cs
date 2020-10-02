namespace SPM
{
    partial class AssignRoomForLecturer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxLECT = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1Room = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2Building = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2Capacity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2Type = new System.Windows.Forms.TextBox();
            this.button1Clear = new System.Windows.Forms.Button();
            this.button2Assign = new System.Windows.Forms.Button();
            this.button3Update = new System.Windows.Forms.Button();
            this.button4Remove = new System.Windows.Forms.Button();
            this.SEARCH = new System.Windows.Forms.Label();
            this.textBox2Search = new System.Windows.Forms.TextBox();
            this.dataGridView1LecRoom = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1LecRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ASSIGN ROOM(S) FOR LECTURER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(39, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "LECTURER NAME:";
            // 
            // comboBoxLECT
            // 
            this.comboBoxLECT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLECT.FormattingEnabled = true;
            this.comboBoxLECT.Location = new System.Drawing.Point(147, 79);
            this.comboBoxLECT.Name = "comboBoxLECT";
            this.comboBoxLECT.Size = new System.Drawing.Size(220, 23);
            this.comboBoxLECT.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(423, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "ROOM NAME:";
            // 
            // comboBox1Room
            // 
            this.comboBox1Room.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1Room.FormattingEnabled = true;
            this.comboBox1Room.Location = new System.Drawing.Point(526, 82);
            this.comboBox1Room.Name = "comboBox1Room";
            this.comboBox1Room.Size = new System.Drawing.Size(184, 23);
            this.comboBox1Room.TabIndex = 6;
            this.comboBox1Room.SelectedIndexChanged += new System.EventHandler(this.comboBox1Room_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "BUILDING NAME:";
            // 
            // textBox2Building
            // 
            this.textBox2Building.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2Building.Location = new System.Drawing.Point(147, 133);
            this.textBox2Building.Name = "textBox2Building";
            this.textBox2Building.ReadOnly = true;
            this.textBox2Building.Size = new System.Drawing.Size(201, 21);
            this.textBox2Building.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(380, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "CAPACITY:";
            // 
            // textBox2Capacity
            // 
            this.textBox2Capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2Capacity.Location = new System.Drawing.Point(460, 134);
            this.textBox2Capacity.Name = "textBox2Capacity";
            this.textBox2Capacity.ReadOnly = true;
            this.textBox2Capacity.Size = new System.Drawing.Size(100, 21);
            this.textBox2Capacity.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(597, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "TYPE:";
            // 
            // textBox2Type
            // 
            this.textBox2Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2Type.Location = new System.Drawing.Point(648, 134);
            this.textBox2Type.Name = "textBox2Type";
            this.textBox2Type.ReadOnly = true;
            this.textBox2Type.Size = new System.Drawing.Size(100, 21);
            this.textBox2Type.TabIndex = 12;
            // 
            // button1Clear
            // 
            this.button1Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Clear.Location = new System.Drawing.Point(81, 182);
            this.button1Clear.Name = "button1Clear";
            this.button1Clear.Size = new System.Drawing.Size(102, 35);
            this.button1Clear.TabIndex = 13;
            this.button1Clear.Text = "CLEAR";
            this.button1Clear.UseVisualStyleBackColor = false;
            this.button1Clear.Click += new System.EventHandler(this.button1Clear_Click);
            // 
            // button2Assign
            // 
            this.button2Assign.BackColor = System.Drawing.Color.Blue;
            this.button2Assign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2Assign.Location = new System.Drawing.Point(265, 182);
            this.button2Assign.Name = "button2Assign";
            this.button2Assign.Size = new System.Drawing.Size(102, 35);
            this.button2Assign.TabIndex = 14;
            this.button2Assign.Text = "ASSIGN";
            this.button2Assign.UseVisualStyleBackColor = false;
            this.button2Assign.Click += new System.EventHandler(this.button2Assign_Click);
            // 
            // button3Update
            // 
            this.button3Update.BackColor = System.Drawing.Color.Lime;
            this.button3Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3Update.Location = new System.Drawing.Point(444, 182);
            this.button3Update.Name = "button3Update";
            this.button3Update.Size = new System.Drawing.Size(102, 35);
            this.button3Update.TabIndex = 15;
            this.button3Update.Text = "CHANGE";
            this.button3Update.UseVisualStyleBackColor = false;
            this.button3Update.Click += new System.EventHandler(this.button3Update_Click);
            // 
            // button4Remove
            // 
            this.button4Remove.BackColor = System.Drawing.Color.Red;
            this.button4Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4Remove.Location = new System.Drawing.Point(622, 182);
            this.button4Remove.Name = "button4Remove";
            this.button4Remove.Size = new System.Drawing.Size(102, 35);
            this.button4Remove.TabIndex = 16;
            this.button4Remove.Text = "REMOVE";
            this.button4Remove.UseVisualStyleBackColor = false;
            this.button4Remove.Click += new System.EventHandler(this.button4Remove_Click);
            // 
            // SEARCH
            // 
            this.SEARCH.AutoSize = true;
            this.SEARCH.BackColor = System.Drawing.Color.Yellow;
            this.SEARCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEARCH.Location = new System.Drawing.Point(105, 238);
            this.SEARCH.Name = "SEARCH";
            this.SEARCH.Size = new System.Drawing.Size(66, 15);
            this.SEARCH.TabIndex = 17;
            this.SEARCH.Text = "SEARCH:";
            // 
            // textBox2Search
            // 
            this.textBox2Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2Search.Location = new System.Drawing.Point(173, 235);
            this.textBox2Search.Name = "textBox2Search";
            this.textBox2Search.Size = new System.Drawing.Size(440, 21);
            this.textBox2Search.TabIndex = 18;
            this.textBox2Search.TextChanged += new System.EventHandler(this.textBox2Search_TextChanged);
            // 
            // dataGridView1LecRoom
            // 
            this.dataGridView1LecRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1LecRoom.Location = new System.Drawing.Point(70, 277);
            this.dataGridView1LecRoom.Name = "dataGridView1LecRoom";
            this.dataGridView1LecRoom.Size = new System.Drawing.Size(654, 212);
            this.dataGridView1LecRoom.TabIndex = 19;
            this.dataGridView1LecRoom.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1LecRoom_RowHeaderMouseClick);
            // 
            // AssignRoomForLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 501);
            this.Controls.Add(this.dataGridView1LecRoom);
            this.Controls.Add(this.textBox2Search);
            this.Controls.Add(this.SEARCH);
            this.Controls.Add(this.button4Remove);
            this.Controls.Add(this.button3Update);
            this.Controls.Add(this.button2Assign);
            this.Controls.Add(this.button1Clear);
            this.Controls.Add(this.textBox2Type);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2Capacity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2Building);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1Room);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxLECT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AssignRoomForLecturer";
            this.Text = "AssignRoomForLecturer";
            this.Load += new System.EventHandler(this.AssignRoomForLecturer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1LecRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxLECT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1Room;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2Building;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2Capacity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2Type;
        private System.Windows.Forms.Button button1Clear;
        private System.Windows.Forms.Button button2Assign;
        private System.Windows.Forms.Button button3Update;
        private System.Windows.Forms.Button button4Remove;
        private System.Windows.Forms.Label SEARCH;
        private System.Windows.Forms.TextBox textBox2Search;
        private System.Windows.Forms.DataGridView dataGridView1LecRoom;
    }
}