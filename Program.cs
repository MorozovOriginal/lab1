using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab1
{
    class Program
    {

        static void Main(string[] args)
        {
            bool glasnia(char bukva)
            {
                char[] glasniee = { 'A', 'E', 'I', 'O', 'U', 'Y' };
                for (int i = 0; i < glasniee.Length; i++)
                {
                    if (bukva == glasniee[i])
                    {
                        return true;
                    }
                }
                return false;
            }

            string str, newstr = "";
            str = Console.ReadLine();
            char[] soglasnie = { 'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Y', 'Z', 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < soglasnie.Length; j++)
                {
                    if ((str[i] == str.ToUpper()[i]) && !glasnia(str[i]))
                    {
                        newstr += str.ToLower()[i];
                        break;
                    }
                    else if (str[i] == soglasnie[j])
                    {
                        newstr += str[i];
                    }
                }
            }
            str = newstr;
            newstr = "";
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < soglasnie.Length; j++)
                {
                    if (str[i] == soglasnie[j])
                    {
                        newstr += $".{str[i]}";
                    }

                }
            }
            Console.WriteLine(newstr);
            Console.ReadKey();
        }
    }
}
