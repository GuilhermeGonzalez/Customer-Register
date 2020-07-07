using Microsoft.Reporting.WinForms;
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
    class ControladoraCadastroTitular : IObservador
    {
        private static ControladoraCadastroTitular instancia = null;
        private static Object trava = new object();
        private Banco bancoDeDados;
        private Titular titularAtivo;
        FTitular telaCadastroTitular;
        

        public static ControladoraCadastroTitular obterInstancia()
        {
            lock (trava)
            {
                if(instancia == null)
                {
                    instancia = new ControladoraCadastroTitular(TIPO_BD.SQLSERVER);
                }
                return instancia;
            }
        }

        public void mostrarTelaCadastroTitular()
        {
            PlanoSaudeBD planoSaudeBD = new PlanoSaudeBD(this.bancoDeDados);
            telaCadastroTitular = new FTitular();
            telaCadastroTitular.adicionarObservadores(this);

            telaCadastroTitular.cbModalidade.DataSource = planoSaudeBD.consulta("");
            telaCadastroTitular.cbModalidade.DisplayMember ="descricao";
            telaCadastroTitular.cbModalidade.ValueMember = "codigo";
            telaCadastroTitular.ShowDialog();
        }

        private ControladoraCadastroTitular(TIPO_BD tipoDeBanco)
        {
            if(tipoDeBanco == TIPO_BD.SQLSERVER)
            {
                bancoDeDados = new BancoSQLServer();
            }
        }
        
       
        public void notificar(string acao, params object[] parametros)
        {
            //ERRO --> NAO ESTA INSERINDO NO BANCO, TENTAMOS DE DIVERSAS FORMAS CORRIGIR MAS NAO
            //         ESTAVA DANDO CERTO.
            TitularBD titBD = new TitularBD(bancoDeDados);
            PlanoSaudeBD psBD = new PlanoSaudeBD(bancoDeDados);

            ReportParameter[] paramRel = new ReportParameter[1];    //CONSTANTE QUE
            paramRel[0] = new ReportParameter("usuario", "Hugo");   //DEFINE USUÁRIO

            if (acao != "P" && (bool)parametros[12] == true)
            {
                PlanoSaude teste = (PlanoSaude)parametros[11];
                PlanoSaude plano = psBD.consulta(teste.Codigo);
                telaCadastroTitular.dtpVini.Text = plano.Vigencia_ini.ToString();
                telaCadastroTitular.dtpVfim.Text = plano.Vigencia_fim.ToString();

            }
            else
            {
                switch (acao)
                {
                    case "I":
                        titularAtivo = new Titular(parametros[0].ToString(),
                                                 parametros[1].ToString(),
                                                 (DateTime)parametros[2],
                                                 parametros[3].ToString(),
                                                 parametros[4].ToString(),
                                                 parametros[5].ToString(),
                                                 parametros[6].ToString(),
                                                 parametros[7].ToString(),
                                                 parametros[8].ToString(),
                                                 parametros[9].ToString(),
                                                 parametros[10].ToString(),
                                                 (PlanoSaude)parametros[11]);
                        titBD.incluir(titularAtivo);
                        if (telaCadastroTitular != null)
                        {
                            telaCadastroTitular.tbCPF.Text = titularAtivo.Cpf_tit.ToString();
                        }


                        break;
                    case "A":
                        titularAtivo.Cpf_tit = parametros[0].ToString();
                        titularAtivo.Nome = parametros[1].ToString();
                        titularAtivo.Dt_nasc = (DateTime)parametros[2];
                        titularAtivo.Estado_civil = parametros[3].ToString();
                        titularAtivo.Email = parametros[4].ToString();
                        titularAtivo.Telefone = parametros[5].ToString();
                        titularAtivo.Celular = parametros[6].ToString();
                        titularAtivo.Cidade = parametros[7].ToString();
                        titularAtivo.Endereco = parametros[8].ToString();
                        titularAtivo.Uf = parametros[9].ToString();
                        titularAtivo.Sexo = parametros[10].ToString();
                        titularAtivo.Plano = (PlanoSaude)parametros[11];

                        titBD.alterar(titularAtivo);
                        break;
                    case "E":
                        titBD.excluir(titularAtivo);
                        titularAtivo = null;
                        break;
                    case "P":
                        DataTable dtTitular = new DataTable();
                        dtTitular.Columns.Add("cpf");
                        dtTitular.Columns.Add("nome");
                        dtTitular.Columns.Add("dataNasc", typeof(DateTime));
                        dtTitular.Columns.Add("estadoCivil");
                        dtTitular.Columns.Add("email");
                        dtTitular.Columns.Add("telefone");
                        dtTitular.Columns.Add("celular");
                        dtTitular.Columns.Add("cidade");
                        dtTitular.Columns.Add("endereco");
                        dtTitular.Columns.Add("uf");
                        dtTitular.Columns.Add("sexo");
                        dtTitular.Columns.Add("planoSaude", typeof(PlanoSaude));
                        dtTitular.Columns.Add("cod_p", typeof(PlanoSaude));

                        foreach (Titular tit in titBD.consulta(parametros[0].ToString()))
                        {
                            DataRow linha = dtTitular.NewRow();
                            linha["cpf"] = tit.Cpf_tit;
                            linha["nome"] = tit.Nome;
                            linha["dataNasc"] = tit.Dt_nasc;
                            linha["estadoCivil"] = tit.Estado_civil;
                            linha["email"] = tit.Email;
                            linha["telefone"] = tit.Telefone;
                            linha["celular"] = tit.Celular;
                            linha["cidade"] = tit.Cidade;
                            linha["endereco"] = tit.Endereco;
                            linha["uf"] = tit.Uf;
                            linha["sexo"] = tit.Sexo;
                            linha["planoSaude"] = tit.Plano;
                            linha["cod_p"] = tit.Plano;
                            dtTitular.Rows.Add(linha);
                        }
                        telaCadastroTitular.dgvTitular.DataSource = dtTitular;
                        break;
                    case "RTC":                        
                        processaRelatorio(telaCadastroTitular.visualizadorRel,
                                            @"..\..\Relatorios\RelatorioSimplesCliente.rdlc",
                                            "DSClientes",
                                            titBD.consulta(""),
                                            paramRel);
                        break;
                    case "RCA":
                        processaRelatorio(telaCadastroTitular.visualizadorRel,
                                            @"..\..\Relatorios\RelatorioClientesAgrupadoPorPlanoDeSaude.rdlc",
                                            "DsPlano",
                                            titBD.consulta(""),
                                            paramRel);
                        break;
                    default:
                        break;
                }
            }
                
            
            
        }
        public void processaRelatorio(ReportViewer visualizador,
                                        string caminhoArquivoRelatorio,
                                        string nomeFonteDeDados,
                                        List<Titular> dados,
                                        ReportParameter[] parametros)
        {
            visualizador.Reset();
            visualizador.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource(nomeFonteDeDados, dados);
            visualizador.LocalReport.DataSources.Add(rds);
            visualizador.LocalReport.ReportPath = caminhoArquivoRelatorio;
            if (parametros != null)
            {
                visualizador.LocalReport.SetParameters(parametros);
            }
            visualizador.RefreshReport();
        }
    }

    public enum TIPO_BD { SQLSERVER, ORACLE, MYSQL, FIREBIRD}
}