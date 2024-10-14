using System.Data;
using System.Diagnostics;

namespace Gerenciamento_de_Dietas
{
    public partial class MainApp : Form
    {   
        List<string> tables = new List<string>() {"usuario", "dieta", "alimento","refeicao", "refeicao_alimento"};
        Dictionary<int, InformationFrame> InfoPanels = new Dictionary<int, InformationFrame>();

        string current_table = "usuario";
        DataGridViewButtonColumn visualizar_alimento = new System.Windows.Forms.DataGridViewButtonColumn();

        DataSet data = new DataSet();

        DataTable searchData = new DataTable();
        bool searching = false;

        public int currentPage = 0;

        public MainApp()
        {
            InitializeComponent();

            // Abre a conexão com o banco de dados.
            DataBase.connection.Open();

            // Preenche o DataSet com as tabelas de dados especificadas (armazenadas na variável 'tables').
            data = DataBase.FillDataSet(tables, "");

            pageLabel.Text = $"{currentPage}/{(data.Tables[0].Rows.Count/8).ToString()}";
            GenerateNewUserPanel(data.Tables[0]);
            fillFilter();
        }

        private void fillFilter()
        {
            filter_combobox.Text = "Filtro";
            filter_combobox.Items.Clear();
         
            foreach (DataColumn column in data.Tables[tables.IndexOf(current_table)].Columns)
            {
                filter_combobox.Items.Add(column.ColumnName);
            }
            filter_combobox.Items.Add("Filtro");
        }

        private async void GenerateNewUserPanel(DataTable table)
        {
            if (InfoPanels.Count > 0)
            {
                foreach (var i in InfoPanels.Keys)
                {
                    MainSplitScreen.Panel2.Controls.Remove(InfoPanels[i].mainPanel);
                }
            }

            InfoPanels.Clear();
            int currentFrame = 0;
            
            foreach (int value in Enumerable.Range(0 + (8 * currentPage), 9 + (8*currentPage)))
            {
                if (value == data.Tables[0].Rows.Count)
                    break;

                int xpos = 3 + (288 * currentFrame);

                if (currentFrame > 3)
                    xpos = 3 + (288 * (currentFrame - 4));

                int ypos = 24;

                if (currentFrame > 3)
                    ypos = ypos + 214;
                    
                Dictionary<string, string> auxlist = new Dictionary<string, string>();

                for (int i = 0; i < 8; i++)
                {
                    try
                    {
                        auxlist[table.Columns[i].ColumnName] = Convert.ToString(table.Rows[value][i]);
                    }
                    catch
                    {
                        Console.WriteLine("Pesquisa aa");
                    }
                }

                InfoPanels[currentFrame] = new InformationFrame();
                
                await Task.Run( () => InfoPanels[currentFrame].userMain(auxlist, xpos, ypos));

                if (auxlist.Values.Count != 0)
                {
                    MainSplitScreen.Panel2.Controls.Add(InfoPanels[currentFrame].mainPanel);
                    currentFrame++;
                }
            }
        }

