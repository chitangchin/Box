using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCollectionTest.Regex
{
    using PracticeCollection.Regex;
    using NUnit.Framework;

    [TestFixture]
    public class RegexReplaceTests
    {
        [Test]
        public void Tests()
        {
            string test = "hello!^";
            Assert.That(SolutionClass.RegexReplace(test), Is.EqualTo("hello"));
        }
    }
}
