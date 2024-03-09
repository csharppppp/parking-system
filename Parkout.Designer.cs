namespace Parking
{
    partial class Parkout
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
            panel2 = new Panel();
            button1 = new Button();
            button4 = new Button();
            button2 = new Button();
            listOfVehicle = new FlowLayoutPanel();
            panel1 = new Panel();
            label8 = new Label();
            label7 = new Label();
            change = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            enterAmt = new TextBox();
            panel3 = new Panel();
            seeAll = new Button();
            button3 = new Button();
            searchVHTxt = new TextBox();
            flowPanelVH = new FlowLayoutPanel();
            panel4 = new Panel();
            flowPanel = new Panel();
            label3 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            flowPanelVH.SuspendLayout();
            flowPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(157, 352);
            panel2.Name = "panel2";
            panel2.Size = new Size(349, 56);
            panel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Font = new Font("Segoe UI", 13.8F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(127, 3);
            button1.Name = "button1";
            button1.Size = new Size(103, 43);
            button1.TabIndex = 0;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonFace;
            button4.Font = new Font("Segoe UI", 13.8F);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(236, 3);
            button4.Name = "button4";
            button4.Size = new Size(102, 43);
            button4.TabIndex = 11;
            button4.Text = "Pay";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.Font = new Font("Segoe UI", 13.8F);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(18, 4);
            button2.Name = "button2";
            button2.Size = new Size(103, 40);
            button2.TabIndex = 6;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // listOfVehicle
            // 
            listOfVehicle.AutoScroll = true;
            listOfVehicle.BorderStyle = BorderStyle.FixedSingle;
            listOfVehicle.Location = new Point(24, 100);
            listOfVehicle.Name = "listOfVehicle";
            listOfVehicle.Size = new Size(998, 106);
            listOfVehicle.TabIndex = 3;
            listOfVehicle.Paint += listOfVehicle_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(change);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(enterAmt);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(532, 251);
            panel1.Name = "panel1";
            panel1.Size = new Size(491, 441);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(192, 0, 0);
            label8.Location = new Point(210, 184);
            label8.Name = "label8";
            label8.Size = new Size(0, 23);
            label8.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(116, 180);
            label7.Name = "label7";
            label7.Size = new Size(79, 27);
            label7.TabIndex = 7;
            label7.Text = "Status:";
            // 
            // change
            // 
            change.AutoSize = true;
            change.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            change.Location = new Point(210, 115);
            change.Name = "change";
            change.Size = new Size(0, 23);
            change.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(101, 111);
            label5.Name = "label5";
            label5.Size = new Size(103, 27);
            label5.TabIndex = 4;
            label5.Text = "Changed:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Lime;
            label4.Location = new Point(210, 56);
            label4.Name = "label4";
            label4.Size = new Size(0, 27);
            label4.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(38, 56);
            label2.Name = "label2";
            label2.Size = new Size(166, 28);
            label2.TabIndex = 2;
            label2.Text = "TOTAL AMOUNT:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(33, 244);
            label1.Name = "label1";
            label1.Size = new Size(168, 31);
            label1.TabIndex = 1;
            label1.Text = "Entert Amount:";
            // 
            // enterAmt
            // 
            enterAmt.BackColor = Color.Black;
            enterAmt.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enterAmt.ForeColor = Color.Lime;
            enterAmt.Location = new Point(205, 244);
            enterAmt.Name = "enterAmt";
            enterAmt.Size = new Size(283, 61);
            enterAmt.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(seeAll);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(searchVHTxt);
            panel3.Location = new Point(24, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(999, 82);
            panel3.TabIndex = 5;
            // 
            // seeAll
            // 
            seeAll.BackColor = SystemColors.ButtonFace;
            seeAll.ForeColor = Color.Black;
            seeAll.Location = new Point(465, 42);
            seeAll.Name = "seeAll";
            seeAll.Size = new Size(74, 37);
            seeAll.TabIndex = 2;
            seeAll.Text = "see all";
            seeAll.UseVisualStyleBackColor = false;
            seeAll.Click += seeAll_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(363, 45);
            button3.Name = "button3";
            button3.Size = new Size(96, 34);
            button3.TabIndex = 1;
            button3.Text = "SEARCH";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // searchVHTxt
            // 
            searchVHTxt.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchVHTxt.Location = new Point(2, 45);
            searchVHTxt.Name = "searchVHTxt";
            searchVHTxt.PlaceholderText = "ENTER PLATE NO.";
            searchVHTxt.Size = new Size(349, 34);
            searchVHTxt.TabIndex = 0;
            // 
            // flowPanelVH
            // 
            flowPanelVH.Controls.Add(panel4);
            flowPanelVH.Location = new Point(-1, 17);
            flowPanelVH.Name = "flowPanelVH";
            flowPanelVH.Size = new Size(492, 486);
            flowPanelVH.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(474, 42);
            panel4.TabIndex = 2;
            // 
            // flowPanel
            // 
            flowPanel.BorderStyle = BorderStyle.FixedSingle;
            flowPanel.Controls.Add(flowPanelVH);
            flowPanel.Location = new Point(32, 251);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(494, 442);
            flowPanel.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(50, 234);
            label3.Name = "label3";
            label3.Size = new Size(165, 31);
            label3.TabIndex = 10;
            label3.Text = "Vehicle Details";
            // 
            // Parkout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 10, 75);
            ClientSize = new Size(1034, 704);
            Controls.Add(label3);
            Controls.Add(flowPanel);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(listOfVehicle);
            ForeColor = Color.White;
            Name = "Parkout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Parkout";
            Load += Parkout_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            flowPanelVH.ResumeLayout(false);
            flowPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Button button1;
        private FlowLayoutPanel listOfVehicle;
        private Panel panel1;
        private Panel panel3;
        private Button button3;
        private TextBox searchVHTxt;
        private Label label1;
        private FlowLayoutPanel flowPanelVH;
        private Panel panel4;
        private Panel flowPanel;
        private Label label3;
        private TextBox enterAmt;
        private Button button4;
        private Button button2;
        private Label label8;
        private Label label7;
        private Label change;
        private Label label5;
        private Label label4;
        private Label label2;
        private Button seeAll;
    }
}