using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Criptografia
{
    public partial class MainMenu : Form
    {
        public static string[] users;
        public static string[] passwords;
        readonly string hash = @"foxle@rn";

        private readonly string name = string.Empty;
        private readonly MessageBoxButtons button = MessageBoxButtons.OK;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            labSCS.Select();
            Database.LoadData(users, passwords);
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

            if (user == string.Empty || password == string.Empty) MessageBox.Show("Por favor, preencha todos os campos.", name, button, MessageBoxIcon.Warning);
            else
            {
                if (user.Contains('|'))
                {
                    MessageBox.Show("O nome de usuário não deve conter o símbolo illegal!", name, button, MessageBoxIcon.Error);
                    return;
                }

                List<string> usuarios = new List<string>();
                List<string> senhas = new List<string>();

                string encrypted_password = EncryptPassword(password);

                if (users != null && passwords != null)
                {
                    if (users.Contains(user))
                    {
                        MessageBox.Show("O nome de usuário já foi cadastrado!", name, button, MessageBoxIcon.Warning);
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

                MessageBox.Show("O usuário foi cadastrado com sucesso!", name, button, MessageBoxIcon.Information);
                Database.SaveData(users, passwords);
                MainMenu_Load(sender, e);
                txtUser_01.Text = string.Empty;
                txtPassword_01.Text = string.Empty;
            }
        }

        private void BtnAuthenticate_Click(object sender, EventArgs e)
        {
            string user = txtUser_02.Text;
            string password = txtPassword_02.Text;

            if (user == string.Empty || password == string.Empty) MessageBox.Show("Por favor, preencha todos os campos.", name, button, MessageBoxIcon.Warning);
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
                                    MessageBox.Show("O usuário foi autenticado com sucesso!", name, button, MessageBoxIcon.Information);
                                    return;
                                }
                                else
                                {
                                    MessageBox.Show("A senha está incorreta!", name, button, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }
                    }
                    else MessageBox.Show("Nenhum usuario encontrado.", name, button, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("Nenhum usuario encontrado.", name, button, MessageBoxIcon.Warning);
            }
        }
    }
}
