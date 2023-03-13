using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosClassesEncapsulamentoHeranca
{
    class DadosTimes : Times
    {
        public int leTipo()
        {
            Console.Clear();
            Console.WriteLine("Informe também se ele é profissional ou de várzea");
            Console.WriteLine("1 - Profissional");
            Console.WriteLine("2 - Várzea");
            int opc = int.Parse(Console.ReadLine());

            return opc;
        }
        public void leDados(List<Times> lista, Times time)
        {
            Console.Clear();
            Console.WriteLine("Nome do time:");
            time.nome = Console.ReadLine();
            Console.WriteLine("Nome do presidente:");
            time.nomePresidente = Console.ReadLine();
            Console.WriteLine("Nome do tecnico:");
            time.nomeTecnico = Console.ReadLine();
            Console.WriteLine("Data de fundação:");
            time.dataFundacao = Console.ReadLine();
            Console.WriteLine("Cidade:");
            time.cidade = Console.ReadLine();
            Console.WriteLine("UF:");
            time.uf = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Adicionado com sucesso!");
            lista.Add(time);
            Console.ReadKey();
            Console.Clear();
        }
        public void leDados(List<Times> lista, int tipoTime)
        {
            switch (tipoTime) {
                case 1:
                    TimeProfissional profissional = new TimeProfissional();
                    Console.WriteLine("Digite os patrocinadores do time:");
                    profissional.patrocinadores = Console.ReadLine();
                    leDados(lista, profissional);
                    break;
                case 2:
                    TimeVarzea varzea = new TimeVarzea();
                    Console.WriteLine("Digite o bairro que o time representa:");
                    varzea.bairro = Console.ReadLine();
                    leDados(lista, varzea);
                    break;
            }   
        }

        public void lista(List<Times> lista)
        {
            Console.Clear();
            int cont = 1;

            foreach(Times t in lista)
            {
                Console.WriteLine($"Time {cont}");
                if (t.GetType() == typeof(TimeProfissional))
                    Console.WriteLine($"Time Profissional");
                if (t.GetType() == typeof(TimeVarzea))
                    Console.WriteLine($"Time de Várzea");
                Console.WriteLine($"Nome: {t.nome}");
                Console.WriteLine($"Nome do  presidente: {t.nomePresidente}");
                Console.WriteLine($"Nome do técnico: {t.nomeTecnico}");
                Console.WriteLine($"Data de fundação: {t.dataFundacao}");
                Console.WriteLine($"Cidade: {t.cidade}");
                Console.WriteLine($"UF: {t.uf}\n\n");
                cont++;
            }

            Console.WriteLine("\n\nFim");
            Console.ReadKey();
        }
    }
}
