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

        private string mSupplierSince;
        public string SupplierSince
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

        private long mContactNumber;
        public long ContactNumber
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
            mSupplierID = 21;
            mSupplierSince = "12/12/2022";
            mSupplierName = "Nike";
            mCurrentSupplier = false;
            mSupplierAddress = "Test Street";
            mContactNumber = 123456789;

            return true;
        }
    }
}
