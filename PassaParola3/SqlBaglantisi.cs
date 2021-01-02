using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace PassaParola3
{
    class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-INSQH5J\\SQLEXPRESS;Initial Catalog=Passaparola;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
