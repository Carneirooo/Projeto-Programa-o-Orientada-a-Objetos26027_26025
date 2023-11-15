/*
 * Review.cs
 * 
 * Carlos Brandão - a26025@alunos.ipca.pt
 * Pedro Carneiro - a26027@alunos.ipca.pt
 * 15-11-2023
 * POO - ESI
 * Class that describes a Review
*/

using ManageResidents;

namespace ManageReviews
{
    /// <summary>
    /// Represents a Review
    /// </summary>
    internal class Review
    {
        #region ATRIBUTES

        private Resident resident;
        private DateTime reviewDate;
        private string userReview;

        #endregion

        #region METHODS

        #region CONSTRUCTORS

        #endregion

        #region OTHER METHODS

        #endregion

        #region PROPERTIES

        public Resident Resident
        {
            get
            {
                return resident;
            }
            set
            {
                resident = value;
            }
        }
        public DateTime ReviewDate
        {
            get
            {
                return reviewDate;
            }
            set
            {
                reviewDate = value;
            }
        }
        public string UserReview
        {
            get
            {
                return userReview;
            }
            set
            {
                userReview = value;
            }
        }

        #endregion

        /// <summary>
        /// Review Class Constructor
        /// </summary>
        /// <param Resident="resident"></param>
        /// <param Review Date="reviewDate"></param>
        /// <param Review="userReview"></param>
        public Review(Resident resident, DateTime reviewDate, string userReview)
        {
            Resident = resident;
            ReviewDate = reviewDate;
            UserReview = userReview;
        }

    #endregion
}
}
