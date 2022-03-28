using System;
using System.Collections;



namespace ClassLibrary
{
    public class clsStaff
    {


        public string staffFullname;
        public int staffId;
        public DateTime startDate;
        public bool availability;
        public string staffRole;
        public string CustomerID;
        public object tbstaffFullname;


        public bool Find(int staffId)
        {
            throw new NotImplementedException();
        }

        public bool Find(object staffId)
        {
            throw new NotImplementedException();
        }
    }
    public class clsStaff
    {



        private int mstaffId;


        public int staffId

        {

            get
        }

        return mstaffId
            }
    set
}

        //set the private data
        mstaffId = value;
}

}


//private date added 
private DateTime mstartDate;

//public for when started
public DateTime startDate;
{
    get
    { 
        return mstartDate;

    }

    set

    {  
        //set the private data
        mstartDate = value;
    }

}



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
}

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
    DB.Execute("sproc_tblAddress_FilterBystaffId");
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

