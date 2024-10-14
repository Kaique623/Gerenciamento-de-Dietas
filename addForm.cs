using System.Data;
using iTextSharp.text;
using iTextSharp;
using iTextSharp.text.pdf;
using System.Text;
using System.IO;

namespace Gerenciamento_de_Dietas
{
    public partial class AddForm : Form
    {
        private TextBox TemplateTextBox;
        private Label TextboxLabel;
        private CustomPanel templatePanel;

        private Dictionary<string, CustomPanel> 

        public AddForm()
        {
            InitializeComponent();
        }

        public void startup()
        {

        }

        private void InitializeComponent()
        {
            this.templatePanel = new Gerenciamento_de_Dietas.CustomPanel();
            this.TemplateTextBox = new System.Windows.Forms.TextBox();
            this.TextboxLabel = new System.Windows.Forms.Label();
            this.templatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // templatePanel
            // 
            this.templatePanel.Controls.Add(this.TemplateTextBox);
            this.templatePanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.templatePanel.Location = new System.Drawing.Point(12, 40);
            this.templatePanel.Name = "templatePanel";
            this.templatePanel.Size = new System.Drawing.Size(200, 100);
            this.templatePanel.TabIndex = 0;
            // 
            // TemplateTextBox
            // 
            this.TemplateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.TemplateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TemplateTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TemplateTextBox.ForeColor = System.Drawing.Color.Navy;
            this.TemplateTextBox.Location = new System.Drawing.Point(20, 20);
            this.TemplateTextBox.Name = "TemplateTextBox";
            this.TemplateTextBox.Size = new System.Drawing.Size(143, 22);
            this.TemplateTextBox.TabIndex = 0;
            this.TemplateTextBox.Text = "123";
            // 
            // TextboxLabel
            // 
            this.TextboxLabel.AutoSize = true;
            this.TextboxLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextboxLabel.ForeColor = System.Drawing.Color.Black;
            this.TextboxLabel.Location = new System.Drawing.Point(25, 24);
            this.TextboxLabel.Name = "TextboxLabel";
            this.TextboxLabel.Size = new System.Drawing.Size(98, 21);
            this.TextboxLabel.TabIndex = 1;
            this.TextboxLabel.Text = "TextboxLabel";
            // 
            // AddForm
            // 
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(421, 588);
            this.Controls.Add(this.TextboxLabel);
            this.Controls.Add(this.templatePanel);
            this.Name = "AddForm";
            this.templatePanel.ResumeLayout(false);
            this.templatePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}