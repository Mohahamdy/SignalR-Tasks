using Microsoft.AspNetCore.SignalR.Client;

namespace SignalRClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        HubConnection con;
        private void Form1_Load(object sender, EventArgs e)
        {
            con = new HubConnectionBuilder().WithUrl("http://localhost:8090/chat").Build();

            con.StartAsync();

            con.On<string, string>("notifygroup", (string n, string g) => lb_messages.Invoke(() => lb_messages.Items.Add(n+" Joined "+g)));

            con.On<string, string, string>("sendtogroup", (string g, string m, string n) => lb_messages.Invoke(() => lb_messages.Items.Add($"{n}({g}): {m}")));
        }

        private void btn_join_Click(object sender, EventArgs e)
        {
            con.InvokeAsync("joingroup", txt_group.Text, txt_name.Text);
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            con.InvokeAsync("sendmesstogroup",txt_group.Text,txt_mess.Text,txt_name.Text);
        }
    }
}
