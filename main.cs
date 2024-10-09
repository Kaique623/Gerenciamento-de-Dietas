using System.Data;
using System.Diagnostics;

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

            // Abre a conex�o com o banco de dados.
            DataBase.connection.Open();
            MessageBox.Show("Conex�o Aberta!");

            // Preenche o DataSet com as tabelas de dados especificadas (armazenadas na vari�vel 'tables').
            // O segundo argumento "" representa uma poss�vel condi��o ou filtro de consulta (aqui est� vazio).
            data = DataBase.FillDataSet(tables, "");

            // Define a fonte de dados do DataGrid como a primeira tabela do DataSet.
            UserDataGrid.DataSource = data.Tables[0];
            fillFilter();
        }

        private void fillFilter()
        {
            filter_combobox.Text = "Filtro";
            filter_combobox.Items.Clear();
            foreach (DataGridViewColumn column in UserDataGrid.Columns)
            {
                filter_combobox.Items.Add(column.HeaderText);
            }
        }

        private void TabButtonClick(object sender, EventArgs e)
        {
            try
            {
                // Tenta remover a coluna "visualizar_alimento" do DataGrid caso ela j� exista.
                UserDataGrid.Columns.Remove(visualizar_alimento);
            }
            catch
            {
                // Caso a coluna "visualizar_alimento" n�o exista, exibe uma mensagem no console.
                Console.WriteLine("Coluna Inexistente");
            }

            // Permite que o DataGrid gere as colunas automaticamente com base no DataSource.
            UserDataGrid.AutoGenerateColumns = true;

            // Obt�m o texto do bot�o que disparou o evento.
            string buttonText = ((Button)sender).Text;

            // Muda o DataGrid para a tabela de "Usu�rios" se o bot�o clicado for "Usu�rios".
            if (buttonText == "Usu�rios")
            {
                // Define a tabela atual como "usuario" e atualiza o DataSource com os dados de usu�rios.
                current_table = "usuario";
                UserDataGrid.DataSource = data.Tables[0];
            }
            // Muda o DataGrid para a tabela de "Dietas" se o bot�o clicado for "Dietas".
            else if (buttonText == "Dietas")
            {
                // Define a tabela atual como "dieta" e atualiza o DataSource com os dados de dietas.
                current_table = "dieta";
                UserDataGrid.DataSource = data.Tables[1];
            }
            // Muda o DataGrid para a tabela de "Alimentos" se o bot�o clicado for "Alimentos".
            else if (buttonText == "Alimentos")
            {
                // Define a tabela atual como "alimento" e atualiza o DataSource com os dados de alimentos.
                current_table = "alimento";
                UserDataGrid.DataSource = data.Tables[2];
            }
            // Muda o DataGrid para a tabela de "Refei��es" se o bot�o clicado for "Refei��es".
            else if (buttonText == "Refei��es")
            {
                // Define a tabela atual como "refeicao" e atualiza o DataSource com os dados de refei��es.
                current_table = "refeicao";
                UserDataGrid.DataSource = data.Tables[3];

                try
                {
                    // Desativa a gera��o autom�tica de colunas para personalizar as colunas manualmente.
                    UserDataGrid.AutoGenerateColumns = false;

                    // Configura a coluna "visualizar_alimento" como um bot�o.
                    visualizar_alimento.HeaderText = "";  // O cabe�alho da coluna ser� vazio.
                    visualizar_alimento.Name = "visualizar_alimento";  // Nome da coluna.
                    visualizar_alimento.ReadOnly = true;  // Define a coluna como somente leitura.
                    visualizar_alimento.Visible = true;  // Torna a coluna vis�vel.
                    visualizar_alimento.Text = "Visualizar Alimentos";  // Texto exibido no bot�o.
                    visualizar_alimento.UseColumnTextForButtonValue = true;  // Define o texto do bot�o.

                    // Adiciona a coluna de bot�o "visualizar_alimento" ao DataGrid.
                    UserDataGrid.Columns.Add(visualizar_alimento);

                    // Define a posi��o da coluna "visualizar_alimento" para ser a �ltima.
                    UserDataGrid.Columns["visualizar_alimento"].DisplayIndex = UserDataGrid.Columns.Count - 1;

                    // Define a posi��o da coluna "id" para ser a primeira.
                    try
                    {
                        UserDataGrid.Columns["id"].DisplayIndex = 0;
                    }
                    catch
                    {
                        MessageBox.Show("Erro ao Carregar DB");
                    }
                }
                catch
                {
                    // Caso j� exista uma coluna com o nome "visualizar_alimento", exibe uma mensagem no console.
                    Console.WriteLine("Erro ao adicionar Coluna (J� Existente)");
                }
            }
            fillFilter();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string columnName = filter_combobox.Text;
            string searchTextAux = SearchText.Text;

            if (columnName == "Dieta")
            {
                columnName = "dieta.nome";
            }
                

            // Atualiza o DataGrid com os resultados da busca
            MessageBox.Show(columnName);
            UserDataGrid.DataSource = DataBase.SearchContent(current_table, $"WHERE {columnName} LIKE '%{SearchText.Text}%'");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Cria��o da tela de adi��o
            addForm addScreen = new addForm();

            // Configura��o de hierarquia dos formul�rios
            addScreen.TopLevel = false;
            this.TopLevel = true;

            // Adiciona o formul�rio de adi��o ao painel secund�rio
            InformationContainer.Panel2.Controls.Add(addScreen);

            // Registra o evento para quando o formul�rio de adi��o for fechado
            addScreen.addFormClosed += addFormClosed;

            // Define a tabela atual no formul�rio de adi��o
            addScreen.currentTable = current_table;

            // Inicializa a tela de adi��o
            addScreen.startup();

            CollapsePanels();

            // Exibe o formul�rio de adi��o
            addScreen.Show();
        }

        private void addFormClosed(object sender, EventArgs e)
        {
            // Recarrega as tabelas de dados do banco de dados
            data = DataBase.FillDataSet(tables, "");

            // Define a fonte de dados do UserDataGrid para a tabela atualizada
            UserDataGrid.DataSource = data.Tables[tables.IndexOf(current_table)];

            // Torna o UserDataGrid vis�vel e habilitado novamente
            UserDataGrid.Visible = true;
            UserDataGrid.Enabled = true;

            // Reexpande o painel principal (cabe�alho ou dashboard)
            InformationContainer.Panel1Collapsed = false;
            MainSplitScreen.Panel1Collapsed = false;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            // Cria uma nova tela de adi��o no modo de edi��o
            addForm addScreen = new addForm();
            addScreen.editMode = true;

            try
            {
                // Coleta os dados da linha selecionada no UserDataGrid

                // Coleta o valor da primeira c�lula (ID)
                addScreen.id = Convert.ToString(UserDataGrid.SelectedRows[0].Cells[0].Value);

                // Coleta o valor da segunda e terceira c�lula (campos de entrada)
                addScreen.entry1 = Convert.ToString(UserDataGrid.SelectedRows[0].Cells[1].Value);
                addScreen.entry2 = Convert.ToString(UserDataGrid.SelectedRows[0].Cells[2].Value);

                // Se a tabela atual n�o for "dieta", coleta o valor da terceira entrada
                if (current_table != "dieta")
                    addScreen.entry3 = Convert.ToString(UserDataGrid.SelectedRows[0].Cells[3].Value);

                // Se a tabela atual for "alimento", coleta valores extras
                if (current_table == "alimento" || current_table == "usuario")
                    addScreen.entry4 = Convert.ToString(UserDataGrid.SelectedRows[0].Cells[4].Value);
                if (current_table == "alimento")
                    addScreen.entry5 = Convert.ToString(UserDataGrid.SelectedRows[0].Cells[5].Value);

                // Define a tabela atual no formul�rio de edi��o
                addScreen.currentTable = current_table;

                // Configura a tela de edi��o
                addScreen.TopLevel = false;
                this.TopLevel = true;

                // Adiciona o formul�rio de edi��o ao painel secund�rio
                InformationContainer.Panel2.Controls.Add(addScreen);

                // Registra o evento para restaurar a interface ap�s fechar o formul�rio de edi��o
                addScreen.addFormClosed += addFormClosed;

                CollapsePanels();

                // Inicializa o formul�rio de edi��o
                addScreen.startup();

                // Exibe o formul�rio de edi��o
                addScreen.Show();
            }
            catch
            {
                // Caso nenhuma linha esteja selecionada, exibe uma mensagem de erro
                MessageBox.Show("Nenhuma Fileira Selecionada!");
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // Verifica se nenhuma linha est� selecionada
            if (UserDataGrid.SelectedRows.Count == 0)
            {
                // Exibe uma mensagem de alerta ao usu�rio
                MessageBox.Show("Nenhuma Fileira Selecionada!");
            }
            else
            {
                // Itera sobre as linhas selecionadas
                foreach (DataGridViewRow row in UserDataGrid.SelectedRows)
                {
                    // Confirma a remo��o do item
                    if (MessageBox.Show($"Deseja Remover: {row.Cells[1].Value} ?", "Confirma��o", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // Executa o comando SQL para remover o usu�rio selecionado da tabela
                        DataBase.ExecuteCommand($"DELETE FROM {current_table} WHERE id='{row.Cells[0].Value}'");

                        // Remove a linha do UserDataGrid
                        UserDataGrid.Rows.RemoveAt(row.Index);
                    }
                }
            }
        }

        private void RecarregarPagina_Click(object sender, EventArgs e)
        {
            // Limpa o conjunto de dados atual para preparar para o recarregamento
            data.Tables.Clear();

            // Recarrega os dados do banco de dados
            data = DataBase.FillDataSet(tables, "");

            // Atualiza a fonte de dados do UserDataGrid com a tabela correspondente
            UserDataGrid.DataSource = data.Tables[tables.IndexOf(current_table)];

            // Informa ao usu�rio que os dados foram recarregados
            MessageBox.Show("Dados Recarregados!");
        }

        private void UserDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se a tabela atual � "refeicao" e se a c�lula clicada � um bot�o
            if (current_table == "refeicao" && UserDataGrid.Columns[e.ColumnIndex].CellType == typeof(DataGridViewButtonCell))
            {
                // Cria uma nova inst�ncia do formul�rio de adi��o
                addForm addScreen = new addForm();

                // Coleta o ID da refei��o da linha clicada
                addScreen.id = Convert.ToString(UserDataGrid.Rows[e.RowIndex].Cells[0].Value);

                // Configura o formul�rio para ser adicionado ao painel secund�rio
                addScreen.TopLevel = false;

                // Adiciona o formul�rio de adi��o ao painel secund�rio
                InformationContainer.Panel2.Controls.Add(addScreen);

                // Define a tabela atual no formul�rio de adi��o
                addScreen.currentTable = current_table;

                // Define a propriedade Alimentos como verdadeira
                addScreen.Alimentos = true;

                // Registra o m�todo addFormClosed para restaurar a interface ap�s o fechamento do formul�rio de adi��o
                addScreen.addFormClosed += addFormClosed;

                // Inicializa a tela de adi��o
                addScreen.startup();

                // Exibe o formul�rio de adi��o
                addScreen.Show();
            }
        }

        private void CollapsePanels()
        {
            // Desabilita e oculta o UserDataGrid durante a edi��o
            UserDataGrid.Visible = false;
            UserDataGrid.Enabled = false;

            // Colapsa o painel principal para melhor visualiza��o
            InformationContainer.Panel1Collapsed = true;
            MainSplitScreen.Panel1Collapsed = true;
        }
    }
}