using System;

namespace lab1
{
    class ProgramTwo
    {

        static void Main(string[] args)
        {
            bool AllUP(string str)
            {
                string test = "";
                for (int i = 0; i < str.Length; i++)
                {
                    if (!Char.IsUpper(str[i]))
                        return false;
                }
                return true;
            }   
            bool FirstUP(string str)
            {
                string newstr = "";
                if(str.ToLower()[0] == str[0])
                {
                    if(str.Length == 1)
                    {
                        return true;
                    }
                    for (int i = 1; i < str.Length; i++)
                    {
                        newstr += str[i];
                    }
                    bool check = AllUP(newstr);
                    if(check)
                    {
                        return true;
                    }
                }
                return false;
            }
            string slovo, newslovo = "";
            slovo = Console.ReadLine();
            bool checkone = AllUP(slovo);
            bool checktwo= FirstUP(slovo);
            if(!checkone && !checktwo)
            {
                Console.WriteLine(slovo);
            }
            else
            {
                for (int i = 0; i < slovo.Length; i++)
                {
                    char temp = slovo[i];
                    if (slovo.ToLower()[i] == temp)
                    {
                        newslovo += Char.ToUpper(temp);
                    }
                    else if(slovo.ToUpper()[i] == temp)
                    {
                        newslovo += Char.ToLower(temp);
                    }
                }
                Console.WriteLine(newslovo);
            }
            Console.ReadKey();
        }
    }
}