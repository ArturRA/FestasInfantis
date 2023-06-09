namespace FestasInfantis.WinFormsApp
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1=new MenuStrip();
            cadastrosMenuItem=new ToolStripMenuItem();
            alugueisMenuItem=new ToolStripMenuItem();
            clientesMenuItem=new ToolStripMenuItem();
            temasMenuItem=new ToolStripMenuItem();
            ItensTemaMenuItem=new ToolStripMenuItem();
            statusStrip1=new StatusStrip();
            statusLabelTelaPrincipal=new ToolStripStatusLabel();
            toolStrip1=new ToolStrip();
            btnInserir=new ToolStripButton();
            btnEditar=new ToolStripButton();
            btnExcluir=new ToolStripButton();
            toolStripSeparator2=new ToolStripSeparator();
            btnAdicionarItens=new ToolStripButton();
            toolStripSeparator3=new ToolStripSeparator();
            labelTipoCadastro=new ToolStripLabel();
            panelRegistros=new Panel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosMenuItem });
            menuStrip1.Location=new Point(0, 0);
            menuStrip1.Name="menuStrip1";
            menuStrip1.Size=new Size(1098, 24);
            menuStrip1.TabIndex=0;
            menuStrip1.Text="menuStrip1";
            // 
            // cadastrosMenuItem
            // 
            cadastrosMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alugueisMenuItem, clientesMenuItem, ItensTemaMenuItem, temasMenuItem });
            cadastrosMenuItem.Name="cadastrosMenuItem";
            cadastrosMenuItem.Size=new Size(71, 20);
            cadastrosMenuItem.Text="Cadastros";
            // 
            // alugueisMenuItem
            // 
            alugueisMenuItem.Name="alugueisMenuItem";
            alugueisMenuItem.Size=new Size(180, 22);
            alugueisMenuItem.Text="Alugueis";
            alugueisMenuItem.Click+=alugueisMenuItem_Click;
            // 
            // clientesMenuItem
            // 
            clientesMenuItem.Name="clientesMenuItem";
            clientesMenuItem.Size=new Size(180, 22);
            clientesMenuItem.Text="Clientes";
            clientesMenuItem.Click+=clientesMenuItem_Click;
            // 
            // temasMenuItem
            // 
            temasMenuItem.Name="temasMenuItem";
            temasMenuItem.Size=new Size(180, 22);
            temasMenuItem.Text="Tema";
            temasMenuItem.Click+=temasMenuItem_Click;
            // 
            // ItensTemaMenuItem
            // 
            ItensTemaMenuItem.Name="ItensTemaMenuItem";
            ItensTemaMenuItem.Size=new Size(180, 22);
            ItensTemaMenuItem.Text="Itens Tema";
            ItensTemaMenuItem.Click+=itensTemaMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabelTelaPrincipal });
            statusStrip1.Location=new Point(0, 539);
            statusStrip1.Name="statusStrip1";
            statusStrip1.Size=new Size(1098, 22);
            statusStrip1.TabIndex=1;
            statusStrip1.Text="statusStrip1";
            // 
            // statusLabelTelaPrincipal
            // 
            statusLabelTelaPrincipal.Name="statusLabelTelaPrincipal";
            statusLabelTelaPrincipal.Size=new Size(0, 17);
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnInserir, btnEditar, btnExcluir, toolStripSeparator2, btnAdicionarItens, toolStripSeparator3, labelTipoCadastro });
            toolStrip1.Location=new Point(0, 24);
            toolStrip1.Name="toolStrip1";
            toolStrip1.Size=new Size(1098, 45);
            toolStrip1.TabIndex=2;
            toolStrip1.Text="toolStrip1";
            // 
            // btnInserir
            // 
            btnInserir.DisplayStyle=ToolStripItemDisplayStyle.Image;
            btnInserir.Enabled=false;
            btnInserir.Image=Properties.Resources.add_circle_FILL0_wght400_GRAD0_opsz24;
            btnInserir.ImageScaling=ToolStripItemImageScaling.None;
            btnInserir.ImageTransparentColor=Color.Magenta;
            btnInserir.Name="btnInserir";
            btnInserir.Padding=new Padding(7);
            btnInserir.Size=new Size(42, 42);
            btnInserir.Click+=btnInserir_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle=ToolStripItemDisplayStyle.Image;
            btnEditar.Enabled=false;
            btnEditar.Image=Properties.Resources.edit_FILL0_wght400_GRAD0_opsz24;
            btnEditar.ImageScaling=ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor=Color.Magenta;
            btnEditar.Name="btnEditar";
            btnEditar.Padding=new Padding(7);
            btnEditar.Size=new Size(42, 42);
            btnEditar.Click+=btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle=ToolStripItemDisplayStyle.Image;
            btnExcluir.Enabled=false;
            btnExcluir.Image=Properties.Resources.delete_FILL0_wght400_GRAD0_opsz24;
            btnExcluir.ImageScaling=ToolStripItemImageScaling.None;
            btnExcluir.ImageTransparentColor=Color.Magenta;
            btnExcluir.Name="btnExcluir";
            btnExcluir.Padding=new Padding(7);
            btnExcluir.Size=new Size(42, 42);
            btnExcluir.Click+=btnExcluir_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name="toolStripSeparator2";
            toolStripSeparator2.Size=new Size(6, 45);
            // 
            // btnAdicionarItens
            // 
            btnAdicionarItens.DisplayStyle=ToolStripItemDisplayStyle.Image;
            btnAdicionarItens.Enabled=false;
            btnAdicionarItens.Image=Properties.Resources.library_add_FILL0_wght400_GRAD0_opsz24;
            btnAdicionarItens.ImageScaling=ToolStripItemImageScaling.None;
            btnAdicionarItens.ImageTransparentColor=Color.Magenta;
            btnAdicionarItens.Name="btnAdicionarItens";
            btnAdicionarItens.Padding=new Padding(7);
            btnAdicionarItens.Size=new Size(42, 42);
            btnAdicionarItens.Click+=btnAdicionarItens_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name="toolStripSeparator3";
            toolStripSeparator3.Size=new Size(6, 45);
            // 
            // labelTipoCadastro
            // 
            labelTipoCadastro.Name="labelTipoCadastro";
            labelTipoCadastro.Size=new Size(75, 42);
            labelTipoCadastro.Text="tipoCadastro";
            // 
            // panelRegistros
            // 
            panelRegistros.BorderStyle=BorderStyle.FixedSingle;
            panelRegistros.Dock=DockStyle.Fill;
            panelRegistros.Location=new Point(0, 69);
            panelRegistros.Name="panelRegistros";
            panelRegistros.Size=new Size(1098, 470);
            panelRegistros.TabIndex=3;
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1098, 561);
            Controls.Add(panelRegistros);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip=menuStrip1;
            Name="TelaPrincipalForm";
            ShowIcon=false;
            StartPosition=FormStartPosition.CenterScreen;
            Text="e-Agenda 1.0";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosMenuItem;
        private ToolStripMenuItem clientesMenuItem;
        private ToolStripMenuItem alugueisMenuItem;
        private ToolStripMenuItem temasMenuItem;
        private ToolStripMenuItem ItensTemaMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabelTelaPrincipal;
        private ToolStrip toolStrip1;
        private ToolStripButton btnInserir;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private Panel panelRegistros;
        private ToolStripLabel labelTipoCadastro;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnAdicionarItens;
    }
}