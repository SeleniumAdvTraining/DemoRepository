using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoProject
{
    [TestClass]
    public class DemoTestcase
    {
        [TestMethod]
        public void Member1Member2_TestMethod()
        {
            Console.WriteLine("Hello Member 2!");

            Console.WriteLine("Hello Member 1!");
            Console.WriteLine("How are you?");
        }
    }
}
