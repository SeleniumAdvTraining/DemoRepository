using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoProject
{
    [TestClass]
    public class DemoTestcase
    {
        [TestMethod]
        public void Greeting_Testcase()
        {
            Console.WriteLine("Hello Member 2!");
            Console.WriteLine("How are you?");
            Console.WriteLine("I am Member 1");
        }
    }
}
