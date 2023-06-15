namespace FestasInfantis.WinFormsApp.ModuloAluguel
{
    partial class DialogAluguel
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
            btnCancelar = new Button();
            btnGravar = new Button();
            cmbTema = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelId = new Label();
            txtLocal = new TextBox();
            dtpDataInicio = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            cmbCliente = new ComboBox();
            label6 = new Label();
            dtpDataFim = new DateTimePicker();
            label7 = new Label();
            dtpPagamento = new DateTimePicker();
            label8 = new Label();
            txtNome = new TextBox();
            txtDesconto = new TextBox();
            label9 = new Label();
            label10 = new Label();
            txtValor = new TextBox();
            btnValor = new Button();
            txtEntrada = new TextBox();
            label11 = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(368, 374);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(287, 374);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 41);
            btnGravar.TabIndex = 9;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // cmbTema
            // 
            cmbTema.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTema.FormattingEnabled = true;
            cmbTema.Location = new Point(119, 91);
            cmbTema.Name = "cmbTema";
            cmbTema.Size = new Size(266, 23);
            cmbTema.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 94);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 12;
            label1.Text = "Tema:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 129);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 13;
            label2.Text = "Local:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 31);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 14;
            label3.Text = "Id:";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(119, 31);
            labelId.Name = "labelId";
            labelId.Size = new Size(13, 15);
            labelId.TabIndex = 15;
            labelId.Text = "0";
            // 
            // txtLocal
            // 
            txtLocal.Location = new Point(119, 126);
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new Size(266, 23);
            txtLocal.TabIndex = 16;
            // 
            // dtpDataInicio
            // 
            dtpDataInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpDataInicio.Format = DateTimePickerFormat.Custom;
            dtpDataInicio.Location = new Point(119, 160);
            dtpDataInicio.Name = "dtpDataInicio";
            dtpDataInicio.Size = new Size(266, 23);
            dtpDataInicio.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 164);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 18;
            label4.Text = "Data Início:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 232);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 20;
            label5.Text = "Cliente:";
            // 
            // cmbCliente
            // 
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(119, 229);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(266, 23);
            cmbCliente.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 199);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 22;
            label6.Text = "Data Fim:";
            // 
            // dtpDataFim
            // 
            dtpDataFim.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpDataFim.Format = DateTimePickerFormat.Custom;
            dtpDataFim.Location = new Point(119, 195);
            dtpDataFim.Name = "dtpDataFim";
            dtpDataFim.Size = new Size(266, 23);
            dtpDataFim.TabIndex = 21;
            // 
            // label7
            // 
            label7.Location = new Point(-4, 288);
            label7.Name = "label7";
            label7.Size = new Size(117, 38);
            label7.TabIndex = 24;
            label7.Text = "Data Pagamento Valor Restante:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dtpPagamento
            // 
            dtpPagamento.Format = DateTimePickerFormat.Short;
            dtpPagamento.Location = new Point(119, 298);
            dtpPagamento.Name = "dtpPagamento";
            dtpPagamento.Size = new Size(266, 23);
            dtpPagamento.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(75, 59);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 25;
            label8.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(119, 56);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(266, 23);
            txtNome.TabIndex = 26;
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(119, 264);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(266, 23);
            txtDesconto.TabIndex = 28;
            txtDesconto.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(53, 267);
            label9.Name = "label9";
            label9.Size = new Size(60, 15);
            label9.TabIndex = 27;
            label9.Text = "Desconto:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(105, 358);
            label10.Name = "label10";
            label10.Size = new Size(36, 15);
            label10.TabIndex = 29;
            label10.Text = "Valor:";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(147, 355);
            txtValor.Name = "txtValor";
            txtValor.ReadOnly = true;
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 30;
            // 
            // btnValor
            // 
            btnValor.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnValor.Location = new Point(12, 358);
            btnValor.Name = "btnValor";
            btnValor.Size = new Size(75, 41);
            btnValor.TabIndex = 31;
            btnValor.Text = "Checar Valor";
            btnValor.UseVisualStyleBackColor = true;
            btnValor.Click += btnValor_Click;
            // 
            // txtEntrada
            // 
            txtEntrada.Location = new Point(147, 392);
            txtEntrada.Name = "txtEntrada";
            txtEntrada.ReadOnly = true;
            txtEntrada.Size = new Size(100, 23);
            txtEntrada.TabIndex = 33;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(94, 395);
            label11.Name = "label11";
            label11.Size = new Size(50, 15);
            label11.TabIndex = 32;
            label11.Text = "Entrada:";
            // 
            // DialogAluguel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 427);
            Controls.Add(txtEntrada);
            Controls.Add(label11);
            Controls.Add(btnValor);
            Controls.Add(txtValor);
            Controls.Add(label10);
            Controls.Add(txtDesconto);
            Controls.Add(label9);
            Controls.Add(txtNome);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dtpPagamento);
            Controls.Add(label6);
            Controls.Add(dtpDataFim);
            Controls.Add(label5);
            Controls.Add(cmbCliente);
            Controls.Add(label4);
            Controls.Add(dtpDataInicio);
            Controls.Add(txtLocal);
            Controls.Add(labelId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbTema);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Name = "DialogAluguel";
            Text = "DialogAluguel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGravar;
        private ComboBox cmbTema;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelId;
        private TextBox txtLocal;
        private DateTimePicker dtpDataInicio;
        private Label label4;
        private Label label5;
        private ComboBox cmbCliente;
        private Label label6;
        private DateTimePicker dtpDataFim;
        private Label label7;
        private DateTimePicker dtpPagamento;
        private Label label8;
        private TextBox txtNome;
        private TextBox txtDesconto;
        private Label label9;
        private Label label10;
        private TextBox txtValor;
        private Button btnValor;
        private TextBox txtEntrada;
        private Label label11;
    }
}