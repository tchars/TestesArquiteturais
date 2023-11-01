using NetArchTest.Rules;
using System.Reflection;

namespace com.tchars.TestesArquiteturais.ArchitectureTests
{
    public class InfrastructureTests
    {
        private readonly Types _type;

        public InfrastructureTests()
        {
            _type = Types.InAssembly(Assembly.Load("com.tchars.TestesArquiteturais.Infrastructure"));
        }

        [Fact]
        public void Todas_Classes_De_Repositorio_Devem_Terminar_Em_Repository()
        {
            // Arrange
            var types = _type;

            // Act
            var result = types
                            .That().AreClasses()
                            .Should().HaveNameEndingWith("Repository")
                            .GetResult().IsSuccessful;

            // Assert
            Assert.True(result);
        }
    }
}