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
    /// <summary>
    /// Provides operations for Contracts.
    /// </summary>
    public static class OperationsContract
    {
        /// <summary>
        /// Checks if the specified home ID exists in the list of homes.
        /// </summary>
        /// <param name="idToCheck">The home ID to check.</param>
        /// <param name="homes">The list of homes.</param>
        /// <returns>True if the home ID exists; otherwise, false.</returns>
        private static bool HomeIdExists(int idToCheck, List<Home> homes)
        {
            if (idToCheck < 0)
            {
                // You may choose to throw an exception or handle it differently based on your application logic.
                return false;
            }

            return homes.Any(home => idToCheck == home.Id);
        }

        /// <summary>
        /// Adds a contract to the list of contracts.
        /// </summary>
        /// <param name="contracts">The list of contracts.</param>
        /// <param name="homes">The list of homes.</param>
        /// <param name="homeId">The ID of the home.</param>
        /// <param name="contractId">The ID of the contract.</param>
        /// <param name="startDate">The start date of the contract.</param>
        /// <param name="endDate">The end date of the contract.</param>
        /// <param name="clientName">The client's name.</param>
        /// <param name="clientId">The client's ID.</param>
        /// <param name="cost">The cost of the contract.</param>
        /// <returns>True if the contract is added successfully; otherwise, false.</returns>
        public static bool AddContract(List<Contract> contracts, List<Home> homes, int homeId, int contractId, DateTime startDate, DateTime endDate, string clientName, int clientId, double cost)
        {
            if (HomeIdExists(homeId, homes))
            {
                Home home = homes.FirstOrDefault(h => h.Id == homeId);

                Contract contrato = new Contract(home, contractId, startDate, endDate, clientName, clientId, cost);
                contracts.Add(contrato);

                home.State = false;

                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Searches contracts by client name.
        /// </summary>
        /// <param name="contracts">The list of contracts.</param>
        /// <param name="clientName">The client name to search for.</param>
        /// <returns>The list of contracts corresponding to the client.</returns>
        public static List<Contract> SearchContractsByClient(List<Contract> contracts, string clientName)
        {
            return contracts
                .Where(contract => contract.ClientName.Equals(clientName, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        // Other methods can follow the same pattern with appropriate XML documentation.
    }
}
