using System.Data.SqlClient;

string stringaDiConnessione = "Data Source=localhost;Initial Catalog=db-videogames;Integrated Security=True";

SqlConnection connessioneSql = new SqlConnection(stringaDiConnessione);

try
{
    connessioneSql.Open();
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}
finally
{
    connessioneSql.Close();
}
