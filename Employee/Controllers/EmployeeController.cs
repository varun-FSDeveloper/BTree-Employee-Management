using Employee.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employee.Controllers
{
    public class EmployeeController : Controller
    {

        string connectionString = @"Data Source=DESKTOP-N0LGVQG\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=SSPI";

        // GET: Employee
        public ActionResult Index()
        {  
            List<EmployeeModel> employees = new List<EmployeeModel>();

            EmployeeModel employeeModel = null;

            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = connectionString;

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "ListEmployee";
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Connection = sqlConnection;

            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    employeeModel = new EmployeeModel();

                    employeeModel.EmpId = int.Parse(sqlDataReader["EmpId"].ToString());
                    employeeModel.EmpName = sqlDataReader["EmpName"].ToString();
                    employeeModel.ContactNo = sqlDataReader["ContactNo"].ToString();
                    employeeModel.Address = sqlDataReader["Address"].ToString();
                    employeeModel.City = sqlDataReader["City"].ToString();
                    employeeModel.JoiningDate = DateTime.Parse(sqlDataReader["JoiningDate"].ToString());
                    employeeModel.projectName = sqlDataReader["projectName"].ToString();
                    employeeModel.RoleName = sqlDataReader["RoleName"].ToString();
                    employeeModel.DepartmentName = sqlDataReader["DepartmentName"].ToString();

                    employees.Add(employeeModel);
                }
            }

            sqlConnection.Close();


            return View(employees);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {

            EmployeeModel employeeModel = GetEmployeeDetails(id);

            return View(employeeModel);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(EmployeeModel employeeModel)
        {
            try
            {
                // TODO: Add insert logic here

                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = connectionString;

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "EmployeeInsert";
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Connection = sqlConnection;

                sqlCommand.Parameters.AddWithValue("@EmpName", employeeModel.EmpName);
                sqlCommand.Parameters.AddWithValue("@ContactNo", employeeModel.ContactNo);
                sqlCommand.Parameters.AddWithValue("@Address", employeeModel.Address);
                sqlCommand.Parameters.AddWithValue("@City", employeeModel.City);
                sqlCommand.Parameters.AddWithValue("@JoiningDate", employeeModel.JoiningDate);
                sqlCommand.Parameters.AddWithValue("@projectName", employeeModel.projectName);
                sqlCommand.Parameters.AddWithValue("@RoleName", employeeModel.RoleName);
                sqlCommand.Parameters.AddWithValue("@DepartmentName", employeeModel.DepartmentName);

                sqlConnection.Open();

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();


                return RedirectToAction("Index");
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {

            EmployeeModel employeeModel = GetEmployeeDetails(id);

            return View(employeeModel);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, EmployeeModel employeeModel)
        {
            try
            {
                // TODO: Add update logic here

                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = connectionString;

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "EmployeeUpdate";
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Connection = sqlConnection;

                sqlCommand.Parameters.AddWithValue("@EmpId", id);
                sqlCommand.Parameters.AddWithValue("@EmpName", employeeModel.EmpName);
                sqlCommand.Parameters.AddWithValue("@ContactNo", employeeModel.ContactNo);
                sqlCommand.Parameters.AddWithValue("@Address", employeeModel.Address);
                sqlCommand.Parameters.AddWithValue("@City", employeeModel.City);
                sqlCommand.Parameters.AddWithValue("@JoiningDate", employeeModel.JoiningDate);
                sqlCommand.Parameters.AddWithValue("@projectName", employeeModel.projectName);
                sqlCommand.Parameters.AddWithValue("@RoleName", employeeModel.RoleName);
                sqlCommand.Parameters.AddWithValue("@DepartmentName", employeeModel.DepartmentName);


                sqlConnection.Open();

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();


                return RedirectToAction("Index");
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            EmployeeModel employeeModel = GetEmployeeDetails(id);

            return View(employeeModel);
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, EmployeeModel employeeModel)
        {
            try
            {
                // TODO: Add delete logic here


                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = connectionString;

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "DeleteEmployee";
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Connection = sqlConnection;

                sqlCommand.Parameters.AddWithValue("@EmpId", id);
               

                sqlConnection.Open();

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();

                return RedirectToAction("Index");
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
                return View();
            }
        }


        private EmployeeModel GetEmployeeDetails(int id)
        {
            EmployeeModel employeeModel = new EmployeeModel();

            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = connectionString;

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "EmployeeDetail";
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Connection = sqlConnection;

            sqlCommand.Parameters.AddWithValue("@EmpId", id);

            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    employeeModel.EmpId = int.Parse(sqlDataReader["EmpId"].ToString());
                    employeeModel.EmpName = sqlDataReader["EmpName"].ToString();
                    employeeModel.ContactNo = sqlDataReader["ContactNo"].ToString();
                    employeeModel.Address = sqlDataReader["Address"].ToString();
                    employeeModel.City = sqlDataReader["City"].ToString();
                    employeeModel.JoiningDate = DateTime.Parse(sqlDataReader["JoiningDate"].ToString());
                    employeeModel.projectName = sqlDataReader["projectName"].ToString();
                    employeeModel.RoleName = sqlDataReader["RoleName"].ToString();
                    employeeModel.DepartmentName = sqlDataReader["DepartmentName"].ToString();
                }
            }

            sqlConnection.Close();

            return employeeModel;
        }
    }
}
