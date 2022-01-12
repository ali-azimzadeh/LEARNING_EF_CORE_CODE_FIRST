
namespace LESSON_02
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
            this.HashButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.HashedPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EncryptConnectionStringButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.HashFileButton = new System.Windows.Forms.Button();
            this.browsButton = new System.Windows.Forms.Button();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.HashFileTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HashButton
            // 
            this.HashButton.Font = new System.Drawing.Font("IRANSans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HashButton.Location = new System.Drawing.Point(24, 126);
            this.HashButton.Name = "HashButton";
            this.HashButton.Size = new System.Drawing.Size(555, 36);
            this.HashButton.TabIndex = 0;
            this.HashButton.Text = "Compute Hash";
            this.HashButton.UseVisualStyleBackColor = true;
            this.HashButton.Click += new System.EventHandler(this.HashButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("IRANSans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(151, 16);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(428, 35);
            this.passwordTextBox.TabIndex = 1;
            // 
            // HashedPasswordTextBox
            // 
            this.HashedPasswordTextBox.Font = new System.Drawing.Font("IRANSans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HashedPasswordTextBox.Location = new System.Drawing.Point(151, 77);
            this.HashedPasswordTextBox.Name = "HashedPasswordTextBox";
            this.HashedPasswordTextBox.ReadOnly = true;
            this.HashedPasswordTextBox.Size = new System.Drawing.Size(428, 35);
            this.HashedPasswordTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hash Password";
            // 
            // EncryptConnectionStringButton
            // 
            this.EncryptConnectionStringButton.Font = new System.Drawing.Font("IRANSans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptConnectionStringButton.Location = new System.Drawing.Point(24, 419);
            this.EncryptConnectionStringButton.Name = "EncryptConnectionStringButton";
            this.EncryptConnectionStringButton.Size = new System.Drawing.Size(555, 36);
            this.EncryptConnectionStringButton.TabIndex = 5;
            this.EncryptConnectionStringButton.Text = "Encrypt ConnectionString";
            this.EncryptConnectionStringButton.UseVisualStyleBackColor = true;
            this.EncryptConnectionStringButton.Click += new System.EventHandler(this.EncryptConnectionStringButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Font = new System.Drawing.Font("IRANSans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecryptButton.Location = new System.Drawing.Point(24, 461);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(555, 36);
            this.DecryptButton.TabIndex = 6;
            this.DecryptButton.Text = "Decrypt ConnectionString";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // HashFileButton
            // 
            this.HashFileButton.Font = new System.Drawing.Font("IRANSans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HashFileButton.Location = new System.Drawing.Point(24, 323);
            this.HashFileButton.Name = "HashFileButton";
            this.HashFileButton.Size = new System.Drawing.Size(555, 36);
            this.HashFileButton.TabIndex = 7;
            this.HashFileButton.Text = "Compute Hash File";
            this.HashFileButton.UseVisualStyleBackColor = true;
            this.HashFileButton.Click += new System.EventHandler(this.HashFileButton_Click);
            // 
            // browsButton
            // 
            this.browsButton.Font = new System.Drawing.Font("IRANSans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browsButton.Location = new System.Drawing.Point(496, 238);
            this.browsButton.Name = "browsButton";
            this.browsButton.Size = new System.Drawing.Size(77, 36);
            this.browsButton.TabIndex = 8;
            this.browsButton.Text = "Brows";
            this.browsButton.UseVisualStyleBackColor = true;
            this.browsButton.Click += new System.EventHandler(this.browsButton_Click);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Font = new System.Drawing.Font("IRANSans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePathTextBox.Location = new System.Drawing.Point(151, 238);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(321, 35);
            this.filePathTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 27);
            this.label3.TabIndex = 10;
            this.label3.Text = "File Path";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "Hash File";
            // 
            // HashFileTextBox
            // 
            this.HashFileTextBox.Font = new System.Drawing.Font("IRANSans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HashFileTextBox.Location = new System.Drawing.Point(151, 282);
            this.HashFileTextBox.Name = "HashFileTextBox";
            this.HashFileTextBox.ReadOnly = true;
            this.HashFileTextBox.Size = new System.Drawing.Size(428, 35);
            this.HashFileTextBox.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 512);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HashFileTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.browsButton);
            this.Controls.Add(this.HashFileButton);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptConnectionStringButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HashedPasswordTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.HashButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HashButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox HashedPasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EncryptConnectionStringButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Button HashFileButton;
        private System.Windows.Forms.Button browsButton;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox HashFileTextBox;
    }
}