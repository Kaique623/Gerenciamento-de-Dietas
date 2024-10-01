using MySql.Data.MySqlClient;
using System.Data;

namespace Gerenciamento_de_Dietas
{
    public partial class MainApp : Form
    {
        public static MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=dietas;User=root;Password=acesso123;");
        
        MySqlDataAdapter adapter = new MySqlDataAdapter();

        List<string> tables = new List<string>() {"usuario", "dieta", "alimento","refeicao", "refeicao_alimento"};

        string current_table = "usuario";

        DataSet data = new DataSet();

        public MainApp()
        {
            InitializeComponent();
            connection.Open();

            LoadAllTables("usuario");
        }

        void LoadAllTables(string table)
        {
            data.Tables.Clear();
            foreach (string value in tables)
            {
                data.Tables.Add();
                adapter.SelectCommand = new MySqlCommand($"Select * FROM {value}", connection);
                adapter.Fill(data.Tables[tables.IndexOf(value)]);
            }
            UserDataGrid.DataSource = data.Tables[tables.IndexOf(table)];
        }

        private void TabButtonClick(object sender, EventArgs e)
        {
            string buttonText = ((Button)sender).Text;

            if (buttonText == "Usuários")
            {
                current_table = "usuario";
                UserDataGrid.DataSource = data.Tables[0];
            } 
            else if (buttonText == "Dietas")
            {
                current_table = "dieta";
                UserDataGrid.DataSource = data.Tables[1];
            }    
            else if(buttonText == "Alimentos")
            {
                current_table = "alimento";
                UserDataGrid.DataSource = data.Tables[2];
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string columnsConditional = "WHERE ";
            foreach (DataGridViewColumn column in UserDataGrid.Columns)
            {
                if (columnsConditional == "WHERE ")
                    columnsConditional += $"{column.Name} LIKE '%{SearchText.Text}%'";
                else
                    columnsConditional += $" OR {column.Name} LIKE '%{SearchText.Text}%'";
            }

            DataSet ds = new DataSet();
            ds.Tables.Add();
            adapter.SelectCommand = new MySqlCommand($"SELECT * FROM {current_table} {columnsConditional}" , connection);
            adapter.Fill(ds.Tables[0]);
            UserDataGrid.DataSource = ds.Tables[0];
        }
    }
}