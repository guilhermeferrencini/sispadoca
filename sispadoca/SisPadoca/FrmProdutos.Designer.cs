namespace SisPadoca
{
    partial class FrmProdutos
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
            components = new System.ComponentModel.Container();
            LblNCM = new Label();
            PbxImagem = new PictureBox();
            TxtNCM = new TextBox();
            LblDescricao = new Label();
            TxtDescricao = new TextBox();
            LblCodigoBarras = new Label();
            TxtCodigo = new TextBox();
            LblUnidade = new Label();
            CmbUnidade = new ComboBox();
            LblLote = new Label();
            TxtLote = new TextBox();
            BtnNovo = new Button();
            BtnEditar = new Button();
            BtnExcluir = new Button();
            BtnLimpar = new Button();
            BtnFechar = new Button();
            ImgLista = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)PbxImagem).BeginInit();
            SuspendLayout();
            // 
            // LblNCM
            // 
            LblNCM.AutoSize = true;
            LblNCM.Location = new Point(289, 31);
            LblNCM.Name = "LblNCM";
            LblNCM.Size = new Size(52, 25);
            LblNCM.TabIndex = 0;
            LblNCM.Text = "NCM";
            LblNCM.Click += label1_Click;
            // 
            // PbxImagem
            // 
            PbxImagem.Image = Properties.Resources.minhaImagem;
            PbxImagem.Location = new Point(33, 31);
            PbxImagem.Name = "PbxImagem";
            PbxImagem.Size = new Size(186, 242);
            PbxImagem.TabIndex = 1;
            PbxImagem.TabStop = false;
            // 
            // TxtNCM
            // 
            TxtNCM.Location = new Point(289, 59);
            TxtNCM.Name = "TxtNCM";
            TxtNCM.Size = new Size(150, 31);
            TxtNCM.TabIndex = 2;
            // 
            // LblDescricao
            // 
            LblDescricao.AutoSize = true;
            LblDescricao.Location = new Point(289, 119);
            LblDescricao.Name = "LblDescricao";
            LblDescricao.Size = new Size(88, 25);
            LblDescricao.TabIndex = 3;
            LblDescricao.Text = "Descrição";
            // 
            // TxtDescricao
            // 
            TxtDescricao.Location = new Point(289, 147);
            TxtDescricao.Name = "TxtDescricao";
            TxtDescricao.Size = new Size(150, 31);
            TxtDescricao.TabIndex = 4;
            // 
            // LblCodigoBarras
            // 
            LblCodigoBarras.AutoSize = true;
            LblCodigoBarras.Location = new Point(289, 198);
            LblCodigoBarras.Name = "LblCodigoBarras";
            LblCodigoBarras.Size = new Size(149, 25);
            LblCodigoBarras.TabIndex = 5;
            LblCodigoBarras.Text = "Código de Barras";
            // 
            // TxtCodigo
            // 
            TxtCodigo.Location = new Point(289, 226);
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(150, 31);
            TxtCodigo.TabIndex = 6;
            // 
            // LblUnidade
            // 
            LblUnidade.AutoSize = true;
            LblUnidade.Location = new Point(525, 119);
            LblUnidade.Name = "LblUnidade";
            LblUnidade.Size = new Size(143, 25);
            LblUnidade.TabIndex = 7;
            LblUnidade.Text = "Unidade medida";
            // 
            // CmbUnidade
            // 
            CmbUnidade.FormattingEnabled = true;
            CmbUnidade.Items.AddRange(new object[] { "Unitário", "Kilo", "Dúzia" });
            CmbUnidade.Location = new Point(525, 147);
            CmbUnidade.Name = "CmbUnidade";
            CmbUnidade.Size = new Size(133, 33);
            CmbUnidade.TabIndex = 8;
            // 
            // LblLote
            // 
            LblLote.AutoSize = true;
            LblLote.Location = new Point(525, 198);
            LblLote.Name = "LblLote";
            LblLote.Size = new Size(46, 25);
            LblLote.TabIndex = 9;
            LblLote.Text = "Lote";
            // 
            // TxtLote
            // 
            TxtLote.Location = new Point(525, 226);
            TxtLote.Name = "TxtLote";
            TxtLote.Size = new Size(150, 31);
            TxtLote.TabIndex = 10;
            // 
            // BtnNovo
            // 
            BtnNovo.Location = new Point(33, 300);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(130, 56);
            BtnNovo.TabIndex = 11;
            BtnNovo.Text = "Novo";
            BtnNovo.UseVisualStyleBackColor = true;
            // 
            // BtnEditar
            // 
            BtnEditar.Location = new Point(169, 300);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(130, 56);
            BtnEditar.TabIndex = 12;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            BtnExcluir.Location = new Point(305, 300);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(130, 56);
            BtnExcluir.TabIndex = 13;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Location = new Point(441, 300);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(130, 56);
            BtnLimpar.TabIndex = 14;
            BtnLimpar.Text = "Limpar";
            BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(577, 300);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(130, 56);
            BtnFechar.TabIndex = 15;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            // 
            // ImgLista
            // 
            ImgLista.ColorDepth = ColorDepth.Depth32Bit;
            ImgLista.ImageSize = new Size(16, 16);
            ImgLista.TransparentColor = Color.Transparent;
            // 
            // FrmProdutos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 625);
            Controls.Add(BtnFechar);
            Controls.Add(BtnLimpar);
            Controls.Add(BtnExcluir);
            Controls.Add(BtnEditar);
            Controls.Add(BtnNovo);
            Controls.Add(TxtLote);
            Controls.Add(LblLote);
            Controls.Add(CmbUnidade);
            Controls.Add(LblUnidade);
            Controls.Add(TxtCodigo);
            Controls.Add(LblCodigoBarras);
            Controls.Add(TxtDescricao);
            Controls.Add(LblDescricao);
            Controls.Add(TxtNCM);
            Controls.Add(PbxImagem);
            Controls.Add(LblNCM);
            Name = "FrmProdutos";
            Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)PbxImagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblNCM;
        private PictureBox PbxImagem;
        private TextBox TxtNCM;
        private Label LblDescricao;
        private TextBox TxtDescricao;
        private Label LblCodigoBarras;
        private TextBox TxtCodigo;
        private Label LblUnidade;
        private ComboBox CmbUnidade;
        private Label LblLote;
        private TextBox TxtLote;
        private Button BtnNovo;
        private Button BtnEditar;
        private Button BtnExcluir;
        private Button BtnLimpar;
        private Button BtnFechar;
        private ImageList ImgLista;
    }
}