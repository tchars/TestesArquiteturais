using NetArchTest.Rules;
using System.Reflection;

namespace TestesArquiteturais.ArchitectureTests
{
    public class CodeDefinitionsTests
    {
        private readonly Types _type;

        private readonly IEnumerable<Assembly> _assemblies = new List<Assembly> 
        {
            Assembly.Load("TestesArquiteturais.API"),
            Assembly.Load("TestesArquiteturais.Application"),
            Assembly.Load("TestesArquiteturais.Domain"),
            Assembly.Load("TestesArquiteturais.Infrastructure")
        };

        public CodeDefinitionsTests()
        {
            _type = Types.InAssemblies(_assemblies);
        }

        [Fact]
        public void Todas_Interfaces_Devem_Comecar_Com_Letra_I()
        {
            // Arrange
            var types = _type;

            // Act
            var result = types
                            .That().AreInterfaces()
                            .Should()
                            .HaveNameStartingWith("I")
                            .GetResult();
            // Assert
            Assert.True(result.IsSuccessful);
        }
    }
}