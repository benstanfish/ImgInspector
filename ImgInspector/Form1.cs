using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Diagnostics;

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
                checkedListBoxImages.SetSelected(0, true);
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


        private void WriteCSV(string FilePath)
        {
            string filePath;
            
            if (FilePath == "")
            {
                filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\ImageSizeLog" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".csv";
            }
            else
            {
                filePath = FilePath + "\\ImageSizeLog" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".csv";
            }

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (String image in checkedListBoxImages.CheckedItems)
                {
                    System.Drawing.Image img = System.Drawing.Image.FromFile(image);
                    string line =
                        Path.GetFullPath(image) + ", " +
                        Path.GetFileName(image).Trim() + ", " +
                        img.Width + ", " +
                        img.Height + ", " +
                        Math.Round(Convert.ToDouble(img.Width) / Convert.ToDouble(img.Height), 5);
                    writer.WriteLine(line);
                }
                writer.Close();
            }

            MessageBox.Show("Completed!");

        }

        private void OpenFolder(string filePath)
        {
            if (File.Exists(filePath))
            {
                Process.Start("explorer.exe", filePath);
            }
        }

        private void writeFiles(string FilePath)
        {
            var images = new List<MyImageData>();
                
            foreach (String image in checkedListBoxImages.CheckedItems)
            {
                System.Drawing.Image img = System.Drawing.Image.FromFile(image);
                MyImageData mid = new MyImageData(image, img.Width, img.Height);
                images.Add(mid);
            }

            string filePath;
            if (FilePath == "")
            {
                filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\ImageSizeLog" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".xml";
            }
            else
            {
                filePath = FilePath + "\\ImageSizeLog" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".xml";
            }
            

            XmlSerializer formatter = new XmlSerializer(typeof(MyImageData));
            TextWriter writer = new StreamWriter(filePath);
           
            foreach (MyImageData myImageData in images)
            {
                //formatter.Serialize(stream, person);
                formatter.Serialize(writer, myImageData);
            }
            writer.Close();
        }

        // [Serializable]
        public class MyImageData
        {
           // [XmlAttribute]
          //  public string ID { get; set; }
            [XmlElement]
            public string imagePath { get; set; }
            public double width { get; set; }
            public double height { get; set; }
            public double aspectRatio { get; set; }

            private MyImageData()
            {
            }

            public MyImageData(string Path, double Width, double Height)
            {
               //this.ID = Path;
                this.imagePath = Path;
                this.width = Width;
                this.height = Height;
                int digits = 5;
                this.aspectRatio = Math.Round(Width / Height, digits);
            }

            public void Save(string fileName)
            {
                using (FileStream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(MyImageData));
                    xml.Serialize(stream, this);
                }
            }

            public static MyImageData LoadFromFile(string fileName)
            {
                using (FileStream stream = new FileStream(fileName, FileMode.Open))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(MyImageData));
                    return (MyImageData)xml.Deserialize(stream);
                }
            }

        }

        private void buttonWriteFile_Click(object sender, EventArgs e)
        {
            //writeFiles();

            if (textBoxLogPath.Text != "")
            {
                WriteCSV(textBoxLogPath.Text);
            }
            else
            {
                MessageBox.Show("Please select a log save location.");
            }

  
        }

        private void buttonFileLoc_Click(object sender, EventArgs e)
        {

                if (textBoxLogPath.Text != "")
                {
                    Process.Start(textBoxLogPath.Text + @"\");
                }
                

        }

        private void buttonLogPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBoxLogPath.Text = fbd.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ReturnText();
        }
    }
}
