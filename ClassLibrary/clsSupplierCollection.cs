using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsSupplierCollection
    {
        public clsSupplierCollection()
        {
            // create items of test data
            clssupplier TestItem = new clssupplier();
            //set properties
            TestItem.CurrentSupplier = true;
            TestItem.SupplierID = 1;
            TestItem.SupplierName = "Nike";
            TestItem.SupplierSince = DateTime.Now.Date;
            TestItem.SupplierAddress = "11 Stret";
            TestItem.ContactNumber = "098765432";
            mSupplierList.Add(TestItem);

            //re initialise the object for new data
            TestItem = new clssupplier();
            //Set properties
            TestItem.CurrentSupplier = true;
            TestItem.SupplierID = 2;
            TestItem.SupplierName = "Adiddas";
            TestItem.SupplierSince = DateTime.Now.Date;
            TestItem.SupplierAddress = "11 Different Street";
            TestItem.ContactNumber = "04567890";
            mSupplierList.Add(TestItem);
        }

        List<clssupplier> mSupplierList = new List<clssupplier>();
        public List<clssupplier> SupplierList
        {
            get
            {
                return mSupplierList;
            }
            set
            {
                mSupplierList = value;
            }
        }

        public int Count
        {
            get
            {
                return mSupplierList.Count;
            }
            set
            {
                //worry about this later
            }
        }
   


        public clssupplier ThisSupplier { get; set; }
    }
}