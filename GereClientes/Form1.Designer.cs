namespace GereClientes
{
    partial class Form1
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
            this.groupBoxInserirCliente = new System.Windows.Forms.GroupBox();
            this.buttonAddCliente = new System.Windows.Forms.Button();
            this.textBoxClienteNif = new System.Windows.Forms.TextBox();
            this.labelInserirNif = new System.Windows.Forms.Label();
            this.labelInserirNome = new System.Windows.Forms.Label();
            this.textBoxClienteNome = new System.Windows.Forms.TextBox();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.groupBoxClientes = new System.Windows.Forms.GroupBox();
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.groupBoxCompras = new System.Windows.Forms.GroupBox();
            this.labelLinhasCompra = new System.Windows.Forms.Label();
            this.labelCompras = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelAddLinhaValor = new System.Windows.Forms.Label();
            this.labelAddLinhaDescricao = new System.Windows.Forms.Label();
            this.buttonAddLinha = new System.Windows.Forms.Button();
            this.textBoxAddLinhaValor = new System.Windows.Forms.TextBox();
            this.textBoxAddLinhaDescricao = new System.Windows.Forms.TextBox();
            this.labelTotalValor = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonApagarLinhaCompra = new System.Windows.Forms.Button();
            this.buttonApagarCompra = new System.Windows.Forms.Button();
            this.buttonCriarCompra = new System.Windows.Forms.Button();
            this.listBoxLinhasCompra = new System.Windows.Forms.ListBox();
            this.listBoxCompras = new System.Windows.Forms.ListBox();
            this.labelTotalClienteValor = new System.Windows.Forms.Label();
            this.labelTotalCliente = new System.Windows.Forms.Label();
            this.labelNifCliente = new System.Windows.Forms.Label();
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.groupBoxInserirCliente.SuspendLayout();
            this.groupBoxClientes.SuspendLayout();
            this.groupBoxCliente.SuspendLayout();
            this.groupBoxCompras.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInserirCliente
            // 
            this.groupBoxInserirCliente.Controls.Add(this.buttonAddCliente);
            this.groupBoxInserirCliente.Controls.Add(this.textBoxClienteNif);
            this.groupBoxInserirCliente.Controls.Add(this.labelInserirNif);
            this.groupBoxInserirCliente.Controls.Add(this.labelInserirNome);
            this.groupBoxInserirCliente.Controls.Add(this.textBoxClienteNome);
            this.groupBoxInserirCliente.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInserirCliente.Name = "groupBoxInserirCliente";
            this.groupBoxInserirCliente.Size = new System.Drawing.Size(304, 164);
            this.groupBoxInserirCliente.TabIndex = 0;
            this.groupBoxInserirCliente.TabStop = false;
            this.groupBoxInserirCliente.Text = "Inserir Cliente";
            // 
            // buttonAddCliente
            // 
            this.buttonAddCliente.Location = new System.Drawing.Point(182, 106);
            this.buttonAddCliente.Name = "buttonAddCliente";
            this.buttonAddCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonAddCliente.TabIndex = 5;
            this.buttonAddCliente.Text = "Adicionar";
            this.buttonAddCliente.UseVisualStyleBackColor = true;
            this.buttonAddCliente.Click += new System.EventHandler(this.buttonAddCliente_Click);
            // 
            // textBoxClienteNif
            // 
            this.textBoxClienteNif.Location = new System.Drawing.Point(67, 69);
            this.textBoxClienteNif.Name = "textBoxClienteNif";
            this.textBoxClienteNif.Size = new System.Drawing.Size(190, 20);
            this.textBoxClienteNif.TabIndex = 4;
            // 
            // labelInserirNif
            // 
            this.labelInserirNif.AutoSize = true;
            this.labelInserirNif.Location = new System.Drawing.Point(6, 69);
            this.labelInserirNif.Name = "labelInserirNif";
            this.labelInserirNif.Size = new System.Drawing.Size(24, 13);
            this.labelInserirNif.TabIndex = 3;
            this.labelInserirNif.Text = "NIF";
            // 
            // labelInserirNome
            // 
            this.labelInserirNome.AutoSize = true;
            this.labelInserirNome.Location = new System.Drawing.Point(6, 34);
            this.labelInserirNome.Name = "labelInserirNome";
            this.labelInserirNome.Size = new System.Drawing.Size(35, 13);
            this.labelInserirNome.TabIndex = 2;
            this.labelInserirNome.Text = "Nome";
            // 
            // textBoxClienteNome
            // 
            this.textBoxClienteNome.Location = new System.Drawing.Point(67, 31);
            this.textBoxClienteNome.Name = "textBoxClienteNome";
            this.textBoxClienteNome.Size = new System.Drawing.Size(190, 20);
            this.textBoxClienteNome.TabIndex = 1;
            this.textBoxClienteNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.Location = new System.Drawing.Point(6, 22);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(281, 186);
            this.listBoxClientes.TabIndex = 7;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.listBoxClientes_SelectedIndexChanged);
            // 
            // groupBoxClientes
            // 
            this.groupBoxClientes.Controls.Add(this.listBoxClientes);
            this.groupBoxClientes.Location = new System.Drawing.Point(12, 197);
            this.groupBoxClientes.Name = "groupBoxClientes";
            this.groupBoxClientes.Size = new System.Drawing.Size(304, 220);
            this.groupBoxClientes.TabIndex = 8;
            this.groupBoxClientes.TabStop = false;
            this.groupBoxClientes.Text = "Lista de clientes";
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.Controls.Add(this.groupBoxCompras);
            this.groupBoxCliente.Controls.Add(this.labelTotalClienteValor);
            this.groupBoxCliente.Controls.Add(this.labelTotalCliente);
            this.groupBoxCliente.Controls.Add(this.labelNifCliente);
            this.groupBoxCliente.Controls.Add(this.labelNomeCliente);
            this.groupBoxCliente.Location = new System.Drawing.Point(339, 22);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Size = new System.Drawing.Size(648, 395);
            this.groupBoxCliente.TabIndex = 9;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Text = "Cliente";
            // 
            // groupBoxCompras
            // 
            this.groupBoxCompras.Controls.Add(this.labelLinhasCompra);
            this.groupBoxCompras.Controls.Add(this.labelCompras);
            this.groupBoxCompras.Controls.Add(this.groupBox4);
            this.groupBoxCompras.Controls.Add(this.labelTotalValor);
            this.groupBoxCompras.Controls.Add(this.labelTotal);
            this.groupBoxCompras.Controls.Add(this.buttonApagarLinhaCompra);
            this.groupBoxCompras.Controls.Add(this.buttonApagarCompra);
            this.groupBoxCompras.Controls.Add(this.buttonCriarCompra);
            this.groupBoxCompras.Controls.Add(this.listBoxLinhasCompra);
            this.groupBoxCompras.Controls.Add(this.listBoxCompras);
            this.groupBoxCompras.Location = new System.Drawing.Point(29, 96);
            this.groupBoxCompras.Name = "groupBoxCompras";
            this.groupBoxCompras.Size = new System.Drawing.Size(590, 269);
            this.groupBoxCompras.TabIndex = 10;
            this.groupBoxCompras.TabStop = false;
            this.groupBoxCompras.Text = "Compras";
            // 
            // labelLinhasCompra
            // 
            this.labelLinhasCompra.AutoSize = true;
            this.labelLinhasCompra.Location = new System.Drawing.Point(187, 24);
            this.labelLinhasCompra.Name = "labelLinhasCompra";
            this.labelLinhasCompra.Size = new System.Drawing.Size(91, 13);
            this.labelLinhasCompra.TabIndex = 15;
            this.labelLinhasCompra.Text = "Linhas de compra";
            // 
            // labelCompras
            // 
            this.labelCompras.AutoSize = true;
            this.labelCompras.Location = new System.Drawing.Point(14, 24);
            this.labelCompras.Name = "labelCompras";
            this.labelCompras.Size = new System.Drawing.Size(48, 13);
            this.labelCompras.TabIndex = 11;
            this.labelCompras.Text = "Compras";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelAddLinhaValor);
            this.groupBox4.Controls.Add(this.labelAddLinhaDescricao);
            this.groupBox4.Controls.Add(this.buttonAddLinha);
            this.groupBox4.Controls.Add(this.textBoxAddLinhaValor);
            this.groupBox4.Controls.Add(this.textBoxAddLinhaDescricao);
            this.groupBox4.Location = new System.Drawing.Point(394, 40);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(178, 186);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Adicionar linha compra";
            // 
            // labelAddLinhaValor
            // 
            this.labelAddLinhaValor.AutoSize = true;
            this.labelAddLinhaValor.Location = new System.Drawing.Point(16, 79);
            this.labelAddLinhaValor.Name = "labelAddLinhaValor";
            this.labelAddLinhaValor.Size = new System.Drawing.Size(31, 13);
            this.labelAddLinhaValor.TabIndex = 17;
            this.labelAddLinhaValor.Text = "Valor";
            // 
            // labelAddLinhaDescricao
            // 
            this.labelAddLinhaDescricao.AutoSize = true;
            this.labelAddLinhaDescricao.Location = new System.Drawing.Point(16, 23);
            this.labelAddLinhaDescricao.Name = "labelAddLinhaDescricao";
            this.labelAddLinhaDescricao.Size = new System.Drawing.Size(55, 13);
            this.labelAddLinhaDescricao.TabIndex = 16;
            this.labelAddLinhaDescricao.Text = "Descrição";
            // 
            // buttonAddLinha
            // 
            this.buttonAddLinha.Location = new System.Drawing.Point(19, 136);
            this.buttonAddLinha.Name = "buttonAddLinha";
            this.buttonAddLinha.Size = new System.Drawing.Size(71, 23);
            this.buttonAddLinha.TabIndex = 15;
            this.buttonAddLinha.Text = "Adicionar linha";
            this.buttonAddLinha.UseVisualStyleBackColor = true;
            this.buttonAddLinha.Click += new System.EventHandler(this.buttonAddLinha_Click);
            // 
            // textBoxAddLinhaValor
            // 
            this.textBoxAddLinhaValor.Location = new System.Drawing.Point(19, 95);
            this.textBoxAddLinhaValor.Name = "textBoxAddLinhaValor";
            this.textBoxAddLinhaValor.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddLinhaValor.TabIndex = 7;
            // 
            // textBoxAddLinhaDescricao
            // 
            this.textBoxAddLinhaDescricao.Location = new System.Drawing.Point(19, 39);
            this.textBoxAddLinhaDescricao.Name = "textBoxAddLinhaDescricao";
            this.textBoxAddLinhaDescricao.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddLinhaDescricao.TabIndex = 6;
            // 
            // labelTotalValor
            // 
            this.labelTotalValor.AutoSize = true;
            this.labelTotalValor.Location = new System.Drawing.Point(239, 240);
            this.labelTotalValor.Name = "labelTotalValor";
            this.labelTotalValor.Size = new System.Drawing.Size(13, 13);
            this.labelTotalValor.TabIndex = 13;
            this.labelTotalValor.Text = "0";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(198, 240);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(31, 13);
            this.labelTotal.TabIndex = 12;
            this.labelTotal.Text = "Total";
            // 
            // buttonApagarLinhaCompra
            // 
            this.buttonApagarLinhaCompra.Location = new System.Drawing.Point(278, 235);
            this.buttonApagarLinhaCompra.Name = "buttonApagarLinhaCompra";
            this.buttonApagarLinhaCompra.Size = new System.Drawing.Size(71, 23);
            this.buttonApagarLinhaCompra.TabIndex = 11;
            this.buttonApagarLinhaCompra.Text = "Apagar";
            this.buttonApagarLinhaCompra.UseVisualStyleBackColor = true;
            this.buttonApagarLinhaCompra.Click += new System.EventHandler(this.buttonApagarLinhaCompra_Click);
            // 
            // buttonApagarCompra
            // 
            this.buttonApagarCompra.Location = new System.Drawing.Point(98, 240);
            this.buttonApagarCompra.Name = "buttonApagarCompra";
            this.buttonApagarCompra.Size = new System.Drawing.Size(75, 23);
            this.buttonApagarCompra.TabIndex = 10;
            this.buttonApagarCompra.Text = "Apagar";
            this.buttonApagarCompra.UseVisualStyleBackColor = true;
            this.buttonApagarCompra.Click += new System.EventHandler(this.buttonApagarCompra_Click);
            // 
            // buttonCriarCompra
            // 
            this.buttonCriarCompra.Location = new System.Drawing.Point(17, 240);
            this.buttonCriarCompra.Name = "buttonCriarCompra";
            this.buttonCriarCompra.Size = new System.Drawing.Size(75, 23);
            this.buttonCriarCompra.TabIndex = 6;
            this.buttonCriarCompra.Text = "Criar compra";
            this.buttonCriarCompra.UseVisualStyleBackColor = true;
            this.buttonCriarCompra.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBoxLinhasCompra
            // 
            this.listBoxLinhasCompra.FormattingEnabled = true;
            this.listBoxLinhasCompra.Location = new System.Drawing.Point(190, 40);
            this.listBoxLinhasCompra.Name = "listBoxLinhasCompra";
            this.listBoxLinhasCompra.Size = new System.Drawing.Size(159, 186);
            this.listBoxLinhasCompra.TabIndex = 9;
            // 
            // listBoxCompras
            // 
            this.listBoxCompras.FormattingEnabled = true;
            this.listBoxCompras.Location = new System.Drawing.Point(17, 40);
            this.listBoxCompras.Name = "listBoxCompras";
            this.listBoxCompras.Size = new System.Drawing.Size(156, 186);
            this.listBoxCompras.TabIndex = 8;
            this.listBoxCompras.SelectedIndexChanged += new System.EventHandler(this.listBoxCompras_SelectedIndexChanged);
            // 
            // labelTotalClienteValor
            // 
            this.labelTotalClienteValor.AutoSize = true;
            this.labelTotalClienteValor.Location = new System.Drawing.Point(584, 62);
            this.labelTotalClienteValor.Name = "labelTotalClienteValor";
            this.labelTotalClienteValor.Size = new System.Drawing.Size(13, 13);
            this.labelTotalClienteValor.TabIndex = 9;
            this.labelTotalClienteValor.Text = "0";
            // 
            // labelTotalCliente
            // 
            this.labelTotalCliente.AutoSize = true;
            this.labelTotalCliente.Location = new System.Drawing.Point(566, 21);
            this.labelTotalCliente.Name = "labelTotalCliente";
            this.labelTotalCliente.Size = new System.Drawing.Size(31, 13);
            this.labelTotalCliente.TabIndex = 8;
            this.labelTotalCliente.Text = "Total";
            // 
            // labelNifCliente
            // 
            this.labelNifCliente.AutoSize = true;
            this.labelNifCliente.Location = new System.Drawing.Point(26, 66);
            this.labelNifCliente.Name = "labelNifCliente";
            this.labelNifCliente.Size = new System.Drawing.Size(35, 13);
            this.labelNifCliente.TabIndex = 7;
            this.labelNifCliente.Text = "label4";
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.Location = new System.Drawing.Point(26, 28);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(35, 13);
            this.labelNomeCliente.TabIndex = 6;
            this.labelNomeCliente.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 450);
            this.Controls.Add(this.groupBoxCliente);
            this.Controls.Add(this.groupBoxClientes);
            this.Controls.Add(this.groupBoxInserirCliente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxInserirCliente.ResumeLayout(false);
            this.groupBoxInserirCliente.PerformLayout();
            this.groupBoxClientes.ResumeLayout(false);
            this.groupBoxCliente.ResumeLayout(false);
            this.groupBoxCliente.PerformLayout();
            this.groupBoxCompras.ResumeLayout(false);
            this.groupBoxCompras.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInserirCliente;
        private System.Windows.Forms.TextBox textBoxClienteNome;
        private System.Windows.Forms.Button buttonAddCliente;
        private System.Windows.Forms.TextBox textBoxClienteNif;
        private System.Windows.Forms.Label labelInserirNif;
        private System.Windows.Forms.Label labelInserirNome;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.GroupBox groupBoxClientes;
        private System.Windows.Forms.Button buttonCriarCompra;
        private System.Windows.Forms.GroupBox groupBoxCliente;
        private System.Windows.Forms.GroupBox groupBoxCompras;
        private System.Windows.Forms.ListBox listBoxLinhasCompra;
        private System.Windows.Forms.ListBox listBoxCompras;
        private System.Windows.Forms.Label labelTotalClienteValor;
        private System.Windows.Forms.Label labelTotalCliente;
        private System.Windows.Forms.Label labelNifCliente;
        private System.Windows.Forms.Label labelNomeCliente;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelAddLinhaValor;
        private System.Windows.Forms.Label labelAddLinhaDescricao;
        private System.Windows.Forms.Button buttonAddLinha;
        private System.Windows.Forms.TextBox textBoxAddLinhaValor;
        private System.Windows.Forms.TextBox textBoxAddLinhaDescricao;
        private System.Windows.Forms.Label labelTotalValor;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonApagarLinhaCompra;
        private System.Windows.Forms.Button buttonApagarCompra;
        private System.Windows.Forms.Label labelLinhasCompra;
        private System.Windows.Forms.Label labelCompras;
    }
}

