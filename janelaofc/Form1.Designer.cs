namespace janelaofc
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            listBox = new ListBox();
            txtNome = new TextBox();
            Gmail = new Label();
            txtGmail = new TextBox();
            Senha = new Label();
            txtSenha = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(337, 103);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 75);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(145, 144);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 3;
            label3.Text = "Nome";
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSlateBlue;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(222, 250);
            button1.Name = "button1";
            button1.Size = new Size(98, 28);
            button1.TabIndex = 4;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox
            // 
            listBox.BackColor = SystemColors.HighlightText;
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(222, 284);
            listBox.Name = "listBox";
            listBox.Size = new Size(302, 154);
            listBox.TabIndex = 5;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(222, 136);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(302, 23);
            txtNome.TabIndex = 6;
            // 
            // Gmail
            // 
            Gmail.AutoSize = true;
            Gmail.Location = new Point(145, 179);
            Gmail.Name = "Gmail";
            Gmail.Size = new Size(38, 15);
            Gmail.TabIndex = 7;
            Gmail.Text = "Gmail";
            Gmail.Click += label4_Click;
            // 
            // txtGmail
            // 
            txtGmail.Location = new Point(222, 176);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(302, 23);
            txtGmail.TabIndex = 8;
            // 
            // Senha
            // 
            Senha.AutoSize = true;
            Senha.Location = new Point(144, 213);
            Senha.Name = "Senha";
            Senha.Size = new Size(39, 15);
            Senha.TabIndex = 9;
            Senha.Text = "Senha";
            Senha.Click += label5_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(222, 205);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(302, 23);
            txtSenha.TabIndex = 10;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkSlateBlue;
            pictureBox1.BackgroundImage = Properties.Resources.Faça_o_seu_login_;
            pictureBox1.Image = Properties.Resources.Faça_o_seu_login_;
            pictureBox1.Location = new Point(-11, -99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(810, 623);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSenha);
            Controls.Add(Senha);
            Controls.Add(txtGmail);
            Controls.Add(Gmail);
            Controls.Add(txtNome);
            Controls.Add(listBox);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private ListBox listBox;
        private TextBox txtNome;
        private Label Gmail;
        private TextBox txtGmail;
        private Label Senha;
        private TextBox txtSenha;
        private PictureBox pictureBox1;
    }
}
