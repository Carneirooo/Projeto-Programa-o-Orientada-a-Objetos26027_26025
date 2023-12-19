/*
 * PersonOperations.cs
 * 
 * Carlos Brandão - a26025@alunos.ipca.pt
 * Pedro Carneiro - a26027@alunos.ipca.pt
 * 03-11-2023
 * POO - ESI
 * Manage home operations
 */
using System;

namespace Fase2
{
    internal class HomeOperations
    {
        #region METHODS

        #region VALIDATE NIF

        /// <summary>
        /// Validates a NIF (Número de Identificação Fiscal).
        /// </summary>
        /// <param name="person">The person with the NIF to validate.</param>
        /// <returns>True if the NIF is valid; otherwise, false.</returns>
        public static bool ValidateNif(Person person)
        {
            // Simplified NIF validation (assuming a valid NIF has 9 digits)
            if (person.Nif >= 100000000 && person.Nif <= 999999999)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #endregion
    }
}

