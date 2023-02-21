using System;
using System.Data;

namespace lab1
{
    class ProgramTwo
    {

        static void Main(string[] args)
        {
            string s, newslovo, slovo = "";
            s = Console.ReadLine();
            char[] bukvi = { 'h', 'e', 'l', 'o' };
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < bukvi.Length; j++)
                {
                    if (s[i] == bukvi[j])
                    {
                        slovo += s[i];
                    }
                }
            }
            newslovo = slovo;
            slovo = "";
            for (int g = 0; g < 10; g++)
            {
                for (int i = 0; i < newslovo.Length; i++)
                {
                    var temp = newslovo[i];
                    if (i != newslovo.Length - 1 && temp == newslovo[i + 1])
                    {
                        i++;
                    }
                    slovo += newslovo[i];
                }
                newslovo = slovo;
                slovo = "";
            }

            slovo = newslovo;
            Console.WriteLine(slovo);
            if (slovo == "helo")
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
            
            Console.ReadKey();
        }
    }
}