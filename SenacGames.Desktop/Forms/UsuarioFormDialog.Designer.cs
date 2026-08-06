// =============================================================================
// SenacGames.Desktop - Forms/UsuarioFormDialog.Designer.cs
// =============================================================================
// ️ ARQUIVO GERADO PELO DESIGNER — NÃO EDITE MANUALMENTE
// Toda lógica de negócio deve estar em UsuarioFormDialog.cs
// =============================================================================

namespace SenacGames.Desktop.Forms
{
    partial class UsuarioFormDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        // =====================================================================
        // DECLARAÇÕES DOS CONTROLES — todos como campos privados
        // =====================================================================
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label lblSenha;
        private Guna.UI2.WinForms.Guna2TextBox txtSenha;
        private System.Windows.Forms.Label lblConf;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmar;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.ComboBox cmbPerfil;
        private Guna.UI2.WinForms.Guna2Button btnSalvar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;

        // =====================================================================
        // INITIALIZECOMPONENT — formato padrão do Windows Forms Designer
        // =====================================================================
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblTitulo = new Label();
            lblEmail = new Label();
            txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            lblSenha = new Label();
            txtSenha = new Guna.UI2.WinForms.Guna2TextBox();
            lblConf = new Label();
            txtConfirmar = new Guna.UI2.WinForms.Guna2TextBox();
            lblPerfil = new Label();
            cmbPerfil = new ComboBox();
            btnSalvar = new Guna.UI2.WinForms.Guna2Button();
            btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(0, 75, 135);
            lblTitulo.Location = new Point(24, 16);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(400, 36);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "👤 Novo Usuário";
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(51, 61, 75);
            lblEmail.Location = new Point(24, 64);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(400, 18);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "E-MAIL *";
            // 
            // txtEmail
            // 
            txtEmail.BorderColor = Color.FromArgb(224, 228, 235);
            txtEmail.BorderRadius = 6;
            txtEmail.CustomizableEdges = customizableEdges1;
            txtEmail.DefaultText = "";
            txtEmail.FillColor = Color.FromArgb(245, 247, 250);
            txtEmail.Font = new Font("Segoe UI", 9.5F);
            txtEmail.Location = new Point(24, 84);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "usuario@email.com";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtEmail.Size = new Size(400, 40);
            txtEmail.TabIndex = 2;
            // 
            // lblSenha
            // 
            lblSenha.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblSenha.ForeColor = Color.FromArgb(51, 61, 75);
            lblSenha.Location = new Point(24, 136);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(400, 18);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "SENHA *";
            // 
            // txtSenha
            // 
            txtSenha.BorderColor = Color.FromArgb(224, 228, 235);
            txtSenha.BorderRadius = 6;
            txtSenha.CustomizableEdges = customizableEdges3;
            txtSenha.DefaultText = "";
            txtSenha.FillColor = Color.FromArgb(245, 247, 250);
            txtSenha.Font = new Font("Segoe UI", 9.5F);
            txtSenha.Location = new Point(24, 156);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "••••••••";
            txtSenha.SelectedText = "";
            txtSenha.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtSenha.Size = new Size(400, 40);
            txtSenha.TabIndex = 4;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // lblConf
            // 
            lblConf.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblConf.ForeColor = Color.FromArgb(51, 61, 75);
            lblConf.Location = new Point(24, 208);
            lblConf.Name = "lblConf";
            lblConf.Size = new Size(400, 18);
            lblConf.TabIndex = 5;
            lblConf.Text = "CONFIRMAR SENHA *";
            // 
            // txtConfirmar
            // 
            txtConfirmar.BorderColor = Color.FromArgb(224, 228, 235);
            txtConfirmar.BorderRadius = 6;
            txtConfirmar.CustomizableEdges = customizableEdges5;
            txtConfirmar.DefaultText = "";
            txtConfirmar.FillColor = Color.FromArgb(245, 247, 250);
            txtConfirmar.Font = new Font("Segoe UI", 9.5F);
            txtConfirmar.Location = new Point(24, 228);
            txtConfirmar.Name = "txtConfirmar";
            txtConfirmar.PlaceholderText = "••••••••";
            txtConfirmar.SelectedText = "";
            txtConfirmar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtConfirmar.Size = new Size(400, 40);
            txtConfirmar.TabIndex = 6;
            txtConfirmar.UseSystemPasswordChar = true;
            // 
            // lblPerfil
            // 
            lblPerfil.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblPerfil.ForeColor = Color.FromArgb(51, 61, 75);
            lblPerfil.Location = new Point(24, 280);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(400, 18);
            lblPerfil.TabIndex = 7;
            lblPerfil.Text = "PERFIL (ROLE)";
            // 
            // cmbPerfil
            // 
            cmbPerfil.BackColor = Color.FromArgb(245, 247, 250);
            cmbPerfil.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPerfil.FlatStyle = FlatStyle.Flat;
            cmbPerfil.Font = new Font("Segoe UI", 9.5F);
            cmbPerfil.Items.AddRange(new object[] { "User", "Admin" });
            cmbPerfil.Location = new Point(24, 300);
            cmbPerfil.Name = "cmbPerfil";
            cmbPerfil.Size = new Size(400, 25);
            cmbPerfil.TabIndex = 8;
            // 
            // btnSalvar
            // 
            btnSalvar.BorderRadius = 8;
            btnSalvar.CustomizableEdges = customizableEdges7;
            btnSalvar.FillColor = Color.FromArgb(40, 167, 69);
            btnSalvar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(24, 358);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnSalvar.Size = new Size(160, 42);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "💾 Criar Usuário";
            btnSalvar.Click += btnSalvar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.BorderColor = Color.FromArgb(224, 228, 235);
            btnCancelar.BorderRadius = 8;
            btnCancelar.BorderThickness = 1;
            btnCancelar.CustomizableEdges = customizableEdges9;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.FillColor = Color.FromArgb(245, 247, 250);
            btnCancelar.Font = new Font("Segoe UI", 9F);
            btnCancelar.ForeColor = Color.FromArgb(51, 61, 75);
            btnCancelar.Location = new Point(200, 358);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnCancelar.Size = new Size(100, 42);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // UsuarioFormDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(460, 420);
            Controls.Add(lblTitulo);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblSenha);
            Controls.Add(txtSenha);
            Controls.Add(lblConf);
            Controls.Add(txtConfirmar);
            Controls.Add(lblPerfil);
            Controls.Add(cmbPerfil);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UsuarioFormDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Novo Usuário";
            ResumeLayout(false);
        }
    }
}
