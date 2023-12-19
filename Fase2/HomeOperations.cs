/*
 * HomeOperations.cs
 * 
 * Carlos Brandão - a26025@alunos.ipca.pt
 * Pedro Carneiro - a26027@alunos.ipca.pt
 * 03-11-2023
 * POO - ESI
 * Manage home operations
 */

using System.Collections.Generic;
using System.Linq;

namespace Fase2
{
    internal class HomeOperations
    {
        #region METHODS

        #region CONSTRUCTORS

        #endregion

        #region OTHER METHODS

        #region CREATE HOME

        /// <summary>
        /// Method that creates a home
        /// </summary>
        /// <param name="homeId">The unique identifier of the home.</param>
        /// <param name="type">The type of the home.</param>
        /// <param name="address">The address of the home.</param>
        /// <param name="state">The state of the home.</param>
        /// <returns>The created home object.</returns>
        public Home CreateHome(int homeId, string type, string address, bool state)
        {
            Home home = new Home(homeId, type, address, state);
            return home;
        }

        #endregion

        #region ADD HOME

        /// <summary>
        /// Method that adds a home to the homes list
        /// </summary>
        /// <param name="homes">The list of homes.</param>
        /// <param name="home">The home to be added.</param>
        /// <returns>True if the home was added, false if it already exists in the list.</returns>
        public bool AddHome(List<Home> homes, Home home)
        {
            if (homes.Contains(home))
            {
                return false;
            }
            else
            {
                homes.Add(home);
                return true;
            }
        }

        #endregion

        #region DOES HOME EXIST

        /// <summary>
        /// Method that checks if a home exists
        /// </summary>
        /// <param name="homes">The list of homes.</param>
        /// <param name="idToCheck">The ID of the home to check.</param>
        /// <returns>True if the home exists, false otherwise.</returns>
        public bool DoesHomeExist(List<Home> homes, int idToCheck)
        {
            foreach (Home home in homes)
            {
                if (home.Id == idToCheck)
                {
                    return true;
                }
            }
            return homes.Any(home => home.Id == idToCheck);
        }

        #endregion

        #region DELETE HOME

        /// <summary>
        /// Method that deletes a home
        /// </summary>
        /// <param name="homes">The list of homes.</param>
        /// <param name="idToCheck">The ID of the home to delete.</param>
        /// <returns>True if the home was deleted, false if it was not found in the list.</returns>
        public bool DeleteHome(List<Home> homes, int idToCheck)
        {
            foreach (Home home in homes)
            {
                if (home.Id == idToCheck)
                {
                    homes.Remove(home);
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


