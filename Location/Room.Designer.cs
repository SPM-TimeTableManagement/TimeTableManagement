﻿namespace Location
{
    partial class Room
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
            this.comboBoxBuildingName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxFloorNo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxcapacity = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonAddR = new System.Windows.Forms.Button();
            this.button1UpdateR = new System.Windows.Forms.Button();
            this.buttonDeleteR = new System.Windows.Forms.Button();
            this.buttonClearR = new System.Windows.Forms.Button();
            this.dataGridViewRoom = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Building Name";
            // 
            // comboBoxBuildingName
            // 
            this.comboBoxBuildingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBuildingName.FormattingEnabled = true;
            this.comboBoxBuildingName.Items.AddRange(new object[] {
            "Main Hall",
            "Computing",
            "New",
            "Art",
            "Business"});
            this.comboBoxBuildingName.Location = new System.Drawing.Point(177, 70);
            this.comboBoxBuildingName.Name = "comboBoxBuildingName";
            this.comboBoxBuildingName.Size = new System.Drawing.Size(179, 28);
            this.comboBoxBuildingName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "FloorNo";
            // 
            // comboBoxFloorNo
            // 
            this.comboBoxFloorNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFloorNo.FormattingEnabled = true;
            this.comboBoxFloorNo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxFloorNo.Location = new System.Drawing.Point(177, 137);
            this.comboBoxFloorNo.Name = "comboBoxFloorNo";
            this.comboBoxFloorNo.Size = new System.Drawing.Size(84, 28);
            this.comboBoxFloorNo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Room ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(177, 212);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(56, 26);
            this.textBoxID.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Room Name";
            // 
            // textBoxname
            // 
            this.textBoxname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxname.Location = new System.Drawing.Point(177, 275);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(179, 26);
            this.textBoxname.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Capacity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Type";
            // 
            // textBoxcapacity
            // 
            this.textBoxcapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcapacity.Location = new System.Drawing.Point(177, 340);
            this.textBoxcapacity.Name = "textBoxcapacity";
            this.textBoxcapacity.Size = new System.Drawing.Size(56, 26);
            this.textBoxcapacity.TabIndex = 10;
            // 
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "LAB",
            "LECTURE"});
            this.comboBoxType.Location = new System.Drawing.Point(177, 384);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(179, 28);
            this.comboBoxType.TabIndex = 11;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(512, 76);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(244, 26);
            this.textBoxSearch.TabIndex = 12;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonAddR
            // 
            this.buttonAddR.BackColor = System.Drawing.Color.Cyan;
            this.buttonAddR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddR.Location = new System.Drawing.Point(186, 476);
            this.buttonAddR.Name = "buttonAddR";
            this.buttonAddR.Size = new System.Drawing.Size(96, 46);
            this.buttonAddR.TabIndex = 13;
            this.buttonAddR.Text = "ADD";
            this.buttonAddR.UseVisualStyleBackColor = false;
            this.buttonAddR.Click += new System.EventHandler(this.buttonAddR_Click);
            // 
            // button1UpdateR
            // 
            this.button1UpdateR.BackColor = System.Drawing.Color.Lime;
            this.button1UpdateR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1UpdateR.Location = new System.Drawing.Point(469, 476);
            this.button1UpdateR.Name = "button1UpdateR";
            this.button1UpdateR.Size = new System.Drawing.Size(96, 46);
            this.button1UpdateR.TabIndex = 14;
            this.button1UpdateR.Text = "UPDATE";
            this.button1UpdateR.UseVisualStyleBackColor = false;
            this.button1UpdateR.Click += new System.EventHandler(this.button1UpdateR_Click);
            // 
            // buttonDeleteR
            // 
            this.buttonDeleteR.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteR.Location = new System.Drawing.Point(752, 476);
            this.buttonDeleteR.Name = "buttonDeleteR";
            this.buttonDeleteR.Size = new System.Drawing.Size(96, 46);
            this.buttonDeleteR.TabIndex = 15;
            this.buttonDeleteR.Text = "DELETE";
            this.buttonDeleteR.UseVisualStyleBackColor = false;
            this.buttonDeleteR.Click += new System.EventHandler(this.buttonDeleteR_Click);
            // 
            // buttonClearR
            // 
            this.buttonClearR.BackColor = System.Drawing.Color.Yellow;
            this.buttonClearR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearR.Location = new System.Drawing.Point(818, 18);
            this.buttonClearR.Name = "buttonClearR";
            this.buttonClearR.Size = new System.Drawing.Size(96, 46);
            this.buttonClearR.TabIndex = 16;
            this.buttonClearR.Text = "CLEAR";
            this.buttonClearR.UseVisualStyleBackColor = false;
            this.buttonClearR.Click += new System.EventHandler(this.buttonClearR_Click);
            // 
            // dataGridViewRoom
            // 
            this.dataGridViewRoom.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoom.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewRoom.Location = new System.Drawing.Point(418, 107);
            this.dataGridViewRoom.Name = "dataGridViewRoom";
            this.dataGridViewRoom.Size = new System.Drawing.Size(556, 343);
            this.dataGridViewRoom.TabIndex = 17;
            this.dataGridViewRoom.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewRoom_RowHeaderMouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(423, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "SEARCH";
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 534);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewRoom);
            this.Controls.Add(this.buttonClearR);
            this.Controls.Add(this.buttonDeleteR);
            this.Controls.Add(this.button1UpdateR);
            this.Controls.Add(this.buttonAddR);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBoxcapacity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxFloorNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxBuildingName);
            this.Controls.Add(this.label1);
            this.Name = "Room";
            this.Text = "Room";
            this.Load += new System.EventHandler(this.Room_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxBuildingName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFloorNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxcapacity;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonAddR;
        private System.Windows.Forms.Button button1UpdateR;
        private System.Windows.Forms.Button buttonDeleteR;
        private System.Windows.Forms.Button buttonClearR;
        private System.Windows.Forms.DataGridView dataGridViewRoom;
        private System.Windows.Forms.Label label7;
    }
}