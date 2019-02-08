namespace Zyborg.IAMCreds.WinForm
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.accessKeysDataGrid = new System.Windows.Forms.DataGridView();
            this.accessKeyIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.createdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUsedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteLinkColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.akCreate = new System.Windows.Forms.LinkLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.passwordResetRequiredCheckBox = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.passwordLastUsedTextBox = new System.Windows.Forms.TextBox();
            this.passwordCreateDateTextBox = new System.Windows.Forms.TextBox();
            this.resetPasswordLinkLabel = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.arnTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.refreshLinkLabel = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accessKeysDataGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 296);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1083, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.accessKeysDataGrid);
            this.tabPage1.Controls.Add(this.akCreate);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1067, 378);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Access Keys";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // accessKeysDataGrid
            // 
            this.accessKeysDataGrid.AllowUserToAddRows = false;
            this.accessKeysDataGrid.AllowUserToDeleteRows = false;
            this.accessKeysDataGrid.AllowUserToResizeRows = false;
            this.accessKeysDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.accessKeysDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accessKeysDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accessKeyIdColumn,
            this.activeColumn,
            this.createdColumn,
            this.lastUsedColumn,
            this.serviceNameColumn,
            this.deleteLinkColumn});
            this.accessKeysDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accessKeysDataGrid.Location = new System.Drawing.Point(3, 76);
            this.accessKeysDataGrid.MultiSelect = false;
            this.accessKeysDataGrid.Name = "accessKeysDataGrid";
            this.accessKeysDataGrid.RowHeadersVisible = false;
            this.accessKeysDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.accessKeysDataGrid.RowTemplate.Height = 33;
            this.accessKeysDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.accessKeysDataGrid.Size = new System.Drawing.Size(1061, 299);
            this.accessKeysDataGrid.TabIndex = 1;
            this.accessKeysDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.accessKeysDataGrid_CellContentClick);
            // 
            // accessKeyIdColumn
            // 
            this.accessKeyIdColumn.DataPropertyName = "AccessKeyId";
            this.accessKeyIdColumn.HeaderText = "Access Key ID";
            this.accessKeyIdColumn.MinimumWidth = 50;
            this.accessKeyIdColumn.Name = "accessKeyIdColumn";
            this.accessKeyIdColumn.ReadOnly = true;
            // 
            // activeColumn
            // 
            this.activeColumn.DataPropertyName = "Status";
            this.activeColumn.HeaderText = "Active";
            this.activeColumn.MinimumWidth = 50;
            this.activeColumn.Name = "activeColumn";
            // 
            // createdColumn
            // 
            this.createdColumn.DataPropertyName = "CreateDate";
            this.createdColumn.HeaderText = "Created";
            this.createdColumn.MinimumWidth = 50;
            this.createdColumn.Name = "createdColumn";
            // 
            // lastUsedColumn
            // 
            this.lastUsedColumn.DataPropertyName = "LastUsedDate";
            this.lastUsedColumn.HeaderText = "Last Used";
            this.lastUsedColumn.MinimumWidth = 50;
            this.lastUsedColumn.Name = "lastUsedColumn";
            // 
            // serviceNameColumn
            // 
            this.serviceNameColumn.DataPropertyName = "ServiceName";
            this.serviceNameColumn.HeaderText = "Last Service";
            this.serviceNameColumn.MinimumWidth = 50;
            this.serviceNameColumn.Name = "serviceNameColumn";
            this.serviceNameColumn.ReadOnly = true;
            // 
            // deleteLinkColumn
            // 
            this.deleteLinkColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.deleteLinkColumn.DataPropertyName = "DeleteLinkLabel";
            this.deleteLinkColumn.HeaderText = "";
            this.deleteLinkColumn.MinimumWidth = 50;
            this.deleteLinkColumn.Name = "deleteLinkColumn";
            this.deleteLinkColumn.Text = "Delete";
            this.deleteLinkColumn.UseColumnTextForLinkValue = true;
            this.deleteLinkColumn.VisitedLinkColor = System.Drawing.Color.Blue;
            this.deleteLinkColumn.Width = 50;
            // 
            // akCreate
            // 
            this.akCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.akCreate.Location = new System.Drawing.Point(3, 3);
            this.akCreate.Name = "akCreate";
            this.akCreate.Size = new System.Drawing.Size(1061, 73);
            this.akCreate.TabIndex = 0;
            this.akCreate.TabStop = true;
            this.akCreate.Text = "Create Access Key";
            this.akCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.akCreate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.akCreate_LinkClicked);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1067, 375);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Password";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.passwordResetRequiredCheckBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.passwordLastUsedTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.passwordCreateDateTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.resetPasswordLinkLabel, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1041, 260);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // passwordResetRequiredCheckBox
            // 
            this.passwordResetRequiredCheckBox.AutoSize = true;
            this.passwordResetRequiredCheckBox.Enabled = false;
            this.passwordResetRequiredCheckBox.Location = new System.Drawing.Point(224, 123);
            this.passwordResetRequiredCheckBox.Name = "passwordResetRequiredCheckBox";
            this.passwordResetRequiredCheckBox.Size = new System.Drawing.Size(193, 29);
            this.passwordResetRequiredCheckBox.TabIndex = 9;
            this.passwordResetRequiredCheckBox.Text = "Reset Required";
            this.passwordResetRequiredCheckBox.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 25);
            this.label10.TabIndex = 6;
            this.label10.Text = "Password Created:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 63);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(215, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Password Last Used:";
            // 
            // passwordLastUsedTextBox
            // 
            this.passwordLastUsedTextBox.Location = new System.Drawing.Point(224, 63);
            this.passwordLastUsedTextBox.Name = "passwordLastUsedTextBox";
            this.passwordLastUsedTextBox.ReadOnly = true;
            this.passwordLastUsedTextBox.Size = new System.Drawing.Size(392, 31);
            this.passwordLastUsedTextBox.TabIndex = 3;
            // 
            // passwordCreateDateTextBox
            // 
            this.passwordCreateDateTextBox.Location = new System.Drawing.Point(224, 3);
            this.passwordCreateDateTextBox.Name = "passwordCreateDateTextBox";
            this.passwordCreateDateTextBox.ReadOnly = true;
            this.passwordCreateDateTextBox.Size = new System.Drawing.Size(392, 31);
            this.passwordCreateDateTextBox.TabIndex = 4;
            // 
            // resetPasswordLinkLabel
            // 
            this.resetPasswordLinkLabel.AutoSize = true;
            this.resetPasswordLinkLabel.Location = new System.Drawing.Point(224, 203);
            this.resetPasswordLinkLabel.Margin = new System.Windows.Forms.Padding(3);
            this.resetPasswordLinkLabel.Name = "resetPasswordLinkLabel";
            this.resetPasswordLinkLabel.Size = new System.Drawing.Size(168, 25);
            this.resetPasswordLinkLabel.TabIndex = 10;
            this.resetPasswordLinkLabel.TabStop = true;
            this.resetPasswordLinkLabel.Text = "Reset Password";
            this.resetPasswordLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.resetPasswordLinkLabel_LinkClicked);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.arnTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.userIdTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.usernameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(20);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1083, 296);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(23, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 79);
            this.label7.TabIndex = 1;
            this.label7.Text = "Username:";
            // 
            // arnTextBox
            // 
            this.arnTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arnTextBox.Location = new System.Drawing.Point(145, 193);
            this.arnTextBox.Name = "arnTextBox";
            this.arnTextBox.ReadOnly = true;
            this.arnTextBox.Size = new System.Drawing.Size(915, 31);
            this.arnTextBox.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(23, 193);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 80);
            this.label8.TabIndex = 5;
            this.label8.Text = "ARN:";
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userIdTextBox.Location = new System.Drawing.Point(145, 108);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.ReadOnly = true;
            this.userIdTextBox.Size = new System.Drawing.Size(915, 31);
            this.userIdTextBox.TabIndex = 3;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameTextBox.Location = new System.Drawing.Point(145, 23);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.ReadOnly = true;
            this.usernameTextBox.Size = new System.Drawing.Size(915, 31);
            this.usernameTextBox.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(23, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 79);
            this.label6.TabIndex = 0;
            this.label6.Text = "User ID:";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1061, 369);
            this.panel1.TabIndex = 2;
            // 
            // refreshLinkLabel
            // 
            this.refreshLinkLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.refreshLinkLabel.Location = new System.Drawing.Point(0, 721);
            this.refreshLinkLabel.Name = "refreshLinkLabel";
            this.refreshLinkLabel.Size = new System.Drawing.Size(1083, 55);
            this.refreshLinkLabel.TabIndex = 7;
            this.refreshLinkLabel.TabStop = true;
            this.refreshLinkLabel.Text = "Refresh";
            this.refreshLinkLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.refreshLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.refreshLinkLabel_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 776);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.refreshLinkLabel);
            this.Name = "MainForm";
            this.Text = "IAM Credentials Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accessKeysDataGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.LinkLabel akCreate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox arnTextBox;
        private System.Windows.Forms.TextBox userIdTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox passwordCreateDateTextBox;
        private System.Windows.Forms.TextBox passwordLastUsedTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox passwordResetRequiredCheckBox;
        private System.Windows.Forms.DataGridView accessKeysDataGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessKeyIdColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUsedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceNameColumn;
        private System.Windows.Forms.DataGridViewLinkColumn deleteLinkColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.LinkLabel resetPasswordLinkLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel refreshLinkLabel;
    }
}

