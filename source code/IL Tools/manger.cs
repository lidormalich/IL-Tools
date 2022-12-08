using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace IL_Tools
{
    public partial class manger : Form
    {
        IFirebaseConfig confing = new FirebaseConfig
            {
                AuthSecret = "9OjqShSAzdpNLOGI6nNq1ckaHg9BiPrNWmMxsXjx",
                BasePath = "https://il-tools.firebaseio.com/"
            };
            IFirebaseClient client;


        public manger()
        {
            InitializeComponent();
        }

        private void manger_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(confing);
            if (client == null)
            {
                MessageBox.Show("חיבור לשרת נכשל - מבצע יציאה");
                this.Close();
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var data = new Data
            {
                Name = textBox1.Text,
                Key = textBox2.Text,
                date = textBox3.Text,
                mail = textBox4.Text,
                phone = textBox5.Text

            };

            SetResponse response = await client.SetTaskAsync("Information /" + textBox1.Text, data);
            Data result = response.ResultAs<Data>();
            MessageBox.Show("Data Id" + result.Name);
        }
    }
}
