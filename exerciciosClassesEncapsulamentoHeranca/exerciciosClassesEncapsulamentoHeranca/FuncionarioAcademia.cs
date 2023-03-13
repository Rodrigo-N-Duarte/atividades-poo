using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosClassesEncapsulamentoHeranca
{
    class FuncionarioAcademia
    {
        public static int id = 0;
        public string nome { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }
        public string carteiraTrabalho { get; set; }
        public string salario { get; set; }
        public FuncionarioAcademia()
        {
            id++;
            nome = $"nome {id}";
            endereco = $"endereco {id}";
            telefone = $"telefone {id}";
            carteiraTrabalho = $"carteira de trabalho {id}";
            salario = $"salario {id}";
        }
    }
}
