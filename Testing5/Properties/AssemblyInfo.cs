using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("Testing5")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("Testing5")]
[assembly: AssemblyCopyright("Copyright ©  2022")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: ComVisible(false)]

[assembly: Guid("6b836712-3706-49e8-a57e-add4149d788b")]

// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

namespace ClassLibrary
{
    class clsStock
    {
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

        public string ProductCategory { get;  set; }

        public bool Available { get;  set; }

        public string ProductName { get;  set; }
        public int Quantity { get;  set; }
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

        public bool Find(string productCategory)
        {
            return true;
        }

        internal bool Find(int stockId)
        {
            mStockId = 1001;
            mProductCategory = "Nike Air Max 90";
            mQuantity = 12;
            mDate = Convert.ToDateTime("09/03/2022");
            mAvailable = true;
            mProductName = "Nike";
            return true;

        }
    }
} 
    