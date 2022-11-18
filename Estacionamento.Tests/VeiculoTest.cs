using Alura.Estacionamento.Modelos;

namespace Estacionamento.Tests
{
    public class VeiculoTest
    {
        [Fact]
        public void TestaVeiculoAcelerar()
        {
            // Arrange -> Prepara��o do cen�rio para realizar o teste
            var veiculo = new Veiculo();
            // Act -> Execu��o do m�todo testado
            veiculo.Acelerar(10);
            // Assert -> Verifica��o do dado obtido do m�todo com os esperados
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