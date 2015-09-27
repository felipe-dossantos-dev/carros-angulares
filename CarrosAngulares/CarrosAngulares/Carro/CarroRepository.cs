using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CarrosAngulares.Carro
{
    public class CarroRepository : ICarroRepository
    {
        private int cont;
        private static String conexao = @"Data Source=(localdb)\Projects;Initial Catalog=carros;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";

        public CarroRepository()
        {
        }

        bool ICarroRepository.adicionarCarro(Carro car)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = conexao;
                conn.Open();
                String sql = "insert into dbo.carro (categoria, marca, tipo, modelo, ano, preco, proprietario, placa, cor, obs, data_aquisicao) values ("
                    + car.categoria + "," 
                    + car.marca + "," 
                    + car.tipo + "," 
                    + "'" + car.modelo + "'," 
                    + car.ano + "," 
                    + car.preco.Replace(',', '.') + ","
                    + "'" + car.proprietario + "'," 
                    +"'" + car.placa + "'," 
                    +"'" + car.cor + "'," 
                    +"'" + car.obs + "'," 
                    +"'" + car.dataAquisicao + "'" +
                    ")";
                SqlCommand cmd = new SqlCommand(sql, conn);
                return cmd.ExecuteNonQuery() == 1;
            }
        }

        public List<Carro> listarDestaques()
        {
            var lista = new List<Carro>();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = conexao;
                conn.Open();
                String sql = "Select top 5 * from dbo.carro order by preco desc";
                SqlCommand cmd = new SqlCommand(sql, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Carro c = new Carro();
                        c.codigo = (reader["id"]).ToString();
                        c.categoria = (reader["categoria"]).ToString();
                        c.marca = (reader["marca"]).ToString();
                        c.tipo = (reader["tipo"]).ToString();  
                        c.modelo = (reader["modelo"]).ToString();
                        c.ano = (reader["ano"]).ToString();
                        c.preco = (reader["preco"]).ToString();
                        c.proprietario = (reader["proprietario"]).ToString();
                        c.placa = (reader["placa"]).ToString();
                        c.cor = (reader["cor"]).ToString();
                        c.obs = (reader["obs"]) != null ? (reader["obs"]).ToString() : "";
                        c.dataAquisicao = (reader["data_aquisicao"]).ToString();
                        lista.Add(c);
                    }
                }
            }
            return lista;
        }

        public List<Carro> listarFiltro(Filtro filtro)
        {
            var lista = new List<Carro>();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = conexao;
                conn.Open();
                String sql = "Select * from dbo.carro where modelo like '%"+ filtro.palavraChave +"%' order by preco desc";
                SqlCommand cmd = new SqlCommand(sql, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Carro c = new Carro();
                        c.codigo = (reader["id"]).ToString();
                        c.categoria = (reader["categoria"]).ToString();
                        c.marca = (reader["marca"]).ToString();
                        c.tipo = (reader["tipo"]).ToString();
                        c.modelo = (reader["modelo"]).ToString();
                        c.ano = (reader["ano"]).ToString();
                        c.preco = (reader["preco"]).ToString();
                        c.proprietario = (reader["proprietario"]).ToString();
                        c.placa = (reader["placa"]).ToString();
                        c.cor = (reader["cor"]).ToString();
                        c.obs = (reader["obs"]) != null ? (reader["obs"]).ToString() : "";
                        c.dataAquisicao = (reader["data_aquisicao"]).ToString();
                        lista.Add(c);
                    }
                }
            }
            return lista;
        }

        public List<Marca> listarMarcas()
        {
            var lista = new List<Marca>();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = conexao;
                conn.Open();
                String sql = "Select * from dbo.marca";
                SqlCommand cmd = new SqlCommand(sql, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Marca
                        {
                            id = Convert.ToInt16(reader["id"]),
                            descricao = reader["descricao"].ToString()
                        });
                    }
                }
            }
            return lista;
        }
    }
}