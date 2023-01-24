using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using main_project;

namespace Native_Unit_Test_Project
{
    [TestClass]
    public class UnitTest1
    {

            [TestMethod]
            public void TestMethod1()
            {
                  process p = new process();
                  string[,] arr = { {"10:00:00", "12:32:18"}, { "10:00:00", "12:31:39" }, { "10:00:00", "12:33:19" } };
                  TimeSpan timeSpan = new TimeSpan(02, 31, 39);
                  TimeSpan timeSpan1 = p.test(arr);
                   Assert.AreEqual(timeSpan, timeSpan1);
            }

            [TestMethod]
            public void TestMethod2()
            {
                process p = new process();
                string[,] arr = { { "10:00:00", "11:32:18" }, { "10:00:00", "11:31:39" }, { "10:00:00", "11:33:19" } };
                TimeSpan timeSpan = new TimeSpan(01, 31, 39);
                TimeSpan timeSpan1 = p.test(arr);
                Assert.AreEqual(timeSpan, timeSpan1);
            }

            [TestMethod]
            public void TestMethod3()
            {
                process p = new process();
                string[,] arr = { { "10:00:00", "10:32:18" }, { "10:00:00", "10:31:39" }, { "10:00:00", "10:33:19" } };
                TimeSpan timeSpan = new TimeSpan(00, 31, 39);
                TimeSpan timeSpan1 = p.test(arr);
                Assert.AreEqual(timeSpan, timeSpan1);
            }

        }
    }

