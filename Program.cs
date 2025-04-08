using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldPhoneKeyPad_CodingChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This Main just ask for the message of the user so it can be converted in OldPhonePad

            Console.Write("Write your message as an old phone keypad.\n" +
                            "To delete a letter in your message use '*'.\n" +
                            "To send your message use '#' at the end of the message.\n\n" +
                            "Message: ");


            string user_message = Console.ReadLine();
            Console.WriteLine("Output: " + OldPhonePad(user_message));
        }

        public static String OldPhonePad(string input)
        {
            // Contains all the letters for every number.
            Dictionary<char, List<string>> letters = new Dictionary<char, List<string>>()
            {
                {'2', new List<string> {"A", "B", "C"}},
                {'3', new List<string> {"D", "E", "F"}},
                {'4', new List<string> {"G", "H", "I"}},
                {'5', new List<string> {"J", "K", "L"}},
                {'6', new List<string> {"M", "N", "O"}},
                {'7', new List<string> {"P", "Q", "R", "S"}},
                {'8', new List<string> {"T", "U", "V"}},
                {'9', new List<string> {"W", "X", "Y", "Z"}}
            };

            string message = "";
            int order = 0;

            // Checks every character in the input.
            for (int i = 0; i < input.Length; i++)
            {
                // If the character is a blank space it continues.
                if (input[i] == ' ')
                {
                    order = 0;
                    continue;
                }

                // the while inside this if, won't have effect with these three characters.
                if (input[i] != '1' && input[i] != '0' && input[i] != '*')
                {
                    // Checks if there are more characters and if the current one is the same to the next one.
                    // If both of the conditions are true the order increase and it advanced to the next one.
                    while (i + 1 < input.Length && input[i] == input[i + 1])
                    {
                        order++;
                        i++;
                    }
                }

                try
                {
                    // In this switch the letter is added to the message.
                    // input[i] = our current number(character).
                    // order = the times that current number(character) is repeated after a different or a space.
                    switch (input[i])
                    {
                        case '1':
                            message += ",";
                            break;
                        case '0':
                            message += " ";
                            break;
                        case '*':
                            if (message.Length > 0)
                            {
                                message = message.Remove(message.Length - 1);
                            }
                            break;
                        case '#':
                            message += "#";
                            break;
                        default:
                            // If it detects a letter it won't work and return just an error.
                            if (Char.IsDigit(input[i]))
                            {
                                message += letters[input[i]][order];
                                break;
                            }
                            else
                            {
                                return "Error, sorry, Only Numbers";
                            }
                    }
                }
                // In this case, make sure you don't pass the index in the dictionary.
                // For example depending on the number there may be to cases like '2222' = Error or '7777' = Error.
                // In those cases you should use a space like '222 2' = 'CA' or '77 77' = 'QQ'.
                catch
                {
                    return "Error, Index out of Range";
                }
                //When a letter is add to the message the order of the list in the dict is 0 again.
                order = 0;
            }

            // There must be a '#' at the message to send it.
            // Otherwise the message won't be displayed in the console.

            if (message[message.Length - 1] == '#')
            {
                //The last character in this case '#' is deleted at the end so It doesn't appear.
                message = message.Remove(message.Length - 1);
                return message;
            }
            else
            {
                return "The message was not send, you had to use # at the end of the message.";
            }
        }
    }
}
