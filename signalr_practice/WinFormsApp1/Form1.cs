using Microsoft.AspNet.SignalR.Client;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        //to connect to  signalr (point to url of hub)(take instance of the hub)
       private HubConnection _connection;
        //create proxy
        private IHubProxy _chathub;
        public Form1()
        {
            InitializeComponent();
        }

        private void connection_Click(object sender, EventArgs e)
        {
            //make connection to hub
            _connection = new HubConnection("https://localhost:44387/");
            _chathub = _connection.CreateHubProxy("chat");

            _chathub.On("recieveMessage", msg => receivemsg(msg));

            _connection.Start().Wait();
            //connection.Enabled = false;

        }
        private void receivemsg(string msg)
        {
            //delegate
            listBox1.BeginInvoke(new Action(() => { listBox1.Items.Add(msg); }));
        }

        private void txtsend_Click(object sender, EventArgs e)
        {
            _chathub.Invoke("SendMessage", txtmsg.Text);
        }
    }
}