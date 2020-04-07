using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace CadastroDeProduto
{
    class Conection
    {
        public static string stringconn = "Server=127.0.0.1;Port=5432;Database=DbCadastro;User Id=postgres;Password=181271;";
        public NpgsqlConnection conn = new NpgsqlConnection(stringconn);
        public string sql;
        public NpgsqlCommand cmd;
        public DataTable dt;

        public Conection()
        {
        }

        public DataTable Select()
        {
            try
            {
                conn.Open();
                sql = @"select pro_id as ""ID"", pro_nome as ""Nome"", pro_precocusto as ""Preco de Custo"", pro_precovenda as ""Preco de Venda"", pro_ICMS as ""ICMS"" from produtos ";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();                
            }catch(Exception e)
            {
                conn.Close();
                MessageBox.Show("Error: " + e.Message);
            }
            return dt;
        }
    }
}
