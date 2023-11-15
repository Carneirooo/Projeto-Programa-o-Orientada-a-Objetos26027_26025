/*
 * Receipt.cs
 * 
 * Carlos Brandão - a26025@alunos.ipca.pt
 * Pedro Carneiro - a26027@alunos.ipca.pt
 * 15-11-2023
 * POO - ESI
 * Class that describes a Receipt
*/

namespace ManageReceipts
{
    /// <summary>
    /// Represents a Receipt.
    /// </summary>
    internal class Receipt
    {
        #region Attributes

        private int receiptId;
        private int contractId;
        private DateTime paymentDate;
        private string observations;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the receipt ID.
        /// </summary>
        public int ReceiptId
        {
            set { receiptId = value; }
            get { return receiptId; }
        }

        /// <summary>
        /// Gets or sets the associated contract ID.
        /// </summary>
        public int ContractId
        {
            set { contractId = value; }
            get { return contractId; }
        }

        /// <summary>
        /// Gets or sets the payment date.
        /// </summary>
        public DateTime PaymentDate
        {
            set { paymentDate = value; }
            get { return paymentDate; }
        }

        /// <summary>
        /// Gets or sets extra information added to the receipt.
        /// </summary>
        public string Observations
        {
            set { observations = value; }
            get { return observations; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Receipt"/> class.
        /// </summary>
        /// <param name="receiptId">The receipt ID.</param>
        /// <param name="contractId">The associated contract ID.</param>
        /// <param name="paymentDate">The payment date.</param>
        /// <param name="observations">Extra information added to receipt.</param>
        public Receipt(int receiptId, int contractId, DateTime paymentDate, string observations)
        {
            ReceiptId = receiptId;
            ContractId = contractId;
            PaymentDate = paymentDate;
            Observations = observations;
        }

        #endregion
    }
}
