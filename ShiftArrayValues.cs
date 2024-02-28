using System;

namespace ShiftArrayValues
{
	internal class ShiftArrayValues
	{
		static void Main(string[] args)
		{
			int arraySize = 10;
			int[] arrayNumbers = new int[arraySize];

			int maxValue = 100;
			Random random = new Random();

			for (int i = 0; i < arraySize; i++)
			{
				arrayNumbers[i] = random.Next(maxValue + 1);
				Console.Write(arrayNumbers[i] + "  ");
			}

			Console.WriteLine();

			Console.Write("Введите количество сдвигов влево: ");
			int countShifts = Convert.ToInt32(Console.ReadLine());

			countShifts %= arraySize;

			for (int shift = 0; shift < countShifts; shift++)
			{
				for (int i = 0; i < arraySize - 1; i++)
				{
					int tempValue = arrayNumbers[i];
					arrayNumbers[i] = arrayNumbers[i + 1];
					arrayNumbers[i + 1] = tempValue;
				}
			}

			for (int i = 0; i < arraySize; i++)
				Console.Write(arrayNumbers[i] + "  ");

			Console.WriteLine();
		}
	}
}
