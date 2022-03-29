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

        public string Valid(string productCategory, int quantity, DateTime date, string available, string productName)
        {

            String Error = " ";
            // =============== ProductCategory ===================

            if (string.IsNullOrEmpty(ProductCategory))
            {
                Error += $"ProductCategory is Null or Empty!\n";
            }










            else
            {
                if (ProductCategory.Length < 1)
                {
                    Error += $"ProductCategory:{ProductCategory} is less than 2 characters!\n";

                }
                if (ProductCategory.Length > 50)
                {
                    Error += $"ProductCategory:{ProductCategory} is greater than 50 characters!\n";
                }
            }

            // =============== Quantity ===================
            if (Quantity < 0)
            {
                Error += $"Quantity is Null or Empty!\n";
            }
            if (Quantity > 1000)
            {
                Error += $"Quantity cannot be more than 1000!\n";
            }

            // =============== Date ===================
            if (Date.GetType() != new DateTime().GetType())
            {
                Error += $"timeOfOrder is not the correct data type.";
            }
            else
            {
                if (DateTime.Now < Date)
                {
                    Error += $"timeOfOrder:{Date.ToString("dd/mm/yy")} is in the future!\n";
                }
                if (Date < Convert.ToDateTime("1/1/2022"))
                {
                    Error += $"timeOfOrder:{Date.ToString("dd/mm/yy")} is too far in the past!\n";
                }
            }

            // =============== Available ===================
            //For Available, i am using drop down menu hence customer will submit the form by available by default.
            //Hence, i do not need any validation for that. 


            // =============== ProductName ===================
            if (string.IsNullOrEmpty(ProductName))
            {
                Error += $"address is Null or Empty!\n";
            }
            else
            {
                if (ProductName.Length < 10)
                {
                    Error += $"ProductName:{ProductCategory} is less than 2 characters!\n";

                }
                if (ProductCategory.Length > 50)
                {
                    Error += $"ProductName:{ProductCategory} is greater than 50 characters!\n";
                }
            }

            return Error;
        }
    }
}
