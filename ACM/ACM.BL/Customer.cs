using System;
using System.Collections.Generic;

namespace ACM.BL
{
    /// <summary>
    /// 
    /// </summary>
    public class Customer
    {
        public Customer()
        {

        }

        public Customer(int customerId)
        {
            this.CustomerID = customerId;
        }

        public string FirstName { get; set; }

        private string _lastName;

        public string LastName
        {
            get
            {
                return this._lastName;
            }
            set
            {
                this._lastName = value;
            }
        }

        public string EmailAddress { get; set; }

        public int CustomerID { get; private set; }

        public string FullName 
        {
            get {
                return this.FirstName + ", "+ this.LastName ;
            }

        }

        public static int InstanceCount { get; set; }

        /// <summary>
        /// Validates Customer Data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(LastName))
            {
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(EmailAddress))
            {
                isValid = false;
            }

            return isValid;
        }

      
    }
}
