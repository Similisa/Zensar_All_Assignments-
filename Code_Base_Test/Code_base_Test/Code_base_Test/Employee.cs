using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Code_base_Test
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;

        static void Main(string[] args)
        {
            con = getConnection();
            string name, type;
            double sal;
            Console.WriteLine("Enter the empmloyee Name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter Employee Salary:");
            sal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Employee Type:");
            type = Console.ReadLine();

            cmd = new SqlCommand("add_new_Employee", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter param;
            param = cmd.Parameters.Add("@empname", SqlDbType.NVarChar, 50);
            param.Value = name;
            param = cmd.Parameters.Add("@empsal", SqlDbType.Money);
            param.Value = sal;
            param = cmd.Parameters.Add("@emptype", SqlDbType.NVarChar, 1);
            param.Value = type;

            int NoOfRows = cmd.ExecuteNonQuery();
            con.Close();

            if (NoOfRows > 0)
                Console.WriteLine(NoOfRows.ToString() + " record(s) inserted");

            Console.ReadLine();
        }

        static SqlConnection getConnection()
        {
            con = new SqlConnection("Data Source=POOLW42NLPC0466;Initial Catalog=EmployeeManagement;Integrated Security=True;MultipleActiveResultSets=True");
            con.Open();
            return con;
        }
    }
}