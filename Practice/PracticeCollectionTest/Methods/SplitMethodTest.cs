using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCollectionTest.Methods
{
    using PracticeCollection.Methods;
    using NUnit.Framework;
    [TestFixture]
    public class SplitMethodTests
    {
        [Test]
        public void Tests()
        {
            string test = "Hello Test 1 2";
            Assert.That(SolutionClass.SplitMethod(test), Is.EqualTo(test.Split(" ")));
        }
    }
}
