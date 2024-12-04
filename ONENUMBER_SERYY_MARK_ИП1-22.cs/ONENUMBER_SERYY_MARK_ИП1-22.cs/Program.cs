using System;

namespace edinoe_chislo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите количество чисел:");
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];  

           
            Console.WriteLine("Введите числа по одному:");
            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());  
            }

            
            bool foundUnique = false;

            
            Console.WriteLine("Уникальные числа, которые появляются только один раз:");

            // Ищем уникальные числа
            for (int i = 0; i < nums.Length; i++)
            {
                bool isUnique = true;

                // Считаем, сколько раз встречается текущее число
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j && nums[i] == nums[j])
                    {
                        // Если найдено совпадение, число не уникальное
                        isUnique = false;
                        break;
                    }
                }

                // Если число уникальное, выводим его
                if (isUnique)
                {
                    Console.WriteLine(nums[i]);
                    foundUnique = true;
                }
            }

            // Если уникальные числа не были найдены
            if (!foundUnique)
            {
                Console.WriteLine("Числа, которые появляются только один раз, не найдены.");
            }
        }
    }
}
