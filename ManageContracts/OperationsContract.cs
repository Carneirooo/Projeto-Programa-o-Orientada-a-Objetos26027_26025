/*
 * OperationsContract.cs
 * 
 * Carlos Brandão - a26025@alunos.ipca.pt
 * Pedro Carneiro - a26027@alunos.ipca.pt
 * 05-11-2023
 * POO - ESI
 * File that holds operations for Contracts
*/

using ManageHomes;

namespace OperationsContracts
{
    public static class OperationsContract
    {
        /// <summary>
        /// Checks if given Id already exists or not
        /// </summary>
        /// <param name="idToCheck"></param>
        /// <param name="homes"></param>
        /// <returns></returns>
        static bool HomeIdExists(int idToCheck, List<Home> homes)
        {
            if (idToCheck < 0)
            {
                Console.WriteLine("Invalid ID!");
                return false;
            }

            foreach (Home home in homes)
            {
                if (idToCheck == home.Id)
                {
                    return true;
                    // Place AddContract() here
                }
            }
            
            return false;
        }


        /// <summary>
        /// Adds a contract to the Contracts List
        /// </summary>
        /// <param Contract List="contracts"></param>
        /// <param Home List="homes"></param>
        public static void AddContract(List<Contract> contracts, List<Home> homes)
        {
            //Pass Console.ReadLine()'s to main()

            Console.WriteLine("Add contract");
            Console.Write("Home ID: ");
            int idToCkeck = int.Parse(Console.ReadLine());

            if(HomeIdExists(idToCkeck, homes) == true)
            {

                //Verify if home isn't already in an existing contract

                Home home = homes[home.Id]; //idk what to do here => ask teacher

                Console.Write("Contract Id: ");
                int contractId = int.Parse(Console.ReadLine());

                Console.Write("Initial Date (dd/mm/aaaa): ");
                DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

                Console.Write("Final Date (dd/mm/aaaa): ");
                DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

                Console.Write("Clientname Name: ");
                string clientName = Console.ReadLine();

                Console.Write("Clientname Id: ");
                int clientId = int.Parse(Console.ReadLine());

                Console.Write("Cost: ");
                double cost = double.Parse(Console.ReadLine());

                Contract contrato = new Contract(home, contractId, startDate, endDate, clientName, clientId, cost);
                contracts.Add(contrato);

                home.State = false;

                Console.WriteLine("Contract added successfully!");
            }
            else
            {
                Console.WriteLine("There was an error adding the contract!");
            }
        }

        /// <summary>
        /// Lists all existing Contracts
        /// </summary>
        /// <param Contract List="contracts"></param>
        public static void ListContracts(this List<Contract> contracts)
        {
            Console.WriteLine("ContractList");
            Console.WriteLine("=-=-=-=-=-=-=-=-=");

            foreach (Contract contract in contracts)
            {
                Console.WriteLine("Home: {0}", contract.Home.Type);
                Console.WriteLine("Home ID {0}", contract.Home.Id);
                Console.WriteLine("Contract ID {0}", contract.ContractId);
                Console.WriteLine("Address: {0}", contract.Home.Address);
                Console.WriteLine("Initial Date: " + contract.StartDate.ToString("dd/MM/yyyy"));
                Console.WriteLine("Final Date: " + contract.EndDate.ToString("dd/MM/yyyy"));
                Console.WriteLine("Clientname Name: {0}", contract.ClientName);
                Console.WriteLine("Clientname Id: {0}", contract.ClientId);
                Console.WriteLine("Cost: {0}", contract.Cost);
                Console.WriteLine("- - - - - - - - - -");
            }
        }
    }
}
