using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace GibPacker
{
  public partial class MainForm : Form
  {
    private ArrayList assetManifestList;

    public MainForm()
    {
      InitializeComponent();
      initializeTree();
    }

    public void initializeTree()
    {
      assetManifestList = new ArrayList();
      treeViewFileList.Nodes.Clear();
    }

    private void newManifestToolStripMenuItem_Click(object sender, EventArgs e)
    {
      initializeTree();
    }

    private void addFileToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FileDialog addFileDialog = new OpenFileDialog();
      addFileDialog.RestoreDirectory = true;

      if (addFileDialog.ShowDialog() == DialogResult.OK && !assetManifestList.Contains(addFileDialog.FileName))
      {
        assetManifestList.Add(addFileDialog.FileName);
        treeViewFileList.Nodes.Add(addFileDialog.FileName);
      }
    }

    private void addFolderToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog addFolderDialog = new FolderBrowserDialog();
      if(addFolderDialog.ShowDialog() == DialogResult.OK)
      {
        TreeNode folderNode = new TreeNode(addFolderDialog.SelectedPath);
        string[] folderContents = Directory.GetFiles(addFolderDialog.SelectedPath);

        foreach(string file in folderContents)
        {
          assetManifestList.Add(file);
          folderNode.Nodes.Add(file);
        }

        treeViewFileList.Nodes.Add(folderNode);
      }
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new AboutForm().ShowDialog();
    }
  }
}
