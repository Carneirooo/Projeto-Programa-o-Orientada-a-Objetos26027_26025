/*
 * Menu.cs
 * 
 * Carlos Brandão - a26025@alunos.ipca.pt
 * Pedro Carneiro - a26027@alunos.ipca.pt
 * 13-11-2023
 * POO - ESI
 * File that contains the Menu, which allows a user to use the program
*/

using OperationsContracts;
using ManageHomes;

namespace Menu;
public class Menu
{
    private static List<Home> Homes = new List<Home>(); // Home List
    private static List<Contract> Contracts = new List<Contract>(); // Contract List

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1 - Add Home");
            Console.WriteLine("2 - List Homes");
            Console.WriteLine("3 - Add Contract");
            Console.WriteLine("4 - List Contracts");
            Console.WriteLine("0 - Exit");
            Console.WriteLine();
            Console.Write("Option: ");
            int option = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (option)
            {
                case 1:
                    Console.WriteLine("Add Home");
                    Console.Write("Insert ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Home Type (apartment, single-family, bungalow): ");
                    string type = Console.ReadLine();
                    Console.Write("Address: ");
                    string adress = Console.ReadLine();

                    Homes.AddHome(id, type, adress);

                    break;
                case 2:
                    Homes.ListHomes();
                    break;
                case 3:
                    OperationsContract.AddContract(Contracts, Homes);
                    break;
                case 4:
                    Contracts.ListContracts();
                    break;
                case 0:
                    Console.WriteLine("Thank you for using our program!");
                    return;
                default:
                    Console.WriteLine("Invalid Option! Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}