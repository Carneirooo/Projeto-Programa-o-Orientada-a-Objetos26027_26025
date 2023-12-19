/*
 * Home.cs
 * 
 * Carlos Brandão - a26025@alunos.ipca.pt
 * Pedro Carneiro - a26027@alunos.ipca.pt
 * 03-11-2023
 * POO - ESI
 * Represents a Home
 */

namespace Fase2
{
    /// <summary>
    /// Represents a Home
    /// </summary>
    public class Home
    {
        #region ATTRIBUTES

        private int id;
        private string type;
        private string address;
        private bool state; //True = Available | False = Already Rented

        #endregion

        #region METHODS

        #region BUILDERS

        /// <summary>
        /// Home Class Constructor
        /// </summary>
        /// <param Home Id="id"></param>
        /// <param Home type="type"></param>
        /// <param Home address="address"></param>
        /// <param Home Cost="cost"></param>
        public Home(int id, string type, string address, bool state)
        {
            Id = id;
            Type = type;
            Address = address;
            State = true;
        }

        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets the unique identifier of the home.
        /// </summary>
        public int Id
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }

        /// <summary>
        /// Gets or sets the type of the home.
        /// </summary>
        public string Type
        {
            set
            {
                type = value;
            }
            get
            {
                return type;
            }
        }

        /// <summary>
        /// Gets or sets the address of the home.
        /// </summary>
        public string Address
        {
            set
            {
                address = value;
            }
            get
            {
                return address;
            }
        }

        /// <summary>
        /// Gets or sets the state of the home (true if available, false if already rented).
        /// </summary>
        public bool State
        {
            set
            {
                state = value;
            }
            get
            {
                return state;
            }
        }

        #endregion

        #endregion
    }
}
