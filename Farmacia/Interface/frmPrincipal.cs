using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class frmPrincipal : Form
    {
        RegraNegocio.UsuariosRegraNegocio novoUsuario;

        int idUsuario; //Variável que armazenará a identificação do usuário por meio da variável de mesmo nome no frmLogin. 3 
        string nomeUsuario, nivelUsuario; //Variáveis para carregar o nome e o nível usuário no sistema.

        public frmPrincipal(int idUsuario) //Método construtor com o parâmetro baseado na identificação do usuário do frmLogin.
        {
            InitializeComponent();
            this.idUsuario = idUsuario; //Indica que o parâmetro passado nesse método construtor receberá o conteúdo da variável de mesmo nome.
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();
            clientes.Show();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            frmProdutos produtos = new frmProdutos();
            produtos.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios usuarios = new frmUsuarios();
            usuarios.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CarregaDadosUsuario(); //Carrega os dados do usuário nos componentes da StatusStrip.
            //Verifica assim que o usuário logar no sistema a habilitação do menu de opções, no qual será condicionado conforme o nível.
            VerificaNivelUsuario();
        }

        public void CarregaDadosUsuario()
        {
            try
            {
                novoUsuario = new RegraNegocio.UsuariosRegraNegocio();
                DataTable dadosTabela = new DataTable();
                //Chama o método RetornarUsuário baseado na identificação de quem entrou no sistema, e armazena isso no DataTable.
                dadosTabela = novoUsuario.RetornarUsuario(idUsuario);

                //Informa as variáveis que elas receberão da base de dados as informações referentes ao nome e nível.
                nomeUsuario = dadosTabela.Rows[0]["NOME_USUARIO"].ToString();
                nivelUsuario = dadosTabela.Rows[0]["NOME_NIVEL"].ToString();

                //Informa o que cada StatusLabel receberá como texto.
                lblUsuario.Text = "Usuario: " + nomeUsuario;
                lblNivel.Text = "Nivel: " + nivelUsuario;
                lblData.Text = DateTime.Today.ToShortDateString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e) //Evento click para saber se o usuário deseja realizar o LogOut do sistema.
        {
            //O MessageBox será a verificacão que a estrutura condicional if realizará, comparando com a escolha do usuário sobre o MessageBox.
            if (MessageBox.Show("Deseja realmente efetuar o LogOut?", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                //Se a condição retonar true("Sim"), será executado o formulário frmLogin, solicitando ao usuário suas credencias de login no sistema.
                frmLogin login = new frmLogin();
                login.ShowDialog(); //Abre o frmLogin com o objetivo de possibilitar outro usuário realizar o login com credencias diferentes.

                /* Realiza a verificação da propriedade DialogResult do frmLogin, se ele é igual a OK.
                 * Se essa verificação não fosse condicionada, será retornado um erro com um aviso "Não há linhas na posição 0". */
                if (login.DialogResult == DialogResult.OK)
                {
                    //Se a condição retornar true, assim que o usuário clicar sobre o botão Entrar, será mostrado no frmPrincipal as informações atualizadas sobre o novo login.
                    idUsuario = login.idUsuario; //Acessa o conteúdo da variável idUsuario do frmLogin para poder 'atualizar' o evento frmPrincipal_Load novamente.

                    /* Para isso utilizaremos a propriedade OnLoad, pois através dela será disparado o evento Load, executando-o novamente. Podemos executar o [...]
                     * evento Load a qualquer momento da execução de um programa utilizando essa propriedade. Ela precisa receber como parâmetro os argumentos do evento
                     * para ser executada. Nesse caso, ela recebe como parâmetro a variável "e" desse evento. */
                    this.OnLoad(e); //O evento frmPrincipal_Load é executado novamente, atualizando o formulário.
                }

            }
        }

        //Evento Timer do tipo Tick, que é desencadeado sempre que o intervalo de horas especificado decorre/elapsa.
        private void relogio_Tick(object sender, EventArgs e) //Quando tiver passado o intervalo da propriedade Interval do componente Timer, ele será executado.
        {
            //A hora será obtida através da propriedade ToLongtimeString da classe DateTime.Now
            lblHorario.Text = DateTime.Now.ToLongTimeString(); //Atribui a StatusLabel lblHorario a hora atual do SO (sistema operacional) em formato extenso.
        }

        //Define as permissões dos níveis de acesso na Tela Principal
        private void VerificaNivelUsuario() //Método que controla o que cada usuário poderá efetuar no sistema de acordo com o nível do usuário
        {
            switch (nivelUsuario) //Utiliza a variável global nivelUsuario (que armazena o nome do nível) como base para as condições a seguir
            {
                case "Gerente":
                    btnProdutos.Enabled = true;
                    btnClientes.Enabled = true;
                    btnUsuarios.Enabled = false; //O Gerente só não poderá realizar ações referentes aos usuários do sistema.
                    btnVendas.Enabled = true;
                    btnRelatorios.Enabled = true;
                    btnCaixa.Enabled = true;
                    break;

                case "Balconista":
                    btnProdutos.Enabled = false;
                    btnClientes.Enabled = false;
                    btnUsuarios.Enabled = false;
                    btnVendas.Enabled = true;
                    btnRelatorios.Enabled = false;
                    btnCaixa.Enabled = false;
                    break;

                case "Conferente":
                    btnProdutos.Enabled = true;
                    btnClientes.Enabled = false;
                    btnUsuarios.Enabled = false;
                    btnVendas.Enabled = false;
                    btnRelatorios.Enabled = false;
                    btnCaixa.Enabled = false;
                    break;

                default: //Todas as funções do projeto estarão habilitadas por default (no caso, para o Administrador)
                    btnProdutos.Enabled = true;
                    btnClientes.Enabled = true;
                    btnUsuarios.Enabled = true;
                    btnVendas.Enabled = true;
                    btnRelatorios.Enabled = true;
                    btnCaixa.Enabled = true;
                    break;
            }
        }
    }
}
