/*
 * Landlord.cs
 * 
 * Carlos Brandão - a26025@alunos.ipca.pt
 * Pedro Carneiro - a26027@alunos.ipca.pt
 * 15-11-2023
 * POO - ESI
 * Class that describes a Landlord
 */

namespace Fase2
{
    /// <summary>
    /// Represents a Landlord
    /// </summary>
    internal class Landlord : Person
    {
        #region ATTRIBUTES

        private int landlordId;

        #endregion

        #region METHODS

        #region CONSTRUCTORS

        /// <summary>
        /// Landlord Class Constructor
        /// </summary>
        /// <param name="name">The name of the landlord.</param>
        /// <param name="nif">The NIF of the landlord.</param>
        /// <param name="landlordId">The unique identifier of the landlord.</param>
        public Landlord(string name, int nif, int landlordId) : base(name, nif)
        {
            Name = name;
            Nif = nif;
            LandlordId = landlordId;
        }

        #endregion

        #region OTHER METHODS

        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets the unique identifier of the landlord.
        /// </summary>
        public int LandlordId
        {
            get
            {
                return landlordId;
            }
            set
            {
                landlordId = value;
            }
        }

        #endregion

        #endregion
    }
}
