namespace SPM
{
    partial class AssignRoomForTag
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTagName = new System.Windows.Forms.ComboBox();
            this.comboBoxRoomName = new System.Windows.Forms.ComboBox();
            this.textBoxCapacity = new System.Windows.Forms.TextBox();
            this.textBoxRoomType = new System.Windows.Forms.TextBox();
            this.buttonAssign = new System.Windows.Forms.Button();
            this.button1Reomove = new System.Windows.Forms.Button();
            this.button1Change = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewTagRoom = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.button1Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTagRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ASSIGN ROOM(S) FOR TAG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "TAG NAME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(440, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "ROOM NAME:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "CAPACITY:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(443, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "ROOM TYPE:";
            // 
            // comboBoxTagName
            // 
            this.comboBoxTagName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTagName.FormattingEnabled = true;
            this.comboBoxTagName.Location = new System.Drawing.Point(100, 47);
            this.comboBoxTagName.Name = "comboBoxTagName";
            this.comboBoxTagName.Size = new System.Drawing.Size(267, 23);
            this.comboBoxTagName.TabIndex = 5;
            // 
            // comboBoxRoomName
            // 
            this.comboBoxRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRoomName.FormattingEnabled = true;
            this.comboBoxRoomName.Location = new System.Drawing.Point(543, 47);
            this.comboBoxRoomName.Name = "comboBoxRoomName";
            this.comboBoxRoomName.Size = new System.Drawing.Size(228, 23);
            this.comboBoxRoomName.TabIndex = 6;
            this.comboBoxRoomName.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoomName_SelectedIndexChanged);
            // 
            // textBoxCapacity
            // 
            this.textBoxCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCapacity.Location = new System.Drawing.Point(100, 101);
            this.textBoxCapacity.Name = "textBoxCapacity";
            this.textBoxCapacity.ReadOnly = true;
            this.textBoxCapacity.Size = new System.Drawing.Size(100, 21);
            this.textBoxCapacity.TabIndex = 7;
            this.textBoxCapacity.TextChanged += new System.EventHandler(this.textBoxCapacity_TextChanged);
            // 
            // textBoxRoomType
            // 
            this.textBoxRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRoomType.Location = new System.Drawing.Point(543, 101);
            this.textBoxRoomType.Name = "textBoxRoomType";
            this.textBoxRoomType.ReadOnly = true;
            this.textBoxRoomType.Size = new System.Drawing.Size(191, 21);
            this.textBoxRoomType.TabIndex = 8;
            // 
            // buttonAssign
            // 
            this.buttonAssign.BackColor = System.Drawing.Color.Blue;
            this.buttonAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAssign.Location = new System.Drawing.Point(255, 146);
            this.buttonAssign.Name = "buttonAssign";
            this.buttonAssign.Size = new System.Drawing.Size(102, 35);
            this.buttonAssign.TabIndex = 9;
            this.buttonAssign.Text = "ASSIGN";
            this.buttonAssign.UseVisualStyleBackColor = false;
            this.buttonAssign.Click += new System.EventHandler(this.buttonAssign_Click);
            // 
            // button1Reomove
            // 
            this.button1Reomove.BackColor = System.Drawing.Color.Red;
            this.button1Reomove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Reomove.Location = new System.Drawing.Point(50, 145);
            this.button1Reomove.Name = "button1Reomove";
            this.button1Reomove.Size = new System.Drawing.Size(102, 35);
            this.button1Reomove.TabIndex = 10;
            this.button1Reomove.Text = "REMOVE";
            this.button1Reomove.UseVisualStyleBackColor = false;
            this.button1Reomove.Click += new System.EventHandler(this.button1Reomove_Click);
            // 
            // button1Change
            // 
            this.button1Change.BackColor = System.Drawing.Color.Lime;
            this.button1Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Change.Location = new System.Drawing.Point(461, 146);
            this.button1Change.Name = "button1Change";
            this.button1Change.Size = new System.Drawing.Size(102, 35);
            this.button1Change.TabIndex = 11;
            this.button1Change.Text = "CHANGE";
            this.button1Change.UseVisualStyleBackColor = false;
            this.button1Change.Click += new System.EventHandler(this.button1Change_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(272, 206);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(345, 21);
            this.textBoxSearch.TabIndex = 12;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Yellow;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(193, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "SEARCH:";
            // 
            // dataGridViewTagRoom
            // 
            this.dataGridViewTagRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTagRoom.Location = new System.Drawing.Point(134, 259);
            this.dataGridViewTagRoom.Name = "dataGridViewTagRoom";
            this.dataGridViewTagRoom.Size = new System.Drawing.Size(515, 230);
            this.dataGridViewTagRoom.TabIndex = 14;
            this.dataGridViewTagRoom.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewTagRoom_RowHeaderMouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(223, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "ID:";
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(255, 101);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(100, 21);
            this.textBoxID.TabIndex = 16;
            // 
            // button1Clear
            // 
            this.button1Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Clear.Location = new System.Drawing.Point(645, 146);
            this.button1Clear.Name = "button1Clear";
            this.button1Clear.Size = new System.Drawing.Size(102, 35);
            this.button1Clear.TabIndex = 17;
            this.button1Clear.Text = "CLEAR";
            this.button1Clear.UseVisualStyleBackColor = false;
            this.button1Clear.Click += new System.EventHandler(this.button1Clear_Click);
            // 
            // AssignRoomForTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 501);
            this.Controls.Add(this.button1Clear);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewTagRoom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.button1Change);
            this.Controls.Add(this.button1Reomove);
            this.Controls.Add(this.buttonAssign);
            this.Controls.Add(this.textBoxRoomType);
            this.Controls.Add(this.textBoxCapacity);
            this.Controls.Add(this.comboBoxRoomName);
            this.Controls.Add(this.comboBoxTagName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AssignRoomForTag";
            this.Text = "AssignRoomForTag";
            this.Load += new System.EventHandler(this.AssignRoomForTag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTagRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxTagName;
        private System.Windows.Forms.ComboBox comboBoxRoomName;
        private System.Windows.Forms.TextBox textBoxCapacity;
        private System.Windows.Forms.TextBox textBoxRoomType;
        private System.Windows.Forms.Button buttonAssign;
        private System.Windows.Forms.Button button1Reomove;
        private System.Windows.Forms.Button button1Change;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewTagRoom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button button1Clear;
    }
}