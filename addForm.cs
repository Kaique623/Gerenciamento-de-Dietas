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
        public event EventHandler addFormClosed;
        public string entry1 = "";
        public string entry2 = "";
        public string entry3 = "";        
        public string entry4 = "";
        public string entry5 = "";
        public string id = "";
        public bool editMode = false;
        public string currentTable = "";
        public bool Alimentos = false;
        public string idRefeicao = "";


        public addForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            // Sem Comentários
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Executa Função ao fechar a Tela
            addFormClosed?.Invoke(this, EventArgs.Empty);
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            bool runCommand = true;
            string command = "";
            string editcommand = "";

            if (nomeTextBox.Text != "" && email_TextBox.Text != "" && tipo_combobox.Text != "" && currentTable == "usuario")
            {
                command = $"INSERT INTO usuario (nome, email, tipo) VALUES ('{nomeTextBox.Text}', '{email_TextBox.Text}', '{tipo_combobox.Text}')";
                editcommand = $"UPDATE usuario SET nome='{nomeTextBox.Text}', email='{email_TextBox.Text}', tipo='{tipo_combobox.Text}' WHERE id='{id}'"
;           }

            else if (currentTable == "alimento" & nomeAlimentoTextBox.Text != "" && caloriasTextBox.Text != "" & proteinasTextBox.Text != "" & carboidratosTextBox.Text != "" & gordurasTextBox.Text != "")
            {
                command  = $"INSERT INTO alimento (nome, calorias, proteinas, carboidratos, gorduras) VALUES ('{nomeAlimentLabel.Text}', '{caloriasTextBox.Text}', '{proteinasTextBox.Text}', '{carboidratosTextBox.Text}', '{gordurasTextBox.Text}')";
                editcommand = $"UPDATE alimento SET nome='{nomeTextBox.Text}', calorias='{caloriasTextBox.Text}', proteinas='{proteinasTextBox.Text}', carboidratos='{carboidratosTextBox.Text}', gorduras='{gordurasTextBox.Text}' WHERE id='{id}'";
            }
            else if (currentTable == "dieta" && nomeDietaTextBox.Text != "" && caloriasTotaisTextBox.Text != "")
            {
                command = $"INSERT INTO dieta (nome, calorias_totais) VALUES ('{nomeDietaTextBox.Text}', '{caloriasTotaisTextBox.Text}')";
                editcommand = $"UPDATE dieta SET nome='{nomeDietaTextBox.Text}', calorias_totais='{caloriasTotaisTextBox.Text}' WHERE id='{id}'";
            }
            else if (currentTable == "refeicao" && nomeRefeicaoTextBox.Text != "" && idDietaTextBox.Text != "" && horarioTextBox.Text != "")
            {
                command = $"INSERT INTO refeicao (nome, horario, id_dieta) VALUES ('{nomeRefeicaoTextBox.Text}', '{horarioTextBox.Text}', '{idDietaTextBox.Text}')";
                editcommand = $"UPDATE refeicao SET nome='{nomeRefeicaoTextBox.Text}', horario='{horarioTextBox.Text}', id_dieta='{idDietaTextBox.Text}' WHERE id='{id}'";
            }
            else
            {
                MessageBox.Show("Preencha Todos os Campos!");
                runCommand = false;
            }
            
            if (runCommand)
            {
                AlterDatabase(command, editcommand);
            }
        }
        private void AlterDatabase(string command, string editcommand)
        {
            if (editMode)
            {
                if (MessageBox.Show($"Deseja Aplicar Alterações?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Faz as Edições Necessárias
                    DataBase.ExecuteCommand(editcommand);
                    MessageBox.Show("Alterações Aplicadas!");
                    this.Close();
                }
            }
            else
            {
                if (MessageBox.Show($"Deseja Confrimar Adição?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Faz a Adição do novo Usuário
                    DataBase.ExecuteCommand(command);
                    MessageBox.Show("Item Adicionado!");
                    this.Close();
                }
            }
        }

        private void usuarioTabPage_Click(object sender, EventArgs e)
        {

        }

        private void usuarioTabPage_Paint(object sender, PaintEventArgs e)
        {
            id_textbox.Text = id;
            // Confere Se está no modo de Edição e Altera Propriedades para o modo
            if (!editMode)
            {
                id_label.Visible = false;
                id_textbox.Enabled = false;
                id_textbox.Visible = false;
            }
            else
            {
                id_label.Visible = true;
                id_textbox.Enabled = false;
                id_textbox.Visible = true;
            }

            // Captura Informações passadas ao Chamar Formulário
            if (currentTable == "usuario")
            {
                nomeTextBox.Text = entry1;
                email_TextBox.Text = entry2;
                tipo_combobox.Text = entry3;
                AddTabControl.SelectedIndex = 0;
            }
            else if (currentTable == "alimento")
            {
                nomeAlimentoTextBox.Text = entry1;
                caloriasTextBox.Text = entry2;
                proteinasTextBox.Text = entry3;
                carboidratosTextBox.Text = entry4;
                gordurasTextBox.Text = entry5;
                AddTabControl.SelectedIndex = 1;
            }
            else if (currentTable == "dieta")
            {
                nomeDietaTextBox.Text = entry1;
                caloriasTotaisTextBox.Text = entry2;
                AddTabControl.SelectedIndex = 2;
            }
            else if (currentTable == "refeicao" && Alimentos)
            {
                id_textbox.Text = id;
                AddTabControl.SelectedIndex = 4;
                DataSet ds = DataBase.FillDataSet(new List<string>() { "refeicao_alimento" }, $"WHERE id_refeicao='{id_textbox.Text}'");
                refeicao_alimento_datagrid.DataSource = ds.Tables[0];
            }
            else if (currentTable == "refeicao")
            {
                nomeRefeicaoTextBox.Text = entry1;
                horarioTextBox.Text = entry2;
                idDietaTextBox.Text = entry3;
                AddTabControl.SelectedIndex = 3;
            }
        }

        private void adicionar_refeicaoButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase.ExecuteCommand($"INSERT INTO refeicao_alimento (id_refeicao, id_alimento, quantidade) VALUE ('{id_textbox.Text}' ,'{id_alimentoTextBox.Text}', '{quantidadeTextBox.Text}')");
            }
            catch
            {
                DataBase.ExecuteCommand($"UPDATE refeicao_alimento SET quantidade = quantidade + {quantidadeTextBox.Text} WHERE id_alimento={id_alimentoTextBox.Text}");
                
            }
            DataBase.ExecuteCommand("DELETE FROM refeicao_alimento WHERE quantidade < 1");
            DataSet ds = DataBase.FillDataSet(new List<string>() { "refeicao_alimento" }, $"WHERE id_refeicao={id_textbox.Text}");
            refeicao_alimento_datagrid.DataSource = ds.Tables[0];
         
        }

        private void gerarRelatorio(object sender, EventArgs e)
        {



            Dictionary<string, string> nutricional = new Dictionary<string, string>() {
                { "calorias", "" },
                { "proteinas", "" },
                { "carboidratos", "" },
                { "gorduras", "" }
            };

            foreach (string key in nutricional.Keys)
            {
                double aux = (double)DataBase.ExecuteScalarCommand(@$"SELECT SUM(alimento.{key}*quantidade) 
                                                            FROM refeicao_alimento
                                                            JOIN alimento on alimento.id = id_alimento
                                                            WHERE id_refeicao = '{id_textbox.Text}'");
                nutricional[key] = aux.ToString("F");
            }

            string output = Directory.GetCurrentDirectory() + "relatorio.pdf";

            Document document = new Document(PageSize.A4);
            document.SetMargins(40, 40, 40, 40);
            document.AddCreationDate();
            var writer = PdfWriter.GetInstance(document, new FileStream(output, FileMode.Create));
            document.Open();

            string Alimentos = "";

            DataTable dt = DataBase.returnColumn($@"SELECT alimento.nome	
                                                    FROM refeicao_alimento
                                                    JOIN dietas.alimento
                                                    ON alimento.id = refeicao_alimento.id_alimento
                                                    AND refeicao_alimento.id_refeicao = {id}");

            foreach (var row in Enumerable.Range(0, dt.Rows.Count))
            {
                Alimentos += $"{(string)dt.Rows[row][0]}; ";    
            }
               
            Paragraph titulo = new Paragraph();
            titulo.Alignment = Element.ALIGN_JUSTIFIED;
            titulo.Add($"Relatorio;\n" +
                       $"Calorias: {nutricional["calorias"]}\n" +
                       $"Proteinas: {nutricional["proteinas"]}\n" +
                       $"Carboidratos: {nutricional["carboidratos"]}\n" +
                       $"Gorduras: {nutricional["gorduras"]}\n" +
                       $"Quantidade de Alimentos: {refeicao_alimento_datagrid.Rows.Count}\n" +
                       $"Alimentos: {Alimentos}\n");

            document.Add(titulo);
            document.Close();
            System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + "/net6.0-windowsrelatorio.pdf");
        }
    }
}
