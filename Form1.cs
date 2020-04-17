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

namespace PhotoGallery
{
    public partial class Form1 : Form
    {
        Panel LastSelectedPicturePanel;

        public Form1()
        {
            InitializeComponent();
        }

        private void Explorer_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = (string)e.Node.Tag;
            this.CurrentDirectory.Text = path;
            try
            {
                ShowImageFiles(path);
            }
            catch
            {

            }
        }

        public void ShowImageFiles(string path)
        {
            LastSelectedPicturePanel = null;

            string[] extensions = new[] { "*.jpg", "*.jpeg", "*.bmp", "*.png", "*.gif", "*.tiff" };
            List<string> ImageFiles = new List<string>();

            foreach (string extension in extensions)
            {
                ImageFiles.AddRange(Directory.GetFiles(path, extension));
            }

            this.PicturePanel.Controls.Clear();

            try
            {
                foreach (string imageFile in ImageFiles)
                {
                    Image image = Image.FromFile(imageFile);

                    Panel panel = new Panel()
                    {
                        Size = new Size(150, 150),
                        BorderStyle = BorderStyle.FixedSingle,
                        Tag = imageFile
                    };

                    Label label = new Label()
                    {
                        AutoSize = false,
                        Text = Path.GetFileName(imageFile),
                        Height = 20,
                        Dock = DockStyle.Bottom,
                        TextAlign = ContentAlignment.MiddleCenter
                    };

                    PictureBox picture = new PictureBox()
                    {
                        Image = image,
                        Dock = DockStyle.Fill
                    };

                    if (image.Height > picture.Height || image.Width > picture.Width)
                        picture.SizeMode = PictureBoxSizeMode.Zoom;
                    else
                        picture.SizeMode = PictureBoxSizeMode.CenterImage;

                    panel.Controls.Add(label);
                    panel.Controls.Add(picture);
                    this.PicturePanel.Controls.Add(panel);

                    MouseEventHandler mouseDownHandler = new MouseEventHandler(Picture_MouseDown);
                    panel.MouseDown += mouseDownHandler;
                    label.MouseDown += mouseDownHandler;
                    picture.MouseDown += mouseDownHandler;

                    EventHandler mouseDoubleClick = new EventHandler(Picture_DoubleClick);
                    panel.DoubleClick += mouseDoubleClick;
                    label.DoubleClick += mouseDoubleClick;
                    picture.DoubleClick += mouseDoubleClick;
                }
            }
            catch
            {

            }
        }

        private void Picture_MouseDown(object sender, MouseEventArgs e)
        {
            if (LastSelectedPicturePanel != null)
            {
                LastSelectedPicturePanel.BackColor = SystemColors.Window;
                LastSelectedPicturePanel.ForeColor = SystemColors.ControlText;
            }

            Panel selectedPanel = (Panel) (sender is Panel ? sender : (sender as Control).Parent);
            selectedPanel.BackColor = SystemColors.Highlight;
            selectedPanel.ForeColor = SystemColors.HighlightText;
            LastSelectedPicturePanel = selectedPanel;
        }

        private void Picture_DoubleClick(object sender, EventArgs e)
        {
            if (LastSelectedPicturePanel == null)
                return;

            string path = (string)LastSelectedPicturePanel.Tag;
            System.Diagnostics.Process.Start(path);
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Photo Gallery, All Rights Reserved 2020.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
