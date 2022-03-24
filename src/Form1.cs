using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Diagnostics;

namespace MariKitaCari
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            //create a viewer object 
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            //create a graph object 
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            //create the graph content 
            // do nothing (blank)
            //bind the graph to the viewer 
            viewer.Graph = graph;
            //associate the viewer with the form 
            panel1.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Controls.Add(viewer);
            panel1.ResumeLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelPath.Text = "";
            labelOutputTimeSpent.Text = "";
        }

        private void ButtonChangeFolder_Click(object sender, EventArgs e)
        {
            // select and acquire starting folder path
            var dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            CommonFileDialogResult result = dialog.ShowDialog();
            labelPath.Text = dialog.FileName;
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            // add timer
            Stopwatch Timer = new Stopwatch();
            if (labelPath.Text == "") // IsNullOrEmpty()
            {
                MessageBox.Show("Pilih starting folder, mas!", "Gagal Ngab!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxFileName.Text == "") // IsNullOrEmpty()
            {
                MessageBox.Show("Isi file name, sob!", "Gagal Ngab!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string root_folder = labelPath.Text;
                if (radiobtnBFS.Checked)
                {
                    //create a viewer object 
                    Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
                    //create a graph object 
                    Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
                    viewer.Graph = null;
                    panel1.Controls.Clear();
                    Timer.Start();
                    BFS bfs_search = new BFS(textBoxFileName.Text, checkBoxOccurence.Checked);
                    bfs_search.BFS_Search(root_folder);
                    foreach (Folder anak in bfs_search.bfs_show)
                    {
                        foreach (Folder ortu in bfs_search.bfs_show)
                        {
                            if (anak.parent == ortu.direct)
                            {
                                graph.AddEdge(ortu.direct, anak.direct);
                                graph.FindNode(anak.parent).Label.Text = new DirectoryInfo(anak.parent).Name;
                                graph.FindNode(anak.direct).Label.Text = new DirectoryInfo(anak.direct).Name;
                                break;
                            }
                        }
                        if (String.Compare(Path.GetFileName(anak.direct), bfs_search.Namafile) == 0)
                        {
                            graph.FindNode(anak.direct).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Green;
                            LinkLabel label = new LinkLabel();
                            label.Text = Path.GetFullPath(anak.direct);
                            listLinkPath.Controls.Add(label);
                        }
                    }
                    Timer.Stop();
                    labelOutputTimeSpent.Text = Timer.Elapsed.TotalSeconds.ToString() + " detik";
                    //bind the graph to the viewer 
                    viewer.Graph = graph;
                    //associate the viewer with the form 
                    panel1.SuspendLayout();
                    viewer.Dock = System.Windows.Forms.DockStyle.Fill;
                    panel1.Controls.Add(viewer);
                    panel1.ResumeLayout();
                }
                else if (radiobtnDFS.Checked)
                {
                    //create a viewer object 
                    Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
                    //create a graph object 
                    Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
                    viewer.Graph = null;
                    panel1.Controls.Clear();
                    Timer.Start();
                    DFS dfs_search = new DFS(textBoxFileName.Text, checkBoxOccurence.Checked);
                    // create graph content
                    dfs_search.DFS_Start(root_folder);
                    foreach (Folder anak in dfs_search.urutan)
                    {
                        foreach (Folder ortu in dfs_search.urutan)
                        {
                            if (anak.parent == ortu.direct)
                            {
                                graph.AddEdge(ortu.direct, anak.direct);
                                graph.FindNode(anak.parent).Label.Text = new DirectoryInfo(anak.parent).Name;
                                graph.FindNode(anak.direct).Label.Text = new DirectoryInfo(anak.direct).Name;
                                break;
                            }
                        }
                        if (String.Compare(Path.GetFileName(anak.direct), dfs_search.Namafile) == 0)
                        {
                            graph.FindNode(anak.direct).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Green;
                        }
                    }
                    Timer.Stop();
                    labelOutputTimeSpent.Text = Timer.Elapsed.TotalSeconds.ToString() + " detik";
                    //bind the graph to the viewer 
                    viewer.Graph = graph;
                    //associate the viewer with the form 
                    panel1.SuspendLayout();
                    viewer.Dock = System.Windows.Forms.DockStyle.Fill;
                    panel1.Controls.Add(viewer);
                    panel1.ResumeLayout();
                }
                else
                {
                    MessageBox.Show("Pilih salah satu metode, gan!", "Gagal Ngab!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
