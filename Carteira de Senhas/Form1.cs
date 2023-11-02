﻿using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Carteira_de_Senhas
{
    public partial class Form1 : Form
    {
        private IniFile iniFile = new IniFile();

        private PasswordGenerator passwordGenerator = new PasswordGenerator();

        private AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();

        private Encrypt encrypt = new Encrypt();

        private string strEncryptDecrypt = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            preencherSecoes();
        }

        private void btn_save_generate_password_Click(object sender, EventArgs e)
        {
            txb_save_password.Text = passwordGenerator.GenerateRandomPassword();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string strSucess = "App adicionado a sua carteira de senhas com sucesso!";
            string strFail = "Existem dados obrigatórios que não foram preenchidos e por isso não foi possível concluir a operação!";
            string strFailKey = "É necessário definir uma chave de criptografia inicialmente.";
            string app = txb_save_app.Text;
            string login = txb_save_login.Text;
            string senha = txb_save_password.Text;
            
            if(String.IsNullOrEmpty(strEncryptDecrypt))
            {
                log(strFailKey);
                ReaLTaiizor.Controls.CrownMessageBox.ShowError(strFailKey, "Info");
                return;
            }

            if (!String.IsNullOrEmpty(app) && !String.IsNullOrEmpty(login) && !String.IsNullOrEmpty(senha))
            {
                iniFile.Write("login", login, app);
                iniFile.Write("password", encrypt.strEncrypt(senha, strEncryptDecrypt), app);
                preencherSecoes();
                txb_save_app.Text = "";
                txb_save_login.Text = "";
                txb_save_password.Text = "";
                log(strSucess);
                ReaLTaiizor.Controls.CrownMessageBox.ShowInformation(strSucess, "Info");
            }
            else
            {
                log(strFail);
                ReaLTaiizor.Controls.CrownMessageBox.ShowInformation("Existem dados obrigatórios que não foram preenchidos e por isso não foi possível concluir a operação!", "Info");
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            string strQuestion = "Você realmente deseja remover da sua carteira de senhas o App selecionado?";
            string strSucess = "App removido da sua carteira de senhas com sucesso!";
            string strFail = "O App selecionado não existe!";
            if (iniFile.ReadAllSectionsName().Contains(txb_remove.Text))
            {
                if (ReaLTaiizor.Controls.CrownMessageBox.ShowInformation(strQuestion, "Info", ReaLTaiizor.Enum.Crown.DialogButton.YesNo) == DialogResult.Yes)
                {
                    iniFile.DeleteSection(txb_remove.Text);
                    preencherSecoes();
                    txb_remove.Text = "";
                    log(strSucess);
                    ReaLTaiizor.Controls.CrownMessageBox.ShowInformation(strSucess, "Info");
                }
            }
            else
            {
                log(strFail);
                ReaLTaiizor.Controls.CrownMessageBox.ShowError(strFail, "Info");
            }
        }

        private void btn_search_app_Click(object sender, EventArgs e)
        {
            string strSucess = "App encontrado e exibido!";
            string strFail = "Nenhum App foi encontrado com esse nome para ser exibido!";
            string strFailKey = "É necessário definir uma chave de criptografia inicialmente.";
            string login = iniFile.Read("login", txb_search_app.Text);
            string senha = iniFile.Read("password", txb_search_app.Text);

            if (String.IsNullOrEmpty(strEncryptDecrypt))
            {
                log(strFailKey);
                ReaLTaiizor.Controls.CrownMessageBox.ShowError(strFailKey, "Info");
                return;
            }

            if (!String.IsNullOrEmpty(login) && !String.IsNullOrEmpty(senha))
            {
                txb_search_login.Text = login;
                txb_search_password.Text = encrypt.strDecrypt(senha, strEncryptDecrypt);
                log(strSucess);
                ReaLTaiizor.Controls.CrownMessageBox.ShowInformation(strSucess, "Info");
            }
            else
            {
                log(strFail);
                ReaLTaiizor.Controls.CrownMessageBox.ShowError(strFail, "Info");
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_encrypt_decrypt_Click(object sender, EventArgs e)
        {
            strEncryptDecrypt = txb_encrypt_decrypt.Text;
        }

        private void preencherSecoes()
        {
            autoCompleteCollection.Clear();

            if (!File.Exists(iniFile.Path))
                return;

            foreach (string name in iniFile.ReadAllSectionsName())
                autoCompleteCollection.Add(name);

            txb_search_app.AutoCompleteCustomSource = autoCompleteCollection;
            txb_remove.AutoCompleteCustomSource = autoCompleteCollection;
        }

        private void log(string msg)
        {
            txb_log.Text += DateTime.Now + " - " + msg + Environment.NewLine;
        }
    }
}
