using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hf3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            InputDialog dlg = new InputDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string result = dlg.Path;
                DirectoryInfo parentDI = new DirectoryInfo(result);
                listView1.Items.Clear();
                try
                {
                    foreach (FileInfo fi in parentDI.GetFiles())
                        listView1.Items.Add(new ListViewItem(new string[] { fi.Name, fi.Length.ToString(), fi.FullName }));
                }
                catch { }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 1) return;
            FileInfo file = new FileInfo(listView1.SelectedItems[0].SubItems[2].Text);
            lName.Text = file.Name;
            lCreated.Text = file.CreationTime.ToString();
            tContent.Text = File.ReadAllText(file.FullName);
        }
    }
}
