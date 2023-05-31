namespace CRUD
{
    partial class CadastroDePecas
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.categoria = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.descricao = new System.Windows.Forms.Label();
            this.dataFabricacao = new System.Windows.Forms.Label();
            this.estoque = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AoClicarEmSalvar);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(266, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 26);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AoClicarCancelar);
            // 
            // categoria
            // 
            this.categoria.AutoSize = true;
            this.categoria.Location = new System.Drawing.Point(25, 35);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(58, 15);
            this.categoria.TabIndex = 2;
            this.categoria.Text = "Categoria";
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(25, 77);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(40, 15);
            this.nome.TabIndex = 3;
            this.nome.Text = "Nome";
            // 
            // descricao
            // 
            this.descricao.AutoSize = true;
            this.descricao.Location = new System.Drawing.Point(25, 119);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(58, 15);
            this.descricao.TabIndex = 4;
            this.descricao.Text = "Descrição";
            // 
            // dataFabricacao
            // 
            this.dataFabricacao.AutoSize = true;
            this.dataFabricacao.Location = new System.Drawing.Point(203, 35);
            this.dataFabricacao.Name = "dataFabricacao";
            this.dataFabricacao.Size = new System.Drawing.Size(107, 15);
            this.dataFabricacao.TabIndex = 5;
            this.dataFabricacao.Text = "Data de Fabricação";
            // 
            // estoque
            // 
            this.estoque.AutoSize = true;
            this.estoque.Location = new System.Drawing.Point(203, 77);
            this.estoque.Name = "estoque";
            this.estoque.Size = new System.Drawing.Size(49, 15);
            this.estoque.TabIndex = 6;
            this.estoque.Text = "Estoque";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 137);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 69);
            this.textBox1.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.HideSelection = false;
            this.textBox6.Location = new System.Drawing.Point(25, 53);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(150, 21);
            this.textBox6.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(25, 95);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 21);
            this.textBox2.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(203, 51);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 23);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(203, 93);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(150, 23);
            this.numericUpDown1.TabIndex = 17;
            // 
            // CadastroDePecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 327);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.estoque);
            this.Controls.Add(this.dataFabricacao);
            this.Controls.Add(this.descricao);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "CadastroDePecas";
            this.Text = "Cadastro de Peças";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Label categoria;
        private Label nome;
        private Label descricao;
        private Label dataFabricacao;
        private Label estoque;
        private TextBox textBox1;
        private TextBox textBox6;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown numericUpDown1;
    }
}