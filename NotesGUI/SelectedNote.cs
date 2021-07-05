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
    }
}
