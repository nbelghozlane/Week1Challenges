using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Week1Challenges
{
    [TestClass]
    public class Types
    {
        [TestMethod]
        public void TestMethod1()
        {
            string name = "Nadia Belghozlane";
            Console.WriteLine(name);

            int age = 28;
            Console.WriteLine(age);


            string[] favoriteBooks = { "Harry Potter and the Sorcerer's Stone", "Harry Potter and the Chamber of Secrets", "Harry Potter and the Prisoner of Azkaban", "Harry Potter and the Goblet of Fire" };
            Console.WriteLine(favoriteBooks);


            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            DateTime randomDate = new DateTime(2020, 8, 31);
            Console.WriteLine(randomDate);

            List<string> dates = new List<string>();
            dates.Add(now.ToString("dd/MM/yyyy HH:mm:ss"));
            dates.Add(randomDate.ToString());


            int Age = 28;
            int num7 = 7;

            int sum = Age + num7;
            Console.WriteLine(sum);

            int diff = Age - num7;
            Console.WriteLine(diff);

            int prod = Age * num7;
            Console.WriteLine(prod);

            int quot = Age / num7;
            Console.WriteLine(quot);

            int remainder = Age % num7;
            Console.WriteLine(remainder);


        }

    
    }
}
