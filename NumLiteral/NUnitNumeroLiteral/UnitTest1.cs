using NUnit.Framework;

namespace NUnitNumeroLiteral
{
    public class Tests
    {
        private string n;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestNumeroaLiteral()
        {
            // Arrange = preparacion
            string n = "1234567";
            string esperado = "Un millon Doscientos Treinta y Cuatro mil Quinientos Sesenta y Siete ";
            LiteralController lit = new LiteralController();

            // Act = ejecucion
            string respuesta = lit.NumeroGet(n);

            // Assert = verificacion
            Assert.AreEqual(esperado, respuesta);
        }
    }
}