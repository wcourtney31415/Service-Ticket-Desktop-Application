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
    public partial class frmNewTicket : Form
    {
        List<String> inventory = new List<String>();
        public frmNewTicket()
        {
            InitializeComponent();
        }
        List<Client> clients = new List<Client>();
        private void UpdateClientList()
        {
            lstExistingClients.Items.Clear();
            foreach (Client client in clients)
            {
                lstExistingClients.Items.Add(client.firstName + " " + client.lastName);
            }
        }
        private void BtnFindByPhone_Click(object sender, EventArgs e)
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
            clients = JsonConvert.DeserializeObject<List<Client>>(json);
            lstExistingClients.Items.Clear();
            UpdateClientList();
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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnToday_Click(object sender, EventArgs e)
        {
            dteDateIn.Value = DateTime.Now;
        }

        private void BtnShowHidePassword_Click(object sender, EventArgs e)
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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            String item = txtInventoryItem.Text;
            inventory.Add(item);
            updateInvenory();
            txtInventoryItem.Text = "";
            txtInventoryItem.Focus();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            int index = lstInventory.SelectedIndex;
            if (index > -1)
            {
                inventory.RemoveAt(index);
            }
            updateInvenory();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtSearchPhoneNumber.Clear();
            dteDateIn.Value = DateTime.Now;
            txtPassword.Clear();
            inventory.Clear();
            updateInvenory();
            txtDescription.Clear();
            clients.Clear();
            bool previousState = lstExistingClients.Enabled;
            lstExistingClients.Enabled = true;
            UpdateClientList();
            lstExistingClients.Enabled = previousState;
            rdoExistingClient.Checked = false;
            rdoNewClient.Checked = false;
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhoneNumber.Clear();
            
            txtInventoryItem.Clear();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {


            if (rdoExistingClient.Enabled)
            {
                int index = lstExistingClients.SelectedIndex;
                if (index > -1)
                {
                    Client client = clients.ElementAt(index);
                    string json = JsonConvert.SerializeObject(client, Formatting.Indented);
                    Console.WriteLine(json);
                }
                
            }
            else if (rdoNewClient.Enabled)
            {
                Client client = new Client();
                client.firstName = txtFirstName.Text;
                client.lastName = txtLastName.Text;
                client.phoneNumber = txtPhoneNumber.Text;
                string json = JsonConvert.SerializeObject(client, Formatting.Indented);
                Console.WriteLine(json);
            }

            
        }
    }
}
