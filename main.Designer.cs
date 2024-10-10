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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pageLabel = new System.Windows.Forms.Label();
            this.changeTabRightButton = new System.Windows.Forms.Button();
            this.ChangeTabLeftButton = new System.Windows.Forms.Button();
            this.clearSearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitScreen)).BeginInit();
            this.MainSplitScreen.Panel1.SuspendLayout();
            this.MainSplitScreen.Panel2.SuspendLayout();
            this.MainSplitScreen.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.MainSplitScreen.Panel1.Controls.Add(this.clearSearchButton);
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
            this.MainSplitScreen.Panel2.Controls.Add(this.panel1);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.pageLabel);
            this.panel1.Controls.Add(this.changeTabRightButton);
            this.panel1.Controls.Add(this.ChangeTabLeftButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 543);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 70);
            this.panel1.TabIndex = 0;
            // 
            // pageLabel
            // 
            this.pageLabel.AutoSize = true;
            this.pageLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pageLabel.Location = new System.Drawing.Point(539, 19);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new System.Drawing.Size(49, 32);
            this.pageLabel.TabIndex = 2;
            this.pageLabel.Text = "0/0";
            this.pageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeTabRightButton
            // 
            this.changeTabRightButton.BackColor = System.Drawing.Color.White;
            this.changeTabRightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeTabRightButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeTabRightButton.Location = new System.Drawing.Point(603, 13);
            this.changeTabRightButton.Margin = new System.Windows.Forms.Padding(2);
            this.changeTabRightButton.Name = "changeTabRightButton";
            this.changeTabRightButton.Size = new System.Drawing.Size(44, 44);
            this.changeTabRightButton.TabIndex = 1;
            this.changeTabRightButton.Text = "⮞";
            this.changeTabRightButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.changeTabRightButton.UseVisualStyleBackColor = false;
            this.changeTabRightButton.Click += new System.EventHandler(this.ChangePageButton);
            // 
            // ChangeTabLeftButton
            // 
            this.ChangeTabLeftButton.BackColor = System.Drawing.Color.White;
            this.ChangeTabLeftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeTabLeftButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangeTabLeftButton.Location = new System.Drawing.Point(479, 13);
            this.ChangeTabLeftButton.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeTabLeftButton.Name = "ChangeTabLeftButton";
            this.ChangeTabLeftButton.Size = new System.Drawing.Size(44, 44);
            this.ChangeTabLeftButton.TabIndex = 0;
            this.ChangeTabLeftButton.Text = "⮜";
            this.ChangeTabLeftButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ChangeTabLeftButton.UseVisualStyleBackColor = false;
            this.ChangeTabLeftButton.Click += new System.EventHandler(this.ChangePageButton);
            // 
            // clearSearchButton
            // 
            this.clearSearchButton.Location = new System.Drawing.Point(504, 18);
            this.clearSearchButton.Name = "clearSearchButton";
            this.clearSearchButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.clearSearchButton.Size = new System.Drawing.Size(101, 30);
            this.clearSearchButton.TabIndex = 11;
            this.clearSearchButton.Text = "Limpar Pesquisa";
            this.clearSearchButton.UseVisualStyleBackColor = true;
            this.clearSearchButton.Click += new System.EventHandler(this.clearSearchButton_Click);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private Panel panel1;
        private Button changeTabRightButton;
        private Button ChangeTabLeftButton;
        private Label pageLabel;
        private Button clearSearchButton;
    }
}