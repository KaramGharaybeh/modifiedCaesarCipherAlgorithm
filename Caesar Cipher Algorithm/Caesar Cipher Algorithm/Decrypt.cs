using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher_Algorithm
{
    class Decrypt
    {

        private string text;
        private readonly string alphabet = "abcdefghijklmnopqrstuvwxyz";
        private readonly string ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        StringBuilder plainText = new StringBuilder();

        public Decrypt(string plainText)
        {

            if (plainText != "")
            {
                this.text = plainText;
                //  textVal = new int[plainText.Length];
                doDecrypt();
            }
        }

        private void doDecrypt()
        {
            for (int i = 0; i < this.text.Length; i++)
            {

                if (char.IsLetter(text[i]))
                {

                    if (i % 2 != 0)
                    {
                        DecryptOdd(text[i]);
                    }
                    else
                    {
                        DecryptEven(text[i]);
                    }
                }
                else
                {
                    plainText.Append(text[i]);
                }
            }
        }

        private void DecryptOdd(char ch)
        {
            char temp;

            if (char.IsUpper(ch))
            {


                temp = ALPHABET[Math.Abs((ALPHABET.IndexOf(ch) + 1) + 26) % 26];

                // System.Windows.Forms.MessageBox.Show("A -->   " + temp);

            }
            else
            {
                temp = alphabet[Math.Abs((alphabet.IndexOf(ch) + 1) + 26) % 26];
            }
            plainText.Append(temp);
        }
        private void DecryptEven(char ch)
        {
            char temp;
            if (char.IsUpper(ch))
            {
                temp = ALPHABET[Math.Abs((ALPHABET.IndexOf(ch) - 3) + 26) % 26];

            }
            else
            {
                temp = alphabet[Math.Abs((alphabet.IndexOf(ch) - 3) + 26) % 26];


            }

            plainText.Append(temp);
        }

        public override string ToString()
        {
            return plainText.ToString();
        }



    }
}
