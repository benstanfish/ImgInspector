using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgInspector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClearAll()
        {
            checkedListBoxImages.Items.Clear();
            pictureBoxPreview.InitialImage = null;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            ClearAll();

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.gif, *.png, *.svg, *.bmp, *.tiff)|*.jpg; *.jpeg; *.gif; *.png; *.svg; *.bmp; *.tiff;)";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                checkedListBoxImages.Items.AddRange(openFileDialog1.FileNames);
                for (int i = 0; i < checkedListBoxImages.Items.Count; i++)
                {
                    checkedListBoxImages.SetItemChecked(i, true);
                }
            }

        }

        private void SelectAll()
        {
            for (int i = 0; i < checkedListBoxImages.Items.Count; i++)
            {
                checkedListBoxImages.SetItemChecked(i, true);
            }
        }

        private void SelectNone()
        {
            while (checkedListBoxImages.CheckedIndices.Count > 0)
            {
                checkedListBoxImages.SetItemChecked(checkedListBoxImages.CheckedIndices[0], false);
            }
        }

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void buttonSelectNone_Click(object sender, EventArgs e)
        {
            SelectNone();
        }

        private void checkedListBoxImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBoxPreview.Image = Image.FromFile(checkedListBoxImages.SelectedItem.ToString());
        }

      
    }
}
