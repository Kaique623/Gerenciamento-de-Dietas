namespace Gerenciamento_de_Dietas
{
    partial class MainApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainSplitScreen = new System.Windows.Forms.SplitContainer();
            this.filter_combobox = new System.Windows.Forms.ComboBox();
            this.refeicoesTabButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.AlimentosButton = new System.Windows.Forms.Button();
            this.DietaTabButton = new System.Windows.Forms.Button();
            this.UsuariosTabButton = new System.Windows.Forms.Button();
            this.customPanel1 = new Gerenciamento_de_Dietas.CustomPanel();
            this.alturaTemplateLabel = new System.Windows.Forms.Label();
            this.idadeTemplateLabel = new System.Windows.Forms.Label();
            this.TemplateGeneroLabel = new System.Windows.Forms.Label();
            this.templateDietaLabel = new System.Windows.Forms.Label();
            this.tipoLabelTemplate = new System.Windows.Forms.Label();
            this.idLabelTemplate = new System.Windows.Forms.Label();
            this.templateLabelUsuario = new System.Windows.Forms.Label();
            this.pesoTemplateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitScreen)).BeginInit();
            this.MainSplitScreen.Panel1.SuspendLayout();
            this.MainSplitScreen.Panel2.SuspendLayout();
            this.MainSplitScreen.SuspendLayout();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainSplitScreen
            // 
            this.MainSplitScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitScreen.IsSplitterFixed = true;
            this.MainSplitScreen.Location = new System.Drawing.Point(0, 0);
            this.MainSplitScreen.Name = "MainSplitScreen";
            this.MainSplitScreen.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MainSplitScreen.Panel1
            // 
            this.MainSplitScreen.Panel1.BackColor = System.Drawing.Color.LightGreen;
            this.MainSplitScreen.Panel1.Controls.Add(this.filter_combobox);
            this.MainSplitScreen.Panel1.Controls.Add(this.refeicoesTabButton);
            this.MainSplitScreen.Panel1.Controls.Add(this.searchButton);
            this.MainSplitScreen.Panel1.Controls.Add(this.SearchText);
            this.MainSplitScreen.Panel1.Controls.Add(this.AlimentosButton);
            this.MainSplitScreen.Panel1.Controls.Add(this.DietaTabButton);
            this.MainSplitScreen.Panel1.Controls.Add(this.UsuariosTabButton);
            // 
            // MainSplitScreen.Panel2
            // 
            this.MainSplitScreen.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MainSplitScreen.Panel2.Controls.Add(this.customPanel1);
            this.MainSplitScreen.Size = new System.Drawing.Size(1148, 684);
            this.MainSplitScreen.SplitterDistance = 70;
            this.MainSplitScreen.SplitterWidth = 1;
            this.MainSplitScreen.TabIndex = 0;
            // 
            // filter_combobox
            // 
            this.filter_combobox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filter_combobox.FormattingEnabled = true;
            this.filter_combobox.Location = new System.Drawing.Point(368, 19);
            this.filter_combobox.Name = "filter_combobox";
            this.filter_combobox.Size = new System.Drawing.Size(96, 29);
            this.filter_combobox.TabIndex = 10;
            this.filter_combobox.Text = "Filtro";
            // 
            // refeicoesTabButton
            // 
            this.refeicoesTabButton.BackColor = System.Drawing.Color.White;
            this.refeicoesTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refeicoesTabButton.Location = new System.Drawing.Point(963, 18);
            this.refeicoesTabButton.Name = "refeicoesTabButton";
            this.refeicoesTabButton.Size = new System.Drawing.Size(78, 31);
            this.refeicoesTabButton.TabIndex = 9;
            this.refeicoesTabButton.Text = "Refeições";
            this.refeicoesTabButton.UseVisualStyleBackColor = false;
            this.refeicoesTabButton.Click += new System.EventHandler(this.TabButtonClick);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(465, 18);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(33, 31);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "🔎";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // SearchText
            // 
            this.SearchText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchText.Location = new System.Drawing.Point(20, 19);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(345, 29);
            this.SearchText.TabIndex = 3;
            // 
            // AlimentosButton
            // 
            this.AlimentosButton.BackColor = System.Drawing.Color.White;
            this.AlimentosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlimentosButton.Location = new System.Drawing.Point(879, 18);
            this.AlimentosButton.Name = "AlimentosButton";
            this.AlimentosButton.Size = new System.Drawing.Size(78, 31);
            this.AlimentosButton.TabIndex = 2;
            this.AlimentosButton.Text = "Alimentos";
            this.AlimentosButton.UseVisualStyleBackColor = false;
            this.AlimentosButton.Click += new System.EventHandler(this.TabButtonClick);
            // 
            // DietaTabButton
            // 
            this.DietaTabButton.BackColor = System.Drawing.Color.White;
            this.DietaTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DietaTabButton.Location = new System.Drawing.Point(1047, 18);
            this.DietaTabButton.Name = "DietaTabButton";
            this.DietaTabButton.Size = new System.Drawing.Size(78, 31);
            this.DietaTabButton.TabIndex = 1;
            this.DietaTabButton.Text = "Dietas";
            this.DietaTabButton.UseVisualStyleBackColor = false;
            this.DietaTabButton.Click += new System.EventHandler(this.TabButtonClick);
            // 
            // UsuariosTabButton
            // 
            this.UsuariosTabButton.BackColor = System.Drawing.Color.White;
            this.UsuariosTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsuariosTabButton.Location = new System.Drawing.Point(795, 18);
            this.UsuariosTabButton.Name = "UsuariosTabButton";
            this.UsuariosTabButton.Size = new System.Drawing.Size(78, 30);
            this.UsuariosTabButton.TabIndex = 0;
            this.UsuariosTabButton.Text = "Usuários";
            this.UsuariosTabButton.UseVisualStyleBackColor = false;
            this.UsuariosTabButton.Click += new System.EventHandler(this.TabButtonClick);
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.Transparent;
            this.customPanel1.Controls.Add(this.pesoTemplateLabel);
            this.customPanel1.Controls.Add(this.alturaTemplateLabel);
            this.customPanel1.Controls.Add(this.idadeTemplateLabel);
            this.customPanel1.Controls.Add(this.TemplateGeneroLabel);
            this.customPanel1.Controls.Add(this.templateDietaLabel);
            this.customPanel1.Controls.Add(this.tipoLabelTemplate);
            this.customPanel1.Controls.Add(this.idLabelTemplate);
            this.customPanel1.Controls.Add(this.templateLabelUsuario);
            this.customPanel1.Location = new System.Drawing.Point(3, 24);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(292, 214);
            this.customPanel1.TabIndex = 0;
            // 
            // alturaTemplateLabel
            // 
            this.alturaTemplateLabel.AutoSize = true;
            this.alturaTemplateLabel.BackColor = System.Drawing.SystemColors.Window;
            this.alturaTemplateLabel.Location = new System.Drawing.Point(153, 55);
            this.alturaTemplateLabel.Name = "alturaTemplateLabel";
            this.alturaTemplateLabel.Size = new System.Drawing.Size(42, 15);
            this.alturaTemplateLabel.TabIndex = 8;
            this.alturaTemplateLabel.Text = "Altura:";
            // 
            // idadeTemplateLabel
            // 
            this.idadeTemplateLabel.AutoSize = true;
            this.idadeTemplateLabel.BackColor = System.Drawing.SystemColors.Window;
            this.idadeTemplateLabel.Location = new System.Drawing.Point(153, 30);
            this.idadeTemplateLabel.Name = "idadeTemplateLabel";
            this.idadeTemplateLabel.Size = new System.Drawing.Size(39, 15);
            this.idadeTemplateLabel.TabIndex = 7;
            this.idadeTemplateLabel.Text = "Idade:";
            // 
            // TemplateGeneroLabel
            // 
            this.TemplateGeneroLabel.AutoSize = true;
            this.TemplateGeneroLabel.BackColor = System.Drawing.SystemColors.Window;
            this.TemplateGeneroLabel.Location = new System.Drawing.Point(23, 130);
            this.TemplateGeneroLabel.Name = "TemplateGeneroLabel";
            this.TemplateGeneroLabel.Size = new System.Drawing.Size(48, 15);
            this.TemplateGeneroLabel.TabIndex = 6;
            this.TemplateGeneroLabel.Text = "Gênero:";
            // 
            // templateDietaLabel
            // 
            this.templateDietaLabel.AutoSize = true;
            this.templateDietaLabel.BackColor = System.Drawing.SystemColors.Window;
            this.templateDietaLabel.Location = new System.Drawing.Point(23, 105);
            this.templateDietaLabel.Name = "templateDietaLabel";
            this.templateDietaLabel.Size = new System.Drawing.Size(37, 15);
            this.templateDietaLabel.TabIndex = 5;
            this.templateDietaLabel.Text = "Dieta:";
            // 
            // tipoLabelTemplate
            // 
            this.tipoLabelTemplate.AutoSize = true;
            this.tipoLabelTemplate.BackColor = System.Drawing.Color.White;
            this.tipoLabelTemplate.Location = new System.Drawing.Point(23, 80);
            this.tipoLabelTemplate.Name = "tipoLabelTemplate";
            this.tipoLabelTemplate.Size = new System.Drawing.Size(36, 15);
            this.tipoLabelTemplate.TabIndex = 4;
            this.tipoLabelTemplate.Text = "Tipo: ";
            // 
            // idLabelTemplate
            // 
            this.idLabelTemplate.AutoSize = true;
            this.idLabelTemplate.BackColor = System.Drawing.SystemColors.Window;
            this.idLabelTemplate.Location = new System.Drawing.Point(23, 30);
            this.idLabelTemplate.Name = "idLabelTemplate";
            this.idLabelTemplate.Size = new System.Drawing.Size(24, 15);
            this.idLabelTemplate.TabIndex = 3;
            this.idLabelTemplate.Text = "ID: ";
            // 
            // templateLabelUsuario
            // 
            this.templateLabelUsuario.AutoSize = true;
            this.templateLabelUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.templateLabelUsuario.Location = new System.Drawing.Point(23, 55);
            this.templateLabelUsuario.Name = "templateLabelUsuario";
            this.templateLabelUsuario.Size = new System.Drawing.Size(53, 15);
            this.templateLabelUsuario.TabIndex = 1;
            this.templateLabelUsuario.Text = "Usuario: ";
            // 
            // pesoTemplateLabel
            // 
            this.pesoTemplateLabel.AutoSize = true;
            this.pesoTemplateLabel.BackColor = System.Drawing.SystemColors.Window;
            this.pesoTemplateLabel.Location = new System.Drawing.Point(153, 80);
            this.pesoTemplateLabel.Name = "pesoTemplateLabel";
            this.pesoTemplateLabel.Size = new System.Drawing.Size(60, 15);
            this.pesoTemplateLabel.TabIndex = 9;
            this.pesoTemplateLabel.Text = "Peso (KG):";
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 684);
            this.Controls.Add(this.MainSplitScreen);
            this.Name = "MainApp";
            this.Text = "Gerenciamento de Dietas";
            this.MainSplitScreen.Panel1.ResumeLayout(false);
            this.MainSplitScreen.Panel1.PerformLayout();
            this.MainSplitScreen.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitScreen)).EndInit();
            this.MainSplitScreen.ResumeLayout(false);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button DietaTabButton;
        private Button UsuariosTabButton;
        private Button AlimentosButton;
        private Button searchButton;
        private TextBox SearchText;
        public SplitContainer MainSplitScreen;
        private Button refeicoesTabButton;
        private ComboBox filter_combobox;
        private CustomPanel customPanel1;
        private Label templateLabelUsuario;
        private Label idLabelTemplate;
        private Label tipoLabelTemplate;
        private Label templateDietaLabel;
        private Label TemplateGeneroLabel;
        private Label idadeTemplateLabel;
        private Label alturaTemplateLabel;
        private Label pesoTemplateLabel;
    }
}