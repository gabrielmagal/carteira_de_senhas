namespace Carteira_de_Senhas
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.themeForm1 = new ReaLTaiizor.Forms.ThemeForm();
            this.txb_log = new ReaLTaiizor.Controls.ForeverTextBox();
            this.parrotGroupBox3 = new ReaLTaiizor.Controls.ParrotGroupBox();
            this.txb_remove = new ReaLTaiizor.Controls.CrownTextBox();
            this.btn_remove = new ReaLTaiizor.Controls.LostButton();
            this.parrotGroupBox2 = new ReaLTaiizor.Controls.ParrotGroupBox();
            this.txb_search_password = new ReaLTaiizor.Controls.CrownTextBox();
            this.txb_search_login = new ReaLTaiizor.Controls.CrownTextBox();
            this.txb_search_app = new ReaLTaiizor.Controls.CrownTextBox();
            this.crownLabel4 = new ReaLTaiizor.Controls.CrownLabel();
            this.btn_search_app = new ReaLTaiizor.Controls.LostButton();
            this.crownLabel5 = new ReaLTaiizor.Controls.CrownLabel();
            this.crownLabel6 = new ReaLTaiizor.Controls.CrownLabel();
            this.parrotGroupBox1 = new ReaLTaiizor.Controls.ParrotGroupBox();
            this.txb_save_password = new ReaLTaiizor.Controls.CrownTextBox();
            this.txb_save_login = new ReaLTaiizor.Controls.CrownTextBox();
            this.txb_save_app = new ReaLTaiizor.Controls.CrownTextBox();
            this.btn_save_generate_password = new ReaLTaiizor.Controls.LostButton();
            this.btn_save = new ReaLTaiizor.Controls.LostButton();
            this.crownLabel3 = new ReaLTaiizor.Controls.CrownLabel();
            this.crownLabel2 = new ReaLTaiizor.Controls.CrownLabel();
            this.crownLabel1 = new ReaLTaiizor.Controls.CrownLabel();
            this.parrotGroupBox4 = new ReaLTaiizor.Controls.ParrotGroupBox();
            this.txb_encrypt_decrypt = new ReaLTaiizor.Controls.CrownTextBox();
            this.btn_encrypt_decrypt = new ReaLTaiizor.Controls.LostButton();
            this.btn_close = new ReaLTaiizor.Controls.LostButton();
            this.themeForm1.SuspendLayout();
            this.parrotGroupBox3.SuspendLayout();
            this.parrotGroupBox2.SuspendLayout();
            this.parrotGroupBox1.SuspendLayout();
            this.parrotGroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // themeForm1
            // 
            this.themeForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.themeForm1.Controls.Add(this.btn_close);
            this.themeForm1.Controls.Add(this.parrotGroupBox4);
            this.themeForm1.Controls.Add(this.txb_log);
            this.themeForm1.Controls.Add(this.parrotGroupBox3);
            this.themeForm1.Controls.Add(this.parrotGroupBox2);
            this.themeForm1.Controls.Add(this.parrotGroupBox1);
            this.themeForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.themeForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.themeForm1.Image = global::Carteira_de_Senhas.Properties.Resources.icons8_senha_doodle_144;
            this.themeForm1.Location = new System.Drawing.Point(0, 0);
            this.themeForm1.Name = "themeForm1";
            this.themeForm1.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.themeForm1.RoundCorners = true;
            this.themeForm1.Sizable = true;
            this.themeForm1.Size = new System.Drawing.Size(747, 442);
            this.themeForm1.SmartBounds = true;
            this.themeForm1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.themeForm1.TabIndex = 0;
            this.themeForm1.Text = "Carteira de Senhas";
            // 
            // txb_log
            // 
            this.txb_log.BackColor = System.Drawing.Color.Transparent;
            this.txb_log.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txb_log.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txb_log.FocusOnHover = false;
            this.txb_log.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txb_log.Location = new System.Drawing.Point(354, 75);
            this.txb_log.MaxLength = 32767;
            this.txb_log.Multiline = true;
            this.txb_log.Name = "txb_log";
            this.txb_log.ReadOnly = false;
            this.txb_log.Size = new System.Drawing.Size(383, 356);
            this.txb_log.TabIndex = 10;
            this.txb_log.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txb_log.UseSystemPasswordChar = false;
            // 
            // parrotGroupBox3
            // 
            this.parrotGroupBox3.BorderColor = System.Drawing.Color.DodgerBlue;
            this.parrotGroupBox3.BorderWidth = 1;
            this.parrotGroupBox3.Controls.Add(this.txb_remove);
            this.parrotGroupBox3.Controls.Add(this.btn_remove);
            this.parrotGroupBox3.Location = new System.Drawing.Point(9, 377);
            this.parrotGroupBox3.Name = "parrotGroupBox3";
            this.parrotGroupBox3.ShowText = true;
            this.parrotGroupBox3.Size = new System.Drawing.Size(339, 54);
            this.parrotGroupBox3.TabIndex = 10;
            this.parrotGroupBox3.TabStop = false;
            this.parrotGroupBox3.Text = "Remover";
            this.parrotGroupBox3.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // txb_remove
            // 
            this.txb_remove.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txb_remove.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txb_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txb_remove.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_remove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txb_remove.Location = new System.Drawing.Point(7, 22);
            this.txb_remove.Name = "txb_remove";
            this.txb_remove.Size = new System.Drawing.Size(246, 21);
            this.txb_remove.TabIndex = 15;
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_remove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.HoverColor = System.Drawing.Color.DodgerBlue;
            this.btn_remove.Image = null;
            this.btn_remove.Location = new System.Drawing.Point(257, 17);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(71, 30);
            this.btn_remove.TabIndex = 1;
            this.btn_remove.Text = "Remover";
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // parrotGroupBox2
            // 
            this.parrotGroupBox2.BorderColor = System.Drawing.Color.DodgerBlue;
            this.parrotGroupBox2.BorderWidth = 1;
            this.parrotGroupBox2.Controls.Add(this.txb_search_password);
            this.parrotGroupBox2.Controls.Add(this.txb_search_login);
            this.parrotGroupBox2.Controls.Add(this.txb_search_app);
            this.parrotGroupBox2.Controls.Add(this.crownLabel4);
            this.parrotGroupBox2.Controls.Add(this.btn_search_app);
            this.parrotGroupBox2.Controls.Add(this.crownLabel5);
            this.parrotGroupBox2.Controls.Add(this.crownLabel6);
            this.parrotGroupBox2.Location = new System.Drawing.Point(9, 271);
            this.parrotGroupBox2.Name = "parrotGroupBox2";
            this.parrotGroupBox2.ShowText = true;
            this.parrotGroupBox2.Size = new System.Drawing.Size(339, 106);
            this.parrotGroupBox2.TabIndex = 9;
            this.parrotGroupBox2.TabStop = false;
            this.parrotGroupBox2.Text = "Buscar";
            this.parrotGroupBox2.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // txb_search_password
            // 
            this.txb_search_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txb_search_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_search_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txb_search_password.Location = new System.Drawing.Point(89, 71);
            this.txb_search_password.Name = "txb_search_password";
            this.txb_search_password.Size = new System.Drawing.Size(233, 21);
            this.txb_search_password.TabIndex = 13;
            // 
            // txb_search_login
            // 
            this.txb_search_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txb_search_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_search_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txb_search_login.Location = new System.Drawing.Point(89, 46);
            this.txb_search_login.Name = "txb_search_login";
            this.txb_search_login.Size = new System.Drawing.Size(233, 21);
            this.txb_search_login.TabIndex = 12;
            // 
            // txb_search_app
            // 
            this.txb_search_app.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txb_search_app.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txb_search_app.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txb_search_app.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_search_app.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txb_search_app.Location = new System.Drawing.Point(89, 21);
            this.txb_search_app.Name = "txb_search_app";
            this.txb_search_app.Size = new System.Drawing.Size(156, 21);
            this.txb_search_app.TabIndex = 11;
            // 
            // crownLabel4
            // 
            this.crownLabel4.AutoSize = true;
            this.crownLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crownLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.crownLabel4.Location = new System.Drawing.Point(37, 73);
            this.crownLabel4.Name = "crownLabel4";
            this.crownLabel4.Size = new System.Drawing.Size(52, 15);
            this.crownLabel4.TabIndex = 7;
            this.crownLabel4.Text = "Senha:";
            // 
            // btn_search_app
            // 
            this.btn_search_app.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_search_app.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search_app.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_search_app.ForeColor = System.Drawing.Color.White;
            this.btn_search_app.HoverColor = System.Drawing.Color.DodgerBlue;
            this.btn_search_app.Image = null;
            this.btn_search_app.Location = new System.Drawing.Point(251, 19);
            this.btn_search_app.Name = "btn_search_app";
            this.btn_search_app.Size = new System.Drawing.Size(71, 25);
            this.btn_search_app.TabIndex = 1;
            this.btn_search_app.Text = "Buscar";
            this.btn_search_app.Click += new System.EventHandler(this.btn_search_app_Click);
            // 
            // crownLabel5
            // 
            this.crownLabel5.AutoSize = true;
            this.crownLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crownLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.crownLabel5.Location = new System.Drawing.Point(42, 48);
            this.crownLabel5.Name = "crownLabel5";
            this.crownLabel5.Size = new System.Drawing.Size(47, 15);
            this.crownLabel5.TabIndex = 5;
            this.crownLabel5.Text = "Login:";
            // 
            // crownLabel6
            // 
            this.crownLabel6.AutoSize = true;
            this.crownLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crownLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.crownLabel6.Location = new System.Drawing.Point(17, 22);
            this.crownLabel6.Name = "crownLabel6";
            this.crownLabel6.Size = new System.Drawing.Size(72, 15);
            this.crownLabel6.TabIndex = 3;
            this.crownLabel6.Text = "Aplicativo:";
            // 
            // parrotGroupBox1
            // 
            this.parrotGroupBox1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.parrotGroupBox1.BorderWidth = 1;
            this.parrotGroupBox1.Controls.Add(this.txb_save_password);
            this.parrotGroupBox1.Controls.Add(this.txb_save_login);
            this.parrotGroupBox1.Controls.Add(this.txb_save_app);
            this.parrotGroupBox1.Controls.Add(this.btn_save_generate_password);
            this.parrotGroupBox1.Controls.Add(this.btn_save);
            this.parrotGroupBox1.Controls.Add(this.crownLabel3);
            this.parrotGroupBox1.Controls.Add(this.crownLabel2);
            this.parrotGroupBox1.Controls.Add(this.crownLabel1);
            this.parrotGroupBox1.Location = new System.Drawing.Point(9, 130);
            this.parrotGroupBox1.Name = "parrotGroupBox1";
            this.parrotGroupBox1.ShowText = true;
            this.parrotGroupBox1.Size = new System.Drawing.Size(339, 140);
            this.parrotGroupBox1.TabIndex = 0;
            this.parrotGroupBox1.TabStop = false;
            this.parrotGroupBox1.Text = "Salvar";
            this.parrotGroupBox1.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // txb_save_password
            // 
            this.txb_save_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txb_save_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_save_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txb_save_password.Location = new System.Drawing.Point(89, 73);
            this.txb_save_password.Name = "txb_save_password";
            this.txb_save_password.Size = new System.Drawing.Size(178, 21);
            this.txb_save_password.TabIndex = 14;
            // 
            // txb_save_login
            // 
            this.txb_save_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txb_save_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_save_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txb_save_login.Location = new System.Drawing.Point(89, 49);
            this.txb_save_login.Name = "txb_save_login";
            this.txb_save_login.Size = new System.Drawing.Size(233, 21);
            this.txb_save_login.TabIndex = 15;
            // 
            // txb_save_app
            // 
            this.txb_save_app.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txb_save_app.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_save_app.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txb_save_app.Location = new System.Drawing.Point(89, 25);
            this.txb_save_app.Name = "txb_save_app";
            this.txb_save_app.Size = new System.Drawing.Size(233, 21);
            this.txb_save_app.TabIndex = 14;
            // 
            // btn_save_generate_password
            // 
            this.btn_save_generate_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_save_generate_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save_generate_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_save_generate_password.ForeColor = System.Drawing.Color.White;
            this.btn_save_generate_password.HoverColor = System.Drawing.Color.DodgerBlue;
            this.btn_save_generate_password.Image = null;
            this.btn_save_generate_password.Location = new System.Drawing.Point(273, 73);
            this.btn_save_generate_password.Name = "btn_save_generate_password";
            this.btn_save_generate_password.Size = new System.Drawing.Size(52, 24);
            this.btn_save_generate_password.TabIndex = 8;
            this.btn_save_generate_password.Text = "Gerar";
            this.btn_save_generate_password.Click += new System.EventHandler(this.btn_save_generate_password_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.HoverColor = System.Drawing.Color.DodgerBlue;
            this.btn_save.Image = null;
            this.btn_save.Location = new System.Drawing.Point(107, 102);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(124, 30);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Salvar";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // crownLabel3
            // 
            this.crownLabel3.AutoSize = true;
            this.crownLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crownLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.crownLabel3.Location = new System.Drawing.Point(37, 75);
            this.crownLabel3.Name = "crownLabel3";
            this.crownLabel3.Size = new System.Drawing.Size(52, 15);
            this.crownLabel3.TabIndex = 7;
            this.crownLabel3.Text = "Senha:";
            // 
            // crownLabel2
            // 
            this.crownLabel2.AutoSize = true;
            this.crownLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crownLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.crownLabel2.Location = new System.Drawing.Point(42, 51);
            this.crownLabel2.Name = "crownLabel2";
            this.crownLabel2.Size = new System.Drawing.Size(47, 15);
            this.crownLabel2.TabIndex = 5;
            this.crownLabel2.Text = "Login:";
            // 
            // crownLabel1
            // 
            this.crownLabel1.AutoSize = true;
            this.crownLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crownLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.crownLabel1.Location = new System.Drawing.Point(17, 27);
            this.crownLabel1.Name = "crownLabel1";
            this.crownLabel1.Size = new System.Drawing.Size(72, 15);
            this.crownLabel1.TabIndex = 3;
            this.crownLabel1.Text = "Aplicativo:";
            // 
            // parrotGroupBox4
            // 
            this.parrotGroupBox4.BorderColor = System.Drawing.Color.DodgerBlue;
            this.parrotGroupBox4.BorderWidth = 1;
            this.parrotGroupBox4.Controls.Add(this.txb_encrypt_decrypt);
            this.parrotGroupBox4.Controls.Add(this.btn_encrypt_decrypt);
            this.parrotGroupBox4.Location = new System.Drawing.Point(9, 70);
            this.parrotGroupBox4.Name = "parrotGroupBox4";
            this.parrotGroupBox4.ShowText = true;
            this.parrotGroupBox4.Size = new System.Drawing.Size(339, 54);
            this.parrotGroupBox4.TabIndex = 17;
            this.parrotGroupBox4.TabStop = false;
            this.parrotGroupBox4.Text = "Encrypt/Decrypt";
            this.parrotGroupBox4.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // txb_encrypt_decrypt
            // 
            this.txb_encrypt_decrypt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txb_encrypt_decrypt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txb_encrypt_decrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txb_encrypt_decrypt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_encrypt_decrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txb_encrypt_decrypt.Location = new System.Drawing.Point(7, 22);
            this.txb_encrypt_decrypt.Name = "txb_encrypt_decrypt";
            this.txb_encrypt_decrypt.Size = new System.Drawing.Size(246, 21);
            this.txb_encrypt_decrypt.TabIndex = 15;
            // 
            // btn_encrypt_decrypt
            // 
            this.btn_encrypt_decrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_encrypt_decrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_encrypt_decrypt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_encrypt_decrypt.ForeColor = System.Drawing.Color.White;
            this.btn_encrypt_decrypt.HoverColor = System.Drawing.Color.DodgerBlue;
            this.btn_encrypt_decrypt.Image = null;
            this.btn_encrypt_decrypt.Location = new System.Drawing.Point(257, 17);
            this.btn_encrypt_decrypt.Name = "btn_encrypt_decrypt";
            this.btn_encrypt_decrypt.Size = new System.Drawing.Size(71, 30);
            this.btn_encrypt_decrypt.TabIndex = 1;
            this.btn_encrypt_decrypt.Text = "Inserir";
            this.btn_encrypt_decrypt.Click += new System.EventHandler(this.btn_encrypt_decrypt_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.HoverColor = System.Drawing.Color.DodgerBlue;
            this.btn_close.Image = null;
            this.btn_close.Location = new System.Drawing.Point(701, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(36, 27);
            this.btn_close.TabIndex = 17;
            this.btn_close.Text = "X";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(747, 442);
            this.Controls.Add(this.themeForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1032);
            this.MinimumSize = new System.Drawing.Size(261, 61);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carteira de Senhas";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.themeForm1.ResumeLayout(false);
            this.parrotGroupBox3.ResumeLayout(false);
            this.parrotGroupBox3.PerformLayout();
            this.parrotGroupBox2.ResumeLayout(false);
            this.parrotGroupBox2.PerformLayout();
            this.parrotGroupBox1.ResumeLayout(false);
            this.parrotGroupBox1.PerformLayout();
            this.parrotGroupBox4.ResumeLayout(false);
            this.parrotGroupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.ThemeForm themeForm1;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox1;
        private ReaLTaiizor.Controls.LostButton btn_save;
        private ReaLTaiizor.Controls.CrownLabel crownLabel3;
        private ReaLTaiizor.Controls.CrownLabel crownLabel2;
        private ReaLTaiizor.Controls.CrownLabel crownLabel1;
        private ReaLTaiizor.Controls.LostButton btn_save_generate_password;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox3;
        private ReaLTaiizor.Controls.LostButton btn_remove;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox2;
        private ReaLTaiizor.Controls.LostButton btn_search_app;
        private ReaLTaiizor.Controls.CrownLabel crownLabel6;
        private ReaLTaiizor.Controls.ForeverTextBox txb_log;
        private ReaLTaiizor.Controls.CrownLabel crownLabel4;
        private ReaLTaiizor.Controls.CrownLabel crownLabel5;
        private ReaLTaiizor.Controls.CrownTextBox txb_search_app;
        private ReaLTaiizor.Controls.CrownTextBox txb_search_password;
        private ReaLTaiizor.Controls.CrownTextBox txb_search_login;
        private ReaLTaiizor.Controls.CrownTextBox txb_save_password;
        private ReaLTaiizor.Controls.CrownTextBox txb_save_login;
        private ReaLTaiizor.Controls.CrownTextBox txb_save_app;
        private ReaLTaiizor.Controls.CrownTextBox txb_remove;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox4;
        private ReaLTaiizor.Controls.CrownTextBox txb_encrypt_decrypt;
        private ReaLTaiizor.Controls.LostButton btn_encrypt_decrypt;
        private ReaLTaiizor.Controls.LostButton btn_close;
    }
}

