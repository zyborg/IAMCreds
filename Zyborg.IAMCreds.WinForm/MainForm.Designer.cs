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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.accessKeysTabPage = new System.Windows.Forms.TabPage();
            this.accessKeysDataGrid = new System.Windows.Forms.DataGridView();
            this.passwordTabPage = new System.Windows.Forms.TabPage();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.passwordTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.passwordResetRequiredCheckBox = new System.Windows.Forms.CheckBox();
            this.passwordCreatedLabel = new System.Windows.Forms.Label();
            this.passwordLastUsedLabel = new System.Windows.Forms.Label();
            this.passwordLastUsedTextBox = new System.Windows.Forms.TextBox();
            this.passwordCreateDateTextBox = new System.Windows.Forms.TextBox();
            this.resetPasswordLinkLabel = new System.Windows.Forms.LinkLabel();
            this.userInfoTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.arnTextBox = new System.Windows.Forms.TextBox();
            this.arnLabel = new System.Windows.Forms.Label();
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.akCreateButton = new System.Windows.Forms.Button();
            this.commonButtonsPanel = new System.Windows.Forms.Panel();
            this.refreshButton = new System.Windows.Forms.Button();
            this.accessKeysButtonPanel = new System.Windows.Forms.Panel();
            this.accessKeyIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.createdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUsedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteLinkColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.mainTabControl.SuspendLayout();
            this.accessKeysTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accessKeysDataGrid)).BeginInit();
            this.passwordTabPage.SuspendLayout();
            this.passwordPanel.SuspendLayout();
            this.passwordTableLayout.SuspendLayout();
            this.userInfoTableLayout.SuspendLayout();
            this.commonButtonsPanel.SuspendLayout();
            this.accessKeysButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.accessKeysTabPage);
            this.mainTabControl.Controls.Add(this.passwordTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 382);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1083, 394);
            this.mainTabControl.TabIndex = 0;
            // 
            // accessKeysTabPage
            // 
            this.accessKeysTabPage.Controls.Add(this.accessKeysDataGrid);
            this.accessKeysTabPage.Controls.Add(this.accessKeysButtonPanel);
            this.accessKeysTabPage.Location = new System.Drawing.Point(8, 39);
            this.accessKeysTabPage.Name = "accessKeysTabPage";
            this.accessKeysTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.accessKeysTabPage.Size = new System.Drawing.Size(1067, 347);
            this.accessKeysTabPage.TabIndex = 0;
            this.accessKeysTabPage.Text = "Access Keys    ";
            this.accessKeysTabPage.UseVisualStyleBackColor = true;
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
            this.deleteLinkColumn,
            this.Column1});
            this.accessKeysDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accessKeysDataGrid.Location = new System.Drawing.Point(3, 84);
            this.accessKeysDataGrid.MultiSelect = false;
            this.accessKeysDataGrid.Name = "accessKeysDataGrid";
            this.accessKeysDataGrid.RowHeadersVisible = false;
            this.accessKeysDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.accessKeysDataGrid.RowTemplate.Height = 33;
            this.accessKeysDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.accessKeysDataGrid.Size = new System.Drawing.Size(1061, 260);
            this.accessKeysDataGrid.TabIndex = 1;
            this.accessKeysDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.accessKeysDataGrid_CellContentClick);
            // 
            // passwordTabPage
            // 
            this.passwordTabPage.Controls.Add(this.passwordPanel);
            this.passwordTabPage.Location = new System.Drawing.Point(8, 39);
            this.passwordTabPage.Name = "passwordTabPage";
            this.passwordTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.passwordTabPage.Size = new System.Drawing.Size(1067, 347);
            this.passwordTabPage.TabIndex = 1;
            this.passwordTabPage.Text = "Password    ";
            this.passwordTabPage.UseVisualStyleBackColor = true;
            // 
            // passwordPanel
            // 
            this.passwordPanel.AutoScroll = true;
            this.passwordPanel.Controls.Add(this.passwordTableLayout);
            this.passwordPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordPanel.Location = new System.Drawing.Point(3, 3);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Padding = new System.Windows.Forms.Padding(10);
            this.passwordPanel.Size = new System.Drawing.Size(1061, 341);
            this.passwordPanel.TabIndex = 2;
            // 
            // passwordTableLayout
            // 
            this.passwordTableLayout.ColumnCount = 2;
            this.passwordTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.passwordTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.passwordTableLayout.Controls.Add(this.passwordResetRequiredCheckBox, 1, 2);
            this.passwordTableLayout.Controls.Add(this.passwordCreatedLabel, 0, 0);
            this.passwordTableLayout.Controls.Add(this.passwordCreateDateTextBox, 1, 0);
            this.passwordTableLayout.Controls.Add(this.passwordLastUsedLabel, 0, 1);
            this.passwordTableLayout.Controls.Add(this.passwordLastUsedTextBox, 1, 1);
            this.passwordTableLayout.Controls.Add(this.resetPasswordLinkLabel, 1, 4);
            this.passwordTableLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.passwordTableLayout.Location = new System.Drawing.Point(10, 10);
            this.passwordTableLayout.Name = "passwordTableLayout";
            this.passwordTableLayout.RowCount = 5;
            this.passwordTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.passwordTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.passwordTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.passwordTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.passwordTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.passwordTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.passwordTableLayout.Size = new System.Drawing.Size(1041, 260);
            this.passwordTableLayout.TabIndex = 1;
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
            // passwordCreatedLabel
            // 
            this.passwordCreatedLabel.AutoSize = true;
            this.passwordCreatedLabel.Location = new System.Drawing.Point(3, 3);
            this.passwordCreatedLabel.Margin = new System.Windows.Forms.Padding(3);
            this.passwordCreatedLabel.Name = "passwordCreatedLabel";
            this.passwordCreatedLabel.Size = new System.Drawing.Size(194, 25);
            this.passwordCreatedLabel.TabIndex = 6;
            this.passwordCreatedLabel.Text = "Password Created:";
            // 
            // passwordLastUsedLabel
            // 
            this.passwordLastUsedLabel.AutoSize = true;
            this.passwordLastUsedLabel.Location = new System.Drawing.Point(3, 63);
            this.passwordLastUsedLabel.Margin = new System.Windows.Forms.Padding(3);
            this.passwordLastUsedLabel.Name = "passwordLastUsedLabel";
            this.passwordLastUsedLabel.Size = new System.Drawing.Size(215, 25);
            this.passwordLastUsedLabel.TabIndex = 5;
            this.passwordLastUsedLabel.Text = "Password Last Used:";
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
            // userInfoTableLayout
            // 
            this.userInfoTableLayout.ColumnCount = 2;
            this.userInfoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.userInfoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.userInfoTableLayout.Controls.Add(this.usernameLabel, 0, 0);
            this.userInfoTableLayout.Controls.Add(this.usernameTextBox, 1, 0);
            this.userInfoTableLayout.Controls.Add(this.userIdLabel, 0, 1);
            this.userInfoTableLayout.Controls.Add(this.userIdTextBox, 1, 1);
            this.userInfoTableLayout.Controls.Add(this.arnLabel, 0, 2);
            this.userInfoTableLayout.Controls.Add(this.arnTextBox, 1, 2);
            this.userInfoTableLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.userInfoTableLayout.Location = new System.Drawing.Point(0, 0);
            this.userInfoTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.userInfoTableLayout.Name = "userInfoTableLayout";
            this.userInfoTableLayout.Padding = new System.Windows.Forms.Padding(20);
            this.userInfoTableLayout.RowCount = 3;
            this.userInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.userInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.userInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.userInfoTableLayout.Size = new System.Drawing.Size(1083, 296);
            this.userInfoTableLayout.TabIndex = 6;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameLabel.Location = new System.Drawing.Point(23, 23);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(116, 79);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username:";
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
            // arnLabel
            // 
            this.arnLabel.AutoSize = true;
            this.arnLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arnLabel.Location = new System.Drawing.Point(23, 193);
            this.arnLabel.Margin = new System.Windows.Forms.Padding(3);
            this.arnLabel.Name = "arnLabel";
            this.arnLabel.Size = new System.Drawing.Size(116, 80);
            this.arnLabel.TabIndex = 5;
            this.arnLabel.Text = "ARN:";
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
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userIdLabel.Location = new System.Drawing.Point(23, 108);
            this.userIdLabel.Margin = new System.Windows.Forms.Padding(3);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(116, 79);
            this.userIdLabel.TabIndex = 0;
            this.userIdLabel.Text = "User ID:";
            // 
            // akCreateButton
            // 
            this.akCreateButton.Location = new System.Drawing.Point(15, 15);
            this.akCreateButton.Name = "akCreateButton";
            this.akCreateButton.Size = new System.Drawing.Size(250, 50);
            this.akCreateButton.TabIndex = 2;
            this.akCreateButton.Text = "Create Acess Key";
            this.akCreateButton.UseVisualStyleBackColor = true;
            this.akCreateButton.Click += new System.EventHandler(this.akCreateButton_Click);
            // 
            // commonButtonsPanel
            // 
            this.commonButtonsPanel.Controls.Add(this.refreshButton);
            this.commonButtonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.commonButtonsPanel.Location = new System.Drawing.Point(0, 296);
            this.commonButtonsPanel.Name = "commonButtonsPanel";
            this.commonButtonsPanel.Size = new System.Drawing.Size(1083, 86);
            this.commonButtonsPanel.TabIndex = 8;
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.Location = new System.Drawing.Point(921, 16);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(150, 50);
            this.refreshButton.TabIndex = 9;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // accessKeysButtonPanel
            // 
            this.accessKeysButtonPanel.Controls.Add(this.akCreateButton);
            this.accessKeysButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.accessKeysButtonPanel.Location = new System.Drawing.Point(3, 3);
            this.accessKeysButtonPanel.Name = "accessKeysButtonPanel";
            this.accessKeysButtonPanel.Size = new System.Drawing.Size(1061, 81);
            this.accessKeysButtonPanel.TabIndex = 9;
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
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Text = "Delete";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 776);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.commonButtonsPanel);
            this.Controls.Add(this.userInfoTableLayout);
            this.Name = "MainForm";
            this.Text = "IAM Credentials Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainTabControl.ResumeLayout(false);
            this.accessKeysTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accessKeysDataGrid)).EndInit();
            this.passwordTabPage.ResumeLayout(false);
            this.passwordPanel.ResumeLayout(false);
            this.passwordTableLayout.ResumeLayout(false);
            this.passwordTableLayout.PerformLayout();
            this.userInfoTableLayout.ResumeLayout(false);
            this.userInfoTableLayout.PerformLayout();
            this.commonButtonsPanel.ResumeLayout(false);
            this.accessKeysButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage accessKeysTabPage;
        private System.Windows.Forms.TabPage passwordTabPage;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.TextBox arnTextBox;
        private System.Windows.Forms.TextBox userIdTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label arnLabel;
        private System.Windows.Forms.TextBox passwordCreateDateTextBox;
        private System.Windows.Forms.TextBox passwordLastUsedTextBox;
        private System.Windows.Forms.Label passwordLastUsedLabel;
        private System.Windows.Forms.Label passwordCreatedLabel;
        private System.Windows.Forms.CheckBox passwordResetRequiredCheckBox;
        private System.Windows.Forms.DataGridView accessKeysDataGrid;
        private System.Windows.Forms.TableLayoutPanel userInfoTableLayout;
        private System.Windows.Forms.TableLayoutPanel passwordTableLayout;
        private System.Windows.Forms.LinkLabel resetPasswordLinkLabel;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.Button akCreateButton;
        private System.Windows.Forms.Panel commonButtonsPanel;
        private System.Windows.Forms.Panel accessKeysButtonPanel;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessKeyIdColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUsedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceNameColumn;
        private System.Windows.Forms.DataGridViewLinkColumn deleteLinkColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}

