using Proj_Aula_BD.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Proj_Aula_BD.Persistencia
{
    class ClienteBD
    {
        private Banco bancoDeDados;

        public ClienteBD(Banco banco)
        {
            this.bancoDeDados = banco;
        }
        

        public void incluir(Cliente cliente)
        {
            string sql = "insert into cliente(cli_nome, cli_datanasc, cli_telefone, cli_cpf, cli_email, cid_cod)" + "values(@pNome, @pdatanasc, @ptelefone, @pcpf, @pemail, @pcodcid)";           

            this.bancoDeDados.Conecta();

            bancoDeDados.ExecuteNonQuery(sql, "@pNome", cliente.Nome, "@pdatanasc", cliente.DataNasc, "@ptelefone", cliente.Telefone, "@pcpf", cliente.Cpf, "@pemail", cliente.Email, "@pcodcid", cliente.Cidade.Codigo);

            this.bancoDeDados.Desconecta();
        }

        public void alterar(Cliente cliente)
        {
            string sql = "update cliente set cli_nome = @pNome, cli_datanasc = @pdatanasc, cli_telefone = @ptelefone, cli_cpf = @pcpf, cli_email = @pemail, cid_cod = @pcidade, where cli_cod = @pcodigo";
            this.bancoDeDados.Conecta();
            this.bancoDeDados.ExecuteNonQuery(sql, "@pnome", cliente.Nome, "@pdatanasc", cliente.DataNasc, "@ptelefone", cliente.Telefone, "@pcpf", cliente.Cpf, "@pemail", cliente.Email, "@pcidade", cliente.Cidade.Codigo);
            this.bancoDeDados.Desconecta();
        }

        public void excluir(Cliente cliente)
        {
            string sql = "delete from cliente where cli_cod = @pcodigo";
            this.bancoDeDados.Conecta();
            this.bancoDeDados.ExecuteNonQuery(sql, "@pcodigo", cliente.Codigo);
            this.bancoDeDados.Desconecta();
        }

        public Cliente consulta(int codigoCliente)
        {
            string sql = "Select * from cliente where cli_cod = @pcodigo";
            DataTable dados;
            this.bancoDeDados.Conecta();
            this.bancoDeDados.ExecuteQuery(sql, out dados, "@pcodigo", codigoCliente);
            if (dados.Rows.Count > 0)
            {
                CidadeBD cidBD = new CidadeBD(this.bancoDeDados);

                Cidade cidadeCliente = cidBD.consulta(Convert.ToInt32(dados.Rows[0][6].ToString()));

                Cliente resultadoCliente = new Cliente(Convert.ToInt32(dados.Rows[0][0].ToString()),
                                                        dados.Rows[0][1].ToString(),
                                                        Convert.ToDateTime(dados.Rows[0][2]),
                                                        dados.Rows[0][3].ToString(),
                                                        dados.Rows[0][4].ToString(),
                                                        dados.Rows[0][5].ToString(),
                                                        cidadeCliente);

                return resultadoCliente;
            }
            else
            {
                return null;
            }
        }

        public List<Cliente> consulta(string termo)
        {
            string sql = "Select * from cliente where cli_cod like @termo";
            DataTable dados;
            List<Cliente> listaClientes = new List<Cliente>();
            this.bancoDeDados.Conecta();
            this.bancoDeDados.ExecuteQuery(sql, out dados, "@termo","%" + termo + "%");
            if (dados.Rows.Count > 0)
            {
                for(int i = 0; i < dados.Rows.Count; i++)
                {
                    CidadeBD cidBD = new CidadeBD(this.bancoDeDados);

                    Cidade cidadeCliente = cidBD.consulta(Convert.ToInt32(dados.Rows[i][6].ToString()));

                    Cliente resultadoCliente = new Cliente(Convert.ToInt32(dados.Rows[i][0].ToString()),
                                                        dados.Rows[i][1].ToString(),
                                                        Convert.ToDateTime(dados.Rows[i][2].ToString()),
                                                        dados.Rows[i][3].ToString(),
                                                        dados.Rows[i][4].ToString(),
                                                        dados.Rows[i][5].ToString(),
                                                        cidadeCliente);
                    listaClientes.Add(resultadoCliente);
                }
                
                
            }
            return listaClientes;
        }
    }
}
