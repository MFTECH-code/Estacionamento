using Alura.Estacionamento.Modelos;
using Xunit;

namespace Estacionamento.Tests
{
    public class VeiculoTest
    {
        [Fact(DisplayName = "Teste do método acelerar")]
        [Trait("Funcionalidade", "Acelerar")]
        public void TestaVeiculoAcelerar()
        {
            // Arrange -> Preparação do cenário para realizar o teste
            var veiculo = new Veiculo();
            // Act -> Execução do método testado
            veiculo.Acelerar(10);
            // Assert -> Verificação do dado obtido do método com os esperados
            Assert.Equal(100, veiculo.VelocidadeAtual);
        }

        [Fact(DisplayName = "Teste do método frear")]
        [Trait("Funcionalidade", "Frear")]
        public void TestaVeiculoFrear()
        {
            // Arrange
            var veiculo = new Veiculo();
            // Act
            veiculo.Frear(10);
            // Assert
            Assert.Equal(-150, veiculo.VelocidadeAtual);
        }

        [Fact(DisplayName = "Validação de nome do proprietário", Skip = "Teste ainda não implementado. Ignorar")]
        public void ValidaNomeProprietario()
        {

        }
    }
}