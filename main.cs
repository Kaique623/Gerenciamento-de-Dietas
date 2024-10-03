using System.Data;

namespace Gerenciamento_de_Dietas
{
    public partial class MainApp : Form
    {   
        List<string> tables = new List<string>() {"usuario", "dieta", "alimento","refeicao", "refeicao_alimento"};

        string current_table = "usuario";
        DataGridViewButtonColumn visualizar_alimento = new System.Windows.Forms.DataGridViewButtonColumn();

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
            UserDataGrid.AutoGenerateColumns = true;
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
            else if (buttonText == "Alimentos")
            {
                current_table = "alimento";
                UserDataGrid.DataSource = data.Tables[2];
            }
            else if (buttonText == "Refeições")
            {
                current_table = "refeicao";
                UserDataGrid.DataSource = data.Tables[3];
                try
                {
                    UserDataGrid.AutoGenerateColumns = false;

                    visualizar_alimento.HeaderText = "";
                    visualizar_alimento.Name = "visualizar_alimento";
                    visualizar_alimento.ReadOnly = true;
                    visualizar_alimento.Visible = true;
                    visualizar_alimento.Text = "Visualizar Alimentos";
                    visualizar_alimento.UseColumnTextForButtonValue = true;
                }
                catch
                {
                    Console.WriteLine("Erro ao adicionar Coluna (Já Existente)");
                }


                UserDataGrid.Columns.Add(visualizar_alimento);
            }
            if (buttonText != "Refeições")
            {
                try
                {
                    UserDataGrid.Columns.Remove(visualizar_alimento);
                }
                catch
                {
                    Console.WriteLine("Coluna Inexistente");
                }
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
           addScreen.currentTable = current_table;
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
                addScreen.id = Convert.ToString(UserDataGrid.SelectedRows[0].Cells[0].Value);
                addScreen.entry1 = Convert.ToString(UserDataGrid.SelectedRows[0].Cells[1].Value);
                addScreen.entry2 = Convert.ToString(UserDataGrid.SelectedRows[0].Cells[2].Value);
                if (current_table != "dieta")
                addScreen.entry3 = Convert.ToString(UserDataGrid.SelectedRows[0].Cells[3].Value);

                if (current_table == "alimento")
                {
                    addScreen.entry4 = Convert.ToString(UserDataGrid.SelectedRows[0].Cells[4].Value);
                    addScreen.entry5 = Convert.ToString(UserDataGrid.SelectedRows[0].Cells[5].Value);
                }

                addScreen.editMode = true;
                addScreen.currentTable = current_table;

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
                    if (MessageBox.Show($"Deseja Remover: {row.Cells[1].Value} ?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        //Remoção do Usuário selecionado
                        DataBase.ExecuteCommand($"DELETE FROM {current_table} WHERE id='{row.Cells[0].Value}'");
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
            MessageBox.Show("Dados Recarregados!");
        }

        private void UserDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (current_table == "refeicao" && UserDataGrid.Columns[e.ColumnIndex].CellType == typeof(DataGridViewButtonCell))
            {
                addForm addScreen = new addForm();
                addScreen.TopLevel = false;
                UserDataGrid.Visible = false;
                UserDataGrid.Enabled = false;
                MainSplitScreen.Panel2.Controls.Add(addScreen);
                addScreen.currentTable = current_table;
                MainSplitScreen.Panel1Collapsed = true;
                this.TopLevel = true;
                addScreen.Alimentos = true;
                addScreen.addFormClosed += addFormClosed;
                addScreen.Show();
            }
            else
            {
                MessageBox.Show(Convert.ToString(typeof(DataGridViewButtonCell)));
                MessageBox.Show(Convert.ToString(UserDataGrid.Columns[e.ColumnIndex].CellType));
            }
        }
    }
}