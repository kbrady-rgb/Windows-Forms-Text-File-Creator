﻿namespace Friend_File
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
            this.exitButton = new System.Windows.Forms.Button();
            this.writeNameButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.promptLabel = new System.Windows.Forms.Label();
            this.readFileButton = new System.Windows.Forms.Button();
            this.friendListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(275, 413);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 28);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // writeNameButton
            // 
            this.writeNameButton.Location = new System.Drawing.Point(224, 65);
            this.writeNameButton.Margin = new System.Windows.Forms.Padding(4);
            this.writeNameButton.Name = "writeNameButton";
            this.writeNameButton.Size = new System.Drawing.Size(100, 28);
            this.writeNameButton.TabIndex = 6;
            this.writeNameButton.Text = "&Write Name";
            this.writeNameButton.UseVisualStyleBackColor = true;
            this.writeNameButton.Click += new System.EventHandler(this.WriteNameButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(172, 21);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(203, 22);
            this.nameTextBox.TabIndex = 5;
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(19, 25);
            this.promptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(147, 17);
            this.promptLabel.TabIndex = 4;
            this.promptLabel.Text = "Enter a friend\'s name:";
            // 
            // readFileButton
            // 
            this.readFileButton.Location = new System.Drawing.Point(22, 123);
            this.readFileButton.Name = "readFileButton";
            this.readFileButton.Size = new System.Drawing.Size(98, 23);
            this.readFileButton.TabIndex = 8;
            this.readFileButton.Text = "&Read File";
            this.readFileButton.UseVisualStyleBackColor = true;
            this.readFileButton.Click += new System.EventHandler(this.ReadFileButton_Click);
            // 
            // friendListBox
            // 
            this.friendListBox.FormattingEnabled = true;
            this.friendListBox.ItemHeight = 16;
            this.friendListBox.Location = new System.Drawing.Point(23, 166);
            this.friendListBox.Name = "friendListBox";
            this.friendListBox.Size = new System.Drawing.Size(351, 212);
            this.friendListBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AcceptButton = this.writeNameButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(395, 462);
            this.Controls.Add(this.friendListBox);
            this.Controls.Add(this.readFileButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.writeNameButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.promptLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Friend File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button writeNameButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.Button readFileButton;
        private System.Windows.Forms.ListBox friendListBox;
    }
}

