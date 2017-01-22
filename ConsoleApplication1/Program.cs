using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        /// <summary>
        /// Method to call sample tasks. Calling all the method from main.
        /// Uncomment the specific method.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //CharCountByLinq();

            //CharCountByLoops();

            //CharCountByDictionary();

            //GetPyramidTypeOne();

            //HighestContiguousSum(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });

            //HighestContiguousSumOpt();

            //MethodToGetCountOfSpecificNumber(30,2);

            //MethodToReverseNumber(02030);

            //MethodToGetStringCountFromParagraph();

            //ConvertStringToInt("1230");

            //ReverseStringTypeOne("Hello World");

            //ReverseStringUsingCharArray("Hello World");
        }

        /// <summary>
        /// Manual Reversal using ToCharArray.
        /// </summary>
        /// <param name="val">string</param>
        private static void ReverseStringUsingCharArray(string val)
        {
            char[] arr = val.ToCharArray();
            string reverse = string.Empty;

            for (int i = arr.Length-1; i > -1; i--)
            {
                reverse += arr[i];
            }
        }

        /// <summary>
        /// Manual Reversal using string[].
        /// </summary>
        /// <param name="val">string</param>
        private static void ReverseStringTypeOne(string val)
        {
            string[] reverse = val.Split(' ');
            string output = "";

            for (int i = 0; i < reverse.Length; i++)
            {
                for (int j = reverse[i].Length - 1; j >= 0; j--)
                {
                    output += reverse[i][j];
                }
                output += " ";
            }
        }

        /// <summary>
        /// Converting string input to integer value.
        /// </summary>
        /// <param name="val">string</param>
        private static void ConvertStringToInt(string val)
        {
            int output = 0;
            foreach (char c in val)
            {
                output *= 10;
                output += c - '0';
            }
        }

        /// <summary>
        /// Method to get all unique string and their count from a paragraph.
        /// Using List of string and Dictionary(string,int).
        /// </summary>
        private static void MethodToGetStringCountFromParagraph()
        {
            var para = "I am from India. I am from MP. I don't know you.";
            List<string> strList = para.Split(' ').ToList();

            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var item in strList)
            {
                if (!dict.ContainsKey(item))
                    dict.Add(item.TrimEnd('.'), 1);
                else
                    dict[item]++;
            }
        }

        /// <summary>
        /// Method to reverse number.
        /// </summary>
        /// <param name="p"></param>
        private static void MethodToReverseNumber(int p)
        {
            int reverse = 0;

            while (p > 0)
            {
                int rem = p % 10;
                reverse = (reverse * 10) + rem;
                p = p / 10;
            }
        }

        /// <summary>
        /// Method to get count of specific number from a given range.
        /// </summary>
        /// <param name="input">Given range like 20(up to 20)</param>
        /// <param name="repeatedNum">Number count from the given range</param>
        private static void MethodToGetCountOfSpecificNumber(int input, int repeatedNum)
        {
            int count = 0;
            for (int i = 2; i <= input; i++)
            {
                int rest = i;
                while (rest > 0)
                {
                    int rem = rest % 10;
                    rest = rest / 10;
                    if(rem == 2)
                        count++;
                }
            }
        
        }

        /// <summary>
        /// To get heighest contiguous sum of array elements.
        /// Using inbuild methods.
        /// </summary>
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

        /// <summary>
        /// To get heighest contiguous sum of array elements.
        /// Using manual way.
        /// </summary>
        /// <param name="arr">int type array</param>
        /// <returns></returns>
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

        /// <summary>
        /// Get pyramid of type number.
        ///     1
        ///    2 3
        ///   4 5 6
        /// </summary>
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

        /// <summary>
        /// Get unique character and their counts using Dictionary.
        /// </summary>
        private static void CharCountByDictionary()
        {
            string input = "WWW.C-SHARPCORNER.COM";

            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (var item in input)
            {
                if (!dict.ContainsKey(item))
                    dict.Add(item, 1);
                else
                    dict[item]++;
            }
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Get unique character and their counts.
        /// Using loops and replacing original value.
        /// </summary>
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

        /// <summary>
        /// Get unique character and their counts using LINQ.
        /// </summary>
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
