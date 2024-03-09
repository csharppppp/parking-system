namespace Parking
{
    partial class ParkingEntry
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
            components = new System.ComponentModel.Container();
            palteNo = new Label();
            plateNo = new TextBox();
            type = new Label();
            model = new Label();
            comboBoxModel = new ComboBox();
            driver = new TextBox();
            label5 = new Label();
            comboBoxType = new ComboBox();
            phoneNo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dateDepart = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // palteNo
            // 
            palteNo.AutoSize = true;
            palteNo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            palteNo.ForeColor = Color.White;
            palteNo.Location = new Point(44, 134);
            palteNo.Name = "palteNo";
            palteNo.Size = new Size(95, 28);
            palteNo.TabIndex = 0;
            palteNo.Text = "Plate No.";
            // 
            // plateNo
            // 
            plateNo.Location = new Point(148, 134);
            plateNo.Name = "plateNo";
            plateNo.Size = new Size(352, 27);
            plateNo.TabIndex = 1;
            // 
            // type
            // 
            type.AutoSize = true;
            type.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            type.ForeColor = Color.White;
            type.Location = new Point(41, 200);
            type.Name = "type";
            type.Size = new Size(55, 28);
            type.TabIndex = 2;
            type.Text = "Type";
            // 
            // model
            // 
            model.AutoSize = true;
            model.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            model.ForeColor = Color.White;
            model.Location = new Point(38, 277);
            model.Name = "model";
            model.Size = new Size(70, 28);
            model.TabIndex = 4;
            model.Text = "Model";
            // 
            // comboBoxModel
            // 
            comboBoxModel.FormattingEnabled = true;
            comboBoxModel.Location = new Point(148, 277);
            comboBoxModel.Name = "comboBoxModel";
            comboBoxModel.Size = new Size(350, 28);
            comboBoxModel.TabIndex = 5;
            comboBoxModel.SelectedIndexChanged += comboBoxModel_SelectedIndexChanged;
            // 
            // driver
            // 
            driver.Location = new Point(716, 131);
            driver.Name = "driver";
            driver.Size = new Size(352, 27);
            driver.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(607, 130);
            label5.Name = "label5";
            label5.Size = new Size(66, 28);
            label5.TabIndex = 8;
            label5.Text = "Driver";
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(148, 204);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(350, 28);
            comboBoxType.TabIndex = 10;
            comboBoxType.SelectedIndexChanged += comboBoxType_SelectedIndexChanged;
            // 
            // phoneNo
            // 
            phoneNo.Location = new Point(716, 205);
            phoneNo.Name = "phoneNo";
            phoneNo.Size = new Size(352, 27);
            phoneNo.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(607, 204);
            label1.Name = "label1";
            label1.Size = new Size(104, 28);
            label1.TabIndex = 11;
            label1.Text = "Phone No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(607, 277);
            label2.Name = "label2";
            label2.Size = new Size(203, 28);
            label2.TabIndex = 13;
            label2.Text = "Date/Time departure";
            // 
            // dateDepart
            // 
            dateDepart.Format = DateTimePickerFormat.Time;
            dateDepart.Location = new Point(716, 329);
            dateDepart.Name = "dateDepart";
            dateDepart.Size = new Size(276, 27);
            dateDepart.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(898, 426);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 16;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(998, 426);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 17;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            // 
            // ParkingEntry
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 22, 71);
            ClientSize = new Size(1182, 635);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateDepart);
            Controls.Add(label2);
            Controls.Add(phoneNo);
            Controls.Add(label1);
            Controls.Add(comboBoxType);
            Controls.Add(palteNo);
            Controls.Add(plateNo);
            Controls.Add(driver);
            Controls.Add(label5);
            Controls.Add(comboBoxModel);
            Controls.Add(model);
            Controls.Add(type);
            Name = "ParkingEntry";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ParikingEntry";
            Load += ParkingEntry_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label palteNo;
        private TextBox plateNo;
        private Label type;
        private Label model;
        private ComboBox comboBoxModel;
        private TextBox driver;
        private Label label5;
        private ComboBox comboBoxType;
        private TextBox phoneNo;
        private Label label1;
        private Label label2;
        private DateTimePicker dateDepart;
        private Button button1;
        private Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer sidebarTransition;
    }
}