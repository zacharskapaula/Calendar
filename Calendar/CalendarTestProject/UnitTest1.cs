using NUnit.Framework;
using Calendar;
using System;

namespace CalendarTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            CalendarForm ob = new CalendarForm();
            bool day = true;
            day = ob.Visible;
        }

        
    }
}