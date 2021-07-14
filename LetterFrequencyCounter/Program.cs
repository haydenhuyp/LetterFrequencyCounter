/* 
 * Finish by Huy Pham on Jul 14 2021
 */
using System;

namespace LetterFrequencyCounter
{
	class Program
	{
		public static char[] characters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H',
				'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S',
				'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '1', '2', '3', '4',
				'5', '6', '7', '8', '9', '0' };
		static void Main(string[] args)
		{
			Console.WriteLine("Instruction: ");
			Console.WriteLine("\t- This program accepts Latin (English) alphabet letters and numbers only.");
			Console.WriteLine("\t- Separate each sentence by pressing enter.");
			Console.WriteLine("\t- You should enable full screen.");
			Console.WriteLine("\t- When you're done, enter 'endz'.");
			Console.WriteLine("\nPlease type your text: ");
			string input = "";
			while (!input.EndsWith("endz"))
			{
				input += Console.ReadLine();
			}
			Console.WriteLine("\nProcessing ...");
			input.Remove(input.IndexOf("endz"));
			input = input.ToUpper();
			
			uint[] occurences = new uint[characters.Length];

			foreach (char character in input)
			{
				for (int i = 0; i < characters.Length; i++)
				{
					if (character == characters[i])
					{
						occurences[i]++;
						break;
					}
				}
			}
			DrawBarChart(occurences);
		}
		public static void DrawBarChart(uint[] occurences)
		{
			Console.Clear();
			for (int i = 0; i < occurences.Length; i++)
			{
				if (occurences[i] > 0)
				{
					Console.Write(characters[i].ToString() + " ");
					Console.BackgroundColor = ConsoleColor.Green;
					for (int j = 0; j < occurences[i]; j++)
					{
						Console.Write(" ");
					}

					Console.BackgroundColor = ConsoleColor.Black;
					Console.Write(" " + occurences[i].ToString());
					Console.WriteLine('\n');
				}
			}
			Console.BackgroundColor = ConsoleColor.Black;
		}
	}
}
