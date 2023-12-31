using NetArchTest.Rules;
using System.Reflection;

namespace com.tchars.TestesArquiteturais.ArchitectureTests
{
    public class DomainTests
    {
        private readonly Types _type;

        public DomainTests()
        {
            _type = Types.InAssembly(Assembly.Load("com.tchars.TestesArquiteturais.Domain"));
        }

        [Fact]
        public void Domain_Nao_Deve_Ter_Dependencia_Da_Application()
        {
            // Arrange
            var types = _type;

            // Act
            var result = types
                           .ShouldNot()
                           .HaveDependencyOn("com.tchars.TestesArquiteturais.Application")
                           .GetResult();

            // Assert
            Assert.True(result.IsSuccessful);
        }
    }
}