using System;
using System.Collections.Generic;
using System.Text;

namespace MyTestAssignment
{
    public class Program
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

            string customResult1 = OldPhonePad("444777666 660 777766633389277733#"); // IRON SOFTWARE
            Console.WriteLine(customResult1);

            string customResult2 = OldPhonePad("2446230 7777666442444555#"); // AHMAD SOHAIL
            Console.WriteLine(customResult2);

            string customResult3 = OldPhonePad("27777 7777444 466 6336680 3666 6633#"); // ASSIGNMENT DONE
            Console.WriteLine(customResult3);

            string customResult4 = OldPhonePad(""); // ASSIGNMENT DONE
            Console.WriteLine(customResult4);
        }


            public static string OldPhonePad(string input)
        {
                // Dictionary (and corresponding loop) to store T9 combinations from numbers: 2 - 9

                Dictionary<string, string> numMap = new Dictionary<string, string>();
                string[] letters = { "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ"};

                for (int i = 2; i <= 9; i++)
                {
                    numMap.Add(i.ToString(), letters[i - 2]);
                }


                var result = new StringBuilder();

                for (int i = 0; i < input.Length; i++) // First and main loop to parse every character in the input string
                {

                    char singleChar = input[i];
                    int repeatCount = 1;
                    char hashSymbol = '#';
                    char spacebarSymbol = ' ';
                    char backspaceSymbol = '*';

                    // First condition to get only digits (e.g. not ' ' or '#' or '0')
                    if  (singleChar != spacebarSymbol && singleChar != hashSymbol && singleChar != backspaceSymbol && singleChar != '0')
                    {
                        // Condition satisfied? Loop to essentially count repeating digits after first instance
                        while (i + 1 < input.Length && input[i + 1] == singleChar)
                        {
                            repeatCount++;
                            i++; // Increase 'i' value to see if the second instance is also same.. and so on
                        }


                        // Mapping characters to the dictionary (in original for loop) and building the result

                        string mappedValue;
                        string inputChar = singleChar.ToString();
                        numMap.TryGetValue(inputChar, out mappedValue);
                        // result.Append(mappedValue[repeatCount - 1]);

                        // Handle cases where repeatCount might exceed the number of letters for a key (circle back)
                        if (mappedValue != null)
                        {
                            result.Append(mappedValue[(repeatCount - 1) % (mappedValue.Length)]);
                        }
                }

                    else if (singleChar == hashSymbol)
                        {
                            break;
                        }

                    else if (singleChar == backspaceSymbol)
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

            // After original loop ends, return the result
            return result.ToString();
        }
        }
    }
