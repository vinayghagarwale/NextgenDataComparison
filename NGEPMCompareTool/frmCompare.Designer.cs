namespace NGEPMCompareTool
{
    partial class frmCompare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompare));
            this.cboDSN1 = new System.Windows.Forms.ComboBox();
            this.cboDSN2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tab_Practice = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CompareProgress = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchdesc = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.ChkShowAll = new System.Windows.Forms.CheckBox();
            this.lbltype2 = new System.Windows.Forms.Label();
            this.lbltype1 = new System.Windows.Forms.Label();
            this.cbo_Practice2 = new System.Windows.Forms.ComboBox();
            this.cbo_Practice1 = new System.Windows.Forms.ComboBox();
            this.gridbox = new System.Windows.Forms.DataGridView();
            this.GrpLogin = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.MaskedTextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.cmd_Close = new System.Windows.Forms.Button();
            this.lblCon1 = new System.Windows.Forms.Label();
            this.lblCon2 = new System.Windows.Forms.Label();
            this.btnConnect1 = new System.Windows.Forms.Button();
            this.btnConnect2 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdContract = new System.Windows.Forms.RadioButton();
            this.rdEnterPrise = new System.Windows.Forms.RadioButton();
            this.rdPayer = new System.Windows.Forms.RadioButton();
            this.rdPractice = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Tab_Practice.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridbox)).BeginInit();
            this.GrpLogin.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboDSN1
            // 
            this.cboDSN1.FormattingEnabled = true;
            this.cboDSN1.Location = new System.Drawing.Point(69, 25);
            this.cboDSN1.Name = "cboDSN1";
            this.cboDSN1.Size = new System.Drawing.Size(230, 21);
            this.cboDSN1.TabIndex = 1;
            this.cboDSN1.SelectedIndexChanged += new System.EventHandler(this.cboDSN1_SelectedIndexChanged);
            // 
            // cboDSN2
            // 
            this.cboDSN2.FormattingEnabled = true;
            this.cboDSN2.Location = new System.Drawing.Point(457, 25);
            this.cboDSN2.Name = "cboDSN2";
            this.cboDSN2.Size = new System.Drawing.Size(230, 21);
            this.cboDSN2.TabIndex = 2;
            this.cboDSN2.SelectedIndexChanged += new System.EventHandler(this.cboDSN2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "DSN 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "DSN 2";
            // 
            // Tab_Practice
            // 
            this.Tab_Practice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab_Practice.Controls.Add(this.tabPage1);
            this.Tab_Practice.Location = new System.Drawing.Point(11, 106);
            this.Tab_Practice.Margin = new System.Windows.Forms.Padding(2);
            this.Tab_Practice.Name = "Tab_Practice";
            this.Tab_Practice.SelectedIndex = 0;
            this.Tab_Practice.Size = new System.Drawing.Size(889, 504);
            this.Tab_Practice.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tabPage1.Controls.Add(this.CompareProgress);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.lbltype2);
            this.tabPage1.Controls.Add(this.lbltype1);
            this.tabPage1.Controls.Add(this.cbo_Practice2);
            this.tabPage1.Controls.Add(this.cbo_Practice1);
            this.tabPage1.Controls.Add(this.gridbox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(881, 478);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Practice Pref";
            // 
            // CompareProgress
            // 
            this.CompareProgress.Location = new System.Drawing.Point(107, 311);
            this.CompareProgress.Name = "CompareProgress";
            this.CompareProgress.Size = new System.Drawing.Size(661, 23);
            this.CompareProgress.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cboType);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSearchdesc);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.ChkShowAll);
            this.groupBox1.Location = new System.Drawing.Point(6, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(865, 55);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(412, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Type";
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "All",
            "Indicator",
            "Library"});
            this.cboType.Location = new System.Drawing.Point(449, 31);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(84, 21);
            this.cboType.TabIndex = 22;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(201, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "DB Field Name";
            // 
            // txtSearchdesc
            // 
            this.txtSearchdesc.Location = new System.Drawing.Point(204, 32);
            this.txtSearchdesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchdesc.Name = "txtSearchdesc";
            this.txtSearchdesc.Size = new System.Drawing.Size(192, 20);
            this.txtSearchdesc.TabIndex = 19;
            this.txtSearchdesc.TextChanged += new System.EventHandler(this.txtSearchdesc_TextChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(9, 31);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(192, 20);
            this.txtSearch.TabIndex = 18;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // ChkShowAll
            // 
            this.ChkShowAll.AutoSize = true;
            this.ChkShowAll.Location = new System.Drawing.Point(538, 34);
            this.ChkShowAll.Margin = new System.Windows.Forms.Padding(2);
            this.ChkShowAll.Name = "ChkShowAll";
            this.ChkShowAll.Size = new System.Drawing.Size(97, 17);
            this.ChkShowAll.TabIndex = 17;
            this.ChkShowAll.Text = "Show All Fields";
            this.ChkShowAll.UseVisualStyleBackColor = true;
            this.ChkShowAll.CheckStateChanged += new System.EventHandler(this.ChkShowAll_CheckStateChanged);
            // 
            // lbltype2
            // 
            this.lbltype2.AutoSize = true;
            this.lbltype2.Location = new System.Drawing.Point(381, 14);
            this.lbltype2.Name = "lbltype2";
            this.lbltype2.Size = new System.Drawing.Size(55, 13);
            this.lbltype2.TabIndex = 8;
            this.lbltype2.Text = "Practice 2";
            // 
            // lbltype1
            // 
            this.lbltype1.AutoSize = true;
            this.lbltype1.Location = new System.Drawing.Point(5, 14);
            this.lbltype1.Name = "lbltype1";
            this.lbltype1.Size = new System.Drawing.Size(55, 13);
            this.lbltype1.TabIndex = 7;
            this.lbltype1.Text = "Practice 1";
            // 
            // cbo_Practice2
            // 
            this.cbo_Practice2.FormattingEnabled = true;
            this.cbo_Practice2.Location = new System.Drawing.Point(442, 11);
            this.cbo_Practice2.Name = "cbo_Practice2";
            this.cbo_Practice2.Size = new System.Drawing.Size(273, 21);
            this.cbo_Practice2.TabIndex = 6;
            this.cbo_Practice2.SelectedIndexChanged += new System.EventHandler(this.cbo_Practice2_SelectedIndexChanged);
            // 
            // cbo_Practice1
            // 
            this.cbo_Practice1.FormattingEnabled = true;
            this.cbo_Practice1.Location = new System.Drawing.Point(75, 11);
            this.cbo_Practice1.Name = "cbo_Practice1";
            this.cbo_Practice1.Size = new System.Drawing.Size(273, 21);
            this.cbo_Practice1.TabIndex = 5;
            this.cbo_Practice1.SelectedIndexChanged += new System.EventHandler(this.cbo_Practice1_SelectedIndexChanged);
            // 
            // gridbox
            // 
            this.gridbox.AllowUserToAddRows = false;
            this.gridbox.AllowUserToDeleteRows = false;
            this.gridbox.AllowUserToOrderColumns = true;
            this.gridbox.AllowUserToResizeRows = false;
            this.gridbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridbox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridbox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridbox.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridbox.Location = new System.Drawing.Point(5, 99);
            this.gridbox.Name = "gridbox";
            this.gridbox.RowHeadersVisible = false;
            this.gridbox.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridbox.Size = new System.Drawing.Size(869, 367);
            this.gridbox.TabIndex = 1;
            // 
            // GrpLogin
            // 
            this.GrpLogin.Controls.Add(this.btnConnect);
            this.GrpLogin.Controls.Add(this.txtPwd);
            this.GrpLogin.Controls.Add(this.txtUser);
            this.GrpLogin.Controls.Add(this.label4);
            this.GrpLogin.Controls.Add(this.label3);
            this.GrpLogin.Controls.Add(this.button3);
            this.GrpLogin.Location = new System.Drawing.Point(732, 43);
            this.GrpLogin.Margin = new System.Windows.Forms.Padding(2);
            this.GrpLogin.Name = "GrpLogin";
            this.GrpLogin.Padding = new System.Windows.Forms.Padding(2);
            this.GrpLogin.Size = new System.Drawing.Size(230, 126);
            this.GrpLogin.TabIndex = 11;
            this.GrpLogin.TabStop = false;
            this.GrpLogin.Text = "Login ";
            this.GrpLogin.Visible = false;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(75, 91);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(72, 23);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(54, 60);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(2);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(170, 20);
            this.txtPwd.TabIndex = 7;
            this.txtPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPwd_KeyPress);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(54, 24);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(170, 20);
            this.txtUser.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "PWD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "User";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(152, 91);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCompare.Location = new System.Drawing.Point(11, 614);
            this.btnCompare.Margin = new System.Windows.Forms.Padding(2);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 24);
            this.btnCompare.TabIndex = 7;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // cmd_Close
            // 
            this.cmd_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmd_Close.Location = new System.Drawing.Point(821, 614);
            this.cmd_Close.Margin = new System.Windows.Forms.Padding(2);
            this.cmd_Close.Name = "cmd_Close";
            this.cmd_Close.Size = new System.Drawing.Size(75, 24);
            this.cmd_Close.TabIndex = 8;
            this.cmd_Close.Text = "Close";
            this.cmd_Close.UseVisualStyleBackColor = true;
            this.cmd_Close.Click += new System.EventHandler(this.cmd_Close_Click);
            // 
            // lblCon1
            // 
            this.lblCon1.Location = new System.Drawing.Point(205, 8);
            this.lblCon1.Name = "lblCon1";
            this.lblCon1.Size = new System.Drawing.Size(97, 14);
            this.lblCon1.TabIndex = 9;
            this.lblCon1.Text = "Not Connected";
            this.lblCon1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCon2
            // 
            this.lblCon2.Location = new System.Drawing.Point(575, 8);
            this.lblCon2.Name = "lblCon2";
            this.lblCon2.Size = new System.Drawing.Size(116, 15);
            this.lblCon2.TabIndex = 10;
            this.lblCon2.Text = "Not Connected";
            this.lblCon2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnConnect1
            // 
            this.btnConnect1.Location = new System.Drawing.Point(299, 25);
            this.btnConnect1.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnect1.Name = "btnConnect1";
            this.btnConnect1.Size = new System.Drawing.Size(16, 20);
            this.btnConnect1.TabIndex = 12;
            this.btnConnect1.Text = "C";
            this.btnConnect1.UseVisualStyleBackColor = true;
            this.btnConnect1.Click += new System.EventHandler(this.btnConnect1_Click);
            // 
            // btnConnect2
            // 
            this.btnConnect2.Location = new System.Drawing.Point(688, 25);
            this.btnConnect2.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnect2.Name = "btnConnect2";
            this.btnConnect2.Size = new System.Drawing.Size(16, 20);
            this.btnConnect2.TabIndex = 13;
            this.btnConnect2.Text = "C";
            this.btnConnect2.UseVisualStyleBackColor = true;
            this.btnConnect2.Click += new System.EventHandler(this.btnConnect2_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.Location = new System.Drawing.Point(90, 614);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 24);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdContract);
            this.groupBox2.Controls.Add(this.rdEnterPrise);
            this.groupBox2.Controls.Add(this.rdPayer);
            this.groupBox2.Controls.Add(this.rdPractice);
            this.groupBox2.Location = new System.Drawing.Point(13, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(887, 41);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Compare Type";
            // 
            // rdContract
            // 
            this.rdContract.AutoSize = true;
            this.rdContract.Location = new System.Drawing.Point(250, 16);
            this.rdContract.Name = "rdContract";
            this.rdContract.Size = new System.Drawing.Size(65, 17);
            this.rdContract.TabIndex = 3;
            this.rdContract.TabStop = true;
            this.rdContract.Text = "Contract";
            this.rdContract.UseVisualStyleBackColor = true;
            this.rdContract.CheckedChanged += new System.EventHandler(this.rdContract_CheckedChanged);
            // 
            // rdEnterPrise
            // 
            this.rdEnterPrise.AutoSize = true;
            this.rdEnterPrise.Location = new System.Drawing.Point(97, 16);
            this.rdEnterPrise.Name = "rdEnterPrise";
            this.rdEnterPrise.Size = new System.Drawing.Size(72, 17);
            this.rdEnterPrise.TabIndex = 2;
            this.rdEnterPrise.TabStop = true;
            this.rdEnterPrise.Text = "Enterprise";
            this.rdEnterPrise.UseVisualStyleBackColor = true;
            this.rdEnterPrise.CheckedChanged += new System.EventHandler(this.rdEnterPrise_CheckedChanged);
            // 
            // rdPayer
            // 
            this.rdPayer.AutoSize = true;
            this.rdPayer.Location = new System.Drawing.Point(183, 16);
            this.rdPayer.Name = "rdPayer";
            this.rdPayer.Size = new System.Drawing.Size(52, 17);
            this.rdPayer.TabIndex = 1;
            this.rdPayer.TabStop = true;
            this.rdPayer.Text = "Payer";
            this.rdPayer.UseVisualStyleBackColor = true;
            this.rdPayer.CheckedChanged += new System.EventHandler(this.rdPayer_CheckedChanged);
            // 
            // rdPractice
            // 
            this.rdPractice.AutoSize = true;
            this.rdPractice.Checked = true;
            this.rdPractice.Location = new System.Drawing.Point(14, 16);
            this.rdPractice.Name = "rdPractice";
            this.rdPractice.Size = new System.Drawing.Size(64, 17);
            this.rdPractice.TabIndex = 0;
            this.rdPractice.TabStop = true;
            this.rdPractice.Text = "Practice";
            this.rdPractice.UseVisualStyleBackColor = true;
            this.rdPractice.CheckedChanged += new System.EventHandler(this.rdPractice_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 648);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(900, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(900, 670);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.GrpLogin);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConnect2);
            this.Controls.Add(this.btnConnect1);
            this.Controls.Add(this.lblCon2);
            this.Controls.Add(this.lblCon1);
            this.Controls.Add(this.cmd_Close);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.Tab_Practice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboDSN2);
            this.Controls.Add(this.cboDSN1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCompare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NextGen Data Comparison Tool";
            this.Load += new System.EventHandler(this.frmCompare_Load);
            this.Tab_Practice.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridbox)).EndInit();
            this.GrpLogin.ResumeLayout(false);
            this.GrpLogin.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDSN1;
        private System.Windows.Forms.ComboBox cboDSN2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl Tab_Practice;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView gridbox;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button cmd_Close;
        private System.Windows.Forms.Label lblCon1;
        private System.Windows.Forms.Label lblCon2;
        private System.Windows.Forms.Label lbltype2;
        private System.Windows.Forms.Label lbltype1;
        private System.Windows.Forms.ComboBox cbo_Practice2;
        private System.Windows.Forms.ComboBox cbo_Practice1;
        private System.Windows.Forms.GroupBox GrpLogin;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.MaskedTextBox txtPwd;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnConnect1;
        private System.Windows.Forms.Button btnConnect2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearchdesc;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.CheckBox ChkShowAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdPayer;
        private System.Windows.Forms.RadioButton rdPractice;
        private System.Windows.Forms.RadioButton rdEnterPrise;
        private System.Windows.Forms.RadioButton rdContract;
        private System.Windows.Forms.ProgressBar CompareProgress;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

