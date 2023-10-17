using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minefort_Server_Keeper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async Task CallServer()
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest("https://api.minefort.com/v1/server/"+ServerID.Text+"/start");
                request.AddHeader("Cookie", Cookie.Text);
                var response = await client.PostAsync(request);


                StatusLabel.Text = "Status: Running!";
                Log("Successfully Started", "Server");
                var data = @"{
                    ""command"": ""ping""
                }";

                var client2 = new RestClient();
                var request2 = new RestRequest("https://api.minefort.com/v1/server/"+ServerID.Text+"/command");
                request2.AddHeader("Cookie", Cookie.Text);
                request2.AddBody(data);


                var response2 = await client2.PostAsync(request2);
            }
            catch
            {
                StatusLabel.Text = "Status: Running";
                Log("Ping Failed, Already Running", "Server");
            }
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            await CallServer();
        }

        private async void Log(string Text, string Type)
        {
            ConsoleBox.Text += $"[{Type}] {Text}{Environment.NewLine}";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Log("User began Keeper", "Server");
            await CallServer();
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            StatusLabel.Text = "Status: Not Running";
        }
    }
}
