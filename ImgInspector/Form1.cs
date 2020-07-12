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


        private void writeFiles()
        {
            string currentFolder = Path.GetDirectoryName(checkedListBoxImages.CheckedItems.ToString());
            string logPath = currentFolder + "_" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".txt";
         
            var images = new List<MyImageData>();

            foreach (string image in checkedListBoxImages.CheckedItems)
            {
                MyImageData myImageData = new MyImageData();
                System.Drawing.Image img = System.Drawing.Image.FromFile(image);
                myImageData.imagePath = Path.GetFullPath(image);
                myImageData.width = img.Width;
                myImageData.height = img.Height;
                images.Add(myImageData);
            }

            foreach (MyImageData image in images)
            {
                image.SaveObject(logPath);
            }
        }


        //private void ButtonMakePersons_Click(object sender, EventArgs e)
        //{
        //    var persons = new List<Person>();
        //    foreach (DataGridViewRow row in dataGridView1.Rows)
        //    {

        //        Person person = new Person();
        //        persons.Add(person);
        //    }

        //    string usersDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        //    //Stream stream = new FileStream(usersDesktop + "\\Project Serialize\\BIN_" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".txt", FileMode.Create, FileAccess.Write);
        //    string filePath = usersDesktop + "\\Project Serialize\\XML_" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".txt";


        //    // IFormatter formatter = new BinaryFormatter();
        //    //BinaryFormatter formatter = new BinaryFormatter();

        //    //XmlSerializer formatter = new XmlSerializer(typeof(Person));

        //    foreach (Person person in persons)
        //    {
        //        //formatter.Serialize(stream, person);
        //        person.Save(filePath);
        //    }
        //    //stream.Close();
        //}


        // [Serializable]
        public class MyImageData
        {
            [XmlAttribute]
            public string imagePath { get; set; }
            [XmlElement]
            public int width { get; set; }
            public int height { get; set; }
            public double aspectRatio { get; set; }

            public void SaveObject(string fileName)
            {
                using (FileStream stream = new FileStream(fileName, FileMode.Append))
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
            writeFiles();
        }
    }
}
