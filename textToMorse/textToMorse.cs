using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textToMorse
{
    class textToMorse
    {
        public char[] text;
        public string[] Morse = new string[] {".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-",
                                        ".-..", "--", "-.", "---", ".--.", "--.-", "-.-", "...", "-", "..-",
                                        "...-", ".--", "-..-", "-.--", "--..", "/"};
        //public string[] MorseCode;
        public string[] Character = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m",
                                                    "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", " " };
        public int[] numbers;
        public void textToMorseCode(int textLength, string Text)
        {
            text = new char[textLength];
            //MorseCode = new string[textLength];
            numbers = new int[textLength];
            for (int i = 0; i < textLength; i++)
            {
                text[i] = char.ToLower(Text[i]);
            }

            for (int j = 0; j < textLength; j++)
            {
                int index = Array.FindIndex(Character, x => x == text[j].ToString());
                numbers[j] = index;
                /*if (text[j].Equals('a'))
                {
                    MorseCode[j] = Morse[0];
                }
                else if (text[j].Equals('b'))
                {
                    MorseCode[j] = Morse[1];
                }
                else if (text[j].Equals('c'))
                {
                    MorseCode[j] = Morse[2];
                }
                else if (text[j].Equals('d'))
                {
                    MorseCode[j] = Morse[3];
                }
                else if (text[j].Equals('e'))
                {
                    MorseCode[j] = Morse[4];
                }
                else if (text[j].Equals('f'))
                {
                    MorseCode[j] = Morse[5];
                }
                else if (text[j].Equals('g'))
                {
                    MorseCode[j] = Morse[6];
                }*/
            }
        }

        public string returnMorse(int charLength)
        {
            string MCode = "";
            for(int l=0; l<charLength; l++)
            {
                MCode += " " + Morse[numbers[l]];
            }
            return MCode;
        }

        }
    }
