namespace SPM
{
    partial class AssignRoomForSubject
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
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1Subject = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2Tag = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3Room = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1BuildingName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1Capacity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1Type = new System.Windows.Forms.TextBox();
            this.button1Clear = new System.Windows.Forms.Button();
            this.button1Assign = new System.Windows.Forms.Button();
            this.button1Change = new System.Windows.Forms.Button();
            this.button1Remove = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1FilterSub = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox2FilterTag = new System.Windows.Forms.ComboBox();
            this.dataGridView1RoomSubject = new System.Windows.Forms.DataGridView();
            this.button1Filter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1RoomSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ASSIGN ROOM(S) FOR SUBJECT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(39, 48);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(100, 21);
            this.textBoxID.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "SUBJECT NAME";
            // 
            // comboBox1Subject
            // 
            this.comboBox1Subject.FormattingEnabled = true;
            this.comboBox1Subject.Location = new System.Drawing.Point(131, 85);
            this.comboBox1Subject.Name = "comboBox1Subject";
            this.comboBox1Subject.Size = new System.Drawing.Size(197, 21);
            this.comboBox1Subject.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(405, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "TAG";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBox2Tag
            // 
            this.comboBox2Tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2Tag.FormattingEnabled = true;
            this.comboBox2Tag.Location = new System.Drawing.Point(445, 86);
            this.comboBox2Tag.Name = "comboBox2Tag";
            this.comboBox2Tag.Size = new System.Drawing.Size(230, 23);
            this.comboBox2Tag.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "ROOM NAME";
            // 
            // comboBox3Room
            // 
            this.comboBox3Room.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3Room.FormattingEnabled = true;
            this.comboBox3Room.Location = new System.Drawing.Point(347, 126);
            this.comboBox3Room.Name = "comboBox3Room";
            this.comboBox3Room.Size = new System.Drawing.Size(214, 23);
            this.comboBox3Room.TabIndex = 8;
            this.comboBox3Room.SelectedIndexChanged += new System.EventHandler(this.comboBox3Room_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "BUILDING NAME";
            // 
            // textBox1BuildingName
            // 
            this.textBox1BuildingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1BuildingName.Location = new System.Drawing.Point(131, 161);
            this.textBox1BuildingName.Name = "textBox1BuildingName";
            this.textBox1BuildingName.ReadOnly = true;
            this.textBox1BuildingName.Size = new System.Drawing.Size(176, 21);
            this.textBox1BuildingName.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(337, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "CAPACITY";
            // 
            // textBox1Capacity
            // 
            this.textBox1Capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1Capacity.Location = new System.Drawing.Point(414, 161);
            this.textBox1Capacity.Name = "textBox1Capacity";
            this.textBox1Capacity.ReadOnly = true;
            this.textBox1Capacity.Size = new System.Drawing.Size(100, 21);
            this.textBox1Capacity.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(555, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "TYPE";
            // 
            // textBox1Type
            // 
            this.textBox1Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1Type.Location = new System.Drawing.Point(603, 161);
            this.textBox1Type.Name = "textBox1Type";
            this.textBox1Type.ReadOnly = true;
            this.textBox1Type.Size = new System.Drawing.Size(144, 21);
            this.textBox1Type.TabIndex = 14;
            // 
            // button1Clear
            // 
            this.button1Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Clear.Location = new System.Drawing.Point(77, 210);
            this.button1Clear.Name = "button1Clear";
            this.button1Clear.Size = new System.Drawing.Size(102, 35);
            this.button1Clear.TabIndex = 15;
            this.button1Clear.Text = "CLEAR";
            this.button1Clear.UseVisualStyleBackColor = false;
            this.button1Clear.Click += new System.EventHandler(this.button1Clear_Click);
            // 
            // button1Assign
            // 
            this.button1Assign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1Assign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Assign.Location = new System.Drawing.Point(251, 210);
            this.button1Assign.Name = "button1Assign";
            this.button1Assign.Size = new System.Drawing.Size(102, 35);
            this.button1Assign.TabIndex = 16;
            this.button1Assign.Text = "ASSIGN";
            this.button1Assign.UseVisualStyleBackColor = false;
            this.button1Assign.Click += new System.EventHandler(this.button1Assign_Click);
            // 
            // button1Change
            // 
            this.button1Change.BackColor = System.Drawing.Color.Lime;
            this.button1Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Change.Location = new System.Drawing.Point(437, 210);
            this.button1Change.Name = "button1Change";
            this.button1Change.Size = new System.Drawing.Size(102, 35);
            this.button1Change.TabIndex = 17;
            this.button1Change.Text = "CHANGE";
            this.button1Change.UseVisualStyleBackColor = false;
            this.button1Change.Click += new System.EventHandler(this.button1Change_Click);
            // 
            // button1Remove
            // 
            this.button1Remove.BackColor = System.Drawing.Color.Red;
            this.button1Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Remove.Location = new System.Drawing.Point(603, 210);
            this.button1Remove.Name = "button1Remove";
            this.button1Remove.Size = new System.Drawing.Size(102, 35);
            this.button1Remove.TabIndex = 18;
            this.button1Remove.Text = "REMOVE";
            this.button1Remove.UseVisualStyleBackColor = false;
            this.button1Remove.Click += new System.EventHandler(this.button1Remove_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(16, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "FILTER BY SUBJECT";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // comboBox1FilterSub
            // 
            this.comboBox1FilterSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1FilterSub.FormattingEnabled = true;
            this.comboBox1FilterSub.Location = new System.Drawing.Point(134, 258);
            this.comboBox1FilterSub.Name = "comboBox1FilterSub";
            this.comboBox1FilterSub.Size = new System.Drawing.Size(249, 23);
            this.comboBox1FilterSub.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Yellow;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(414, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "FILTER BY TAG";
            // 
            // comboBox2FilterTag
            // 
            this.comboBox2FilterTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2FilterTag.FormattingEnabled = true;
            this.comboBox2FilterTag.Location = new System.Drawing.Point(506, 259);
            this.comboBox2FilterTag.Name = "comboBox2FilterTag";
            this.comboBox2FilterTag.Size = new System.Drawing.Size(241, 23);
            this.comboBox2FilterTag.TabIndex = 22;
            // 
            // dataGridView1RoomSubject
            // 
            this.dataGridView1RoomSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1RoomSubject.Location = new System.Drawing.Point(13, 328);
            this.dataGridView1RoomSubject.Name = "dataGridView1RoomSubject";
            this.dataGridView1RoomSubject.Size = new System.Drawing.Size(769, 168);
            this.dataGridView1RoomSubject.TabIndex = 23;
            this.dataGridView1RoomSubject.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1RoomSubject_CellContentClick);
            this.dataGridView1RoomSubject.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1RoomSubject_RowHeaderMouseClick);
            // 
            // button1Filter
            // 
            this.button1Filter.BackColor = System.Drawing.Color.Violet;
            this.button1Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Filter.Location = new System.Drawing.Point(374, 287);
            this.button1Filter.Name = "button1Filter";
            this.button1Filter.Size = new System.Drawing.Size(102, 35);
            this.button1Filter.TabIndex = 24;
            this.button1Filter.Text = "FILTER";
            this.button1Filter.UseVisualStyleBackColor = false;
            this.button1Filter.Click += new System.EventHandler(this.button1Filter_Click);
            // 
            // AssignRoomForSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 501);
            this.Controls.Add(this.button1Filter);
            this.Controls.Add(this.dataGridView1RoomSubject);
            this.Controls.Add(this.comboBox2FilterTag);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox1FilterSub);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1Remove);
            this.Controls.Add(this.button1Change);
            this.Controls.Add(this.button1Assign);
            this.Controls.Add(this.button1Clear);
            this.Controls.Add(this.textBox1Type);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1Capacity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1BuildingName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox3Room);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2Tag);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1Subject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AssignRoomForSubject";
            this.Text = "AssignRoomForSubject";
            this.Load += new System.EventHandler(this.AssignRoomForSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1RoomSubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1Subject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2Tag;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox3Room;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1BuildingName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1Capacity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1Type;
        private System.Windows.Forms.Button button1Clear;
        private System.Windows.Forms.Button button1Assign;
        private System.Windows.Forms.Button button1Change;
        private System.Windows.Forms.Button button1Remove;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1FilterSub;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox2FilterTag;
        private System.Windows.Forms.DataGridView dataGridView1RoomSubject;
        private System.Windows.Forms.Button button1Filter;
    }
}