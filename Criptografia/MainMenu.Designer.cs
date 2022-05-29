namespace Criptografia
{
    partial class MainMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.txtUser_01 = new System.Windows.Forms.TextBox();
            this.txtPassword_01 = new System.Windows.Forms.TextBox();
            this.labUser_01 = new System.Windows.Forms.Label();
            this.labPassword_01 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.labRegistration = new System.Windows.Forms.Label();
            this.labConnection = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.labPassword_02 = new System.Windows.Forms.Label();
            this.labUser_02 = new System.Windows.Forms.Label();
            this.txtPassword_02 = new System.Windows.Forms.TextBox();
            this.txtUser_02 = new System.Windows.Forms.TextBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labSCS = new System.Windows.Forms.Label();
            this.labTitle = new System.Windows.Forms.Label();
            this.labLine = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUser_01
            // 
            this.txtUser_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser_01.Location = new System.Drawing.Point(26, 128);
            this.txtUser_01.Name = "txtUser_01";
            this.txtUser_01.Size = new System.Drawing.Size(268, 26);
            this.txtUser_01.TabIndex = 0;
            // 
            // txtPassword_01
            // 
            this.txtPassword_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword_01.Location = new System.Drawing.Point(26, 189);
            this.txtPassword_01.Name = "txtPassword_01";
            this.txtPassword_01.Size = new System.Drawing.Size(268, 26);
            this.txtPassword_01.TabIndex = 1;
            this.txtPassword_01.UseSystemPasswordChar = true;
            // 
            // labUser_01
            // 
            this.labUser_01.AutoSize = true;
            this.labUser_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUser_01.Location = new System.Drawing.Point(22, 105);
            this.labUser_01.Name = "labUser_01";
            this.labUser_01.Size = new System.Drawing.Size(64, 20);
            this.labUser_01.TabIndex = 2;
            this.labUser_01.Text = "Usuário";
            // 
            // labPassword_01
            // 
            this.labPassword_01.AutoSize = true;
            this.labPassword_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPassword_01.Location = new System.Drawing.Point(22, 166);
            this.labPassword_01.Name = "labPassword_01";
            this.labPassword_01.Size = new System.Drawing.Size(56, 20);
            this.labPassword_01.TabIndex = 3;
            this.labPassword_01.Text = "Senha";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(26, 221);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(268, 33);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Cadastrar";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // labRegistration
            // 
            this.labRegistration.AutoSize = true;
            this.labRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRegistration.Location = new System.Drawing.Point(22, 68);
            this.labRegistration.Name = "labRegistration";
            this.labRegistration.Size = new System.Drawing.Size(84, 24);
            this.labRegistration.TabIndex = 10;
            this.labRegistration.Text = "Cadastro";
            // 
            // labConnection
            // 
            this.labConnection.AutoSize = true;
            this.labConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labConnection.Location = new System.Drawing.Point(22, 301);
            this.labConnection.Name = "labConnection";
            this.labConnection.Size = new System.Drawing.Size(87, 24);
            this.labConnection.TabIndex = 16;
            this.labConnection.Text = "Conexão";
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(26, 451);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(268, 33);
            this.btnConnect.TabIndex = 15;
            this.btnConnect.Text = "Conectar";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnAuthenticate_Click);
            // 
            // labPassword_02
            // 
            this.labPassword_02.AutoSize = true;
            this.labPassword_02.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPassword_02.Location = new System.Drawing.Point(22, 396);
            this.labPassword_02.Name = "labPassword_02";
            this.labPassword_02.Size = new System.Drawing.Size(56, 20);
            this.labPassword_02.TabIndex = 14;
            this.labPassword_02.Text = "Senha";
            // 
            // labUser_02
            // 
            this.labUser_02.AutoSize = true;
            this.labUser_02.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUser_02.Location = new System.Drawing.Point(22, 335);
            this.labUser_02.Name = "labUser_02";
            this.labUser_02.Size = new System.Drawing.Size(64, 20);
            this.labUser_02.TabIndex = 13;
            this.labUser_02.Text = "Usuário";
            // 
            // txtPassword_02
            // 
            this.txtPassword_02.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword_02.Location = new System.Drawing.Point(26, 419);
            this.txtPassword_02.Name = "txtPassword_02";
            this.txtPassword_02.Size = new System.Drawing.Size(268, 26);
            this.txtPassword_02.TabIndex = 12;
            this.txtPassword_02.UseSystemPasswordChar = true;
            // 
            // txtUser_02
            // 
            this.txtUser_02.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser_02.Location = new System.Drawing.Point(26, 358);
            this.txtUser_02.Name = "txtUser_02";
            this.txtUser_02.Size = new System.Drawing.Size(268, 26);
            this.txtUser_02.TabIndex = 11;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToResizeColumns = false;
            this.dgvUsers.AllowUserToResizeRows = false;
            this.dgvUsers.ColumnHeadersHeight = 30;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Password});
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvUsers.Location = new System.Drawing.Point(325, 0);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowHeadersWidth = 40;
            this.dgvUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUsers.Size = new System.Drawing.Size(358, 507);
            this.dgvUsers.TabIndex = 31;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Usuários";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Password.HeaderText = "Senhas";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // labSCS
            // 
            this.labSCS.AutoSize = true;
            this.labSCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSCS.Location = new System.Drawing.Point(22, 19);
            this.labSCS.Name = "labSCS";
            this.labSCS.Size = new System.Drawing.Size(47, 24);
            this.labSCS.TabIndex = 33;
            this.labSCS.Text = "SCS";
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.Location = new System.Drawing.Point(67, 22);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(227, 17);
            this.labTitle.TabIndex = 34;
            this.labTitle.Text = "Sistema de Criptografia de Senhas";
            // 
            // labLine
            // 
            this.labLine.BackColor = System.Drawing.Color.Transparent;
            this.labLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labLine.Location = new System.Drawing.Point(23, 280);
            this.labLine.Name = "labLine";
            this.labLine.Size = new System.Drawing.Size(271, 2);
            this.labLine.TabIndex = 35;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 507);
            this.Controls.Add(this.labLine);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.labSCS);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.labConnection);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.labPassword_02);
            this.Controls.Add(this.labUser_02);
            this.Controls.Add(this.txtPassword_02);
            this.Controls.Add(this.txtUser_02);
            this.Controls.Add(this.labRegistration);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.labPassword_01);
            this.Controls.Add(this.labUser_01);
            this.Controls.Add(this.txtPassword_01);
            this.Controls.Add(this.txtUser_01);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encrypt PWD";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser_01;
        private System.Windows.Forms.TextBox txtPassword_01;
        private System.Windows.Forms.Label labUser_01;
        private System.Windows.Forms.Label labPassword_01;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label labRegistration;
        private System.Windows.Forms.Label labConnection;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label labPassword_02;
        private System.Windows.Forms.Label labUser_02;
        private System.Windows.Forms.TextBox txtPassword_02;
        private System.Windows.Forms.TextBox txtUser_02;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label labSCS;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.Label labLine;
    }
}

