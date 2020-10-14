using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace lab02
{
    public class Tasks
    {

        public static void SecondTask()
        {
            // Zad.4 Znajdź metodę obliczającą podatek od podanej w argumencie 
            //kwoty zgodnie z poniższym wzorem:
            //• za mniej niż 10tys. – 10 %,
            //• za sumę z przedziału od 10tys.Do 30tys. – 15 %,
            //• za kwotę większą niż 30tys. – 20 %.
            //Sprawdź wywołanie metody ToString(„C”) 
            //dla obiektu typu string.Podpowiedź: Do operacji finansowych bezpieczniej jest 
            //używać typu decimal
            // niż double.Sprawdź także jak się mnoży w tym typie, metoda Decima.Multiply.
            Console.WriteLine("Give me money");
            decimal money;
            var loadingMoney = Console.ReadLine();
            bool isLoading = decimal.TryParse(loadingMoney, out money);
            if (isLoading)
            {
                if (money < 10000)
                {
                    var tax = Tax(money, 10);
                    Console.WriteLine($"Tax: {tax}");
                }
                else if (money > 10000 && money < 30000)
                {
                    var tax = Tax(money, 15);
                    Console.WriteLine($"Tax: {tax}");
                }
                else
                {
                    var tax = Tax(money, 30);
                    Console.WriteLine($"Tax: {tax}"); 
                }
            }
            else
            {
                Console.WriteLine("Data is incorrect");
            }
        }
        private static decimal Tax(decimal money, decimal percent)
        {
            percent = percent / 100;
            var tax = money - (money - decimal.Multiply(money, percent));
            return tax;
        }
        public static void ThirdTask()
        {
            Console.WriteLine("Give me array lenght");
            int lenght = 0;
            var loadingDataFromUser = Console.ReadLine();
            bool isLoadingLenght = int.TryParse(loadingDataFromUser, out lenght);

            while (!isLoadingLenght)
            {
                Console.WriteLine("Data is incorrect!");
                Console.WriteLine("Give me array lenght");

                loadingDataFromUser = Console.ReadLine();
                isLoadingLenght = int.TryParse(loadingDataFromUser, out lenght);
            }

            BigInteger[] arrayForFibonnaciNumbers = new BigInteger[lenght];
            arrayForFibonnaciNumbers[0] = 0;
            arrayForFibonnaciNumbers[1] = 1;
            if (lenght > 2)
            {
                for (int i = 2; i < lenght; i++)
                {
                    arrayForFibonnaciNumbers[i] = arrayForFibonnaciNumbers[i - 1] + arrayForFibonnaciNumbers[i - 2];
                }
                for (int i = 0; i < arrayForFibonnaciNumbers.Length; i++)
                {
                    Console.WriteLine($"{arrayForFibonnaciNumbers[i]}");
                }
            }
            else if (lenght == 1)
            {
                Console.WriteLine($"{arrayForFibonnaciNumbers[1]}");
            }
            else
            {
                Console.WriteLine($"{arrayForFibonnaciNumbers[0]}");
            }
        }
    }
}

