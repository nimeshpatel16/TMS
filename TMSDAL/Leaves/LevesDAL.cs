using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.DataTransferObject;


namespace TMS.DataAccessLayer.Leaves
{
    public class LevesDAL
    {
        public void Saveleaves(DTOLeaveMaster dtoLeaveMaster)
        {
            try
            {
                SqlHelper dbHelper = new SqlHelper();
                SqlParameter[] param = new SqlParameter[8];
                // param[0] = new SqlParameter("@DepartmentKey", empDTO.departmentDTO.DepartmentKey);
                param[0] = new SqlParameter("@ResourceID", dtoLeaveMaster.ResourceID);
                param[1] = new SqlParameter("@LeaveType", dtoLeaveMaster.LeaveType);
                param[2] = new SqlParameter("@StartDate", dtoLeaveMaster.StartDate);
                param[3] = new SqlParameter("@EndDate", dtoLeaveMaster.EndDate);
                param[4] = new SqlParameter("@IsStartHalf", dtoLeaveMaster.IsStartHalf);
                param[5] = new SqlParameter("@IsEndHalf", dtoLeaveMaster.IsEndHalf);
                param[6] = new SqlParameter("@Reason", dtoLeaveMaster.Reason);
                param[7] = new SqlParameter("@CreatedBy", dtoLeaveMaster.CreatedBy);
                int i = dbHelper.ExecuteNonQuery("usp_InsertLeave", param);

                //dbHelper.AddParameter("@ResourceID", dtoLeaveMaster.ResourceID);
                //dbHelper.AddParameter("@LeaveType", dtoLeaveMaster.LeaveType);
                //dbHelper.AddParameter("@StartDate", dtoLeaveMaster.StartDate);
                //dbHelper.AddParameter("@EndDate", dtoLeaveMaster.EndDate);
                //dbHelper.AddParameter("@IsStartHalf", dtoLeaveMaster.IsStartHalf);
                //dbHelper.AddParameter("@IsEndHalf", dtoLeaveMaster.IsEndHalf);
                //dbHelper.AddParameter("@Reason", dtoLeaveMaster.Reason);
                //dbHelper.AddParameter("@CreatedBy", dtoLeaveMaster.CreatedBy);

                //return CollectionHelper.ConvertTo<DTOLeaveMaster>(dbHelper.ExecuteDataTable("usp_InsertLeave"));
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
