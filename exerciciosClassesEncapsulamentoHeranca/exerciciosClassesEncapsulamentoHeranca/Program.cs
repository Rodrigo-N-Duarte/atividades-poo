//Exercicios feitos por Rodrigo Duarte
//Para visualizar uma questão, tire ela do comentario e deixe as outras comentadas para evitar erros

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace exerciciosClassesEncapsulamentoHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Exercicio 1
            //FuncionarioAcademia[] funcionarios = new FuncionarioAcademia[100];
            //ProfessorAcademia[] professores = new ProfessorAcademia[100];
            //FuncionarioAcademia funcionario;
            //ProfessorAcademia professor;

            //for (int i = 0; i < 100; i++)
            //{
            //    funcionario = new FuncionarioAcademia();
            //    funcionarios[i] = funcionario;

            //    professor = new ProfessorAcademia();
            //    professores[i] = professor;
            //}

            //Console.WriteLine("Administradores e professores salvos, aperte qualquer tecla para listar");
            //Console.ReadKey();

            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine($"Funcionario {i+1}");
            //    Console.WriteLine($"Nome: {funcionarios[i].nome}");
            //    Console.WriteLine($"Telefone: {funcionarios[i].telefone}");
            //    Console.WriteLine($"Carteira de trabalho: {funcionarios[i].carteiraTrabalho}");
            //    Console.WriteLine($"Salario: {funcionarios[i].salario}\n");

            //    Console.WriteLine($"Professor {i + 1}");
            //    Console.WriteLine($"Nome: {professores[i].nome}");
            //    Console.WriteLine($"Telefone: {professores[i].telefone}");
            //    Console.WriteLine($"Carteira de trabalho: {professores[i].carteiraTrabalho}");
            //    Console.WriteLine($"Salario: {professores[i].salario}");
            //    Console.WriteLine($"Area de atuação: {professores[i].areaAtuacao}\n\n\n");
            //}

            //Console.WriteLine("\n\n\nFim da listagem, aperte qualquer tecla para sair");
            //Console.ReadKey();










            ////Exercicio 2
            //int opc;
            //List<Times> cadastroTimes = new List<Times>();
            //DadosTimes dadosTimes = new DadosTimes();
            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("Selecione a opção desejada");
            //    Console.WriteLine("1 - Adicionar time");
            //    Console.WriteLine("2 - Listar time");
            //    Console.WriteLine("3 - Sair");
            //    opc = int.Parse(Console.ReadLine());

            //    switch (opc)
            //    {
            //        case 1:
            //            Times time = new Times();
            //            dadosTimes.leDados(cadastroTimes, time);
            //            break;
            //        case 2:
            //            dadosTimes.lista(cadastroTimes);
            //            break;
            //        case 3:
            //            Console.WriteLine("O programa será encerrado, aperte qualquer tecla");
            //            Console.ReadKey();
            //            break;
            //    }

            //} while (opc != 3);










            //// Exercicio 3
            //int opc;
            //List<Times> cadastroTimes = new List<Times>();
            //DadosTimes dadosTimes = new DadosTimes();
            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("Selecione a opção desejada");
            //    Console.WriteLine("1 - Adicionar time");
            //    Console.WriteLine("2 - Listar time");
            //    Console.WriteLine("3 - Sair");
            //    opc = int.Parse(Console.ReadLine());

            //    switch (opc)
            //    {
            //        case 1:
            //            dadosTimes.leDados(cadastroTimes, dadosTimes.leTipo());
            //            break;
            //        case 2:
            //            dadosTimes.lista(cadastroTimes);
            //            break;
            //        case 3:
            //            Console.WriteLine("O programa será encerrado, aperte qualquer tecla");
            //            Console.ReadKey();
            //            break;
            //    }

            //} while (opc != 3);












            //// Exercicio 4
            int opc;
            List<Veiculo> cadastroVeiculos = new List<Veiculo>();
            do
            {
                Console.Clear();
                Console.WriteLine("Selecione a opção desejada");
                Console.WriteLine("1 - Adicionar veiculo");
                Console.WriteLine("2 - Listar todos");
                Console.WriteLine("3 - Procurar valor por placa");
                Console.WriteLine("4 - Sair");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Qual tipo de veiculo decide listar?");
                        Console.WriteLine("1 - Passeio");
                        Console.WriteLine("2 - Carga");
                        int opcCarro = int.Parse(Console.ReadLine());

                        if (opcCarro == 1)
                        {
                            VeiculoPasseio v = new VeiculoPasseio();
                            v.leDados();
                            cadastroVeiculos.Add(v);
                        }
                        else
                        {
                            VeiculoCarga v = new VeiculoCarga();
                            v.leDados();
                            cadastroVeiculos.Add(v);
                        }
                        break;
                    case 2:
                        Console.Clear();
                        foreach (Veiculo x in cadastroVeiculos)
                        {
                            x.listaVeiculos(cadastroVeiculos);
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Digite a placa a ser verificada: ");
                        string placa = Console.ReadLine();
                        pesquisaPlaca(cadastroVeiculos, placa);
                        break;
                    case 4:
                        Console.WriteLine("O programa será encerrado, aperte qualquer tecla");
                        Console.ReadKey();
                        break;
                }

            } while (opc != 4);
        }
        static void pesquisaPlaca(List<Veiculo> lista, string placa)
        {
            foreach (Veiculo v in lista)
            {
                if (v.placa == placa)
                {
                    Console.WriteLine($"O veiculo da placa {v.placa}");
                    Console.WriteLine($"KM inicial {v.KMinicial}");
                    Console.WriteLine($"KM final {v.KMfinal}");
                    Console.WriteLine($"Valor da locação R${v.valorKMrodado}");
                    break;
                }
            }
            Console.ReadKey();

        }
    }
}
