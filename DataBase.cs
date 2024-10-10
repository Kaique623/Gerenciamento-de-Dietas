using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Gerenciamento_de_Dietas
{
    public static class DataBase
    {
        public static MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=dietas;User=root;Password=acesso123;");
        public static MySqlDataAdapter adapter = new MySqlDataAdapter();
        public static MySqlCommand mycommand = new MySqlCommand();

        public static DataSet FillDataSet(List<string> tables, string condition){

            DataSet data = new DataSet();

            string startcondition = condition;

            foreach (string value in tables)
            {
                
                string query = "SELECT * FROM";
                if (value == "usuario")
                {
                    query = "SELECT usuario.id AS 'Id', usuario.nome AS 'Nome', usuario.tipo AS 'Tipo', dieta.nome AS 'Dieta', usuario.Genero, usuario.Idade, usuario.Altura, usuario.Peso, usuario.email FROM ";
                    condition += "LEFT JOIN dieta ON dieta.id = usuario.dieta";
                }
                else if (value == "refeicao")
                {
                    query = "SELECT refeicao.id as 'Id', refeicao.nome as 'Nome', refeicao.horario as 'Horario', dieta.nome as 'Dieta' FROM ";
                    condition += "LEFT JOIN dieta ON dieta.id = refeicao.id_dieta";
                }
                else if (value == "refeicao_alimento")
                {
                    query = "SELECT refeicao.nome AS 'refeicao', alimento.nome AS 'alimento', refeicao_alimento.quantidade, refeicao_alimento.medida as 'Medida' FROM ";
                    condition = "LEFT JOIN refeicao ON refeicao.id = refeicao_alimento.id_refeicao " +
                                "LEFT JOIN alimento ON alimento.id = refeicao_alimento.id_alimento ";
                }

                condition += startcondition;
                data.Tables.Add();
                adapter.SelectCommand = new MySqlCommand($"{query} {value} {condition}", connection);
                try
                {
                    adapter.Fill(data.Tables[tables.IndexOf(value)]);
                }
                catch {
                    MessageBox.Show("Erro ao Carregar DB");
                }
                condition = startcondition;
            }

            return data;
        }

        public static DataTable SearchContent(string table, string condition)
        {
            DataTable ds = new DataTable();
            
            if (table == "refeicao")
                adapter.SelectCommand = new MySqlCommand($"SELECT {table}.id as Id, {table}.nome as Nome, " +
                    $"{table}.horario as Horario, dieta.nome as Dieta FROM {table} LEFT JOIN dieta ON dieta.id = " +
                    $"{table}.id_dieta {condition}" , connection);
            else if (table == "usuario")
                adapter.SelectCommand = new MySqlCommand($"SELECT {table}.id as Id, {table}.nome as Nome, " +
                    $"{table}.tipo as Tipo, dieta.nome as Dieta, {table}.Genero, {table}.Idade, {table}.Altura, {table}.Peso,{table}.email as Email FROM {table} LEFT JOIN dieta ON dieta.id = " +
                    $"{table}.dieta {condition}", connection);
            else
                adapter.SelectCommand = new MySqlCommand($"SELECT * FROM {table} {condition}" , connection);
            adapter.Fill(ds);

            return ds;
        }

        public static void ExecuteCommand(string query)
        {
            new MySqlCommand(query, connection).ExecuteNonQuery();
        }
        public static object ExecuteScalarCommand(string query)
        {
            return new MySqlCommand(query, connection).ExecuteScalar();
        }

        public static DataTable returnColumn(string query)
        {
            DataTable ds = new DataTable();

            adapter.SelectCommand = new MySqlCommand(query, connection);
            adapter.Fill(ds);

            return ds;
        }
    }
}
