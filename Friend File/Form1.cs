using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

/***************************************************************
* Name        : File IO
* Author      : Kabrina Brady
* Created     : 9/24/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work
* Description : User enters names individually, which get written to a file. When "Read File" is clicked, the contents of the file are displayed in the ListBox.
*               Input:  Keyboard strokes, button clicks
*               Output: MessageBox, ListBox content
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or unmodified. I have not given other fellow student(s) access to my program.         
***************************************************************/


namespace Friend_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void WriteNameButton_Click(object sender, EventArgs e)
        {
            string stringTester = nameTextBox.Text; //makes variable that holds user input
            bool noNum = stringTester.All(c => Char.IsLetter(c)); //assigns bool value "true" if no numbers, assigns "false" if contains numbers

            if (noNum == false) //checks to see if string contains numbers
            {
                MessageBox.Show("Entry must only contain letters."); //error message
            }
            else
            {
                try
                {
                    //streamwriter variable
                    StreamWriter outputFile;

                    //open Friend.txt file for appending, and get a streamwriter object
                    outputFile = File.AppendText("Friend.txt");

                    //write friend's name to file
                    outputFile.WriteLine(nameTextBox.Text);

                    //close file
                    outputFile.Close();

                    //let user know name was written
                    MessageBox.Show("The name was written.");

                    //clear textbox
                    nameTextBox.Text = "";

                    //put focus on textbox
                    nameTextBox.Focus();
                }
                catch (Exception ex)
                {
                    //display error message
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //closes form
            this.Close();
        }

        private void ReadFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                //holds friend name
                string friendName;

                //streamreader variable
                StreamReader inputFile;

                //open file and get streamreader object
                inputFile = File.OpenText("Friend.txt");

                //clear anything currently in listbox
                friendListBox.Items.Clear();

                //read contents of file
                while (!inputFile.EndOfStream)
                {
                    //get a friend name
                    friendName = inputFile.ReadLine();

                    //add friend name to listbox
                    friendListBox.Items.Add(friendName);
                }
                inputFile.Close(); //closes the file so Write Name process can be done again
            }
            catch
            {
                //error message
                MessageBox.Show("Error");
            }
        }
    }
}
