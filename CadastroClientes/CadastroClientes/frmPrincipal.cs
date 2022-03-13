using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroClientes
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnPessoaFisica_Click(object sender, EventArgs e) // Evento Click do botão PessoaFísica
        {
            painelPessoaFisica.Visible = true; //Deixa visível o painel destinado à Pessoa Física
            painelPessoaJuridica.Visible = false; //Deixa invisível o painel destinado à Pessoa Jurídica
        }

        private void txtPessoaJuridica_Click(object sender, EventArgs e) //Evento Click do botão PessoaJurídica
        {
            painelPessoaJuridica.Visible = true; //Deixa visível o painel destinado à Pessoa Jurídica
            painelPessoaFisica.Visible = false; //Deixa invisível o painel destinado à Pessoa Física
        }

        public void Limpar()
        {
            if (painelPessoaFisica.Visible == true) //Se o painel PessoaFisica estiver visível
            {
                txtNomePessoaFisica.Text = "";       //Limpa o texto da caixa de texto Nome 
                txtEnderecoPessoaFisica.Text = "";   //Limpa o texto da caixa de texto Endereco
                txtRG.Text = "";                     //Limpa o texto da caixa de texto RG
                txtCPF.Text = "";                    //Limpa o texto da caixa de texto CPF 
            }
            else
            {
                txtNomePessoaJuridica.Text = "";      //Limpa o texto da caixa de texto Nome 
                txtEnderecoPessoaJuridica.Text = "";  //Limpa o texto da caixa de texto Endereco
                txtCNPJ.Text = "";                    //Limpa o texto da caixa de texto CNPJ
                txtIE.Text = "";                      //Limpa o texto da caixa de texto IE 
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e) //Evento Click do botão Salvar
        {
            if (painelPessoaFisica.Visible == true) //Se o paínel PessoaFisica estiver visível
            {
                PessoaFisica novaPessoaFisica = new PessoaFisica(); //Instanciar a classe PessoaFisica para utilizá-la

                //Grava os textos digitados em cada campo do painel Pessoa Fisica para seus respectivos atributos 
                novaPessoaFisica.GravarPessoa(txtNomePessoaFisica.Text, txtEnderecoPessoaFisica.Text, txtRG.Text, txtCPF.Text);

                //Exibe os dados gravados no componente txtMostraPessoaFisica com tabulação 
                txtMostraPessoaFisica.AppendText(novaPessoaFisica.MostrarNome() + "\t");
                txtMostraPessoaFisica.AppendText(novaPessoaFisica.MostrarEndereco() + "\t");
                txtMostraPessoaFisica.AppendText(novaPessoaFisica.MostrarRg() + "\t");
                txtMostraPessoaFisica.AppendText(novaPessoaFisica.MostrarCpf() + "\n");
                Limpar(); //Método Limpar
            }
            else //Senão
            {
                PessoaJuridica novaPessoaJuridica = new PessoaJuridica(txtNomePessoaJuridica.Text, txtEnderecoPessoaJuridica.Text, txtCNPJ.Text, txtIE.Text);

                //Exibe os dados gravados no componente txtMostraPessoaFisica com tabulação 
                txtMostraPessoaJuridica.AppendText(novaPessoaJuridica.MostrarNome() + "\t");
                txtMostraPessoaJuridica.AppendText(novaPessoaJuridica.MostrarEndereco() + "\t");
                txtMostraPessoaJuridica.AppendText(novaPessoaJuridica.MostrarCnpj() + "\t");
                txtMostraPessoaJuridica.AppendText(novaPessoaJuridica.MostrarIe() + "\n");
                Limpar(); //Método Limpar
            }
        }

        /*private void txtSalvar_Click(object sender, EventArgs e)
        {
            if (painelPessoaFisica.Visible == true) //Se o painel da PessoaFisica estiver visível
            {
                PessoaFisica novaPessoaFisica = new PessoaFisica(); //Instanciamento da classe PessoaFisica para utilizá-la

                //Gravação de texto digitado em cada painel Pessoa Física para suas respectivas propriedades dos atributos
                novaPessoaFisica.propriedadeNome = txtNomePessoaFisica.Text;
                novaPessoaFisica.propriedadeEndereco = txtEnderecoPessoaFisica.Text;
                novaPessoaFisica.propriedadeRG = txtRG.Text;
                novaPessoaFisica.propriedadeCPF = txtCPF.Text;

                //Exibe os dados gravados no componente txtMostraPessoaFisica
                txtMostraPessoaFisica.AppendText(novaPessoaFisica.propriedadeNome + "\t");
                txtMostraPessoaFisica.AppendText(novaPessoaFisica.propriedadeEndereco + "\t" );
                txtMostraPessoaFisica.AppendText(novaPessoaFisica.propriedadeRG + "\t");
                txtMostraPessoaFisica.AppendText(novaPessoaFisica.propriedadeCPF + "\n");
            }
            else
            {
                PessoaJuridica novaPessoaJuridica = new PessoaJuridica(); //Instanciamento da classe PessoaJurídica para utilizá-la

                //Gravação de texto digitado em cada painel Pessoa Jurídica para suas respectivas propriedades dos atributos
                novaPessoaJuridica.propriedadeNome = txtNomePessoaJuridica.Text;
                novaPessoaJuridica.propriedadeEndereco = txtEnderecoPessoaFisica.Text;
                novaPessoaJuridica.propriedadeCNPJ = txtRG.Text;
                novaPessoaJuridica.propriedadeIE = txtCPF.Text;

                //Exibe os dados gravados no componente txtMostraPessoaFisica
                txtMostraPessoaFisica.AppendText(novaPessoaJuridica.propriedadeNome + "\t");
                txtMostraPessoaFisica.AppendText(novaPessoaJuridica.propriedadeEndereco + "\t");
                txtMostraPessoaFisica.AppendText(novaPessoaJuridica.propriedadeCNPJ + "\t");
                txtMostraPessoaFisica.AppendText(novaPessoaJuridica.propriedadeIE + "\n");
            }
        }*/
    }

    /*public class Pessoa
    {
        private string nome;               //Atributo nome com método de acesso privado
        private string endereco;           //Atributo endereço com método de acesso privado

        public string propriedadeNome      //Propriedade do atributo nome
        {
            set { nome = value; }          //Método de acesso de gravação
            get { return nome; }           //Método de acesso de leitura
        }

        public string propriedadeEndereco  //Propriedade do atributo endereço
        {
            set { endereco = value; }      //Método de acesso de gravação (grava o valor do atributo endereco)
            get { return endereco; }       //Método de acesso de leitura (retorna o valor do atributo nome)
        }
    }

    public class PessoaFisica : Pessoa //Classe PessoaFisica
    {
        public string propriedadeRG { set; get; }   //Propriedade autoimplementada do atributo RG
        public string propriedadeCPF { set; get; }  //Propriedade autoimplementada do atributo CPF
    }

    public class PessoaJuridica : Pessoa //Classe PessoaJuridica
    {
        public string propriedadeCNPJ { set; get; } //Propriedade autoimplementada do atributo CNPJ
        public string propriedadeIE { set; get; }   //Propriedade autoimplementada do atributo IE
    }*/
}
