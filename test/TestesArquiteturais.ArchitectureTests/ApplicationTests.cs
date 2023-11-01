using NetArchTest.Rules;
using System.Reflection;

namespace TestesArquiteturais.ArchitectureTests
{
    public class ApplicationTests
    {
        private readonly Types _type;

        public ApplicationTests()
        {
            _type = Types.InAssembly(Assembly.Load("TestesArquiteturais.Application"));
        }

        [Fact]
        public void Todas_Classes_Devem_Ser_Sealed()
        {
            // Arrange
            var types = _type;

            // Act
            var result = types
                            .That().AreClasses()
                            .Should()
                            .BeSealed()
                            .GetResult();

            // Assert
            Assert.True(result.IsSuccessful);
        }
    }
}