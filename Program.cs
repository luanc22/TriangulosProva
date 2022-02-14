using System;

namespace Triangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Declarao de variveis. [OK]
            string inputLadoUm;
            string inputLadoDois;
            string inputLadoTres;

            int LadoUm;
            int LadoDois;
            int LadoTres;

            string inputOp;

            bool fecharApp = false;

            bool checarLetra;
            bool checarDigito;
            bool naoLetra;
            int letraChecado;
            char[] verificarInput = new char[400];

            bool opcaoValida;
            string fecharBotao;
            #endregion

            #region Loop para manter o programa aberto e menu de opcoes. [OK]
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

                #region Opcao de verificar o tipo do triangulo. [OK]
                if (inputOp == "1")
                {
                    Console.Clear();
                    Console.WriteLine("===== Programa Triangulos =====");
                    Console.WriteLine("");
                    Console.WriteLine("Utilize esse programa para descobrir a definicao de um triangulo digitando seus lados.");
                    Console.WriteLine("");
                    Console.WriteLine("===================================");
                    Console.WriteLine("");

                    Console.Write("Digite o primeiro lado do triangulo: ");
                    inputLadoUm = Console.ReadLine();
                    Console.Write("Digite o segundo lado do triangulo: ");
                    inputLadoDois = Console.ReadLine();
                    Console.Write("Digite o terceiro lado do triangulo: ");
                    inputLadoTres = Console.ReadLine();

                    #region Checar se existe letras no input digitado. [OK]
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
                            checarDigito = char.IsDigit(verificarInput[i]);

                            if (checarDigito == false)
                            {
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("ERRO!\nLetra identificada, por favor, digite apenas numeros!");
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
                    #endregion

                    #region Parse para Int e condicoes para verificar o tipo de Triangulo e se ele eh um triangulo valido. [OK]
                    LadoUm = int.Parse(inputLadoUm);
                    LadoDois = int.Parse(inputLadoDois);
                    LadoTres = int.Parse(inputLadoTres);

                    if (LadoUm <= 0 || LadoDois <=0 || LadoTres <= 0)
                    {
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERRO!\nNumero digitado igual ou menor que zero, digite um numero valido.");
                        Console.WriteLine("");
                        Console.ResetColor();
                        Console.Write("Aperte ENTER para prosseguir.");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }
                    else if (LadoUm + LadoDois < LadoTres || LadoDois + LadoTres < LadoUm || LadoUm + LadoTres < LadoDois)
                    {
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERRO!\nLados do triangulo invalidos, a soma de dois lados nao pode ser menor que o terceiro.");
                        Console.WriteLine("");
                        Console.ResetColor();
                        Console.Write("Aperte ENTER para prosseguir.");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }
                    else if (LadoUm == LadoDois && LadoDois == LadoTres)
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
                    #endregion

                    Console.WriteLine("");

                    #region Menu de Opcoes no fim do programa para rodar novamente. [OK]
                    opcaoValida = false;
                    while (opcaoValida == false)
                    {
                        Console.WriteLine("Caso deseje realizar rodar o programa novamente e inserir novos comandos, digite 1 e aperte ENTER.");
                        Console.WriteLine("Caso deseje fechar o programa, digite 0 e aperte ENTER.");
                        Console.Write("Opcao escolhida: ");
                        fecharBotao = Console.ReadLine();

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
                    #endregion
                }
                #endregion
                #region Opcao de Fechar Programa. [OK]
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
                #endregion
            }
            #endregion
        }
    }
}
