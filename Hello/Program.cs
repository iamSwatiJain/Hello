using System;
using OtherStuff;

namespace Hello
{
    class Program
    {
        

        static void Main(string[] args)
        {
            if(DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
            Console.WriteLine("Hey " + args[0] + ", Cheer up! It is mid week already!");
            // Console.WriteLine(DateTime.Now.GetDateTimeFormats());
            // Console.ReadLine();

            // since specified strings are treated on the fly as string objects...
            //string limit6 = "The quick brown fox jumped over the lazy dog.".Substring(0,6);
            //string limit10 = "The quick brown fox jumped over the lazy dog.".LimitLength(10);
            //// this line should return us the entire contents of the test string
            //string limit100 = "The quick brown fox jumped over the lazy dog.".LimitLength(100);

            //Console.WriteLine("limit5   - {0}", limit6);
            //Console.WriteLine("limit10  - {0}", limit10);
            //Console.WriteLine("limit100 - {0}", limit100);
            //Console.WriteLine("Enter the number of hours you slept");
            //try {
            //    int x = int.Parse(Console.ReadLine());
            //    Console.WriteLine("you entered: " + x);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine($"{e}\nPlease enter integer value only.");

            //}
            Console.WriteLine("Enter input 1");
            string input1 = Console.ReadLine();
            int val1;
            try {
                 val1 = int.Parse(input1);
            }
            catch
            {
                Console.WriteLine("Fel format");
               return;
            }

            int val2;
            bool parsed;
            string input2;

            // the do while will keep on taking input till the value entered is integer otherwise it will keep on showing fel message.
            do
            {
                Console.WriteLine("Ange värde 2");
                input2 = Console.ReadLine();
                parsed = int.TryParse(input2, out val2);
                if (!parsed)
                {
                    Console.WriteLine("Fel");
                }
            } while (!parsed);


            //Console.WriteLine("Enter input 2");
            //string input2 = Console.ReadLine();
            //int val2 = int.Parse(input2);

            var max = Util.Max(val1, val2);
            Console.WriteLine($"Du ange {val1} och {val2}");
            Console.WriteLine("max value is " + max);
            
            //Console.ReadLine();
        }

       
    }
}