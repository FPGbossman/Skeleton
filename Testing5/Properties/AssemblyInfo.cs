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
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StockId", StockId);
            DB.Execute("sproc_tbStock_FilterByStockId");

            if (DB.Count == 1)
            {

                mStockId = Convert.ToInt32(DB.DataTable.Rows[0]["StockId"]);
                mProductCategory = Convert.ToString(DB.DataTable.Rows[0]["ProductCategory"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Date"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);
                mProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                return true;
            }
            else
            {
                return false; 

            }
        }
           
        }
    
}