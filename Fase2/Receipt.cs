/*
 * Receipt.cs
 * 
 * Carlos Brandão - a26025@alunos.ipca.pt
 * Pedro Carneiro - a26027@alunos.ipca.pt
 * 03-11-2023
 * POO - ESI
 * Class that describes a Receipt
 */
using System;

namespace Fase2
{
    /// <summary>
    /// Represents a Receipt
    /// </summary>
    internal class Receipt
    {
        #region ATTRIBUTES

        private int receiptId;
        private int contractId;
        private int clientId;
        private int landlordId;
        private DateTime paymentDate;
        private string observations;

        #endregion

        #region METHODS

        #region CONSTRUCTORS

        /// <summary>
        /// Initializes a new instance of the <see cref="Receipt"/> class.
        /// </summary>
        /// <param name="receiptId">The ID of the receipt.</param>
        /// <param name="contractId">The ID of the associated contract.</param>
        /// <param name="clientId">The ID of the client associated with the receipt.</param>
        /// <param name="landlordId">The ID of the landlord associated with the receipt.</param>
        /// <param name="paymentDate">The date of the payment.</param>
        /// <param name="observations">Extra information added to the receipt.</param>
        public Receipt(int receiptId, int contractId, int clientId, int landlordId, DateTime paymentDate, string observations)
        {
            ReceiptId = receiptId;
            ContractId = contractId;
            ClientId = clientId;
            LandlordId = landlordId;
            PaymentDate = paymentDate;
            Observations = observations;
        }

        #endregion

        #region OTHER METHODS

        // Incluir outros métodos, se necessário

        #endregion

        #region PROPERTIES

        #region RECEIPT ID PROPERTY

        /// <summary>
        /// Gets or sets the ID of the receipt.
        /// </summary>
        public int ReceiptId
        {
            set { receiptId = value; }
            get { return receiptId; }
        }

        #endregion

        #region CONTRACT ID PROPERTY

        /// <summary>
        /// Gets or sets the ID of the associated contract.
        /// </summary>
        public int ContractId
        {
            set { contractId = value; }
            get { return contractId; }
        }

        #endregion

        #region CLIENT ID PROPERTY

        /// <summary>
        /// Gets or sets the ID of the client associated with the receipt.
        /// </summary>
        public int ClientId
        {
            set { clientId = value; }
            get { return clientId; }
        }

        #endregion

        #region LANDLORD ID PROPERTY

        /// <summary>
        /// Gets or sets the ID of the landlord associated with the receipt.
        /// </summary>
        public int LandlordId
        {
            set { landlordId = value; }
            get { return landlordId; }
        }

        #endregion

        #region PAYMENT DATE PROPERTY

        /// <summary>
        /// Gets or sets the date of the payment.
        /// </summary>
        public DateTime PaymentDate
        {
            set { paymentDate = value; }
            get { return paymentDate; }
        }

        #endregion

        #region OBSERVATIONS PROPERTY

        /// <summary>
        /// Gets or sets extra information added to the receipt.
        /// </summary>
        public string Observations
        {
            set { observations = value; }
            get { return observations; }
        }

        #endregion

        #endregion

        #endregion
    }
}
