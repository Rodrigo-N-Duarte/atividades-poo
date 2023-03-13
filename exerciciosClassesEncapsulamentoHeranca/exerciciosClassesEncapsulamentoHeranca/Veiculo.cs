using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosClassesEncapsulamentoHeranca
{
    abstract class Veiculo
    {
        public string placa { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string anoFabricacao { get; set; }
        public double valorKMrodado { get; set; }
        public double KMinicial { get; set; }
        public double KMfinal { get; set; }
        private double valorLocacao { get; set; }

        public double calculaValorLocacao()
        {
            this.valorKMrodado = (this.KMfinal - this.KMinicial) * this.valorKMrodado;

            if (this.GetType() == typeof(VeiculoCarga))
                this.valorKMrodado *= 1.1;

            return valorKMrodado;
        }

        public virtual void leDados()
        {
            Console.Clear();
            Console.WriteLine("Informe a placa: ");
            this.placa = Console.ReadLine();
            Console.WriteLine("Informe a marca: ");
            this.marca = Console.ReadLine();
            Console.WriteLine("Informe o modelo: ");
            this.modelo = Console.ReadLine();
            Console.WriteLine("Informe o ano de fabricação: ");
            this.anoFabricacao = Console.ReadLine();
            Console.WriteLine("Valor do KM rodado: ");
            this.valorKMrodado = int.Parse(Console.ReadLine());
            Console.WriteLine("KM inicial: ");
            this.KMinicial = int.Parse(Console.ReadLine());
            Console.WriteLine("KM final: ");
            this.KMfinal = int.Parse(Console.ReadLine());
            calculaValorLocacao();
        }

        public abstract void listaVeiculos(List<Veiculo> lista);
    }
}
