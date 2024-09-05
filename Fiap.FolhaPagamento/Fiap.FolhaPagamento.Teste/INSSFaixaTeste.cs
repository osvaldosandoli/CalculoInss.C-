using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.FolhaPagamento.Teste
{
    public class INSSFaixaTeste
    {

        public static IEnumerable<object> DadosValorFaixa => 
            new List<object>
            {
                
                new object[] { 0m,  1412m,  7.5m},
                new object[] { 1412.01m, 2666.68m,  9m},
                new object[] { 2666.69m,  4000.03m,  12m},
                new object[] { 4000.04m,  7786.02m,  14m},
            }
        [Fact]
        public void INSS_Faixa_Deve_Conter_Valor()
        {
            var faixa = new INSSFaixa
            {
                Piso = 0,
                Teto = 1412
            };
            Assert.True(faixa.ContemValor(1200));
        }
        [Fact]
        public void Deve_Obter_1412()
        {
            //Arange
            var faixa = new INSSFaixa
            {
                Piso = 0,
                Teto = 1412,
                Aliquota = 7.5m
            };
            //Act
            var resultado = faixa.ObterValorFaixa(1412);
            const decimal esperado = 1412m;
            //Assert
            Assert.Equal(esperado, resultado);
        }
    }
}
