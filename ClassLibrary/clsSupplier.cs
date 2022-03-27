using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clssupplier
    {
        private Int32 mSupplierID;
        public Int32 SupplierID
        {
            get
            {
                return mSupplierID;
            }
            set
            {
                mSupplierID = value;
            }
        }

        private DateTime mSupplierSince;
        public DateTime SupplierSince
        {
            get
            {
                return mSupplierSince;
            }
            set
            {
                mSupplierSince = value;
            }
        }

        private string mSupplierName;
        public string SupplierName
        {
            get
            {
                return mSupplierName;
            }
            set
            {
                mSupplierName = value;
            }

        }

        private bool mCurrentSupplier;
        public bool CurrentSupplier
        {
            get
            {
                return mCurrentSupplier;
            }
            set
            {
                mCurrentSupplier = value;
            }
        }

        private string mSupplierAddress;
        public string SupplierAddress
        {
            get
            {
                return mSupplierAddress;
            }

            set
            {
                mSupplierAddress = value;
            }
        }

        private string mContactNumber;
        public string ContactNumber
        {
            get
            {
                return mContactNumber;
            }
            set
            {
                mContactNumber = value;
            }
        }

        //==============================================================================

        public bool Find(int SupplierID)
        {

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierID", SupplierID);
            DB.Execute("sproc_tblSupplier_FilterBySupplierID");
            if (DB.Count == 1)
            {
                mSupplierID = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierID"]);
                mSupplierSince = Convert.ToDateTime(DB.DataTable.Rows[0]["SupplierSince"]);
                mSupplierName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                mCurrentSupplier = Convert.ToBoolean(DB.DataTable.Rows[0]["CurrentSupplier"]);
                mSupplierAddress = Convert.ToString(DB.DataTable.Rows[0]["SupplierAddress"]);
                mContactNumber = Convert.ToString(DB.DataTable.Rows[0]["ContactNumber"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        //==============================================================================

        public string Valid(string SupplierSince, string SupplierName, string SupplierAddress, string ContactNumber)
        {
            string Error = "";
            DateTime DateTemp;
            //Supplier Name is greater than 0 characters
            if(SupplierName.Length == 0)
            {
                Error = Error + "The Name must not be left blank";
            }
            //SupplierName is less than 50 characters
            if (SupplierName.Length> 50)
            {
                Error = Error + "Name must be less than 50 characters";
            }
            

            //SupplierSince validation
            try
            {
                DateTemp = Convert.ToDateTime(SupplierSince);

                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date entered is cannot be in the past";
                }

                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date entered is cannot be in the future";
                }
            }

            catch
            {
                Error = Error + "Not a valid date";
            }

            //Supplier Address is greater than 0 characters
            if (SupplierAddress.Length == 0)
            {
                Error = Error + "The address must not be left blank";
            }
            //Supplier Address is less than 50 characters
            if (SupplierAddress.Length > 50)
            {
                Error = Error + "Address must be less than 50 characters";
            }

            //Contact Number is greater than 0 characters
            if (ContactNumber.Length == 0)
            {
                Error = Error + "The contact number must not be left blank";
            }
            //Contact Number is less than 11 characters
            if (ContactNumber.Length > 11)
            {
                Error = Error + "Contact Number must be less than 11 characters";
            }
            return Error;
        }
    }
}
