using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;

namespace Winform
{
    public partial class Form1 : Form
    {
        public HttpClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtIDProduit_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:59718/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("Produits/Create"));
            var response = client.GetAsync(System.Configuration.ConfigurationSettings.AppSettings["UrlMethod"] + string.Format("a={0}&b={1}", 4, 8)).Result;

        }

        private void btnSelecte_Click(object sender, EventArgs e)
        {
            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("http://localhost:59718/");
            //HttpResponseMessage response = client.GetAsync("Produits/Create").Result;
            //var prod = response.Content.ReadAsAsync<IEnumerable<Produit>>().Result;
            //DgProduit.DataSource = prod;
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
