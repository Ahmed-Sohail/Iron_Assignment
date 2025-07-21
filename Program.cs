using System;
using System.Collections.Generic;
using System.Text;

namespace MyTestAssignment
{
    class Program
        {
            static void Main(string[] args)
            {
            string result1 = OldPhonePad("8 88777444666*664#");
            Console.WriteLine(result1);

            string result2 = OldPhonePad("4433555 555666#");
            Console.WriteLine(result2);

            string result3 = OldPhonePad("227*#");
            Console.WriteLine(result3);

            string result4 = OldPhonePad("33#");
            Console.WriteLine(result4);

            string customResult1 = OldPhonePad("444777666 660 777766633389277733#");
            Console.WriteLine(customResult1);

            string customResult2 = OldPhonePad("2446230 7777666442444555#");
            Console.WriteLine(customResult2);

            string customResult3 = OldPhonePad("27777 7777444 466 6336680 3666 6633#");
            Console.WriteLine(customResult3);
        }


            public static string OldPhonePad(string input)
        {
   
                Dictionary<string, string> numMap = new Dictionary<string, string>();
                string[] letters = { "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ"};

                var result = new StringBuilder();
                for (int i = 2; i <= 9; i++)
                {
                    numMap.Add(i.ToString(), letters[i - 2]);
                }
                for (int i = 0; i < input.Length; i++)
                {
                    char singleChar = input[i];
                    int repeat_count = 1;
                    char hash = '#';
                    char spacebar = ' ';
                    char backspace = '*';
                    if  (singleChar != spacebar && singleChar != hash && singleChar != backspace && singleChar != '0')
                    {
                        while (i + 1 < input.Length && input[i + 1] == singleChar)
                        {
                            repeat_count++;
                            i++;
                        }
                        string characters;
                        string charInput_string = singleChar.ToString();
                        numMap.TryGetValue(charInput_string, out characters);
                        result.Append(characters[repeat_count - 1]);
                    }
                    else if (singleChar == hash)
                    {
                        break;
                    }

                    else if (singleChar == backspace)
                    {
                        if (result.Length != 0)
                        {
                            result.Length -= 1;
                        }
                    }
                    else if (singleChar == '0')
                    {
                        result.Append(' ');
                    }
                }
            return result.ToString();
        }
        }
    }
