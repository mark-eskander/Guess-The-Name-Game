using System;
using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        private client ClientInstance;
        string randomWord;

        Random rand = new Random();
        int intRoomNumber;
        Rooms rm = new Rooms();
        public Form2(client clientInstance)
        {
            InitializeComponent();

            ClientInstance = clientInstance;
            ClientInstance.OnMessageReceive += OnResponseForm2;

            Options.Visible = false;
            label1.Text = clientInstance.ClientName;
            intRoomNumber = clientInstance.RoomNumber;
            DrawRooms();
        }

        private void OnResponseForm2(string s)
        {
        }

        public void DrawRooms()
        {
            groupBox1.Controls.Clear();

            FlowLayoutPanel container = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                AutoSize = true,
                Location = new Point(40,40),
                Width = groupBox1.Width - 20
            };

            for (int i = 0; i < intRoomNumber; i++)
            {
                Panel panel = new Panel
                {
                    Size = new Size(320, 50), 
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle
                };

                Label roomLabel = new Label
                {
                    Text = $"Room ID: {i + 1}",
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    Location = new Point(10, 15),
                    AutoSize = true
                };

                Button watchButton = new Button
                {
                    Text = "Watch",
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    Size = new Size(80, 30),
                    Location = new Point(140, 10) 
                };

                Button joinButton = new Button
                {
                    Text = "Join",
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    Size = new Size(80, 30),
                    Location = new Point(230, 10) 
                };

                watchButton.Name = $"watchButton{i}";
                joinButton.Name = $"joinButton{i}";

                watchButton.Click += WatchButtonClick;
                joinButton.Click += JoinButtonClick;

          
                panel.Controls.Add(roomLabel);
                panel.Controls.Add(watchButton);
                panel.Controls.Add(joinButton);

         
                container.Controls.Add(panel);
            }

            groupBox1.Controls.Add(container);
        }



        private void JoinButtonClick(object sender, EventArgs e)
        {
            ClientInstance.Flag2 = false;
            ClientInstance.MessageFromserver = "";
            Button joinButton = (Button)sender;
            int roomId = int.Parse(joinButton.Name.Replace("joinButton", ""));
            ClientInstance.RoomId = roomId;
            ClientInstance.ClientState = "Player";
            ClientInstance.SendMessageToServer($"2,{ClientInstance.ClientId},{roomId},{ClientInstance.ClientName}");
            MessageBox.Show("Please Wait a minute");

            while (ClientInstance.Flag2 == false && ClientInstance.MessageFromserver == "")
            {

            }
            if (ClientInstance.MessageFromserver == "Accepted")
            {
                GameRoom gm = new GameRoom(ClientInstance);
                ClientInstance.gameRoomInClientThread = gm;

                gm.Show();
            }
            this.Hide();

        }

        private void WatchButtonClick(object sender, EventArgs e)
        {
            Button watchButton = (Button)sender;
            int roomId = int.Parse(watchButton.Name.Replace("watchButton", ""));
            ClientInstance.RoomId = roomId;
            ClientInstance.ClientState = "Watcher";
            ClientInstance.SendMessageToServer($"3,{ClientInstance.ClientId},{roomId}");
            MessageBox.Show("Please Wait a minute");
            GameRoom gm = new GameRoom(ClientInstance);
            ClientInstance.gameRoomInClientThread = gm;
            gm.Show();
            this.Hide();

        }


        private void CreateRoom_Click(object sender, EventArgs e)
        {
            Options.Visible = true;
        }

        private void Animals_CheckedChanged(object sender, EventArgs e)
        {
            ClientInstance.FlagToStartPlay = false;
            string filePath = @"D:\ITI\C#\Guess The Name\Animals.txt";
            string[] AnimalWords = File.ReadAllLines(filePath);
            randomWord = AnimalWords[rand.Next(AnimalWords.Length)];

            int RoomId = ClientInstance.RoomNumber;
            ClientInstance.SendMessageToServer($"1,{ClientInstance.ClientId},{RoomId},Animals,{randomWord},{ClientInstance.ClientName}");
            ClientInstance.ClientState = "Host";
            ClientInstance.RandomWord = randomWord;
            ClientInstance.RoomId = intRoomNumber;

            rm.Id = intRoomNumber;
            rm.RandomWord = randomWord;
            rm.Player1ID = ClientInstance.ClientId;

            GameRoom GameForm = new GameRoom(ClientInstance);
            ClientInstance.gameRoomInClientThread = GameForm;
            ClientInstance.gameRoomInClientThread2 = GameForm;
            GameForm.Show();
            this.Hide();
        }
        private void Food_CheckedChanged(object sender, EventArgs e)
        {
            ClientInstance.FlagToStartPlay = false;
            string filePath = @"D:\ITI\C#\Guess The Name\Food.txt";
            string[] AnimalWords = File.ReadAllLines(filePath);
            randomWord = AnimalWords[rand.Next(AnimalWords.Length)];

            int RoomId = ClientInstance.RoomNumber;
            ClientInstance.SendMessageToServer($"1,{ClientInstance.ClientId},{RoomId},Food,{randomWord},{ClientInstance.ClientName}");
            ClientInstance.ClientState = "Host";
            ClientInstance.RandomWord = randomWord;
            ClientInstance.RoomId = intRoomNumber;

            rm.Id = intRoomNumber;
            rm.RandomWord = randomWord;
            rm.Player1ID = ClientInstance.ClientId;

            GameRoom GameForm = new GameRoom(ClientInstance);
            ClientInstance.gameRoomInClientThread = GameForm;
            ClientInstance.gameRoomInClientThread2 = GameForm;
            GameForm.Show();
            this.Hide();
        }

        private void Vehicle_CheckedChanged(object sender, EventArgs e)
        {
            ClientInstance.FlagToStartPlay = false;
            string filePath = @"D:\ITI\C#\Guess The Name\Vehicles.txt";
            string[] AnimalWords = File.ReadAllLines(filePath);
            randomWord = AnimalWords[rand.Next(AnimalWords.Length)];

            int RoomId = ClientInstance.RoomNumber;
            ClientInstance.SendMessageToServer($"1,{ClientInstance.ClientId},{RoomId},Vehicle,{randomWord},{ClientInstance.ClientName}");
            ClientInstance.ClientState = "Host";
            ClientInstance.RandomWord = randomWord;
            ClientInstance.RoomId = intRoomNumber;

            rm.Id = intRoomNumber;
            rm.RandomWord = randomWord;
            rm.Player1ID = ClientInstance.ClientId;

            GameRoom GameForm = new GameRoom(ClientInstance);
            ClientInstance.gameRoomInClientThread = GameForm;
            ClientInstance.gameRoomInClientThread2 = GameForm;
            GameForm.Show();
            this.Hide();
        }

        private void Options_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
