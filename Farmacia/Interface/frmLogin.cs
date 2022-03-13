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
    public partial class frmLogin : Form
    {
        RegraNegocio.Criptografia criptografia;
        RegraNegocio.UsuariosRegraNegocio novoUsuario;
        public int idUsuario; //Variável para armazenar a identificação do usuário que fizer o login. (public para poder reutilizada fora do form)

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            /*Informa a propriedade DialogResult desse formulário que terá o valor que liberará a entrada ao programa,
             * porém somente após ser verificado Login e Senha. */
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnEntrar_Click(object sender, EventArgs e) //Realiza as verificações necessárias para entrar no sistema.
        {
            try
            {
                criptografia = new RegraNegocio.Criptografia(); //↓↓ Criptografa o txtSenha antes de passar pela verificação abaixo
                string senhaCripto = criptografia.Criptografar(txtSenha.Text); //Armazena o conteudo do txtSenha já codificado em uma variável do tipo string.
                novoUsuario = new RegraNegocio.UsuariosRegraNegocio();

                /* Cria um objeto da classe DataTable e depois atribui a ele o método Login, tendo como base as informações digitadas [...] 
                 * nos campos Usuario e Senha do formulário. */ 
                DataTable dadosTabela = new DataTable(); //       ↓↓↓↓↓ não dá pra entrar com usuários cuja senha ainda não foram codificados, troque pelo txtSenha se preciso
                dadosTabela = novoUsuario.Login(txtUsuario.Text, senhaCripto); //Para o usuário entrar no sistema, é feito a busca no banco verificando o nome e senha.
                //Se deixar a busca ser feita diretamente pelo ↑↑↑↑↑ contéudo da txtSenha, ela não será encontrada, pois a senha gravada no banco está criptografada (corrigido)


                if (dadosTabela.Rows.Count == 0) //Verifica se o nome do usuário ou a senha não foram encontrados no banco.
                {
                    MessageBox.Show("Usuário ou senha inválidos!", "Entrada não permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (dadosTabela.Rows[0]["STATUS_USUARIO"].ToString() == "Inativo")
                    {
                        MessageBox.Show("Conta de usuário inativa \nContate com o administrador do sistema!", "Entrada não permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else //Caso tenha encontrado no banco as informações, aparecerá uma mensagem de boas vindas, a abertura da aplicação e fecha essa janela.
                    {
                        MessageBox.Show("Olá, " + dadosTabela.Rows[0]["NOME_USUARIO"].ToString() + ".\nBem-vindo ao sistema!", "Bem-vindo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        /*Armazena os dados do usuário que entrou no programa por meio das informações digitadas nos campos do frmLogin. Com o id do usuário, [...]
                         * será programado para que o frmPrincipal entre usando como referência a identificação do usuário. E esse local é na classe Program. */
                        idUsuario = Convert.ToInt32(dadosTabela.Rows[0]["ID_USUARIO"]); // pq armazenar o id?  --- resposta acima

                        /* A entrada do usuário no sistema só acontecerá se a propriedade DialogResult estiver com o valor OK, que, como programado nesse botão,
                         * isso somente ocorre se ele passar pelas verificações necessárias. */
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Evento KeyPress, que captura todas as teclas pressionadas sobre o componente vinculado
        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e) 
        {
            if ((Keys)e.KeyChar == Keys.Enter) //Acessa o parâmetro KeyPressEventArgs para comparar se a tecla que foi acionada é o Enter.
            {
                //Chama o evento click do botão btnEntrar. Como ele é um evento, devemos passar os mesmos parâmetros do evento txtSenha_Keypress.
                btnEntrar_Click(sender, e);
            }
        }
    }
}
