﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using KattisSolution.Helpers;
using NUnit.Framework;

namespace KattisSolution.Tests
{
    [TestFixture]
    public class FileInputTest
    {
        private IEnumerable<TestCase> _testCases;

        [TestFixtureSetUp]
        public void SetUp()
        {
            _testCases = TestCaseFinder.GetTestCases();
        }

        [Test]
        public void AllCases_Should_Pass()
        {
            foreach (var testCase in _testCases)
            {
                Console.WriteLine("Running for {0}", testCase.In);
                // Arrange
                var expectedResult = File.ReadAllText(testCase.Out);

                using (var dataStream = File.OpenRead(testCase.In))
                using (var outStream = new MemoryStream())
                {
                    // Act
                    Program.Solve(dataStream, outStream);
                    var result = Encoding.UTF8.GetString(outStream.ToArray());

                    // Assert
                    Assert.That(result, Is.EqualTo(expectedResult));
                }
            }

        }
    }
}
