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
    /// Represents a Landlord
    /// </summary>
    internal class Landlord
    {
        #region ATRIBUTES

        private int landlordId;
        private Home home;
        private Contract contract;
        private Receipt receipt;
        private Review review;

        #endregion

        #region METHODS

        #region CONSTRUCTORS

        #endregion

        #region OTHER METHODS

        #endregion

        #region PROPERTIES

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
        public Home Home
        {
            get
            {
                return home;
            }
            set
            {
                home = value;
            }
        }
        public Contract Contract
        {
            get
            {
                return contract;
            }
            set
            {
                contract = value;
            }
        }
        public Receipt Receipt
        {
            get
            {
                return receipt;
            }
            set
            {
                receipt = value;
            }
        }
        public Review Review
        {
            get
            {
                return review;
            }
            set
            {
                review = value;
            }
        }

        #endregion

        /// <summary>
        /// Landlord Class Constructor
        /// </summary>
        /// <param Landlords Id="landlordId"></param>
        /// <param Home="home"></param>
        /// <param Contract="contract"></param>
        /// <param Receipt="receipt"></param>
        /// <param Resident's Review="review"></param>
        public Landlord(int landlordId, Home home, Contract contract, Receipt receipt, Review review)
        {
            LandlordId =landlordId;
            Home = home;
            Contract = contract;
            Receipt = receipt;
            Review = review;
        }

        #endregion
    }
}
