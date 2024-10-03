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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainSplitScreen = new System.Windows.Forms.SplitContainer();
            this.refeicoesTabButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.RecarregarPagina = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.AlimentosButton = new System.Windows.Forms.Button();
            this.DietaTabButton = new System.Windows.Forms.Button();
            this.UsuariosTabButton = new System.Windows.Forms.Button();
            this.UserDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitScreen)).BeginInit();
            this.MainSplitScreen.Panel1.SuspendLayout();
            this.MainSplitScreen.Panel2.SuspendLayout();
            this.MainSplitScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGrid)).BeginInit();
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
            this.MainSplitScreen.Panel1.Controls.Add(this.refeicoesTabButton);
            this.MainSplitScreen.Panel1.Controls.Add(this.removeButton);
            this.MainSplitScreen.Panel1.Controls.Add(this.RecarregarPagina);
            this.MainSplitScreen.Panel1.Controls.Add(this.EditButton);
            this.MainSplitScreen.Panel1.Controls.Add(this.addButton);
            this.MainSplitScreen.Panel1.Controls.Add(this.searchButton);
            this.MainSplitScreen.Panel1.Controls.Add(this.SearchText);
            this.MainSplitScreen.Panel1.Controls.Add(this.AlimentosButton);
            this.MainSplitScreen.Panel1.Controls.Add(this.DietaTabButton);
            this.MainSplitScreen.Panel1.Controls.Add(this.UsuariosTabButton);
            // 
            // MainSplitScreen.Panel2
            // 
            this.MainSplitScreen.Panel2.BackColor = System.Drawing.Color.White;
            this.MainSplitScreen.Panel2.Controls.Add(this.UserDataGrid);
            this.MainSplitScreen.Size = new System.Drawing.Size(1148, 684);
            this.MainSplitScreen.SplitterDistance = 110;
            this.MainSplitScreen.SplitterWidth = 1;
            this.MainSplitScreen.TabIndex = 0;
            // 
            // refeicoesTabButton
            // 
            this.refeicoesTabButton.BackColor = System.Drawing.Color.White;
            this.refeicoesTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refeicoesTabButton.Location = new System.Drawing.Point(1058, 20);
            this.refeicoesTabButton.Name = "refeicoesTabButton";
            this.refeicoesTabButton.Size = new System.Drawing.Size(78, 64);
            this.refeicoesTabButton.TabIndex = 9;
            this.refeicoesTabButton.Text = "Refeições";
            this.refeicoesTabButton.UseVisualStyleBackColor = false;
            this.refeicoesTabButton.Click += new System.EventHandler(this.TabButtonClick);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.White;
            this.removeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Location = new System.Drawing.Point(249, 53);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(96, 41);
            this.removeButton.TabIndex = 8;
            this.removeButton.Text = "Remover";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // RecarregarPagina
            // 
            this.RecarregarPagina.BackColor = System.Drawing.Color.White;
            this.RecarregarPagina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RecarregarPagina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecarregarPagina.Location = new System.Drawing.Point(371, 53);
            this.RecarregarPagina.Name = "RecarregarPagina";
            this.RecarregarPagina.Size = new System.Drawing.Size(96, 41);
            this.RecarregarPagina.TabIndex = 7;
            this.RecarregarPagina.Text = "Recarregar Dados";
            this.RecarregarPagina.UseVisualStyleBackColor = false;
            this.RecarregarPagina.Click += new System.EventHandler(this.RecarregarPagina_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.White;
            this.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Location = new System.Drawing.Point(136, 53);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(96, 41);
            this.EditButton.TabIndex = 6;
            this.EditButton.Text = "Editar";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.White;
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(23, 53);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(96, 41);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Adicionar";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(469, 17);
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
            this.SearchText.Location = new System.Drawing.Point(23, 18);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(446, 29);
            this.SearchText.TabIndex = 3;
            // 
            // AlimentosButton
            // 
            this.AlimentosButton.BackColor = System.Drawing.Color.White;
            this.AlimentosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlimentosButton.Location = new System.Drawing.Point(974, 20);
            this.AlimentosButton.Name = "AlimentosButton";
            this.AlimentosButton.Size = new System.Drawing.Size(78, 64);
            this.AlimentosButton.TabIndex = 2;
            this.AlimentosButton.Text = "Alimentos";
            this.AlimentosButton.UseVisualStyleBackColor = false;
            this.AlimentosButton.Click += new System.EventHandler(this.TabButtonClick);
            // 
            // DietaTabButton
            // 
            this.DietaTabButton.BackColor = System.Drawing.Color.White;
            this.DietaTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DietaTabButton.Location = new System.Drawing.Point(890, 20);
            this.DietaTabButton.Name = "DietaTabButton";
            this.DietaTabButton.Size = new System.Drawing.Size(78, 64);
            this.DietaTabButton.TabIndex = 1;
            this.DietaTabButton.Text = "Dietas";
            this.DietaTabButton.UseVisualStyleBackColor = false;
            this.DietaTabButton.Click += new System.EventHandler(this.TabButtonClick);
            // 
            // UsuariosTabButton
            // 
            this.UsuariosTabButton.BackColor = System.Drawing.Color.White;
            this.UsuariosTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsuariosTabButton.Location = new System.Drawing.Point(806, 20);
            this.UsuariosTabButton.Name = "UsuariosTabButton";
            this.UsuariosTabButton.Size = new System.Drawing.Size(78, 64);
            this.UsuariosTabButton.TabIndex = 0;
            this.UsuariosTabButton.Text = "Usuários";
            this.UsuariosTabButton.UseVisualStyleBackColor = false;
            this.UsuariosTabButton.Click += new System.EventHandler(this.TabButtonClick);
            // 
            // UserDataGrid
            // 
            this.UserDataGrid.AllowUserToAddRows = false;
            this.UserDataGrid.AllowUserToDeleteRows = false;
            this.UserDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.UserDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.UserDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.UserDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.UserDataGrid.Location = new System.Drawing.Point(3, 3);
            this.UserDataGrid.Name = "UserDataGrid";
            this.UserDataGrid.ReadOnly = true;
            this.UserDataGrid.RowTemplate.Height = 25;
            this.UserDataGrid.Size = new System.Drawing.Size(1142, 570);
            this.UserDataGrid.TabIndex = 0;
            this.UserDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserDataGrid_CellContentClick);
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
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button DietaTabButton;
        private Button UsuariosTabButton;
        private DataGridView UserDataGrid;
        private Button AlimentosButton;
        private Button RecarregarPagina;
        private Button EditButton;
        private Button addButton;
        private Button searchButton;
        private TextBox SearchText;
        public SplitContainer MainSplitScreen;
        private Button removeButton;
        private Button refeicoesTabButton;
    }
}