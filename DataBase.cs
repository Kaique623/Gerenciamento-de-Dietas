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
            

            foreach (string value in tables)
            {
                data.Tables.Add();
                adapter.SelectCommand = new MySqlCommand($"Select * FROM {value} {condition}", connection);
                adapter.Fill(data.Tables[tables.IndexOf(value)]);
            }

            return data;
        }

        public static DataTable SearchContent(string table, string condition)
        {
            DataTable ds = new DataTable();
            
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
