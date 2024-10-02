using System.Data;

namespace Gerenciamento_de_Dietas
{
    public partial class MainApp : Form
    {   
        List<string> tables = new List<string>() {"usuario", "dieta", "alimento","refeicao", "refeicao_alimento"};

        string current_table = "usuario";

        DataSet data = new DataSet();

        public MainApp()
        {
            InitializeComponent();
            // Abre conexão e Carrega as Tabelas
            DataBase.connection.Open();
            data = DataBase.FillDataSet(tables);
            UserDataGrid.DataSource = data.Tables[0];
        }

        private void TabButtonClick(object sender, EventArgs e)
        {
            string buttonText = ((Button)sender).Text;
            // Muda DataGrid Atual
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
            // Gera as Condições de Pesquisa
            foreach (DataGridViewColumn column in UserDataGrid.Columns)
            {
                if (columnsConditional == "WHERE ")
                    columnsConditional += $"{column.Name} LIKE '%{SearchText.Text}%'";
                else
                    columnsConditional += $" OR {column.Name} LIKE '%{SearchText.Text}%'";
            }
            // Mostra elementos Próximos aos pesquisados
            UserDataGrid.DataSource = DataBase.SearchContent(current_table, columnsConditional);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
           addForm addScreen = new addForm();

           addScreen.TopLevel = false;
           this.TopLevel = true;
           MainSplitScreen.Panel2.Controls.Add(addScreen);
           // Desabilita o UserDataGrid Para inserção da tela de Adição
           UserDataGrid.Visible = false;
           UserDataGrid.Enabled = false;
           // Adiciona Função a ser chamada quando o Formulário for fechado
           addScreen.addFormClosed += addFormClosed;
           // Desabilita Cabeçalho/Dashboard
           MainSplitScreen.Panel1Collapsed = true;

           addScreen.Show();
        }

        private void addFormClosed(object sender, EventArgs e)
        {
            // Redefine as Intancias (UserDatagrid, Painel)
            data = DataBase.FillDataSet(tables);
            UserDataGrid.DataSource = data.Tables[tables.IndexOf(current_table)];
            UserDataGrid.Visible = true;
            UserDataGrid.Enabled = true;
            MainSplitScreen.Panel1Collapsed = false;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Coleta as Informações da Fileira
                addForm addScreen = new addForm();
                addScreen.id = (int)UserDataGrid.SelectedRows[0].Cells[0].Value;
                addScreen.nomeText = (string)UserDataGrid.SelectedRows[0].Cells[1].Value;
                addScreen.emailtext = (string)UserDataGrid.SelectedRows[0].Cells[2].Value;
                addScreen.tipotext = (string)UserDataGrid.SelectedRows[0].Cells[3].Value;
                addScreen.editMode = true;

                // Abre Tela de adição
                addScreen.TopLevel = false;
                this.TopLevel = true;
                MainSplitScreen.Panel2.Controls.Add(addScreen);
                UserDataGrid.Visible = false;
                UserDataGrid.Enabled = false;
                addScreen.addFormClosed += addFormClosed;
                MainSplitScreen.Panel1Collapsed = true;

                addScreen.Show();
            }

            catch
            {
                MessageBox.Show("Nenhuma Fileira Selecionada!");
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (UserDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma Fileira Selecionada!");
            }
            else
            {
                foreach (DataGridViewRow row in UserDataGrid.SelectedRows)
                {
                    if (MessageBox.Show($"Deseja Remover o Usuário: {row.Cells[1].Value} ?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        //Remoção do Usuário selecionado
                        DataBase.ExecuteCommand($"DELETE FROM usuario WHERE id='{row.Cells[0].Value}'");
                        UserDataGrid.Rows.RemoveAt(row.Index);
                    }

                }
            }
        }

        private void RecarregarPagina_Click(object sender, EventArgs e)
        {
            data.Tables.Clear();
            data = DataBase.FillDataSet(tables);
            UserDataGrid.DataSource = data.Tables[tables.IndexOf(current_table)];
        }
    }
}