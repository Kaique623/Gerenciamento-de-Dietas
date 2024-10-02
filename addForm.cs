using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciamento_de_Dietas
{
    public partial class addForm : Form
    {
        public event EventHandler addFormClosed;
        public static string nomeText = "";
        public static string emailtext = "";
        public static string tipotext = "";
        public static int id = 0;
        public static bool editMode = false;

        public addForm()
        {
            InitializeComponent();

            nomeTextBox.Text = nomeText;
            email_TextBox.Text = emailtext;
            tipo_combobox.Text = tipotext;
            id_textbox.Text = Convert.ToString(id);

            if (!editMode)
            {
                id_label.Visible = false;
                id_textbox.Enabled = false;
                id_textbox.Visible = false;   
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Dispare o evento quando o formulário for fechado
            addFormClosed?.Invoke(this, EventArgs.Empty);
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (nomeTextBox.Text != "" && email_TextBox.Text != "" && tipo_combobox.Text != "")
            {
                if (editMode)
                {
                    if (MessageBox.Show($"Deseja Aplicar Alterações?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DataBase.ExecuteCommand($"UPDATE usuario SET nome='{nomeTextBox.Text}', email='{email_TextBox.Text}', tipo='{tipo_combobox.Text}' WHERE id='{id}'");
                        MessageBox.Show("Alterações Aplicadas!");
                        this.Close();
                    }
                }
                else
                {
                    if (MessageBox.Show($"Deseja Confrimar Adição?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DataBase.ExecuteCommand($"INSERT INTO usuario (nome, email, tipo) VALUES ('{nomeTextBox.Text}', '{email_TextBox.Text}', '{tipo_combobox.Text}')");
                        MessageBox.Show("Usuário Adicionado!");
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Preencha Todos os Campos!");
            }
        }
    }
}
