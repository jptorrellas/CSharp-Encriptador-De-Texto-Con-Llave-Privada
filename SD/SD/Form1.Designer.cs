namespace SD
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelLogoName = new System.Windows.Forms.Label();
            this.labelLogoSubName = new System.Windows.Forms.Label();
            this.groupBoxLogoAndLogoName = new System.Windows.Forms.GroupBox();
            this.groupBoxLogoName = new System.Windows.Forms.GroupBox();
            this.groupBoxLogo = new System.Windows.Forms.GroupBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.groupBoxMasterKey = new System.Windows.Forms.GroupBox();
            this.groupBoxMKSelectedOK = new System.Windows.Forms.GroupBox();
            this.labelNameMasterKey = new System.Windows.Forms.Label();
            this.pictureBoxMasterKeyOk = new System.Windows.Forms.PictureBox();
            this.buttonPwdMasterKeyOk = new System.Windows.Forms.Button();
            this.buttonPwdMasterKeyBack = new System.Windows.Forms.Button();
            this.buttonChangeMasterKey = new System.Windows.Forms.Button();
            this.pictureBoxMKOpened = new System.Windows.Forms.PictureBox();
            this.buttonOkMasterKey = new System.Windows.Forms.Button();
            this.comboBoxSelectMasterKey = new System.Windows.Forms.ComboBox();
            this.checkBoxHiddenMasterKey = new System.Windows.Forms.CheckBox();
            this.textBoxPwdMasterKey = new System.Windows.Forms.TextBox();
            this.groupBoxEncryptAndDecrypt = new System.Windows.Forms.GroupBox();
            this.pictureBoxDecrypt = new System.Windows.Forms.PictureBox();
            this.radioButtonDecryptText = new System.Windows.Forms.RadioButton();
            this.radioButtonDecryptFile = new System.Windows.Forms.RadioButton();
            this.pictureBoxEncrypt = new System.Windows.Forms.PictureBox();
            this.radioButtonEncryptText = new System.Windows.Forms.RadioButton();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBoxTextBoxText = new System.Windows.Forms.GroupBox();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBoxText = new System.Windows.Forms.RichTextBox();
            this.pictureBoxLoading = new System.Windows.Forms.PictureBox();
            this.labelProgressBarText = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitHelp = new System.Windows.Forms.ToolStripSplitButton();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSaveAs = new System.Windows.Forms.Button();
            this.buttonPaste = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonGo = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tEXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxLogoAndLogoName.SuspendLayout();
            this.groupBoxLogoName.SuspendLayout();
            this.groupBoxLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.groupBoxMasterKey.SuspendLayout();
            this.groupBoxMKSelectedOK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMasterKeyOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMKOpened)).BeginInit();
            this.groupBoxEncryptAndDecrypt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDecrypt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEncrypt)).BeginInit();
            this.groupBoxTextBoxText.SuspendLayout();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelLogoName
            // 
            this.labelLogoName.AutoSize = true;
            this.labelLogoName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogoName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.labelLogoName.Location = new System.Drawing.Point(7, 10);
            this.labelLogoName.Name = "labelLogoName";
            this.labelLogoName.Size = new System.Drawing.Size(239, 32);
            this.labelLogoName.TabIndex = 1;
            this.labelLogoName.Text = "SD - Secure Data";
            // 
            // labelLogoSubName
            // 
            this.labelLogoSubName.AutoSize = true;
            this.labelLogoSubName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelLogoSubName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelLogoSubName.Location = new System.Drawing.Point(8, 52);
            this.labelLogoSubName.Name = "labelLogoSubName";
            this.labelLogoSubName.Size = new System.Drawing.Size(237, 23);
            this.labelLogoSubName.TabIndex = 2;
            this.labelLogoSubName.Text = "(Encrypt  and  Decrypt)";
            // 
            // groupBoxLogoAndLogoName
            // 
            this.groupBoxLogoAndLogoName.Controls.Add(this.groupBoxLogoName);
            this.groupBoxLogoAndLogoName.Controls.Add(this.groupBoxLogo);
            this.groupBoxLogoAndLogoName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxLogoAndLogoName.Location = new System.Drawing.Point(6, 1);
            this.groupBoxLogoAndLogoName.Name = "groupBoxLogoAndLogoName";
            this.groupBoxLogoAndLogoName.Size = new System.Drawing.Size(355, 102);
            this.groupBoxLogoAndLogoName.TabIndex = 3;
            this.groupBoxLogoAndLogoName.TabStop = false;
            // 
            // groupBoxLogoName
            // 
            this.groupBoxLogoName.Controls.Add(this.labelLogoSubName);
            this.groupBoxLogoName.Controls.Add(this.labelLogoName);
            this.groupBoxLogoName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxLogoName.Location = new System.Drawing.Point(84, 8);
            this.groupBoxLogoName.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxLogoName.Name = "groupBoxLogoName";
            this.groupBoxLogoName.Padding = new System.Windows.Forms.Padding(0);
            this.groupBoxLogoName.Size = new System.Drawing.Size(264, 86);
            this.groupBoxLogoName.TabIndex = 5;
            this.groupBoxLogoName.TabStop = false;
            // 
            // groupBoxLogo
            // 
            this.groupBoxLogo.Controls.Add(this.pictureBoxLogo);
            this.groupBoxLogo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxLogo.Location = new System.Drawing.Point(8, 8);
            this.groupBoxLogo.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxLogo.Name = "groupBoxLogo";
            this.groupBoxLogo.Padding = new System.Windows.Forms.Padding(0);
            this.groupBoxLogo.Size = new System.Drawing.Size(78, 86);
            this.groupBoxLogo.TabIndex = 4;
            this.groupBoxLogo.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(7, 13);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(66, 66);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // groupBoxMasterKey
            // 
            this.groupBoxMasterKey.Controls.Add(this.groupBoxMKSelectedOK);
            this.groupBoxMasterKey.Controls.Add(this.buttonPwdMasterKeyOk);
            this.groupBoxMasterKey.Controls.Add(this.buttonPwdMasterKeyBack);
            this.groupBoxMasterKey.Controls.Add(this.buttonChangeMasterKey);
            this.groupBoxMasterKey.Controls.Add(this.pictureBoxMKOpened);
            this.groupBoxMasterKey.Controls.Add(this.buttonOkMasterKey);
            this.groupBoxMasterKey.Controls.Add(this.comboBoxSelectMasterKey);
            this.groupBoxMasterKey.Location = new System.Drawing.Point(367, 9);
            this.groupBoxMasterKey.Name = "groupBoxMasterKey";
            this.groupBoxMasterKey.Size = new System.Drawing.Size(230, 94);
            this.groupBoxMasterKey.TabIndex = 6;
            this.groupBoxMasterKey.TabStop = false;
            this.groupBoxMasterKey.Text = "Master Key";
            // 
            // groupBoxMKSelectedOK
            // 
            this.groupBoxMKSelectedOK.Controls.Add(this.labelNameMasterKey);
            this.groupBoxMKSelectedOK.Controls.Add(this.pictureBoxMasterKeyOk);
            this.groupBoxMKSelectedOK.Location = new System.Drawing.Point(7, 16);
            this.groupBoxMKSelectedOK.Name = "groupBoxMKSelectedOK";
            this.groupBoxMKSelectedOK.Size = new System.Drawing.Size(215, 49);
            this.groupBoxMKSelectedOK.TabIndex = 63;
            this.groupBoxMKSelectedOK.TabStop = false;
            this.groupBoxMKSelectedOK.Visible = false;
            // 
            // labelNameMasterKey
            // 
            this.labelNameMasterKey.AutoSize = true;
            this.labelNameMasterKey.Location = new System.Drawing.Point(58, 22);
            this.labelNameMasterKey.Name = "labelNameMasterKey";
            this.labelNameMasterKey.Size = new System.Drawing.Size(107, 13);
            this.labelNameMasterKey.TabIndex = 57;
            this.labelNameMasterKey.Text = "labelNameMasterKey";
            this.labelNameMasterKey.Visible = false;
            // 
            // pictureBoxMasterKeyOk
            // 
            this.pictureBoxMasterKeyOk.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMasterKeyOk.Image")));
            this.pictureBoxMasterKeyOk.Location = new System.Drawing.Point(16, 10);
            this.pictureBoxMasterKeyOk.Name = "pictureBoxMasterKeyOk";
            this.pictureBoxMasterKeyOk.Size = new System.Drawing.Size(39, 35);
            this.pictureBoxMasterKeyOk.TabIndex = 9;
            this.pictureBoxMasterKeyOk.TabStop = false;
            this.pictureBoxMasterKeyOk.Visible = false;
            // 
            // buttonPwdMasterKeyOk
            // 
            this.buttonPwdMasterKeyOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPwdMasterKeyOk.Location = new System.Drawing.Point(126, 67);
            this.buttonPwdMasterKeyOk.Name = "buttonPwdMasterKeyOk";
            this.buttonPwdMasterKeyOk.Size = new System.Drawing.Size(57, 23);
            this.buttonPwdMasterKeyOk.TabIndex = 55;
            this.buttonPwdMasterKeyOk.Text = "ok";
            this.buttonPwdMasterKeyOk.UseVisualStyleBackColor = true;
            this.buttonPwdMasterKeyOk.Visible = false;
            this.buttonPwdMasterKeyOk.Click += new System.EventHandler(this.buttonPwdMasterKeyOk_Click);
            // 
            // buttonPwdMasterKeyBack
            // 
            this.buttonPwdMasterKeyBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPwdMasterKeyBack.Location = new System.Drawing.Point(182, 67);
            this.buttonPwdMasterKeyBack.Name = "buttonPwdMasterKeyBack";
            this.buttonPwdMasterKeyBack.Size = new System.Drawing.Size(37, 23);
            this.buttonPwdMasterKeyBack.TabIndex = 56;
            this.buttonPwdMasterKeyBack.Text = "back";
            this.buttonPwdMasterKeyBack.UseVisualStyleBackColor = true;
            this.buttonPwdMasterKeyBack.Visible = false;
            this.buttonPwdMasterKeyBack.Click += new System.EventHandler(this.buttonNewMasterKeyBack_Click);
            // 
            // buttonChangeMasterKey
            // 
            this.buttonChangeMasterKey.Location = new System.Drawing.Point(7, 65);
            this.buttonChangeMasterKey.Name = "buttonChangeMasterKey";
            this.buttonChangeMasterKey.Size = new System.Drawing.Size(215, 23);
            this.buttonChangeMasterKey.TabIndex = 10;
            this.buttonChangeMasterKey.Text = "Change Master Key";
            this.buttonChangeMasterKey.UseVisualStyleBackColor = true;
            this.buttonChangeMasterKey.Visible = false;
            this.buttonChangeMasterKey.Click += new System.EventHandler(this.buttonChangeMasterKey_Click);
            // 
            // pictureBoxMKOpened
            // 
            this.pictureBoxMKOpened.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMKOpened.Image")));
            this.pictureBoxMKOpened.Location = new System.Drawing.Point(65, 0);
            this.pictureBoxMKOpened.Name = "pictureBoxMKOpened";
            this.pictureBoxMKOpened.Size = new System.Drawing.Size(22, 18);
            this.pictureBoxMKOpened.TabIndex = 7;
            this.pictureBoxMKOpened.TabStop = false;
            this.pictureBoxMKOpened.Visible = false;
            // 
            // buttonOkMasterKey
            // 
            this.buttonOkMasterKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOkMasterKey.Location = new System.Drawing.Point(173, 18);
            this.buttonOkMasterKey.Name = "buttonOkMasterKey";
            this.buttonOkMasterKey.Size = new System.Drawing.Size(49, 23);
            this.buttonOkMasterKey.TabIndex = 7;
            this.buttonOkMasterKey.Text = "Open";
            this.buttonOkMasterKey.UseVisualStyleBackColor = true;
            this.buttonOkMasterKey.Click += new System.EventHandler(this.buttonOkMasterKey_Click);
            // 
            // comboBoxSelectMasterKey
            // 
            this.comboBoxSelectMasterKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectMasterKey.Items.AddRange(new object[] {
            "Open Master Key",
            "Create new Master Key"});
            this.comboBoxSelectMasterKey.Location = new System.Drawing.Point(7, 19);
            this.comboBoxSelectMasterKey.Name = "comboBoxSelectMasterKey";
            this.comboBoxSelectMasterKey.Size = new System.Drawing.Size(160, 21);
            this.comboBoxSelectMasterKey.TabIndex = 7;
            this.comboBoxSelectMasterKey.Tag = "";
            this.comboBoxSelectMasterKey.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectMasterKey_SelectedIndexChanged);
            // 
            // checkBoxHiddenMasterKey
            // 
            this.checkBoxHiddenMasterKey.AutoSize = true;
            this.checkBoxHiddenMasterKey.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxHiddenMasterKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxHiddenMasterKey.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxHiddenMasterKey.Location = new System.Drawing.Point(374, 79);
            this.checkBoxHiddenMasterKey.Name = "checkBoxHiddenMasterKey";
            this.checkBoxHiddenMasterKey.Size = new System.Drawing.Size(104, 17);
            this.checkBoxHiddenMasterKey.TabIndex = 54;
            this.checkBoxHiddenMasterKey.Text = "Show characters";
            this.checkBoxHiddenMasterKey.UseVisualStyleBackColor = false;
            this.checkBoxHiddenMasterKey.Visible = false;
            this.checkBoxHiddenMasterKey.CheckedChanged += new System.EventHandler(this.checkBoxHiddenMasterKey_CheckedChanged);
            // 
            // textBoxPwdMasterKey
            // 
            this.textBoxPwdMasterKey.AccessibleDescription = "";
            this.textBoxPwdMasterKey.AccessibleName = "";
            this.textBoxPwdMasterKey.Location = new System.Drawing.Point(374, 53);
            this.textBoxPwdMasterKey.Name = "textBoxPwdMasterKey";
            this.textBoxPwdMasterKey.Size = new System.Drawing.Size(215, 20);
            this.textBoxPwdMasterKey.TabIndex = 53;
            this.textBoxPwdMasterKey.Tag = "";
            this.textBoxPwdMasterKey.Text = "Enter the password for the new MasterKey";
            this.textBoxPwdMasterKey.Visible = false;
            this.textBoxPwdMasterKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPwdMasterKey_KeyPress);
            // 
            // groupBoxEncryptAndDecrypt
            // 
            this.groupBoxEncryptAndDecrypt.Controls.Add(this.pictureBoxDecrypt);
            this.groupBoxEncryptAndDecrypt.Controls.Add(this.radioButtonDecryptText);
            this.groupBoxEncryptAndDecrypt.Controls.Add(this.radioButtonDecryptFile);
            this.groupBoxEncryptAndDecrypt.Controls.Add(this.pictureBoxEncrypt);
            this.groupBoxEncryptAndDecrypt.Controls.Add(this.radioButtonEncryptText);
            this.groupBoxEncryptAndDecrypt.Enabled = false;
            this.groupBoxEncryptAndDecrypt.Location = new System.Drawing.Point(6, 119);
            this.groupBoxEncryptAndDecrypt.Name = "groupBoxEncryptAndDecrypt";
            this.groupBoxEncryptAndDecrypt.Size = new System.Drawing.Size(355, 66);
            this.groupBoxEncryptAndDecrypt.TabIndex = 55;
            this.groupBoxEncryptAndDecrypt.TabStop = false;
            this.groupBoxEncryptAndDecrypt.Text = " Select Option ";
            // 
            // pictureBoxDecrypt
            // 
            this.pictureBoxDecrypt.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDecrypt.Image")));
            this.pictureBoxDecrypt.Location = new System.Drawing.Point(190, 30);
            this.pictureBoxDecrypt.Name = "pictureBoxDecrypt";
            this.pictureBoxDecrypt.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxDecrypt.TabIndex = 62;
            this.pictureBoxDecrypt.TabStop = false;
            // 
            // radioButtonDecryptText
            // 
            this.radioButtonDecryptText.AutoSize = true;
            this.radioButtonDecryptText.Location = new System.Drawing.Point(230, 23);
            this.radioButtonDecryptText.Name = "radioButtonDecryptText";
            this.radioButtonDecryptText.Size = new System.Drawing.Size(86, 17);
            this.radioButtonDecryptText.TabIndex = 57;
            this.radioButtonDecryptText.TabStop = true;
            this.radioButtonDecryptText.Text = "Decrypt Text";
            this.radioButtonDecryptText.UseVisualStyleBackColor = true;
            this.radioButtonDecryptText.CheckedChanged += new System.EventHandler(this.radioButtonDecryptText_CheckedChanged);
            // 
            // radioButtonDecryptFile
            // 
            this.radioButtonDecryptFile.AutoSize = true;
            this.radioButtonDecryptFile.Location = new System.Drawing.Point(230, 43);
            this.radioButtonDecryptFile.Name = "radioButtonDecryptFile";
            this.radioButtonDecryptFile.Size = new System.Drawing.Size(116, 17);
            this.radioButtonDecryptFile.TabIndex = 57;
            this.radioButtonDecryptFile.Text = "Decrypt File ( .sde )";
            this.radioButtonDecryptFile.UseVisualStyleBackColor = true;
            this.radioButtonDecryptFile.CheckedChanged += new System.EventHandler(this.radioButtonDecryptFile_CheckedChanged);
            // 
            // pictureBoxEncrypt
            // 
            this.pictureBoxEncrypt.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEncrypt.Image")));
            this.pictureBoxEncrypt.Location = new System.Drawing.Point(9, 30);
            this.pictureBoxEncrypt.Name = "pictureBoxEncrypt";
            this.pictureBoxEncrypt.Size = new System.Drawing.Size(23, 25);
            this.pictureBoxEncrypt.TabIndex = 61;
            this.pictureBoxEncrypt.TabStop = false;
            // 
            // radioButtonEncryptText
            // 
            this.radioButtonEncryptText.AutoSize = true;
            this.radioButtonEncryptText.Location = new System.Drawing.Point(48, 33);
            this.radioButtonEncryptText.Name = "radioButtonEncryptText";
            this.radioButtonEncryptText.Size = new System.Drawing.Size(85, 17);
            this.radioButtonEncryptText.TabIndex = 0;
            this.radioButtonEncryptText.Text = "Encrypt Text";
            this.radioButtonEncryptText.UseVisualStyleBackColor = true;
            this.radioButtonEncryptText.CheckedChanged += new System.EventHandler(this.radioButtonEncryptText_CheckedChanged);
            // 
            // buttonClear
            // 
            this.buttonClear.Enabled = false;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonClear.Location = new System.Drawing.Point(265, 37);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(43, 22);
            this.buttonClear.TabIndex = 58;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // groupBoxTextBoxText
            // 
            this.groupBoxTextBoxText.Controls.Add(this.grpSearch);
            this.groupBoxTextBoxText.Controls.Add(this.textBoxText);
            this.groupBoxTextBoxText.Controls.Add(this.pictureBoxLoading);
            this.groupBoxTextBoxText.Controls.Add(this.labelProgressBarText);
            this.groupBoxTextBoxText.Controls.Add(this.statusStrip1);
            this.groupBoxTextBoxText.Controls.Add(this.buttonSaveAs);
            this.groupBoxTextBoxText.Controls.Add(this.buttonPaste);
            this.groupBoxTextBoxText.Controls.Add(this.buttonCopy);
            this.groupBoxTextBoxText.Controls.Add(this.buttonClear);
            this.groupBoxTextBoxText.Location = new System.Drawing.Point(6, 202);
            this.groupBoxTextBoxText.Name = "groupBoxTextBoxText";
            this.groupBoxTextBoxText.Size = new System.Drawing.Size(591, 341);
            this.groupBoxTextBoxText.TabIndex = 59;
            this.groupBoxTextBoxText.TabStop = false;
            this.groupBoxTextBoxText.Text = "Text Box";
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Enabled = false;
            this.grpSearch.Location = new System.Drawing.Point(343, 19);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(242, 42);
            this.grpSearch.TabIndex = 69;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search text ";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(8, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(172, 20);
            this.txtSearch.TabIndex = 66;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(186, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(49, 23);
            this.btnSearch.TabIndex = 67;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBoxText
            // 
            this.textBoxText.Enabled = false;
            this.textBoxText.Location = new System.Drawing.Point(6, 65);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(579, 248);
            this.textBoxText.TabIndex = 65;
            this.textBoxText.Text = "";
            // 
            // pictureBoxLoading
            // 
            this.pictureBoxLoading.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLoading.Image")));
            this.pictureBoxLoading.Location = new System.Drawing.Point(418, 322);
            this.pictureBoxLoading.Name = "pictureBoxLoading";
            this.pictureBoxLoading.Size = new System.Drawing.Size(22, 22);
            this.pictureBoxLoading.TabIndex = 64;
            this.pictureBoxLoading.TabStop = false;
            this.pictureBoxLoading.Visible = false;
            // 
            // labelProgressBarText
            // 
            this.labelProgressBarText.AutoSize = true;
            this.labelProgressBarText.Location = new System.Drawing.Point(439, 323);
            this.labelProgressBarText.Name = "labelProgressBarText";
            this.labelProgressBarText.Size = new System.Drawing.Size(118, 13);
            this.labelProgressBarText.TabIndex = 63;
            this.labelProgressBarText.Text = "Working, please wait ...";
            this.labelProgressBarText.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitHelp});
            this.statusStrip1.Location = new System.Drawing.Point(3, 316);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(585, 22);
            this.statusStrip1.TabIndex = 62;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripSplitHelp
            // 
            this.toolStripSplitHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolStripSplitHelp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitHelp.Image")));
            this.toolStripSplitHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitHelp.Name = "toolStripSplitHelp";
            this.toolStripSplitHelp.Size = new System.Drawing.Size(64, 20);
            this.toolStripSplitHelp.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Checked = true;
            this.aboutToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // buttonSaveAs
            // 
            this.buttonSaveAs.Enabled = false;
            this.buttonSaveAs.Location = new System.Drawing.Point(172, 37);
            this.buttonSaveAs.Name = "buttonSaveAs";
            this.buttonSaveAs.Size = new System.Drawing.Size(77, 22);
            this.buttonSaveAs.TabIndex = 61;
            this.buttonSaveAs.Text = "Save as...";
            this.buttonSaveAs.UseVisualStyleBackColor = true;
            this.buttonSaveAs.Click += new System.EventHandler(this.buttonSaveAs_Click);
            // 
            // buttonPaste
            // 
            this.buttonPaste.Enabled = false;
            this.buttonPaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPaste.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPaste.Location = new System.Drawing.Point(89, 37);
            this.buttonPaste.Name = "buttonPaste";
            this.buttonPaste.Size = new System.Drawing.Size(77, 22);
            this.buttonPaste.TabIndex = 60;
            this.buttonPaste.Text = "Paste";
            this.buttonPaste.UseVisualStyleBackColor = true;
            this.buttonPaste.Click += new System.EventHandler(this.buttonPaste_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Enabled = false;
            this.buttonCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCopy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCopy.Location = new System.Drawing.Point(6, 37);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(77, 22);
            this.buttonCopy.TabIndex = 59;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonGo
            // 
            this.buttonGo.BackColor = System.Drawing.Color.Transparent;
            this.buttonGo.Enabled = false;
            this.buttonGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonGo.Location = new System.Drawing.Point(374, 125);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(215, 60);
            this.buttonGo.TabIndex = 60;
            this.buttonGo.UseVisualStyleBackColor = false;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tEXTToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.menuToolStripMenuItem.Text = "menu";
            // 
            // tEXTToolStripMenuItem
            // 
            this.tEXTToolStripMenuItem.Name = "tEXTToolStripMenuItem";
            this.tEXTToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.tEXTToolStripMenuItem.Text = "TEXT";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.fileToolStripMenuItem.Text = "file";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 547);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.groupBoxEncryptAndDecrypt);
            this.Controls.Add(this.checkBoxHiddenMasterKey);
            this.Controls.Add(this.textBoxPwdMasterKey);
            this.Controls.Add(this.groupBoxMasterKey);
            this.Controls.Add(this.groupBoxLogoAndLogoName);
            this.Controls.Add(this.groupBoxTextBoxText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SD - SecureData (Encrypt and Decrypt)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxLogoAndLogoName.ResumeLayout(false);
            this.groupBoxLogoName.ResumeLayout(false);
            this.groupBoxLogoName.PerformLayout();
            this.groupBoxLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.groupBoxMasterKey.ResumeLayout(false);
            this.groupBoxMKSelectedOK.ResumeLayout(false);
            this.groupBoxMKSelectedOK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMasterKeyOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMKOpened)).EndInit();
            this.groupBoxEncryptAndDecrypt.ResumeLayout(false);
            this.groupBoxEncryptAndDecrypt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDecrypt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEncrypt)).EndInit();
            this.groupBoxTextBoxText.ResumeLayout(false);
            this.groupBoxTextBoxText.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelLogoName;
        private System.Windows.Forms.Label labelLogoSubName;
        private System.Windows.Forms.GroupBox groupBoxLogoAndLogoName;
        private System.Windows.Forms.GroupBox groupBoxLogo;
        private System.Windows.Forms.GroupBox groupBoxLogoName;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tEXTToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxMasterKey;
        private System.Windows.Forms.Button buttonOkMasterKey;
        private System.Windows.Forms.PictureBox pictureBoxMKOpened;
        private System.Windows.Forms.Button buttonPwdMasterKeyOk;
        private System.Windows.Forms.Button buttonChangeMasterKey;
        private System.Windows.Forms.PictureBox pictureBoxMasterKeyOk;
        private System.Windows.Forms.CheckBox checkBoxHiddenMasterKey;
        private System.Windows.Forms.TextBox textBoxPwdMasterKey;
        private System.Windows.Forms.GroupBox groupBoxEncryptAndDecrypt;
        private System.Windows.Forms.RadioButton radioButtonDecryptFile;
        private System.Windows.Forms.RadioButton radioButtonEncryptText;
        private System.Windows.Forms.RadioButton radioButtonDecryptText;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.GroupBox groupBoxTextBoxText;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.PictureBox pictureBoxEncrypt;
        private System.Windows.Forms.PictureBox pictureBoxDecrypt;
        private System.Windows.Forms.Button buttonPaste;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonPwdMasterKeyBack;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.Label labelNameMasterKey;
        private System.Windows.Forms.GroupBox groupBoxMKSelectedOK;
        private System.Windows.Forms.ComboBox comboBoxSelectMasterKey;
        private System.Windows.Forms.Button buttonSaveAs;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitHelp;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label labelProgressBarText;
        private System.Windows.Forms.PictureBox pictureBoxLoading;
        private System.Windows.Forms.RichTextBox textBoxText;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox grpSearch;
    }
}

