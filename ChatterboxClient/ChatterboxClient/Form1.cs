using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatterboxClient
{
    public partial class ChatterboxMain : Form
    {
        public ChatterboxMain()
        {
            InitializeComponent();
        }

        //Opens clicked links in the user's default web browser
        private void richTextBoxOutput_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        //Activated when the send button is clicked
        //Calls the function to send the message and clears the textBox
        //Selects the text box
        private void buttonSend_Click(object sender, EventArgs e)
        {
            SendMessage(textBoxMessage.Text);
            textBoxMessage.Text = null;
            textBoxMessage.Select();
        }

        //Adds the message to the RichTextBox and moves it to the next line
        private void SendMessage(string message)
        {
            richTextBoxOutput.AppendText(message + "\n");
        }

        //Called when a key is pressed if the form is selected
        //Automatically clicks the Send Button if Enter is the key pressed
        private void ChatterboxMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSend.PerformClick();
            }
            
        }

        //Called when the form loads
        //Selects the text box
        private void ChatterboxMain_Load(object sender, EventArgs e)
        {
            textBoxMessage.Select();
        }


        //Called when a key is pressed if the text box is selected
        //Automatically clicks the Send Button if Enter is the key pressed
        private void textBoxMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSend.PerformClick();
            }
        }
    }
}
