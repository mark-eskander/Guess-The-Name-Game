namespace server
{
    public partial class Form1 : Form
    {
        private serverclass ServerInstance;

        public Form1()
        {
            InitializeComponent();
            ServerInstance = new serverclass();
        }

        private void StartServer_Click(object sender, EventArgs e)
        {
            ServerInstance.StartServer();
            StartServer.Enabled = false;
            StartServer.Text = "Server Is Running Now!";
        }
    }
}
