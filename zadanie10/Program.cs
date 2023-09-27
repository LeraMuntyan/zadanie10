using System;
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main()
        {
            Random rand = new Random();
            int n = 20;
            int[] arr = new int[n];
            arr[0] = rand.Next(0, 20);
            int i = 1, k;

            while (i < arr.Length)
            {
                do
                {
                    k = 0;
                    arr[i] = rand.Next(0, 20);
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (arr[i] == arr[j])
                            k++;
                    }
                }
                while (k != 0);
                i++;
            }
            for (int t = 0; t < arr.Length; t++)
                Console.Write("{0,3} ", arr[t]);

            Console.WriteLine();
            {
                Console.WriteLine("Esli hotite povtorit vvod, vvedite 1, inache lubuyu dr cifru");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 1) Main();
                return;
            }
            Console.ReadLine();
        }
    }
}
