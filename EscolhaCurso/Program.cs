using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolhaCurso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int cont = 0;
                int meca = 0;
                int ds = 0
                    
                    
                    
                    ;
                int edf = 0;
                int adm = 0;
                int continuar = 1;
                int curso;

                while (continuar == 1)

                {
                    Console.WriteLine("Escolha o curso usando (1)Desenvolvimento de Sistemas (2)Mecatrônica (3)Edificações (4)Administração");

                    curso = int.Parse(Console.ReadLine());

                    switch (curso)
                    {
                        case 1:
                            if (ds <= 5)
                            {
                                Console.WriteLine("O aluno foi matrículado em Desenvolvimento de Sistemas.");
                                ds++;
                            }
                            else
                            {
                                Console.WriteLine("Não há mais vagas neste curso.");
                                ds--;
                            }
                            break;

                        case 2:
                           if (meca <= 5)
                            {
                                Console.WriteLine("O aluno foi matrículado em Mecatrônica.");
                                meca++;
                            }
                            else
                            {
                                Console.WriteLine("Não há mais vagas neste curso.");
                                meca--;
                            }
                            break;

                        case 3:
                            if (edf <= 0)
                            {
                                Console.WriteLine("O aluno foi matrículado em Edificações.");
                                edf++;
                            }
                            else
                            {
                                Console.WriteLine("Não há mais vagas neste curso.");
                                edf--;
                            }
                            break;

                        case 4:
                            if (adm <= 0)
                            {
                                Console.WriteLine("O aluno foi matrículado em Adminastração.");
                                adm++;
                            }
                            else
                            {
                                Console.WriteLine("Não há mais vagas neste curso.");
                                adm--;
                            }
                            break;


                        default:
                            Console.WriteLine("Opção inválida.");
                        break;

                    }
                    cont++;
                    Console.WriteLine("Você deseja continuar? (1)Sim (2)Não: ");
                    continuar = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
                Console.WriteLine("O total de matrículas em cada curso foram de " + cont + " alunos");
                Console.WriteLine("Desenvolvimento de Sistemas: " + ds);
                Console.WriteLine("Mecatrônica: " + meca);
                Console.WriteLine("Edificações: " + edf);
                Console.WriteLine("Administração: " + adm);
                Console.ReadKey();
            }
        }
    }
}