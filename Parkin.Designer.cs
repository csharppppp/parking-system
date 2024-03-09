namespace Parking
{
    partial class Parkin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parkin));
            panel1 = new Panel();
            humBtn = new PictureBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            sidebar = new Panel();
            menuContainer = new FlowLayoutPanel();
            panel6 = new Panel();
            menu = new Button();
            panel7 = new Panel();
            button2 = new Button();
            panel8 = new Panel();
            parkout = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            btnAll = new Button();
            panel4 = new Panel();
            btnCleared = new Button();
            btnParked = new Button();
            panel5 = new Panel();
            panel12 = new Panel();
            button1 = new Button();
            searchVH = new TextBox();
            panel11 = new Panel();
            panel15 = new Panel();
            numCV = new Label();
            label14 = new Label();
            button4 = new Button();
            panel10 = new Panel();
            panel14 = new Panel();
            numPV = new Label();
            label9 = new Label();
            button3 = new Button();
            panel9 = new Panel();
            panel13 = new Panel();
            numV = new Label();
            label5 = new Label();
            logo = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)humBtn).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            sidebar.SuspendLayout();
            menuContainer.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel12.SuspendLayout();
            panel11.SuspendLayout();
            panel15.SuspendLayout();
            panel10.SuspendLayout();
            panel14.SuspendLayout();
            panel9.SuspendLayout();
            panel13.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(humBtn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1691, 57);
            panel1.TabIndex = 0;
            // 
            // humBtn
            // 
            humBtn.Image = (Image)resources.GetObject("humBtn.Image");
            humBtn.Location = new Point(6, 12);
            humBtn.Name = "humBtn";
            humBtn.Size = new Size(59, 39);
            humBtn.TabIndex = 2;
            humBtn.TabStop = false;
            humBtn.Click += humBtn_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1361, 658);
            flowLayoutPanel2.TabIndex = 1;
            flowLayoutPanel2.Click += flowLayoutPanel2_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(flowLayoutPanel2);
            panel2.Location = new Point(22, 306);
            panel2.Name = "panel2";
            panel2.Size = new Size(1367, 664);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.BackColor = Color.MidnightBlue;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(28, 239);
            panel3.Name = "panel3";
            panel3.Size = new Size(1310, 61);
            panel3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(599, 19);
            label1.Name = "label1";
            label1.Size = new Size(205, 28);
            label1.TabIndex = 11;
            label1.Text = "Departure Date/Time";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(1043, 19);
            label12.Name = "label12";
            label12.Size = new Size(67, 28);
            label12.TabIndex = 10;
            label12.Text = "Status";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(934, 19);
            label11.Name = "label11";
            label11.Size = new Size(86, 28);
            label11.TabIndex = 9;
            label11.Text = "Amount";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(828, 19);
            label10.Name = "label10";
            label10.Size = new Size(100, 28);
            label10.TabIndex = 8;
            label10.Text = "Time(h/s)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(377, 19);
            label8.Name = "label8";
            label8.Size = new Size(170, 28);
            label8.TabIndex = 6;
            label8.Text = "Arrival Date/Time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(250, 19);
            label4.Name = "label4";
            label4.Size = new Size(70, 28);
            label4.TabIndex = 2;
            label4.Text = "Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(140, 19);
            label3.Name = "label3";
            label3.Size = new Size(55, 28);
            label3.TabIndex = 1;
            label3.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 19);
            label2.Name = "label2";
            label2.Size = new Size(95, 28);
            label2.TabIndex = 0;
            label2.Text = "Plate No.";
            label2.Click += label2_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(22, 19, 75);
            sidebar.Controls.Add(menuContainer);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 57);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(235, 982);
            sidebar.TabIndex = 6;
            // 
            // menuContainer
            // 
            menuContainer.Controls.Add(panel6);
            menuContainer.Controls.Add(panel7);
            menuContainer.Controls.Add(panel8);
            menuContainer.Location = new Point(6, 3);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(241, 294);
            menuContainer.TabIndex = 7;
            // 
            // panel6
            // 
            panel6.BackgroundImageLayout = ImageLayout.None;
            panel6.Controls.Add(menu);
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(233, 66);
            panel6.TabIndex = 4;
            // 
            // menu
            // 
            menu.BackColor = Color.FromArgb(31, 28, 75);
            menu.BackgroundImageLayout = ImageLayout.None;
            menu.Cursor = Cursors.Hand;
            menu.FlatAppearance.BorderSize = 0;
            menu.FlatStyle = FlatStyle.Flat;
            menu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menu.ForeColor = Color.White;
            menu.Image = (Image)resources.GetObject("menu.Image");
            menu.ImageAlign = ContentAlignment.MiddleLeft;
            menu.Location = new Point(-3, -9);
            menu.Name = "menu";
            menu.Size = new Size(236, 75);
            menu.TabIndex = 3;
            menu.Text = "Menu";
            menu.UseVisualStyleBackColor = false;
            menu.Click += menu_Click;
            // 
            // panel7
            // 
            panel7.BackgroundImageLayout = ImageLayout.None;
            panel7.Controls.Add(button2);
            panel7.Location = new Point(3, 75);
            panel7.Name = "panel7";
            panel7.Size = new Size(233, 59);
            panel7.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(31, 28, 75);
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, -12);
            button2.Name = "button2";
            button2.Size = new Size(230, 87);
            button2.TabIndex = 3;
            button2.Text = "Parkin";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel8
            // 
            panel8.BackgroundImageLayout = ImageLayout.None;
            panel8.Controls.Add(parkout);
            panel8.Location = new Point(3, 140);
            panel8.Name = "panel8";
            panel8.Size = new Size(233, 66);
            panel8.TabIndex = 5;
            // 
            // parkout
            // 
            parkout.BackColor = Color.FromArgb(31, 28, 75);
            parkout.BackgroundImageLayout = ImageLayout.None;
            parkout.Cursor = Cursors.Hand;
            parkout.FlatAppearance.BorderSize = 0;
            parkout.FlatStyle = FlatStyle.Flat;
            parkout.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parkout.ForeColor = Color.White;
            parkout.Image = (Image)resources.GetObject("parkout.Image");
            parkout.ImageAlign = ContentAlignment.MiddleLeft;
            parkout.Location = new Point(0, -12);
            parkout.Name = "parkout";
            parkout.Size = new Size(233, 85);
            parkout.TabIndex = 3;
            parkout.Text = "Parkout";
            parkout.UseVisualStyleBackColor = false;
            parkout.Click += parkout_Click;
            // 
            // menuTransition
            // 
            menuTransition.Interval = 10;
            menuTransition.Tick += menuTransition_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // btnAll
            // 
            btnAll.Location = new Point(0, 3);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(94, 29);
            btnAll.TabIndex = 7;
            btnAll.Text = "All";
            btnAll.UseVisualStyleBackColor = true;
            btnAll.Click += btnAll_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.Controls.Add(btnCleared);
            panel4.Controls.Add(btnParked);
            panel4.Controls.Add(btnAll);
            panel4.Location = new Point(1041, 197);
            panel4.Name = "panel4";
            panel4.Size = new Size(297, 36);
            panel4.TabIndex = 8;
            // 
            // btnCleared
            // 
            btnCleared.Location = new Point(200, 3);
            btnCleared.Name = "btnCleared";
            btnCleared.Size = new Size(94, 29);
            btnCleared.TabIndex = 9;
            btnCleared.Text = "Cleared";
            btnCleared.UseVisualStyleBackColor = true;
            btnCleared.Click += btnCleared_Click;
            // 
            // btnParked
            // 
            btnParked.Location = new Point(100, 3);
            btnParked.Name = "btnParked";
            btnParked.Size = new Size(94, 29);
            btnParked.TabIndex = 8;
            btnParked.Text = "Parked";
            btnParked.UseVisualStyleBackColor = true;
            btnParked.Click += btnParked_Click;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.Controls.Add(panel12);
            panel5.Controls.Add(panel11);
            panel5.Controls.Add(panel10);
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(panel3);
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(panel2);
            panel5.Location = new Point(272, 54);
            panel5.Name = "panel5";
            panel5.Size = new Size(1416, 982);
            panel5.TabIndex = 9;
            // 
            // panel12
            // 
            panel12.Anchor = AnchorStyles.Top;
            panel12.Controls.Add(button1);
            panel12.Controls.Add(searchVH);
            panel12.Location = new Point(28, 172);
            panel12.Name = "panel12";
            panel12.Size = new Size(415, 61);
            panel12.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(293, 12);
            button1.Name = "button1";
            button1.Size = new Size(113, 43);
            button1.TabIndex = 1;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // searchVH
            // 
            searchVH.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchVH.Location = new Point(3, 12);
            searchVH.Name = "searchVH";
            searchVH.PlaceholderText = "Search Plate No.";
            searchVH.Size = new Size(284, 43);
            searchVH.TabIndex = 0;
            // 
            // panel11
            // 
            panel11.Anchor = AnchorStyles.Top;
            panel11.BackColor = Color.FromArgb(22, 19, 75);
            panel11.Controls.Add(panel15);
            panel11.Controls.Add(label14);
            panel11.Controls.Add(button4);
            panel11.Location = new Point(847, 15);
            panel11.Name = "panel11";
            panel11.Size = new Size(287, 125);
            panel11.TabIndex = 10;
            // 
            // panel15
            // 
            panel15.Controls.Add(numCV);
            panel15.Location = new Point(6, 75);
            panel15.Name = "panel15";
            panel15.Size = new Size(278, 42);
            panel15.TabIndex = 15;
            // 
            // numCV
            // 
            numCV.AutoSize = true;
            numCV.Dock = DockStyle.Right;
            numCV.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numCV.ForeColor = Color.White;
            numCV.Location = new Point(244, 0);
            numCV.Name = "numCV";
            numCV.Size = new Size(34, 37);
            numCV.TabIndex = 0;
            numCV.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(115, 32);
            label14.Name = "label14";
            label14.Size = new Size(146, 28);
            label14.TabIndex = 14;
            label14.Text = "Cleared Vihicle";
            // 
            // button4
            // 
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(3, 7);
            button4.Name = "button4";
            button4.Size = new Size(87, 48);
            button4.TabIndex = 13;
            button4.Text = "Logo";
            button4.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Top;
            panel10.BackColor = Color.FromArgb(22, 19, 75);
            panel10.Controls.Add(panel14);
            panel10.Controls.Add(label9);
            panel10.Controls.Add(button3);
            panel10.Location = new Point(527, 12);
            panel10.Name = "panel10";
            panel10.Size = new Size(287, 125);
            panel10.TabIndex = 10;
            // 
            // panel14
            // 
            panel14.Controls.Add(numPV);
            panel14.Location = new Point(6, 75);
            panel14.Name = "panel14";
            panel14.Size = new Size(278, 42);
            panel14.TabIndex = 15;
            // 
            // numPV
            // 
            numPV.AutoSize = true;
            numPV.Dock = DockStyle.Right;
            numPV.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numPV.ForeColor = Color.White;
            numPV.Location = new Point(244, 0);
            numPV.Name = "numPV";
            numPV.Size = new Size(34, 37);
            numPV.TabIndex = 0;
            numPV.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(116, 27);
            label9.Name = "label9";
            label9.Size = new Size(145, 28);
            label9.TabIndex = 14;
            label9.Text = "Parked Vehicle";
            // 
            // button3
            // 
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(3, 7);
            button3.Name = "button3";
            button3.Size = new Size(87, 48);
            button3.TabIndex = 13;
            button3.Text = "Logo";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Top;
            panel9.BackColor = Color.FromArgb(22, 19, 75);
            panel9.Controls.Add(panel13);
            panel9.Controls.Add(label5);
            panel9.Controls.Add(logo);
            panel9.Location = new Point(201, 15);
            panel9.Name = "panel9";
            panel9.Size = new Size(287, 125);
            panel9.TabIndex = 9;
            // 
            // panel13
            // 
            panel13.Controls.Add(numV);
            panel13.Location = new Point(6, 80);
            panel13.Name = "panel13";
            panel13.Size = new Size(278, 42);
            panel13.TabIndex = 12;
            // 
            // numV
            // 
            numV.AutoSize = true;
            numV.Dock = DockStyle.Right;
            numV.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numV.ForeColor = Color.White;
            numV.Location = new Point(244, 0);
            numV.Name = "numV";
            numV.Size = new Size(34, 37);
            numV.TabIndex = 0;
            numV.Text = "0";
            numV.Click += numV_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(186, 32);
            label5.Name = "label5";
            label5.Size = new Size(77, 28);
            label5.TabIndex = 1;
            label5.Text = "Vehicle";
            // 
            // logo
            // 
            logo.BackgroundImageLayout = ImageLayout.None;
            logo.FlatStyle = FlatStyle.Flat;
            logo.Location = new Point(3, 12);
            logo.Name = "logo";
            logo.Size = new Size(87, 48);
            logo.TabIndex = 0;
            logo.Text = "Logo";
            logo.UseVisualStyleBackColor = true;
            // 
            // Parkin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 19, 64);
            Controls.Add(panel5);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            Name = "Parkin";
            Size = new Size(1691, 1039);
            Load += Parkin_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)humBtn).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            sidebar.ResumeLayout(false);
            menuContainer.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel2;
        private Panel panel3;
        private Label label11;
        private Label label10;
        private Label label8;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label12;
        private Panel sidebar;
        private FlowLayoutPanel menuContainer;
        private Panel panel6;
        private Button menu;
        private Panel panel7;
        private Button button2;
        private Panel panel8;
        private Button parkout;
        private PictureBox humBtn;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private Label label1;
        private Button btnAll;
        private Panel panel4;
        private Button btnCleared;
        private Button btnParked;
        private Panel panel5;
        private Panel panel12;
        private Button button1;
        private TextBox searchVH;
        private Panel panel11;
        private Panel panel10;
        private Panel panel9;
        private Button logo;
        private Panel panel15;
        private Label numCV;
        private Label label14;
        private Button button4;
        private Panel panel14;
        private Label numPV;
        private Label label9;
        private Button button3;
        private Panel panel13;
        private Label numV;
        private Label label5;
    }
}
