using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public string CustomerFirstname;
        public string CustomerSurnamename;
        public string CustomerEmail;
        public string Gender;
        public DateTime CustomerDOB;
        public int CustomerId;

        private Int32 mCustomerID;

        public int CustomerID
        {

            get
            {

                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }

        }
        private string mCustomerFirstname;
        public string CustomerFirtname
        {

            get
            {
                return mCustomerFirtname;

            }
            set
            {
                mCustomerFirstname = value;
            }
        }
    }
    private string mCustomerSurname;
    public string CustomerSurname
    {

        get
        {
            return mCustomerSurname;

        }
        set
        {
            mCustomerSurname = value;
        }
    }
    private string mCustomerEmail;
    public string CustomerEmail
    {

        get
        {
            return mCustomerEmail;

        }
        set
        {
            mCustomerEmail = value;
        }
    }


    private DateTime mCustomerDOB;
    public DateTime CustomerDOB
    {
        get
        {
            return mCustomerDOB;
        }
        set
        {
            mCustomerDOB = value;
        }
    }

    private string mGender;
    public string Gender
    {
        get
        {
            return mGender;
        }
        set
        {
            mGender = value;
        }
    }

}
