using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using Paciente.Model;
using Medico.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Diagnostics;

namespace Paciente.Dao
{
    class Dao_paciente
    {
        OleDbConnection conexao;

        public Dao_paciente(string banco)
        {
            // conexao = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source ="+banco+"; Extended Properties =’Excel 12.0 Xml; HDR = YES’;");
            conexao = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source ="+banco+"; Extended Properties = 'Excel 8.0;HDR=YES;ReadOnly=False'");
        }

        public void create(paciente paciente)
        {
            string comandoSql = "INSERT INTO [Paciente$] ([CPF],[RG],[NOME],[TIPOSANGUINEO],[TELEFONE],[SEXO],[DATANASCIMENTO],[ENDERECO],[CONVENIO]) VALUES (@CPF,@RG,@NOME,@TIPOSANGUINEO,@TELEFONE,@SEXO,@DATANASCIMENTO,@ENDERECO,@CONVENIO)";


            OleDbCommand comando = new OleDbCommand(comandoSql, conexao);

            comando.Parameters.Add("@CPF", OleDbType.Integer).Value = Convert.ToInt16(paciente.cpf);
            comando.Parameters.Add("@RG", OleDbType.Integer).Value = Convert.ToInt16(paciente.rg);
            comando.Parameters.Add("@NOME", OleDbType.VarChar, 255).Value = paciente.nome;
            comando.Parameters.Add("@TIPOSANGUINEO", OleDbType.VarChar, 255).Value = paciente.tiposanguineo;
            comando.Parameters.Add("@TELEFONE", OleDbType.Integer).Value = Convert.ToInt16(paciente.numero);
            comando.Parameters.Add("@SEXO", OleDbType.VarChar, 255).Value = paciente.sexo;
            comando.Parameters.Add("@DATANASCIMENTO", OleDbType.Integer).Value = Convert.ToInt16(paciente.datanascimento);
            comando.Parameters.Add("@ENDERECO", OleDbType.VarChar, 255).Value = paciente.endereco;
            comando.Parameters.Add("@CONVENIO", OleDbType.VarChar, 255).Value = paciente.convenio;

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

        public paciente read(paciente paciente)
        {
            string comandoSql = "select * from [Paciente$] Where CPF =" + paciente.cpf;

            OleDbCommand comando = new OleDbCommand(comandoSql, conexao);

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                OleDbDataReader rd = comando.ExecuteReader();

                while (rd.Read())
                {

                    paciente.cpf = Convert.ToInt16(rd["CPF"]);
                    paciente.rg = Convert.ToInt16(rd["RG"]);
                    paciente.nome = Convert.ToString(rd["NOME"]);
                    paciente.tiposanguineo = Convert.ToString(rd["TIPOSANGUINEO"]);
                    paciente.numero = Convert.ToInt16(rd["TELEFONE"]);
                    paciente.sexo = Convert.ToString(rd["SEXO"]);
                    paciente.datanascimento = Convert.ToInt16(rd["DATANASCIMENTO"]);
                    paciente.endereco = Convert.ToString(rd["ENDERECO"]);
                    paciente.convenio = Convert.ToString(rd["CONVENIO"]);

                }
                
                

                return paciente;
                

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

        public void update(paciente paciente)
        {
            string comandoSql = "UPDATE [Paciente$] SET [RG] = @RG, [NOME] = @NOME, [TIPOSANGUINEO] = @TIPOSANGUINEO, [TELEFONE] = @TELEFONE, [SEXO] = @SEXO,[DATANASCIMENTO] = @DATANASCIMENTO,[ENDERECO] = @ENDERECO,[CONVENIO] = @CONVENIO WHERE [CPF] = @CPF ";
            

            OleDbCommand comando = new OleDbCommand(comandoSql, conexao);

            comando.Parameters.Add("@RG", OleDbType.Integer).Value = Convert.ToInt16(paciente.rg);
            comando.Parameters.Add("@NOME", OleDbType.VarChar, 255).Value = paciente.nome;
            comando.Parameters.Add("@TIPOSANGUINEO", OleDbType.VarChar, 255).Value = paciente.tiposanguineo;
            comando.Parameters.Add("@TELEFONE", OleDbType.Integer).Value = Convert.ToInt16(paciente.numero);
            comando.Parameters.Add("@CPF", OleDbType.Integer).Value = Convert.ToInt16(paciente.cpf);
            comando.Parameters.Add("@SEXO", OleDbType.VarChar, 255).Value = paciente.sexo;
            comando.Parameters.Add("@DATANASCIMENTO", OleDbType.Integer).Value = Convert.ToInt16(paciente.datanascimento);
            comando.Parameters.Add("@ENDERECO", OleDbType.VarChar, 255).Value = paciente.endereco;
            comando.Parameters.Add("@CONVENIO", OleDbType.VarChar, 255).Value = paciente.convenio;

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

        public void delete(paciente paciente)
        {
            string comandoSql = "DELETE FROM [Paciente$] WHERE [CPF] = @CPF ";


            OleDbCommand comando = new OleDbCommand(comandoSql, conexao);

            comando.Parameters.Add("@CPF", OleDbType.Integer).Value = Convert.ToInt16(paciente.cpf);

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
