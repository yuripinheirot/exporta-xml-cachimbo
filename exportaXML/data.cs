using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;

namespace exportaXML
{
    class DataFirebird
    {
        static string server = Properties.Settings.Default["conexaoDB"].ToString();
        static FbConnection conexao = null;

        public Dictionary<string, string> xmlsFromDatabase(string dti, string dtf)
        {
            try
            {
                conexao = new FbConnection(server);
                conexao.Open();
                string query =
                    "select                                                                     " +
                    "a.numerodunfe,                                                             " +
                    "case                                                                       " +
                    "when b.nome || '-' || b.cpf is null then 'INDEFINIDO'                      " +
                    "else                                                                       " +
                    "b.nome || '-' || b.cpf                                                     " +
                    "end as vendedor                                                            " +
                    "from tvenpedido a                                                          " +
                    "inner                                                                      " +
                    "join tvenvendedor b on (a.empresa = b.empresa and a.vendedor = b.codigo)   " +
                    "where                                                                      " +
                    $"a.data between '{dti}' and '{dtf}'                                        " +
                    "and a.numerodunfe is not null                                              " +
                    "and a.numerodunfe <> ''                                                    " +
                    "and a.nfeletronica = 'S'                                                   " +
                    "order by 1 asc                                                             ";
                FbCommand cmd = new FbCommand(query, conexao);
                FbDataReader reader = cmd.ExecuteReader();
                Dictionary<string, string> temp = new Dictionary<string, string>();

                while (reader.Read())
                {
                    temp.Add(reader["numerodunfe"].ToString(), reader["vendedor"].ToString());
                }

                return temp;
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
