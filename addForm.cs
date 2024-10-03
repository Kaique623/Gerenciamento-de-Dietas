using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

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
                AddTabControl.SelectedIndex = 4;

                DataSet ds = DataBase.FillDataSet(new List<string>() { "refeicao_alimento" });
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
    }
}
