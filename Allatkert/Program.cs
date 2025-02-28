namespace Allatkert
{
	internal class Program
	{
		static void Main(string[] args)
		{
            //Console.WriteLine("aaaaaaaaaaaaaaa");
            //Console.Clear();
            //Console.WriteLine("aaaa");


            Console.WriteLine("O\nO");
			int haladas = 0;
			int haladas2 = 0;
			for (int i = 0; i < 5; i++)
            {
				Thread.Sleep(1000);
				Console.Clear();
                Console.SetCursorPosition(haladas += 2, 0);
                Console.WriteLine("O");
				Console.SetCursorPosition(haladas2 += 3, 1);
                Console.WriteLine("O");
            }
		}
		static void Szazalek()
		{
			string[] szavak = new string[5];
			szavak[0] = "aaaa";
			szavak[1] = "bbb";
			szavak[2] = "ccc";

			Console.WriteLine("_______");
			Console.Write("|");

			for (int i = 0; i < szavak.Length; i++)
			{
				if (szavak[i] != null) Console.BackgroundColor = ConsoleColor.Green;
				else Console.BackgroundColor = ConsoleColor.Black;
				Console.Write(" ");
			}
			Console.BackgroundColor = ConsoleColor.Black;
			Console.WriteLine("|");
			Console.WriteLine("_______");
		}
	}
}
