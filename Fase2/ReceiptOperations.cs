/*
 * ReceiptOperations.cs
 * 
 * Carlos Brandão - a26025@alunos.ipca.pt
 * Pedro Carneiro - a26027@alunos.ipca.pt
 * 03-11-2023
 * POO - ESI
 * Manage home operations
*/
using System;
using System.Collections.Generic;

namespace Fase2
{
    internal class ReceiptOperations
    {
        #region ATRIBUTES

        #endregion

        #region METHODS

        #region CONSTRUCTORS

        #endregion

        #region OTHER METHODS

        /// <summary>
        /// Method that creates a receipt
        /// </summary>
        /// <param name="receiptId"></param>
        /// <param name="contractId"></param>
        /// <param name="clientId"></param>
        /// <param name="landlordId"></param>
        /// <param name="paymentDate"></param>
        /// <param name="observations"></param>
        /// <returns></returns>
        public static Receipt CreateReceipt(int receiptId, int contractId, int clientId, int landlordId, DateTime paymentDate, string observations)
        {
            Receipt receipt = new Receipt(receiptId, contractId, clientId, landlordId, paymentDate, observations);
            return (receipt);
        }

        /// <summary>
        /// Method that adds a receipt to the receipts list
        /// </summary>
        /// <param name="receipts"></param>
        /// <param name="receipt"></param>
        /// <returns></returns>
        public bool AddReceipt(List<Receipt> receipts, Receipt receipt)
        {
            bool added = false;
            if (receipt != null)
            {
                receipts.Add(receipt);
                added = true;
            }
            return (added);
        }

        /// <summary>
        /// Method that checks if a receipt exists
        /// </summary>
        /// <param name="receipts"></param>
        /// <param name="idToCheck"></param>
        /// <returns></returns>
        public bool DoesReceiptExist(List<Receipt> receipts, int idToCheck)
        {
            bool exists = false;
            foreach (Receipt receipt in receipts)
            {
                if (receipt.ReceiptId == idToCheck)
                {
                    exists = true;
                }
            }
            return (exists);
        }

        /// <summary>
        /// Method that gets a receipt
        /// </summary>
        /// <param name="receipts"></param>
        /// <param name="idToCheck"></param>
        /// <returns></returns>
        public Receipt GetReceipt(List<Receipt> receipts, int idToCheck)
        {
            Receipt receipt = null;
            foreach (Receipt receiptToCheck in receipts)
            {
                if (receiptToCheck.ReceiptId == idToCheck)
                {
                    receipt = receiptToCheck;
                }
            }
            return (receipt);
        }

        /// <summary>
        /// Method that deletes a receipt
        /// </summary>
        /// <param name="receipts"></param>
        /// <param name="idToCheck"></param>
        /// <returns></returns>
        public bool DeleteReceipt(List<Receipt> receipts, int idToCheck)
        {
            bool deleted = false;
            foreach (Receipt receipt in receipts)
            {
                if (receipt.ReceiptId == idToCheck)
                {
                    receipts.Remove(receipt);
                    deleted = true;
                }
            }
            return (deleted);
        }

        #endregion

        #region PROPERTIES

        #endregion

        #endregion
    }
}
