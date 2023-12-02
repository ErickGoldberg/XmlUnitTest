using DevEnsinaDevXml;

namespace XmlUnitTest
{
    [TestFixture]
    public class XmlDevTest
    {
        private string Xml;

        [SetUp]
        public void SetUp()
        {
            //Leitura do Arquivo
            var XmlCompleted = File.ReadAllText(@"C:\Users\erick\OneDrive\Área de Trabalho\Programação\Testes .NET\XmlUnitTest\XmlUnitTest\Files\XmlCompleted.txt");
            var XmlInvalid = File.ReadAllText(@"C:\Users\erick\OneDrive\Área de Trabalho\Programação\Testes .NET\XmlUnitTest\XmlUnitTest\Files\XmlInvalid.txt");
            var XmlWithoutCnpjEmit = File.ReadAllText(@"C:\Users\erick\OneDrive\Área de Trabalho\Programação\Testes .NET\XmlUnitTest\XmlUnitTest\Files\XmlWithoutCnpjEmit.txt");
            var XmlWithoutNumber = File.ReadAllText(@"C:\Users\erick\OneDrive\Área de Trabalho\Programação\Testes .NET\XmlUnitTest\XmlUnitTest\Files\XmlWithoutNumber.txt");
        }

        [Test]
        public void IsXmlValidTest()
        {
            Assert.Pass();
        }

        [Test]
        public void XmlHasAllRequiredInfoTest()
        {
            Assert.Pass();
        }

        [Test]
        public void TestXmlExceptions()
        {
            Assert.Pass();
        }
    }
}