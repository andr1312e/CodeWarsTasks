namespace Solution
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using Word_values;

    [TestFixture]
    public class SolutionTest
    {
        private static IEnumerable<TestCaseData> sampleTestCases
        {
            get
            {
                yield return new TestCaseData(new[] { new string[] { "codewars", "abc", "xyz" } }).Returns(new int[] { 88, 12, 225 });
                yield return new TestCaseData(new[] { new string[] { "abc abc", "abc abc", "abc", "abc" } }).Returns(new int[] { 12, 24, 18, 24 });
            }
        }

        [Test, TestCaseSource("sampleTestCases")]
        public int[] SampleTest(string[] a) => WordValue(a);
    }
}
