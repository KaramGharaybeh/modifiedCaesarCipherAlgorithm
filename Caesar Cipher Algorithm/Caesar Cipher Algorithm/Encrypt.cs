using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher_Algorithm
{
    class Encrypt
    {
        private string text;
       private readonly string alphabet = "abcdefghijklmnopqrstuvwxyz";
        private readonly string ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        StringBuilder cipherText = new StringBuilder();

        public Encrypt(string plainText)
        {

            if (plainText != "")
            {
                this.text = plainText;
                //  textVal = new int[plainText.Length];
                doEncrypt();
            }
        }

        private void doEncrypt()
        {
            for (int i = 0; i < this.text.Length; i++)
            {

                if (char.IsLetter(text[i]))
                {

                    if (i % 2 != 0)
                    {
                        encryptOdd(text[i]);
                    }
                    else
                    {
                        encryptEven(text[i]);
                    }
                }
                else
                {
                    cipherText.Append(text[i]);
                }
            }
        }

        private void encryptOdd(char ch)
        {
            char temp;

            if (char.IsUpper(ch))
            {


                temp = ALPHABET[Math.Abs((ALPHABET.IndexOf(ch) - 1) + 26) % 26];

                // System.Windows.Forms.MessageBox.Show("A -->   " + temp);

            }
            else
            {
                temp = alphabet[Math.Abs((alphabet.IndexOf(ch) - 1) + 26) % 26];
            }
            cipherText.Append(temp);
        }
        private void encryptEven(char ch)
        {
            char temp;
            if (char.IsUpper(ch))
            {
                temp = ALPHABET[Math.Abs((ALPHABET.IndexOf(ch) + 3) + 26) % 26];

            }
            else
            {
                temp = alphabet[Math.Abs((alphabet.IndexOf(ch) + 3) + 26) % 26];


            }

            cipherText.Append(temp);
        }

        public override string ToString()
        {
            return cipherText.ToString();
        }
    }


}
