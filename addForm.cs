using System.Data;

namespace Gerenciamento_de_Dietas
{
    public partial class AddForm : Form
    {
        Dictionary<string, TextBox> entries = new Dictionary<string, TextBox>();
        Dictionary<string, CustomPanel> panels = new Dictionary<string, CustomPanel>();
        DataTable Data = new DataTable();

        private int currentEntry = 0;

        int currentRow = 0;

        public AddForm()
        {
            InitializeComponent();
        }
        public void startup(List<string> entryText, string currentTable, string id)
        {
            DataTable Data = DataBase.returnColumn($"SELECT * FROM {currentTable} WHERE id={id}");

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
            Label TextboxLabel = new Label();

            int column = 1;

            if (currentEntry%2 != 0)
                column = 2;

            TextboxLabel.AutoSize = true;
            TextboxLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextboxLabel.ForeColor = Color.Black;
            TextboxLabel.Location = new Point(25 + (200 * (column - 1)), 24 + (100 * currentRow));
            TextboxLabel.Size = new Size(98, 21);
            TextboxLabel.TabIndex = 0;
            TextboxLabel.Text = entryText;

            panels[entryText].Controls.Add(entries[entryText]);
            panels[entryText].ForeColor = Color.FromArgb(203, 203, 203);
            panels[entryText].Location = new Point(12 + (200 *(column-1)), 40 + (100*currentRow));
            panels[entryText].Size = new Size(200, 100);
            panels[entryText].TabIndex = 1;

            entries[entryText].BackColor = Color.FromArgb(203, 203, 203);
            entries[entryText].BorderStyle = BorderStyle.None;
            entries[entryText].Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            entries[entryText].ForeColor = Color.Navy;
            entries[entryText].Location = new Point(20, 20);
            entries[entryText].Size = new Size(143, 22);
            entries[entryText].TabIndex = 1;

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
    }
}
