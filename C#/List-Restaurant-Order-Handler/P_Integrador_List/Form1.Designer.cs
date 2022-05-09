namespace P_Integrador_List
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.cBoxTipo = new System.Windows.Forms.ComboBox();
            this.listComida = new System.Windows.Forms.ListBox();
            this.listBebida = new System.Windows.Forms.ListBox();
            this.lblComida = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblQtdComida = new System.Windows.Forms.Label();
            this.lblQtdBebida = new System.Windows.Forms.Label();
            this.btnApagaComida = new System.Windows.Forms.Button();
            this.btnApagaBebida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anote o pedido...";
            // 
            // txtPedido
            // 
            this.txtPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedido.Location = new System.Drawing.Point(15, 29);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(200, 23);
            this.txtPedido.TabIndex = 1;
            this.txtPedido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPedido_KeyPress);
            // 
            // cBoxTipo
            // 
            this.cBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxTipo.FormattingEnabled = true;
            this.cBoxTipo.Items.AddRange(new object[] {
            "Comida",
            "Bebida"});
            this.cBoxTipo.Location = new System.Drawing.Point(221, 29);
            this.cBoxTipo.Name = "cBoxTipo";
            this.cBoxTipo.Size = new System.Drawing.Size(200, 24);
            this.cBoxTipo.TabIndex = 2;
            this.cBoxTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cBoxTipo_KeyPress);
            // 
            // listComida
            // 
            this.listComida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listComida.FormattingEnabled = true;
            this.listComida.ItemHeight = 16;
            this.listComida.Location = new System.Drawing.Point(15, 77);
            this.listComida.Name = "listComida";
            this.listComida.Size = new System.Drawing.Size(200, 100);
            this.listComida.TabIndex = 3;
            this.listComida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listComida_KeyPress);
            // 
            // listBebida
            // 
            this.listBebida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBebida.FormattingEnabled = true;
            this.listBebida.ItemHeight = 16;
            this.listBebida.Location = new System.Drawing.Point(221, 77);
            this.listBebida.Name = "listBebida";
            this.listBebida.Size = new System.Drawing.Size(200, 100);
            this.listBebida.TabIndex = 4;
            this.listBebida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBebida_KeyPress);
            // 
            // lblComida
            // 
            this.lblComida.AutoSize = true;
            this.lblComida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComida.Location = new System.Drawing.Point(13, 57);
            this.lblComida.Name = "lblComida";
            this.lblComida.Size = new System.Drawing.Size(55, 17);
            this.lblComida.TabIndex = 5;
            this.lblComida.Text = "Comida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bebida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(404, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "☻ Para adicionar um pedido, basta apenas pressionar a tecla Enter!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 252);
            this.label4.MaximumSize = new System.Drawing.Size(404, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(357, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "☻ Para apagar um pedido, basta apenas pressionar a tecla Backspace após seleciona" +
    "r o pedido!";
            // 
            // lblQtdComida
            // 
            this.lblQtdComida.AutoSize = true;
            this.lblQtdComida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdComida.Location = new System.Drawing.Point(13, 180);
            this.lblQtdComida.Name = "lblQtdComida";
            this.lblQtdComida.Size = new System.Drawing.Size(91, 17);
            this.lblQtdComida.TabIndex = 9;
            this.lblQtdComida.Text = "Comandas: 0";
            // 
            // lblQtdBebida
            // 
            this.lblQtdBebida.AutoSize = true;
            this.lblQtdBebida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdBebida.Location = new System.Drawing.Point(218, 180);
            this.lblQtdBebida.Name = "lblQtdBebida";
            this.lblQtdBebida.Size = new System.Drawing.Size(91, 17);
            this.lblQtdBebida.TabIndex = 10;
            this.lblQtdBebida.Text = "Comandas: 0";
            // 
            // btnApagaComida
            // 
            this.btnApagaComida.Location = new System.Drawing.Point(16, 201);
            this.btnApagaComida.Name = "btnApagaComida";
            this.btnApagaComida.Size = new System.Drawing.Size(199, 23);
            this.btnApagaComida.TabIndex = 11;
            this.btnApagaComida.Text = "Apagar todas as comidas";
            this.btnApagaComida.UseVisualStyleBackColor = true;
            this.btnApagaComida.Click += new System.EventHandler(this.btnApagaComida_Click);
            // 
            // btnApagaBebida
            // 
            this.btnApagaBebida.Location = new System.Drawing.Point(221, 201);
            this.btnApagaBebida.Name = "btnApagaBebida";
            this.btnApagaBebida.Size = new System.Drawing.Size(200, 23);
            this.btnApagaBebida.TabIndex = 12;
            this.btnApagaBebida.Text = "Apagar todas as bebidas";
            this.btnApagaBebida.UseVisualStyleBackColor = true;
            this.btnApagaBebida.Click += new System.EventHandler(this.btnApagaBebida_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(439, 293);
            this.Controls.Add(this.btnApagaBebida);
            this.Controls.Add(this.btnApagaComida);
            this.Controls.Add(this.lblQtdBebida);
            this.Controls.Add(this.lblQtdComida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblComida);
            this.Controls.Add(this.listBebida);
            this.Controls.Add(this.listComida);
            this.Controls.Add(this.cBoxTipo);
            this.Controls.Add(this.txtPedido);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de comandas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.ComboBox cBoxTipo;
        private System.Windows.Forms.ListBox listComida;
        private System.Windows.Forms.ListBox listBebida;
        private System.Windows.Forms.Label lblComida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblQtdComida;
        private System.Windows.Forms.Label lblQtdBebida;
        private System.Windows.Forms.Button btnApagaComida;
        private System.Windows.Forms.Button btnApagaBebida;
    }
}

