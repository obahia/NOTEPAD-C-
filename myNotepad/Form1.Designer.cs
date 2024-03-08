namespace myNotepad
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.MenuFicheiro = new System.Windows.Forms.ToolStripSplitButton();
            this.MenuFicheiroNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFicheiroAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFicheiroGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFicheiroSair = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditar = new System.Windows.Forms.ToolStripSplitButton();
            this.MenuEditarCortar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditarCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditarColar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditarSelecionar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditarProcurar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.MenuFormatarLetra = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFormatarCores = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFormatarCoresLetra = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFormatarCoresFundo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFormatarAlinhamento = new System.Windows.Forms.ToolStripMenuItem();
            this.esquerdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.direitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFicheiro,
            this.MenuEditar,
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(366, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // MenuFicheiro
            // 
            this.MenuFicheiro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFicheiroNovo,
            this.MenuFicheiroAbrir,
            this.MenuFicheiroGuardar,
            this.toolStripMenuItem1,
            this.MenuFicheiroSair});
            this.MenuFicheiro.Image = global::myNotepad.Properties.Resources.noun_files_1142307;
            this.MenuFicheiro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuFicheiro.Name = "MenuFicheiro";
            this.MenuFicheiro.Size = new System.Drawing.Size(81, 22);
            this.MenuFicheiro.Text = "Ficheiro";
            // 
            // MenuFicheiroNovo
            // 
            this.MenuFicheiroNovo.Image = global::myNotepad.Properties.Resources.noun_file_6649169;
            this.MenuFicheiroNovo.Name = "MenuFicheiroNovo";
            this.MenuFicheiroNovo.Size = new System.Drawing.Size(180, 22);
            this.MenuFicheiroNovo.Text = "Novo";
            this.MenuFicheiroNovo.Click += new System.EventHandler(this.MenuFicheiroNovo_Click);
            // 
            // MenuFicheiroAbrir
            // 
            this.MenuFicheiroAbrir.Image = global::myNotepad.Properties.Resources.noun_file_1408009;
            this.MenuFicheiroAbrir.Name = "MenuFicheiroAbrir";
            this.MenuFicheiroAbrir.Size = new System.Drawing.Size(180, 22);
            this.MenuFicheiroAbrir.Text = "Abrir";
            // 
            // MenuFicheiroGuardar
            // 
            this.MenuFicheiroGuardar.Image = global::myNotepad.Properties.Resources.noun_save_1014816;
            this.MenuFicheiroGuardar.Name = "MenuFicheiroGuardar";
            this.MenuFicheiroGuardar.Size = new System.Drawing.Size(180, 22);
            this.MenuFicheiroGuardar.Text = "Guardar";
            // 
            // MenuFicheiroSair
            // 
            this.MenuFicheiroSair.Image = global::myNotepad.Properties.Resources.noun_exit_1016630;
            this.MenuFicheiroSair.Name = "MenuFicheiroSair";
            this.MenuFicheiroSair.Size = new System.Drawing.Size(180, 22);
            this.MenuFicheiroSair.Text = "Sair";
            // 
            // MenuEditar
            // 
            this.MenuEditar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuEditarCortar,
            this.MenuEditarCopiar,
            this.MenuEditarColar,
            this.toolStripMenuItem2,
            this.MenuEditarSelecionar,
            this.MenuEditarProcurar});
            this.MenuEditar.Image = ((System.Drawing.Image)(resources.GetObject("MenuEditar.Image")));
            this.MenuEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuEditar.Name = "MenuEditar";
            this.MenuEditar.Size = new System.Drawing.Size(69, 22);
            this.MenuEditar.Text = "Editar";
            // 
            // MenuEditarCortar
            // 
            this.MenuEditarCortar.Image = global::myNotepad.Properties.Resources.noun_scissors_6657204;
            this.MenuEditarCortar.Name = "MenuEditarCortar";
            this.MenuEditarCortar.Size = new System.Drawing.Size(180, 22);
            this.MenuEditarCortar.Text = "Cortar";
            // 
            // MenuEditarCopiar
            // 
            this.MenuEditarCopiar.Image = global::myNotepad.Properties.Resources.noun_copy_to_4213618;
            this.MenuEditarCopiar.Name = "MenuEditarCopiar";
            this.MenuEditarCopiar.Size = new System.Drawing.Size(180, 22);
            this.MenuEditarCopiar.Text = "Copiar";
            this.MenuEditarCopiar.Click += new System.EventHandler(this.MenuEditarCopiar_Click);
            // 
            // MenuEditarColar
            // 
            this.MenuEditarColar.Image = ((System.Drawing.Image)(resources.GetObject("MenuEditarColar.Image")));
            this.MenuEditarColar.Name = "MenuEditarColar";
            this.MenuEditarColar.Size = new System.Drawing.Size(180, 22);
            this.MenuEditarColar.Text = "Colar";
            // 
            // MenuEditarSelecionar
            // 
            this.MenuEditarSelecionar.Image = global::myNotepad.Properties.Resources.noun_mark_all_3067122;
            this.MenuEditarSelecionar.Name = "MenuEditarSelecionar";
            this.MenuEditarSelecionar.Size = new System.Drawing.Size(180, 22);
            this.MenuEditarSelecionar.Text = "Selecionar tudo";
            // 
            // MenuEditarProcurar
            // 
            this.MenuEditarProcurar.Image = global::myNotepad.Properties.Resources.noun_search_6655766;
            this.MenuEditarProcurar.Name = "MenuEditarProcurar";
            this.MenuEditarProcurar.Size = new System.Drawing.Size(180, 22);
            this.MenuEditarProcurar.Text = "Procurar";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFormatarLetra,
            this.MenuFormatarCores,
            this.MenuFormatarAlinhamento});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(87, 22);
            this.toolStripSplitButton1.Text = "Formatar";
            // 
            // MenuFormatarLetra
            // 
            this.MenuFormatarLetra.Image = global::myNotepad.Properties.Resources.noun_text_3493441;
            this.MenuFormatarLetra.Name = "MenuFormatarLetra";
            this.MenuFormatarLetra.Size = new System.Drawing.Size(180, 22);
            this.MenuFormatarLetra.Text = "Letra";
            // 
            // MenuFormatarCores
            // 
            this.MenuFormatarCores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFormatarCoresLetra,
            this.MenuFormatarCoresFundo});
            this.MenuFormatarCores.Image = global::myNotepad.Properties.Resources.noun_pallete_5924548;
            this.MenuFormatarCores.Name = "MenuFormatarCores";
            this.MenuFormatarCores.Size = new System.Drawing.Size(180, 22);
            this.MenuFormatarCores.Text = "Cores";
            // 
            // MenuFormatarCoresLetra
            // 
            this.MenuFormatarCoresLetra.Image = ((System.Drawing.Image)(resources.GetObject("MenuFormatarCoresLetra.Image")));
            this.MenuFormatarCoresLetra.Name = "MenuFormatarCoresLetra";
            this.MenuFormatarCoresLetra.Size = new System.Drawing.Size(108, 22);
            this.MenuFormatarCoresLetra.Text = "Letra";
            // 
            // MenuFormatarCoresFundo
            // 
            this.MenuFormatarCoresFundo.Image = ((System.Drawing.Image)(resources.GetObject("MenuFormatarCoresFundo.Image")));
            this.MenuFormatarCoresFundo.Name = "MenuFormatarCoresFundo";
            this.MenuFormatarCoresFundo.Size = new System.Drawing.Size(108, 22);
            this.MenuFormatarCoresFundo.Text = "Fundo";
            // 
            // MenuFormatarAlinhamento
            // 
            this.MenuFormatarAlinhamento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.esquerdaToolStripMenuItem,
            this.centroToolStripMenuItem,
            this.direitaToolStripMenuItem});
            this.MenuFormatarAlinhamento.Image = global::myNotepad.Properties.Resources.noun_text_585637;
            this.MenuFormatarAlinhamento.Name = "MenuFormatarAlinhamento";
            this.MenuFormatarAlinhamento.Size = new System.Drawing.Size(180, 22);
            this.MenuFormatarAlinhamento.Text = "Alinhamento";
            // 
            // esquerdaToolStripMenuItem
            // 
            this.esquerdaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("esquerdaToolStripMenuItem.Image")));
            this.esquerdaToolStripMenuItem.Name = "esquerdaToolStripMenuItem";
            this.esquerdaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.esquerdaToolStripMenuItem.Text = "Esquerda";
            // 
            // centroToolStripMenuItem
            // 
            this.centroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("centroToolStripMenuItem.Image")));
            this.centroToolStripMenuItem.Name = "centroToolStripMenuItem";
            this.centroToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.centroToolStripMenuItem.Text = "Centro";
            // 
            // direitaToolStripMenuItem
            // 
            this.direitaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("direitaToolStripMenuItem.Image")));
            this.direitaToolStripMenuItem.Name = "direitaToolStripMenuItem";
            this.direitaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.direitaToolStripMenuItem.Text = "Direita";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(366, 425);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(366, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Notepad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton MenuFicheiro;
        private System.Windows.Forms.ToolStripMenuItem MenuFicheiroNovo;
        private System.Windows.Forms.ToolStripMenuItem MenuFicheiroAbrir;
        private System.Windows.Forms.ToolStripMenuItem MenuFicheiroGuardar;
        private System.Windows.Forms.ToolStripMenuItem MenuFicheiroSair;
        private System.Windows.Forms.ToolStripSplitButton MenuEditar;
        private System.Windows.Forms.ToolStripMenuItem MenuEditarCortar;
        private System.Windows.Forms.ToolStripMenuItem MenuEditarCopiar;
        private System.Windows.Forms.ToolStripMenuItem MenuEditarColar;
        private System.Windows.Forms.ToolStripMenuItem MenuEditarSelecionar;
        private System.Windows.Forms.ToolStripMenuItem MenuEditarProcurar;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem MenuFormatarLetra;
        private System.Windows.Forms.ToolStripMenuItem MenuFormatarCores;
        private System.Windows.Forms.ToolStripMenuItem MenuFormatarCoresLetra;
        private System.Windows.Forms.ToolStripMenuItem MenuFormatarCoresFundo;
        private System.Windows.Forms.ToolStripMenuItem MenuFormatarAlinhamento;
        private System.Windows.Forms.ToolStripMenuItem esquerdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem direitaToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}

