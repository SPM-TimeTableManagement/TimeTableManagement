namespace SPM
{
    partial class Programme
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
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btnDlt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProgrammeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProgrammeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSaveUpdate = new System.Windows.Forms.Button();
            this.textBoxProgName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxProgCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(470, 255);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(239, 34);
            this.textBoxSearch.TabIndex = 33;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // btnDlt
            // 
            this.btnDlt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDlt.BackColor = System.Drawing.Color.Crimson;
            this.btnDlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDlt.Location = new System.Drawing.Point(503, 534);
            this.btnDlt.Margin = new System.Windows.Forms.Padding(5);
            this.btnDlt.Name = "btnDlt";
            this.btnDlt.Size = new System.Drawing.Size(261, 58);
            this.btnDlt.TabIndex = 32;
            this.btnDlt.Text = "Delete";
            this.btnDlt.UseVisualStyleBackColor = false;
            this.btnDlt.Click += new System.EventHandler(this.btnDlt_Click);
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
            this.ProgrammeName,
            this.ProgrammeCode});
            this.dataGridView1.Location = new System.Drawing.Point(93, 316);
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
            this.dataGridView1.Size = new System.Drawing.Size(817, 178);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // ProgrammeName
            // 
            this.ProgrammeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProgrammeName.HeaderText = "Programme Name";
            this.ProgrammeName.MinimumWidth = 6;
            this.ProgrammeName.Name = "ProgrammeName";
            // 
            // ProgrammeCode
            // 
            this.ProgrammeCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProgrammeCode.HeaderText = "Programme Code";
            this.ProgrammeCode.MinimumWidth = 6;
            this.ProgrammeCode.Name = "ProgrammeCode";
            // 
            // buttonSaveUpdate
            // 
            this.buttonSaveUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSaveUpdate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSaveUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveUpdate.Location = new System.Drawing.Point(361, 160);
            this.buttonSaveUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSaveUpdate.Name = "buttonSaveUpdate";
            this.buttonSaveUpdate.Size = new System.Drawing.Size(261, 58);
            this.buttonSaveUpdate.TabIndex = 30;
            this.buttonSaveUpdate.Text = "Enter";
            this.buttonSaveUpdate.UseVisualStyleBackColor = false;
            this.buttonSaveUpdate.Click += new System.EventHandler(this.buttonSaveUpdate_Click);
            // 
            // textBoxProgName
            // 
            this.textBoxProgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProgName.Location = new System.Drawing.Point(219, 93);
            this.textBoxProgName.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxProgName.Name = "textBoxProgName";
            this.textBoxProgName.Size = new System.Drawing.Size(239, 34);
            this.textBoxProgName.TabIndex = 29;
            this.textBoxProgName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProgName_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(213, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 31);
            this.label4.TabIndex = 28;
            this.label4.Text = "Programme Name";
            // 
            // textBoxProgCode
            // 
            this.textBoxProgCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProgCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProgCode.Location = new System.Drawing.Point(538, 93);
            this.textBoxProgCode.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxProgCode.Name = "textBoxProgCode";
            this.textBoxProgCode.Size = new System.Drawing.Size(239, 34);
            this.textBoxProgCode.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(538, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 31);
            this.label1.TabIndex = 35;
            this.label1.Text = "Programme Code";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(211, 534);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(261, 58);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 256);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 31);
            this.label2.TabIndex = 46;
            this.label2.Text = "Search Programme";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Programme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1080, 665);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.textBoxProgCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.btnDlt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSaveUpdate);
            this.Controls.Add(this.textBoxProgName);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Programme";
            this.Text = "Programme";
            this.Load += new System.EventHandler(this.Programme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnDlt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSaveUpdate;
        private System.Windows.Forms.TextBox textBoxProgName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxProgCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgrammeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgrammeCode;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
    }
}