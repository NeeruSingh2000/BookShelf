using System;
using System.Linq;
using System.Text;

namespace SinchConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number to check if it is power of 2 or not !");
            ulong number = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine(IsPowerOfTwo(number));
            Console.WriteLine("------------------------------------------------");


            Console.WriteLine("Enter a string to be reversed");
            string strString = Console.ReadLine();
            Console.WriteLine(ReverseString(strString));
            Console.WriteLine("------------------------------------------------");


            Console.WriteLine("Enter the string  to be repeated ");
            strString = Console.ReadLine();
            Console.WriteLine("Enter the number of times you want string to repeat");
            int numberOfTimes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(RepeatString(strString, numberOfTimes));                       
            Console.WriteLine("------------------------------------------------");



            Console.WriteLine("Press enter to print all odd numbers between 0 and 100");
            Console.ReadLine();
            PrintOddNumbers();
            Console.ReadLine();


        }

        /// <summary>
        /// Determines wether a number is power of 2 or not
        /// </summary>
        /// <example>
        ///    0000 0111(num: 7)
        ///  & 0000 1000(num: 8)
        ///---------------------------
        ///    0000 0000
        ///--------------If You see here, the numbers which are power of 2 will have only 
        /// single "1" in binary format. This "1" goes on shifting to left as power increases. 
        /// A number just prior to such "2-powered" number will have a "0"(zero) above that "1". 
        /// In this case only, the bitwise AND operation between 2-powered number and just prior 
        /// number results in "0"(zero).   
        /// so (true && true) will result true
        /// </example>
        /// <returns></returns>
       public  static  bool IsPowerOfTwo(ulong number)
        {
            return (number != 0) && ((number & (number - 1)) == 0);
        }


        /// <summary>
        /// Returns a revese string 
        /// </summary>
        /// <param name="strString"></param>
        /// <returns></returns>
        public static string ReverseString(string strString)
        {

            char[] charArray = strString.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }


        /// <summary>
        /// Repeats a string for a given number of times  
        /// </summary>
        /// <param name="strString"></param>
        /// <param name="numberOfTimes"></param>
        /// <returns></returns>
        public static string RepeatString(string strString, int numberOfTimes)
        {
            string result = new StringBuilder().Insert(0, strString, numberOfTimes).ToString();
            return result;
        }


        /// <summary>
        /// Prints all odd numbers between 0 and 100
        /// </summary>
        public static void  PrintOddNumbers()
        {
            for (int i = 1; i < 100; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
