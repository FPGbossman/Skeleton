﻿using System;
using System.Collections;
using System.Linq;



namespace ClassLibrary
{
    public class clsStaff
    {


        public string staffFullname;
        public Int32 staffId;
        public DateTime startDate;
        public bool availability;
        public string staffRole;
        public string CustomerID;
        public string tbstaffFullname;

        public bool Find(int staffId)
        {
            throw new NotImplementedException();
        }

        private Int32 mstaffId;
        public int staffId
        {

            get
            { 
                return mstaffId;
            }
            set 
            {
                 mstaffId = value;
            }
        }
 
        private DateTime mstartDate;
        public DateTime startDate
        {
            get
            {
                return mstartDate;
            }
            set
            {
                mstartDate = value;
            }
        }

        private string mstaffFullname;
        public string staffFullname
        {
            get
            {
                return mstaffFullname;
            }
            set
            {
                mstaffFullname = value;
            }
        }

        private Boolean mavailability;
        public bool availability
        {
            get
            { 
                return mavailability;
            }   
            set
            { 
                mavailability = value;
            }
        }
        
        private string mstaffRole;
        public string staffRole
        {
            get
            { 
                return mstaffRole;
            }
            set
            {
                mstaffRole = value;
            }
        }
        
        public bool Find(int staffId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@staffId", staffId);
            DB.Execute("sproc_tblstaffId_FilterBystaffId");
            if (DB.Count == 1)
            {
                mstaffId = Convert.ToInt(DB.DataTable.Rows[0]["staffId"]);
                mstaffFullname = Convert.ToString(DB.DataTable.Rows[0]["staffFullname"]);
                mstaffRole = Convert.ToString(DB.DataTable.Rows[0]["staffRole"]);
                mstartDate = Convert.ToDateTime(DB.DataTable.Rows[0]["startDate"]);
                mavailability = Convert.ToBoolean(DB.DataTable.Rows[0]["availability"])
                return true;
            }
            else
            {
                return false;
            }
        }
        //===================================================================================================================================================
        //===================================================================================================================================================
        public string Valid(string staffId, string staffFullname, string staffRole, string availability, string startDate)
        {
            String Error = "";
            startDate DateTemp;
            if (staffId.Length == 0)
            {
                Error = Error + "The staff id may not be blank : ";
            }
            if (staffId.Length > 6)
            {
                Error = Error + "The staff id must be less than 6 characters : ";
            }

            //validation for start date
            try {
                DateTemp = Convert.ToDateTime(startDate);
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
                Error = Error + "Not a valid date";
            }

            if (staffFullname.Length == 0)
            {
                Error = Error + "The staffFullname must not be blank : ";
            }
            if (staffFullname.Length > 20)
            {
                Error = Error + "The staffFullname must be less than 20 letters : ";
            }
            if (staffRole.Length == 0)
            {
                Error = Error + "The staffRole must not be blank : ";
            }
            if (staffRole.Length > 50) 
            {
                Error = Error + "The staffRole must be less than 50 characters ; ")
            }
        }
    }
}

