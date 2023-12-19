/*
 * ReviewOperations.cs
 * 
 * Carlos Brandão - a26025@alunos.ipca.pt
 * Pedro Carneiro - a26027@alunos.ipca.pt
 * 03-11-2023
 * POO - ESI
 * Manage review operations
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Fase2DLL
{
    internal class ReviewOperations
    {
        #region ATTRIBUTES

        // No attributes in this class

        #endregion

        #region CONSTRUCTORS

        // No constructors in this class

        #endregion

        #region METHODS

        #region CREATE REVIEW

        /// <summary>
        /// Method that creates a review.
        /// </summary>
        /// <param name="reviewId"></param>
        /// <param name="homeId"></param>
        /// <param name="clientId"></param>
        /// <param name="landlordId"></param>
        /// <param name="timeOfReview"></param>
        /// <param name="stars"></param>
        /// <param name="reviewText"></param>
        /// <returns></returns>
        public static Review CreateReview(int reviewId, int homeId, int clientId, int landlordId, DateTime timeOfReview, int stars, string reviewText)
        {
            Review review = new Review(reviewId, homeId, clientId, landlordId, timeOfReview, stars, reviewText);
            return review;
        }

        #endregion

        #region CHECK STARS

        /// <summary>
        /// Method that checks if the stars are between 0 and 5.
        /// </summary>
        /// <param name="review"></param>
        /// <returns></returns>
        public Review CheckStars(Review review)
        {
            if (review.Stars < 0)
            {
                review.Stars = 0;
            }
            if (review.Stars > 5)
            {
                review.Stars = 5;
            }

            return review;
        }

        #endregion

        #region ADD REVIEW

        /// <summary>
        /// Method that adds a review to the reviews list.
        /// </summary>
        /// <param name="reviews"></param>
        /// <param name="review"></param>
        /// <returns></returns>
        public static bool AddReview(List<Review> reviews, Review review)
        {
            if (reviews.Contains(review))
            {
                return false;
            }
            else
            {
                reviews.Add(review);
                return true;
            }
        }

        #endregion

        #region DOES REVIEW EXIST

        /// <summary>
        /// Method that checks if a review already exists.
        /// </summary>
        /// <param name="reviews"></param>
        /// <param name="idToCheck"></param>
        /// <returns></returns>
        public static bool DoesReviewExist(List<Review> reviews, int idToCheck)
        {
            foreach (Review review in reviews)
            {
                if (review.ReviewId == idToCheck)
                {
                    return true;
                }
            }
            return reviews.Any(review => review.ReviewId == idToCheck);
        }

        #endregion

        #region EDIT REVIEW

        /// <summary>
        /// Method that edits a review's description.
        /// </summary>
        /// <param name="reviews"></param>
        /// <param name="idToEdit"></param>
        /// <param name="reviewText"></param>
        /// <returns></returns>
        public bool EditReview(List<Review> reviews, int idToEdit, string reviewText)
        {
            foreach (Review review in reviews)
            {
                if (review.ReviewId == idToEdit)
                {
                    review.ReviewText = reviewText;
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region DELETE REVIEW

        /// <summary>
        /// Method that deletes a review.
        /// </summary>
        /// <param name="reviews"></param>
        /// <param name="idToDelete"></param>
        /// <returns></returns>
        public bool DeleteReview(List<Review> reviews, int idToDelete)
        {
            foreach (Review review in reviews)
            {
                if (review.ReviewId == idToDelete)
                {
                    reviews.Remove(review);
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region SAVE REVIEWS TO FILE

        /// <summary>
        /// Method that saves reviews to a file.
        /// </summary>
        /// <param name="reviews"></param>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static bool SaveReviewsToFile(List<Review> reviews, string filePath)
        {
            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, reviews);
                }

                return true;
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new UnauthorizedAccessException($"Error: Unauthorized access to the file. {ex.Message}", ex);
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new DirectoryNotFoundException($"Error

