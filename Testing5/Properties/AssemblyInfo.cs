using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("StockTesting")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("StockTesting")]
[assembly: AssemblyCopyright("Copyright ©  2022")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: ComVisible(false)]

[assembly: Guid("c5039f49-a6d1-4adc-ae53-7cb1c0574514")]

// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

namespace StockTesting
{
     class clsStock
    {
        private Int32 mStockId;
        public Int32 StockId
        {
            get
            {
                return mStockId;
            }
            set
            {
                mStockId = value;
            }
        }

        private string mProductCategory;
        public string ProductCategory
        {
            get
            {
                return mProductCategory;
            }
            set
            {
                mProductCategory = value; 
            }
        }

        private Int32 mQuantity;
        public Int32 Quantity
        {
            get
            {
                return mQuantity;
            }
            set
            {
                mQuantity = value;
            }
        }
        private DateTime mDate;
        public DateTime Date
        {
            get
            {
                return mDate;
            }
            set
            {
                mDate = value;
            }
        }

        private Boolean mAvailable;
        public bool Available
        {
            get
            {
                return mAvailable;
            }
            set
            {
                mAvailable = value;
            }
        }

        private string mProductName;
        public string ProductName
        {
            get
            {
                return mProductName;
            }
            set
            {
                mProductName = value;
            }
        }


        public bool Find(int StockId)
        {
            mStockId = 9;
            mProductCategory = "Ultraboost 4.0 DNA Shoes";
            mQuantity = 33;
            mDate = Convert.ToDateTime("09/03/2022");
            mAvailable = true;
            mProductName = "Addidas";
                return true;
            }
           
        }
    
}