using System;


namespace Tutorial_2
{
    public class SampleRefOutIn
    {
        public int x = 3;
        public int y = 6;
        public int c, d;

        public static void AddListener()
        {
            SampleRefOutIn MyClass = new SampleRefOutIn();
            Program.CallRefOutIn += MyClass.ShowRefOutIn;

        }
        public void ShowRefOutIn()
        {
            SimpleSummary(3, 6);
            Console.WriteLine("public x = " + x);
            Console.WriteLine("");
            x = 3;
            SummaryWhithRef(ref x, 6);
            Console.WriteLine("public x = " + x);
            Console.WriteLine("");
            x = 3;
            SummaryWhithOut(3, 6, out c, out d);
            Console.WriteLine("public x = " + x);
            Console.WriteLine("");
            x = 3;
            SummaryWhithIn(in x, 6, out c, out d);
            Console.WriteLine("public x = " + x);
            Console.WriteLine("\n");
        }

         void SimpleSummary(int x, int y) // значение параметра х можно изменить внутри метода, публичная переменна х не меняет значение
        {
            x++;
            var c = x + y;
            Console.WriteLine("SimpleSummary = " + c);
            Console.WriteLine("x in SimpleSummary = " + x);
        }

        void SummaryWhithRef(ref int x, int y) // Ref значение параметра х можно изменить внутри метода, публичная переменна х изменит значение
        {
            x++;
            var c = x + y;
            Console.WriteLine("Summary whith ref = " + c);
            Console.WriteLine("x in SummaryWhithRef = " + x);
        }

        void SummaryWhithOut(int x, int y, out int c, out int d)//получаем значение в виде выходного параметра
        {
            x++;
            c = x + y;
            d = x * y;
            Console.WriteLine("Summary whith Out = " + c);
            Console.WriteLine("Multiplication whith Out = " + d);
            Console.WriteLine("x in Summary whith Out  = " + x);
        }

        void SummaryWhithIn(in int x, int y, out int c, out int d) // Нельзя менять значение переменной х внутри метода
        {
            // x++;
            c = x + y;
            d = x * y;
            Console.WriteLine("Summary whith In = " + c);
            Console.WriteLine("Multiplication whith In = " + d);
            Console.WriteLine("x in SummaryWhithIn = " + x);
        }
    }
}
