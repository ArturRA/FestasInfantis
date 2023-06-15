namespace FestasInfantis.WinFormsApp.ModuloItemTema
{
    partial class DialogItemCliente
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
            label1 = new Label();
            labelId = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            label4 = new Label();
            txtTel = new TextBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            txtEmail = new TextBox();
            label2 = new Label();
            cbAntigo = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 9);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(87, 9);
            labelId.Name = "labelId";
            labelId.Size = new Size(13, 15);
            labelId.TabIndex = 1;
            labelId.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 37);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(87, 34);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(227, 23);
            txtNome.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 74);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 4;
            label4.Text = "Telefone:";
            // 
            // txtTel
            // 
            txtTel.Location = new Point(87, 71);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(227, 23);
            txtTel.TabIndex = 5;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(181, 171);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 41);
            btnGravar.TabIndex = 6;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(262, 171);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(87, 105);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(227, 23);
            txtEmail.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 107);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 9;
            label2.Text = "E-mail:";
            // 
            // cbAntigo
            // 
            cbAntigo.AutoSize = true;
            cbAntigo.Location = new Point(87, 144);
            cbAntigo.Name = "cbAntigo";
            cbAntigo.Size = new Size(69, 19);
            cbAntigo.TabIndex = 10;
            cbAntigo.Text = "É antigo";
            cbAntigo.UseVisualStyleBackColor = true;
            // 
            // DialogItemCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 224);
            Controls.Add(cbAntigo);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtTel);
            Controls.Add(label4);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(labelId);
            Controls.Add(label1);
            Name = "DialogItemCliente";
            Text = "DialogItemTema";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelId;
        private Label label3;
        private TextBox txtNome;
        private Label label4;
        private TextBox txtTel;
        private Button btnGravar;
        private Button btnCancelar;
        private TextBox txtEmail;
        private Label label2;
        private CheckBox cbAntigo;
    }
}