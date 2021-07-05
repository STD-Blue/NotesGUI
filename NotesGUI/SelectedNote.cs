using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NotesDLL;

namespace NotesGUI
{
    public partial class SelectedNote : Form
    {
        public SelectedNote()
        {
            InitializeComponent();
            textBox1.Text = Manager.TakeTextNote(File.ReadAllText("FindBtn.txt"));

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            File.WriteAllText("FindBtnText.txt", textBox1.Text);
        }

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
            using (FontDialog font = new FontDialog())
            {
                if(font.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Font = font.Font;
                }
            }
        }

        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog color = new ColorDialog())
            {
                if(color.ShowDialog() == DialogResult.OK)
                {
                    textBox1.ForeColor = color.Color;
                }
            }
        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog color = new ColorDialog())
            {
                if (color.ShowDialog() == DialogResult.OK)
                {
                    textBox1.BackColor = color.Color;
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.Filter = "Txt(.txt)|*.txt";
                if(save.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText($"{save.FileName}.txt", textBox1.Text);
                }
            }
        }

        private void backToNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
