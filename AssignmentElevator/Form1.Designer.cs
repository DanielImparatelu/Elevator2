namespace AssignmentElevator//auto-generated code by Windows Form
{
    partial class Form1
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
        /// Required method for Designer support - do not mhoodify
        /// the contents of this metd with the code editor.
        /// </summary>
        private void InitializeComponent()//creates new instances of all the objects in my program
        {                                   //and inintialises them with their specific properties
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.control_group_up = new System.Windows.Forms.GroupBox();
            this.control_panel_label = new System.Windows.Forms.Label();
            this.control_down = new System.Windows.Forms.Button();
            this.control_up = new System.Windows.Forms.Button();
            this.btn_log = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.clear_button = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.control_floor1 = new System.Windows.Forms.PictureBox();
            this.control_floor0 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.floor_display_label = new System.Windows.Forms.Label();
            this.display_floor0 = new System.Windows.Forms.PictureBox();
            this.display_floor1 = new System.Windows.Forms.PictureBox();
            this.request_down = new System.Windows.Forms.Button();
            this.request_up = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.control_group_up.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.control_floor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.control_floor0)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_floor0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_floor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(577, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(357, 225);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // control_group_up
            // 
            this.control_group_up.Controls.Add(this.pictureBox2);
            this.control_group_up.Controls.Add(this.control_floor1);
            this.control_group_up.Controls.Add(this.control_floor0);
            this.control_group_up.Controls.Add(this.control_panel_label);
            this.control_group_up.Controls.Add(this.control_down);
            this.control_group_up.Controls.Add(this.control_up);
            this.control_group_up.Location = new System.Drawing.Point(352, 15);
            this.control_group_up.Name = "control_group_up";
            this.control_group_up.Size = new System.Drawing.Size(142, 238);
            this.control_group_up.TabIndex = 3;
            this.control_group_up.TabStop = false;
            this.control_group_up.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // control_panel_label
            // 
            this.control_panel_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.control_panel_label.AutoSize = true;
            this.control_panel_label.Location = new System.Drawing.Point(34, 0);
            this.control_panel_label.Name = "control_panel_label";
            this.control_panel_label.Size = new System.Drawing.Size(70, 13);
            this.control_panel_label.TabIndex = 2;
            this.control_panel_label.Text = "Control Panel";
            // 
            // control_down
            // 
            this.control_down.Location = new System.Drawing.Point(17, 198);
            this.control_down.Name = "control_down";
            this.control_down.Size = new System.Drawing.Size(75, 23);
            this.control_down.TabIndex = 1;
            this.control_down.Text = "Floor 0";
            this.control_down.UseVisualStyleBackColor = true;
            this.control_down.Click += new System.EventHandler(this.control_down_Click);
            // 
            // control_up
            // 
            this.control_up.Location = new System.Drawing.Point(17, 161);
            this.control_up.Name = "control_up";
            this.control_up.Size = new System.Drawing.Size(75, 23);
            this.control_up.TabIndex = 0;
            this.control_up.Text = "Floor 1";
            this.control_up.UseVisualStyleBackColor = true;
            this.control_up.Click += new System.EventHandler(this.control_up_Click);
            // 
            // btn_log
            // 
            this.btn_log.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_log.Location = new System.Drawing.Point(577, 272);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(75, 23);
            this.btn_log.TabIndex = 4;
            this.btn_log.Text = "Show Logs";
            this.btn_log.UseVisualStyleBackColor = true;
            this.btn_log.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Location = new System.Drawing.Point(859, 462);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "Exit";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // clear_button
            // 
            this.clear_button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.clear_button.Location = new System.Drawing.Point(859, 272);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(75, 23);
            this.clear_button.TabIndex = 6;
            this.clear_button.Text = "Clear Logs";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // timer3
            // 
            this.timer3.Interval = 20;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 20;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Interval = 20;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Interval = 20;
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(100, 50);
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(17, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // control_floor1
            // 
            this.control_floor1.Image = ((System.Drawing.Image)(resources.GetObject("control_floor1.Image")));
            this.control_floor1.Location = new System.Drawing.Point(94, 161);
            this.control_floor1.Name = "control_floor1";
            this.control_floor1.Size = new System.Drawing.Size(23, 23);
            this.control_floor1.TabIndex = 7;
            this.control_floor1.TabStop = false;
            // 
            // control_floor0
            // 
            this.control_floor0.Image = ((System.Drawing.Image)(resources.GetObject("control_floor0.Image")));
            this.control_floor0.Location = new System.Drawing.Point(94, 198);
            this.control_floor0.Name = "control_floor0";
            this.control_floor0.Size = new System.Drawing.Size(23, 22);
            this.control_floor0.TabIndex = 8;
            this.control_floor0.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::AssignmentElevator.Properties.Resources.images;
            this.panel1.Controls.Add(this.pictureBox10);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.floor_display_label);
            this.panel1.Controls.Add(this.display_floor0);
            this.panel1.Controls.Add(this.display_floor1);
            this.panel1.Controls.Add(this.request_down);
            this.panel1.Controls.Add(this.request_up);
            this.panel1.Controls.Add(this.pictureBox9);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 470);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::AssignmentElevator.Properties.Resources.black;
            this.pictureBox10.Location = new System.Drawing.Point(0, 221);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(301, 40);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 8;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Silver;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(57, 315);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 148);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Silver;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(112, 26);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(59, 148);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Silver;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(55, 26);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(60, 148);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 10;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Silver;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(112, 315);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(59, 148);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AssignmentElevator.Properties.Resources.fully_open;
            this.pictureBox3.Location = new System.Drawing.Point(42, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(140, 165);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // floor_display_label
            // 
            this.floor_display_label.AutoSize = true;
            this.floor_display_label.BackColor = System.Drawing.Color.Gainsboro;
            this.floor_display_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floor_display_label.ForeColor = System.Drawing.Color.Red;
            this.floor_display_label.Location = new System.Drawing.Point(91, 291);
            this.floor_display_label.Name = "floor_display_label";
            this.floor_display_label.Size = new System.Drawing.Size(52, 15);
            this.floor_display_label.TabIndex = 4;
            this.floor_display_label.Text = "Floor 0";
            this.floor_display_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.floor_display_label.Click += new System.EventHandler(this.floor_display_label_Click);
            // 
            // display_floor0
            // 
            this.display_floor0.Image = ((System.Drawing.Image)(resources.GetObject("display_floor0.Image")));
            this.display_floor0.Location = new System.Drawing.Point(256, 375);
            this.display_floor0.Name = "display_floor0";
            this.display_floor0.Size = new System.Drawing.Size(42, 43);
            this.display_floor0.TabIndex = 3;
            this.display_floor0.TabStop = false;
            // 
            // display_floor1
            // 
            this.display_floor1.Image = ((System.Drawing.Image)(resources.GetObject("display_floor1.Image")));
            this.display_floor1.Location = new System.Drawing.Point(256, 41);
            this.display_floor1.Name = "display_floor1";
            this.display_floor1.Size = new System.Drawing.Size(42, 43);
            this.display_floor1.TabIndex = 2;
            this.display_floor1.TabStop = false;
            // 
            // request_down
            // 
            this.request_down.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.request_down.BackColor = System.Drawing.Color.Transparent;
            this.request_down.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("request_down.BackgroundImage")));
            this.request_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.request_down.Location = new System.Drawing.Point(204, 375);
            this.request_down.Name = "request_down";
            this.request_down.Size = new System.Drawing.Size(46, 43);
            this.request_down.TabIndex = 1;
            this.request_down.UseVisualStyleBackColor = false;
            this.request_down.Click += new System.EventHandler(this.request_down_Click);
            // 
            // request_up
            // 
            this.request_up.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.request_up.BackColor = System.Drawing.Color.Transparent;
            this.request_up.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("request_up.BackgroundImage")));
            this.request_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.request_up.Location = new System.Drawing.Point(204, 41);
            this.request_up.Name = "request_up";
            this.request_up.Size = new System.Drawing.Size(46, 43);
            this.request_up.TabIndex = 0;
            this.request_up.UseVisualStyleBackColor = false;
            this.request_up.Click += new System.EventHandler(this.request_up_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::AssignmentElevator.Properties.Resources.fully_open;
            this.pictureBox9.Location = new System.Drawing.Point(42, 302);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(140, 165);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 8;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::AssignmentElevator.Properties.Resources.fully_open;
            this.pictureBox1.Location = new System.Drawing.Point(42, 302);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(949, 488);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_log);
            this.Controls.Add(this.control_group_up);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Elevator";
            this.control_group_up.ResumeLayout(false);
            this.control_group_up.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.control_floor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.control_floor0)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_floor0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_floor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button request_down;
        private System.Windows.Forms.Button request_up;
        private System.Windows.Forms.GroupBox control_group_up;
        private System.Windows.Forms.Button control_down;
        private System.Windows.Forms.Button control_up;
        private System.Windows.Forms.Button btn_log;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label floor_display_label;
        private System.Windows.Forms.PictureBox display_floor0;
        private System.Windows.Forms.PictureBox display_floor1;
        private System.Windows.Forms.Label control_panel_label;
        private System.Windows.Forms.PictureBox control_floor1;
        private System.Windows.Forms.PictureBox control_floor0;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
    }
}

