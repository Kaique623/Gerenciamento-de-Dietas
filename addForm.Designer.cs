namespace Gerenciamento_de_Dietas
{
    partial class addForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CancelButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.email_TextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.tipo_combobox = new System.Windows.Forms.ComboBox();
            this.id_label = new System.Windows.Forms.Label();
            this.id_textbox = new System.Windows.Forms.TextBox();
            this.AddTabControl = new System.Windows.Forms.TabControl();
            this.usuarioTabPage = new System.Windows.Forms.TabPage();
            this.alimentoTabPage = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gordurasLabel = new System.Windows.Forms.Label();
            this.gordurasTextBox = new System.Windows.Forms.TextBox();
            this.carboidratoLabel = new System.Windows.Forms.Label();
            this.carboidratosTextBox = new System.Windows.Forms.TextBox();
            this.proteinasLabel = new System.Windows.Forms.Label();
            this.proteinasTextBox = new System.Windows.Forms.TextBox();
            this.caloriasLabel = new System.Windows.Forms.Label();
            this.caloriasTextBox = new System.Windows.Forms.TextBox();
            this.nomeAlimentLabel = new System.Windows.Forms.Label();
            this.nomeAlimentoTextBox = new System.Windows.Forms.TextBox();
            this.DietaTabPage = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.nomeDietaTextBox = new System.Windows.Forms.TextBox();
            this.nomeDietaLabel = new System.Windows.Forms.Label();
            this.caloriasTotaisLabel = new System.Windows.Forms.Label();
            this.caloriasTotaisTextBox = new System.Windows.Forms.TextBox();
            this.RefeicaoTabPage = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.id_dietaLabel = new System.Windows.Forms.Label();
            this.idDietaTextBox = new System.Windows.Forms.TextBox();
            this.nomeRefeicaoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.horarioTextBox = new System.Windows.Forms.TextBox();
            this.refeicao_alimentos = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.adicionar_refeicaoButton = new System.Windows.Forms.Button();
            this.id_alimentoTextBox = new System.Windows.Forms.TextBox();
            this.sairButton = new System.Windows.Forms.Button();
            this.refeicao_alimento_datagrid = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.AddTabControl.SuspendLayout();
            this.usuarioTabPage.SuspendLayout();
            this.alimentoTabPage.SuspendLayout();
            this.DietaTabPage.SuspendLayout();
            this.RefeicaoTabPage.SuspendLayout();
            this.refeicao_alimentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refeicao_alimento_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Red;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelButton.ForeColor = System.Drawing.Color.Black;
            this.CancelButton.Location = new System.Drawing.Point(491, 366);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(172, 35);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancelar";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmButton.ForeColor = System.Drawing.Color.Black;
            this.confirmButton.Location = new System.Drawing.Point(491, 325);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(172, 35);
            this.confirmButton.TabIndex = 1;
            this.confirmButton.Text = "Confirmar";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nomeTextBox.Location = new System.Drawing.Point(491, 126);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(172, 32);
            this.nomeTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(491, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(491, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email";
            // 
            // email_TextBox
            // 
            this.email_TextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email_TextBox.Location = new System.Drawing.Point(491, 186);
            this.email_TextBox.Name = "email_TextBox";
            this.email_TextBox.Size = new System.Drawing.Size(172, 32);
            this.email_TextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(491, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo";
            // 
            // tipo_combobox
            // 
            this.tipo_combobox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tipo_combobox.FormattingEnabled = true;
            this.tipo_combobox.Items.AddRange(new object[] {
            "nutrólogo",
            "paciente"});
            this.tipo_combobox.Location = new System.Drawing.Point(491, 249);
            this.tipo_combobox.Name = "tipo_combobox";
            this.tipo_combobox.Size = new System.Drawing.Size(172, 33);
            this.tipo_combobox.TabIndex = 7;
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.id_label.Location = new System.Drawing.Point(491, 35);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(30, 25);
            this.id_label.TabIndex = 9;
            this.id_label.Text = "ID";
            // 
            // id_textbox
            // 
            this.id_textbox.Enabled = false;
            this.id_textbox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.id_textbox.Location = new System.Drawing.Point(491, 63);
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.Size = new System.Drawing.Size(172, 32);
            this.id_textbox.TabIndex = 8;
            // 
            // AddTabControl
            // 
            this.AddTabControl.Controls.Add(this.usuarioTabPage);
            this.AddTabControl.Controls.Add(this.alimentoTabPage);
            this.AddTabControl.Controls.Add(this.DietaTabPage);
            this.AddTabControl.Controls.Add(this.RefeicaoTabPage);
            this.AddTabControl.Controls.Add(this.refeicao_alimentos);
            this.AddTabControl.Location = new System.Drawing.Point(-9, 0);
            this.AddTabControl.Name = "AddTabControl";
            this.AddTabControl.SelectedIndex = 0;
            this.AddTabControl.Size = new System.Drawing.Size(1227, 710);
            this.AddTabControl.TabIndex = 10;
            // 
            // usuarioTabPage
            // 
            this.usuarioTabPage.Controls.Add(this.tipo_combobox);
            this.usuarioTabPage.Controls.Add(this.id_label);
            this.usuarioTabPage.Controls.Add(this.CancelButton);
            this.usuarioTabPage.Controls.Add(this.id_textbox);
            this.usuarioTabPage.Controls.Add(this.confirmButton);
            this.usuarioTabPage.Controls.Add(this.nomeTextBox);
            this.usuarioTabPage.Controls.Add(this.label3);
            this.usuarioTabPage.Controls.Add(this.label1);
            this.usuarioTabPage.Controls.Add(this.label2);
            this.usuarioTabPage.Controls.Add(this.email_TextBox);
            this.usuarioTabPage.Location = new System.Drawing.Point(4, 24);
            this.usuarioTabPage.Name = "usuarioTabPage";
            this.usuarioTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.usuarioTabPage.Size = new System.Drawing.Size(1219, 682);
            this.usuarioTabPage.TabIndex = 0;
            this.usuarioTabPage.Text = "Usuário";
            this.usuarioTabPage.UseVisualStyleBackColor = true;
            this.usuarioTabPage.Paint += new System.Windows.Forms.PaintEventHandler(this.usuarioTabPage_Paint);
            // 
            // alimentoTabPage
            // 
            this.alimentoTabPage.Controls.Add(this.button1);
            this.alimentoTabPage.Controls.Add(this.button2);
            this.alimentoTabPage.Controls.Add(this.gordurasLabel);
            this.alimentoTabPage.Controls.Add(this.gordurasTextBox);
            this.alimentoTabPage.Controls.Add(this.carboidratoLabel);
            this.alimentoTabPage.Controls.Add(this.carboidratosTextBox);
            this.alimentoTabPage.Controls.Add(this.proteinasLabel);
            this.alimentoTabPage.Controls.Add(this.proteinasTextBox);
            this.alimentoTabPage.Controls.Add(this.caloriasLabel);
            this.alimentoTabPage.Controls.Add(this.caloriasTextBox);
            this.alimentoTabPage.Controls.Add(this.nomeAlimentLabel);
            this.alimentoTabPage.Controls.Add(this.nomeAlimentoTextBox);
            this.alimentoTabPage.Location = new System.Drawing.Point(4, 24);
            this.alimentoTabPage.Name = "alimentoTabPage";
            this.alimentoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.alimentoTabPage.Size = new System.Drawing.Size(1219, 682);
            this.alimentoTabPage.TabIndex = 1;
            this.alimentoTabPage.Text = "Alimento";
            this.alimentoTabPage.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(493, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 35);
            this.button1.TabIndex = 20;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(493, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 35);
            this.button2.TabIndex = 21;
            this.button2.Text = "Confirmar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // gordurasLabel
            // 
            this.gordurasLabel.AutoSize = true;
            this.gordurasLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gordurasLabel.Location = new System.Drawing.Point(375, 232);
            this.gordurasLabel.Name = "gordurasLabel";
            this.gordurasLabel.Size = new System.Drawing.Size(90, 25);
            this.gordurasLabel.TabIndex = 19;
            this.gordurasLabel.Text = "Gorduras";
            // 
            // gordurasTextBox
            // 
            this.gordurasTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gordurasTextBox.Location = new System.Drawing.Point(375, 260);
            this.gordurasTextBox.Name = "gordurasTextBox";
            this.gordurasTextBox.Size = new System.Drawing.Size(172, 32);
            this.gordurasTextBox.TabIndex = 18;
            // 
            // carboidratoLabel
            // 
            this.carboidratoLabel.AutoSize = true;
            this.carboidratoLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.carboidratoLabel.Location = new System.Drawing.Point(585, 154);
            this.carboidratoLabel.Name = "carboidratoLabel";
            this.carboidratoLabel.Size = new System.Drawing.Size(121, 25);
            this.carboidratoLabel.TabIndex = 17;
            this.carboidratoLabel.Text = "Carboidratos";
            // 
            // carboidratosTextBox
            // 
            this.carboidratosTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.carboidratosTextBox.Location = new System.Drawing.Point(585, 182);
            this.carboidratosTextBox.Name = "carboidratosTextBox";
            this.carboidratosTextBox.Size = new System.Drawing.Size(172, 32);
            this.carboidratosTextBox.TabIndex = 16;
            // 
            // proteinasLabel
            // 
            this.proteinasLabel.AutoSize = true;
            this.proteinasLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.proteinasLabel.Location = new System.Drawing.Point(375, 154);
            this.proteinasLabel.Name = "proteinasLabel";
            this.proteinasLabel.Size = new System.Drawing.Size(91, 25);
            this.proteinasLabel.TabIndex = 15;
            this.proteinasLabel.Text = "Proteinas";
            // 
            // proteinasTextBox
            // 
            this.proteinasTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.proteinasTextBox.Location = new System.Drawing.Point(375, 182);
            this.proteinasTextBox.Name = "proteinasTextBox";
            this.proteinasTextBox.Size = new System.Drawing.Size(172, 32);
            this.proteinasTextBox.TabIndex = 14;
            // 
            // caloriasLabel
            // 
            this.caloriasLabel.AutoSize = true;
            this.caloriasLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.caloriasLabel.Location = new System.Drawing.Point(585, 84);
            this.caloriasLabel.Name = "caloriasLabel";
            this.caloriasLabel.Size = new System.Drawing.Size(80, 25);
            this.caloriasLabel.TabIndex = 13;
            this.caloriasLabel.Text = "Calorias";
            // 
            // caloriasTextBox
            // 
            this.caloriasTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.caloriasTextBox.Location = new System.Drawing.Point(585, 112);
            this.caloriasTextBox.Name = "caloriasTextBox";
            this.caloriasTextBox.Size = new System.Drawing.Size(172, 32);
            this.caloriasTextBox.TabIndex = 12;
            // 
            // nomeAlimentLabel
            // 
            this.nomeAlimentLabel.AutoSize = true;
            this.nomeAlimentLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nomeAlimentLabel.Location = new System.Drawing.Point(375, 84);
            this.nomeAlimentLabel.Name = "nomeAlimentLabel";
            this.nomeAlimentLabel.Size = new System.Drawing.Size(63, 25);
            this.nomeAlimentLabel.TabIndex = 11;
            this.nomeAlimentLabel.Text = "Nome";
            // 
            // nomeAlimentoTextBox
            // 
            this.nomeAlimentoTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nomeAlimentoTextBox.Location = new System.Drawing.Point(375, 112);
            this.nomeAlimentoTextBox.Name = "nomeAlimentoTextBox";
            this.nomeAlimentoTextBox.Size = new System.Drawing.Size(172, 32);
            this.nomeAlimentoTextBox.TabIndex = 10;
            // 
            // DietaTabPage
            // 
            this.DietaTabPage.Controls.Add(this.button3);
            this.DietaTabPage.Controls.Add(this.button4);
            this.DietaTabPage.Controls.Add(this.nomeDietaTextBox);
            this.DietaTabPage.Controls.Add(this.nomeDietaLabel);
            this.DietaTabPage.Controls.Add(this.caloriasTotaisLabel);
            this.DietaTabPage.Controls.Add(this.caloriasTotaisTextBox);
            this.DietaTabPage.Location = new System.Drawing.Point(4, 24);
            this.DietaTabPage.Name = "DietaTabPage";
            this.DietaTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DietaTabPage.Size = new System.Drawing.Size(1219, 682);
            this.DietaTabPage.TabIndex = 2;
            this.DietaTabPage.Text = "Dieta";
            this.DietaTabPage.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(460, 362);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 35);
            this.button3.TabIndex = 10;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(460, 321);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 35);
            this.button4.TabIndex = 11;
            this.button4.Text = "Confirmar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // nomeDietaTextBox
            // 
            this.nomeDietaTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nomeDietaTextBox.Location = new System.Drawing.Point(460, 140);
            this.nomeDietaTextBox.Name = "nomeDietaTextBox";
            this.nomeDietaTextBox.Size = new System.Drawing.Size(172, 32);
            this.nomeDietaTextBox.TabIndex = 6;
            // 
            // nomeDietaLabel
            // 
            this.nomeDietaLabel.AutoSize = true;
            this.nomeDietaLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nomeDietaLabel.Location = new System.Drawing.Point(460, 112);
            this.nomeDietaLabel.Name = "nomeDietaLabel";
            this.nomeDietaLabel.Size = new System.Drawing.Size(63, 25);
            this.nomeDietaLabel.TabIndex = 7;
            this.nomeDietaLabel.Text = "Nome";
            // 
            // caloriasTotaisLabel
            // 
            this.caloriasTotaisLabel.AutoSize = true;
            this.caloriasTotaisLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.caloriasTotaisLabel.Location = new System.Drawing.Point(460, 172);
            this.caloriasTotaisLabel.Name = "caloriasTotaisLabel";
            this.caloriasTotaisLabel.Size = new System.Drawing.Size(133, 25);
            this.caloriasTotaisLabel.TabIndex = 9;
            this.caloriasTotaisLabel.Text = "Calorias Totais";
            // 
            // caloriasTotaisTextBox
            // 
            this.caloriasTotaisTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.caloriasTotaisTextBox.Location = new System.Drawing.Point(460, 200);
            this.caloriasTotaisTextBox.Name = "caloriasTotaisTextBox";
            this.caloriasTotaisTextBox.Size = new System.Drawing.Size(172, 32);
            this.caloriasTotaisTextBox.TabIndex = 8;
            // 
            // RefeicaoTabPage
            // 
            this.RefeicaoTabPage.Controls.Add(this.button5);
            this.RefeicaoTabPage.Controls.Add(this.button6);
            this.RefeicaoTabPage.Controls.Add(this.id_dietaLabel);
            this.RefeicaoTabPage.Controls.Add(this.idDietaTextBox);
            this.RefeicaoTabPage.Controls.Add(this.nomeRefeicaoTextBox);
            this.RefeicaoTabPage.Controls.Add(this.label4);
            this.RefeicaoTabPage.Controls.Add(this.label5);
            this.RefeicaoTabPage.Controls.Add(this.horarioTextBox);
            this.RefeicaoTabPage.Location = new System.Drawing.Point(4, 24);
            this.RefeicaoTabPage.Name = "RefeicaoTabPage";
            this.RefeicaoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RefeicaoTabPage.Size = new System.Drawing.Size(1219, 682);
            this.RefeicaoTabPage.TabIndex = 3;
            this.RefeicaoTabPage.Text = "Refeicao";
            this.RefeicaoTabPage.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(471, 384);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(172, 35);
            this.button5.TabIndex = 16;
            this.button5.Text = "Cancelar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(471, 343);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(172, 35);
            this.button6.TabIndex = 17;
            this.button6.Text = "Confirmar";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // id_dietaLabel
            // 
            this.id_dietaLabel.AutoSize = true;
            this.id_dietaLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.id_dietaLabel.Location = new System.Drawing.Point(471, 196);
            this.id_dietaLabel.Name = "id_dietaLabel";
            this.id_dietaLabel.Size = new System.Drawing.Size(91, 25);
            this.id_dietaLabel.TabIndex = 15;
            this.id_dietaLabel.Text = "ID (Dieta)";
            // 
            // idDietaTextBox
            // 
            this.idDietaTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idDietaTextBox.Location = new System.Drawing.Point(471, 224);
            this.idDietaTextBox.Name = "idDietaTextBox";
            this.idDietaTextBox.Size = new System.Drawing.Size(172, 32);
            this.idDietaTextBox.TabIndex = 14;
            // 
            // nomeRefeicaoTextBox
            // 
            this.nomeRefeicaoTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nomeRefeicaoTextBox.Location = new System.Drawing.Point(471, 96);
            this.nomeRefeicaoTextBox.Name = "nomeRefeicaoTextBox";
            this.nomeRefeicaoTextBox.Size = new System.Drawing.Size(172, 32);
            this.nomeRefeicaoTextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(471, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(471, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Horário";
            // 
            // horarioTextBox
            // 
            this.horarioTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.horarioTextBox.Location = new System.Drawing.Point(471, 156);
            this.horarioTextBox.Name = "horarioTextBox";
            this.horarioTextBox.Size = new System.Drawing.Size(172, 32);
            this.horarioTextBox.TabIndex = 12;
            // 
            // refeicao_alimentos
            // 
            this.refeicao_alimentos.Controls.Add(this.button7);
            this.refeicao_alimentos.Controls.Add(this.label7);
            this.refeicao_alimentos.Controls.Add(this.quantidadeTextBox);
            this.refeicao_alimentos.Controls.Add(this.label6);
            this.refeicao_alimentos.Controls.Add(this.adicionar_refeicaoButton);
            this.refeicao_alimentos.Controls.Add(this.id_alimentoTextBox);
            this.refeicao_alimentos.Controls.Add(this.sairButton);
            this.refeicao_alimentos.Controls.Add(this.refeicao_alimento_datagrid);
            this.refeicao_alimentos.Location = new System.Drawing.Point(4, 24);
            this.refeicao_alimentos.Name = "refeicao_alimentos";
            this.refeicao_alimentos.Padding = new System.Windows.Forms.Padding(3);
            this.refeicao_alimentos.Size = new System.Drawing.Size(1219, 682);
            this.refeicao_alimentos.TabIndex = 4;
            this.refeicao_alimentos.Text = "refeicao_alimento";
            this.refeicao_alimentos.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Quantidade";
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.Location = new System.Drawing.Point(141, 33);
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.Size = new System.Drawing.Size(118, 23);
            this.quantidadeTextBox.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "ID (Alimento)";
            // 
            // adicionar_refeicaoButton
            // 
            this.adicionar_refeicaoButton.Location = new System.Drawing.Point(273, 31);
            this.adicionar_refeicaoButton.Name = "adicionar_refeicaoButton";
            this.adicionar_refeicaoButton.Size = new System.Drawing.Size(75, 25);
            this.adicionar_refeicaoButton.TabIndex = 19;
            this.adicionar_refeicaoButton.Text = "Adicionar";
            this.adicionar_refeicaoButton.UseVisualStyleBackColor = true;
            this.adicionar_refeicaoButton.Click += new System.EventHandler(this.adicionar_refeicaoButton_Click);
            // 
            // id_alimentoTextBox
            // 
            this.id_alimentoTextBox.Location = new System.Drawing.Point(17, 33);
            this.id_alimentoTextBox.Name = "id_alimentoTextBox";
            this.id_alimentoTextBox.Size = new System.Drawing.Size(118, 23);
            this.id_alimentoTextBox.TabIndex = 18;
            // 
            // sairButton
            // 
            this.sairButton.BackColor = System.Drawing.Color.Red;
            this.sairButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sairButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sairButton.ForeColor = System.Drawing.Color.Black;
            this.sairButton.Location = new System.Drawing.Point(1040, 27);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(96, 35);
            this.sairButton.TabIndex = 17;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = false;
            this.sairButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // refeicao_alimento_datagrid
            // 
            this.refeicao_alimento_datagrid.AllowUserToAddRows = false;
            this.refeicao_alimento_datagrid.AllowUserToDeleteRows = false;
            this.refeicao_alimento_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.refeicao_alimento_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.refeicao_alimento_datagrid.Location = new System.Drawing.Point(17, 68);
            this.refeicao_alimento_datagrid.Name = "refeicao_alimento_datagrid";
            this.refeicao_alimento_datagrid.ReadOnly = true;
            this.refeicao_alimento_datagrid.RowTemplate.Height = 25;
            this.refeicao_alimento_datagrid.Size = new System.Drawing.Size(1119, 463);
            this.refeicao_alimento_datagrid.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Gainsboro;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(918, 27);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(116, 35);
            this.button7.TabIndex = 23;
            this.button7.Text = "Gerar Relatorio";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.gerarRelatorio);
            // 
            // addForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1148, 684);
            this.Controls.Add(this.AddTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "addForm";
            this.AddTabControl.ResumeLayout(false);
            this.usuarioTabPage.ResumeLayout(false);
            this.usuarioTabPage.PerformLayout();
            this.alimentoTabPage.ResumeLayout(false);
            this.alimentoTabPage.PerformLayout();
            this.DietaTabPage.ResumeLayout(false);
            this.DietaTabPage.PerformLayout();
            this.RefeicaoTabPage.ResumeLayout(false);
            this.RefeicaoTabPage.PerformLayout();
            this.refeicao_alimentos.ResumeLayout(false);
            this.refeicao_alimentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refeicao_alimento_datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button CancelButton;
        private Button confirmButton;
        private TextBox nomeTextBox;
        private Label label1;
        private Label label2;
        private TextBox email_TextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label3;
        private ComboBox tipo_combobox;
        private Label id_label;
        private TextBox id_textbox;
        private TabControl AddTabControl;
        private TabPage usuarioTabPage;
        private TabPage alimentoTabPage;
        private Label caloriasLabel;
        private TextBox caloriasTextBox;
        private Label nomeAlimentLabel;
        private TextBox nomeAlimentoTextBox;
        private Label proteinasLabel;
        private TextBox proteinasTextBox;
        private Label carboidratoLabel;
        private TextBox carboidratosTextBox;
        private Label gordurasLabel;
        private TextBox gordurasTextBox;
        private Button button1;
        private Button button2;
        private TabPage DietaTabPage;
        private TextBox nomeDietaTextBox;
        private Label nomeDietaLabel;
        private Label caloriasTotaisLabel;
        private TextBox caloriasTotaisTextBox;
        private Button button3;
        private Button button4;
        private TabPage RefeicaoTabPage;
        private Label id_dietaLabel;
        private TextBox idDietaTextBox;
        private TextBox nomeRefeicaoTextBox;
        private Label label4;
        private Label label5;
        private TextBox horarioTextBox;
        private Button button5;
        private Button button6;
        private TabPage refeicao_alimentos;
        private DataGridView refeicao_alimento_datagrid;
        private Button sairButton;
        private Label label6;
        private Button adicionar_refeicaoButton;
        private TextBox id_alimentoTextBox;
        private Label label7;
        private TextBox quantidadeTextBox;
        private Button button7;
    }
}