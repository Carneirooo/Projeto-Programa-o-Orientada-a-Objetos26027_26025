/*
 * Payment.cs
 * 
 * Carlos Brandão - a26025@alunos.ipca.pt
 * Pedro Carneiro - a26027@alunos.ipca.pt
 * 15-11-2023
 * POO - ESI
 * Class that describes a Payment
*/

using System;

namespace ManagePayment
{
    /// <summary>
    /// Represents a Payment.
    /// </summary>
    public class Payment
    {
        #region Attributes

        private float[] paymentHistory;
        private DateTime paymentDate;
        private string paymentMethod;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Payment"/> class.
        /// </summary>
        /// <param name="paymentHistory">The payment history.</param>
        /// <param name="paymentDate">The payment date.</param>
        /// <param name="paymentMethod">The payment method.</param>
        public Payment(float[] paymentHistory, DateTime paymentDate, string paymentMethod)
        {
            PaymentHistory = paymentHistory;
            PaymentDate = paymentDate;
            PaymentMethod = paymentMethod;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the payment history.
        /// </summary>
        public float[] PaymentHistory
        {
            set { paymentHistory = value; }
            get { return paymentHistory; }
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
        /// Gets or sets the payment method.
        /// </summary>
        public string PaymentMethod
        {
            set { paymentMethod = value; }
            get { return paymentMethod; }
        }

        #endregion
    }
}
