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
using System.Xml;
using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void serializeB_Click(object sender, EventArgs e)
        {
            student s = new student();
            s.name = nameBox.Text;
            s.surname = surnameBox.Text;
            s.age = Convert.ToInt32(ageBox.Text);
            s.department=departmentBox.Text;
            XmlSerializer serializer = new XmlSerializer(typeof(student));
            StreamWriter writer = new StreamWriter(@"C:\Users\Ferhat\Documents\Visual Studio 2013\Projects\Programming languages\Students\WindowsFormsApplication1\exemel.xml");
            serializer.Serialize(writer, s);
            writer.Close();
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameBox.Text))
            {
                epName.SetError(nameBox, "Field cannot be blank.");
            }
            else
            {
                epName.Clear();
            }
        }




        private void deserializeB_Click(object sender, EventArgs e)
        {

            XmlSerializer deserializer = new XmlSerializer(typeof(student));
            XmlTextReader reader = new XmlTextReader(@"C:\Users\Ferhat\Documents\Visual Studio 2013\Projects\Programming languages\Students\WindowsFormsApplication1\exemel.xml");
            student s = new student();
            s = (student)deserializer.Deserialize(reader);
            listStudents.Items.Add(s.getStudentInfo());


            reader.Close();

        }

        private void surnameBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(surnameBox.Text))
            {
                epSurname.SetError(surnameBox, "Field cannot be blank.");
            }
            else
            {
                epSurname.Clear();
            }
        }

        private void ageBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ageBox.Text))
            {
                epAge.SetError(ageBox, "Field cannot be blank.");
            }
            else
            {
                epAge.Clear();
            }
        }

        private void departmentBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(departmentBox.Text))
            {
                epDepartment.SetError(departmentBox, "Field cannot be blank.");
            }
            else
            {
                epDepartment.Clear();
            }
        }
    }
}
