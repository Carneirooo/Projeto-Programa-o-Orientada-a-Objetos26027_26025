/*
 * Payment.cs
 * 
 * Carlos Brandão - a26025@alunos.ipca.pt
 * Pedro Carneiro - a26027@alunos.ipca.pt
 * 15-11-2023
 * POO - ESI
 * Class that describes a Payment
*/

namespace ManagePayment
{
    /// <summary>
    /// Represents a Payment
    /// </summary>
    public class Payment
    {
        #region ATRIBUTES

        private float[] paymentHistory;
        private DateTime paymentDate;
        private string paymentMethod;

        #endregion

        #region METHODS

        #region CONSTRUCTORS

        #endregion

        #region OTHER METHODS

        #endregion

        #region PROPERTIES

        public float[] PaymentHistory
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
        public string PaymentMethod
        { 
            set
            {
                paymentMethod = value;
            }
            get
            {
                return paymentMethod;
            }
        }
        #endregion

        /// <summary>
        /// Payment Class Constructor
        /// </summary>
        /// <param Payment History="paymentHistory"></param>
        /// <param payment Date="paymentDate"></param>
        /// <param Payment Method="paymentMethod"></param>
        public Payment(float[] paymentHistory, DateTime paymentDate, string paymentMethod)
        {
            PaymentHistory = paymentHistory;
            PaymentDate = paymentDate;
            PaymentMethod = paymentMethod;
        }

        #endregion
    }
}