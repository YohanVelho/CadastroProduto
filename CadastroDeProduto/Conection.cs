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

        public void Cadastro(string nome, double precocusto, double precovenda, string classificacao , int icms)
        {
            try
            {
                conn.Open();
                sql = "insert into produtos (pro_nome,pro_precocusto,pro_precovenda,pro_classificacao,pro_icms) values (@nome, @precocusto, @precovenda, @classificacao , @icms)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("nome", nome);
                cmd.Parameters.AddWithValue("precocusto", precocusto);
                cmd.Parameters.AddWithValue("precovenda", precovenda);
                cmd.Parameters.AddWithValue("classificacao", classificacao);
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

        public void Atualizar(int id, string nome, double precocusto, double precovenda, string classificacao , int icms)
        {
            try
            {
                conn.Open();
                sql = "update produtos set pro_nome = @nome , pro_precocusto = @precocusto, pro_precovenda = @precovenda, pro_classificacao = @classificacao , pro_icms = @icms where pro_id = @id ";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("nome", nome);
                cmd.Parameters.AddWithValue("precocusto", precocusto);
                cmd.Parameters.AddWithValue("precovenda", precovenda);
                cmd.Parameters.AddWithValue("classificacao", classificacao);
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

        public void Deletar(int id)
        {
            try
            {
                conn.Open();
                sql = @"delete from produtos where pro_id = (:id)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", id);
                cmd.ExecuteReader();
                conn.Close();
                MessageBox.Show("Produto excluído com sucesso!");
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public DataTable Select()
        {
            try
            {
                conn.Open();
                sql = @"select pro_id as ""ID"", pro_nome as ""Nome"", pro_precocusto as ""Preco de Custo"", pro_precovenda as ""Preco de Venda"", pro_classificacao as ""Classificacao"" ,pro_ICMS as ""ICMS"" from produtos order by pro_id";
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

        public DataTable CodBarras(int id)
        {
            try
            {
                conn.Open();
                sql = @"select pb_codigodebarra from produtoscodigodebarra where pb_id = @id";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", id);
                dt = new DataTable();
                NpgsqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
            }
            catch (Exception e)
            {
                conn.Close();
                MessageBox.Show("Error: " + e.Message);
            }
            return dt;
        }


        public DataTable SelectByPrecoCusto(double precocusto)
        {
            try
            {
                conn.Open();
                sql = @"select pro_id as ""ID"", pro_nome as ""Nome"", pro_precocusto as ""Preco de Custo"", pro_precovenda as ""Preco de Venda"", pro_classificacao as ""Classificacao"" ,pro_ICMS as ""ICMS"" from produtos where pro_precocusto = @precocusto ";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("precocusto", precocusto);
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

        public DataTable SelectByPrecoVenda(double precovenda)
        {
            try
            {
                conn.Open();
                sql = @"select pro_id as ""ID"", pro_nome as ""Nome"", pro_precocusto as ""Preco de Custo"", pro_precovenda as ""Preco de Venda"", pro_classificacao as ""Classificacao"" ,pro_ICMS as ""ICMS"" from produtos where pro_precovenda = @precovenda ";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("precovenda", precovenda);
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

        public DataTable SelectByName(string nome)
        {
            try
            {
                conn.Open();
                sql = @"select pro_id as ""ID"", pro_nome as ""Nome"", pro_precocusto as ""Preco de Custo"", pro_precovenda as ""Preco de Venda"", pro_classificacao as ""Classificacao"" ,pro_ICMS as ""ICMS"" from produtos where pro_nome = @nome ";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("nome", nome);
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

        public DataTable SelectById(int Id)
        {
            try
            {
                conn.Open();
                sql = @"select pro_id as ""ID"", pro_nome as ""Nome"", pro_precocusto as ""Preco de Custo"", pro_precovenda as ""Preco de Venda"", pro_classificacao as ""Classificacao"" ,pro_ICMS as ""ICMS"" from produtos where pro_id = @id ";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", Id);
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

        public DataTable SelectByClassification(string classificacao)
        {
            try
            {
                conn.Open();
                sql = @"select pro_id as ""ID"", pro_nome as ""Nome"", pro_precocusto as ""Preco de Custo"", pro_precovenda as ""Preco de Venda"", pro_classificacao as ""Classificacao"" ,pro_ICMS as ""ICMS"" from produtos where pro_classificacao = @classificacao ";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("classificacao", classificacao);
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

        public DataTable SelectByICMS(int icms)
        {
            try
            {
                conn.Open();
                sql = @"select pro_id as ""ID"", pro_nome as ""Nome"", pro_precocusto as ""Preco de Custo"", pro_precovenda as ""Preco de Venda"", pro_classificacao as ""Classificacao"" ,pro_ICMS as ""ICMS"" from produtos where pro_icms = @icms ";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("icms", icms);
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
    }
}

