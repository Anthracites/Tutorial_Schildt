using System;

namespace Tutorial_2
{
	public class SampleBoxingUnboxing
	{
		int x, y;

		public static void AddListener()
		{
			SampleBoxingUnboxing MyClass = new SampleBoxingUnboxing();
			Program.CallRefOutIn += MyClass.BoxingUnboxing;
		}

		public void BoxingUnboxing() // Пример с ядерным Ганди из Цивилизации
        {
			int x = 280;
			byte y = 0;
			object o;
			o = (object)y;

			y = (byte)x;
			o = y; // Можно неявно приобразовывать любые типы в тип object
			o = (byte) y;
			x = (int)(byte) o; //Распаковка всегда с явным преобразованием типов

			Console.WriteLine("Boxing/Unboxing.......\n x = {0}, y = {1}, o = {2}, x = y", x, y, o);
				Console.WriteLine("\n");

		}
	}
}
