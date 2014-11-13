namespace PasswordDrawer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Android Store");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Apple ID");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Facebook");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Gmail");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Hotmail");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Live");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("PlayStation Network");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Origin");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Steam");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Skype");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Twitter");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Windows Login");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Windows Store");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Xbox Live");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Yahoo! Mail");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Other");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("All", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabPane = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelStatusLabel = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelAccount = new System.Windows.Forms.Label();
            this.textOther = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.comboType = new System.Windows.Forms.ComboBox();
            tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolTipAddNew = new System.Windows.Forms.ToolTip(this.components);
            tabPane.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane
            // 
            tabPane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            tabPane.Controls.Add(tabPage1);
            tabPane.Controls.Add(tabPage2);
            tabPane.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tabPane.Location = new System.Drawing.Point(12, 12);
            tabPane.Name = "tabPane";
            tabPane.SelectedIndex = 0;
            tabPane.Size = new System.Drawing.Size(531, 239);
            tabPane.TabIndex = 9;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            tabPage1.Controls.Add(this.labelStatus);
            tabPage1.Controls.Add(this.labelStatusLabel);
            tabPage1.Controls.Add(this.buttonCancel);
            tabPage1.Controls.Add(this.label4);
            tabPage1.Controls.Add(this.buttonClear);
            tabPage1.Controls.Add(this.labelPassword);
            tabPage1.Controls.Add(this.buttonSave);
            tabPage1.Controls.Add(this.buttonAddNew);
            tabPage1.Controls.Add(this.labelUserName);
            tabPage1.Controls.Add(this.labelAccount);
            tabPage1.Controls.Add(this.textOther);
            tabPage1.Controls.Add(this.textPassword);
            tabPage1.Controls.Add(this.textUserName);
            tabPage1.Controls.Add(this.comboType);
            tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tabPage1.Location = new System.Drawing.Point(4, 25);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(523, 210);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Details";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.Blue;
            this.labelStatus.Location = new System.Drawing.Point(65, 167);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(24, 13);
            this.labelStatus.TabIndex = 23;
            this.labelStatus.Text = "Idle";
            // 
            // labelStatusLabel
            // 
            this.labelStatusLabel.AutoSize = true;
            this.labelStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusLabel.ForeColor = System.Drawing.Color.Blue;
            this.labelStatusLabel.Location = new System.Drawing.Point(11, 167);
            this.labelStatusLabel.Name = "labelStatusLabel";
            this.labelStatusLabel.Size = new System.Drawing.Size(40, 13);
            this.labelStatusLabel.TabIndex = 22;
            this.labelStatusLabel.Text = "Status:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackgroundImage = global::PasswordDrawer.Properties.Resources.Delete_icon;
            this.buttonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCancel.Enabled = false;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(113, 16);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(32, 28);
            this.buttonCancel.TabIndex = 7;
            this.toolTipAddNew.SetToolTip(this.buttonCancel, "Cancel");
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(211, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "If Other, please specify";
            // 
            // buttonClear
            // 
            this.buttonClear.BackgroundImage = global::PasswordDrawer.Properties.Resources.clear;
            this.buttonClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClear.Enabled = false;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(80, 16);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(32, 28);
            this.buttonClear.TabIndex = 6;
            this.toolTipAddNew.SetToolTip(this.buttonClear, "Clear Form");
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(11, 134);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(68, 16);
            this.labelPassword.TabIndex = 16;
            this.labelPassword.Text = "Password";
            // 
            // buttonSave
            // 
            this.buttonSave.BackgroundImage = global::PasswordDrawer.Properties.Resources.Save_icon;
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSave.Enabled = false;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(47, 16);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(32, 28);
            this.buttonSave.TabIndex = 5;
            this.toolTipAddNew.SetToolTip(this.buttonSave, "Save/Update Record");
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.AccessibleDescription = "Add New Record";
            this.buttonAddNew.BackgroundImage = global::PasswordDrawer.Properties.Resources.add_1_icon1;
            this.buttonAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNew.Location = new System.Drawing.Point(14, 16);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(32, 28);
            this.buttonAddNew.TabIndex = 4;
            this.toolTipAddNew.SetToolTip(this.buttonAddNew, "Add New Record");
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(11, 103);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(71, 16);
            this.labelUserName.TabIndex = 15;
            this.labelUserName.Text = "Username";
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccount.Location = new System.Drawing.Point(11, 72);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(56, 16);
            this.labelAccount.TabIndex = 14;
            this.labelAccount.Text = "Account";
            // 
            // textOther
            // 
            this.textOther.Enabled = false;
            this.textOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOther.Location = new System.Drawing.Point(356, 67);
            this.textOther.Name = "textOther";
            this.textOther.Size = new System.Drawing.Size(118, 22);
            this.textOther.TabIndex = 8;
            // 
            // textPassword
            // 
            this.textPassword.Enabled = false;
            this.textPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Location = new System.Drawing.Point(90, 128);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(384, 22);
            this.textPassword.TabIndex = 3;
            // 
            // textUserName
            // 
            this.textUserName.Enabled = false;
            this.textUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUserName.Location = new System.Drawing.Point(90, 97);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(384, 22);
            this.textUserName.TabIndex = 2;
            // 
            // comboType
            // 
            this.comboType.BackColor = System.Drawing.Color.White;
            this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboType.Enabled = false;
            this.comboType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboType.FormattingEnabled = true;
            this.comboType.Items.AddRange(new object[] {
            "Android Store",
            "Apple ID",
            "Facebook",
            "Gmail",
            "Hotmail",
            "Live",
            "Origin",
            "Other",
            "Playstation Network",
            "Skype",
            "Steam",
            "Twitter",
            "Windows Login",
            "Windows Store",
            "Xbox Live",
            "Yahoo! Mail"});
            this.comboType.Location = new System.Drawing.Point(90, 64);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(96, 24);
            this.comboType.Sorted = true;
            this.comboType.TabIndex = 10;
            this.comboType.SelectedIndexChanged += new System.EventHandler(this.comboType_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            tabPage2.BackColor = System.Drawing.SystemColors.Control;
            tabPage2.Controls.Add(this.buttonEdit);
            tabPage2.Controls.Add(this.buttonDelete);
            tabPage2.Controls.Add(this.buttonSearch);
            tabPage2.Controls.Add(this.textSearch);
            tabPage2.Controls.Add(this.treeView1);
            tabPage2.Controls.Add(this.dataGridView1);
            tabPage2.Location = new System.Drawing.Point(4, 25);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(523, 210);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Vault";
            tabPage2.Enter += new System.EventHandler(tabPage2_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackgroundImage = global::PasswordDrawer.Properties.Resources.edit;
            this.buttonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit.Location = new System.Drawing.Point(152, 5);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(32, 22);
            this.buttonEdit.TabIndex = 7;
            this.toolTipAddNew.SetToolTip(this.buttonEdit, "Edit Record");
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackgroundImage = global::PasswordDrawer.Properties.Resources.delete;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Location = new System.Drawing.Point(185, 5);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(32, 22);
            this.buttonDelete.TabIndex = 6;
            this.toolTipAddNew.SetToolTip(this.buttonDelete, "Delete Record");
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackgroundImage = global::PasswordDrawer.Properties.Resources.search1;
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Location = new System.Drawing.Point(475, 5);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(32, 22);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(337, 5);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(135, 22);
            this.textSearch.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(5, 8);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Android Store";
            treeNode2.Name = "Node1";
            treeNode2.Text = "Apple ID";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Facebook";
            treeNode4.Name = "Node2";
            treeNode4.Text = "Gmail";
            treeNode5.Name = "Node3";
            treeNode5.Text = "Hotmail";
            treeNode6.Name = "Node5";
            treeNode6.Text = "Live";
            treeNode7.Name = "Node6";
            treeNode7.Text = "PlayStation Network";
            treeNode8.Name = "Node7";
            treeNode8.Text = "Origin";
            treeNode9.Name = "Node14";
            treeNode9.Text = "Steam";
            treeNode10.Name = "Node8";
            treeNode10.Text = "Skype";
            treeNode11.Name = "Node9";
            treeNode11.Text = "Twitter";
            treeNode12.Name = "Node3";
            treeNode12.Text = "Windows Login";
            treeNode13.Name = "Node4";
            treeNode13.Text = "Windows Store";
            treeNode14.Name = "Node10";
            treeNode14.Text = "Xbox Live";
            treeNode15.Name = "Node11";
            treeNode15.Text = "Yahoo! Mail";
            treeNode16.Name = "Node12";
            treeNode16.Text = "Other";
            treeNode17.Name = "Node10";
            treeNode17.Text = "All";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode17});
            this.treeView1.Size = new System.Drawing.Size(139, 196);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(150, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(373, 174);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolTipAddNew
            // 
            this.toolTipAddNew.AutoPopDelay = 1000;
            this.toolTipAddNew.InitialDelay = 500;
            this.toolTipAddNew.ReshowDelay = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(551, 255);
            this.Controls.Add(tabPane);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(650, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Vault";
            tabPane.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.TextBox textOther;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.ComboBox comboType;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ToolTip toolTipAddNew;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelStatusLabel;
        private static System.Windows.Forms.TabControl tabPane;
        private static System.Windows.Forms.TabPage tabPage1;
        private static System.Windows.Forms.TabPage tabPage2;

    }
}

