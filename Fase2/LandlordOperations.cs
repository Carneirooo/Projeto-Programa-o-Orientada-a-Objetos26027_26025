/*
 * LandlordOperations.cs
 * 
 * Carlos Brandão - a26025@alunos.ipca.pt
 * Pedro Carneiro - a26027@alunos.ipca.pt
 * 03-11-2023
 * POO - ESI
 * Manage landlord operations
 */

using System.Collections.Generic;
using System.Linq;

namespace Fase2
{
    internal class LandlordOperations
    {
        #region METHODS

        #region CONSTRUCTORS

        #endregion

        #region OTHER METHODS

        #region CREATE LANDLORD

        /// <summary>
        /// Method that creates a landlord
        /// </summary>
        /// <param name="name">The name of the landlord.</param>
        /// <param name="nif">The NIF of the landlord.</param>
        /// <param name="id">The unique identifier of the landlord.</param>
        /// <returns>The created landlord object.</returns>
        public static Landlord CreateLandlord(string name, int nif, int id)
        {
            Landlord landlord = new Landlord(name, nif, id);
            return landlord;
        }

        #endregion

        #region ADD LANDLORD

        /// <summary>
        /// Method that adds a landlord to the landlords list
        /// </summary>
        /// <param name="landlords">The list of landlords.</param>
        /// <param name="landlord">The landlord to be added.</param>
        /// <returns>True if the landlord was added, false if it already exists in the list.</returns>
        public bool AddLandlord(List<Landlord> landlords, Landlord landlord)
        {
            if (landlords.Contains(landlord))
            {
                return false;
            }
            else
            {
                landlords.Add(landlord);
                return true;
            }
        }

        #endregion

        #region DOES LANDLORD EXIST

        /// <summary>
        /// Method that checks if a landlord exists
        /// </summary>
        /// <param name="landlords">The list of landlords.</param>
        /// <param name="idToCheck">The ID of the landlord to check.</param>
        /// <returns>True if the landlord exists, false otherwise.</returns>
        public bool DoesLandlordExist(List<Landlord> landlords, int idToCheck)
        {
            foreach (Landlord landlord in landlords)
            {
                if (landlord.LandlordId == idToCheck)
                {
                    return true;
                }
            }
            return landlords.Any(landlord => landlord.LandlordId == idToCheck);
        }

        #endregion

        #region DELETE LANDLORD

        /// <summary>
        /// Method that deletes a landlord
        /// </summary>
        /// <param name="landlords">The list of landlords.</param>
        /// <param name="idToDelete">The ID of the landlord to delete.</param>
        /// <returns>True if the landlord was deleted, false if it was not found in the list.</returns>
        public bool DeleteLandlord(List<Landlord> landlords, int idToDelete)
        {
            foreach (Landlord landlord in landlords)
            {
                if (landlord.LandlordId == idToDelete)
                {
                    landlords.Remove(landlord);
                    return true;
                }
            }
            return false;
        }

        #endregion

        #endregion

        #region PROPERTIES

        #endregion

        #endregion
    }
}


