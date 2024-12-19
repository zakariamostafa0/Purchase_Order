using Core.Database;
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Purchase_Order
{
    public class PO_Manager
    {
        private readonly SqlDatabaseManager _dbManager;
        //private readonly SqlConnection _connection;
        private readonly string _userName;
        public PO_Manager(SqlDatabaseManager dbManager, string userName) 
        {
            _dbManager = dbManager;
            _userName = userName;
        }

        public /*static*/ List<PO_Details> GetDetails(string filePath, int month, int year, int poType)
        {
            var deatailsDatatable = Utilities.ReadExcelFile(filePath,true);
            var deatilsList = new List<PO_Details>();

            foreach (DataRow row in deatailsDatatable.Rows)
            {
                var poDeatils = new PO_Details
                {
                    PR_Month = month,
                    PR_Year = year,
                    PR_Type = poType,
                    PR_Name = row["PR Name"].ToString(),
                    PO_Name = row["PO Name"].ToString(),
                    PO_Date = DateTime.Parse(row["PO date"].ToString()),
                    PO_Department = row["Dept."].ToString(),
                    PO_Supplier = row["Supplier"].ToString(),
                    PO_PIN = int.Parse(row["PIN"].ToString()),
                    PO_Article = row["Article"].ToString(),
                    PO_Unit = row["Unit"].ToString(),
                    PO_Quantity = double.Parse(row["PO Qty"].ToString()),
                    PO_Recived_Quantity = double.Parse(row["Rec. Qty"].ToString()),
                    PO_Due_Quantity = double.Parse(row["Due Qty"].ToString()),
                    PO_Due_Date = DateTime.Parse(row["Due Date"].ToString()),
                    PO_FileName = Path.GetFileName(filePath)
                };
                deatilsList.Add(poDeatils);
            }
            return deatilsList;
        }

        public int SavePOData(List<PO_Details> deatilsList)
        {
            int savedRecords = 0;

            var fileName = deatilsList[0].PO_FileName;
            var poType = deatilsList[0].PR_Type;

            string deleteSql = "DELETE FROM PO_Details WHERE PR_Type = @PR_Type AND FileName = @FileName";
            var delParameters = new List<SqlParameter>
            {
                new SqlParameter("@PR_Type",poType),
                new SqlParameter("@FileName", fileName)
            };
            _dbManager.ExecuteDeleteQuery(deleteSql, delParameters);


            foreach (var poDetails in deatilsList)
            {
                string sql = @"INSERT INTO PO_Details
                (PR_Month, PR_Year, PR_Type, PR_Name, PO_Name, PO_Date, PO_Department, PO_Supplier, PO_PIN, PO_Article, PO_Unit, PO_Quantity, 
                PO_Recived_Quantity, PO_Due_Quantity, PO_Due_Date, FileName, UserName, Creationdate)
                VALUES
                (@PR_Month, @PR_Year, @PR_Type, @PR_Name, @PO_Name, @PO_Date, @PO_Department, @PO_Supplier, @PO_PIN, @PO_Article, @PO_Unit, 
                @PO_Quantity, @PO_Recived_Quantity, @PO_Due_Quantity, @PO_Due_Date, @FileName, @UserName, GETDATE())";

                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@PR_Month", poDetails.PR_Month),
                    new SqlParameter("@PR_Year", poDetails.PR_Year),
                    new SqlParameter("@PR_Type", poDetails.PR_Type),
                    new SqlParameter("@PR_Name", poDetails.PR_Name),
                    new SqlParameter("@PO_Name", poDetails.PO_Name),
                    new SqlParameter("@PO_Date", poDetails.PO_Date),
                    new SqlParameter("@PO_Department", poDetails.PO_Department),
                    new SqlParameter("@PO_Supplier", poDetails.PO_Supplier),
                    new SqlParameter("@PO_PIN", poDetails.PO_PIN),
                    new SqlParameter("@PO_Article", poDetails.PO_Article),
                    new SqlParameter("@PO_Unit", poDetails.PO_Unit),
                    new SqlParameter("@PO_Quantity", poDetails.PO_Quantity),
                    new SqlParameter("@PO_Recived_Quantity", poDetails.PO_Recived_Quantity),
                    new SqlParameter("@PO_Due_Quantity", poDetails.PO_Due_Quantity),
                    new SqlParameter("@PO_Due_Date", poDetails.PO_Due_Date),
                    new SqlParameter("@FileName", poDetails.PO_FileName),
                    new SqlParameter("@UserName", _userName)
                 };
                savedRecords += _dbManager.ExecuteInsertQuery(sql, parameters);
            }
            return savedRecords;
        }

        public void DeletePOData(string fileName)
        {
            string sql = "DELETE FROM PO_Details WHERE FileName = @FileName";
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@FileName", fileName)
            };

            _dbManager.ExecuteDeleteQuery(sql, parameters);
        }
    }
}

