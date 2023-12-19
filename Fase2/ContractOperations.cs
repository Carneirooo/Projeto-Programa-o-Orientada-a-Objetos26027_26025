/*
 * ContractOperations.cs
 * 
 * Carlos Brandão - a26025@alunos.ipca.pt
 * Pedro Carneiro - a26027@alunos.ipca.pt
 * 05-11-2023
 * POO - ESI
 * Manages contract operations
*/
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Fase2
{
    internal static class ContractOperations
    {
        /// <summary>
        /// Method that creates a Contract
        /// </summary>
        /// <param name="home"></param>
        /// <param name="contractId"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="clientName"></param>
        /// <param name="clientId"></param>
        /// <param name="landlordId"></param>
        /// <param name="cost"></param>
        /// <returns></returns>
        public static Contract CreateContract(Home home, int contractId, DateTime startDate, DateTime endDate, string clientName, int clientId, int landlordId, double cost, bool state)
        {
            if (home != null)
            {
                Contract contract = new Contract(home, contractId, startDate, endDate, clientName, clientId, landlordId, cost, state);
                return (contract);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Adds a contract to the Contracts List
        /// </summary>
        /// <param Contract List="contracts"></param>
        /// <param Home List="homes"></param>
        public static bool AddContract(List<Contract> contracts, List<Home> homes, Contract createdContract, int idToCheck)
        {
            int index = FindIndexById(idToCheck, homes);

            if (index >= 0 && index < homes.Count)
            {
                Home home = homes[index];

                contracts.Add(createdContract);
                home.State = false;

                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Method that gets the index of a Home by its ID
        /// </summary>
        /// <param name="targetId"></param>
        /// <param name="homes"></param>
        /// <returns></returns>
        private static int FindIndexById(int targetId, List<Home> homes)
        {
            for (int i = 0; i < homes.Count; i++)
            {
                if (homes[i].Id == targetId)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Lists all existing Contracts
        /// </summary>
        /// <param Contract List="contracts"></param>
        public static void ListContracts(this List<Contract> contracts)
        {
            //A solução seria writelines no entanto o professor pediu para nao utilizar//
        }
    }
}

