/*
 * Landlord.cs
 * 
 * Carlos Brandão - a26025@alunos.ipca.pt
 * Pedro Carneiro - a26027@alunos.ipca.pt
 * 15-11-2023
 * POO - ESI
 * Class that describes a Landlord
*/

using ManageHomes;
using OperationsContracts;
using ManagePayment;
using ManageReceipts;
using ManageReviews;

namespace ManageLandlords
{
    /// <summary>
    /// Represents a Landlord.
    /// </summary>
    internal class Landlord
    {
        #region Attributes

        private int landlordId;
        private Home home;
        private Contract contract;
        private Receipt receipt;
        private Review review;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Landlord"/> class.
        /// </summary>
        /// <param name="landlordId">The Landlord ID.</param>
        /// <param name="home">The associated home.</param>
        /// <param name="contract">The associated contract.</param>
        /// <param name="receipt">The associated receipt.</param>
        /// <param name="review">The resident's review.</param>
        public Landlord(int landlordId, Home home, Contract contract, Receipt receipt, Review review)
        {
            LandlordId = landlordId;
            Home = home;
            Contract = contract;
            Receipt = receipt;
            Review = review;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the Landlord ID.
        /// </summary>
        public int LandlordId
        {
            get { return landlordId; }
            set { landlordId = value; }
        }

        /// <summary>
        /// Gets or sets the associated home.
        /// </summary>
        public Home Home
        {
            get { return home; }
            set { home = value; }
        }

        /// <summary>
        /// Gets or sets the associated contract.
        /// </summary>
        public Contract Contract
        {
            get { return contract; }
            set { contract = value; }
        }

        /// <summary>
        /// Gets or sets the associated receipt.
        /// </summary>
        public Receipt Receipt
        {
            get { return receipt; }
            set { receipt = value; }
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
    }
}
