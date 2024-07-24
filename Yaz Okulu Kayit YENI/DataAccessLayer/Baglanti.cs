using System.Data;
using System.Data.SqlClient;
using EntityLayer;



namespace DataAccessLayer
{
    public class Baglanti
    {
        public static SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-TBKO1DI\SQLEXPRESS;Initial Catalog=Db_YazOkulu;Integrated Security=True");
    }
}
