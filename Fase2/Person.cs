/*
 * Person.cs
 * 
 * Carlos Brandão - a26025@alunos.ipca.pt
 * Pedro Carneiro - a26027@alunos.ipca.pt
 * 03-11-2023
 * POO - ESI
 * Class that describes a Person
 */
namespace Fase2
{
    public abstract class Person
    {
        #region ATTRIBUTES

        /// <summary>
        /// Atributes of the Person Class
        /// </summary>
        private string name;
        private int nif;

        #endregion

        #region METHODS

        #region CONSTRUCTORS

        /// <summary>
        /// Person Class Constructor
        /// </summary>
        /// <param name="name">The name of the person.</param>
        /// <param name="nif">The NIF of the person.</param>
        public Person(string name, int nif)
        {
            Name = name;
            Nif = nif;
        }

        #endregion

        #region OTHER METHODS

        #endregion

        #region PROPERTIES

        #region NIF PROPERTY

        /// <summary>
        /// Get and Set NIF
        /// </summary>
        public int Nif
        {
            get
            {
                return nif;
            }
            set
            {
                nif = value;
            }
        }

        #endregion

        #region NAME PROPERTY

        /// <summary>
        /// Get and Set Name
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        #endregion

        #endregion

        #endregion
    }
}
