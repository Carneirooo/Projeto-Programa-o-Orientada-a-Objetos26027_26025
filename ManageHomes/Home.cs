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
        #region ATRIBUTES

        private int id;
        private string type;
        private string address;
        private bool state;

        #endregion

        #region METHODS

        #region BUILDERS

        #endregion

        #region PROPERTIES

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

        /// <summary>
        /// Home Class Constructor
        /// </summary>
        /// <param Home Id="id"></param>
        /// <param Home type="type"></param>
        /// <param Home address="address"></param>
        /// <param Home Cost="cost"></param>
        public Home(int id, string type, string address)
        {
            Id = id;
            Type = type;
            Address = address;
            State = true; //True = Available | False = Already Rented
        }

        #endregion

        #endregion
    }
}