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
    }
}