        private void TabButtonClick(object sender, EventArgs e)
        {
         /*   try
            {
                // Tenta remover a coluna "visualizar_alimento" do DataGrid caso ela já exista.
                UserDataGrid.Columns.Remove(visualizar_alimento);
            }
            catch
            {
                // Caso a coluna "visualizar_alimento" não exista, exibe uma mensagem no console.
                Console.WriteLine("Coluna Inexistente");
            }

            // Permite que o DataGrid gere as colunas automaticamente com base no DataSource.
            UserDataGrid.AutoGenerateColumns = true;

            // Obtém o texto do botão que disparou o evento.
            string buttonText = ((Button)sender).Text;

            // Muda o DataGrid para a tabela de "Usuários" se o botão clicado for "Usuários".
            if (buttonText == "Usuários")
            {
                // Define a tabela atual como "usuario" e atualiza o DataSource com os dados de usuários.
                current_table = "usuario";
                UserDataGrid.DataSource = data.Tables[0];
            }
            // Muda o DataGrid para a tabela de "Dietas" se o botão clicado for "Dietas".
            else if (buttonText == "Dietas")
            {
                // Define a tabela atual como "dieta" e atualiza o DataSource com os dados de dietas.
                current_table = "dieta";
                UserDataGrid.DataSource = data.Tables[1];
            }
            // Muda o DataGrid para a tabela de "Alimentos" se o botão clicado for "Alimentos".
            else if (buttonText == "Alimentos")
            {
                // Define a tabela atual como "alimento" e atualiza o DataSource com os dados de alimentos.
                current_table = "alimento";
                UserDataGrid.DataSource = data.Tables[2];
            }
            // Muda o DataGrid para a tabela de "Refeições" se o botão clicado for "Refeições".
            else if (buttonText == "Refeições")
            {
                // Define a tabela atual como "refeicao" e atualiza o DataSource com os dados de refeições.
                current_table = "refeicao";
                UserDataGrid.DataSource = data.Tables[3];

                try
                {
                    // Desativa a geração automática de colunas para personalizar as colunas manualmente.
                    UserDataGrid.AutoGenerateColumns = false;

                    // Configura a coluna "visualizar_alimento" como um botão.
                    visualizar_alimento.HeaderText = "";  // O cabeçalho da coluna será vazio.
                    visualizar_alimento.Name = "visualizar_alimento";  // Nome da coluna.
                    visualizar_alimento.ReadOnly = true;  // Define a coluna como somente leitura.
                    visualizar_alimento.Visible = true;  // Torna a coluna visível.
                    visualizar_alimento.Text = "Visualizar Alimentos";  // Texto exibido no botão.
                    visualizar_alimento.UseColumnTextForButtonValue = true;  // Define o texto do botão.

                    // Adiciona a coluna de botão "visualizar_alimento" ao DataGrid.
                    UserDataGrid.Columns.Add(visualizar_alimento);

                    // Define a posição da coluna "visualizar_alimento" para ser a última.
                    UserDataGrid.Columns["visualizar_alimento"].DisplayIndex = UserDataGrid.Columns.Count - 1;

                    // Define a posição da coluna "id" para ser a primeira.
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
                    // Caso já exista uma coluna com o nome "visualizar_alimento", exibe uma mensagem no console.
                    Console.WriteLine("Erro ao adicionar Coluna (Já Existente)");
                }
            }
            fillFilter(); */
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string columnName = filter_combobox.Text;
            string searchTextAux = SearchText.Text;
            currentPage = 0;

            if (columnName == "Dieta")
            {
                columnName = "dieta.nome";
            }
            searchData = DataBase.SearchContent(current_table, $"WHERE {current_table}.{columnName} LIKE '%{SearchText.Text}%'");
            
            if (columnName != "Filtro")
                GenerateNewUserPanel(searchData);
            else
                MessageBox.Show("Selecione um Filtro!", "Aviso!", MessageBoxButtons.OK);

            pageLabel.Text = $"{currentPage}/{(searchData.Rows.Count / 8).ToString()}";

            searching = true;
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
        /*    // Criação da tela de adição
            addForm addScreen = new addForm();

            // Configuração de hierarquia dos formulários
            addScreen.TopLevel = false;
            this.TopLevel = true;

            // Adiciona o formulário de adição ao painel secundário
            InformationContainer.Panel2.Controls.Add(addScreen);

            // Registra o evento para quando o formulário de adição for fechado
            addScreen.addFormClosed += addFormClosed;

            // Define a tabela atual no formulário de adição
            addScreen.currentTable = current_table;

            // Inicializa a tela de adição
            addScreen.startup();

            CollapsePanels();

            // Exibe o formulário de adição
            addScreen.Show(); */
        }

        private void addFormClosed(object sender, EventArgs e)
        {
           /* // Recarrega as tabelas de dados do banco de dados
            data = DataBase.FillDataSet(tables, "");

            // Define a fonte de dados do UserDataGrid para a tabela atualizada
            UserDataGrid.DataSource = data.Tables[tables.IndexOf(current_table)];

            // Torna o UserDataGrid visível e habilitado novamente
            UserDataGrid.Visible = true;
            UserDataGrid.Enabled = true;

            // Reexpande o painel principal (cabeçalho ou dashboard)
            InformationContainer.Panel1Collapsed = false;
            MainSplitScreen.Panel1Collapsed = false; */
        }

