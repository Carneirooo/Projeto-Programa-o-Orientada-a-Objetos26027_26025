/*
 * Home.cs
 * 
 * Carlos Brandão - a26025@alunos.ipca.pt
 * Pedro Carneiro - a26027@alunos.ipca.pt
 * 03-11-2023
 * POO - ESI
 * Class that describes a Home
*/

namespace ManageHomes
{
    /// <summary>
    /// Represents a Home
    /// </summary>
    public class Home
    {
        #region Attributes

        private int id;
        private string type;
        private string address;
        private bool state;

        #endregion

        #region Constructors

        /// <summary>
        /// Home Class Constructor
        /// </summary>
        /// <param name="id">Home ID.</param>
        /// <param name="type">Home type.</param>
        /// <param name="address">Home address.</param>
        public Home(int id, string type, string address)
        {
            Id = id;
            Type = type;
            Address = address;
            State = true; // True = Available | False = Already Rented
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the Home ID.
        /// </summary>
        public int Id
        {
            set { id = value; }
            get { return id; }
        }

        /// <summary>
        /// Gets or sets the Home type.
        /// </summary>
        public string Type
        {
            set { type = value; }
            get { return type; }
        }

        /// <summary>
        /// Gets or sets the Home address.
        /// </summary>
        public string Address
        {
            set { address = value; }
            get { return address; }
        }

        /// <summary>
        /// Gets or sets the Home state (availability).
        /// True = Available, False = Already Rented
        /// </summary>
        public bool State
        {
            set { state = value; }
            get { return state; }
        }

        #endregion
    }
}
