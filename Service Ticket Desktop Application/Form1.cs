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
            WebRequest webRequest = WebRequest.Create("http://localhost/client");

            ASCIIEncoding encoding = new ASCIIEncoding();
            webRequest.Method = "GET";
            webRequest.ContentType = "application/json";
           
            WebResponse webResp = webRequest.GetResponse();

            Stream objWebResp = webResp.GetResponseStream();
            StreamReader sr = new StreamReader(objWebResp);
            String json = sr.ReadLine();
            Console.WriteLine(json);
            List<Client> clients = JsonConvert.DeserializeObject<List<Client>>(json);
            foreach(Client client in clients)
            {
                listBox1.Items.Add(client.lastName + ", " + client.firstName + ": " + client.phoneNumber);
            }
        }
    }
}
