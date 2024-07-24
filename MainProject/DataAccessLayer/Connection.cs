using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayer
{
    public class Connection
    {
        public static SqlConnection bgl = new SqlConnection("@Data Source=DESKTOP-TBKO1DI\\SQLEXPRESS;Initial Catalog=Db_YazOkulu;Integrated Security=True");
    }
}
