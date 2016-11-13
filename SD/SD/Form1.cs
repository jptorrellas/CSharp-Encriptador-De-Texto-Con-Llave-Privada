using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Security.Cryptography;
using System.IO;

namespace SD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
 
            // Create Events
            textBoxPwdMasterKey.GotFocus  += new EventHandler(textBoxPwdMasterKey_GotFocus);
            textBoxPwdMasterKey.LostFocus += new EventHandler(textBoxPwdMasterKey_LostFocus);


            // Start comboBoxSelectMasterKey in "Open MasterKey"
            if (comboBoxSelectMasterKey.Items.Count > 0)
            {
                comboBoxSelectMasterKey.SelectedIndex = 0;
            }
            
        }

        #region Events

        private void textBoxPwdMasterKey_GotFocus(object sender, EventArgs e)
        {
            if (textBoxPwdMasterKey.Text == "Enter the password for your new Master Key" && buttonPwdMasterKeyOk.Text == "create")
            {
                textBoxPwdMasterKey.PasswordChar = '*';
                textBoxPwdMasterKey.Text = "";
                checkBoxHiddenMasterKey.Enabled = true;
            }

            if (textBoxPwdMasterKey.Text == "Enter your password" && buttonPwdMasterKeyOk.Text == "check")
            {
                textBoxPwdMasterKey.PasswordChar = '*';
                textBoxPwdMasterKey.Text = "";
                checkBoxHiddenMasterKey.Enabled = true;
            }
        }

        private void textBoxPwdMasterKey_LostFocus(object sender, EventArgs e)
        {
            if (textBoxPwdMasterKey.Text == "" && buttonPwdMasterKeyOk.Text == "create")
            {
                textBoxPwdMasterKey.PasswordChar = '\0';
                textBoxPwdMasterKey.Text = "Enter the password for your new Master Key";
                checkBoxHiddenMasterKey.Enabled = false;
            }

            if (textBoxPwdMasterKey.Text == "" && buttonPwdMasterKeyOk.Text == "check")
            {
                textBoxPwdMasterKey.PasswordChar = '\0';
                textBoxPwdMasterKey.Text = "Enter your password";
                checkBoxHiddenMasterKey.Enabled = false;
            }
        }

        private void textBoxPwdMasterKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                buttonPwdMasterKeyOk.PerformClick();
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                btnSearch.PerformClick();
            }
        }



        #endregion

        #region Attributes

        public string text = ""; // Text to Encrypt or Decrypt
        public string pathFile = ""; // Path of MasterKey file
        public string nameFile = ""; // Name of MasterKey file
        public string masterKeyPassword = ""; // User password used to encrypt and decrypt the Master Key
        public string actionForButtonGo = ""; // Save the action for the buttonGo


        #endregion

        #region Buttons

        private void buttonOkMasterKey_Click(object sender, EventArgs e)
        {
            if(buttonOkMasterKey.Text == "Open")
            {
                // Open openFileDialog for open the Master Key from file
                openFileDialog1.Filter = "SD Master Keys|*.sdmk";
                openFileDialog1.Title = "Open a Master Key";

                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // MessageBox.Show("OPENED");

                    this.pathFile = openFileDialog1.FileName;
                    this.nameFile = openFileDialog1.SafeFileName;


                    StreamReader objStreamReader = new StreamReader(this.pathFile);
                    
                    this.text = "";
                    
                    this.text = objStreamReader.ReadToEnd();

                    objStreamReader.Close();

                    textBoxPwdMasterKey.Focus();
                    
                    //Change the properties of controls
                    comboBoxSelectMasterKey.Enabled = false;
                    buttonOkMasterKey.Enabled = false;                   
                    pictureBoxMKOpened.Visible = true;
                    textBoxPwdMasterKey.Visible = true;
                    buttonPwdMasterKeyOk.Visible = true;
                    buttonPwdMasterKeyOk.Text = "check";
                    buttonPwdMasterKeyBack.Visible = true;
                    checkBoxHiddenMasterKey.Visible = true;
                    textBoxPwdMasterKey.Text = "Enter your password";
                    textBoxPwdMasterKey.PasswordChar = '\0';

                    // Change comboBoxSelectMasterKey to Open
                    comboBoxSelectMasterKey.SelectedItem = "Open Master Key";

                    // Change buttonOkMasterKey to Open
                    buttonOkMasterKey.Text = "Open";
                }
            }

            if (buttonOkMasterKey.Text == "Create")
            {
                if (buttonOkMasterKey.Text == "Create")
                {
                    // MessageBox.Show("CREATE");

                    buttonPwdMasterKeyOk.Focus();
                    
                    // Disable ComboBox of select Open or Create Master Key
                    comboBoxSelectMasterKey.Enabled = false;
                    buttonOkMasterKey.Enabled = false;

                    // Show components of Create new Master Key
                    buttonPwdMasterKeyOk.Visible = true;
                    buttonPwdMasterKeyOk.Enabled = true;
                    buttonPwdMasterKeyOk.Text = "create";
                    buttonPwdMasterKeyBack.Visible = true;
                    textBoxPwdMasterKey.Visible = true;
                    checkBoxHiddenMasterKey.Visible = true;
                    checkBoxHiddenMasterKey.Enabled = false;
                }
            }
        }

        private void buttonPwdMasterKeyOk_Click(object sender, EventArgs e)
        {
            if (buttonPwdMasterKeyOk.Text == "create")
            {
                // Check textBoxNewMasterKey is not empty
                if (textBoxPwdMasterKey.Text == "Enter the password for your new Master Key")
                {
                    MessageBox.Show("Error. Enter the password for your new Master Key", "Error");
                }

                // If Check textBoxNewMasterKey is not empty, then create the Master Key
                if (textBoxPwdMasterKey.Text != "Enter the password for your new Master Key")
                {

                    // Adds password entered by user to masterKeyPassword used to encrypt Masterkey
                    this.masterKeyPassword = textBoxPwdMasterKey.Text;

                    // Open saveDialog for save the Master Key to file
                    saveFileDialog1.Title = "Save Master Key file as...";
                    saveFileDialog1.Filter = "SD Master Key | *.sdmk";

                    if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        this.pathFile = saveFileDialog1.FileName;

                        StreamWriter objStreamWriter = new StreamWriter(this.pathFile);

                        if (Encrypt(this.masterKeyPassword, "MasterKey"))
                        {
                            objStreamWriter.WriteLine(this.text);

                            objStreamWriter.Close();
                            MessageBox.Show("New Master Key created successfully!", "New Master Key");

                            // Re-Enable ComboBox of select Open or Create Master Key
                            comboBoxSelectMasterKey.Enabled = true;
                            buttonOkMasterKey.Enabled = true;

                            // Disable components of Create new Master Key
                            textBoxPwdMasterKey.Visible = false;
                            buttonPwdMasterKeyOk.Visible = false;
                            buttonPwdMasterKeyBack.Visible = false;
                            checkBoxHiddenMasterKey.Visible = false;
                            textBoxPwdMasterKey.Text = "Enter the password for your new Master Key";
                            textBoxPwdMasterKey.PasswordChar = '\0';

                            // Change comboBoxSelectMasterKey to Open
                            comboBoxSelectMasterKey.SelectedItem = "Open Master Key";

                            // Change buttonOkMasterKey to Open
                            buttonOkMasterKey.Text = "Open";
                        }  
                    }
                }
            }

            if (buttonPwdMasterKeyOk.Text == "check")
            { 
                // Check textBoxNewMasterKey is not empty
                if (textBoxPwdMasterKey.Text == "Enter the password for your new Master Key" || textBoxPwdMasterKey.Text == "")
                {
                    MessageBox.Show("Error. Enter your password", "Error");
                }

                // If Check textBoxNewMasterKey is not empty, check and try decrypt MasterKey
                this.masterKeyPassword = textBoxPwdMasterKey.Text;
                
                if (Decrypt(this.text, "MasterKey"))
                {
                    // Hide all controls of Masterkey
                    textBoxPwdMasterKey.Visible = false;
                    buttonOkMasterKey.Visible = false;
                    buttonPwdMasterKeyOk.Visible = false;
                    buttonPwdMasterKeyBack.Visible = false;
                    checkBoxHiddenMasterKey.Visible = false;
                    comboBoxSelectMasterKey.Visible = false;

                    // Show controls of MasterKey Selected
                    buttonChangeMasterKey.Visible = true; 
                    labelNameMasterKey.Text = this.nameFile;
                    groupBoxMKSelectedOK.Visible = true;
                    pictureBoxMasterKeyOk.Visible = true;
                    labelNameMasterKey.Visible = true;
                    
                    // Enabled all controls to Encrypt and Decrypt
                    groupBoxEncryptAndDecrypt.Enabled = true;
                }
            }
        }

        private void buttonNewMasterKeyBack_Click(object sender, EventArgs e)
        {

            // Re-Enable ComboBox of select Open or Create Master Key
            comboBoxSelectMasterKey.Enabled = true;
            buttonOkMasterKey.Enabled = true;

            // Disable components of Create new Master Key
            textBoxPwdMasterKey.Visible = false;
            buttonPwdMasterKeyOk.Visible = false;
            buttonPwdMasterKeyBack.Visible = false;
            checkBoxHiddenMasterKey.Checked = false;
            checkBoxHiddenMasterKey.Visible = false;
            textBoxPwdMasterKey.Text = "Enter the password for your new Master Key";
            textBoxPwdMasterKey.PasswordChar = '\0';
            pictureBoxMKOpened.Visible = false;
        }

        private void buttonChangeMasterKey_Click(object sender, EventArgs e)
        {
            // Re-Enable ComboBox of select Open or Create Master Key
            comboBoxSelectMasterKey.Enabled = true;
            comboBoxSelectMasterKey.Visible = true;
            buttonOkMasterKey.Enabled = true;
            buttonOkMasterKey.Visible = true;

            // Disable components of Create new Master Key
            
            pictureBoxMKOpened.Visible = false;

            groupBoxMKSelectedOK.Visible = false;
            pictureBoxMasterKeyOk.Visible = false;
            labelNameMasterKey.Visible = false;
            labelNameMasterKey.Text = "";
            buttonChangeMasterKey.Visible = false;
            
            textBoxPwdMasterKey.Text = "Enter the password for your new Master Key";
            textBoxPwdMasterKey.PasswordChar = '\0';
            
            // Disable components of Encrypt and Decrypt
            groupBoxEncryptAndDecrypt.Enabled = false;

            radioButtonDecryptFile.Checked = false;
            radioButtonEncryptText.Checked = false;
            radioButtonDecryptText.Checked = false;

            textBoxText.Enabled = false;
            textBoxText.Clear();
            buttonGo.Enabled = false;
            buttonGo.Text = "";
            buttonCopy.Enabled=false;
            buttonPaste.Enabled = false;
            buttonSaveAs.Enabled = false;
            buttonClear.Enabled = false;
            grpSearch.Enabled = false;
            
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            labelProgressBarText.Visible = true;
            pictureBoxLoading.Visible = true;
            groupBoxEncryptAndDecrypt.Enabled = false;
            buttonGo.Enabled = false;
   

            /// Encrypt Text
            if (this.actionForButtonGo == "Encrypt Text")
            {
                if (textBoxText.Text == "")
                {
                    MessageBox.Show("Error. No text for encrypting", "Failed to Encrypt");
                }

                else
                {
                    //Encryptation
                    if (Encrypt(textBoxText.Text, "Text"))
                    {
                        textBoxText.Text = this.text;
                        buttonSaveAs.Enabled = true;
                        textBoxText.Enabled = true;
                    }
                }
                
                labelProgressBarText.Visible = false;
                pictureBoxLoading.Visible = false;
                groupBoxEncryptAndDecrypt.Enabled = true;
                buttonGo.Enabled = true;
            }

            /// Decrypt File
            if (this.actionForButtonGo == "Decrypt File")
            {
                // Open openFileDialog for open the encrypted text file
                openFileDialog1.Title = "Load encrypted text file";
                openFileDialog1.Filter = "SD File Encrypted | *.sde";

                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.pathFile = openFileDialog1.FileName;
                    this.nameFile = openFileDialog1.SafeFileName;

                    StreamReader objStreamReader = new StreamReader(this.pathFile);

                    this.text = "";

                    this.text = objStreamReader.ReadToEnd();

                    objStreamReader.Close();

                    textBoxText.Text = this.text;

                    actionForButtonGo = "Decrypt Text";

                    buttonGo.PerformClick();
                }

                else
                {
                    textBoxText.ReadOnly = true;
                    buttonCopy.Enabled = true;
                    buttonSaveAs.Enabled = false;

                    labelProgressBarText.Visible = false;
                    pictureBoxLoading.Visible = false;
                    groupBoxEncryptAndDecrypt.Enabled = true;
                    buttonGo.Enabled = true;
                }
            }

            /// Decrypt Text
            if (this.actionForButtonGo == "Decrypt Text")
            {
                string auxText = "";

                labelProgressBarText.Visible = true;
                pictureBoxLoading.Visible = true;
                groupBoxEncryptAndDecrypt.Enabled = false;
                buttonGo.Enabled = false;

                if (textBoxText.Text == "" && buttonGo.Text == "Decrypt Text")
                {
                    MessageBox.Show("Error. No text for encrypting", "Failed to Encrypt");
                }
                
                if (Decrypt(textBoxText.Text, "Text"))
                {
                    foreach (char item in this.text)
                    {
                        if (item == 'Ñ')
                        {
                            break;
                        }
                        else
                        {
                            auxText += item;
                        }
                    }

                    this.text = auxText;
                    textBoxText.Text = this.text;
                   
                    textBoxText.ReadOnly = true;
                    buttonCopy.Enabled = true;
                    buttonSaveAs.Enabled = false;          
                }

                else
                {
                    labelProgressBarText.Visible = false;
                    pictureBoxLoading.Visible = false;
                    groupBoxEncryptAndDecrypt.Enabled = true;
                    buttonGo.Enabled = true;
                }

                labelProgressBarText.Visible = false;
                pictureBoxLoading.Visible = false;
                textBoxText.Enabled = true;
                groupBoxEncryptAndDecrypt.Enabled = true;
                buttonGo.Enabled = true;
                
                // If the above function was used by the function "Decrypt File", then we return the property of the buttonGo to "Decrypt File"
                if (buttonGo.Text == "Decrypt File")
                {
                    actionForButtonGo = "Decrypt File";
                }
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(textBoxText.Text);
        }

        private void buttonPaste_Click(object sender, EventArgs e)
        {
            textBoxText.Text = Clipboard.GetText();
        }

        private void buttonSaveAs_Click(object sender, EventArgs e)
        {
            // Open saveDialog for save the Text Encrypted to file
            saveFileDialog1.Title = "Save encrypted text file as...";
            saveFileDialog1.Filter = "SD File Encrypted | *.sde";

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.pathFile = saveFileDialog1.FileName;

                StreamWriter objStreamWriter = new StreamWriter(this.pathFile);

                objStreamWriter.WriteLine(textBoxText.Text);

                objStreamWriter.Close();
                MessageBox.Show("SD Encrypted File saved successfully!", "Saved File");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxText.Clear();
            
            if (actionForButtonGo == "Encrypt Text")
            {
                buttonGo.Enabled = true;
                textBoxText.ReadOnly = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int index = 0;
            string temp = textBoxText.Text;
            textBoxText.Text = "";
            textBoxText.Text = temp;

            while (index < textBoxText.Text.LastIndexOf(txtSearch.Text))
            {
                // Searches the text in a RichTextBox control for a string within a range of text withing the control and with specific options applied to the search.
                textBoxText.Find(txtSearch.Text, index, textBoxText.TextLength, RichTextBoxFinds.None);
                // Selection Color. This is added automatically when a match is found.
                textBoxText.SelectionBackColor = Color.Yellow;
                textBoxText.Focus();
                // After a match is found the index is increased so the search won't stop at the same match again. This makes possible to highlight same words at the same time.
                index = textBoxText.Text.IndexOf(txtSearch.Text, index) + 1;

            };
        }

       

        #endregion

        #region ComboBoxesSelect

        private void comboBoxSelectMasterKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSelectMasterKey.SelectedItem.ToString() == "Open Master Key")
            {
                buttonOkMasterKey.Text = "Open";
            }

            if (comboBoxSelectMasterKey.SelectedItem.ToString() == "Create new Master Key")
            {
                buttonOkMasterKey.Text = "Create";
            }
        }

        #endregion

        #region CheckBoxes

        private void checkBoxHiddenMasterKey_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHiddenMasterKey.Checked == true)
            {
                textBoxPwdMasterKey.PasswordChar = '\0';
            }
            else
            {
                if (checkBoxHiddenMasterKey.Text != "")
                {
                    textBoxPwdMasterKey.PasswordChar = '*';
                }
            }
        }

        #endregion//

        #region RadioButtons

        private void radioButtonEncryptText_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEncryptText.Checked)
            {
                textBoxText.Enabled = true;
                textBoxText.ReadOnly = false;
                buttonGo.Enabled = true;
                buttonCopy.Enabled = false;
                buttonPaste.Enabled = true;
                buttonSaveAs.Enabled = false;
                buttonClear.Enabled = true;
                grpSearch.Enabled = true;

                buttonGo.Text = "Encrypt Text";
                this.actionForButtonGo = "Encrypt Text";
            }
        }

        private void radioButtonDecryptText_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDecryptText.Checked)
            {
                textBoxText.Enabled = true;
                textBoxText.ReadOnly = true;
                buttonGo.Enabled = true;
                buttonCopy.Enabled = false;
                buttonPaste.Enabled = true;
                buttonSaveAs.Enabled = false;
                buttonClear.Enabled = true;
                grpSearch.Enabled = true;

                buttonGo.Text = "Decrypt Text";
                this.actionForButtonGo = "Decrypt Text";
            }
        }

        private void radioButtonDecryptFile_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDecryptFile.Checked)
            {
                textBoxText.Clear();
                textBoxText.Enabled = true;
                textBoxText.ReadOnly = true;
                buttonGo.Enabled = true;
                buttonCopy.Enabled = false;
                buttonPaste.Enabled = false;
                buttonSaveAs.Enabled = false;
                buttonClear.Enabled = false;
                textBoxText.Enabled = false;
                grpSearch.Enabled = true;


                buttonGo.Text = "Decrypt File";
                this.actionForButtonGo = "Decrypt File";
            }
        }

        #endregion

        #region ToolStripSplits

        //toolStripSplitHelp
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Juan Pablo Torrellas on July 7, 2015.\nE-mail: jp.torrellas@gmx.com\n\nCopyright (c) 2015 Juan Pablo Torrellas. All rights reserved.", "About the SD - Secure Data software:");
        }

        #endregion

        #region Methods

        #region Encrypt and Decrypt

        // Method for Encrypt 
        public bool Encrypt(string txt, string typeOfEncryption)
        {
            // Create object DateTime.Now
            DateTime dt = new DateTime();
            dt = DateTime.Now;

            try
            {
                StringBuilder objStreamBuilder1 = new StringBuilder();

                // Adds Date and Time now to text
                objStreamBuilder1.Append(DateTime.Now.ToString());

                // Adds Random Text to text
                objStreamBuilder1.Append(GenerateRandomText());

                // masterKey = DateTime + Random Text
                this.text = txt + "Ñ" + objStreamBuilder1.ToString();

                // Array where we store the key for encryption 3DES.
                byte[] key;

                // Array where we save the string encrypted.
                byte[] array = UTF8Encoding.UTF8.GetBytes(text);

                // We encrypt using the algorithm MD5.
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(masterKeyPassword));
                md5.Clear();

                // We encrypt using the algorithm 3DES.
                TripleDESCryptoServiceProvider objTripleDes = new TripleDESCryptoServiceProvider();
                objTripleDes.Key = key;
                objTripleDes.Mode = CipherMode.ECB;
                objTripleDes.Padding = PaddingMode.PKCS7;

                // We began the conversion of the string.
                ICryptoTransform convertir = objTripleDes.CreateEncryptor();

                //Array of bytes where we save the string encrypted.
                byte[] result = convertir.TransformFinalBlock(array, 0, array.Length);
                objTripleDes.Clear();

                StringBuilder objStreamBuilder2 = new StringBuilder();

                // We convert the string.
                objStreamBuilder2.AppendLine(Convert.ToBase64String(result, 0, result.Length) + "Ñ");


                ///ONLY for encrypt MasterKey
                if (typeOfEncryption == "MasterKey")
                {

                    // Adds Footer Text not encrypted to MasterKey Encrypted
                    objStreamBuilder2.AppendLine("");
                    objStreamBuilder2.AppendLine("");
                    objStreamBuilder2.AppendLine("##################################################################");
                    objStreamBuilder2.AppendLine("#");
                    objStreamBuilder2.AppendLine("#  This is a MasterKey of SD - Secure Data software");
                    objStreamBuilder2.AppendLine("#  Generated on: " + dt.ToString("MMM d, yyyy") + " at "+dt.ToString("H:mm:ss") + " Hs.");
                    objStreamBuilder2.AppendLine("#");
                    objStreamBuilder2.AppendLine("##################################################################");
                    objStreamBuilder2.AppendLine("##################################################################");
                    objStreamBuilder2.AppendLine("#");
                    objStreamBuilder2.AppendLine("#  VERY IMPORTANT: DO NOT MODIFY THE CONTENTS OF THIS FILE!!!");
                    objStreamBuilder2.AppendLine("#");
                    objStreamBuilder2.AppendLine("##################################################################");
                    objStreamBuilder2.AppendLine("##################################################################");
                    objStreamBuilder2.AppendLine("#");
                    objStreamBuilder2.AppendLine("#  About the SD - Secure Data software:");
                    objStreamBuilder2.AppendLine("#");
                    objStreamBuilder2.AppendLine("#  Created by Juan Pablo Torrellas on July 6, 2015.");
                    objStreamBuilder2.AppendLine("#  E-mail: jp.torrellas@gmx.com");
                    objStreamBuilder2.AppendLine("#  Copyright (c) 2015 Juan Pablo Torrellas. All rights reserved.");
                    objStreamBuilder2.AppendLine("#");
                    objStreamBuilder2.AppendLine("##################################################################");

                    this.text = objStreamBuilder2.ToString();
                }

                ///ONLY for encrypt Text of textBoxText
                if (typeOfEncryption == "Text")
                {
                    if (textBoxText.Text == "")
                    {
                        objStreamBuilder2.Clear();
                        return false;
                    }

                    else
                    {
                        buttonGo.Enabled = false;
                        buttonCopy.Enabled = true;
                        buttonPaste.Enabled = false;
                        buttonSaveAs.Enabled = true;
                        textBoxText.ReadOnly = true;

                        // Adds Footer Text not encrypted to TextEncrypted
                        objStreamBuilder2.AppendLine("");
                        objStreamBuilder2.AppendLine("");
                        objStreamBuilder2.AppendLine("##################################################################");
                        objStreamBuilder2.AppendLine("#");
                        objStreamBuilder2.AppendLine("#  This is an encrypted text of SD - Secure Data software");
                        objStreamBuilder2.AppendLine("#  Generated on: " + dt.ToString("MMM d, yyyy") + " at " + dt.ToString("H:mm:ss") + " Hs.");
                        objStreamBuilder2.AppendLine("#");
                        objStreamBuilder2.AppendLine("##################################################################");
                        objStreamBuilder2.AppendLine("##################################################################");
                        objStreamBuilder2.AppendLine("#");
                        objStreamBuilder2.AppendLine("#  VERY IMPORTANT: DO NOT MODIFY THE CONTENTS OF THIS FILE!!!");
                        objStreamBuilder2.AppendLine("#");
                        objStreamBuilder2.AppendLine("##################################################################");
                        objStreamBuilder2.AppendLine("##################################################################");
                        objStreamBuilder2.AppendLine("#");
                        objStreamBuilder2.AppendLine("#  About the SD - Secure Data software:");
                        objStreamBuilder2.AppendLine("#");
                        objStreamBuilder2.AppendLine("#  Created by Juan Pablo Torrellas on July 6, 2015.");
                        objStreamBuilder2.AppendLine("#  E-mail: jp.torrellas@gmx.com");
                        objStreamBuilder2.AppendLine("#  Copyright (c) 2015 Juan Pablo Torrellas. All rights reserved.");
                        objStreamBuilder2.AppendLine("#");
                        objStreamBuilder2.AppendLine("##################################################################");

                        this.text = objStreamBuilder2.ToString();
                    }
                }
                
                return true;
            }

            catch
            {
                return false; 
            }       
        }

        // Method for Decrypt 
        public bool Decrypt(string txt, string typeOfEncryption)
        {
            try
            {
                this.text = "";

                foreach (char item in txt)
                {
                    if (item == 'Ñ')
                    {
                        break;
                    }
                    else
                    {
                        this.text += item;
                    }
                }
                
                // Array where we store the key for dencryption 3DES.
                byte[] key;

                // Array where we save the string decrypted.
                byte[] array = Convert.FromBase64String(this.text); 

                // We decrypt using the algorithm MD5.
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(masterKeyPassword));
                md5.Clear();

                // We encrypt using the algorithm 3DES.
                TripleDESCryptoServiceProvider objTripleDes = new TripleDESCryptoServiceProvider();
                objTripleDes.Key = key;
                objTripleDes.Mode = CipherMode.ECB;
                objTripleDes.Padding = PaddingMode.PKCS7;
                ICryptoTransform convertir = objTripleDes.CreateDecryptor();
                byte[] result = convertir.TransformFinalBlock(array, 0, array.Length);
                objTripleDes.Clear();

                string stringDecrypted = UTF8Encoding.UTF8.GetString(result); // We receive the string

                this.text = stringDecrypted;
                
                return true; // whe return the bool
            }

            catch
            {
                MessageBox.Show("Error. Wrong password of Master Key", "Error");

                return false; // whe return the bool
            }
        }



        #endregion

        #region Generate Random text to add in MasterKey

        public string GenerateRandomText()
        {
            Random objRandom = new Random();

            string possibleChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            int length = possibleChars.Length;
            char charSelected;
            int lengthNewString = 777;
            string randomString = "";

            for (int i = 0; i < lengthNewString; i++)
            {
                charSelected = possibleChars[objRandom.Next(length)];
                randomString += charSelected.ToString();
            }

            return randomString;
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        #endregion

       


        

       

        
    }
}
