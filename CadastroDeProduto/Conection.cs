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
            }
            catch (Exception e)
            {
                conn.Close();
                MessageBox.Show("Error: " + e.Message);
            }
            return dt;
        }

        public void Cadastro(int ID, string nome, double precocusto, double precovenda, int icms)
        {
            try
            {
                conn.Open();
                sql = "insert into produtos (pro_id,pro_nome,pro_precocusto,pro_precovenda,pro_icms) values (@id, @nome, @precocusto, @precovenda, @icms)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", ID);
                cmd.Parameters.AddWithValue("nome", nome);
                cmd.Parameters.AddWithValue("precocusto", precocusto);
                cmd.Parameters.AddWithValue("precovenda", precovenda);
                cmd.Parameters.AddWithValue("icms", icms);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Cadastrado com Sucesso!");

            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message);
            }
        }

        public void Atualizar(int id, string nome, double precocusto, double precovenda, int icms)
        {
            try
            {
                conn.Open();
                sql = "update produtos set pro_id = @id, pro_nome = @nome , pro_precocusto = @precocusto, pro_precovenda = @precovenda, pro_icms = @icms where pro_id = @id ";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("nome", nome);
                cmd.Parameters.AddWithValue("precocusto", precocusto);
                cmd.Parameters.AddWithValue("precovenda", precovenda);
                cmd.Parameters.AddWithValue("icms", icms);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Atualizado com sucesso!");
            }
            catch(Exception e)
            {
                MessageBox.Show("Erro: " + e.Message);
            }
        }
    }
}

