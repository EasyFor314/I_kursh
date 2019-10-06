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
using System.Xml;

namespace l_kursh
{
    public partial class MainForm : Form
    {
        string filename;
        XmlDocument xmlDoc;
        StreamWriter sr;
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip2_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripAdd_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripFileCreate_Click(object sender, EventArgs e)
        {
            ChildForm childforminit = new ChildForm
            {
                MdiParent = this,
            };

            childforminit.Show();
            
        }

        private void ParentKnot_Click(object sender, EventArgs e)
        {
            Form active = this.ActiveMdiChild;
            if(active != null)
            {

                TreeNode newParentNode = new TreeNode("Test");
                try
                {
                    TreeView all = (TreeView)active.ActiveControl;
                    all.Nodes.Add(newParentNode);
                }
                catch
                {
                    MessageBox.Show("Вызвано исключение");
                }
            }
        }

        private void ToolStripFileOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = null;
            openFileDialog1.ShowDialog();
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            filename = openFileDialog1.FileName;
            string cashefile = File.ReadAllText(filename);
            xmlDoc = new XmlDocument();
            try
            {
                xmlDoc.LoadXml(cashefile);
                ChildForm childforminit = new ChildForm()
                {
                    MdiParent = this,
                };
                childforminit.Show();
                Form active = this.ActiveMdiChild;
                if (active != null)
                {
                    try
                    {
                        TreeView all = (TreeView)active.ActiveControl;
                        all.Nodes.Clear();
                        int i = 0;
                        TreeNode rootNode = new TreeNode();
                        all.Nodes.Add(new TreeNode() { Text = xmlDoc.DocumentElement.Name });
                        rootNode = all.Nodes[i];
                        AddNode(xmlDoc.DocumentElement, rootNode);
                        all.ExpandAll();
                    }
                    catch
                    {
                        MessageBox.Show("Вызвано исключение");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Неверный формат файла");
            }
        }
        private void AddNode(XmlNode xmlnode, TreeNode treeNode)
        {
            XmlNode xNode;
            TreeNode tNode;
            XmlNodeList listn;
            int i;
            if (xmlnode.HasChildNodes)
            {
                listn = xmlnode.ChildNodes;
                for (i = 0;  i < listn.Count; i++)
                {
                    xNode = xmlnode.ChildNodes[i];
                    treeNode.Nodes.Add(new TreeNode() { Text = xNode.Name });
                    tNode = treeNode.Nodes[i];
                    AddNode(xNode, tNode);
                }
            }
            else
            {
                listn = xmlnode.ChildNodes;
                for (i = 0; i < listn.Count; i++)
                {
                    xNode = xmlnode.ChildNodes[i];
                    treeNode.Nodes.Add(new TreeNode(xNode.Name));
                    tNode = treeNode.Nodes[i];
                    AddNode(xNode, tNode);
                }
            }
        }

        private void SaveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Form active = this.ActiveMdiChild;
            if (active != null)
            {
                try
                {
                    TreeView all = (TreeView)active.ActiveControl;
                    exportToXml(all, saveFileDialog1.FileName);
                    active.Text = saveFileDialog1.FileName;
                }
                catch
                {
                    MessageBox.Show("Дочерняя форма не выбрана");
                }

            }

        }
        public void exportToXml(TreeView tv, string filename)
        {
            sr = new StreamWriter(filename, false, System.Text.Encoding.UTF8);
            //Write the header
            sr.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
            //Write our root node
            sr.WriteLine("<" + tv.Nodes[0].Text + ">");
            foreach (TreeNode node in tv.Nodes)
            {
                saveNode(node.Nodes);
            }
            //Close the root node
            sr.WriteLine("</" + tv.Nodes[0].Text + ">");
            sr.Close();
        }
        private void saveNode(TreeNodeCollection tnc)
        {
            foreach (TreeNode node in tnc)
            {
                //If we have child nodes, we'll write 
                //a parent node, then iterrate through
                //the children
                if (node.Nodes.Count > 0)
                {
                    sr.WriteLine("<" + node.Text + ">");
                    saveNode(node.Nodes);
                    sr.WriteLine("</" + node.Text + ">");
                }
                else //No child nodes, so we just write the text
                {
                    sr.WriteLine("<" + node.Text + ">");
                    sr.WriteLine("</" + node.Text + ">");
                }
            }
        }
        private void ToolStripSaveFile_Click(object sender, EventArgs e)
        {
            Form active = this.ActiveMdiChild;
            if (active != null)
            {
                saveFileDialog1.ShowDialog();
            }
            else
                MessageBox.Show("Дочерняя форма не выбрана");

        }

        private void DeleteKnot_Click(object sender, EventArgs e)
        {
            Form active = this.ActiveMdiChild;
            if (active != null)
            {
                try
                {
                    TreeView box = (TreeView)active.ActiveControl;
                    TreeNode SelectedNode = box.SelectedNode;
                    SelectedNode.Nodes.Remove(SelectedNode);
                }
                catch
                {
                    MessageBox.Show("Узел не выбран!");
                }
            }
        }

        private void ChildKnot_Click(object sender, EventArgs e)
        {
            Form active = this.ActiveMdiChild;
            if (active != null)
            {

                TreeNode newChildNode = new TreeNode("Test");
                try
                {
                    TreeView all = (TreeView)active.ActiveControl;
                    TreeNode SelectedNode = all.SelectedNode;
                    SelectedNode.Nodes.Add(newChildNode);
                }
                catch
                {
                    MessageBox.Show("Узел не выбран!");
                }
            }
        }
    }
}
