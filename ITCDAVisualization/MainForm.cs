using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

namespace ITCDAVisualization
{
    public partial class MainForm : Form
    {
        private JArray jsonData;

        public MainForm()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog()
            {
                Filter = "json file|*.json|word|*.docx"
            })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (openFileDialog.FileName.EndsWith("json"))
                        ReadJson(openFileDialog.FileName);
                    else
                        ReadDocx(openFileDialog.FileName);
                }
            }
        }

        private void ReadDocx(string fileName)
        {
            var output = GenJson(fileName);
            ReadJson(output);
        }

        private string GenJson(string fileName)
        {
            throw new NotImplementedException();
        }

        private void ReadJson(string fileName)
        {
            jsonData = JsonConvert.DeserializeObject<JArray>(File.ReadAllText(fileName));
            docTreeView.Nodes.Clear();
            var nodes = CreateDocView(jsonData);
            docTreeView.Nodes.Add(new TreeNode(fileName, nodes));
        }

        private static TreeNode[] CreateDocView(JArray json)
        {
            TreeNode[] nodes = new TreeNode[json.Count];
            for (int i = 0; i < json.Count; i++)
            {
                var level = json[i].Value<string>("level");
                var header = json[i].Value<string>("header");
                var requirement = json[i].Value<string>("requirement");
                var reqNode = new TreeNode(requirement);
                reqNode.Tag = json[i];
                var reqNodes = new TreeNode[] { reqNode };
                nodes[i] = new TreeNode(level + header, reqNodes);
            }
            return nodes;
        }

        private void collapseAllButton_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in docTreeView.Nodes)
                node.Collapse();
        }

        private void dumpTextButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (docTreeView.SelectedNode != null)
                    Clipboard.SetText(docTreeView.SelectedNode.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void docTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Nodes.Count != 0)
                return;
            testCaseListView.SuspendLayout();
            testCaseListView.Items.Clear();
            TreeNode node = e.Node;
            JToken json = node.Tag as JToken;
            var features = json.Value<JArray>("features").Select(v => v.Value<double>()).ToArray();
            var testCases = json.Value<JArray>("testCases");
            var testCaseFragments = json.Value<JArray>("testCaseFragments");
            if (testCases != null)
            {
                for (int i = 0; i < testCases.Count; i++)
                {
                    var item = new ListViewItem(new string[] { i.ToString() });
                    testCaseListView.Items.Add(item);
                }
            }
            if (testCaseFragments != null)
            {

            }
            testCaseListView.ResumeLayout();
        }
    }
}
