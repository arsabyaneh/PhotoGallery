using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoGallery.Controls
{
    public class Explorer : TreeView
    {
        private ImageList ExplorerImageList;

        private void Initialize()
        {
            ExplorerImageList = new ImageList();
            TreeNode RootNode = new TreeNode();

            this.SuspendLayout();

            ExplorerImageList.Images.Add("MyComputer", Properties.Resources.Computer_16x);
            ExplorerImageList.Images.Add("Drive", Properties.Resources.HardDrive_16x);
            ExplorerImageList.Images.Add("CDDrive", Properties.Resources.CDDrive_16x);
            ExplorerImageList.Images.Add("FolderClosed", Properties.Resources.FolderClosed_16x);
            ExplorerImageList.Images.Add("FolderOpened", Properties.Resources.FolderOpened_16x);

            this.ImageList = ExplorerImageList;
            this.ImageIndex = 0;
            this.SelectedImageIndex = 0;
            RootNode.Name = "RootNode";
            RootNode.Text = "My Computer";
            this.Nodes.Add(RootNode);

            this.ResumeLayout(false);
        }

        private void AddFolders(string path, TreeNode parent)
        {
            string[] directories = null;
            parent.Nodes.Clear();

            try
            {
                if (path == null)
                    directories = Directory.GetLogicalDrives();
                else
                    directories = Directory.GetDirectories(path);

                foreach (string directory in directories)
                {
                    TreeNode node = new TreeNode()
                    {
                        Text = (path == null) ? directory : Path.GetFileName(directory),
                        Tag = directory
                    };

                    if (path == null)
                    {
                        node.ImageIndex = node.SelectedImageIndex = (new DriveInfo(directory).DriveType == DriveType.CDRom) ? 2 : 1;
                    }
                    else
                    {
                        node.ImageIndex = node.SelectedImageIndex = 3;
                    }

                    parent.Nodes.Add(node);
                }
            }
            catch
            {

            }
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            if (this.DesignMode)
                return;

            Initialize();
            AddFolders(null, this.Nodes[0]);
            this.Nodes[0].Expand();
        }

        protected override void OnAfterExpand(TreeViewEventArgs e)
        {
            if (e.Node.Level > 1)
                e.Node.ImageIndex = e.Node.SelectedImageIndex = 4;

            foreach (TreeNode node in e.Node.Nodes)
            {
                AddFolders((string)node.Tag, node);
            }

            base.OnAfterExpand(e);
        }

        protected override void OnAfterCollapse(TreeViewEventArgs e)
        {
            if (e.Node.Level > 1)
                e.Node.ImageIndex = e.Node.SelectedImageIndex = 3;

            base.OnAfterCollapse(e);
        }
    }
}
