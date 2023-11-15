/*
 * Review.cs
 * 
 * Carlos Brandão - a26025@alunos.ipca.pt
 * Pedro Carneiro - a26027@alunos.ipca.pt
 * 15-11-2023
 * POO - ESI
 * Class that describes a Review
*/

namespace ManageReviews
{
    /// <summary>
    /// Represents a Review.
    /// </summary>
    internal class Review
    {
        #region Attributes

        private Resident resident;
        private DateTime reviewDate;
        private string userReview;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the resident associated with the review.
        /// </summary>
        public Resident Resident
        {
            get { return resident; }
            set { resident = value; }
        }

        /// <summary>
        /// Gets or sets the date of the review.
        /// </summary>
        public DateTime ReviewDate
        {
            get { return reviewDate; }
            set { reviewDate = value; }
        }

        /// <summary>
        /// Gets or sets the user's review.
        /// </summary>
        public string UserReview
        {
            get { return userReview; }
            set { userReview = value; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Review"/> class.
        /// </summary>
        /// <param name="resident">The resident associated with the review.</param>
        /// <param name="reviewDate">The date of the review.</param>
        /// <param name="userReview">The user's review.</param>
        public Review(Resident resident, DateTime reviewDate, string userReview)
        {
            Resident = resident;
            ReviewDate = reviewDate;
            UserReview = userReview;
        }

        #endregion
    }
}
