using Proj_Aula_BD.Modelo;
using Proj_Aula_BD.Persistencia;
using Proj_Aula_BD.Visao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Proj_Aula_BD.Controle
{
    public class ControladoraCadastroClientes : IObservador
    {
        private static ControladoraCadastroClientes instancia = null;
        private static Object trava = new object();
        private Banco bancoDeDados;
        private Cliente clienteAtivo;
        FClientes telaCadastroCliente;


        //padrao de projeto singleton ou singular
        public static ControladoraCadastroClientes obterInstancia()
        {
            lock (trava)
            {
                if (instancia == null)
                {
                    instancia = new ControladoraCadastroClientes(TIPO_BD.SQLSERVER);
                }
                return instancia;
            }
        }

        public void mostrarTelaCadastroCliente()
        {
            CidadeBD cidadeBD = new CidadeBD(this.bancoDeDados);
            FClientes telaCadastroCliente = new FClientes();
            telaCadastroCliente.adicionarObservadores(this);
            telaCadastroCliente.cbCidades.DataSource = cidadeBD.consulta("");
            //e preciso dar diretrizes para que o combobox saiba o que ele esta recebendo e de que maneira 
            //representar um objeto do tipo Modelo.Cidade
            //Diz ao comobobox qual atributo exibir de uma cidade
            telaCadastroCliente.cbCidades.DisplayMember = "Nome";
            //Diz ao combobox qual valor devolver quando uma cidade for selecionada
            telaCadastroCliente.cbCidades.ValueMember = "Codigo";
            telaCadastroCliente.ShowDialog();
        }

        private ControladoraCadastroClientes(TIPO_BD tipoDeBanco) // construtor e privado
        {
            if(tipoDeBanco == TIPO_BD.SQLSERVER)
            {
                //DECLARAR CODIGO PARA INSTANCIAR CLASSES QUE PERMITEM ACESSO AO BANCO SQLSERVER
                bancoDeDados = new BancoSQLServer();
            }
        }

        public void notificar(string acao, params object[] parametros)
        {
            ClienteBD cliBD = new ClienteBD(bancoDeDados);
            switch (acao)
            {
                case "I":
                    clienteAtivo = new Cliente(0,
                                                parametros[1].ToString(),//nome
                                                (DateTime)parametros[2],//DataNascimento
                                                parametros[3].ToString(),//telefone
                                                parametros[4].ToString(),//cpf
                                                parametros[5].ToString(),//email
                                                (Cidade) parametros[6]);
                    cliBD.incluir(clienteAtivo);
                    if(telaCadastroCliente != null)
                    {
                        telaCadastroCliente.tbCodigo.Text = clienteAtivo.Codigo.ToString();
                    }
                    //executar algum codigo
                    break;
                case "A":
                    clienteAtivo.Codigo = Convert.ToInt32(parametros[0].ToString());
                    clienteAtivo.Nome = parametros[1].ToString();
                    clienteAtivo.DataNasc = (DateTime)parametros[2];
                    clienteAtivo.Telefone = parametros[3].ToString();
                    clienteAtivo.Cpf = parametros[4].ToString();
                    clienteAtivo.Email = parametros[5].ToString();
                    clienteAtivo.Cidade = (Cidade)parametros[6];
                    cliBD.alterar(clienteAtivo);
                    break;
                case "E":
                    cliBD.excluir(clienteAtivo);
                    clienteAtivo = null;
                    break;
                case "P":
                    DataTable dtCliente = new DataTable();
                    dtCliente.Columns.Add("codigo", typeof(int));
                    dtCliente.Columns.Add("nome");
                    dtCliente.Columns.Add("dataNasc", typeof(DateTime));
                    dtCliente.Columns.Add("cpf");
                    dtCliente.Columns.Add("telefone");
                    dtCliente.Columns.Add("email");
                    dtCliente.Columns.Add("Cidade", typeof(Cidade));
                    dtCliente.Columns.Add("cod_cid",typeof(int));

                    foreach (Cliente cli in cliBD.consulta(parametros[0].ToString()))
                    {
                        DataRow linha = dtCliente.NewRow();
                        linha["codigo"] = cli.Codigo;
                        linha["nome"] = cli.Nome;
                        linha["dataNasc"] = cli.DataNasc;
                        linha["cpf"] = cli.Cpf;
                        linha["telefone"] = cli.Telefone;
                        linha["email"] = cli.Email;
                        linha["Cidade"] = cli.Cidade;
                        linha["cod_cid"] = cli.Cidade.Codigo;
                        dtCliente.Rows.Add(linha);
                    }
                    telaCadastroCliente.dgvClientes.DataSource = dtCliente;
                    break;
                default:
                    break;
            }
        }
    }

    public enum TIPO_BD { SQLSERVER, ORACLE, MYSQL, FIREBIRD}
}