        private void EditButton_Click(object sender, EventArgs e)
        {

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            /* Verifica se nenhuma linha está selecionada
        //    if (UserDataGrid.SelectedRows.Count == 0)
          //  {
                // Exibe uma mensagem de alerta ao usuário
                MessageBox.Show("Nenhuma Fileira Selecionada!");
         //   }
            else
            {
                // Itera sobre as linhas selecionadas
                foreach (DataGridViewRow row in UserDataGrid.SelectedRows)
                {
                    // Confirma a remoção do item
                    if (MessageBox.Show($"Deseja Remover: {row.Cells[1].Value} ?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // Executa o comando SQL para remover o usuário selecionado da tabela
                        DataBase.ExecuteCommand($"DELETE FROM {current_table} WHERE id='{row.Cells[0].Value}'");

                        // Remove a linha do UserDataGrid
                   //     UserDataGrid.Rows.RemoveAt(row.Index);
                    }
                }
            } */
        }

        private void RecarregarPagina_Click(object sender, EventArgs e)
        {
         /*   // Limpa o conjunto de dados atual para preparar para o recarregamento
            data.Tables.Clear();

            // Recarrega os dados do banco de dados
            data = DataBase.FillDataSet(tables, "");

            // Atualiza a fonte de dados do UserDataGrid com a tabela correspondente
            UserDataGrid.DataSource = data.Tables[tables.IndexOf(current_table)];

            // Informa ao usuário que os dados foram recarregados
            MessageBox.Show("Dados Recarregados!"); */
        }

        private void UserDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se a tabela atual é "refeicao" e se a célula clicada é um botão
      /*      if (current_table == "refeicao" && UserDataGrid.Columns[e.ColumnIndex].CellType == typeof(DataGridViewButtonCell))
            {
                // Cria uma nova instância do formulário de adição
                addForm addScreen = new addForm();

                // Coleta o ID da refeição da linha clicada
                addScreen.id = Convert.ToString(UserDataGrid.Rows[e.RowIndex].Cells[0].Value);

                // Configura o formulário para ser adicionado ao painel secundário
                addScreen.TopLevel = false;

                // Adiciona o formulário de adição ao painel secundário
                InformationContainer.Panel2.Controls.Add(addScreen);

                // Define a tabela atual no formulário de adição
                addScreen.currentTable = current_table;

                // Define a propriedade Alimentos como verdadeira
                addScreen.Alimentos = true;

                // Registra o método addFormClosed para restaurar a interface após o fechamento do formulário de adição
                addScreen.addFormClosed += addFormClosed;

                // Inicializa a tela de adição
                addScreen.startup();

                // Exibe o formulário de adição
                addScreen.Show();
            }*/
        }

        private void CollapsePanels()
        {
          /*  // Desabilita e oculta o UserDataGrid durante a edição
            UserDataGrid.Visible = false;
            UserDataGrid.Enabled = false;

            // Colapsa o painel principal para melhor visualização
            InformationContainer.Panel1Collapsed = true;
            MainSplitScreen.Panel1Collapsed = true; */
        }

        private void ChangePageButton(object sender, EventArgs e)
        {

            string ButtonText = ((Button)sender).Text;
            var currentPageStart = currentPage;
            int maxPage = data.Tables[0].Rows.Count / 8;
            if (searching)
            {
                maxPage = searchData.Rows.Count / 8;
            }


            if (ButtonText == "⮞" && currentPage < maxPage)
                currentPage++;
            else if (ButtonText == "⮜" && currentPage > 0)
                currentPage--;

            if (currentPageStart != currentPage)
                if (!searching)
                    GenerateNewUserPanel(data.Tables[0]);
                else
                    GenerateNewUserPanel(searchData);

            pageLabel.Text = $"{currentPage}/{maxPage.ToString()}";
        }

        private void clearSearchButton_Click(object sender, EventArgs e)
        {
            SearchText.Text = "";
            filter_combobox.Text = "Filtro";
            searching = false;
            GenerateNewUserPanel(data.Tables[tables.IndexOf(current_table)]);
            currentPage = 0;
        }
    }
}