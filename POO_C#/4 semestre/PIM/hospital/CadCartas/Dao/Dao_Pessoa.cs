using Pessoa.Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa.Dao
{
    internal class Dao_pessoa
    {
        OleDbConnection conexao;

        public Dao_pessoa(string banco)
        {
            // conexao = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source ="+banco+"; Extended Properties =’Excel 12.0 Xml; HDR = YES’;");
            conexao = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source =" + banco + "; Extended Properties = 'Excel 8.0;HDR=YES;ReadOnly=False'");
        }

        public void create(pessoa pessoa)
        {
            string comandoSql = "INSERT INTO [Pessoa$] ([CPF],[RG],[NOME],[TELEFONE],[SEXO],[DATANASCIMENTO],[ENDERECO]) VALUES (@CPF,@RG,@NOME,@TELEFONE,@SEXO,@DATANASCIMENTO,@ENDERECO)";


            OleDbCommand comando = new OleDbCommand(comandoSql, conexao);

            comando.Parameters.Add("@CPF", OleDbType.Integer).Value = Convert.ToInt16(pessoa.cpf);
            comando.Parameters.Add("@RG", OleDbType.Integer).Value = Convert.ToInt16(pessoa.rg);
            comando.Parameters.Add("@NOME", OleDbType.VarChar, 255).Value = pessoa.nome;
            comando.Parameters.Add("@TELEFONE", OleDbType.Integer).Value = Convert.ToInt16(pessoa.numero);
            comando.Parameters.Add("@SEXO", OleDbType.VarChar, 255).Value = pessoa.sexo;
            comando.Parameters.Add("@DATANASCIMENTO", OleDbType.Integer).Value = Convert.ToInt16(pessoa.datanascimento);
            comando.Parameters.Add("@ENDERECO", OleDbType.VarChar, 255).Value = pessoa.endereco;

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                conexao.Close();

            }
        }

        public pessoa read(pessoa pessoa)
        {
            string comandoSql = "select * from [Pessoa$] Where CPF =" + pessoa.cpf;

            OleDbCommand comando = new OleDbCommand(comandoSql, conexao);

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                OleDbDataReader rd = comando.ExecuteReader();

                while (rd.Read())
                {

                    pessoa.cpf = Convert.ToInt16(rd["CPF"]);
                    pessoa.rg = Convert.ToInt16(rd["RG"]);
                    pessoa.nome = Convert.ToString(rd["NOME"]);
                    pessoa.numero = Convert.ToInt16(rd["TELEFONE"]);
                    pessoa.sexo = Convert.ToString(rd["SEXO"]);
                    pessoa.datanascimento = Convert.ToInt16(rd["DATANASCIMENTO"]);
                    pessoa.endereco = Convert.ToString(rd["ENDERECO"]);

                }



                return pessoa;


            }
            catch
            {
                return null;
            }
            finally
            {
                conexao.Close();

            }
        }

        public void update(pessoa pessoa)
        {
            string comandoSql = "UPDATE [Pessoa$] SET [RG] = @RG, [NOME] = @NOME, [TELEFONE] = @TELEFONE, [SEXO] = @SEXO,[DATANASCIMENTO] = @DATANASCIMENTO,[ENDERECO] = @ENDERECO WHERE [CPF] = @CPF ";


            OleDbCommand comando = new OleDbCommand(comandoSql, conexao);

            comando.Parameters.Add("@RG", OleDbType.Integer).Value = Convert.ToInt16(pessoa.rg);
            comando.Parameters.Add("@NOME", OleDbType.VarChar, 255).Value = pessoa.nome;
            comando.Parameters.Add("@TELEFONE", OleDbType.Integer).Value = Convert.ToInt16(pessoa.numero);
            comando.Parameters.Add("@CPF", OleDbType.Integer).Value = Convert.ToInt16(pessoa.cpf);
            comando.Parameters.Add("@SEXO", OleDbType.VarChar, 255).Value = pessoa.sexo;
            comando.Parameters.Add("@DATANASCIMENTO", OleDbType.Integer).Value = Convert.ToInt16(pessoa.datanascimento);
            comando.Parameters.Add("@ENDERECO", OleDbType.VarChar, 255).Value = pessoa.endereco;

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                conexao.Close();

            }
        }

        public void delete(pessoa pessoa)
        {
            string comandoSql = "DELETE FROM [Pessoa$] WHERE [CPF] = @CPF ";


            OleDbCommand comando = new OleDbCommand(comandoSql, conexao);

            comando.Parameters.Add("@CPF", OleDbType.Integer).Value = Convert.ToInt16(pessoa.cpf);

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                conexao.Close();

            }
        }
    }
}
