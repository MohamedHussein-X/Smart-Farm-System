using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Farm_DB
{
    class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }



        public int UpdateMManager(int  id, int salary, string c)
        {
            string query = "UPDATE M_Manager set Grade= " + "'" + c + "',"+"Salary= " +  salary + "WHERE Employee_ID = " + id + "";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertAssist(string D, int ID,string type, int quantity ,int Price)
        {
            string query = "INSERT INTO F_Manager VALUES('" + D + "', " + ID + ",'" + type + "'," + quantity + "," + Price+ " );";
            return dbMan.ExecuteNonQuery(query);
        }



        public int UpdateAssist(int id,int price, int qauntity)
        {
            string query = "UPDATE F_Manager set Price= "  + price + ","+"Quantity=" + qauntity  + "WHERE Asset_ID = " + id + "";
            return dbMan.ExecuteNonQuery(query);
        }

        public int DeleteAssist(int id)
        {
            string query = "DELETE FROM F_Manager WHERE Asset_ID=" + id + "";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable SelectAllAssits()
        {
            string query = "SELECT * From F_Manager ";
            return dbMan.ExecuteReader(query);
        }





        public DataTable SelectEmpId()
        {
            string query = "SELECT Employee_ID From M_Manager ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAsId()
        {
            string query = "SELECT Asset_ID From F_Manager ";
            return dbMan.ExecuteReader(query);
        }



         public DataTable SelectAllTypes()
        {
            string query = "SELECT Product_Type FROM wherehouse;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAllIDS()
        {
            string query = "SELECT Product_ID FROM wherehouse;";
            return dbMan.ExecuteReader(query);
        }

        public int changeinfo(DateTime date,int ID ,string producttype, int Quantity)
        {

            string StoredProcedureName = StoredProcedures.updateinfo;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@date", date);
            Parameters.Add("@ID", ID);
            Parameters.Add("@producttype", producttype);
            Parameters.Add("@Quantity", Quantity);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int createinfo(DateTime date, int ID, string producttype, int Quantity)
        {

            string StoredProcedureName = StoredProcedures.newinfo;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@date", date);
            Parameters.Add("@ID", ID);
            Parameters.Add("@producttype", producttype);
            Parameters.Add("@Quantity", Quantity);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable geteverything()
        {
            string storedProcedureName = StoredProcedures.getallinfo;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(storedProcedureName,Parameters);
        }
        

        public DataTable getweeklyAgriculture(DateTime date)
        {
            String StoredProcedureName = StoredProcedures.weeklyreportAgriculture;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@date", date);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable getweeklyvet(DateTime date)
        {
            String StoredProcedureName = StoredProcedures.weeklyreportvet;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@date", date);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable getweeklyExports(DateTime date)
        {
            String StoredProcedureName = StoredProcedures.weeklyreportExports;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@date", date);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable getmonthlyAgriculture(DateTime date)
        {
            String StoredProcedureName = StoredProcedures.monthlyreportAgriculture;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@date",date);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable getmonthlyExports(DateTime date)
        {
            String StoredProcedureName = StoredProcedures.monthlyreportExports;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@date",date);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable getmonthlyvet(DateTime date)
        {
            String StoredProcedureName = StoredProcedures.monthlyreportvet;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@date",date);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable getyearlyAgriculture(DateTime date)
        {
            String StoredProcedureName = StoredProcedures.yearlyreportAgriculture;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@date", date);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable getyearlyexports(DateTime date)
        {
            String StoredProcedureName = StoredProcedures.yearlyreportExports;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@date", date);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable getyearlyvet(DateTime date)
        {
            String StoredProcedureName = StoredProcedures.yearlyreportvet;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@date", date);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
 
   




        public int InsertEmp(int ID,string Name,string adress,string gender, string BOD,string workas)
        {
            string query = "INSERT INTO employees VALUES(" + ID+ ",'" + Name + "','" + adress + "','" + gender + "','" + BOD + "','"+ workas+"'"+ " );";
            return dbMan.ExecuteNonQuery(query);
        }

        public int DeleteEmp(int id)
        {
            string query = "DELETE FROM Employees WHERE ID=" + id + "";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable SelectEmp_Id()
        {
            string query = "SELECT ID From Employees ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAllEmp()
        {
            string query = "SELECT * From Employees ";
            return dbMan.ExecuteReader(query);
        }



        public DataTable LogIn(int id ,int password)
        {
            string query = "SELECT Workas From Login Where LoginID=" + id+ " and Password=" +password +"";
          //  if (dbMan.ExecuteReader(query) == null)
            return  dbMan.ExecuteReader(query); 
        }



        public int SignUp(int ID, int Pass, string workas)
        {
            string query = "INSERT INTO Login VALUES(" + ID + ", " + Pass + ",'" + workas +"'"+ " );";
            return dbMan.ExecuteNonQuery(query);
        }





        public int UpdatePassWord(int id, int Pass)
        {
            string query = "UPDATE Login set Password= " + Pass + "WHERE LoginID = " + id + "";
            return dbMan.ExecuteNonQuery(query);
        }

        public string getname(int id)
        {
            string query1 = "select Name from employees where ID = " +id +"";
            string name = (string)dbMan.ExecuteScalar(query1);
            return name;
        }
        public string getadd(int id)
        {
            string query1 = "select Address from employees where ID = " + id + "";
            string name = (string)dbMan.ExecuteScalar(query1);
            return name;
        }
        public string getGen(int id)
        {
            string query1 = "select sex from employees where ID = " + id + "";
            string name = (string)dbMan.ExecuteScalar(query1);
            return name;
        }
        public string getBOD(int id)
        {
            string query1 = "select BOD from employees where ID = " + id + "";
            string name = (string)dbMan.ExecuteScalar(query1);
            return name;
        }

        public string getWorkas(int id)
        {
            string query1 = "select work_as from employees where ID = " + id + "";
            string name = (string)dbMan.ExecuteScalar(query1);
            return name;
        }




        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        




        public int InsertDep(string Dname, int Dnum, int MnSSN
             , string Date)
        {
            string query = "INSERT INTO Depatment (Dname,Dnumber,Mgr_SSN,Mgr_Start_Date) " +
                            "Values ('" + Dname + "'," + Dnum + "," + MnSSN + ","
                            + Date + "); ";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertDepLoc(int DNum, string Loc)
        {
            string query = "INSERT INTO Dept_Locations  (Dnumber, Dlocation)" +
                            "Values (" + DNum + ",'" + Loc + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertProject(string Pname, int pnumber, string Plocation, int Dnum)
        {
            string query = "INSERT INTO Project (Pname, Pnumber, Plocation, Dnum)" +
                            "Values ('" + Pname + "'," + pnumber + ",'" + Plocation + "'," + Dnum + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable SelectDepNum()
        {
            string query = "SELECT Dnumber FROM Department;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectDepLoc()
        {
            string query = "SELECT DISTINCT Dlocation FROM Dept_Locations;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectProject(int Essn)
        {
            string query = "SELECT Pname FROM Project , Works_On"
             + " where Pnumber = Pno, Essn'" + Essn + "';";

            return dbMan.ExecuteReader(query);
        }
    }
}

