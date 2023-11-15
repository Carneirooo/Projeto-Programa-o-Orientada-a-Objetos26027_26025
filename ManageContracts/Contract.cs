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
    /// Represents a Contract.
    /// </summary>
    public class Contract
    {
        #region Properties

        private Home home;
        private int contractId;
        private DateTime startDate;
        private DateTime endDate;
        private string clientName;
        private int clientId;
        private double cost;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the associated home.
        /// </summary>
        public Home Home
        {
            set { home = value; }
            get { return home; }
        }

        /// <summary>
        /// Gets or sets the contract ID.
        /// </summary>
        public int ContractId
        {
            set { contractId = value; }
            get { return contractId; }
        }

        /// <summary>
        /// Gets or sets the start date of the contract.
        /// </summary>
        public DateTime StartDate
        {
            set { startDate = value; }
            get { return startDate; }
        }

        /// <summary>
        /// Gets or sets the end date of the contract.
        /// </summary>
        public DateTime EndDate
        {
            set { endDate = value; }
            get { return endDate; }
        }

        /// <summary>
        /// Gets or sets the client's name.
        /// </summary>
        public string ClientName
        {
            set { clientName = value; }
            get { return clientName; }
        }

        /// <summary>
        /// Gets or sets the client ID.
        /// </summary>
        public int ClientId
        {
            set { clientId = value; }
            get { return clientId; }
        }

        /// <summary>
        /// Gets or sets the cost of the contract.
        /// </summary>
        public double Cost
        {
            set { cost = value; }
            get { return cost; }
        }

        #endregion
    
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
        
    }
}