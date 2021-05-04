using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingletonWinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            listBox.Items.AddRange(NoteStorage.Instance.Notes.ToArray());
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var addForm = new AddForm();
            addForm.ShowDialog();

            int index = NoteStorage.Instance.Notes.Count;
            listBox.Items.Add(NoteStorage.Instance.Notes[index-1]);
        }
    }
}
