using System.IO;
using System.Text;
using NUnit.Framework;

namespace KattisSolution.Tests
{
    [TestFixture]
    [Category("sample")]
    public class CustomTest
    {
        [Test]
        public void SampleTest_WithStringData4_Should_Pass()
        {
            // Arrange
            const string expectedAnswer = "2\n";
            using (var input = new MemoryStream(Encoding.UTF8.GetBytes("6\n")))
            using (var output = new MemoryStream())
            {
                // Act
                Program.Solve(input, output);
                var result = Encoding.UTF8.GetString(output.ToArray());

                // Assert
                Assert.That(result, Is.EqualTo(expectedAnswer));
            }
        }

        [Test]
        public void SampleTest_WithStringData223092870_Should_Pass()
        {
            // Arrange
            const string expectedAnswer = "9\n";
            using (var input = new MemoryStream(Encoding.UTF8.GetBytes("223092870\n")))
            using (var output = new MemoryStream())
            {
                // Act
                Program.Solve(input, output);
                var result = Encoding.UTF8.GetString(output.ToArray());

                // Assert
                Assert.That(result, Is.EqualTo(expectedAnswer));
            }
        }

        [Test]
        public void SampleTest_WithStringData65536_Should_Pass()
        {
            // Arrange
            const string expectedAnswer = "16\n";
            using (var input = new MemoryStream(Encoding.UTF8.GetBytes("65536\n")))
            using (var output = new MemoryStream())
            {
                // Act
                Program.Solve(input, output);
                var result = Encoding.UTF8.GetString(output.ToArray());

                // Assert
                Assert.That(result, Is.EqualTo(expectedAnswer));
            }
        }

        [Test]
        public void SampleTest_WithStringData127381_Should_Pass()
        {
            // Arrange
            const string expectedAnswer = "3\n";
            using (var input = new MemoryStream(Encoding.UTF8.GetBytes("127381\n")))
            using (var output = new MemoryStream())
            {
                // Act
                Program.Solve(input, output);
                var result = Encoding.UTF8.GetString(output.ToArray());

                // Assert
                Assert.That(result, Is.EqualTo(expectedAnswer));
            }
        }

        [Test]
        public void SampleTest_WithStringData982451653_Should_Pass()
        {
            // Arrange
            const string expectedAnswer = "0\n";
            using (var input = new MemoryStream(Encoding.UTF8.GetBytes("982451653\n")))
            using (var output = new MemoryStream())
            {
                // Act
                Program.Solve(input, output);
                var result = Encoding.UTF8.GetString(output.ToArray());

                // Assert
                Assert.That(result, Is.EqualTo(expectedAnswer));
            }
        }


        [Test]
        public void SampleTest_WithStringData997010783_Should_Pass()
        {
            // 99971*9973
            // Arrange
            const string expectedAnswer = "2\n";
            using (var input = new MemoryStream(Encoding.UTF8.GetBytes("997010783\n")))
            using (var output = new MemoryStream())
            {
                // Act
                Program.Solve(input, output);
                var result = Encoding.UTF8.GetString(output.ToArray());

                // Assert
                Assert.That(result, Is.EqualTo(expectedAnswer));
            }
        }

        [Test]
        public void SampleTest_WithStringData113_Should_Pass()
        {
            // Arrange
            const string expectedAnswer = "0\n";
            using (var input = new MemoryStream(Encoding.UTF8.GetBytes("113\n")))
            using (var output = new MemoryStream())
            {
                // Act
                Program.Solve(input, output);
                var result = Encoding.UTF8.GetString(output.ToArray());

                // Assert
                Assert.That(result, Is.EqualTo(expectedAnswer));
            }
        }

        [Test]
        public void SampleTest_WithStringData64_Should_Pass()
        {
            // Arrange
            const string expectedAnswer = "6\n";
            using (var input = new MemoryStream(Encoding.UTF8.GetBytes("64\n")))
            using (var output = new MemoryStream())
            {
                // Act
                Program.Solve(input, output);
                var result = Encoding.UTF8.GetString(output.ToArray());

                // Assert
                Assert.That(result, Is.EqualTo(expectedAnswer));
            }
        }

        [Test]
        public void SampleTest_WithStringData99460729_Should_Pass()
        {
            // Arrange
            const string expectedAnswer = "2\n";
            using (var input = new MemoryStream(Encoding.UTF8.GetBytes("99460729\n")))
            using (var output = new MemoryStream())
            {
                // Act
                Program.Solve(input, output);
                var result = Encoding.UTF8.GetString(output.ToArray());

                // Assert
                Assert.That(result, Is.EqualTo(expectedAnswer));
            }
        }

        [Test]
        public void SampleTest_WithStringData1000000000_Should_Pass()
        {
            // Arrange
            const string expectedAnswer = "18\n";
            using (var input = new MemoryStream(Encoding.UTF8.GetBytes("1000000000\n")))
            using (var output = new MemoryStream())
            {
                // Act
                Program.Solve(input, output);
                var result = Encoding.UTF8.GetString(output.ToArray());

                // Assert
                Assert.That(result, Is.EqualTo(expectedAnswer));
            }
        }
    }
}
