using System;
using System.ComponentModel;
using System.Reflection.Metadata;

namespace Methods
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Task - 1
			//IsPrime metodu -parametr olaraq integer value qəbul edir.Göndərilmiş integer dəyərin sadə olub olmadığını qaytarır.
			//Ədəd sadədirsə true, deyilsə false qayıtmalıdır.
			Console.WriteLine("Ededi daxil edin:");
			int n = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(IsPrime(n));
            //Task - 2
            //CalcAvg metodu -Göndərilmiş imtahanlar qiyməti siyahısına(integer array) əsasən həmin qiymətlərin ortalamasını qaytaran metod yazın.
            //Main metodunda bu metodu call edib, burdan qayıdan dəyərə əsasən ortalama 60 - dan böyükdürsə console-da "Mezun oldunuz"
            //əks halda "Mezun ola bilmediniz" yazısı yazdırın
            Console.WriteLine("-------------------------------------------------------");
            int[] grades = { 70, 76, 50,56, 97, 45 };
			double average=CalcAvg(grades);
			if (average > 60 )
			{
                Console.WriteLine("Mezun oldunuz");
            }
			else
			{
                Console.WriteLine("Mezun ola bilmediniz");
            }

		}

		static bool IsPrime(int num)
		{
			if (num <= 1)
			{
				return false;
			}
			for (int i = 2; i * i <= num; i++)
			{
				if (num % i == 0)
				{
					return false;
				}
			}
			return true;
		}
		static double CalcAvg(int[] grades)
		{
			int sum = 0;
			foreach (int grade in grades)
			{
				sum += grade;
			}
			return sum/grades.Length;

		}
	}
}