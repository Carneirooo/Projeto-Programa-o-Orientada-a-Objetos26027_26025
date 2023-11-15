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
using OperationsContracts;

namespace ManageResidents
{
    /// <summary>
    /// Represents a Resident.
    /// </summary>
    internal class Resident
    {
        #region Attributes

        private int nif;
        private string name;
        private Contract contract;
        private Payment paymentHistory;
        private Receipt receipt;
        private Review review;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the resident's NIF.
        /// </summary>
        public int Nif
        {
            set { nif = value; }
            get { return nif; }
        }

        /// <summary>
        /// Gets or sets the resident's name.
        /// </summary>
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        /// <summary>
        /// Gets or sets the resident's contract.
        /// </summary>
        public Contract Contract
        {
            set { contract = value; }
            get { return contract; }
        }

        /// <summary>
        /// Gets or sets the resident's payment history.
        /// </summary>
        public Payment PaymentHistory
        {
            set { paymentHistory = value; }
            get { return paymentHistory; }
        }

        /// <summary>
        /// Gets or sets the resident's receipt.
        /// </summary>
        public Receipt Receipt
        {
            set { receipt = value; }
            get { return receipt; }
        }

        /// <summary>
        /// Gets or sets the resident's review.
        /// </summary>
        public Review Review
        {
            get { return review; }
            set { review = value; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Resident"/> class.
        /// </summary>
        /// <param name="nif">The resident's NIF.</param>
        /// <param name="name">The resident's name.</param>
        /// <param name="contract">The resident's contract.</param>
        /// <param name="paymentHistory">The resident's payment history.</param>
        /// <param name="receipt">The resident's receipt.</param>
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
