/*
 * Resident.cs
 * 
 * Carlos Brandão - a26025@alunos.ipca.pt
 * Pedro Carneiro - a26027@alunos.ipca.pt
 * 15-11-2023
 * POO - ESI
 * Class that describes a Resident
*/

using ManagePayment;
using ManageReceipts;
using OperationsContracts;
using ManageReviews;

namespace ManageResidents
{
    /// <summary>
    /// Represents a Resident
    /// </summary>
    internal class Resident
    {
        #region ATRIBUTES

        private int nif;
        private string name;
        private Contract contract;
        private Payment paymentHistory;
        private Receipt receipt;

        #endregion

        #region METHODS

        #region CONSTRUCTORS

        #endregion

        #region OTHER METHODS

        #endregion

        #region PROPERTIES

        public int Nif
        {
            set
            {
                nif = value;
            }
            get
            {
                return nif;
            }
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public Contract Contract
        {
            set
            {
                contract = value;
            }
            get
            {
                return contract;
            }
        }
        public Payment PaymentHistory
        {
            set
            {
                paymentHistory = value;
            }
            get
            {
                return paymentHistory;
            }
        }
        public Receipt Receipt
        {
            set
            {
                receipt = value;
            }
            get
            {
                return receipt;
            }
        }
        public Review Review
        {
            get
            {
                return Review;
            }
            set
            {
                Review = value;
            }
        }

        #endregion

        /// <summary>
        /// Resident Class Constructor
        /// </summary>
        /// <param Residents NIF="nif"></param>
        /// <param Residents Name="name"></param>
        /// <param Contract="contract"></param>
        /// <param Payment History="paymentHistory"></param>
        /// <param Receipt="receipt"></param>
        public Resident(int nif, string name, Contract contract, Payment paymentHistory, Receipt receipt)
        {
            Nif = nif;
            Name = name;
            Contract = contract;
            PaymentHistory = paymentHistory;
            Receipt = receipt;
        }

        #endregion
    }
}