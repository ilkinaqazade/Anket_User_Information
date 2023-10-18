using System;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Drawing;

namespace Anket_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadUsersFromJson();

            this.BackColor = Color.FromArgb(57, 64, 83);
            foreach (Control control in Controls)
            {
                if (control is GroupBox)
                {
                    GroupBox groupBox = (GroupBox)control;

                    foreach (Control innerControl in groupBox.Controls)
                    {
                        if (innerControl is Label)
                        {
                            Label label = (Label)innerControl;
                            label.ForeColor = Color.FromArgb(253, 240, 213);
                        }
                    }
                }
                if (control is Label)
                {
                    Label label = (Label)control;
                    label.ForeColor = System.Drawing.Color.FromArgb(253, 240, 213);
                }
            }
            

        }

        private void LoadUsersFromJson()
        {
            string jsonFilePath = "userInfo.json";
            if (File.Exists(jsonFilePath))
            {
                string[] lines = File.ReadAllLines(jsonFilePath);

                foreach (string line in lines)
                {
                    Userİnfo veri = JsonConvert.DeserializeObject<Userİnfo>(line);
                    userSaverLog.Items.Add(veri.Name);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string saveName = fileSaveTxtbox.Text;

            if (!string.IsNullOrWhiteSpace(saveName))
            {
                userSaverLog.Items.Add(saveName);
                
            }
            else
            {
                MessageBox.Show("Enter a save name !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {


            string selectedUser = userSaverLog.SelectedItem as string;

            if (selectedUser != null)
            {
                Userİnfo veri = new Userİnfo
                {
                    Name = nameTxtbox.Text,
                    Sorname = surnameTxtbox.Text,
                    Mail = mailTxtbox.Text,
                    Tel = telTxtbox.Text,
                    Birthday = birthdayTxtbox.Text,
                };


                string jsonData = JsonConvert.SerializeObject(veri);
                File.AppendAllText("userInfo.json", jsonData + Environment.NewLine);
                MessageBox.Show("Secsefull User Save", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void loadBtr_Click(object sender, EventArgs e)
        {
            string selectedUser = userSaverLog.SelectedItem as string;

            if (selectedUser != null)
            {
                string jsonFilePath = "userInfo.json";
                string[] lines = File.ReadAllLines(jsonFilePath);

                foreach (string line in lines)
                {
                    Userİnfo veri = JsonConvert.DeserializeObject<Userİnfo>(line);

                    if (veri.Name == selectedUser)
                    {
                        nameTxtbox.Text = veri.Name;
                        surnameTxtbox.Text = veri.Sorname;
                        mailTxtbox.Text = veri.Mail;
                        telTxtbox.Text = veri.Tel;
                        birthdayTxtbox.Text = veri.Birthday;
                        break; 
                    }
                }
            }
            else
            {
                MessageBox.Show("Select User.", "Worning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void changeBtr_Click(object sender, EventArgs e)
        {
            string selectedUser = userSaverLog.SelectedItem as string;

            if (selectedUser != null)
            {
                string jsonFilePath = "userInfo.json";
                string[] lines = File.ReadAllLines(jsonFilePath);

                List<string> updatedLines = new List<string>();

                foreach (string line in lines)
                {
                    Userİnfo veri = JsonConvert.DeserializeObject<Userİnfo>(line);

                    if (veri.Name == selectedUser)
                    {

                        veri.Name = nameTxtbox.Text;
                        veri.Sorname = surnameTxtbox.Text;
                        veri.Mail = mailTxtbox.Text;
                        veri.Tel = telTxtbox.Text;
                        veri.Birthday = birthdayTxtbox.Text;
                    }

                    string updatedData = JsonConvert.SerializeObject(veri);
                    updatedLines.Add(updatedData);
                }

                File.WriteAllLines(jsonFilePath, updatedLines);

                MessageBox.Show("User information has been updated successfully.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Select User", "worning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

    public class Userİnfo
    {
        public string Name { get; set; }
        public string Sorname { get; set; }
        public string Mail { get; set; }
        public string Tel { get; set; }
        public string Birthday { get; set; }
    }
}
