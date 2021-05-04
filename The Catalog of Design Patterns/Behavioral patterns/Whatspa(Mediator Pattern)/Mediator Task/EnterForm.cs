using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediator_Task
{
    interface IEnter
    {
        event Action<string> enter;
    }
    public partial class EnterForm : Form,IEnter
    {
        public EnterForm()
        {
            InitializeComponent();
        }

        public event Action<string> enter;

        private void enterButton_Click(object sender, EventArgs e)
        {

            if (enterTextBox.Text.Length > 0)
            {
                enter?.Invoke(enterTextBox.Text.ToString());
            }
            else
            {
                MessageBox.Show("Please enter name !", "Informat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            enterTextBox.Clear();
        }
    }
}
