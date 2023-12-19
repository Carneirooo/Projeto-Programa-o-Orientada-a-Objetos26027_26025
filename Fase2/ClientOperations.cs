/*
 * ClientOperations.cs
 * 
 * Carlos Brandão - a26025@alunos.ipca.pt
 * Pedro Carneiro - a26027@alunos.ipca.pt
 * 15-11-2023
 * POO - ESI
 * Manages client operations
 */

using System;

namespace Fase2
{
    /// <summary>
    /// Provides operations for managing clients.
    /// </summary>
    internal class ClientOperations
    {
        #region DEPOSIT

        /// <summary>
        /// Deposits a specified amount into the client's account.
        /// </summary>
        /// <param name="client">The client to deposit money into.</param>
        /// <param name="amount">The amount to deposit.</param>
        /// <exception cref="ArgumentException">Thrown when the amount is not greater than zero.</exception>
        public static void Deposit(Client client, float amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("The deposit amount must be bigger than zero.", nameof(amount));
            }

            client.Balance += amount;
        }

        #endregion

        #region CHECK BALANCE

        /// <summary>
        /// Checks the current balance of the client's account.
        /// </summary>
        /// <param name="client">The client to check the balance for.</param>
        /// <returns>The current balance of the client's account.</returns>
        public static float CheckBalance(Client client)
        {
            return client.Balance;
        }

        #endregion
    }
}
