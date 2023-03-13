using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosClassesEncapsulamentoHeranca
{
    class VeiculoPasseio : Veiculo
    {
        public bool possuiArCondicionado { get; set; }

        public override void leDados()
        {
            base.leDados();
            Console.WriteLine("Digite tambem se o veiculo tem ar condicionado s/n:");
            char opc = char.Parse(Console.ReadLine());

            if (opc == 's')
                this.possuiArCondicionado = true;
            else
                this.possuiArCondicionado = false;
        }

        public override void listaVeiculos(List<Veiculo> lista)
        {
            Console.WriteLine("\n-- Veiculo de passeio --");
            Console.WriteLine($"Placa: {placa}");
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Modelo: {modelo}");
            Console.WriteLine($"Ano de fabricação: {anoFabricacao}");
            Console.WriteLine($"Possui ar-condicionado?: {true}");
        }
    }
}
