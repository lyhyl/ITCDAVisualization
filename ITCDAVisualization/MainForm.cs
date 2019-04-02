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
        private double highConf, medConf;
        private JArray jsonData;
        private string[] testCaseKeys = new string[] {
            "uid",
            "caseId",
            "systemName",
            "subSystem",
            "transName",
            "funcPoint",
            "testType",
            "testCheckPoint",
            "batchCharacteristic",
            "precondition",
            "inputData",
            "testProcedure",
            "expectedResult",
            "demandPoint",
            "instruction"
         };
        private string[] testCaseNames = new string[] {
            "UID",
            "Case ID",
            "Sys.",
            "Sub Sys.",
            "Trans.",
            "Func.",
            "Type",
            "Check Pt.",
            "Batch",
            "Precond.",
            "Input",
            "Proc",
            "Result",
            "Requirement",
            "Instruction"
         };
        private string[] fragKeys = new string[] {
            "uid",
            "requirement",
            "test_check_point",
            "test_procedure",
            "expected_result"
        };
        private string[] fragNames = new string[] {
            "UID",
            "Case ID",
            "Requirement",
            "Check Pt.",
            "Proc",
            "Result"
         };

        public MainForm()
        {
            InitializeComponent();
            var confPath = @".\conf.txt";
            if(File.Exists(confPath))
            {
                var lines = File.ReadAllLines(confPath);
                medConf = double.Parse(lines[0]);
                highConf = double.Parse(lines[1]);
            }
            else
            {
                medConf = 0.1;
                highConf = 0.5;
            }
        }

        private Color getColor(double v)
        {
            if (v > highConf)
                return Color.Green;
            else if (v > medConf)
                return Color.Gold;
            else
                return Color.Red;
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
            foreach (ColumnHeader col in testCaseListView.Columns)
                col.Text = "";
            testCaseListView.Items.Clear();
            TreeNode node = e.Node;
            JToken json = node.Tag as JToken;
            var features = json.Value<JArray>("features").Select(v => v.Value<double>()).ToArray();
            var testCases = json.Value<JArray>("testCases");
            var testCaseFragments = json.Value<JArray>("testCaseFragments");
            if (testCases != null)
            {
                testCaseListView.Columns[0].Text = "No.";
                for (int i = 0; i < testCaseNames.Length - 1; i++)
                    testCaseListView.Columns[i + 1].Text = testCaseNames[i];
                for (int i = 0; i < testCases.Count; i++)
                {
                    var test = testCases.Value<JObject>(i);
                    var subitem = testCaseKeys.Select(k => test.Value<string>(k)).ToList();
                    subitem.Insert(0, i.ToString());
                    var lvItem = new ListViewItem(subitem.ToArray());
                    lvItem.ForeColor = getColor(features[i]);
                    lvItem.Tag = features[i];
                    testCaseListView.Items.Add(lvItem);
                }
                testCaseListView.Tag = 1;
            }
            if (testCaseFragments != null)
            {
                for (int i = 0; i < fragNames.Length; i++)
                    testCaseListView.Columns[i].Text = fragNames[i];
                var test = testCaseFragments.Value<JObject>(testCaseFragments.Count - 1);
                var subitem = fragKeys.Select(k => test.Value<string>(k)).ToList();
                subitem.Insert(0, "0");
                var lvItem = new ListViewItem(subitem.ToArray());
                lvItem.SubItems[0].ForeColor = getColor(1);
                lvItem.SubItems[1].ForeColor = getColor(1);
                lvItem.SubItems[2].ForeColor = getColor(1);
                lvItem.Tag = Tuple.Create(features, testCaseFragments);
                testCaseListView.Items.Add(lvItem);
                testCaseListView.Tag = 2;
            }
            testCaseListView.ResumeLayout();
        }

        private void testCaseListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            detailListView.SuspendLayout();
            detailListView.Items.Clear();
            if ((int)testCaseListView.Tag == 1)
            {
                var selected = testCaseListView.SelectedItems;
                var items = selected.Cast<ListViewItem>().Select((a, i) => new ListViewItem(new string[] { i.ToString(), a.Tag.ToString() }));
                detailListView.Items.AddRange(items.ToArray());
            }
            else if ((int)testCaseListView.Tag == 2)
            {
                var selected = testCaseListView.SelectedItems;
                if (selected.Count > 0)
                {
                    var info = selected[0].Tag as Tuple<double[], JArray>;
                    for (int i = 0; i < info.Item1.Length; i++)
                    {
                        var frag = info.Item2.Value<JObject>(i);
                        var subitem = fragKeys.Select(k => frag.Value<string>(k)).ToList();
                        subitem.Insert(0, info.Item1[i].ToString());
                        subitem.Insert(0, i.ToString());
                        detailListView.Items.Add(new ListViewItem(subitem.ToArray()));
                    }
                }
            }
            detailListView.ResumeLayout();
        }

        private void headerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item.Checked)
                testCaseListView.Columns[Array.IndexOf(testCaseNames, item.Text) + 1].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            else
                testCaseListView.Columns[Array.IndexOf(testCaseNames, item.Text) + 1].Width = 0;
        }

        private void resizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            testCaseListView.SuspendLayout();
            foreach (ColumnHeader col in testCaseListView.Columns)
                col.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            testCaseListView.ResumeLayout();
        }

        private void resizeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (ColumnHeader col in detailListView.Columns)
                col.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
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
    }
}
