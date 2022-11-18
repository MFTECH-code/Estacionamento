using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using Xunit;

namespace Estacionamento.Tests
{
    public class PatioTest
    {
        [Fact]
        public void ValidaFaturamento()
        {
            // Arrange
            var estacionamento = new Patio();
            var operador = new Operador();
            operador.Nome = "Severino";
            estacionamento.OperadorPatio = operador;
            var veiculo = new Veiculo();
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
        public void ValidaFaturamentoComVariosVeiculos(
            string nomeOperador,
            string proprietario,
            string placa,
            string cor,
            string modelo)
        {
            // Arrange
            var estacionamento = new Patio();
            var operador = new Operador();
            operador.Nome = nomeOperador;
            estacionamento.OperadorPatio = operador;
            var veiculo = new Veiculo();
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
    }
}
