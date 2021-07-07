using System;

namespace Tutorial_2
{
    delegate string StrMod(string str);
    public class DelegateSample
    {
        public static void AddListener() // Подписка на события 
        {
            DelegateSample MyClass = new DelegateSample();
            Program.CallRefOutIn += MyClass.CallMethods;
        }

        string ReplaceSpaces(string s) 
        {
            Console.WriteLine("Замена пробелов дефисами.");
            return s.Replace(' ', '-');
        }

         string RemoveSpaces(string s)
        {
            string temp = "";
            int i;
            Console.WriteLine("Удаление пробелов");
            for (i = 0; i < s.Length; i++)
                if (s[i] != ' ') temp += s[i];
            return temp;
        }
        public void CallMethods() // Вызов разных метдов через delegate
        {
            StrMod strOp = new StrMod(ReplaceSpaces);
            string str;

            str = strOp("Good bye world!");
            Console.WriteLine("Result string: " + str);
            Console.WriteLine();

            StrMod Reverse = str => {
                string temp = "";
                int i, j;

                Console.WriteLine("Обращение строки.");
                for (j = 0, i = str.Length - 1; i >= 0; i--, j++)
                    temp += str[i];
                Console.WriteLine("Result string: " + temp);
                return temp;

            };
            Reverse(str);

            str = strOp("Good bye world!");
            Console.WriteLine("Result: " + str);

            strOp = new StrMod(RemoveSpaces);
            str = strOp("Good bye world!");
            Console.WriteLine("Result string: " + str);
        }
    }
}
