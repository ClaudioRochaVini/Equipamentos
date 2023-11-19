using System;
using System.Collections.Generic;

namespace SistemaEquipamentos {
    internal class Program {

        public static List<Equipamento> list = new List<Equipamento>();
        static void Main(string[] args) {


            int menu = 0;

            while (menu != 5) {
                Console.WriteLine("\n\n========================================");
                Console.WriteLine("             MENU PRINCIPAL");
                Console.WriteLine("========================================\n");
                Console.WriteLine("1. CADASTRAR");
                Console.WriteLine("2. LISTAR");
                Console.WriteLine("3. EDITAR");
                Console.WriteLine("4. REMOVER");
                Console.WriteLine("5. SAIR");
                menu = int.Parse(Console.ReadLine());

                if (menu == 1) {
                    Console.WriteLine("---------------------------");
                    Console.Write("Codigo: ");
                    int code = int.Parse(Console.ReadLine());
                    Console.Write("Nome: ");
                    string name = Console.ReadLine();
                    Console.Write("Serie: ");
                    int serie = int.Parse(Console.ReadLine());
                    Console.Write("Defeito: ");
                    string bad = Console.ReadLine();
                    list.Add(new Equipamento(code, name, serie, bad));
                    Console.WriteLine("\n   --- ITEM CADASTRADO COM SUCESSO ---");
                    Listar();
                }
                else if (menu == 2) {                    
                    Listar();
                }
                else if (menu == 3) {
                    Console.Write("\nDeseja LISTAR os equipamentos (s/n)? ");
                    char listar = char.Parse(Console.ReadLine());
                    if (listar == 's' || listar == 'S') {
                        Listar();
                    }

                    Console.Write("\nCODIGO do equipamento a ser EDITADO: ");
                    int codEditar = int.Parse(Console.ReadLine());
                    if (list.Find(equipamento => equipamento.Codigo == codEditar) != null) {
                        Console.WriteLine("\n" + list.Find(equipamento => equipamento.Codigo == codEditar));
                        Console.Write("\nAtualizar DEFEITO: ");
                        string newBad = Console.ReadLine();
                        list.Find(equipamento => equipamento.Codigo == codEditar).AtualizarDefeito(newBad);
                        Console.WriteLine("\n" + list.Find(equipamento => equipamento.Codigo == codEditar));
                        Console.WriteLine("\n     --- DEFEITO EDITADO COM SUCESSO ---");
                    }
                    else {
                        Console.WriteLine("\n ------ CODIGO INVALIDO!!! ------");
                    }
                }
                else if (menu == 4) {
                    Console.Write("\nDeseja LISTAR os equipamentos (s/n)? ");
                    char listar = char.Parse(Console.ReadLine());
                    if (listar == 's' || listar == 'S') {
                        Listar();
                    }

                    Console.Write("\nCODIGO do equipamento a ser REMOVIDO: ");
                    int codRemover = int.Parse(Console.ReadLine());
                    if (list.Find(equip => equip.Codigo == codRemover) != null) {
                        Console.WriteLine("\n" + list.Find(equip => equip.Codigo == codRemover));
                        Console.Write("Deseja REMOVER o item listado (s/n)? ");
                        char remover = char.Parse(Console.ReadLine());

                        if (remover == 's' || remover == 'S') {
                            list.RemoveAll(equip => equip.Codigo == codRemover);
                            Console.WriteLine("\n   ---- ITEM REMOVIDO COM SUCESSO ----");
                        }
                        else {
                            Console.WriteLine("\n   ---- CANCELADA REMOÇÃO ----");
                        }

                        Listar();
                    }
                    else {
                        Console.WriteLine("\n     ---- CODIGO INVALIDO ----");
                    }
                }
                else if (menu != 5) {
                    Console.WriteLine("\nInvalido");
                }
            }
        }

        static void Listar() {
            Console.WriteLine("\n-------------------------------------------");
            foreach (Equipamento equipamento in list) {                
                Console.WriteLine(equipamento);
            }
            Console.WriteLine("-------------------------------------------\n");
        }
    }
}
