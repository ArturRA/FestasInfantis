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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 12);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(65, 12);
            labelId.Name = "labelId";
            labelId.Size = new Size(17, 20);
            labelId.TabIndex = 1;
            labelId.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 49);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 2;
            label3.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(65, 45);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(261, 27);
            txtNome.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 98);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 4;
            label4.Text = "Telefone:";
            // 
            // txtTel
            // 
            txtTel.Location = new Point(84, 95);
            txtTel.Margin = new Padding(3, 4, 3, 4);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(242, 27);
            txtTel.TabIndex = 5;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(148, 197);
            btnGravar.Margin = new Padding(3, 4, 3, 4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(86, 55);
            btnGravar.TabIndex = 6;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(240, 197);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 55);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(67, 140);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(259, 27);
            txtEmail.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 143);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 9;
            label2.Text = "E-mail:";
            // 
            // DialogItemCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 265);
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
            Margin = new Padding(3, 4, 3, 4);
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
    }
}