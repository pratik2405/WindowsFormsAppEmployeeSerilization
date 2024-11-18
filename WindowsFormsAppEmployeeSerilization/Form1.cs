using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//for Binary serialization
using System.Runtime.Serialization.Formatters.Binary;

//For XMl File
using System.Xml.Serialization;

//For SOAP File
using System.Runtime.Serialization.Formatters.Soap;

//For JSON file
using System.Text.Json;

using System.IO;

namespace WindowsFormsAppEmployeeSerilization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBinaryWriter_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\Serilization\EmpBinaryDemo.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter binaryFormatter = new BinaryFormatter();

                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(txtId.Text);
                emp.Name = txtName.Text;
                emp.Salary = Convert.ToInt32(txtSalary.Text);

                binaryFormatter.Serialize(fs, emp);
                fs.Close();

                MessageBox.Show("Done");
                txtId.Clear();
                txtName.Clear();
                txtSalary.Clear();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\Serilization\EmpBinaryDemo.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Employee emp = new Employee();
                emp = (Employee)binaryFormatter.Deserialize(fs);
                txtId.Text = emp.Id.ToString();
                txtName.Text = emp.Name.ToString();
                txtSalary.Text = emp.Salary.ToString();
                fs.Close();
            }
            catch (Exception ex) 
            {
                    MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtSalary.Clear();
        }

        private void btnXMLWriter_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\Serilization\EmpXMLDemo.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer serializer = new XmlSerializer(typeof(Employee));

                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(txtId.Text);
                emp.Name = txtName.Text;
                emp.Salary = Convert.ToInt32(txtSalary.Text);

                serializer.Serialize(fs, emp);
                fs.Close();

                MessageBox.Show("Done");
                txtId.Clear();
                txtName.Clear();
                txtSalary.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXMLRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\Serilization\EmpXMlDemo.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer serializer=new XmlSerializer(typeof(Employee));
                Employee emp = new Employee();
                emp = (Employee)serializer.Deserialize(fs);
                txtId.Text = emp.Id.ToString();
                txtName.Text = emp.Name.ToString();
                txtSalary.Text = emp.Salary.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSOAPWriter_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\Serilization\EmpSOAPDemo.soap", FileMode.Create, FileAccess.Write);
                SoapFormatter soapFormatter = new SoapFormatter();

                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(txtId.Text);
                emp.Name = txtName.Text;
                emp.Salary = Convert.ToInt32(txtSalary.Text);

                soapFormatter.Serialize(fs, emp);
                fs.Close();

                MessageBox.Show("Done");
                txtId.Clear();
                txtName.Clear();
                txtSalary.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSOAPRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\Serilization\EmpSOAPDemo.soap", FileMode.Open, FileAccess.Read);
               SoapFormatter soapFormatter=new SoapFormatter();
                Employee emp = new Employee();
                emp = (Employee)soapFormatter.Deserialize(fs);
                txtId.Text = emp.Id.ToString();
                txtName.Text = emp.Name.ToString();
                txtSalary.Text = emp.Salary.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJSONWriter_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\Serilization\EmpJSONDemo.json", FileMode.Create, FileAccess.Write);
               
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(txtId.Text);
                emp.Name = txtName.Text;
                emp.Salary = Convert.ToInt32(txtSalary.Text);

                JsonSerializer.Serialize<Employee>(fs, emp);
                fs.Close();

                MessageBox.Show("Done");
                txtId.Clear();
                txtName.Clear();
                txtSalary.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJSONReader_Click(object sender, EventArgs e)
        {

            try
            {
                FileStream fs = new FileStream(@"D:\Serilization\EmpJSONDemo.json", FileMode.Open, FileAccess.Read);
                
                Employee emp = new Employee();
                emp = JsonSerializer.Deserialize<Employee>(fs);
                txtId.Text = emp.Id.ToString();
                txtName.Text = emp.Name.ToString();
                txtSalary.Text = emp.Salary.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
