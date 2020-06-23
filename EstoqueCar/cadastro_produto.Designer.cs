namespace EstoqueCar
{
    partial class cadastro_produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastro_produto));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxPrateleira = new System.Windows.Forms.ComboBox();
            this.textBoxCatg = new System.Windows.Forms.TextBox();
            this.botaoCadastrarProduto = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.textBoxItem = new System.Windows.Forms.TextBox();
            this.textBoxCod = new System.Windows.Forms.TextBox();
            this.textBoxProduto = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(406, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(359, 37);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cadastro do Produto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxPrateleira);
            this.groupBox1.Controls.Add(this.textBoxCatg);
            this.groupBox1.Controls.Add(this.botaoCadastrarProduto);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.textBoxModelo);
            this.groupBox1.Controls.Add(this.textBoxMarca);
            this.groupBox1.Controls.Add(this.textBoxItem);
            this.groupBox1.Controls.Add(this.textBoxCod);
            this.groupBox1.Controls.Add(this.textBoxProduto);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 320);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Produto";
            // 
            // comboBoxPrateleira
            // 
            this.comboBoxPrateleira.FormattingEnabled = true;
            this.comboBoxPrateleira.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBoxPrateleira.Location = new System.Drawing.Point(284, 179);
            this.comboBoxPrateleira.Name = "comboBoxPrateleira";
            this.comboBoxPrateleira.Size = new System.Drawing.Size(177, 27);
            this.comboBoxPrateleira.TabIndex = 9;
            this.comboBoxPrateleira.Text = "Selecione prateleira";
            this.comboBoxPrateleira.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrateleira_SelectedIndexChanged);
            // 
            // textBoxCatg
            // 
            this.textBoxCatg.Location = new System.Drawing.Point(15, 180);
            this.textBoxCatg.Name = "textBoxCatg";
            this.textBoxCatg.Size = new System.Drawing.Size(221, 26);
            this.textBoxCatg.TabIndex = 8;
            this.textBoxCatg.Text = "Categoria";
            this.textBoxCatg.Enter += new System.EventHandler(this.textBoxCatg_Enter);
            this.textBoxCatg.Leave += new System.EventHandler(this.textBoxCatg_Leave);
            // 
            // botaoCadastrarProduto
            // 
            this.botaoCadastrarProduto.BackColor = System.Drawing.SystemColors.Highlight;
            this.botaoCadastrarProduto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botaoCadastrarProduto.Location = new System.Drawing.Point(301, 237);
            this.botaoCadastrarProduto.Name = "botaoCadastrarProduto";
            this.botaoCadastrarProduto.Size = new System.Drawing.Size(129, 62);
            this.botaoCadastrarProduto.TabIndex = 7;
            this.botaoCadastrarProduto.Text = "Cadastrar";
            this.botaoCadastrarProduto.UseVisualStyleBackColor = false;
            this.botaoCadastrarProduto.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(495, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(261, 221);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(15, 88);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(221, 26);
            this.textBoxModelo.TabIndex = 5;
            this.textBoxModelo.Text = "Modelo";
            this.textBoxModelo.Enter += new System.EventHandler(this.textBoxModelo_Enter);
            this.textBoxModelo.Leave += new System.EventHandler(this.textBoxModelo_Leave);
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(15, 135);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(221, 26);
            this.textBoxMarca.TabIndex = 4;
            this.textBoxMarca.Text = "Marca";
            this.textBoxMarca.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.textBoxMarca.Enter += new System.EventHandler(this.textBoxMarca_Enter);
            this.textBoxMarca.Leave += new System.EventHandler(this.textBoxMarca_Leave);
            // 
            // textBoxItem
            // 
            this.textBoxItem.Location = new System.Drawing.Point(15, 230);
            this.textBoxItem.Name = "textBoxItem";
            this.textBoxItem.Size = new System.Drawing.Size(221, 26);
            this.textBoxItem.TabIndex = 2;
            this.textBoxItem.Text = "N° Item";
            this.textBoxItem.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBoxItem.Enter += new System.EventHandler(this.textBoxItem_Enter);
            this.textBoxItem.Leave += new System.EventHandler(this.textBoxItem_Leave);
            // 
            // textBoxCod
            // 
            this.textBoxCod.Location = new System.Drawing.Point(15, 273);
            this.textBoxCod.Name = "textBoxCod";
            this.textBoxCod.Size = new System.Drawing.Size(221, 26);
            this.textBoxCod.TabIndex = 1;
            this.textBoxCod.Text = "Código Item";
            this.textBoxCod.Enter += new System.EventHandler(this.textBoxCod_Enter);
            this.textBoxCod.Leave += new System.EventHandler(this.textBoxCod_Leave);
            // 
            // textBoxProduto
            // 
            this.textBoxProduto.Location = new System.Drawing.Point(15, 42);
            this.textBoxProduto.Name = "textBoxProduto";
            this.textBoxProduto.Size = new System.Drawing.Size(365, 26);
            this.textBoxProduto.TabIndex = 0;
            this.textBoxProduto.Text = "Nome do Produto";
            this.textBoxProduto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBoxProduto.Enter += new System.EventHandler(this.textBoxProduto_Enter);
            this.textBoxProduto.Leave += new System.EventHandler(this.textBoxProduto_Leave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(550, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(162, 78);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(809, 110);
            this.panel2.TabIndex = 25;
            // 
            // cadastro_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cadastro_produto";
            this.Text = "Cadastrar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.TextBox textBoxItem;
        private System.Windows.Forms.TextBox textBoxCod;
        private System.Windows.Forms.TextBox textBoxProduto;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button botaoCadastrarProduto;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox textBoxCatg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxPrateleira;
    }
}