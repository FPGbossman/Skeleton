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
                return mCustomerFirstname;

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
            CustomerSurname = value;
        }
    }
    private string mCustomerEmail;
    public string CustomerEmail
    {

        get
        {
            return CustomerEmail;

        }
        set
        {
            CustomerEmail = value;
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
            public bool Find(int CustomerId)
            {
                clsDataConnection DB = new clsDataConnection();

                DB.AddParameter("@CustomerId", CustomerId);

                DB.Execute("sproc_tblCustomerId_FilterbyCustomerId");

                if (DB.Count == 1)
                {
                    mCustomerID  = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                    mCustomerFirstname = Convert.ToString(DB.DataTable.Rows[0]["CustomerFirstname"]);
                    mCustomerSurname = Convert.ToString(DB.DataTable.Rows[0]["CustomerSurname"]);
                    mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                    mCustomerDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerDOB "]);
                    mGender = Convert.ToString(DB.DataTable.Rows[0]["Gender"]);
                    return true;
                }
                else
                {

                    return false;
                }

                public string Valid(string CustomerFirstname, string CustomerSurname, string CustomerEmail, string Gender)
                {

                    String Error = "";

                    DateTime DateTemp;

                    //if CustomerFirstname is blank
                    if (CustomerFirstname.Length == 0)
                    {
                        Error = Error + "Your Customer Name may not be blank";
                    }
                    if (CustomerFirstname.Length > 6)
                    {
                        Error = Error + "Your Customer Name may not be blank";
                    }
                    try
                    {
                        //copy the dateAdded value to the DateTemp variable
                        DateTemp = Convert.ToDateTime(CustomerDOB);
                        if (DateTemp < DateTime.Now.Date)
                        {
                            //record the error
                            Error = Error + "The date cannot be in the past : ";

                        }
                        if (DateTemp > DateTime.Now.Date)
                        {
                            //record the error
                            Error = Error + "The date cannot be in the future : ";
                        }
                    }

                    catch
                    {
                        //record the error
                        Error = Error + "The date was not a valid date : ";

                    }
                    if (Gender.Length == 0)
                    {
                        //record the error
                        Error = Error + "The street may not be blank : ";
                    }
                    //if the gender is too long
                    if (Gender.Length > 6)
                    {
                        //record the error
                        Error = Error + "The street must be less than 50 characters : ";
                    }


                    return Error;
                }
            }

        }
    
        
