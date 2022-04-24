using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary
{
    public class clsStaffCollection
    {
        public clsStaffCollection


        public List<clsStaff> StaffList;
        public clsStaff ThisStaff;

        Int32 Index = 0;
        Int32 RecordCount = 0;
        clsDataConnection DB = new clsDataConnection();
        DB.Execute("sproc_tblStaff_SelectAll");
            RecordCount = DB.Count;
            while(Index<RecordCount)
public int Add()
        {
            throw new NotImplementedException();
        }
    }
}


    

clsSupplier AnStaff = new clsStaff();
        AnStaff.staffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AnStaff.startDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StartDate"]);
                AnStaff.staffFullname = Convert.ToString(DB.DataTable.Rows[Index]["StaffFullname"]);
                AnStaff.availability = Convert.ToBoolean(DB.DataTable.Rows[Index]["Availability"]);
                AnStaff.staffRole = Convert.ToString(DB.DataTable.Rows[Index]["StaffRole"]);
                
                mStaffList.Add(AnStaff);
                Index++;
            }
}
List<clsStaff> mStaffList = new List<clsStaff>();
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
        //worry about this later
    }
}


private clsStaff mThisStaff;
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

{
    clsDataConnection DB = new clsDataConnection();
    DB.AddParameter("@StaffFullame", mThisStaff.StaffFullname);
    DB.AddParameter("@StaffId", mThisStaff.StaffId);
    DB.AddParameter("@StaffRole", mThisStaff.StaffRole);
    DB.AddParameter("@StartDate", mThisStaff.StartDate);
    

    return DB.Execute("Sproc_tblStaff_Insert");
}
           
                
    }
}



    public int Add()
        {
            throw new NotImplementedException();
        }
    }
}

       