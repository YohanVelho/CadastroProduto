using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace CadastroDeProduto
{
    class Conection
    {
        public static string stringconn = "Server=127.0.0.1;Port=5432;Database=DbCadastro;User Id=postgres;Password=181271;";
        public NpgsqlConnection conn = new NpgsqlConnection(stringconn);


    }
}
