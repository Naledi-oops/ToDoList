using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxAddTasks.Text == "")
                return;
            else
                checkedListBox.Items.Add(textBoxAddTasks.Text);
                textBoxAddTasks.ResetText();
        }
                
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            for (int i = checkedListBox.Items.Count - 1; i >= 0; i--)
            {
                if (checkedListBox.GetItemChecked(i))
                {
                    checkedListBox.Items.RemoveAt(i);

                }

            }

        }
                
        private void Form1_Load(object sender, EventArgs e)
        {
  
           
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            checkedListBox.Items.Clear();
            textBoxAddTasks.ResetText();
        }

        private void buttonUncheck_Click(object sender, EventArgs e)
        {
            for (int a = 0; a < checkedListBox.Items.Count; a++)
                checkedListBox.SetItemChecked(a, false);
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            for (int a = 0; a < checkedListBox.Items.Count; a++)
                checkedListBox.SetItemChecked(a, true);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
