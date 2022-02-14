using System;

namespace Triangulos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLadoUm;
            string inputLadoDois;
            string inputLadoTres;

            int LadoUm;
            int LadoDois;
            int LadoTres;

            string inputOp;

            bool fecharApp = false;

            bool checarLetra;
            bool naoLetra;
            int letraChecado;
            char[] verificarInput = new char[400];

            while (fecharApp == false)
            {
                Console.WriteLine("===== Programa Triangulos =====");
                Console.WriteLine("");
                Console.WriteLine("Utilize esse programa para descobrir a definicao de um triangulo digitando seus lados.");
                Console.WriteLine("");
                Console.WriteLine("===================================");
                Console.WriteLine("");

                Console.WriteLine("Bem vindo ao menu de utilizacao da calculadora de triangulo.");
                Console.WriteLine("");
                Console.WriteLine("Escolha uma das opcoes a baixo para continuar.");
                Console.WriteLine("");
                Console.WriteLine("1 - Verificar o tipo do triangulo.\n2 - Fechar o programa.");
                Console.WriteLine("");
                Console.Write("Opcao escolhida: ");
                inputOp = Console.ReadLine();
                inputOp = inputOp.Replace(" ", "");

                if (inputOp == "1")
                {
                    Console.WriteLine("");
                    Console.Write("Digite o primeiro lado do triangulo: ");
                    inputLadoUm = Console.ReadLine();
                    Console.Write("Digite o segundo lado do triangulo: ");
                    inputLadoDois = Console.ReadLine();
                    Console.Write("Digite o terceiro lado do triangulo: ");
                    inputLadoTres = Console.ReadLine();

                    checarLetra = false;
                    naoLetra = false;
                    letraChecado = 1;

                    while (checarLetra == false)
                    {

                        if (letraChecado == 1)
                        {
                            verificarInput = inputLadoUm.ToCharArray();
                        }
                        else if (letraChecado == 2)
                        {
                            verificarInput = inputLadoDois.ToCharArray();
                        }
                        else if (letraChecado == 3)
                        {
                            verificarInput = inputLadoTres.ToCharArray();
                        }
                        else
                        {
                            checarLetra = true;
                        }

                        letraChecado = letraChecado + 1;

                        for (int i = 0; i < verificarInput.Length; i++)
                        {
                            bool checarDigito = char.IsDigit(verificarInput[i]);

                            if (checarDigito == false)
                            {
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Lado de triangulo invalido, por favor digite um numero valido.");
                                Console.WriteLine("");
                                Console.ResetColor();
                                Console.Write("Aperte ENTER para prosseguir.");
                                Console.ReadLine();
                                Console.Clear();

                                naoLetra = true;
                                checarLetra = true;
                            }
                        }
                    }

                    if (naoLetra == true)
                    {
                        continue;
                    }

                    LadoUm = int.Parse(inputLadoUm);
                    LadoDois = int.Parse(inputLadoDois);
                    LadoTres = int.Parse(inputLadoTres);

                    if (LadoUm + LadoDois < LadoTres || LadoDois + LadoTres < LadoUm || LadoUm + LadoTres < LadoDois)
                    {
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Lado de triangulo invalido, por favor digite um lado valida.");
                        Console.WriteLine("");
                        Console.ResetColor();
                        Console.Write("Aperte ENTER para prosseguir.");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }

                    if (LadoUm == LadoDois && LadoDois == LadoTres)
                    {
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Seu triangulo eh um triangulo do tipo Equilatero.");
                        Console.WriteLine("");
                        Console.ResetColor();
                        Console.Write("Aperte ENTER para prosseguir.");
                        Console.ReadLine();
                    }
                    else if (LadoUm == LadoDois || LadoDois == LadoTres || LadoTres == LadoUm)
                    {
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Seu triangulo eh um triangulo do tipo Isoceles.");
                        Console.WriteLine("");
                        Console.ResetColor();
                        Console.Write("Aperte ENTER para prosseguir.");
                        Console.ReadLine();
                    }
                    else if (LadoUm != LadoDois || LadoDois != LadoTres || LadoTres != LadoUm)
                    {
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Seu triangulo eh um triangulo do tipo Escaleno.");
                        Console.WriteLine("");
                        Console.ResetColor();
                        Console.Write("Aperte ENTER para prosseguir.");
                        Console.ReadLine();
                    }

                    Console.WriteLine("");

                    bool opcaoValida = false;
                    while (opcaoValida == false)
                    {
                        Console.WriteLine("Caso deseje realizar rodar o programa novamente e inserir novos comandos, digite 1 e aperte ENTER.");
                        Console.WriteLine("Caso deseje fechar o programa, digite 0 e aperte ENTER.");
                        Console.Write("Opcao escolhida: ");
                        string fecharBotao = Console.ReadLine();

                        if (fecharBotao == "0")
                        {
                            fecharApp = true;
                            opcaoValida = true;
                        }
                        else if (fecharBotao == "1")
                        {
                            Console.Clear();
                            opcaoValida = true;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Opcao invalida, selecione uma opcao valida!");
                            Console.ResetColor();
                            Console.WriteLine("");
                            Console.WriteLine("Aperte ENTER para prosseguir.");
                            Console.ReadLine();
                            continue;
                        }
                    }

                }

                else if (inputOp == "2")
                {
                    fecharApp = true;
                }
                else
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opcao Invalida, por favor digite uma opcao valida.");
                    Console.WriteLine("");
                    Console.ResetColor();
                    Console.Write("Aperte ENTER para prosseguir.");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
            }
        }
    }
}
