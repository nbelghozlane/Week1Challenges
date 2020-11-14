using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Week1Challenges
{
    [TestClass]
    public class SwitchCase
    {


        [TestMethod]
        public void TestMethod1()
        {

            Console.WriteLine("How has your day been?");
            string dayRating = "Great";
            switch (dayRating)
            {
                case "Great":
                    Console.WriteLine("Excellent! I'm glad you're having a great day!");
                    break;
                case "Good":
                    Console.WriteLine("Good to hear!");
                    break;
                case "Okay":
                    Console.WriteLine("I hope your day gets better.");
                    break;
                case "Bad":
                    Console.WriteLine("I'm sorry you're having a bad day.");
                    break;
                case ":(":
                    Console.WriteLine("I'm sorry you're having a terrible day. Let me buy you some ice cream!");
                    break;
                
            }
        }
    }
}
