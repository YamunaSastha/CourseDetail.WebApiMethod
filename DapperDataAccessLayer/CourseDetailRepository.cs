using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
namespace DapperDataAccessLayer
{
   
        public class CourseDetailsRepository : ICourseDetailsRepository
        {
            public CourseDetails InsertSP(CourseDetails CourseDt)
            {
                try
                {
                    var connectionString = " Data source=DESKTOP-BLBGEHJ\\SQLEXPRESS;initial catalog=batch7;user id=sa;password=Anaiyaan@123;";
                    var con = new SqlConnection(connectionString);
                    con.Open();
                    var insertQuery = $"exec CourseDetailInsert '{CourseDt.CourseName}','{CourseDt.Duration}', '{CourseDt.StartDate}',{CourseDt.NumberOfStudents},'{CourseDt.ContactPerson}'";
                    con.Execute(insertQuery);
                    con.Close();

                }
                catch (SqlException sql)
                {
                    throw;
                }
                catch (Exception ex)
                {
                    throw;
                }
                return CourseDt;
            }
            public CourseDetails UpdateSP(long id, CourseDetails Dts)
            {

                try
                {
                    var connectionString = " Data source=DESKTOP-BLBGEHJ\\SQLEXPRESS;initial catalog=batch7;user id=sa;password=Anaiyaan@123;";
                    var con = new SqlConnection(connectionString);
                    con.Open();
                    var updateQuery = $"exec CourseDetailUpdate {id}, '{Dts.CourseName}','{Dts.Duration}','{Dts.StartDate}',{Dts.NumberOfStudents},'{Dts.ContactPerson}'";
                    var dts = con.QueryFirstOrDefault<CourseDetails>(updateQuery);
                    con.Execute(updateQuery);
                    Console.WriteLine(updateQuery);
                    con.Close();
                    return dts;
                }
                catch (SqlException sql)
                {
                    throw;
                }
                catch (Exception ex)
                {
                    throw;
                }

            }
            public IEnumerable<CourseDetails> ReadSP()
            {
                try
                {
                    var connectionString = " Data source=DESKTOP-BLBGEHJ\\SQLEXPRESS;initial catalog=batch7;user id=sa;password=Anaiyaan@123;";
                    var con = new SqlConnection(connectionString);
                    con.Open();
                    var selectQuery = $"CourseDetailRead";
                    var details = con.Query<CourseDetails>(selectQuery);
                    con.Execute(selectQuery);
                    con.Close();
                    return details.ToList();
                }
                catch (SqlException sql)
                {
                    throw;
                }
                catch (Exception ex)
                {
                    throw;
                }

            }
            public void DeleteSP(long id)
            {
                try
                {
                    var connectionString = " Data source=DESKTOP-BLBGEHJ\\SQLEXPRESS;initial catalog=batch7;user id=sa;password=Anaiyaan@123;";
                    var con = new SqlConnection(connectionString);
                    con.Open();
                    var deleteQuery = $"exec CourseDetailDelete {id}";
                    con.Execute(deleteQuery);
                    con.Close();
                }
                catch (SqlException sql)
                {
                    throw;
                }
                catch (Exception ex)
                {
                    throw;
                }

            }
        }
    }




