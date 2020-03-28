using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caesar_Cipher_Algorithm
{
    public partial class Form1 : Form
    {
        Encrypt encrypt;
        Decrypt decrypt;
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                encrypt = new Encrypt(richTextBox1.Text);
                richTextBox1.Text = "";

                richTextBox2.Text = encrypt.ToString();
            }
            else
            { MessageBox.Show("  The plain text box is empty please enter your text  ", "erorr", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text != "")
            {
                decrypt = new Decrypt(richTextBox2.Text);
                richTextBox2.Text = "";

                richTextBox1.Text = decrypt.ToString();
            }
            else
            { MessageBox.Show("  The cipherText box is empty please enter your text  ", "erorr", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("will encrypt/decrypt that string \t\n" +
"using Caesar Cipher and prints out the results on the screen.In this time, the user will not be asked to\t\n" +
"enter any keys, encryption should be based on the following conditions:\t\n" +
"• Replace the characters at the odd positions by the previous character in the alphabet.\t\n" +
"• Replace the characters at the even positions by the next 3rd character in the alphabet.", "Assignment details");
        }
    }
}
