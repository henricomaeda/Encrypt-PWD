using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Criptografia
{
    public partial class MainMenu : Form
    {
        readonly string hash = @"foxle@rn";
        string[] users;
        string[] passwords;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.Select();
            if (users != null && passwords != null)
            {
                this.dgvUsers.Rows.Clear();

                for (int count = 0; count < users.Length; count++)
                {
                    this.dgvUsers.Rows.Add(users[count].ToString(), passwords[count].ToString());
                }

                this.dgvUsers.ClearSelection();
            }
        }

        public string EncryptPassword(string password)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(password);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripleDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripleDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return(Convert.ToBase64String(results));
                }
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string user = txtUser_01.Text;
            string password = txtPassword_01.Text;

            if (user == string.Empty || password == string.Empty) MessageBox.Show("Por favor, preencha todos os campos");
            else
            {
                List<string> usuarios = new List<string>();
                List<string> senhas = new List<string>();

                string encrypted_password = EncryptPassword(password);

                if (users != null && passwords != null)
                {
                    if (users.Contains(user))
                    {
                        MessageBox.Show("O usuário já foi cadastrado.");
                        return;
                    }
                    else
                    {
                        foreach (string temp_user in users)
                        {
                            usuarios.Add(temp_user);
                        }

                        foreach (string temp_password in passwords)
                        {
                            senhas.Add(temp_password);
                        }
                    }
                }

                usuarios.Add(user);
                users = usuarios.ToArray();

                senhas.Add(encrypted_password);
                passwords = senhas.ToArray();

                MessageBox.Show("O usuário foi cadastrado com sucesso!");
                MainMenu_Load(sender, e);
                txtUser_01.Text = string.Empty;
                txtPassword_01.Text = string.Empty;
            }
        }

        private void BtnAuthenticate_Click(object sender, EventArgs e)
        {
            string user = txtUser_02.Text;
            string password = txtPassword_02.Text;

            if (user == string.Empty || password == string.Empty) MessageBox.Show("Por favor, preencha todos os campos.");
            else
            {
                if (users != null && passwords != null)
                {
                    string encrypted_password = EncryptPassword(password);

                    if (users.Contains(user))
                    {
                        for (int count = 0; count <= users.Length; count++)
                        {
                            if (user == users[count])
                            {
                                if (encrypted_password == passwords[count])
                                {
                                    MessageBox.Show("O usuário foi autenticado!");
                                    return;
                                }
                                else
                                {
                                    MessageBox.Show("A senha está incorreta.");
                                    return;
                                }
                            }
                        }
                    }
                    else MessageBox.Show("Nenhum usuario encontrado.");
                }
                else MessageBox.Show("Nenhum usuario encontrado.");
            }
        }
    }
}
