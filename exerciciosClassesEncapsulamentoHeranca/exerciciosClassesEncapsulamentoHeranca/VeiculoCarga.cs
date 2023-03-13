using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosClassesEncapsulamentoHeranca
{
    class VeiculoCarga:Veiculo
    {
        public double capacidadeToneladas { get; set; }

        public override void leDados()
        {
            base.leDados();
            Console.WriteLine("Digite tambem a quantidade em toneladas suportada pelo veiculo em questão: ");
            this.capacidadeToneladas = double.Parse(Console.ReadLine());
        }

        public override void listaVeiculos(List<Veiculo> lista)
        {
            Console.WriteLine("\n-- Veiculo de varga --");
            Console.WriteLine($"Placa: {placa}");
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Modelo: {modelo}");
            Console.WriteLine($"Ano de fabricação: {anoFabricacao}");
            Console.WriteLine($"Cacidade de carga: {capacidadeToneladas}");
        }
    }
}
