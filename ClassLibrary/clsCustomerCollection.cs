using System;
using System.Collections.Generic;

namespace ClassLibrary

{
    public class clsCustomerCollection
    {

        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();



        clsDataConnection DBNames = new clsDataConnection();

        //Int32 Index = 0;

        //Int32 RecordCount = 0;

        DB.Execute(".sproc_tblCustomer_SelectAll");
            PopulateArray(DB);

        public clsCustomerCollection()
        {
        }

        // RecordCount = DB.Count;

        /// while (Index < RecordCount)
        //{
        // clsCustomer gg = new clsCustomer();

        //   gg.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
        //   gg.CustomerFirstname = Convert.ToString(DB.DataTable.Rows[Index]["CustomerFirstname"]);
        //   gg.CustomerSurname = Convert.ToString(DB.DataTable.Rows[Index]["CustomerSurname"]);
        //   gg.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
        //   gg. CustomerDOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomerDOB"]);
        //   gg.Gender = Convert.ToString(DB.DataTable.Rows[Index]["Gender"]);
        //  mCustomerList.Add(gg);

        // Index++;


        // }

        public List<clsCustomer> CustomerList
        {
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }
        public clsCustomer ThisCustomer
        {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }

        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {

            }
        }


        public int Add()
        {
            clsDataConnection DBNames = new clsDataConnection();
            DBNames.AddParameter("@CustomerFirstname", mThisCustomer.CustomerFirstname);
            DBNames.AddParameter("@CustomerSurname", mThisCustomer.CustomerSurname);
            DBNames.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DBNames.AddParameter("@CustomerDOB", mThisCustomer.CustomerDOB);
            DBNames.AddParameter("@Gender", mThisCustomer.Gender);
            return DBNames.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            clsDataConnection DBNames = new clsDataConnection();
            DBNames.AddParameter("@CustomerID", mThisCustomer.CustomerID);

            DBNames.AddParameter("@CustomerFirstname", mThisCustomer.CustomerFirstname);
            DBNames.AddParameter("@CustomerSurname", mThisCustomer.CustomerSurname);
            DBNames.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DBNames.AddParameter("@CustomerDOB", mThisCustomer.CustomerDOB);
            DBNames.AddParameter("@Gender", mThisCustomer.Gender);


            DBNames.Execute("sproc_tblCustomer_Update");
        }
    
        public void Delete()
        {
            clsDataConnection DBNames = new clsDataConnection();

            DBNames.AddParameter("@CustomerID", mThisCustomer.CustomerID);

            DBNames.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByCustomername(string CustomerFirstname)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerFirstname", CustomerFirstname);            
            DB.Execute("sproc_tblCustomer_FilterByCustomerName");
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;

            Int32 RecordCount;

            RecordCount = DB.Count;

            mCustomerList = new List<clsCustomer>();



            while (Index < RecordCount)
            {
                clsCustomer gg = new clsCustomer();

                gg.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                gg.CustomerFirstname = Convert.ToString(DB.DataTable.Rows[Index]["CustomerFirstname"]);
                gg.CustomerSurname = Convert.ToString(DB.DataTable.Rows[Index]["CustomerSurname"]);
                gg.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                gg.CustomerDOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomerDOB"]);
                gg.Gender = Convert.ToString(DB.DataTable.Rows[Index]["Gender"]);


                mCustomerList.Add(gg);

                Index++;


            }
        }
    }
}

    







