namespace FestasInfantis.WinFormsApp.ModuloItemTema
{
    partial class DialogItemTema
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
            label1=new Label();
            labelId=new Label();
            label3=new Label();
            txtNome=new TextBox();
            label4=new Label();
            txtValor=new TextBox();
            btnGravar=new Button();
            btnCancelar=new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(31, 9);
            label1.Name="label1";
            label1.Size=new Size(20, 15);
            label1.TabIndex=0;
            label1.Text="Id:";
            // 
            // labelId
            // 
            labelId.AutoSize=true;
            labelId.Location=new Point(57, 9);
            labelId.Name="labelId";
            labelId.Size=new Size(13, 15);
            labelId.TabIndex=1;
            labelId.Text="0";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(8, 37);
            label3.Name="label3";
            label3.Size=new Size(43, 15);
            label3.TabIndex=2;
            label3.Text="Nome:";
            // 
            // txtNome
            // 
            txtNome.Location=new Point(57, 34);
            txtNome.Name="txtNome";
            txtNome.Size=new Size(229, 23);
            txtNome.TabIndex=3;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(18, 71);
            label4.Name="label4";
            label4.Size=new Size(33, 15);
            label4.TabIndex=4;
            label4.Text="Valor";
            // 
            // txtValor
            // 
            txtValor.Location=new Point(57, 68);
            txtValor.Name="txtValor";
            txtValor.Size=new Size(229, 23);
            txtValor.TabIndex=5;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult=DialogResult.OK;
            btnGravar.Location=new Point(130, 97);
            btnGravar.Name="btnGravar";
            btnGravar.Size=new Size(75, 41);
            btnGravar.TabIndex=6;
            btnGravar.Text="Gravar";
            btnGravar.UseVisualStyleBackColor=true;
            btnGravar.Click+=btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult=DialogResult.Cancel;
            btnCancelar.Location=new Point(211, 97);
            btnCancelar.Name="btnCancelar";
            btnCancelar.Size=new Size(75, 41);
            btnCancelar.TabIndex=7;
            btnCancelar.Text="Cancelar";
            btnCancelar.UseVisualStyleBackColor=true;
            // 
            // DialogItemTema
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(313, 167);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtValor);
            Controls.Add(label4);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(labelId);
            Controls.Add(label1);
            Name="DialogItemTema";
            Text="DialogItemTema";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelId;
        private Label label3;
        private TextBox txtNome;
        private Label label4;
        private TextBox txtValor;
        private Button btnGravar;
        private Button btnCancelar;
    }
}