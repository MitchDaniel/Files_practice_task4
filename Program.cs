

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10000];
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(10000);
            }
            string parthForEven = @"C:\Users\Brill\Desktop\For even.txt";
            string parthForOdd = @"C:\Users\Brill\Desktop\For odd.txt";
            if (!File.Exists(parthForEven))
            {
                throw new FileNotFoundException("parthForEven not found");
            }
            if (!File.Exists(parthForOdd))
            {
                throw new FileNotFoundException("parthForOdd not found");
            }
            int countEven = 0;
            int countOdd = 0;
            List<string> stringsOdd = new List<string>();
            List<string> stringsEven = new List<string>();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(10000);
                if (numbers[i] % 2 == 0)
                {
                    stringsEven.Add(numbers[i].ToString());
                    countEven++;
                }
                else
                {
                    stringsOdd.Add(numbers[i].ToString());
                    countOdd++;
                }
            }
            File.WriteAllLines(parthForOdd, stringsOdd);
            File.WriteAllLines(parthForEven, stringsEven);
            Console.WriteLine("Statistic: ");
            Console.WriteLine($"Even: {(double)countEven / numbers.Length * 100} %");
            Console.WriteLine($"Odd: {(double)countOdd/ numbers.Length * 100} %");
        }
    }
}

//Задание 4:
//Приложение генерирует случайным образом 10000 целых чисел. 
//Необходимо сохранить чётные числа в один файл, нечётные в другой. 
//По итогам работы приложения нужно отобразить статистику на экран.