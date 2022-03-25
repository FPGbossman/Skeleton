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

        public string Valid(string SupplierSince, string SupplierName, string SupplierAddress, string ContactNumber)
        {
            return "";
        }
        
    }
}
