using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();
        clsStaff mThisStaff = new clsStaff();





        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }


        public int Count
        {
            get
            {
                return mStaffList.Count;
            }
            set
            {

            }
        }

        public clsStaff ThisStaff
        {
            get
            {
                return mThisStaff;

            }
            set
            {
                mThisStaff = value;
            }
        }


        public clsStaffCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectALL");
            PopulateArray(DB);

        }

        public int Add()
        {

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffFullame", mThisStaff.staffFullname);
            DB.AddParameter("@StaffRole", mThisStaff.staffRole);
            DB.AddParameter("@StartDate", mThisStaff.startDate);
            DB.AddParameter("@Availability", mThisStaff.availability);
            return DB.Execute("Sproc_tblStaff_Insert");




        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", mThisStaff.staffId);
            DB.AddParameter("@StaffFullame", mThisStaff.staffFullname);
            DB.AddParameter("@StaffRole", mThisStaff.staffRole);
            DB.AddParameter("@StartDate", mThisStaff.startDate);
            DB.AddParameter("@Availability", mThisStaff.availability);
            DB.Execute("sproc_tblStaff_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", mThisStaff.staffId);
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByStaffName(string StaffFullName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffName", StaffFullName);
            DB.Execute("sproc_tblStaff_FilterByStaffName");
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mStaffList = new List<clsStaff>();
            while (Index < RecordCount)
            {
                clsStaff AnStaff = new clsStaff();
                AnStaff.staffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AnStaff.availability = Convert.ToBoolean(DB.DataTable.Rows[Index]["Availability"]);
                AnStaff.staffFullname = Convert.ToString(DB.DataTable.Rows[Index]["StaffFullname"]);
                AnStaff.staffRole = Convert.ToString(DB.DataTable.Rows[Index]["StaffRole"]);
                AnStaff.startDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StartDate"]);
                mStaffList.Add(AnStaff);
                Index++;
            }


        }
    }
}