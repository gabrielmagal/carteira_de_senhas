namespace Carteira_de_Senhas_Core
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
            themeForm1 = new ReaLTaiizor.Forms.ThemeForm();
            txb_log = new ReaLTaiizor.Controls.PoisonTextBox();
            btn_close = new ReaLTaiizor.Controls.LostButton();
            parrotGroupBox4 = new ReaLTaiizor.Controls.ParrotGroupBox();
            btn_remove = new ReaLTaiizor.Controls.LostButton();
            txb_remove = new ReaLTaiizor.Controls.CrownTextBox();
            parrotGroupBox3 = new ReaLTaiizor.Controls.ParrotGroupBox();
            btn_search_app = new ReaLTaiizor.Controls.LostButton();
            crownLabel4 = new ReaLTaiizor.Controls.CrownLabel();
            txb_search_password = new ReaLTaiizor.Controls.CrownTextBox();
            crownLabel5 = new ReaLTaiizor.Controls.CrownLabel();
            txb_search_login = new ReaLTaiizor.Controls.CrownTextBox();
            crownLabel6 = new ReaLTaiizor.Controls.CrownLabel();
            txb_search_app = new ReaLTaiizor.Controls.CrownTextBox();
            parrotGroupBox2 = new ReaLTaiizor.Controls.ParrotGroupBox();
            btn_save = new ReaLTaiizor.Controls.LostButton();
            btn_generate_password = new ReaLTaiizor.Controls.LostButton();
            crownLabel3 = new ReaLTaiizor.Controls.CrownLabel();
            txb_save_password = new ReaLTaiizor.Controls.CrownTextBox();
            crownLabel2 = new ReaLTaiizor.Controls.CrownLabel();
            txb_save_login = new ReaLTaiizor.Controls.CrownTextBox();
            crownLabel1 = new ReaLTaiizor.Controls.CrownLabel();
            txb_save_app = new ReaLTaiizor.Controls.CrownTextBox();
            parrotGroupBox1 = new ReaLTaiizor.Controls.ParrotGroupBox();
            btn_encrypt_decrypt = new ReaLTaiizor.Controls.LostButton();
            txb_encrypt_decrypt = new ReaLTaiizor.Controls.CrownTextBox();
            themeForm1.SuspendLayout();
            parrotGroupBox4.SuspendLayout();
            parrotGroupBox3.SuspendLayout();
            parrotGroupBox2.SuspendLayout();
            parrotGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // themeForm1
            // 
            themeForm1.BackColor = Color.FromArgb(32, 41, 50);
            themeForm1.Controls.Add(txb_log);
            themeForm1.Controls.Add(btn_close);
            themeForm1.Controls.Add(parrotGroupBox4);
            themeForm1.Controls.Add(parrotGroupBox3);
            themeForm1.Controls.Add(parrotGroupBox2);
            themeForm1.Controls.Add(parrotGroupBox1);
            themeForm1.Dock = DockStyle.Fill;
            themeForm1.Font = new Font("Microsoft Sans Serif", 9F);
            themeForm1.Image = Properties.Resources.icons8_senha_doodle_144;
            themeForm1.Location = new Point(0, 0);
            themeForm1.Name = "themeForm1";
            themeForm1.Padding = new Padding(10, 70, 10, 9);
            themeForm1.RoundCorners = true;
            themeForm1.Sizable = true;
            themeForm1.Size = new Size(750, 453);
            themeForm1.SmartBounds = true;
            themeForm1.StartPosition = FormStartPosition.CenterScreen;
            themeForm1.TabIndex = 0;
            themeForm1.Text = "Carteira de Senhas";
            // 
            // txb_log
            // 
            txb_log.BackColor = Color.FromArgb(45, 47, 49);
            // 
            // 
            // 
            txb_log.CustomButton.Image = null;
            txb_log.CustomButton.Location = new Point(8, 1);
            txb_log.CustomButton.Name = "";
            txb_log.CustomButton.Size = new Size(369, 369);
            txb_log.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            txb_log.CustomButton.TabIndex = 1;
            txb_log.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            txb_log.CustomButton.UseSelectable = true;
            txb_log.CustomButton.Visible = false;
            txb_log.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txb_log.ForeColor = SystemColors.ButtonHighlight;
            txb_log.Location = new Point(359, 73);
            txb_log.MaxLength = 32767;
            txb_log.Multiline = true;
            txb_log.Name = "txb_log";
            txb_log.PasswordChar = '\0';
            txb_log.ScrollBars = ScrollBars.None;
            txb_log.SelectedText = "";
            txb_log.SelectionLength = 0;
            txb_log.SelectionStart = 0;
            txb_log.ShortcutsEnabled = true;
            txb_log.Size = new Size(378, 371);
            txb_log.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            txb_log.TabIndex = 12;
            txb_log.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            txb_log.UseCustomBackColor = true;
            txb_log.UseCustomFont = true;
            txb_log.UseCustomForeColor = true;
            txb_log.UseSelectable = true;
            txb_log.UseStyleColors = true;
            txb_log.WaterMarkColor = Color.DeepSkyBlue;
            txb_log.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.FromArgb(45, 45, 48);
            btn_close.Font = new Font("Segoe UI", 9F);
            btn_close.ForeColor = Color.White;
            btn_close.HoverColor = Color.DodgerBlue;
            btn_close.Image = null;
            btn_close.Location = new Point(702, 12);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(35, 27);
            btn_close.TabIndex = 3;
            btn_close.Text = "X";
            btn_close.Click += lostButton1_Click;
            // 
            // parrotGroupBox4
            // 
            parrotGroupBox4.BorderColor = Color.LightSkyBlue;
            parrotGroupBox4.BorderWidth = 1;
            parrotGroupBox4.Controls.Add(btn_remove);
            parrotGroupBox4.Controls.Add(txb_remove);
            parrotGroupBox4.Location = new Point(13, 391);
            parrotGroupBox4.Name = "parrotGroupBox4";
            parrotGroupBox4.ShowText = true;
            parrotGroupBox4.Size = new Size(340, 53);
            parrotGroupBox4.TabIndex = 10;
            parrotGroupBox4.TabStop = false;
            parrotGroupBox4.Text = "Remover";
            parrotGroupBox4.TextColor = Color.LightSkyBlue;
            // 
            // btn_remove
            // 
            btn_remove.BackColor = Color.FromArgb(45, 45, 48);
            btn_remove.Font = new Font("Segoe UI", 9F);
            btn_remove.ForeColor = Color.White;
            btn_remove.HoverColor = Color.DodgerBlue;
            btn_remove.Image = null;
            btn_remove.Location = new Point(256, 22);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(70, 21);
            btn_remove.TabIndex = 3;
            btn_remove.Text = "Remover";
            btn_remove.Click += btn_remove_Click;
            // 
            // txb_remove
            // 
            txb_remove.BackColor = Color.FromArgb(69, 73, 74);
            txb_remove.BorderStyle = BorderStyle.FixedSingle;
            txb_remove.ForeColor = Color.FromArgb(220, 220, 220);
            txb_remove.Location = new Point(14, 22);
            txb_remove.Name = "txb_remove";
            txb_remove.Size = new Size(236, 21);
            txb_remove.TabIndex = 1;
            // 
            // parrotGroupBox3
            // 
            parrotGroupBox3.BorderColor = Color.LightSkyBlue;
            parrotGroupBox3.BorderWidth = 1;
            parrotGroupBox3.Controls.Add(btn_search_app);
            parrotGroupBox3.Controls.Add(crownLabel4);
            parrotGroupBox3.Controls.Add(txb_search_password);
            parrotGroupBox3.Controls.Add(crownLabel5);
            parrotGroupBox3.Controls.Add(txb_search_login);
            parrotGroupBox3.Controls.Add(crownLabel6);
            parrotGroupBox3.Controls.Add(txb_search_app);
            parrotGroupBox3.Location = new Point(13, 276);
            parrotGroupBox3.Name = "parrotGroupBox3";
            parrotGroupBox3.ShowText = true;
            parrotGroupBox3.Size = new Size(340, 109);
            parrotGroupBox3.TabIndex = 9;
            parrotGroupBox3.TabStop = false;
            parrotGroupBox3.Text = "Buscar";
            parrotGroupBox3.TextColor = Color.LightSkyBlue;
            // 
            // btn_search_app
            // 
            btn_search_app.BackColor = Color.FromArgb(45, 45, 48);
            btn_search_app.Font = new Font("Segoe UI", 9F);
            btn_search_app.ForeColor = Color.White;
            btn_search_app.HoverColor = Color.DodgerBlue;
            btn_search_app.Image = null;
            btn_search_app.Location = new Point(256, 22);
            btn_search_app.Name = "btn_search_app";
            btn_search_app.Size = new Size(70, 21);
            btn_search_app.TabIndex = 3;
            btn_search_app.Text = "Buscar";
            btn_search_app.Click += btn_search_app_Click;
            // 
            // crownLabel4
            // 
            crownLabel4.AutoSize = true;
            crownLabel4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            crownLabel4.ForeColor = Color.FromArgb(220, 220, 220);
            crownLabel4.Location = new Point(34, 79);
            crownLabel4.Name = "crownLabel4";
            crownLabel4.Size = new Size(52, 15);
            crownLabel4.TabIndex = 7;
            crownLabel4.Text = "Senha:";
            // 
            // txb_search_password
            // 
            txb_search_password.BackColor = Color.FromArgb(69, 73, 74);
            txb_search_password.BorderStyle = BorderStyle.FixedSingle;
            txb_search_password.ForeColor = Color.FromArgb(220, 220, 220);
            txb_search_password.Location = new Point(90, 76);
            txb_search_password.Name = "txb_search_password";
            txb_search_password.Size = new Size(236, 21);
            txb_search_password.TabIndex = 6;
            // 
            // crownLabel5
            // 
            crownLabel5.AutoSize = true;
            crownLabel5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            crownLabel5.ForeColor = Color.FromArgb(220, 220, 220);
            crownLabel5.Location = new Point(39, 52);
            crownLabel5.Name = "crownLabel5";
            crownLabel5.Size = new Size(47, 15);
            crownLabel5.TabIndex = 5;
            crownLabel5.Text = "Login:";
            // 
            // txb_search_login
            // 
            txb_search_login.BackColor = Color.FromArgb(69, 73, 74);
            txb_search_login.BorderStyle = BorderStyle.FixedSingle;
            txb_search_login.ForeColor = Color.FromArgb(220, 220, 220);
            txb_search_login.Location = new Point(90, 49);
            txb_search_login.Name = "txb_search_login";
            txb_search_login.Size = new Size(236, 21);
            txb_search_login.TabIndex = 4;
            // 
            // crownLabel6
            // 
            crownLabel6.AutoSize = true;
            crownLabel6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            crownLabel6.ForeColor = Color.FromArgb(220, 220, 220);
            crownLabel6.Location = new Point(14, 25);
            crownLabel6.Name = "crownLabel6";
            crownLabel6.Size = new Size(72, 15);
            crownLabel6.TabIndex = 3;
            crownLabel6.Text = "Aplicativo:";
            // 
            // txb_search_app
            // 
            txb_search_app.AutoCompleteMode = AutoCompleteMode.Suggest;
            txb_search_app.BackColor = Color.FromArgb(69, 73, 74);
            txb_search_app.BorderStyle = BorderStyle.FixedSingle;
            txb_search_app.ForeColor = Color.FromArgb(220, 220, 220);
            txb_search_app.Location = new Point(90, 22);
            txb_search_app.Name = "txb_search_app";
            txb_search_app.Size = new Size(160, 21);
            txb_search_app.TabIndex = 1;
            // 
            // parrotGroupBox2
            // 
            parrotGroupBox2.BorderColor = Color.LightSkyBlue;
            parrotGroupBox2.BorderWidth = 1;
            parrotGroupBox2.Controls.Add(btn_save);
            parrotGroupBox2.Controls.Add(btn_generate_password);
            parrotGroupBox2.Controls.Add(crownLabel3);
            parrotGroupBox2.Controls.Add(txb_save_password);
            parrotGroupBox2.Controls.Add(crownLabel2);
            parrotGroupBox2.Controls.Add(txb_save_login);
            parrotGroupBox2.Controls.Add(crownLabel1);
            parrotGroupBox2.Controls.Add(txb_save_app);
            parrotGroupBox2.Location = new Point(13, 130);
            parrotGroupBox2.Name = "parrotGroupBox2";
            parrotGroupBox2.ShowText = true;
            parrotGroupBox2.Size = new Size(340, 140);
            parrotGroupBox2.TabIndex = 3;
            parrotGroupBox2.TabStop = false;
            parrotGroupBox2.Text = "Salvar";
            parrotGroupBox2.TextColor = Color.LightSkyBlue;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.FromArgb(45, 45, 48);
            btn_save.Font = new Font("Segoe UI", 9F);
            btn_save.ForeColor = Color.White;
            btn_save.HoverColor = Color.DodgerBlue;
            btn_save.Image = null;
            btn_save.Location = new Point(125, 106);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(91, 25);
            btn_save.TabIndex = 8;
            btn_save.Text = "Salvar";
            btn_save.Click += btn_save_Click;
            // 
            // btn_generate_password
            // 
            btn_generate_password.BackColor = Color.FromArgb(45, 45, 48);
            btn_generate_password.Font = new Font("Segoe UI", 9F);
            btn_generate_password.ForeColor = Color.White;
            btn_generate_password.HoverColor = Color.DodgerBlue;
            btn_generate_password.Image = null;
            btn_generate_password.Location = new Point(274, 76);
            btn_generate_password.Name = "btn_generate_password";
            btn_generate_password.Size = new Size(52, 21);
            btn_generate_password.TabIndex = 3;
            btn_generate_password.Text = "Gerar";
            btn_generate_password.Click += btn_generate_password_Click;
            // 
            // crownLabel3
            // 
            crownLabel3.AutoSize = true;
            crownLabel3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            crownLabel3.ForeColor = Color.FromArgb(220, 220, 220);
            crownLabel3.Location = new Point(34, 79);
            crownLabel3.Name = "crownLabel3";
            crownLabel3.Size = new Size(52, 15);
            crownLabel3.TabIndex = 7;
            crownLabel3.Text = "Senha:";
            // 
            // txb_save_password
            // 
            txb_save_password.BackColor = Color.FromArgb(69, 73, 74);
            txb_save_password.BorderStyle = BorderStyle.FixedSingle;
            txb_save_password.ForeColor = Color.FromArgb(220, 220, 220);
            txb_save_password.Location = new Point(90, 76);
            txb_save_password.Name = "txb_save_password";
            txb_save_password.Size = new Size(178, 21);
            txb_save_password.TabIndex = 6;
            // 
            // crownLabel2
            // 
            crownLabel2.AutoSize = true;
            crownLabel2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            crownLabel2.ForeColor = Color.FromArgb(220, 220, 220);
            crownLabel2.Location = new Point(39, 52);
            crownLabel2.Name = "crownLabel2";
            crownLabel2.Size = new Size(47, 15);
            crownLabel2.TabIndex = 5;
            crownLabel2.Text = "Login:";
            // 
            // txb_save_login
            // 
            txb_save_login.BackColor = Color.FromArgb(69, 73, 74);
            txb_save_login.BorderStyle = BorderStyle.FixedSingle;
            txb_save_login.ForeColor = Color.FromArgb(220, 220, 220);
            txb_save_login.Location = new Point(90, 49);
            txb_save_login.Name = "txb_save_login";
            txb_save_login.Size = new Size(236, 21);
            txb_save_login.TabIndex = 4;
            // 
            // crownLabel1
            // 
            crownLabel1.AutoSize = true;
            crownLabel1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            crownLabel1.ForeColor = Color.FromArgb(220, 220, 220);
            crownLabel1.Location = new Point(14, 25);
            crownLabel1.Name = "crownLabel1";
            crownLabel1.Size = new Size(72, 15);
            crownLabel1.TabIndex = 3;
            crownLabel1.Text = "Aplicativo:";
            // 
            // txb_save_app
            // 
            txb_save_app.BackColor = Color.FromArgb(69, 73, 74);
            txb_save_app.BorderStyle = BorderStyle.FixedSingle;
            txb_save_app.ForeColor = Color.FromArgb(220, 220, 220);
            txb_save_app.Location = new Point(90, 22);
            txb_save_app.Name = "txb_save_app";
            txb_save_app.Size = new Size(236, 21);
            txb_save_app.TabIndex = 1;
            // 
            // parrotGroupBox1
            // 
            parrotGroupBox1.BorderColor = Color.LightSkyBlue;
            parrotGroupBox1.BorderWidth = 1;
            parrotGroupBox1.Controls.Add(btn_encrypt_decrypt);
            parrotGroupBox1.Controls.Add(txb_encrypt_decrypt);
            parrotGroupBox1.Location = new Point(13, 66);
            parrotGroupBox1.Name = "parrotGroupBox1";
            parrotGroupBox1.ShowText = true;
            parrotGroupBox1.Size = new Size(340, 58);
            parrotGroupBox1.TabIndex = 0;
            parrotGroupBox1.TabStop = false;
            parrotGroupBox1.Text = "Chave Criptografia";
            parrotGroupBox1.TextColor = Color.LightSkyBlue;
            // 
            // btn_encrypt_decrypt
            // 
            btn_encrypt_decrypt.BackColor = Color.FromArgb(45, 45, 48);
            btn_encrypt_decrypt.Font = new Font("Segoe UI", 9F);
            btn_encrypt_decrypt.ForeColor = Color.White;
            btn_encrypt_decrypt.HoverColor = Color.DodgerBlue;
            btn_encrypt_decrypt.Image = null;
            btn_encrypt_decrypt.Location = new Point(261, 24);
            btn_encrypt_decrypt.Name = "btn_encrypt_decrypt";
            btn_encrypt_decrypt.Size = new Size(70, 21);
            btn_encrypt_decrypt.TabIndex = 2;
            btn_encrypt_decrypt.Text = "Inserir";
            btn_encrypt_decrypt.Click += btn_encrypt_decrypt_Click;
            // 
            // txb_encrypt_decrypt
            // 
            txb_encrypt_decrypt.BackColor = Color.FromArgb(69, 73, 74);
            txb_encrypt_decrypt.BorderStyle = BorderStyle.FixedSingle;
            txb_encrypt_decrypt.ForeColor = Color.FromArgb(220, 220, 220);
            txb_encrypt_decrypt.Location = new Point(6, 24);
            txb_encrypt_decrypt.Name = "txb_encrypt_decrypt";
            txb_encrypt_decrypt.Size = new Size(249, 21);
            txb_encrypt_decrypt.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(750, 453);
            Controls.Add(themeForm1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(261, 61);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carteira de Senhas";
            TransparencyKey = Color.Fuchsia;
            Load += Form1_Load;
            themeForm1.ResumeLayout(false);
            parrotGroupBox4.ResumeLayout(false);
            parrotGroupBox4.PerformLayout();
            parrotGroupBox3.ResumeLayout(false);
            parrotGroupBox3.PerformLayout();
            parrotGroupBox2.ResumeLayout(false);
            parrotGroupBox2.PerformLayout();
            parrotGroupBox1.ResumeLayout(false);
            parrotGroupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.ThemeForm themeForm1;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox1;
        private ReaLTaiizor.Controls.CrownTextBox txb_encrypt_decrypt;
        private ReaLTaiizor.Controls.LostButton btn_encrypt_decrypt;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox2;
        private ReaLTaiizor.Controls.CrownTextBox txb_save_app;
        private ReaLTaiizor.Controls.CrownLabel crownLabel1;
        private ReaLTaiizor.Controls.CrownLabel crownLabel2;
        private ReaLTaiizor.Controls.CrownTextBox txb_save_login;
        private ReaLTaiizor.Controls.CrownLabel crownLabel3;
        private ReaLTaiizor.Controls.CrownTextBox txb_save_password;
        private ReaLTaiizor.Controls.LostButton btn_generate_password;
        private ReaLTaiizor.Controls.LostButton btn_save;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox3;
        private ReaLTaiizor.Controls.CrownLabel crownLabel4;
        private ReaLTaiizor.Controls.CrownTextBox txb_search_password;
        private ReaLTaiizor.Controls.CrownLabel crownLabel5;
        private ReaLTaiizor.Controls.CrownTextBox txb_search_login;
        private ReaLTaiizor.Controls.CrownLabel crownLabel6;
        private ReaLTaiizor.Controls.CrownTextBox txb_search_app;
        private ReaLTaiizor.Controls.LostButton btn_search_app;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox4;
        private ReaLTaiizor.Controls.LostButton btn_remove;
        private ReaLTaiizor.Controls.CrownTextBox txb_remove;
        private ReaLTaiizor.Controls.LostButton btn_close;
        private ReaLTaiizor.Controls.PoisonTextBox txb_log;
    }
}
