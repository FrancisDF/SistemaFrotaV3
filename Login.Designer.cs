namespace SistemaFrotaV3
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            panel3 = new Panel();
            label3 = new Label();
            label2 = new Label();
            text_login = new TextBox();
            label1 = new Label();
            panel6 = new Panel();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            button2 = new Button();
            panel4 = new Panel();
            button1 = new Button();
            comboBox1 = new ComboBox();
            text_senha = new TextBox();
            panel2 = new Panel();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(418, 264);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(text_login);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(text_senha);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(210, 264);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(30, 170);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 7;
            label3.Text = "local";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(30, 130);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 6;
            label2.Text = "senha";
            // 
            // text_login
            // 
            text_login.Location = new Point(30, 100);
            text_login.Multiline = true;
            text_login.Name = "text_login";
            text_login.Size = new Size(142, 18);
            text_login.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(30, 84);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 4;
            label1.Text = "usuario";
            // 
            // panel6
            // 
            panel6.Controls.Add(pictureBox1);
            panel6.Location = new Point(14, 14);
            panel6.Name = "panel6";
            panel6.Size = new Size(47, 44);
            panel6.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(button2);
            panel5.Location = new Point(81, 227);
            panel5.Name = "panel5";
            panel5.Size = new Size(91, 17);
            panel5.TabIndex = 2;
            // 
            // button2
            // 
            button2.ForeColor = Color.FromArgb(128, 128, 255);
            button2.Location = new Point(-9, -10);
            button2.Name = "button2";
            button2.Size = new Size(111, 38);
            button2.TabIndex = 1;
            button2.Text = "recuperar_senha";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(button1);
            panel4.Location = new Point(30, 227);
            panel4.Name = "panel4";
            panel4.Size = new Size(45, 17);
            panel4.TabIndex = 1;
            // 
            // button1
            // 
            button1.ForeColor = Color.Red;
            button1.Location = new Point(-16, -10);
            button1.Name = "button1";
            button1.Size = new Size(79, 38);
            button1.TabIndex = 1;
            button1.Text = "acessar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(30, 188);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(142, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // text_senha
            // 
            text_senha.Location = new Point(30, 146);
            text_senha.Multiline = true;
            text_senha.Name = "text_senha";
            text_senha.Size = new Size(142, 18);
            text_senha.TabIndex = 1;
            text_senha.TextChanged += textBox1_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 128);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(208, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(210, 264);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(16, 43);
            label4.Name = "label4";
            label4.Size = new Size(181, 32);
            label4.TabIndex = 1;
            label4.Text = "Gestão de Frota";
            label4.Click += label4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 48);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(210, 196);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Login
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 265);
            ControlBox = false;
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Login";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private TextBox text_senha;
        private Panel panel2;
        private Panel panel4;
        private ComboBox comboBox1;
        private Panel panel5;
        private Button button2;
        private Button button1;
        private Panel panel6;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox text_login;
        private Label label4;
    }
}