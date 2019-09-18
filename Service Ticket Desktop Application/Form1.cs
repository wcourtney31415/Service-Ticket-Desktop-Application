using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service_Ticket_Desktop_Application
{
    public partial class Form1 : Form
    {
        List<String> inventory = new List<String>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            WebRequest webRequest = WebRequest.Create("http://localhost/client?phoneNumber=" + txtSearchPhoneNumber.Text);

            ASCIIEncoding encoding = new ASCIIEncoding();
            webRequest.Method = "GET";
            webRequest.ContentType = "application/json";
           
            WebResponse webResp = webRequest.GetResponse();

            Stream objWebResp = webResp.GetResponseStream();
            StreamReader sr = new StreamReader(objWebResp);
            String json = sr.ReadLine();
            Console.WriteLine(json);
            List<Client> clients = JsonConvert.DeserializeObject<List<Client>>(json);
            lstExistingClients.Items.Clear();
            foreach (Client client in clients)
            {
                lstExistingClients.Items.Add(client.firstName + " " + client.lastName);
            }
            rdoExistingClient.Enabled = true;
            rdoNewClient.Enabled = true;
            rdoExistingClient.Checked = true;
            txtPhoneNumber.Text = txtSearchPhoneNumber.Text;

        }

        private void RdoExistingClient_CheckedChanged(object sender, EventArgs e)
        {
            grpExistingClient.Enabled = rdoExistingClient.Checked;
        }

        private void RdoNewClient_CheckedChanged(object sender, EventArgs e)
        {
            grpNewClient.Enabled = rdoNewClient.Checked;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            dteDateIn.Value = DateTime.Now;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            char clearText = '\0';
            char mask = '*';
            if (txtPassword.PasswordChar == clearText)
            {
                txtPassword.PasswordChar = mask;
                btnShowHidePassword.Text = "Show";
            } else
            {
                txtPassword.PasswordChar = clearText;
                btnShowHidePassword.Text = "Hide";
            }
            
        }

        private void updateInvenory ()
        {
            lstInventory.Items.Clear();
            foreach (String item in inventory)
            {
                lstInventory.Items.Add(item);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            String item = txtInventoryItem.Text;
            inventory.Add(item);
            updateInvenory();
            txtInventoryItem.Text = "";
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
