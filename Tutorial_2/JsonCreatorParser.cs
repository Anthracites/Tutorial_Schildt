using System;
using System.IO;
using Newtonsoft.Json;


namespace Tutorial_2
{
	public class JsonCreatorParser
	{
		static string jsonString;
		static string jsonWay;
		static int count;

		public static void AddListener()
		{
			JsonCreatorParser MyClass = new JsonCreatorParser();
			Program.CallRefOutIn += MyClass.CreateJson;

		}

		public void CreateJson()
		{
			var myStruct = new MyStruct
			{
				i = 457,
				f = 3.1415926f,
				s = "Goob bye world :(",
				ByteArray = new byte[] { 64, 70, 35, 7, 90 },
				CurrentColor = MyStruct.Colors.Black,
				CurrentDate = DateTime.Now,
			};
			count++;

			jsonWay = ("E:" + @"\" + "Tutorial_2" + @"\"+ "JsonStore" + @"\"  + ("MyJson" + count + ".json")); //
			jsonString = JsonConvert.SerializeObject(myStruct);
			File.WriteAllText(jsonWay, jsonString);
			Console.WriteLine(jsonWay);
			Console.WriteLine("Json created... \nYou can get file in:" + jsonWay + "\n");
		}

		public void JsonParser()
        {
			var myStructParsed = JsonConvert.DeserializeObject<MyStruct>(jsonString);
        }
	}
}
