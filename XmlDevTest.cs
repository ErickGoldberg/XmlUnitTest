using DevEnsinaDevXml;
using System.Runtime.ExceptionServices;
using System.Xml;

namespace XmlUnitTest
{
    [TestFixture]
    public class XmlDevTest
    {
        XmlDev xmlDev;
        private string _xmlCompleted;
        private string _xmlInvalid;
        private string _xmlWithoutCnpjEmit;
        private string _xmlWithoutNumber;

        [SetUp]
        public void SetUp()
        {
            // Arrange
            xmlDev = new XmlDev();

            _xmlCompleted = File.ReadAllText(@"C:\Users\erick\OneDrive\Área de Trabalho\Programação\Testes .NET\XmlUnitTest\XmlUnitTest\Files\XmlCompleted.txt");
            _xmlInvalid = File.ReadAllText(@"C:\Users\erick\OneDrive\Área de Trabalho\Programação\Testes .NET\XmlUnitTest\XmlUnitTest\Files\XmlInvalid.txt");
            _xmlWithoutCnpjEmit = File.ReadAllText(@"C:\Users\erick\OneDrive\Área de Trabalho\Programação\Testes .NET\XmlUnitTest\XmlUnitTest\Files\XmlWithoutCnpjEmit.txt");
            _xmlWithoutNumber = File.ReadAllText(@"C:\Users\erick\OneDrive\Área de Trabalho\Programação\Testes .NET\XmlUnitTest\XmlUnitTest\Files\XmlWithoutNumber.txt");
        }

        #region TestExceptions

        [Test]
        [Category("TestExceptions")]
        public void ReadXml_WhenLoad_ThrowInvalidDataExceptionInXmlGeneral()
        {
            Assert.Throws<InvalidDataException>(() => xmlDev.ReadXml(_xmlInvalid));
        }

        [Test]
        [Category("TestExceptions")]
        public void ReadXml_WhenLoad_ThrowInvalidDataExceptionInCnpjEmit()
        {
            Assert.Throws<InvalidDataException>(() => xmlDev.ReadXml(_xmlWithoutCnpjEmit));
        }

        [Test]
        [Category("TestExceptions")]
        public void ReadXml_WhenLoad_ThrowFormatExceptionInNumXml()
        {
            Assert.Throws<FormatException>(() => xmlDev.ReadXml(_xmlWithoutNumber));
        }

        #endregion 

        #region TestRequiredInfo

        [Test]
        [Category("TestRequiredInfo")]
        public void ReadXml_WhenLoad_ReturnsAValidXmlNumber()
        {
            // Act
            var xml = xmlDev.ReadXml(_xmlCompleted);

            // Assert
            Assert.Greater(xml?.NumXml, 0);
        }

        [Test]
        [Category("TestRequiredInfo")]
        public void ReadXml_WhenLoad_ReturnsAValidCnpjEmit()
        {
            // Act
            var xml = xmlDev.ReadXml(_xmlCompleted);

            // Assert
            Assert.That(xml?.CnpjEmit, Has.Length.EqualTo(14));
        }

        [Test]
        [Category("TestRequiredInfo")]
        public void ReadXml_WhenLoad_ReturnsAValidCnpjDest()
        {
            // Act
            var xml = xmlDev.ReadXml(_xmlCompleted);

            // Assert
            Assert.That(xml?.CnpjDest, Has.Length.EqualTo(14));
        }


        /* PROD CODE */

        [Test]
        [Ignore("Example of production code")]
        [Category("TestRequiredInfo")]
        public void ReadXml_WhenLoad_ReturnsValidFields()
        {
            // Act
            var xml = xmlDev.ReadXml(_xmlCompleted);

            // Assert
            Assert.Greater(xml?.NumXml, 0);
            Assert.That(xml?.CnpjEmit, Has.Length.EqualTo(14));
            Assert.That(xml?.CnpjDest, Has.Length.EqualTo(14));
        }

        #endregion

    }
}