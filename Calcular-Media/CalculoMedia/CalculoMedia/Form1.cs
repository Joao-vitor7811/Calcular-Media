namespace CalculoMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Validação das entradas
                if (string.IsNullOrWhiteSpace(txtNota1.Text) || string.IsNullOrWhiteSpace(txtNota2.Text) || string.IsNullOrWhiteSpace(txtNota3.Text))
                {
                    MessageBox.Show("Por favor, preencha todas as notas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Conversão das notas
                if (!double.TryParse(txtNota1.Text, out double nota1) ||
                    !double.TryParse(txtNota2.Text, out double nota2) ||
                    !double.TryParse(txtNota3.Text, out double nota3))
                {
                    MessageBox.Show("Insira valores numéricos válidos para as notas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Verificação de limites das notas
                if (nota1 < 0 || nota1 > 10 || nota2 < 0 || nota2 > 10 || nota3 < 0 || nota3 > 10)
                {
                    MessageBox.Show("As notas devem estar entre 0 e 10.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Cálculo da média
                double media = (nota1 + nota2 + nota3) / 3;

                // Exibição do resultado
                txtMedia.Text = media.ToString("F2");
                textBox2.Text = media >= 7 ? "Aprovado" : "Reprovado";
            }
            catch (Exception ex)
            {
                // Tratamento de erros inesperados
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpa os campos de entrada e saída
            txtNota1.Text = string.Empty;
            txtNota2.Text = string.Empty;
            txtNota3.Text = string.Empty;
            txtMedia.Text = string.Empty;
            textBox2.Text = string.Empty;

            // Foco no primeiro campo
            txtNota1.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // Fecha o aplicativo
            var confirmResult = MessageBox.Show("Tem certeza de que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

