using System.Data;
using System.Diagnostics;

namespace Gerenciamento_de_Dietas
{
    public partial class MainApp : Form
    {   
        List<string> tables = new List<string>() {"usuario", "dieta", "alimento","refeicao", "refeicao_alimento"};
        Dictionary<int, InformationFrame> InfoPanels = new Dictionary<int, InformationFrame>();

        string current_table = "usuario";

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