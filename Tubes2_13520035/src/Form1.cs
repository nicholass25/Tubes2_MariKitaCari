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
            //ScrollBar vScrollBar1 = new VScrollBar();
            //vScrollBar1.Dock = DockStyle.Right;
            //vScrollBar1.Scroll += (sender, eScroll) => { flowLayoutPanel1.VerticalScroll.Value = vScrollBar1.Value; };
            //flowLayoutPanel1.Controls.Add(vScrollBar1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelPath.Text = "";
            labelOutputTimeSpent.Text = "";
            linkLabelList.Text = "";
        }

        private void ButtonChangeFolder_Click(object sender, EventArgs e)
        {
            /*
            // select and acquire starting folder path (Windows 7 below but better UI)
            var dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            CommonFileDialogResult result = dialog.ShowDialog();
            labelPath.Text = dialog.FileName;
            */

            // select and acquire starting folder path (Windows 7 above but worse UI)
            using (var folderbdialog = new FolderBrowserDialog()){
                DialogResult dialogresult = folderbdialog.ShowDialog();
                labelPath.Text = folderbdialog.SelectedPath;
            }
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
                
                // clear list to reuse
                List<string> listLink = new List<string>();
                List<string> listPath = new List<string>();
                listLink.Clear();
                listPath.Clear();
                linkLabelList.Text = "";
                linkLabelList.Links.Clear();

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
                    // Queue<string> solution = new Queue<string>(); //Queue of solution
                    bool temu = false; // handle all occur atau engga

                    bfs_search.BFS_Search(root_folder);
                    int i = 0;
                    foreach (Folder anak in bfs_search.bfs_show)
                    {
                        foreach (Folder ortu in bfs_search.bfs_show)
                        {
                            if (anak.parent == ortu.direct)
                            {
                                if (bfs_search.jalur.Contains(anak.direct))
                                {
                                    graph.AddEdge(ortu.direct, anak.direct).Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
                                }
                                else if (temu == true && bfs_search.all_occur == false)
                                {
                                    graph.AddEdge(ortu.direct, anak.direct).Attr.Color = Microsoft.Msagl.Drawing.Color.Gray;
                                }
                                else
                                {
                                    graph.AddEdge(ortu.direct, anak.direct).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                                }
                                graph.FindNode(anak.parent).Label.Text = new DirectoryInfo(anak.parent).Name;
                                graph.FindNode(anak.direct).Label.Text = new DirectoryInfo(anak.direct).Name;
                                break;
                            }
                        }
                        if (String.Compare(Path.GetFileName(anak.direct), bfs_search.Namafile) == 0 && i < bfs_search.solution.Count())
                        {
                            graph.FindNode(anak.direct).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Green;
                            temu = true;
                            i++;
                            listPath.Add(anak.direct);
                            listLink.Add(anak.parent);
                        }
                    }

                    int charCounter = 0;
                    int countLink = 0;
                    string[] arrayLink = listLink.ToArray();
                    string[] arrayPath = listPath.ToArray();
                    if (arrayLink.Length > 0)
                    {
                        foreach (var link in arrayLink)
                        {
                            linkLabelList.Text += arrayPath[countLink];
                            linkLabelList.Text += "\n";
                            linkLabelList.Links.Add(charCounter, arrayPath[countLink].Length, arrayLink[countLink]);
                            charCounter += (arrayPath[countLink].Length + 1);
                            countLink++;
                        }
                        linkLabelList.LinkClicked += (s, eLink) => Process.Start((string)eLink.Link.LinkData);
                    }
                    else
                    {
                        linkLabelList.Text += "Tidak ada path yang sesuai!";
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
                    Queue<string> solution = new Queue<string>(); //Queue of solution
                    bool temu = false; // handle all occur atau engga

                    // create graph content
                    dfs_search.DFS_Start(root_folder);
                    int i = 0;
                    foreach (Folder anak in dfs_search.urutan)
                    {
                        foreach (Folder ortu in dfs_search.urutan)
                        {
                            if (anak.parent == ortu.direct)
                            {
                                if (dfs_search.jalur.Contains(anak.direct))
                                {
                                    graph.AddEdge(ortu.direct, anak.direct).Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
                                }
                                else if (temu == true && dfs_search.all_occur == false)
                                {
                                    graph.AddEdge(ortu.direct, anak.direct).Attr.Color = Microsoft.Msagl.Drawing.Color.Gray;
                                }
                                else
                                {
                                    graph.AddEdge(ortu.direct, anak.direct).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                                }
                                graph.FindNode(anak.parent).Label.Text = new DirectoryInfo(anak.parent).Name;
                                graph.FindNode(anak.direct).Label.Text = new DirectoryInfo(anak.direct).Name;
                                break;
                            }
                        }
                        if (String.Compare(Path.GetFileName(anak.direct), dfs_search.Namafile) == 0 && i < dfs_search.solution.Count())
                        {
                            graph.FindNode(anak.direct).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Green;
                            temu = true;
                            i++;
                            listPath.Add(anak.direct);
                            listLink.Add(anak.parent);
                        }
                    }

                    int charCounter = 0;
                    int countLink = 0;
                    string[] arrayLink = listLink.ToArray();
                    string[] arrayPath = listPath.ToArray();
                    if (arrayLink.Length > 0)
                    {
                        foreach (var link in arrayLink)
                        {
                            linkLabelList.Text += arrayPath[countLink];
                            linkLabelList.Text += "\n";
                            linkLabelList.Links.Add(charCounter, arrayPath[countLink].Length, arrayLink[countLink]);
                            charCounter += (arrayPath[countLink].Length + 1);
                            countLink++;
                        }
                        linkLabelList.LinkClicked += (s, eLink) => Process.Start((string)eLink.Link.LinkData);
                    }
                    else
                    {
                        linkLabelList.Text += "Tidak ada path yang sesuai!";
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