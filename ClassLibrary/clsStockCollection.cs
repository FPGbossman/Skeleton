using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        List<clsStock> mStockList = new List<clsStock>();
        clsStock mThisStock = new clsStock();

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

        public clsStockCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tbStock_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsStock AStock = new clsStock();
                AStock.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                AStock.StockId = Convert.ToInt32(DB.DataTable.Rows[Index]["StockId"]);
                AStock.ProductCategory = Convert.ToString(DB.DataTable.Rows[Index]["ProductCategory"]);
                AStock.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AStock.Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Date"]);
                AStock.ProductName = Convert.ToString(DB.DataTable.Rows[Index]["ProductName"]);
                mStockList.Add(AStock);
                Index++;
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

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            
            DB.AddParameter("@ProductCategory", mThisStock.ProductCategory);
            DB.AddParameter("@Quantity", mThisStock.Quantity);
            DB.AddParameter("@Date", mThisStock.Date);
            DB.AddParameter("@Available", mThisStock.Available);
            DB.AddParameter("@ProductName", mThisStock.ProductName);

            return DB.Execute("sproc_tbStock_Insert");
        }

        public void Update()
        {
            //Updates an existing record to  the database based on the values of ThisSupplier
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set parameters for the stored procedure

            DB.AddParameter("@StockId", mThisStock.StockId);
            DB.AddParameter("@ProductCategory", mThisStock.ProductCategory);
            DB.AddParameter("@Quantity", mThisStock.Quantity);
            DB.AddParameter("@Date", mThisStock.Date);
            DB.AddParameter("@Available", mThisStock.Available);
            DB.AddParameter("@ProductName", mThisStock.ProductName);

            //execute the querry returnining the primary key value
            DB.Execute("sproc_tbStock_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            //set parameters for the stored procedure
            DB.AddParameter("@StockId", mThisStock.StockId);
            //execute the querry returnining the primary key value
            DB.Execute("sproc_tbStock_Delete");
        }

        public void ReportbyProductName(string ProductName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductName", ProductName);
            DB.Execute("sproc_tbStock_FilterProductName");
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mStockList = new List<clsStock>();

            while (Index < RecordCount)
            {
                clsStock AStock = new clsStock();

                AStock.StockId = Convert.ToInt32(DB.DataTable.Rows[Index]["StockId"]);
                AStock.ProductName = Convert.ToString(DB.DataTable.Rows[Index]["ProductName"]);
                AStock.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AStock.ProductCategory = Convert.ToString(DB.DataTable.Rows[Index]["ProductCategory"]);
                AStock.Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Date"]);
                AStock.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);

                mStockList.Add(AStock);
                Index++;
            }
        }
    }
}