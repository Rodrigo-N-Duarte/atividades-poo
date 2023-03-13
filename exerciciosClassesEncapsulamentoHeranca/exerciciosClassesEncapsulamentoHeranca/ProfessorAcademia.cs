using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosClassesEncapsulamentoHeranca
{
    class ProfessorAcademia : FuncionarioAcademia
    {
        public string areaAtuacao { get; set; }

        public ProfessorAcademia()
        {
            areaAtuacao = $"area de atuação {id}";
        }
    }
}
