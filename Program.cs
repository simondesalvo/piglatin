using System;

namespace piglatin
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x = true;
            while (x)
            {
                Console.WriteLine("Type in a word");
                string input = Console.ReadLine();
                string toPig = input.ToLower();
                string str = pigLatin(toPig);


                if (str == "-1")
                    Console.WriteLine("Pig Latin needs a vowel, yo. Put in a word that contains the letters: a, e, i , o, or u (we're ignoring y frn)");
                else
                    Console.WriteLine(str);


                Console.WriteLine("Want to play again? y/n"); 
                string answer = Console.ReadLine();
                while (answer == "y" || answer == "yes")
                {
                    break; //returns to beginning
                }
                while (answer == "n" || answer == "no")
                {
                    Console.WriteLine("Ok, see you later!");
                    x = false;
                    break; //ending
                }
            }
        }

        public static bool isVowel(char c)
        {
            return (c =='a' || c =='e' || c=='i' || c=='o'|| c=='u');
        }

        public static string pigLatin(string s)
        {
            int len = s.Length;
            int index = -1; //default error state

            if (isVowel(s[0])) //check if first letter is vowel, then returns string + way
            {
                return (s + "way");
            }
            else
            {

                for (int i = 0; i < len; i++) //finding location of first vowel and storing it
                {
                    if (isVowel(s[i]))
                    {
                        index = i;
                        break;
                    }
                }
            }

            if (index == -1) //if there's no vowel, returns default error state
                return "-1";


            return s.Substring(index) + s.Substring(0, index) + "ay"; //prints string from location of first vowel, then prints beginning of word from first letter to first vowel
        }




    }
    }

