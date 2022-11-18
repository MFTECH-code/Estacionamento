using Alura.Estacionamento.Modelos;
using Xunit;

namespace Estacionamento.Tests
{
    public class VeiculoTest
    {
        [Fact(DisplayName = "Teste do m�todo acelerar")]
        [Trait("Funcionalidade", "Acelerar")]
        public void TestaVeiculoAcelerar()
        {
            // Arrange -> Prepara��o do cen�rio para realizar o teste
            var veiculo = new Veiculo();
            // Act -> Execu��o do m�todo testado
            veiculo.Acelerar(10);
            // Assert -> Verifica��o do dado obtido do m�todo com os esperados
            Assert.Equal(100, veiculo.VelocidadeAtual);
        }

        [Fact(DisplayName = "Teste do m�todo frear")]
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

        [Fact(DisplayName = "Valida��o de nome do propriet�rio", Skip = "Teste ainda n�o implementado. Ignorar")]
        public void ValidaNomeProprietario()
        {

        }
    }
}