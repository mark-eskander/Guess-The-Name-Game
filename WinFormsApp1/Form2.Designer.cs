namespace WinFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            CreateRoom = new Button();
            Options = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            Animals = new RadioButton();
            Vehicle = new RadioButton();
            Food = new RadioButton();
            groupBox1 = new GroupBox();
            Options.SuspendLayout();
            SuspendLayout();
            // 
            // CreateRoom
            // 
            CreateRoom.BackColor = Color.DarkGreen;
            resources.ApplyResources(CreateRoom, "CreateRoom");
            CreateRoom.ForeColor = SystemColors.ButtonHighlight;
            CreateRoom.Name = "CreateRoom";
            CreateRoom.UseVisualStyleBackColor = false;
            CreateRoom.Click += CreateRoom_Click;
            // 
            // Options
            // 
            Options.BackColor = SystemColors.HotTrack;
            Options.Controls.Add(label1);
            Options.Controls.Add(label2);
            Options.Controls.Add(Animals);
            Options.Controls.Add(Vehicle);
            Options.Controls.Add(Food);
            resources.ApplyResources(Options, "Options");
            Options.Name = "Options";
            Options.TabStop = false;
            Options.Enter += Options_Enter;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.MidnightBlue;
            label1.ForeColor = SystemColors.Control;
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.MidnightBlue;
            label2.ForeColor = Color.AliceBlue;
            label2.Name = "label2";
            label2.Click += label2_Click;
            // 
            // Animals
            // 
            resources.ApplyResources(Animals, "Animals");
            Animals.Name = "Animals";
            Animals.TabStop = true;
            Animals.UseVisualStyleBackColor = true;
            Animals.CheckedChanged += Animals_CheckedChanged;
            // 
            // Vehicle
            // 
            resources.ApplyResources(Vehicle, "Vehicle");
            Vehicle.Name = "Vehicle";
            Vehicle.TabStop = true;
            Vehicle.UseVisualStyleBackColor = true;
            Vehicle.CheckedChanged += Vehicle_CheckedChanged;
            // 
            // Food
            // 
            resources.ApplyResources(Food, "Food");
            Food.Name = "Food";
            Food.TabStop = true;
            Food.UseVisualStyleBackColor = true;
            Food.CheckedChanged += Food_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Highlight;
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CreateRoom);
            Controls.Add(groupBox1);
            Controls.Add(Options);
            MaximizeBox = false;
            Name = "Form2";
            Options.ResumeLayout(false);
            Options.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button CreateRoom;
        private GroupBox Options;
        private Label label2;
        private RadioButton Animals;
        private RadioButton Vehicle;
        private RadioButton Food;
        private GroupBox groupBox1;
        private Label label1;
    }
}