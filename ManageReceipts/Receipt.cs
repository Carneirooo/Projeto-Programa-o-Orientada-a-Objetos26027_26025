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
    /// Represents a Receipt
    /// </summary>
    internal class Receipt
    {
        #region ATRIBUTES

        private int receiptId;
        private int contractId;
        private DateTime paymentDate;
        private string observations;

        #endregion

        #region METHODS

        #region CONSTRUCTORS

        #endregion

        #region OTHER METHODS

        #endregion

        #region PROPERTIES

        public int ReceiptId
        {
            set
            {
                receiptId = value;
            }
            get
            {
                return receiptId;
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
        public DateTime PaymentDate
        {
            set
            {
                paymentDate = value;
            }
            get
            {
                return paymentDate;
            }
        }
        public string Observations
        {
            set
            {
                observations = value;
            }
        get
            {
                return observations;
            }
        }

        #endregion

        /// <summary>
        /// Receipt Class Constructor
        /// </summary>
        /// <param Receipt Id="receiptId"></param>
        /// <param Contract Id="contractId"></param>
        /// <param Payment Date="paymentDate"></param>
        /// <param Extra information added to receipt="observations"></param>
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
