namespace tpAula2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularNota_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.P1 = txtP1.Text;
            aluno.P2 = txtP2.Text;
            aluno.P3 = txtP3.Text;
            aluno.P4 = txtP4.Text;
            txtResultado.Text = aluno.getMedia();
        }
    }
}