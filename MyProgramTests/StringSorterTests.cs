using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyProgram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram.Tests
{
    [TestClass()]
    public class StringSorterTests
    {
        [TestMethod()]
        public void SortCommaSeparatedStringsTest()
        {

            StringSorter stringSorterObj = new StringSorter();

            /// only strings made of alphabets and integers
            List<string> expectedOrderedList = new List<String>() {"0","25","50","100","a", "A", "c", "C", "e", "E", "z","Z" };
            List<string> actualList = stringSorterObj.SortCommaSeparatedStrings(new string[] { "C", "A", "a", "e", "50", "Z", "z", "c", "0", "E", "25", "100" });

            for(int i = 0; i < expectedOrderedList.Count; i++)
            {
                Assert.AreEqual(expectedOrderedList[i], actualList[i]);
            }


            StringSorter stringSorterObj1 = new StringSorter();
            /// Strings mixed with both chars and numbers
            List<string> expectedOrderedList1 = new List<String>() {"0Zab", "a100DE", "A50DE", "G001A99", "G001A101", "G10A99"};
            List<string> actualList1 = stringSorterObj1.SortCommaSeparatedStrings(new string[] {"G001A99", "G10A99", "0Zab", "a100DE", "A50DE", "G001A101"});
            for (int i = 0; i < expectedOrderedList1.Count; i++)
            {
                Assert.AreEqual(expectedOrderedList1[i], actualList1[i]);
            }


        }
    }
}