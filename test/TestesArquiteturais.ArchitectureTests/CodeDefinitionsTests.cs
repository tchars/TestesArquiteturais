using NetArchTest.Rules;
using System.Reflection;

namespace com.tchars.TestesArquiteturais.ArchitectureTests
{
    public class CodeDefinitionsTests
    {
        private readonly Types _types;

        private readonly IEnumerable<Assembly> _assemblies = new List<Assembly>
        {
            Assembly.Load("com.tchars.TestesArquiteturais.API"),
            Assembly.Load("com.tchars.TestesArquiteturais.Application"),
            Assembly.Load("com.tchars.TestesArquiteturais.Domain"),
            Assembly.Load("com.tchars.TestesArquiteturais.Infrastructure")
        };

        public CodeDefinitionsTests()
        {
            _types = Types.InAssemblies(_assemblies);
        }

        [Fact]
        public void Todas_Interfaces_Devem_Comecar_Com_Letra_I()
        {
            // Arrange
            var types = _types;

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