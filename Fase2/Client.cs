/*
 * Client.cs
 * 
 * Carlos Brandão - a26025@alunos.ipca.pt
 * Pedro Carneiro - a26027@alunos.ipca.pt
 * 15-11-2023
 * POO - ESI
 * Class that describes a Client
*/

namespace Fase2
{
    /// <summary>
    /// Represents a Client
    /// </summary>
    internal class Client : Person
    {
        #region ATRIBUTES

        private float balance;

        #endregion

        #region METHODS

        #region CONSTRUCTORS

        /// <summary>
        /// Constructs Client
        /// </summary>
        /// <param name="name"></param>
        /// <param name="nif"></param>
        /// <param name="balance"></param>
        public Client(string name, int nif, float balance) : base (name, nif)
        {
            Name = name;
            Nif = nif;
            Balance = balance;
        }

        #endregion

        #region OTHER METHODS

        #endregion

        #region PROPERTIES

        /// <summary>
        /// Get and Set Balance
        /// </summary>
        public float Balance
        {
            set
            {
                balance = value;
            }
            get
            {
                return balance;
            }
        }

        #endregion

        #endregion
    }
}