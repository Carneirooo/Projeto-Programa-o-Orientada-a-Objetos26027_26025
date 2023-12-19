/*
 * Review.cs
 * 
 * Carlos Brandão - a26025@alunos.ipca.pt
 * Pedro Carneiro - a26027@alunos.ipca.pt
 * 18-12-2023
 * POO - ESI
 * Class that describes a review
 */
using System;

namespace Fase2DLL
{
    internal class Review
    {
        #region ATTRIBUTES

        private int reviewId;
        private int homeId;
        private int clientId;
        private int landlordId;
        private DateTime timeOfReview;
        private int stars;
        private string reviewText;

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Initializes a new instance of the <see cref="Review"/> class.
        /// </summary>
        /// <param name="reviewId">The ID of the review.</param>
        /// <param name="homeId">The ID of the associated home.</param>
        /// <param name="clientId">The ID of the client who submitted the review.</param>
        /// <param name="landlordId">The ID of the landlord associated with the home.</param>
        /// <param name="timeOfReview">The time the review was submitted.</param>
        /// <param name="stars">The number of stars given in the review.</param>
        /// <param name="reviewText">The text of the review.</param>
        public Review(int reviewId, int homeId, int clientId, int landlordId, DateTime timeOfReview, int stars, string reviewText)
        {
            ReviewId = reviewId;
            HomeId = homeId;
            ClientId = clientId;
            LandlordId = landlordId;
            TimeOfReview = timeOfReview;
            Stars = stars;
            ReviewText = reviewText;
        }

        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets the ID of the review.
        /// </summary>
        public int ReviewId
        {
            set { reviewId = value; }
            get { return reviewId; }
        }

        /// <summary>
        /// Gets or sets the ID of the associated home.
        /// </summary>
        public int HomeId
        {
            set { homeId = value; }
            get { return homeId; }
        }

        /// <summary>
        /// Gets or sets the ID of the client who submitted the review.
        /// </summary>
        public int ClientId
        {
            set { clientId = value; }
            get { return clientId; }
        }

        /// <summary>
        /// Gets or sets the ID of the landlord associated with the home.
        /// </summary>
        public int LandlordId
        {
            set { landlordId = value; }
            get { return landlordId; }
        }

        /// <summary>
        /// Gets or sets the time the review was submitted.
        /// </summary>
        public DateTime TimeOfReview
        {
            set { timeOfReview = value; }
            get { return timeOfReview; }
        }

        /// <summary>
        /// Gets or sets the number of stars given in the review.
        /// </summary>
        public int Stars
        {
            set { stars = value; }
            get { return stars; }
        }

        /// <summary>
        /// Gets or sets the text of the review.
        /// </summary>
        public string ReviewText
        {
            set { reviewText = value; }
            get { return reviewText; }
        }

        #endregion
    }
}
