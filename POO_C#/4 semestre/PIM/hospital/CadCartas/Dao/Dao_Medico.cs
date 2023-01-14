using Medico.Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medico.Dao
{
    internal class Dao_Medico
    {
        OleDbConnection conexao;

        public Dao_Medico(string banco)
        {
            // conexao = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source ="+banco+"; Extended Properties =’Excel 12.0 Xml; HDR = YES’;");
            conexao = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source =" + banco + "; Extended Properties = 'Excel 8.0;HDR=YES;ReadOnly=False'");
        }

        public void create(medico medico)
        {
            string comandoSql = "INSERT INTO [Medico$] ([CPF],[RG],[NOME],[CRM],[TELEFONE],[SEXO],[DATANASCIMENTO],[ENDERECO],[ESPECIALIDADE]) VALUES (@CPF,@RG,@NOME,@CRM,@TELEFONE,@SEXO,@DATANASCIMENTO,@ENDERECO,@ESPECIALIDADE)";


            OleDbCommand comando = new OleDbCommand(comandoSql, conexao);

            comando.Parameters.Add("@CPF", OleDbType.Integer).Value = Convert.ToInt16(medico.cpf);
            comando.Parameters.Add("@RG", OleDbType.Integer).Value = Convert.ToInt16(medico.rg);
            comando.Parameters.Add("@NOME", OleDbType.VarChar, 255).Value = medico.nome;
            comando.Parameters.Add("@CRM", OleDbType.Integer).Value = Convert.ToInt16(medico.CRM);
            comando.Parameters.Add("@TELEFONE", OleDbType.Integer).Value = Convert.ToInt16(medico.numero);
            comando.Parameters.Add("@SEXO", OleDbType.VarChar, 255).Value = medico.sexo;
            comando.Parameters.Add("@DATANASCIMENTO", OleDbType.Integer).Value = Convert.ToInt16(medico.datanascimento);
            comando.Parameters.Add("@ENDERECO", OleDbType.VarChar, 255).Value = medico.endereco;
            comando.Parameters.Add("@ESPECIALIDADE", OleDbType.VarChar, 255).Value = medico.especialidade;

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

        public medico read(medico medico)
        {
            string comandoSql = "select * from [Medico$] Where CPF =" + medico.cpf;

            OleDbCommand comando = new OleDbCommand(comandoSql, conexao);

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                OleDbDataReader rd = comando.ExecuteReader();

                while (rd.Read())
                {

                    medico.cpf = Convert.ToInt16(rd["CPF"]);
                    medico.rg = Convert.ToInt16(rd["RG"]);
                    medico.nome = Convert.ToString(rd["NOME"]);
                    medico.CRM = Convert.ToInt16(rd["CRM"]);
                    medico.numero = Convert.ToInt16(rd["TELEFONE"]);
                    medico.sexo = Convert.ToString(rd["SEXO"]);
                    medico.datanascimento = Convert.ToInt16(rd["DATANASCIMENTO"]);
                    medico.endereco = Convert.ToString(rd["ENDERECO"]);
                    medico.especialidade = Convert.ToString(rd["ESPECIALIDADE"]);

                }



                return medico;


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

        public void update(medico medico)
        {
            string comandoSql = "UPDATE [Medico$] SET [RG] = @RG, [NOME] = @NOME, [CRM] = @CRM, [TELEFONE] = @TELEFONE, [SEXO] = @SEXO,[DATANASCIMENTO] = @DATANASCIMENTO,[ENDERECO] = @ENDERECO,[ESPECIALIDADE] = @ESPECIALIDADE WHERE [CPF] = @CPF ";


            OleDbCommand comando = new OleDbCommand(comandoSql, conexao);

            comando.Parameters.Add("@RG", OleDbType.Integer).Value = Convert.ToInt16(medico.rg);
            comando.Parameters.Add("@NOME", OleDbType.VarChar, 255).Value = medico.nome;
            comando.Parameters.Add("@CRM", OleDbType.Integer).Value = Convert.ToInt16(medico.CRM);
            comando.Parameters.Add("@TELEFONE", OleDbType.Integer).Value = Convert.ToInt16(medico.numero);
            comando.Parameters.Add("@CPF", OleDbType.Integer).Value = Convert.ToInt16(medico.cpf);
            comando.Parameters.Add("@SEXO", OleDbType.VarChar, 255).Value = medico.sexo;
            comando.Parameters.Add("@DATANASCIMENTO", OleDbType.Integer).Value = Convert.ToInt16(medico.datanascimento);
            comando.Parameters.Add("@ENDERECO", OleDbType.VarChar, 255).Value = medico.endereco;
            comando.Parameters.Add("@ESPECIALIDADE", OleDbType.VarChar, 255).Value = medico.especialidade;

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

        public void delete(medico medico)
        {
            string comandoSql = "DELETE FROM [Medico$] WHERE [CPF] = @CPF ";


            OleDbCommand comando = new OleDbCommand(comandoSql, conexao);

            comando.Parameters.Add("@CPF", OleDbType.Integer).Value = Convert.ToInt16(medico.cpf);

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
