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

        private bool mAvailable;
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
        private List<clsStock> mStockList;
        private clsStock mThisStock;

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


        //==================================================================================================================================================================================
        //                                                                                    Validation Methods Start
        //================================================================================================================================================================================== 


        public string Validation(string ProductCategory, 
                                 string Quantity, 
                                 string Date, 
                                 string ProductName)
        {
            DateTime DateTemp;
            // =========================  Product Category ==================================
            String Error = "";
           
                if (ProductCategory.Length == 0)
                {
                    Error += "The ProductCategory Cannot be Blank: " + "\n";
                }

                if (ProductCategory.Length > 50)
                {
                    Error += "The ProductCategory must be less than 50 characters: " + "\n";
                }

            // =========================  Quantity ==================================
                if (Quantity.Length > 5)
                {
                    Error += "The Quantity must be less than 5 characters: " + "\n";
            }
                if (Quantity.Length == 0)
                {
                    Error += "The Quantity cannot be Empty : " + "\n";
                }
      

            // =========================  DateTime =================================
            try
            {

                DateTemp = Convert.ToDateTime(Date);
                if (DateTemp < DateTime.Now.Date)
                {

                    Error += "The date cannot be in the past : " + "\n";
                }

                if (DateTemp > DateTime.Now.Date)
                {
                    Error += "The date cannot be in the future : " + "\n";
                }
            }

            catch
            {
                Error = Error + "The date was not a valid date : " + "\n";
            }

            // =========================  Product Name ==================================

            if (ProductName.Length == 0)
            {
                Error = Error + "The ProductName Cannot be Blank: " + "\n";
            }

            if (ProductName.Length > 50)
            {
                Error = Error + "The ProductName must be less than 50 characters: " + "\n";
            }
            return Error;  

        }
        //==================================================================================================================================================================================
        //                                                                                    Validation Methods End
        //================================================================================================================================================================================== 


     
     
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
        //========================= clsStockCollection

            public List<clsStock> StockList
            {
                get
                {
                    return mStockList;
                }
                set
                {
                    mStockList = value;
                }
            }
            public clsStock ThisStock
        {
            get
            {
                return mThisStock;
            }
            set
            {
                mThisStock = value;
            }
        }
        public int Count
        {
            get
            {

                return mStockList.Count;
            }
            set
            {
            }
        }
    }
}
