using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using Xunit;
using Xunit.Abstractions;

namespace Estacionamento.Tests
{
    public class PatioTest : IDisposable
    {
        private Veiculo veiculo;
        private Patio estacionamento;
        private ITestOutputHelper _saidaConsoleTeste;

        public PatioTest(ITestOutputHelper saidaConsoleTeste)
        {
            _saidaConsoleTeste = saidaConsoleTeste;
            _saidaConsoleTeste.WriteLine("Setup");
            veiculo = new Veiculo();
            estacionamento = new Patio();
        }

        [Fact]
        public void ValidaFaturamentoDoEstacionamentoComUmVeiculo()
        {
            // Arrange
            //var estacionamento = new Patio();
            var operador = new Operador();
            operador.Nome = "Severino";
            estacionamento.OperadorPatio = operador;
            //var veiculo = new Veiculo();
            veiculo.Proprietario = "José";
            veiculo.Tipo = TipoVeiculo.Automovel;
            veiculo.Cor = "verde";
            veiculo.Modelo = "Fusca";
            veiculo.Placa = "asd-9999";
            estacionamento.RegistrarEntradaVeiculo(veiculo);
            estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);
            // Act
            var faturamento = estacionamento.TotalFaturado();
            // Assert
            Assert.Equal(2, faturamento);
        }

        [Theory]
        [InlineData("Severino", "José", "ASD-1234", "preto", "Gol")]
        [InlineData("Marcos", "Josias", "ASD-4321", "Acul", "Fusca")]
        [InlineData("Cleber", "Vagner", "ASD-5678", "Cinza", "Opala")]
        public void ValidaFaturamentoDoEstacionamentoComVariosVeiculos(
            string nomeOperador,
            string proprietario,
            string placa,
            string cor,
            string modelo)
        {
            // Arrange
           // var estacionamento = new Patio();
            var operador = new Operador();
            operador.Nome = nomeOperador;
            estacionamento.OperadorPatio = operador;
           // var veiculo = new Veiculo();
            veiculo.Proprietario = proprietario;
            veiculo.Tipo = TipoVeiculo.Automovel;
            veiculo.Cor = cor;
            veiculo.Modelo = modelo;
            veiculo.Placa = placa;
            estacionamento.RegistrarEntradaVeiculo(veiculo);
            estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);
            // Act
            var faturamento = estacionamento.TotalFaturado();
            // Assert
            Assert.Equal(2, faturamento);
        }

        [Theory]
        [InlineData("Cleber", "Vagner", "ASD-5678", "Cinza", "Opala")]
        public void LocalizaVeiculoNoPatioComBaseNaPlaca(
            string nomeOperador,
            string proprietario,
            string placa,
            string cor,
            string modelo)
        {
            // Arrange
            //var estacionamento = new Patio();
            var operador = new Operador();
            operador.Nome = nomeOperador;
            estacionamento.OperadorPatio = operador;
           // var veiculo = new Veiculo();
            veiculo.Proprietario = proprietario;
            veiculo.Tipo = TipoVeiculo.Automovel;
            veiculo.Cor = cor;
            veiculo.Modelo = modelo;
            veiculo.Placa = placa;
            estacionamento.RegistrarEntradaVeiculo(veiculo);

            // Act
            var consulta = estacionamento.PesquisaVeiculo(placa);

            // Assert
            Assert.Equal(placa, consulta?.Placa);
        }

        [Fact]
        public void AlteraDadosDoProprioVeiculo()
        {
            // Arrange
           // var estacionamento = new Patio();
            var operador = new Operador();
            operador.Nome = "Severino";
            estacionamento.OperadorPatio = operador;
            //var veiculo = new Veiculo();
            veiculo.Proprietario = "José";
            veiculo.Tipo = TipoVeiculo.Automovel;
            veiculo.Cor = "verde";
            veiculo.Modelo = "Fusca";
            veiculo.Placa = "asd-9999";
            estacionamento.RegistrarEntradaVeiculo(veiculo);

            var veiculoAlterado = new Veiculo();
            veiculoAlterado.Proprietario = "José";
            veiculoAlterado.Placa = "asd-9999";
            veiculoAlterado.Cor = "Preto";
            veiculoAlterado.Modelo = "Fusca";

            // Act
            var alterado = estacionamento.AlteraDadosVeiculo(veiculoAlterado);

            // Assert
            Assert.Equal(alterado.Cor, veiculoAlterado.Cor);
        }

        public void Dispose()
        {
            _saidaConsoleTeste.WriteLine("Cleanup");
        }
    }
}
