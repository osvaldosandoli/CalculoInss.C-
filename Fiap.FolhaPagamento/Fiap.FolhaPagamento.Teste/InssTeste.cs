using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.FolhaPagamento.Teste
{
   //Padrão triple A:
   //Arrage, Act, Assert
    public class InssTeste
    {
        [Fact]
        public void Deveria_Aplicar_Faixa_1()
        {
            //Arrage: Configura para o teste
            var inss = new Inss();

            //ACT: realiza ação
            //1412.00 - 7,5% = 105.9
            var desconto = inss.CalcularDesconto(1412);

            //Assert: verrifica se ha asserção
            //está correta
            Assert.Equal(105.9m, desconto);
        }

        [Fact]
        public void Deveria_Aplicar_Faixa_2()
        {
            const decimal salario = 2100.00m;
            const decimal descontoEsperado = 167.82m;
            var inss = new Inss();
            //1412 *  7.5 = 109.05
            // [2100 - 1412] * 0.09 = 688.00 * 0.09 = 61.92

            var desconto = inss.CalcularDesconto(salario);

            Assert.Equal(descontoEsperado, desconto);
        }
    }
}
