using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetroCRUD
{
    public partial class CRUDJoog : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Arquivos\\dowloads\\banco\\Banco_Heranca.mdf;Integrated Security=True;Connect Timeout=30");

        public void CarregaDgvJogo()
        {
            String query = "SELECT * FROM Jogos";
            SqlCommand cmd = new SqlCommand(query, con);
            if (con.State == ConnectionState.Open) { con.Close(); }
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable jogo = new DataTable();
            da.Fill(jogo);
            dgvJogos.DataSource = jogo;
            con.Close();
        }

        public CRUDJoog()
        {
            InitializeComponent();
            CarregaDgvJogo();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "SELECT * FROM Jogos WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", this.txtId.Text);
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    txtId.Text = rd["id"].ToString();
                    txtNome.Text = rd["nome"].ToString();
                    cbxTipo.Text = rd["tipo"].ToString();
                    txtDev.Text = rd["desenvolvedora"].ToString();
                    txtPreço.Text = rd["preco"].ToString();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado!", "Sem registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "INSERT INTO Jogos(nome, tipo, desenvolvedora, preco) VALUES(@nome, @tipo, @dev, @preco)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@tipo", cbxTipo.Text);
                cmd.Parameters.AddWithValue("@dev", txtDev.Text);
                cmd.Parameters.AddWithValue("@preco", SqlDbType.Decimal).Value = Convert.ToDecimal(txtPreço.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Cadastro Realizado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaDgvJogo();
            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            String query = "UPDATE Jogos SET(nome = @nome, tipo = @tipo, desenvolvedora = @dev, preco = @preco) WHERE id = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = Convert.ToInt32(txtId.Text);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@estilo", cbxTipo.Text);
            cmd.Parameters.AddWithValue("@criador", txtDev.Text);
            cmd.Parameters.AddWithValue("@preço", SqlDbType.Decimal).Value = Convert.ToDecimal(txtPreço.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            CarregaDgvJogo();
            MessageBox.Show("Registro atualizado com sucesso!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            txtId.Text = "";
            txtNome.Text = "";
            cbxTipo.Text = "";
            txtDev.Text = "";
            txtPreço.Text = "";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            String query = "DELETE * FROM Jogos WHERE id = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", this.txtId.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            CarregaDgvJogo();
            MessageBox.Show("Registro apagado com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            txtId.Text = "";
            txtNome.Text = "";
            cbxTipo.Text = "";
            txtDev.Text = "";
            txtPreço.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvJogos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvJogos.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                cbxTipo.Text = row.Cells[2].Value.ToString();
                txtDev.Text = row.Cells[3].Value.ToString();
                txtPreço.Text = row.Cells[4].Value.ToString();
            }
        }

        private void CRUDJoog_Load(object sender, EventArgs e)
        {
            cbxTipo.Items.Add("RPG");
            cbxTipo.Items.Add("FPS");
            cbxTipo.Items.Add("Aventura");
            cbxTipo.Items.Add("Esporte");
        }
    }
}
