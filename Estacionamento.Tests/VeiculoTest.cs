using Alura.Estacionamento.Modelos;

namespace Estacionamento.Tests
{
    public class VeiculoTest
    {
        [Fact]
        public void TestaVeiculoAcelerar()
        {
            // Arrange -> Preparação do cenário para realizar o teste
            var veiculo = new Veiculo();
            // Act -> Execução do método testado
            veiculo.Acelerar(10);
            // Assert -> Verificação do dado obtido do método com os esperados
            Assert.Equal(100, veiculo.VelocidadeAtual);
        }

        [Fact]
        public void TestaVeiculoFrear()
        {
            // Arrange
            var veiculo = new Veiculo();
            // Act
            veiculo.Frear(10);
            // Assert
            Assert.Equal(-150, veiculo.VelocidadeAtual);
        }
    }
}