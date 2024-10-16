using System.Data;

namespace Gerenciamento_de_Dietas
{
    public partial class AddForm : Form
    {
        Dictionary<string, TextBox> entries = new Dictionary<string, TextBox>();

        Dictionary<string, CustomPanel> panels = new Dictionary<string, CustomPanel>();

        DataTable Data = new DataTable();

        private Dictionary<string, Guna.UI2.WinForms.Guna2ComboBox> comboboxDict = new Dictionary<string, Guna.UI2.WinForms.Guna2ComboBox>();

        private int currentEntry = 0;

        int currentRow = 0;

        string table = "";
        string _id = "";

        public AddForm()
        {
            InitializeComponent();
            
        }
        public void startup(List<string> entryText, string currentTable, string id)
        {
            table = currentTable;

            Data = DataBase.returnColumn($"SELECT * FROM {currentTable} WHERE id={id}");
            _id = id;
            if (currentTable == "usuario")
            {
                entryText.Add("Objetivo");
                entryText.Add("Email");
            }

            foreach (string entry in entryText)
            {
                generateEntry(entry);
            }

            addPanelsToControl();
            
        }
        private void addPanelsToControl()
        {
            foreach (CustomPanel panel in panels.Values)
            {
                this.Controls.Add(panel);
            }   
        }


        private void generateEntry(string entryText)
        {
            panels[entryText] = new CustomPanel();
            entries[entryText] = new TextBox();
            comboboxDict[entryText] = new Guna.UI2.WinForms.Guna2ComboBox();
            Label TextboxLabel = new Label();

            int column = 1;

            if (currentEntry % 2 != 0)
                column = 2;

            TextboxLabel.AutoSize = true;
            TextboxLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextboxLabel.ForeColor = Color.Black;
            TextboxLabel.Location = new Point(25 + (200 * (column - 1)), 24 + (100 * currentRow));
            TextboxLabel.Size = new Size(98, 21);
            TextboxLabel.TabIndex = 0;
            TextboxLabel.Text = entryText;

            if (entryText != "Tipo" && entryText != "Objetivo")
                panels[entryText].Controls.Add(entries[entryText]);
            panels[entryText].ForeColor = Color.FromArgb(203, 203, 203);
            panels[entryText].Location = new Point(12 + (200 * (column - 1)), 40 + (100 * currentRow));
            panels[entryText].Size = new Size(200, 100);
            panels[entryText].TabIndex = 1;

            if (entryText != "Tipo" && entryText != "Objetivo")
            {
                entries[entryText].BackColor = Color.FromArgb(203, 203, 203);
                entries[entryText].BorderStyle = BorderStyle.None;
                entries[entryText].Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
                entries[entryText].ForeColor = Color.Navy;
                entries[entryText].Location = new Point(20, 20);
                entries[entryText].Size = new Size(143, 22);
                entries[entryText].TabIndex = 1;
            }
            else
            {
                panels[entryText].Controls.Add(comboboxDict[entryText]);
                comboboxDict[entryText].BackColor = Color.Transparent;
                comboboxDict[entryText].BorderColor = Color.Gray;
                comboboxDict[entryText].BorderThickness = 0;
                comboboxDict[entryText].CustomizableEdges = customizableEdges5;
                this.guna2Transition1.SetDecoration(comboboxDict[entryText], Guna.UI2.AnimatorNS.DecorationType.None);
                comboboxDict[entryText].DrawMode = DrawMode.OwnerDrawFixed;
                comboboxDict[entryText].DropDownStyle = ComboBoxStyle.DropDownList;
                comboboxDict[entryText].FillColor = Color.FromArgb(203, 203, 203);
                comboboxDict[entryText].FocusedState.BorderColor = Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
                comboboxDict[entryText].Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
                comboboxDict[entryText].ForeColor = Color.Navy;
                comboboxDict[entryText].ItemHeight = 30;
                comboboxDict[entryText].Location = new Point(20, 15);
                comboboxDict[entryText].ShadowDecoration.CustomizableEdges = customizableEdges6;
                comboboxDict[entryText].Size = new Size(140, 34);
                comboboxDict[entryText].TabIndex = 3;

                var auxList = new List<string>() { "nutrólogo", "paciente" };

                if (entryText == "Tipo")
                    auxList = new List<string>() { "nutrólogo", "paciente" };

                else if (entryText == "Objetivo")
                    auxList = new List<string>() { "ganhar peso", "manter peso", "perder" };

                comboboxDict[entryText].DataSource = auxList;

                try
                {
                    comboboxDict[entryText].StartIndex = auxList.IndexOf(Data.Rows[0][currentEntry + 1].ToString());
                    comboboxDict[entryText].TabIndex = auxList.IndexOf(Data.Rows[0][currentEntry + 1].ToString());
                    comboboxDict[entryText].SelectedIndex = auxList.IndexOf(Data.Rows[0][currentEntry + 1].ToString());
                }
                catch
                {

                }
            }

            entries[entryText].Text = Data.Rows[0][currentEntry + 1].ToString();

            currentEntry += 1;

            this.Controls.Add(TextboxLabel);

            if (currentEntry%2 == 0 )
                currentRow++;
        }
        private void Save(object sender, EventArgs e)
        {
            string columns = "";
            foreach (DataColumn column in Data.Columns)
                if (columns != "")
                    columns += $", {column.ColumnName}";
                else
                    columns += $"{column.ColumnName}";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            string set = "";

            List<string> values = new List<string>();

            foreach (string key in panels.Keys)
            {
                if (key != "Tipo" && key != "Objetivo")
                    values.Add(entries[key].Text);
                else
                    values.Add(comboboxDict[key].Text);
            }

            int i = 0;

            foreach (DataColumn column in Data.Columns)
            {
                if (column.ColumnName != "id")
                {
                    if (set == "")
                        set += $"{column}='{values[i]}'";
                    else
                        set += $", {column}='{values[i]}'";
                    i++;
                }
            }

            string query = $"UPDATE {table} SET {set}";
            MessageBox.Show(query);
            DataBase.ExecuteCommand(query + $"WHERE id={_id}");

            this.Close();
        }
    }
}
