using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CRUD
{
    class Program
    {
        static void Main(string[] args)
        {

            string connectionString = "Data Source=LAPTOP-KJN76HFD\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
            SqlConnection myConn = new SqlConnection(connectionString);


            #region Aanmaken database
            /*  //Aanmaken Database CSharpTest
               string sql = "CREATE DATABASE CSharpTest";
                 SqlCommand myCommand = new SqlCommand(sql, myConn);
               try
               {
                   myConn.Open();
                   myCommand.ExecuteNonQuery();
               }
               catch (Exception e )
               {
                   Console.WriteLine(e);
                   throw;
               }
               finally
               {
                   myConn.Close();
               }
              */
            #endregion

            string myConnection = "Data Source=LAPTOP-KJN76HFD\\SQLEXPRESS;Initial Catalog=CSharpTest;Integrated Security=True";
            SqlConnection myConn2 = new SqlConnection(myConnection);

            #region Aanmaken tabellen en inserten
            /*
                         //Aanmaken tabellen en inserten
                         string sqlCreateContinents = "CREATE TABLE Continents(ContinentName nvarchar(100), CountryId bigint, Population bigint)";
                         string sqlCreateJson = "CREATE TABLE ContJson(Info nvarchar(max))";
                         string insertRow1 = "INSERT Continents(ContinentName, CountryId,Population) VALUES('EUROPE', 32, 10400000)";
                         string insertRow2 = "INSERT Continents(ContinentName, CountryId,Population) VALUES('EUROPE', 31, 17180000)";

                         SqlCommand createContintents = new SqlCommand(sqlCreateContinents, myConn2);
                         SqlCommand createJson = new SqlCommand(sqlCreateJson, myConn2);
                         SqlCommand insertcmd = new SqlCommand(insertRow1, myConn2);
                         SqlCommand insert2cmd = new SqlCommand(insertRow2, myConn2);
                         try
                         {
                             myConn2.Open();
                             createContintents.ExecuteNonQuery();
                             createJson.ExecuteNonQuery();
                             insertcmd.ExecuteNonQuery();
                             insert2cmd.ExecuteNonQuery();

                         }
                         catch (Exception e)
                         {
                             Console.WriteLine(e);
                         }
                         finally
                         {
                             myConn2.Close();
                         }*/
            #endregion

            #region Update table
            /*  string update = @"UPDATE Continents
                               SET Population = 11400000
                               Where CountryId =32";

              SqlCommand cmdUpdate = new SqlCommand(update, myConn2);
              try
              {
                  myConn2.Open();
                  cmdUpdate.ExecuteNonQuery();

              }
              catch (Exception e )
              {
                  Console.WriteLine(e);
              }
              finally
              {
                  myConn2.Close();
              }*/
            #endregion

            #region Json 

            /* DataTable dt = new DataTable();
             using (SqlConnection con = new SqlConnection("Data Source = LAPTOP - KJN76HFD\\SQLEXPRESS; Initial Catalog = CSharpTest; Integrated Security = True"))
             {
                 string insertJsonQuery = "Insert into ContJson(Info) values (@Jsonstring)";
                 using (SqlCommand cmd = new SqlCommand(@"SELECT [ContinentName],[CountryId],[Population]
                 FROM[Continents]", con))
                 {
                     con.Open();
                     SqlDataAdapter da = new SqlDataAdapter(cmd);
                     da.Fill(dt);

                     List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
                     Dictionary<string, object> row;
                     foreach (DataRow dr in dt.Rows)
                     {
                         row = new Dictionary<string, object>();
                         foreach (DataColumn col in dt.Columns)
                         {
                             row.Add(col.ColumnName, dr[col]);
                         }
                         var jsonString = JsonConvert.SerializeObject(row);
                         using (SqlCommand insertCommand = new SqlCommand(insertJsonQuery, con))
                         {
                             var jsonPar = new SqlParameter("Jsonstring", SqlDbType.NVarChar);
                             jsonPar.Value = jsonString;
                             insertCommand.Parameters.Add(jsonPar);
                             insertCommand.ExecuteNonQuery();
                         }
                     }
                 }
             }
             */
            #endregion

            #region Rijen vewijderen
           /* string verijwderRijenContinents = @"DELETE FROM Continents";
            string verwijderRijdenJson = @"Delete FROM ContJson";

            SqlCommand cmdDeleteContinents = new SqlCommand(verijwderRijenContinents, myConn2);
            SqlCommand cmdDeleteJson = new SqlCommand(verwijderRijdenJson, myConn2);
            try
            {
                myConn2.Open();
                cmdDeleteContinents.ExecuteNonQuery();
                cmdDeleteJson.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                myConn2.Close();
            }*/
            #endregion

            #region Tabel verwijderen
            /* string dropContinents = "DROP TABLE Continents";
             string dropContJson = "DROP TABLE ContJson";

             SqlCommand cmdDropContinents = new SqlCommand(dropContinents, myConn2);
             SqlCommand cmdDropContJson = new SqlCommand(dropContJson, myConn2);

             try
             {
                 myConn2.Open();
                 cmdDropContinents.ExecuteNonQuery();
                 cmdDropContJson.ExecuteNonQuery();
             }
             catch (Exception e )
             {
                 Console.WriteLine(e.Message);
 ;
             }
             finally
             {
                 myConn2.Close();
             }*/
            #endregion
        }
    }
}
