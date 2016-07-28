namespace GibPacker
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.menuStrip = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newManifestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.addFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.addFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.packToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mainContainer = new System.Windows.Forms.SplitContainer();
      this.treeViewFileList = new System.Windows.Forms.TreeView();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.menuStrip.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
      this.mainContainer.Panel1.SuspendLayout();
      this.mainContainer.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip
      // 
      this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.packToolStripMenuItem,
            this.aboutToolStripMenuItem});
      this.menuStrip.Location = new System.Drawing.Point(0, 0);
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.Size = new System.Drawing.Size(1585, 33);
      this.menuStrip.TabIndex = 0;
      this.menuStrip.Text = "menuStrip";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newManifestToolStripMenuItem,
            this.openToolStripMenuItem,
            this.addToolStripMenuItem,
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // newManifestToolStripMenuItem
      // 
      this.newManifestToolStripMenuItem.Name = "newManifestToolStripMenuItem";
      this.newManifestToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
      this.newManifestToolStripMenuItem.Text = "New Manifest";
      this.newManifestToolStripMenuItem.Click += new System.EventHandler(this.newManifestToolStripMenuItem_Click);
      // 
      // openToolStripMenuItem
      // 
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
      this.openToolStripMenuItem.Text = "Open Manifest";
      // 
      // addToolStripMenuItem
      // 
      this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFileToolStripMenuItem,
            this.addFolderToolStripMenuItem});
      this.addToolStripMenuItem.Name = "addToolStripMenuItem";
      this.addToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
      this.addToolStripMenuItem.Text = "Add...";
      // 
      // addFileToolStripMenuItem
      // 
      this.addFileToolStripMenuItem.Name = "addFileToolStripMenuItem";
      this.addFileToolStripMenuItem.Size = new System.Drawing.Size(147, 30);
      this.addFileToolStripMenuItem.Text = "File";
      this.addFileToolStripMenuItem.Click += new System.EventHandler(this.addFileToolStripMenuItem_Click);
      // 
      // addFolderToolStripMenuItem
      // 
      this.addFolderToolStripMenuItem.Name = "addFolderToolStripMenuItem";
      this.addFolderToolStripMenuItem.Size = new System.Drawing.Size(147, 30);
      this.addFolderToolStripMenuItem.Text = "Folder";
      this.addFolderToolStripMenuItem.Click += new System.EventHandler(this.addFolderToolStripMenuItem_Click);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
      this.exitToolStripMenuItem.Text = "Exit";
      // 
      // packToolStripMenuItem
      // 
      this.packToolStripMenuItem.Name = "packToolStripMenuItem";
      this.packToolStripMenuItem.Size = new System.Drawing.Size(59, 29);
      this.packToolStripMenuItem.Text = "Pack";
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
      this.aboutToolStripMenuItem.Text = "About";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
      // 
      // mainContainer
      // 
      this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.mainContainer.Location = new System.Drawing.Point(0, 33);
      this.mainContainer.Name = "mainContainer";
      // 
      // mainContainer.Panel1
      // 
      this.mainContainer.Panel1.Controls.Add(this.treeViewFileList);
      this.mainContainer.Size = new System.Drawing.Size(1585, 846);
      this.mainContainer.SplitterDistance = 400;
      this.mainContainer.TabIndex = 1;
      // 
      // treeViewFileList
      // 
      this.treeViewFileList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.treeViewFileList.Location = new System.Drawing.Point(0, 0);
      this.treeViewFileList.Name = "treeViewFileList";
      this.treeViewFileList.Size = new System.Drawing.Size(400, 846);
      this.treeViewFileList.TabIndex = 0;
      // 
      // statusStrip1
      // 
      this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.statusStrip1.Location = new System.Drawing.Point(0, 857);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(1585, 22);
      this.statusStrip1.TabIndex = 0;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1585, 879);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.mainContainer);
      this.Controls.Add(this.menuStrip);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip;
      this.Name = "MainForm";
      this.Text = "GibPacker";
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.mainContainer.Panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
      this.mainContainer.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newManifestToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.SplitContainer mainContainer;
    private System.Windows.Forms.TreeView treeViewFileList;
    private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem packToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem addFileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem addFolderToolStripMenuItem;
    private System.Windows.Forms.StatusStrip statusStrip1;
  }
}

