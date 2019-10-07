using System;

namespace ACM.BL
{
    /// <summary>
    /// 
    /// </summary>
    public class Customer
    {
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

    }
}
