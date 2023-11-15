/*
 * Contract.cs
 * 
 * Carlos Brandão - a26025@alunos.ipca.pt
 * Pedro Carneiro - a26027@alunos.ipca.pt
 * 05-11-2023
 * POO - ESI
 * Class that describes a Contract
*/

using ManageHomes;

namespace OperationsContracts
{
    /// <summary>
    /// Class to represent a Contract
    /// </summary>
    public class Contract
    {
        #region ATRIBUTES

        private Home home;
        private int contractId;
        private DateTime startDate;
        private DateTime endDate;
        private string clientName;
        private int clientId;
        private double cost;

        #endregion

        #region METHODS

        #region BUILDERS

        #endregion

        #region PROPERTIES
        public Home Home
        {
            set
            {
                home = value;
            }
            get
            {
                return home;
            }
        }
        public int ContractId
        {
            set
            {
                contractId = value;
            }
            get
            {
                return contractId;
            }
        }
        public DateTime StartDate
        {
            set
            {
                startDate = value;
            }
            get
            {
                return startDate;
            }
        }
        public DateTime EndDate
        {
            set
            {
                endDate = value;
            }
            get
            {
                return endDate;
            }
        }
        public string ClientName
        {
            set
            {
                clientName = value;
            }
            get
            {
                return clientName;
            }
        }
        public int ClientId
        {
            set
            {
                clientId = value;
            }
            get
            {
                return clientId;
            }
        }
        public double Cost
        {
            set
            {
                cost = value;
            }
            get
            {
                return cost;
            }
        }


        /// <summary>
        /// Contract class constructor
        /// </summary>
        /// <param Home="home"></param>
        /// <param Contract Id="contractId"></param>
        /// <param Initial Date="startDate"></param>
        /// <param Final Date="endDate"></param>
        /// <param Client Name="clientName"></param>
        /// <param Client Id="clientId"></param>
        /// <param Cost="cost"></param>
        public Contract(Home home, int contractId, DateTime startDate, DateTime endDate, string clientName, int clientId, double cost)
        {
            Home = home;
            ContractId = contractId;
            StartDate = startDate;
            EndDate = endDate;
            ClientName = clientName;
            ClientId = clientId;
            Cost = cost;
        }
        #endregion

        #endregion
    }
}