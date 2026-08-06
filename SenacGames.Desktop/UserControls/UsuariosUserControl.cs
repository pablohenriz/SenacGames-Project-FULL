using SenacGames.Desktop.DTOs;
using SenacGames.Desktop.Forms;
using SenacGames.Desktop.Helpers;
using SenacGames.Desktop.Services;
using SenacGames.Desktop.Themes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacGames.Desktop.UserControls
{
    public partial class UsuariosUserControl : UserControl
    {
        /// =====================================
        /// SERVIÇOS (Inicializados no load) 
        /// =====================================

        private UsuariosApiService? _UsuarioService = null;


        /// =====================================
        /// Dados 
        /// =====================================
        private List<UsuarioResponseDto> _todosUsuarios = new();


        public UsuariosUserControl()
        {
            InitializeComponent();
        }

        private void UsuariosUserControl_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            _UsuarioService = new UsuariosApiService();
            SenacTheme.AplicarEstiloGrid(gridUsuarios);
            ConfigurarPermissões();

            _ = CarregarDadosAsync();
        }

        private async Task CarregarDadosAsync()
        {
            try
            {
                // Certifique-se de que o serviço retorna a lista corretamente
                var usuarios = await _UsuarioService.GetAllAsync();
                gridUsuarios.Rows.Clear();

                if (usuarios != null)
                {
                    _todosUsuarios = usuarios;
                    foreach (var u in usuarios)
                    {
                        // Adiciona as colunas na mesma ordem em que foram criadas no DataGridView
                        gridUsuarios.Rows.Add(u.Id, u.Email, u.PerfilPrincipal);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar usuários: {ex.Message}",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void ConfigurarPermissões()
        {
            //Verifica se o usuário logado é administrador
            bool isAdmin = SessionManager.Instance.IsAdmin;
            //Se não for admin, desabilita os botões de gerenciamento
            btnNovo.Enabled = isAdmin;

            btnExcluir.Enabled = isAdmin;
        }


        private void txtPesquisa_TextChanged(object sender, EventArgs e) => FiltrarUsuarios(txtPesquisa.Text);


        private void FiltrarUsuarios(string filtro)
        {
            var usuariosFiltrados = _todosUsuarios
                .Where(u => u.Email.Contains(filtro, StringComparison.OrdinalIgnoreCase))
                .ToList();
            gridUsuarios.Rows.Clear();
            foreach (var u in usuariosFiltrados)
            {
                gridUsuarios.Rows.Add(u.Id, u.Email, u.PerfilPrincipal);
            }

        }

        private async void btnNovo_Click(object sender, EventArgs e)
        {
            using var form = new UsuarioFormDialog();
            if (form.ShowDialog() == DialogResult.OK && form.UsuarioDto != null)
            {
                var (success, _, error) = await _UsuarioService.CreateAsync(form.UsuarioDto);
                if (success)
                {
                    MessageBox.Show("✅ Usuário criado com sucesso!",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    await CarregarDadosAsync();
                }
                else
                {
                    MessageBox.Show($"❌ {error}",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                }
            }
        }

        private UsuarioResponseDto? ObterUsuarioSelecionado()
        {
            if (gridUsuarios.SelectedRows.Count == 0) return null;
            var row = gridUsuarios.SelectedRows[0];
            var id = row.Cells["colId"].Value?.ToString();
            return _todosUsuarios.FirstOrDefault(u => u.Id == id);
        }

        private async void btnAtualizar_Click(object sender, EventArgs e) => await CarregarDadosAsync();

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            var usuario = ObterUsuarioSelecionado();
            if (usuario == null)
            {
                MessageBox.Show("Selecione um usuário para editar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            using var form = new UsuarioFormDialog(usuario);
            if (form.ShowDialog() == DialogResult.OK && form.UsuarioUpdateDto != null)
            {
                var (success, _, error) = await _UsuarioService.UpdateAsync(usuario.Id, form.UsuarioUpdateDto);
                if (success)
                {
                    MessageBox.Show("✅ Usuário atualizado com sucesso!",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    await CarregarDadosAsync();
                }
                else
                {
                    MessageBox.Show($"❌ {error}",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }

        private async void btnExcluir_Click_1(object sender, EventArgs e)
        {
            var u = ObterUsuarioSelecionado();
            if (u == null)
            {
                MessageBox.Show("Selecione um usuário para excluir.", "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var conf = MessageBox.Show($"Deseja excluir o usuário \"{u.Email}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (conf != DialogResult.Yes) return;

            var (success, error) = await _UsuarioService.DeleteAsync(u.Id);
            if (success)
            {
                MessageBox.Show("✅ Usuário excluído com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                await CarregarDadosAsync();
            }
            else
            {
                MessageBox.Show($"❌ {error}",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}