namespace FestasInfantis.WinFormsApp.ModuloTema
{
    partial class DialogTema
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
            txtNome = new TextBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            labelId = new Label();
            label2 = new Label();
            txtPctgmEntrada = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 57);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(141, 57);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(323, 31);
            txtNome.TabIndex = 1;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(276, 157);
            btnGravar.Margin = new Padding(4, 5, 4, 5);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(107, 68);
            btnGravar.TabIndex = 7;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(391, 157);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(107, 68);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(141, 21);
            labelId.Margin = new Padding(4, 0, 4, 0);
            labelId.Name = "labelId";
            labelId.Size = new Size(22, 25);
            labelId.TabIndex = 10;
            labelId.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 21);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(32, 25);
            label2.TabIndex = 9;
            label2.Text = "Id:";
            // 
            // txtPctgmEntrada
            // 
            txtPctgmEntrada.Location = new Point(141, 107);
            txtPctgmEntrada.Name = "txtPctgmEntrada";
            txtPctgmEntrada.Size = new Size(323, 31);
            txtPctgmEntrada.TabIndex = 12;
            // 
            // label3
            // 
            label3.Location = new Point(19, 77);
            label3.Name = "label3";
            label3.Size = new Size(116, 90);
            label3.TabIndex = 11;
            label3.Text = "Porcentagem Entrada:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // DialogTema
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 245);
            Controls.Add(txtPctgmEntrada);
            Controls.Add(label3);
            Controls.Add(labelId);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "DialogTema";
            Text = "Inserir Tema";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Button btnGravar;
        private Button btnCancelar;
        private Label labelId;
        private Label label2;
        private TextBox txtPctgmEntrada;
        private Label label3;
    }
}