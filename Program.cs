using System;
using System.Collections.Generic;

namespace rotationalCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string originalPassword;
            string newPassword;
            int rotation;

            /*
            Example 1
            input = Zebra-493?
            rotationFactor = 3
            output = Cheud - 726 ?
            */
            originalPassword = "Zebra-493?";
            newPassword = "Cheud-726?";
            rotation = 3;

            if(newPassword == RotateCipher(originalPassword, rotation))
            {
                Console.WriteLine("You have passed test 1.");
            }
            else
            {
                Console.WriteLine("You have failed test 1.\n" + originalPassword + "\n" + RotateCipher(originalPassword, rotation));
            }

            /*
            Example 2
            input = abcdefghijklmNOPQRSTUVWXYZ0123456789
            rotationFactor = 39
            output = nopqrstuvwxyzABCDEFGHIJKLM9012345678
            */
            
            originalPassword = "abcdefghijklmNOPQRSTUVWXYZ0123456789";
            newPassword = "nopqrstuvwxyzABCDEFGHIJKLM9012345678";
            rotation = 39;

            if (newPassword == RotateCipher(originalPassword, rotation))
            {
                Console.WriteLine("You have passed test 2.");
            }
            else
            {
                Console.WriteLine("You have failed test 2.\n" + originalPassword + "\n" + RotateCipher(originalPassword, rotation));
            }
            
        }

        public static string RotateCipher(string pass, int rotation)
        {
            string spcChars = "!@#$%^&*()[]{}\\/;-?";
            List<char> specialCharacters = new List<char>();
            specialCharacters.AddRange(spcChars);
            char m;
            string newString = "";
            foreach(char i in pass)
            {
                m = i;
                for(int a = 0; a < rotation; a++)
                {
                    if (m == 'Z')
                        m = 'A';
                    else if (m == 'z')
                        m = 'a';
                    else if (m == '9')
                        m = '0';
                    else if (spcChars.Contains(m))
                    {
                        //Do Nothing
                    }
                    else
                        m = ++m;
                }
                newString += ((char)(m)).ToString();
            }
            return newString;
        }
    }
}
