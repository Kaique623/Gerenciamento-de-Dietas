using System.Data;
using iTextSharp.text;
using iTextSharp;
using iTextSharp.text.pdf;
using System.Text;
using System.IO;

namespace Gerenciamento_de_Dietas
{
    public partial class addForm : Form
    {
        public event EventHandler addFormClosed; // Evento acionado ao fechar o formulário
        public string entry1 = ""; // Campo para armazenar a primeira entrada
        public string entry2 = ""; // Campo para armazenar a segunda entrada
        public string entry3 = ""; // Campo para armazenar a terceira entrada
        public string entry4 = ""; // Campo para armazenar a quarta entrada
        public string entry5 = ""; // Campo para armazenar a quinta entrada
        public string id = ""; // Campo para armazenar o ID
        public bool editMode = false; // Indica se o formulário está em modo de edição
        public string currentTable = ""; // Armazena a tabela atual
        public bool Alimentos = false; // Indica se o formulário lida com alimentos
        public string idRefeicao = ""; // Campo para armazenar o ID da refeição

        public addForm()
        {
            InitializeComponent();

            // Preenche o combobox com os nomes das dietas disponíveis
            var dt = DataBase.returnColumn("SELECT * FROM dieta");
            foreach (var row in Enumerable.Range(0, dt.Rows.Count))
            {
                dieta_combobox.Items.Add((string)dt.Rows[row][1]);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            // Fecha o formulário sem realizar ações adicionais
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Executa a função ao fechar o formulário
            addFormClosed?.Invoke(this, EventArgs.Empty);
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            bool runCommand = true; // Variável para controlar a execução do comando
            string command = ""; // Comando de inserção
            string editcommand = ""; // Comando de edição

            // Gera comandos de inserção e edição com base na tabela atual e nos campos preenchidos
            if (nomeTextBox.Text != "" && email_TextBox.Text != "" && tipo_combobox.Text != "" && currentTable == "usuario")
            {
                command = $"INSERT INTO usuario (nome, email, tipo, dieta) VALUES ('{nomeTextBox.Text}', '{email_TextBox.Text}', '{tipo_combobox.Text}', (SELECT id FROM dieta WHERE nome = '{dieta_combobox.Text}'))";
                editcommand = $"UPDATE usuario SET nome='{nomeTextBox.Text}', email='{email_TextBox.Text}', tipo='{tipo_combobox.Text}' WHERE id='{id}'";
            }
            else if (currentTable == "alimento" && nomeAlimentoTextBox.Text != "" && caloriasTextBox.Text != "" && proteinasTextBox.Text != "" && carboidratosTextBox.Text != "" && gordurasTextBox.Text != "")
            {
                command = $"INSERT INTO alimento (nome, calorias, proteinas, carboidratos, gorduras) VALUES ('{nomeAlimentoTextBox.Text}', '{caloriasTextBox.Text}', '{proteinasTextBox.Text}', '{carboidratosTextBox.Text}', '{gordurasTextBox.Text}')";
                editcommand = $"UPDATE alimento SET nome='{nomeAlimentoTextBox.Text}', calorias='{caloriasTextBox.Text}', proteinas='{proteinasTextBox.Text}', carboidratos='{carboidratosTextBox.Text}', gorduras='{gordurasTextBox.Text}' WHERE id='{id}'";
            }
            else if (currentTable == "dieta" && nomeDietaTextBox.Text != "" && caloriasTotaisTextBox.Text != "")
            {
                command = $"INSERT INTO dieta (nome, calorias_totais) VALUES ('{nomeDietaTextBox.Text}', '{caloriasTotaisTextBox.Text}')";
                editcommand = $"UPDATE dieta SET nome='{nomeDietaTextBox.Text}', calorias_totais='{caloriasTotaisTextBox.Text}' WHERE id='{id}'";
            }
            else if (currentTable == "refeicao" && nomeRefeicaoTextBox.Text != "" && idDietaTextBox.Text != "" && horarioTextBox.Text != "")
            {
                command = $"INSERT INTO refeicao (nome, horario, id_dieta) VALUES ('{nomeRefeicaoTextBox.Text}', '{horarioTextBox.Text}', (SELECT id FROM dieta WHERE nome = '{idDietaTextBox.Text}'))";
                editcommand = $"UPDATE refeicao SET nome='{nomeRefeicaoTextBox.Text}', horario='{horarioTextBox.Text}', id_dieta=(SELECT id FROM dieta WHERE nome = '{idDietaTextBox.Text}') WHERE id='{id}'";
            }
            else
            {
                MessageBox.Show("Preencha Todos os Campos!"); // Mensagem de erro se campos obrigatórios não forem preenchidos
                runCommand = false; // Define que não deve executar o comando
            }

            // Executa a alteração no banco de dados se todas as condições forem atendidas
            if (runCommand)
            {
                AlterDatabase(command, editcommand);
            }
        }

        private void AlterDatabase(string command, string editcommand)
        {
            // Verifica se o formulário está em modo de edição
            if (editMode)
            {
                if (MessageBox.Show($"Deseja Aplicar Alterações?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Realiza a edição necessária
                    DataBase.ExecuteCommand(editcommand);
                    MessageBox.Show("Alterações Aplicadas!"); // Mensagem de confirmação
                    this.Close(); // Fecha o formulário
                }
            }
            else
            {
                if (MessageBox.Show($"Deseja Confirmar Adição?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Realiza a adição do novo item
                    DataBase.ExecuteCommand(command);
                    MessageBox.Show("Item Adicionado!"); // Mensagem de confirmação
                    this.Close(); // Fecha o formulário
                }
            }
        }

        private void usuarioTabPage_Click(object sender, EventArgs e)
        {
            // Evento vazio, pode ser utilizado para futuras implementações
        }

        public void startup()
        {
            id_textbox.Text = id; // Preenche o campo ID

            // Configura a interface com base no modo de edição
            if (!editMode)
            {
                id_label.Visible = false; // Oculta o rótulo de ID
                id_textbox.Enabled = false; // Desabilita o campo ID
                id_textbox.Visible = false; // Oculta o campo ID
            }
            else
            {
                id_label.Visible = true; // Exibe o rótulo de ID
                id_textbox.Enabled = true; // Habilita o campo ID
                id_textbox.Visible = true; // Exibe o campo ID
            }

            // Preenche os campos de entrada com base na tabela atual
            if (currentTable == "usuario")
            {
                nomeTextBox.Text = entry1;
                email_TextBox.Text = entry2;
                tipo_combobox.Text = entry3;
                AddTabControl.SelectedIndex = 0; // Seleciona a aba correspondente
            }
            else if (currentTable == "alimento")
            {
                nomeAlimentoTextBox.Text = entry1;
                caloriasTextBox.Text = entry2;
                proteinasTextBox.Text = entry3;
                carboidratosTextBox.Text = entry4;
                gordurasTextBox.Text = entry5;
                AddTabControl.SelectedIndex = 1; // Seleciona a aba correspondente
            }
            else if (currentTable == "dieta")
            {
                nomeDietaTextBox.Text = entry1;
                caloriasTotaisTextBox.Text = entry2;
                AddTabControl.SelectedIndex = 2; // Seleciona a aba correspondente
            }
            else if (currentTable == "refeicao" && Alimentos)
            {
                id_textbox.Text = id; // Preenche o campo ID
                AddTabControl.SelectedIndex = 4; // Seleciona a aba correspondente
                DataSet ds = DataBase.FillDataSet(new List<string>() { "refeicao_alimento" }, $"WHERE id_refeicao='{id_textbox.Text}'");
                refeicao_alimento_datagrid.DataSource = ds.Tables[0]; // Preenche o DataGrid com alimentos da refeição
            }
            else if (currentTable == "refeicao")
            {
                nomeRefeicaoTextBox.Text = entry1;
                horarioTextBox.Text = entry2;
                idDietaTextBox.Text = entry3;
                AddTabControl.SelectedIndex = 3; // Seleciona a aba correspondente
            }
        }

        private void adicionar_refeicaoButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Insere um novo alimento na refeição ou atualiza a quantidade se já existir
                DataBase.ExecuteCommand($"INSERT INTO refeicao_alimento (id_refeicao, id_alimento, quantidade, medida) VALUE ('{id_textbox.Text}' , (SELECT alimento.id FROM alimento WHERE alimento.nome='{id_alimentoTextBox.Text}'), '{quantidadeTextBox.Text}', '{medida_textbox.Text}')");
            }
            catch
            {
                if (quantidadeTextBox.Text == "")
                {
                    quantidadeTextBox.Text = "0";
                }
                // Atualiza a quantidade se o alimento já existir
                DataBase.ExecuteCommand($"UPDATE refeicao_alimento SET quantidade = quantidade + {quantidadeTextBox.Text}, medida = '{medida_textbox.Text}' WHERE id_alimento=(SELECT alimento.id FROM alimento WHERE alimento.nome='{id_alimentoTextBox.Text}')");
            }
            // Remove alimentos com quantidade menor que 1
            DataBase.ExecuteCommand("DELETE FROM refeicao_alimento WHERE quantidade < 1");
            // Atualiza o DataGrid com a lista de alimentos da refeição
            DataSet ds = DataBase.FillDataSet(new List<string>() { "refeicao_alimento" }, $"WHERE id_refeicao={id_textbox.Text}");
            refeicao_alimento_datagrid.DataSource = ds.Tables[0];
        }

        private void gerarRelatorio(object sender, EventArgs e)
        {
            // Dicionário para armazenar os dados nutricionais
            Dictionary<string, string> nutricional = new Dictionary<string, string>() {
                { "calorias", "" },
                { "proteinas", "" },
                { "carboidratos", "" },
                { "gorduras", "" }
            };

            // Calcula a soma dos nutrientes para a refeição
            foreach (string key in nutricional.Keys)
            {
                double aux = (double)DataBase.ExecuteScalarCommand(@$"SELECT SUM(alimento.{key}*quantidade) 
                                                            FROM refeicao_alimento
                                                            JOIN alimento on alimento.id = id_alimento
                                                            WHERE id_refeicao = '{id_textbox.Text}'");
                nutricional[key] = aux.ToString("F");
            }

            // Define o caminho para o arquivo PDF
            string output = Directory.GetCurrentDirectory() + "relatorio.pdf";

            // Cria o documento PDF
            Document document = new Document(PageSize.A4);
            document.SetMargins(40, 40, 40, 40);
            document.AddCreationDate();
            var writer = PdfWriter.GetInstance(document, new FileStream(output, FileMode.Create));
            document.Open();

            string Alimentos = "";

            // Recupera os nomes dos alimentos da refeição
            DataTable dt = DataBase.returnColumn($@"SELECT alimento.nome	
                                                    FROM refeicao_alimento
                                                    JOIN dietas.alimento
                                                    ON alimento.id = refeicao_alimento.id_alimento
                                                    AND refeicao_alimento.id_refeicao = {id}");

            foreach (var row in Enumerable.Range(0, dt.Rows.Count))
            {
                Alimentos += $"{(string)dt.Rows[row][0]}; "; // Adiciona cada alimento à string
            }

            // Cria o parágrafo com os dados do relatório
            Paragraph titulo = new Paragraph();
            titulo.Alignment = Element.ALIGN_JUSTIFIED;
            titulo.Add($"Relatorio;\n" +
                       $"Calorias: {nutricional["calorias"]}\n" +
                       $"Proteinas: {nutricional["proteinas"]}\n" +
                       $"Carboidratos: {nutricional["carboidratos"]}\n" +
                       $"Gorduras: {nutricional["gorduras"]}\n" +
                       $"Quantidade de Alimentos: {refeicao_alimento_datagrid.Rows.Count}\n" +
                       $"Alimentos: {Alimentos}\n");

            // Adiciona o parágrafo ao documento e fecha o documento
            document.Add(titulo);
            document.Close();
        }
    }
}