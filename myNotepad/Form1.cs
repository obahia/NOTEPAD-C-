using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace myNotepad
{
    public partial class Form1 : Form
    {
        private string ficheiro = "";
        public Form1()
        {
            InitializeComponent();
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

        private void MenuFicheiroNovo_Click(object sender, EventArgs e)
        {
            VerificarAlteracoes();
            rbTexto.ResetText();
            rbTexto.Modified = false;
            ficheiro = "";
          
        }

        private void MenuFicheiroAbrir_Click(object sender, EventArgs e)
        {
            VerificarAlteracoes();
            openFileDialog1.Filter = "Ficheiros RTF | *.rtf | Ficheiros TXT | *.txt | Todos | *.*";
            openFileDialog1.FileName = "";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ficheiro = openFileDialog1.FileName;
                rbTexto.LoadFile(ficheiro);
                rbTexto.Modified = false;
            }
        }

        private void MenuFicheiroGuardar_Click(object sender, EventArgs e)
        {
            if (ficheiro != "")
            {
                rbTexto.SaveFile(ficheiro);
                rbTexto.Modified = false;
            }
            else
            {
                GuardarFicheiro();
            }
        }

        private void MenuFicheiroSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja sair da aplicação?", "Aviso",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(resposta == DialogResult.Yes)
            {
                VerificarAlteracoes();
            }
        }

        private void VerificarAlteracoes()
        {
            if(rbTexto.Modified == true)
            {
                DialogResult resposta = MessageBox.Show("Deseja guardar o texto atual?", "Atenção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(resposta == DialogResult.Yes)
                {
                    if (ficheiro !="")
                    {
                        rbTexto.SaveFile(ficheiro);
                        rbTexto.Modified = false;
                    }
                    else
                    {
                        GuardarFicheiro();
                    }
                }
            }
        }

        private void GuardarFicheiro()
        {
            saveFileDialog1.Filter = "Ficheiros RTF | *.rtf | Ficheiros TXT | *.txt";

            saveFileDialog1.FileName = "";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ficheiro = saveFileDialog1.FileName;
                rbTexto.SaveFile (ficheiro);
                rbTexto.Modified = false;
            }
        }

        private void MenuEditarCortar_Click(object sender, EventArgs e)
        {
            rbTexto.Cut();
        }

        private void MenuEditarCopiar_Click(object sender, EventArgs e)
        {
            rbTexto.Copy();
        }

        private void MenuEditarColar_Click(object sender, EventArgs e)
        {
            rbTexto.Paste();
        }

        private void MenuEditarSelecionar_Click(object sender, EventArgs e)
        {
            rbTexto.SelectAll();
        }

        private void MenuEditarProcurar_Click(object sender, EventArgs e)
        {
            string txtProcura = Interaction.InputBox("Digite o que procura:",
                                                     "Procurar", "", 150, 200);

            int resultado = rbTexto.Find(txtProcura);
            if (resultado ==-1)
            {
                MessageBox.Show("Aviso", "Não foi encotrada a sua procura.",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void MenuFormatarLetra_Click(object sender, EventArgs e)
        {
            if(rbTexto.SelectionFont != null)
            {
                fontDialog1.Font = rbTexto.SelectionFont;
            }
            else
            {
                fontDialog1.Font = null;
            }

            fontDialog1.ShowDialog();
            rbTexto.SelectionFont = fontDialog1.Font;
        }

        private void MenuFormatarCoresLetra_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            rbTexto.SelectionColor = colorDialog1.Color;
        }

        private void MenuFormatarCoresFundo_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            rbTexto.SelectionBackColor = colorDialog1.Color;
        }

        private void esquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rbTexto.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void centroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rbTexto.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void direitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rbTexto.SelectionAlignment = HorizontalAlignment.Right;

        }

        private void MenuFicheiro_ButtonClick(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {

            DialogResult resposta = MessageBox.Show("Autor: João Bahia\nVersão: 1.0 \nCopyRight© Bahia Team", "Informação",
                                                   MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
