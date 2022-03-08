using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;


namespace class_Library
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



        //=======================

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
        //===========================


        private Int32 mQuantity;
        public int Quantity
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

        //===========================


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


        //============================
        private Boolean mAvailable;
        public Boolean Available { 
          
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

        //===================================
        public bool Find(int StockId)
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



