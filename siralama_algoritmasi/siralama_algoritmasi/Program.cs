using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siralama_algoritmasi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { -11, 10, 17, 99, 65, 123, -45, 111 };

            int i, j, temp; //shell sorthing algorithm kullanıldı
            int h = 3; //bosluk sayısı bu degere baglı olarak karsılastırılma yapılır
            while (h > 0)
            {
                for (i = 0; i < numbers.Length; i++) // yer degistirme islemi gerceklesir
                {
                    j = i;
                    temp = numbers[i];
                    while ((j >= h) && (numbers[j - h] > temp)) // yer degistirme islemi gerceklesir
                    {
                        numbers[j] = numbers[j - h];
                        j = j - h;
                    }
                    numbers[j] = temp;
                }
                if (h / 2 != 0) //bosluk değeri azaltılır
                    h = h / 2;
                else if (h == 1)
                    h = 0;
                else
                    h = 1;
            }
        

            foreach (int number in numbers)
            {
                Console.Write(number + " ");

            }
            Console.WriteLine();
            Console.WriteLine(numbers[0] + " en küçük sayıdır");
            Console.WriteLine();
            Console.WriteLine(numbers[numbers.Length - 1] + " en büyük sayıdır");
            Console.WriteLine();



            Program pg = new Program();
            pg.sumAverageElements(numbers, numbers.Length);

            Console.ReadLine();
     
            }
        public void sumAverageElements(int[] arr, int size)
        {

            int sum = 0;
            int average = 0;
            for (int i = 0; i < size; i++)
            {
                sum += arr[i];
            }
            average = sum / size;
            Console.WriteLine("dizinin ortalaması : " + average);
            Console.ReadLine();
        }
        
    }
}
