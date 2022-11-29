namespace WebhookManager2._0
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.siticonePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.activityChoice = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.submitButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.minimizeButton = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.webhooksUsernameInput = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.messageInput = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.titleInput = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.descriptionInput = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.thumbnailInput = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.delayInput = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.webhookUrlBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(8)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 46);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(736, 1);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneDragControl1.TargetControl = this;
            this.siticoneDragControl1.UseTransparentDrag = true;
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.siticonePictureBox1.Image = global::WebhookManager2._0.Properties.Resources.webhook;
            this.siticonePictureBox1.ImageRotate = 0F;
            this.siticonePictureBox1.Location = new System.Drawing.Point(12, 4);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.Size = new System.Drawing.Size(37, 38);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox1.TabIndex = 1;
            this.siticonePictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Discord Webhook Manager 2.0";
            // 
            // activityChoice
            // 
            this.activityChoice.BackColor = System.Drawing.Color.Transparent;
            this.activityChoice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.activityChoice.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.activityChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activityChoice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.activityChoice.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(8)))), ((int)(((byte)(255)))));
            this.activityChoice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(8)))), ((int)(((byte)(255)))));
            this.activityChoice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.activityChoice.ForeColor = System.Drawing.Color.White;
            this.activityChoice.ItemHeight = 30;
            this.activityChoice.Items.AddRange(new object[] {
            "Send Webhook",
            "Delete Webhook",
            "Send Embed",
            "Spam Webhook"});
            this.activityChoice.Location = new System.Drawing.Point(174, 71);
            this.activityChoice.Name = "activityChoice";
            this.activityChoice.Size = new System.Drawing.Size(175, 36);
            this.activityChoice.TabIndex = 3;
            this.activityChoice.SelectedValueChanged += new System.EventHandler(this.activityChoice_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose activity:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(8)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(174, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 1);
            this.panel1.TabIndex = 5;
            // 
            // exitButton
            // 
            this.exitButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.exitButton.HoverState.ImageOffset = new System.Drawing.Point(-1, -1);
            this.exitButton.HoverState.ImageSize = new System.Drawing.Size(66, 66);
            this.exitButton.Image = global::WebhookManager2._0.Properties.Resources.Nowy_projekt;
            this.exitButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.exitButton.ImageRotate = 0F;
            this.exitButton.Location = new System.Drawing.Point(694, 9);
            this.exitButton.Name = "exitButton";
            this.exitButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.exitButton.Size = new System.Drawing.Size(30, 30);
            this.exitButton.TabIndex = 6;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.BorderRadius = 17;
            this.submitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.submitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.submitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.submitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.submitButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(8)))), ((int)(((byte)(255)))));
            this.submitButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submitButton.ForeColor = System.Drawing.Color.White;
            this.submitButton.Location = new System.Drawing.Point(511, 207);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(167, 37);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Made by siwusekkk#1372";
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.minimizeButton.HoverState.ImageOffset = new System.Drawing.Point(-1, -1);
            this.minimizeButton.HoverState.ImageSize = new System.Drawing.Size(66, 66);
            this.minimizeButton.Image = global::WebhookManager2._0.Properties.Resources.Nowy_projekt__1_;
            this.minimizeButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.minimizeButton.ImageRotate = 0F;
            this.minimizeButton.Location = new System.Drawing.Point(658, 9);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.minimizeButton.Size = new System.Drawing.Size(30, 30);
            this.minimizeButton.TabIndex = 8;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Webhooks username:";
            // 
            // webhooksUsernameInput
            // 
            this.webhooksUsernameInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(8)))), ((int)(((byte)(255)))));
            this.webhooksUsernameInput.BorderRadius = 17;
            this.webhooksUsernameInput.DefaultText = "";
            this.webhooksUsernameInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.webhooksUsernameInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.webhooksUsernameInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.webhooksUsernameInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.webhooksUsernameInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.webhooksUsernameInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.webhooksUsernameInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.webhooksUsernameInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.webhooksUsernameInput.Location = new System.Drawing.Point(223, 126);
            this.webhooksUsernameInput.Name = "webhooksUsernameInput";
            this.webhooksUsernameInput.PasswordChar = '\0';
            this.webhooksUsernameInput.PlaceholderText = "";
            this.webhooksUsernameInput.SelectedText = "";
            this.webhooksUsernameInput.Size = new System.Drawing.Size(167, 36);
            this.webhooksUsernameInput.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Message:";
            // 
            // messageInput
            // 
            this.messageInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(8)))), ((int)(((byte)(255)))));
            this.messageInput.BorderRadius = 17;
            this.messageInput.DefaultText = "";
            this.messageInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.messageInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.messageInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.messageInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.messageInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.messageInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.messageInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.messageInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.messageInput.Location = new System.Drawing.Point(121, 183);
            this.messageInput.Name = "messageInput";
            this.messageInput.PasswordChar = '\0';
            this.messageInput.PlaceholderText = "";
            this.messageInput.SelectedText = "";
            this.messageInput.Size = new System.Drawing.Size(167, 36);
            this.messageInput.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Embeds title:";
            // 
            // titleInput
            // 
            this.titleInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(8)))), ((int)(((byte)(255)))));
            this.titleInput.BorderRadius = 17;
            this.titleInput.DefaultText = "";
            this.titleInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.titleInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.titleInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.titleInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.titleInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.titleInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.titleInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.titleInput.Location = new System.Drawing.Point(150, 239);
            this.titleInput.Name = "titleInput";
            this.titleInput.PasswordChar = '\0';
            this.titleInput.PlaceholderText = "";
            this.titleInput.SelectedText = "";
            this.titleInput.Size = new System.Drawing.Size(167, 36);
            this.titleInput.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(25, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Embeds description:";
            // 
            // descriptionInput
            // 
            this.descriptionInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(8)))), ((int)(((byte)(255)))));
            this.descriptionInput.BorderRadius = 17;
            this.descriptionInput.DefaultText = "";
            this.descriptionInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.descriptionInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.descriptionInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descriptionInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descriptionInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.descriptionInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.descriptionInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.descriptionInput.Location = new System.Drawing.Point(212, 287);
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.PasswordChar = '\0';
            this.descriptionInput.PlaceholderText = "";
            this.descriptionInput.SelectedText = "";
            this.descriptionInput.Size = new System.Drawing.Size(167, 36);
            this.descriptionInput.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(25, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Embeds thumbnail url:";
            // 
            // thumbnailInput
            // 
            this.thumbnailInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(8)))), ((int)(((byte)(255)))));
            this.thumbnailInput.BorderRadius = 17;
            this.thumbnailInput.DefaultText = "";
            this.thumbnailInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.thumbnailInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.thumbnailInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.thumbnailInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.thumbnailInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.thumbnailInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.thumbnailInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.thumbnailInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.thumbnailInput.Location = new System.Drawing.Point(232, 341);
            this.thumbnailInput.Name = "thumbnailInput";
            this.thumbnailInput.PasswordChar = '\0';
            this.thumbnailInput.PlaceholderText = "";
            this.thumbnailInput.SelectedText = "";
            this.thumbnailInput.Size = new System.Drawing.Size(167, 36);
            this.thumbnailInput.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(25, 397);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Spam delay (ms): ";
            // 
            // delayInput
            // 
            this.delayInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(8)))), ((int)(((byte)(255)))));
            this.delayInput.BorderRadius = 17;
            this.delayInput.DefaultText = "";
            this.delayInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.delayInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.delayInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.delayInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.delayInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.delayInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.delayInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delayInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.delayInput.Location = new System.Drawing.Point(190, 394);
            this.delayInput.Name = "delayInput";
            this.delayInput.PasswordChar = '\0';
            this.delayInput.PlaceholderText = "";
            this.delayInput.SelectedText = "";
            this.delayInput.Size = new System.Drawing.Size(167, 36);
            this.delayInput.TabIndex = 20;
            // 
            // webhookUrlBox
            // 
            this.webhookUrlBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.webhookUrlBox.BorderRadius = 17;
            this.webhookUrlBox.DefaultText = "";
            this.webhookUrlBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.webhookUrlBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.webhookUrlBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.webhookUrlBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.webhookUrlBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.webhookUrlBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.webhookUrlBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.webhookUrlBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.webhookUrlBox.Location = new System.Drawing.Point(346, 5);
            this.webhookUrlBox.Name = "webhookUrlBox";
            this.webhookUrlBox.PasswordChar = '\0';
            this.webhookUrlBox.PlaceholderText = "";
            this.webhookUrlBox.SelectedText = "";
            this.webhookUrlBox.Size = new System.Drawing.Size(288, 36);
            this.webhookUrlBox.TabIndex = 21;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(736, 450);
            this.Controls.Add(this.webhookUrlBox);
            this.Controls.Add(this.delayInput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.thumbnailInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.descriptionInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.titleInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.messageInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.webhooksUsernameInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.activityChoice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siticonePictureBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox activityChoice;
        private Label label1;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private Label label2;
        private Panel panel1;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton exitButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton submitButton;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton minimizeButton;
        private Label label3;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox thumbnailInput;
        private Label label7;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox descriptionInput;
        private Label label6;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox titleInput;
        private Label label5;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox messageInput;
        private Label label4;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox webhooksUsernameInput;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox delayInput;
        private Label label8;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox webhookUrlBox;
    }
}