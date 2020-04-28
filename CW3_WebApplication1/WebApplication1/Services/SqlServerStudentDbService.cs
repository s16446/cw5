using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DTOs.Requests;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class SqlServerStudentDbService : IStudentDbService
    {
        private const string CONN_STR = "Data Source=db-mssql;Initial Catalog=s16446;Integrated Security=True";
        public void EnrollStudent(EnrollStudentRequest request)
        {
            var st = new Student();
            st.FirstName = request.FirstName;
            st.LastName = request.LastName;
            st.IndexNumber = request.IndexNumber;
            st.BirthDate = request.BirthDate;
            st.Studies = request.Studies;

            using (var con = new SqlConnection(CONN_STR))
            using (var com = new SqlCommand()) 
            {
                com.Connection = con;
               
                con.Open();

                var tran = con.BeginTransaction();
                // procedura skladowana 

                com.CommandText = "select [IndexNumber], [FirstName], [LastName], [BirthDate] from dbo.Student where IndexNumber = @index_no;";
                com.Parameters.AddWithValue("name", request.Studies);
                com.Parameters.AddWithValue("index", request.Studies);

                var dr = com.ExecuteReader();

                if (!dr.Read())
                {
                    tran.Rollback();    
                }
                else 
                {
                    //Ok(200);
                }

                tran.Commit();
            
            
            }


        }

        public void PromoteStudents(int semester, string studies)
        {
            throw new NotImplementedException();
        }
    }
}
