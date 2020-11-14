using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Week1Challenges
{
    [TestClass]
    public class Conditionals
    {
        [TestMethod]
        public void TestMethod1()
        {   
            int sleepHours = 10;

            if (sleepHours >= 10)
            {
                Console.WriteLine("Wow that's a lot of sleep!");
            }

            else if (sleepHours > 8 && sleepHours < 10)
            {
                Console.WriteLine("You should be pretty rested.");
            }

            else if (sleepHours > 4 && sleepHours < 8)
            {
                Console.WriteLine("Bummer");
            }

            else
            {
                Console.WriteLine("Oh man, get some sleep!");
            }
        }
    }
}
