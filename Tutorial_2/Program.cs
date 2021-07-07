using System;
using System.Windows;

namespace Tutorial_2
{
    delegate void MyEvent();
    class Program //Главное меню программы
    {
        public string MyTexst; 
        public static System.Action CallRefOutIn;
        public static System.Action CallBoxingunboxing;
        public static System.Action CallJsonCreator;
        public static System.Action CallDelegate;

        public void AddAbserver() //Вызов подписки класса на собитие
        {
            SampleRefOutIn.AddListener();
            SampleBoxingUnboxing.AddListener();
            JsonCreatorParser.AddListener();
            DelegateSample.AddListener();
        }

        static void Main(string[] args) 
        {
            Program MethodAgregator = new Program();
            MethodAgregator.AddAbserver();
            MethodAgregator.ShowProgramSamples();
        }

        void ShowProgramSamples() // Отображение меню и вызов методов
        {
            Console.WriteLine("Choose method:\n---------------------------------------------------------------\nSampleRefOutIn - 1\nSampleBoxingUnboxing - 2\nCreateJson - 3\nDelegateShow - 4\nExit - 5");
            MyTexst = Console.ReadLine();

            switch (MyTexst)
            {
                case ("1"):
                    CallRefOutIn?.Invoke();
                    ShowProgramSamples();
                    break;
                case ("2"):
                    CallBoxingunboxing?.Invoke();
                    ShowProgramSamples();
                    break;
                case ("3"):
                    CallJsonCreator?.Invoke();
                    ShowProgramSamples();
                    break;
                case ("4"):
                    CallDelegate?.Invoke();
                    ShowProgramSamples();
                    break;
                case ("5"):
                    Environment.Exit(0);
                    break;
                default:
                    ShowProgramSamples();
                    break;
            }
        }

    }
}
