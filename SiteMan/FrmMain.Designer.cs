namespace SiteMan
{
    partial class FrmMain
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dgSites = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSites)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(598, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 17);
            this.lblStatus.Text = "Ready";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(0, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 48);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action Center";
            // 
            // btnLoad
            // 
            this.btnLoad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLoad.Location = new System.Drawing.Point(6, 17);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(57, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(134, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Check";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(198, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(70, 17);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(57, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Login";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dgSites
            // 
            this.dgSites.AllowUserToDeleteRows = false;
            this.dgSites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSites.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colUrl,
            this.colImg,
            this.colVCode,
            this.colResult});
            this.dgSites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSites.Location = new System.Drawing.Point(0, 0);
            this.dgSites.MultiSelect = false;
            this.dgSites.Name = "dgSites";
            this.dgSites.RowTemplate.Height = 23;
            this.dgSites.Size = new System.Drawing.Size(523, 291);
            this.dgSites.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(523, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(75, 291);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selected";
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Location = new System.Drawing.Point(6, 96);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(57, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Check";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button7.Location = new System.Drawing.Point(6, 134);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(57, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "Clear";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(6, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(57, 23);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button8.Location = new System.Drawing.Point(6, 58);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(57, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "Login";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 85;
            // 
            // colUrl
            // 
            this.colUrl.DataPropertyName = "Url";
            this.colUrl.HeaderText = "Url";
            this.colUrl.Name = "colUrl";
            this.colUrl.Width = 140;
            // 
            // colImg
            // 
            this.colImg.HeaderText = "Captcha";
            this.colImg.Name = "colImg";
            // 
            // colVCode
            // 
            this.colVCode.HeaderText = "VCode";
            this.colVCode.Name = "colVCode";
            this.colVCode.Width = 50;
            // 
            // colResult
            // 
            this.colResult.HeaderText = "Result";
            this.colResult.Name = "colResult";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 361);
            this.Controls.Add(this.dgSites);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.MinimumSize = new System.Drawing.Size(570, 400);
            this.Name = "FrmMain";
            this.Text = "SiteMan";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSites)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dgSites;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResult;
    }
}

