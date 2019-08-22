using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemSolving.Tests
{
    [TestClass]
    public class StringManipulationsTests
    {
        [TestMethod]
        public void ShouldReturnTrueWhenExpressionContainsBalancedParanthesis()
        {
            // Arrange
            var expression = "[{name: Datta; city: Pune (Zip code: 411014) }]";

            // Act
            var containsBalancedParanthesis = StringManipulations.ContainsBalancedParanthesis(expression);

            // Assert
            Assert.AreEqual(true, containsBalancedParanthesis);
        }

        [TestMethod]
        public void ShouldReturnFalseWhenExpressionContainsBalancedParanthesis()
        {
            // Arrange
            var expression = "[{name: Datta; city: Pune: 411014]";

            // Act
            var containsBalancedParanthesis = StringManipulations.ContainsBalancedParanthesis(expression);

            // Assert
            Assert.AreEqual(false, containsBalancedParanthesis);
        }
    }
}
