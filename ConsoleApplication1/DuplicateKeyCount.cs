using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class DuplicateKeyCount
    {
        static void Main(string[] args)
        {
            //CharCountByLinq();

            //CharCountByLoops();

            //CharCountByDictionary();

            //GetPyramidTypeOne();

            HighestContiguousSum(new int[] {-2, 1, -3, 4, -1, 2, 1, -5, 4});

            //HighestContiguousSumOpt();
        }

        private static void HighestContiguousSumOpt()
        {
            int[] inputArray = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };          
            if (inputArray.Length == 0)
                throw new ArgumentException("the input parameter cannot be an empty array");

            int maxSum = 0;
            int currentSum = 0;

            maxSum = currentSum = inputArray[0];
            for (int i = 1; i < inputArray.Length; i++)
            {
                currentSum = Math.Max(currentSum + inputArray[i], inputArray[i]);
                maxSum = Math.Max(currentSum, maxSum);
            }
        }

        private static int HighestContiguousSum(int[] arr)
        {
            int currentSum = 0;
            int maxSum = 0;

            currentSum = maxSum = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (currentSum + arr[i] > arr[i])
                {
                    currentSum = currentSum + arr[i];
                }
                else
                {
                    currentSum = arr[i];
                }

                if (currentSum > maxSum)
                    maxSum = currentSum;
            }
            return maxSum;
        }

        private static void GetPyramidTypeOne()
        {
            int i, j, k, l = 1;

            for (i = 1; i <= 5; i++)
            {
                for (j = i; j <= 5; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("{0} ", l++);
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }

        private static void CharCountByDictionary()
        {
            string input = "WWW.C-SHARPCORNER.COM";

            //Dictionary<char, int> dict = new Dictionary<char, int>();
            //if (dict.Contains)
            //{
                
            //}
        }

        private static void CharCountByLoops()
        {
            string input = "WWW.C-SHARPCORNER.COM";

            while (input.Length > 0)
            {
                Console.Write(input[0] + " : ");
                int count = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[0] == input[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                input = input.Replace(input[0].ToString(), string.Empty);
            }
            Console.ReadLine();
        }

        private static void CharCountByLinq()
        {
            string countDuplicates = "aabbbccccddeeeegggggggggggfffhijkl";
            var result = countDuplicates.GroupBy(x => x).Where(x => x.Count() > 1).Select(z => new { CharName = z.Key, CharCount = z.Count() });
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
