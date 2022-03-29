using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ClassLibrary
{

    public class clsStock
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

        //==================================================================================================================================================================================
        //                                                                                    Validation Methods Start
        //================================================================================================================================================================================== 


        public string Validation(string ProductCategory, 
                                 string Quantity, 
                                 string Date, 
                                 string ProductName)
        {

            // =========================  Product Category ==================================
            String Error = "";
           
                if (ProductCategory.Length == 0)
                {
                    Error = Error + "The ProductCategory Cannot be Blank: ";
                }

                if (ProductCategory.Length > 50)
                {
                    Error = Error + "The ProductCategory must be less than 50 characters: ";
                }

            // =========================  DateTime =================================
            try
            {

                DateTemp = Convert.ToDateTime(Date);
                if (DateTemp < DateTime.Now.Date)
                {

                    Error = Error + "The date cannot be in the past : ";
                }

                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }

            catch
            {
                Error = Error + "The date was not a valid date : ";
            }
            // =========================  Product Name ==================================

            if (ProductName.Length == 0)
            {
                Error = Error + "The ProductName Cannot be Blank: ";
            }

            if (ProductName.Length > 50)
            {
                Error = Error + "The ProductName must be less than 50 characters: ";
            }
            return Error;  

        }
        //==================================================================================================================================================================================
        //                                                                                    Validation methods End
        //================================================================================================================================================================================== 


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

        private String mAvailable;
        public String Available
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

        public DateTime DateTemp { get; private set; }

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
                mAvailable = Convert.ToString(DB.DataTable.Rows[0]["Available"]);
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
