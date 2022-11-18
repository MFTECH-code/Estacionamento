using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using Xunit;
using Xunit.Abstractions;

namespace Estacionamento.Tests
{
    public class VeiculoTest : IDisposable
    {
        private Veiculo veiculo;
        private ITestOutputHelper _saidaConsoleTeste;

        public VeiculoTest(ITestOutputHelper saidaConsoleTeste)
        {
            _saidaConsoleTeste = saidaConsoleTeste;
            _saidaConsoleTeste.WriteLine("Construtor invocado");
            veiculo = new Veiculo();
        }

        [Fact]
        public void TestaVeiculoAcelerarComParametro10()
        {
            // Arrange -> Prepara��o do cen�rio para realizar o teste
            // var veiculo = new Veiculo();
            // Act -> Execu��o do m�todo testado
            veiculo.Acelerar(10);
            // Assert -> Verifica��o do dado obtido do m�todo com os esperados
            Assert.Equal(100, veiculo.VelocidadeAtual);
        }

        [Fact]
        public void TestaVeiculoFrearComParametro10()
        {
            // Arrange
            var veiculo = new Veiculo();
            // Act
            veiculo.Frear(10);
            // Assert
            Assert.Equal(-150, veiculo.VelocidadeAtual);
        }

        [Fact(Skip = "Teste ainda n�o implementado. Ignorar")]
        public void ValidaNomeProprietarioDoVeiculo()
        {

        }

        [Fact]
        public void FichaDeDadosDoVeiculo()
        {
            //var veiculo = new Veiculo();
            veiculo.Proprietario = "Jos�";
            veiculo.Tipo = TipoVeiculo.Automovel;
            veiculo.Cor = "verde";
            veiculo.Modelo = "Fusca";
            veiculo.Placa = "asd-9999";

            var dados = veiculo.ToString();

            Assert.Contains("Tipo do Ve�culo: Automovel", dados);
        }

        public void Dispose()
        {
            _saidaConsoleTeste.WriteLine("Clenup");
        }
    }
}