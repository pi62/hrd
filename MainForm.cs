using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hrd
{
    public partial class MainForm : Form
    {
        public MainForm()
        {

            InitializeComponent();
            MainTree.BeginUpdate();
            MainTree.Nodes.Add("lk", "Личная карточка");
            MainTree.Nodes.Add("tabel", "Табель");
            MainTree.Nodes.Add("reports", "Отчеты");
            MainTree.Nodes.Add("search", "Поиск");
            MainTree.EndUpdate();

            this.ActiveControl = HidedButton;
        }

        private void MainTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "lk")
            {
                Form ownedForm = new Form();
                ownedForm.Text = e.Node.FullPath;
                this.AddOwnedForm(ownedForm);
                ownedForm.Show();
            } else if (e.Node.Name == "tabel")
            {
                Tabel ownedForm = new Tabel();
                this.AddOwnedForm(ownedForm);
                ownedForm.Show();
            } else if (e.Node.Name == "reports")
            {
                Form ownedForm = new Form();
                ownedForm.Text = e.Node.FullPath;
                this.AddOwnedForm(ownedForm);
                ownedForm.Show();
            } else if (e.Node.Name == "search")
            {
                Form ownedForm = new Form();
                ownedForm.Text = e.Node.FullPath;
                this.AddOwnedForm(ownedForm);
                ownedForm.Show();
            }

        }
    }
}
