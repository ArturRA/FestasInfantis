namespace FestasInfantis.WinFormsApp.ModuloTema
{
    partial class DialogAdicionar
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
            lblTema = new Label();
            listItens = new CheckedListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(43, 26);
            label1.Name = "label1";
            label1.Size = new Size(49, 21);
            label1.TabIndex = 0;
            label1.Text = "Tema:";
            // 
            // lblTema
            // 
            lblTema.AutoSize = true;
            lblTema.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTema.Location = new Point(89, 26);
            lblTema.Name = "lblTema";
            lblTema.Size = new Size(45, 21);
            lblTema.TabIndex = 1;
            lblTema.Text = "tema";
            // 
            // listItens
            // 
            listItens.FormattingEnabled = true;
            listItens.Location = new Point(12, 68);
            listItens.Name = "listItens";
            listItens.Size = new Size(252, 184);
            listItens.TabIndex = 2;
            // 
            // DialogAdicionar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 294);
            Controls.Add(listItens);
            Controls.Add(lblTema);
            Controls.Add(label1);
            Name = "DialogAdicionar";
            Text = "DialogAdicionar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTema;
        private CheckedListBox listItens;
    }
}