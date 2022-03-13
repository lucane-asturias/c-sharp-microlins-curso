using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class frmControleAlunos : Form
    {
        frmAlunos formulario; //Instância do frmAlunos 

        public frmControleAlunos(frmAlunos formulario) //Sempre que o frmControleAlunos for inicializado, terá acesso a todos os métodos e eventos do frmAlunos
        {
            InitializeComponent();
            this.ListarTurmas(); //"this" para indicar que método que chamarmos aqui está localizado nesse formulário
            //qual seria a diferença entre chamar no Load ou no método construtor do formulário?

            //Informa para o método construtor que >essa< instancia do formulario receberá os valores que foram passados por parâmetro para a variável formulario
            this.formulario = formulario;

            Limpar(); //Limpa o formulário e deixa com um 0 no TextBox referente ao código para cadastrar novos registros
        }

        Alunos novoAluno; //Instancia a classe Alunos para poder usar os métodos dentro dela
        Turmas novaTurma; //Instancia a classe Turmas para poder usar os métodos dentro dela
        Matriculas novaMatricula; //Instancia a classe Matriculas para poder usar os métodos dentro dela

        //Método que irá limpar todos os componentes do formulário ControleAlunos
        private void Limpar()
        {
            txtCodigo.Text = "0";
            txtNome.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtCPF.Clear();
            txtCEP.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            txtObservacao.Clear();
            cboSexo.SelectedIndex = -1;

            //Os campos da guia matrícula também serão limpos
            this.Text = "                                                                            SCA - Controle de Alunos";
            txtCodAluno.Text = "0";
            txtNomeAluno.Clear();

            //Verifica a quantidade de linhas do DataGridView para que possamos retirá-las ao limpar as informações do formulário
            int linhas = dtgMatriculas.Rows.Count;

            for (int i = 0; i < linhas; i++)
            {
                dtgMatriculas.Rows.Remove(dtgMatriculas.Rows[0]);
            }

            cboVencimento.Text = "";
            chkAtivo.Checked = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            novoAluno = new Alunos();

            try //estrutura de tratamento de erros, caso haja algum vai passar pro catch
            {

                if (MessageBox.Show("Deseja realmente excluir?", "Deseja excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    novoAluno.Excluir(Convert.ToInt32(txtCodigo.Text));
                    MessageBox.Show("Aluno excluído com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                }
            }
            catch (Exception ex) //armazena na variavel "ex" a exceção (erro) que o catch pegou
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                novoAluno = new Alunos();

                //Verifica o campo txtCodigo. Se ele for igual 0, indica que estamos criando um novo registro.
                if (txtCodigo.Text == "0")
                {
                    novoAluno.Salvar(txtNome.Text, txtEndereco.Text, txtBairro.Text, txtCidade.Text, txtCEP.Text, txtCPF.Text, txtTelefone.Text, txtCelular.Text,
                                                                                                                                cboSexo.Text, txtObservacao.Text);

                    MessageBox.Show("Aluno salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpar();
                    ListarUltimoAlunoCadastrado();


                    if (MessageBox.Show("Deseja realizar a matrícula do aluno?", "Realizar matrícula?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        tcAlunos.SelectedIndex = 1; //Se o resultado do dialogo foi Sim, redirecionará para a guia Matrículas 
                    }
                }
                else //Caso contrário, indica que estamos alterando as informações do aluno.
                {
                    novoAluno.Alterar(Convert.ToInt32(txtCodigo.Text), txtNome.Text, txtEndereco.Text, txtBairro.Text, txtCidade.Text, txtCEP.Text, txtCPF.Text,
                                                                                            txtTelefone.Text, txtCelular.Text, cboSexo.Text, txtObservacao.Text);

                    MessageBox.Show("Aluno alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void ordenarColunas()
        {
            dtgTurmasCadastradas.Columns["MODALIDADE"].DisplayIndex = 0;
            dtgTurmasCadastradas.Columns["NUMERO"].DisplayIndex = 1;
            dtgTurmasCadastradas.Columns["VAGAS"].DisplayIndex = 2;
            dtgTurmasCadastradas.Columns["btnHorario"].DisplayIndex = 3;

            dtgMatriculas.Columns["NOMEModalidade"].DisplayIndex = 0;
            dtgMatriculas.Columns["TURMA"].DisplayIndex = 1;
            dtgMatriculas.Columns["VENCIMENTO_MATRICULA"].DisplayIndex = 2;
            dtgMatriculas.Columns["MENSALIDADE_MATRICULA"].DisplayIndex = 3;
            dtgMatriculas.Columns["SITUACAO01"].DisplayIndex = 4;

            dtgMatriculasAlunos.Columns["NOME_MODALIDADE"].DisplayIndex = 0;
            dtgMatriculasAlunos.Columns["NUMERO_TURMA"].DisplayIndex = 1;
            dtgMatriculasAlunos.Columns["VENCIMENTO"].DisplayIndex = 2;
            dtgMatriculasAlunos.Columns["MENSALIDADE"].DisplayIndex = 3;
            dtgMatriculasAlunos.Columns["SITUACAO02"].DisplayIndex = 4;
        }

        /* Método que verifica no banco de dados qual foi o último registro adicionado, guardando essas informações em um DataTable
         * e posteriormente exibindo-as nos respectivos TextsBoxes. */

        private void ListarUltimoAlunoCadastrado()
        {
            try
            {
                novoAluno = new Alunos();

               /* Como no método Listar da classe Aluno ordena o ID de forma decrescente, o último aluno cadastrado estará na posição 0 do DataTable,
                * que representa a primeira linha dele. O txtCodALuno e txtNomeAluno ficarão na posição 0 do DataTable, que é a primeira linha da lista */
                DataTable dadosTabela = new DataTable(); //Instancia um objeto da Datatable
                dadosTabela = novoAluno.Listar(); //DataTable armazena o método Listar, o qual chama todos os alunos da tabela Aluno

                txtCodAluno.Text = dadosTabela.Rows[0]["ID_ALUNO"].ToString(); //Passa pro txtCodALuno a coluna ID_ALUNO da tabela Aluno
                txtNomeAluno.Text = dadosTabela.Rows[0]["NOME_ALUNO"].ToString(); //Passa pro txtNomeALuno a coluna NOME_ALUNO
            }
            catch (Exception ex) //armazena na variavel "ex" a exceção (erro) que o catch pegou
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarTurmas()
        {
            try
            {
                //Lista todas as turmas cadastradas no dtgTurmasCadastradas para poder realizar a matrícula.
                novaTurma = new Turmas();
                dtgTurmasCadastradas.DataSource = novaTurma.Listar();
                Estilo();

                //implementa algo ou no outro formulario? AAAAAA
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ExibirAluno(DataGridView aluno) //Variável que armazenará o conteúdo do DataGridView e passará como parâmetro para o método
        {
            //Método para exibir informações do aluno, as quais estão armazenadas na variável DataGridView aluno.
            try
            {
                //Adiciona o nome do aluno na barra de títulos do formulário. O título do form receberá o que estiver na coluna "NOME_ALUNO" da linha que o usuário escolher.
                this.Text = "                                                                      SCA - Controle de Alunos :: " +
                    aluno.Rows[aluno.CurrentRow.Index].Cells["NOME_ALUNO"].Value.ToString() + " ::";

                //Passagem dos valores do DataGridView para os respectivos TextBoxes.
                txtCodigo.Text = aluno.Rows[aluno.CurrentRow.Index].Cells["CODIGO"].Value.ToString();
                txtNome.Text = aluno.Rows[aluno.CurrentRow.Index].Cells["NOME_ALUNO"].Value.ToString();
                txtEndereco.Text = aluno.Rows[aluno.CurrentRow.Index].Cells["ENDERECO"].Value.ToString();
                txtBairro.Text = aluno.Rows[aluno.CurrentRow.Index].Cells["BAIRRO"].Value.ToString();
                txtCidade.Text = aluno.Rows[aluno.CurrentRow.Index].Cells["CIDADE"].Value.ToString();
                txtCEP.Text = aluno.Rows[aluno.CurrentRow.Index].Cells["CEP"].Value.ToString();
                txtCPF.Text = aluno.Rows[aluno.CurrentRow.Index].Cells["CPF"].Value.ToString();
                txtTelefone.Text = aluno.Rows[aluno.CurrentRow.Index].Cells["TELEFONE"].Value.ToString();
                txtCelular.Text = aluno.Rows[aluno.CurrentRow.Index].Cells["CELULAR"].Value.ToString();
                cboSexo.Text = aluno.Rows[aluno.CurrentRow.Index].Cells["SEXO"].Value.ToString();
                txtObservacao.Text = aluno.Rows[aluno.CurrentRow.Index].Cells["OBSERVACAO"].Value.ToString();

                txtCodAluno.Text = aluno.Rows[aluno.CurrentRow.Index].Cells["CODIGO"].Value.ToString();
                txtNomeAluno.Text = aluno.Rows[aluno.CurrentRow.Index].Cells["NOME_ALUNO"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Evento FormClosed, que possibilita programar para que alguma ação ocorra quando fechar o formulário.
        private void frmControleAlunos_FormClosed(object sender, FormClosedEventArgs e)
        {
            /* Chama o método ListarAlunos, o qual exibe todos os cadastros no DataGridView dtgAlunos. 
             * Dessa forma, quando a janela de controle de alunos for fechada, o dtgAlunos será atualizado. */
            formulario.ListarAlunos();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                novaMatricula = new Matriculas(); //Cria um novo objeto da classe Matriculas
                DataTable dadosTabela = new DataTable(); //Instancia a classe DataTable, pois sera utilizado códigos referentes à manipulação dos dados da base de dados

                //dadosTabela armazenará o resultado do método RetornarTurmasMatriculas, tendo como parâmetro a linha clicada, baseada no código da turma; e o código do aluno 
                dadosTabela = novaMatricula.RetornarTurmasMatriculadas(Convert.ToInt32(dtgTurmasCadastradas.Rows[dtgTurmasCadastradas.CurrentRow.Index].Cells["CODIGO"].Value),
                                                                                                                                        Convert.ToInt32(txtCodAluno.Text));
                if (dadosTabela.Rows.Count > 0) //Se a contagem das linhas do DataGridView for maior que 0, ou seja, se ele possuir linhas (registros) duplos
                {
                    MessageBox.Show("Aluno já está matriculado nessa turma.", "Matricula existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else //Se for maior, ou seja, se não houver cadastros no DataGridView
                {
                    if (Convert.ToInt32(dtgTurmasCadastradas.Rows[dtgTurmasCadastradas.CurrentRow.Index].Cells["VAGAS"].Value) == 0) //Se o número de vagas for 0
                    {
                        MessageBox.Show("Numero máximo de alunos atingido. Crie outra turma para esta modalidade", "Numero máximo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        /* Como é a segunda vez que a classe Matriculas será utilizada, será preciso criar um novo objeto para ela, podendo possuir até o mesmo nome.
                         * Isso evitará que o método anterior fique carregando duas informações e não funcione da forma desejada */
                        novaMatricula = new Matriculas();

                        /* Na classe Matriculas, foram estipulados 4 parâmetros pra realizar esse salvamento, o id do aluno, id da turma, o dia do vencimento e a situação da
                         * matricula. Desse modo, é realizado a ligação dos objetos do formulário com as colunas do banco. Deu pra notar que foi preciso converter os três
                         * primeiros objetos, pois são do tipo texto (string) e precisaram ser transformados em números.  Também outro detalhe importante a ser observado
                         * é o dia do vencimento estipulado, que será o atual, isto é, se for matriculado um aluno hoje, a data de vencimento será desse dia. */

                        novaMatricula.Salvar(Convert.ToInt32(txtCodAluno.Text), Convert.ToInt32(dtgTurmasCadastradas.Rows[dtgTurmasCadastradas.CurrentRow.Index].Cells["CODIGO"].Value),
                                                                                                                                          Convert.ToInt32(DateTime.Today.Day), true);
                        /* Na caixa de texto foi incrementando de um jeito que a torna muito instrutiva, pois é pedido que o texto seja acrescentado o número da turma e o seu nome.
                         * E essas informações estão nas colunas NUMERO e MODALIDADE do dtgTurmasCadastradas. */
                        MessageBox.Show("Matricula na turma " + dtgTurmasCadastradas.Rows[dtgTurmasCadastradas.CurrentRow.Index].Cells["NUMERO"].Value.ToString() + " de " +
                            dtgTurmasCadastradas.Rows[dtgTurmasCadastradas.CurrentRow.Index].Cells["MODALIDADE"].Value.ToString() + " feita com sucesso!", "Sucesso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                       
                        AtualizaVagas();  //Chama o método para atualizar as vagas de cada turma cadastrada. 

                        RetornarMatriculas(); //Apresenta a matrícula dentro do DataGridView destinado a receber esse conteúdo 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizaVagas()
        {
            try
            {
                //Cria uma varável receber a contagem de linhas do dtg, consequentemente controlando estrutura de repetição
                int linhas = dtgTurmasCadastradas.Rows.Count;

                for (int i = 0; i < linhas; i++)
                {
                    novaMatricula = new Matriculas();
                    //Acessa o método RetornarQuantidadeMatriculas para obter o total de matrículas realizadas na posição em que o i estiver e o armazena na variável total.
                    int total = novaMatricula.RetornarQuantidadeMatriculas(Convert.ToInt32(dtgTurmasCadastradas.Rows[i].Cells["CODIGO"].Value));

                    novaTurma = new Turmas();

                    /* Para obter a quantidade de matrículas que ainda serão possíveis na turma selecionada, será subtraído o número de vagas existentes, e em seguida,
                     * atualizar a tabela. Para isso, é acessado o método AlterarVagas, que será responsável por atualizar o número de vagas */
                    novaTurma.AlterarVagas(Convert.ToInt32(dtgTurmasCadastradas.Rows[i].Cells["CODIGO"].Value),
                    Convert.ToInt32(dtgTurmasCadastradas.Rows[i].Cells["VAGAS"].Value) - total);

                    ListarTurmas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void RetornarMatriculas() //Método responsável por trazer os dados da matrícula do aluno, para serem exibidos nos DataGridViews correspondentes.
        {
            try
            {
                /* Método responsável por retornar as matrículas do aluno, para que assim ser possível listá-las no DataGridView;
                 * também exibe o texto que indica a situação dela e se a label deve ou não ficar visível. */
                novaMatricula = new Matriculas();
                DataTable dadosTabela = new DataTable();
                dadosTabela = novaMatricula.RetornarMatriculas(Convert.ToInt32(txtCodAluno.Text));

                dtgMatriculas.DataSource = dadosTabela;
                dtgMatriculasAlunos.DataSource = dadosTabela;

                int linhas = dtgMatriculas.Rows.Count; //Variável responsável por armazenar a quantidade de linhas do DataGridView

                for (int i = 0; i < linhas; i++)
                {
                    if (Convert.ToBoolean(dadosTabela.Rows[i]["SITUACAO"])) //Verifica se o campo Situação está com o valor true
                    {
                        //Se for true, é programado para aparecer no dtgMatriculas e dtgMatriculasAluno o texto ATIVA na cor verde
                        dtgMatriculas.Rows[i].Cells["SITUACAO01"].Value = "ATIVA";
                        dtgMatriculas.Rows[i].Cells["SITUACAO01"].Style.ForeColor = Color.ForestGreen;
                        dtgMatriculasAlunos.Rows[i].Cells["SITUACAO02"].Value = "ATIVA";
                        dtgMatriculasAlunos.Rows[i].Cells["SITUACAO02"].Style.ForeColor = Color.ForestGreen;
                    }
                    else
                    {
                        //Senão, é para exibir nestes mesmos componentes o texto INATIVA na cor avermelhada
                        dtgMatriculas.Rows[i].Cells["SITUACAO01"].Value = "INATIVA";
                        dtgMatriculas.Rows[i].Cells["SITUACAO01"].Style.ForeColor = Color.Firebrick;
                        dtgMatriculasAlunos.Rows[i].Cells["SITUACAO02"].Value = "INATIVA";
                        dtgMatriculasAlunos.Rows[i].Cells["SITUACAO02"].Style.ForeColor = Color.Firebrick;
                    }
                }

                if (dadosTabela.Rows.Count > 0) //Se a contagem das linhas dos DataGridViews forem superiores a zero
                {
                    lblAviso.Visible = false;
                    lblAvisoMatricula.Visible = false;

                    /* Carrega os componentes destinados a exibir o Vencimento e a Situação da matrícula, puxando a informação de suas respectivas colunas
                     * Dá o erro "Referência de objeto não definida para uma instância de um objeto" senão referenciar a aba destinada a esses componentes no Load.
                     * Uma outra coisa é que finalmente foi escrito a coluna Situacao do dtgMatriculasAlunos o texto "ATIVO" quando coloquei para referenciar essa aba */
                    cboVencimento.Text = dtgMatriculasAlunos.Rows[dtgMatriculasAlunos.CurrentRow.Index].Cells["VENCIMENTO"].Value.ToString();
                    chkAtivo.Checked = Convert.ToBoolean(dtgMatriculasAlunos.Rows[dtgMatriculasAlunos.CurrentRow.Index].Cells["SITUACAO"].Value);

                }
                else //Caso a contagem das linhas forem menor que zero
                {
                    lblAviso.Visible = true;
                    lblAvisoMatricula.Visible = true;
                }

                ordenarColunas();
                Estilo();
            }

            catch (Exception ex) //Configura para que a variável ex carregue o erro e o mostre numa caixa de mensagem
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Estilo()
        {
            int linhas = dtgMatriculas.Rows.Count; //Variável para armazenar a quantidade de linas do DataGridView respectivo

            for (int i = 0; i < linhas; i++)
            {
                dtgMatriculas.Rows[i].DefaultCellStyle.ForeColor = Color.LightSteelBlue; //Define a aparência de todas as linhas do DataGridView de modo intercalada.
                i++;
            }

            linhas = dtgMatriculasAlunos.Rows.Count;

            for (int i = 0; i < linhas; i++)
            {
                dtgMatriculasAlunos.Rows[i].DefaultCellStyle.ForeColor = Color.LightSteelBlue;
                i++;
            }

            linhas = dtgTurmasCadastradas.Rows.Count;

            for (int i = 0; i < linhas; i++)
            {
                dtgTurmasCadastradas.Rows[i].DefaultCellStyle.ForeColor = Color.LightSteelBlue;
                i++;
            }
        }

        //Evento que é ativado quando qualquer parte da célula do DTV for clicada; diferente da CellClickContent, que é ativada quando clicado no conteúdo inteiro da linha.
        private void dtgMatriculasAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /* Evento responsável por capturar o click das células do DataGridView; e ao fazer isso, adiciona
             * aos objetos cboVencimento e chkAtivo as informações das colunas Vencimento e Situação do DataGridView  */
            cboVencimento.Text = dtgMatriculasAlunos.Rows[dtgMatriculasAlunos.CurrentRow.Index].Cells["VENCIMENTO"].Value.ToString();
            chkAtivo.Checked = Convert.ToBoolean(dtgMatriculasAlunos.Rows[dtgMatriculasAlunos.CurrentRow.Index].Cells["SITUACAO"].Value);
        }

        /* Evento que será executado assim que o formulário frmControleAlunos for carregado. Ele ativará a aba Matriculas
         * e realizará o método responsável por retornar as matrículas */
        private void frmControleAlunos_Load(object sender, EventArgs e)
        {
            /* O carregamento da aba deve ficar antes do método, caso contrário, continuará dando o erro de "referência do objeto não definida pra uma instância de um objeto";
             * ou seja, será preciso obdeceder a ordem de ativar primeiro o formulário e só depois realizar o método, seguindo a lógica de programação. 
             * Repare que para ativar a aba Matriculas foi utilizado o método Show, que até agora foi usado em componentes, mas neste caso, ele ativará ou carregará
             * a aba referenciada, para que ela possa receber o método RetornarMatriculas. */
            tabMatricula.Show();

            RetornarMatriculas();
            ordenarColunas(); //Método cuja função será para ordenar as colunas
        }

        private void btnSalvarMatricula_Click(object sender, EventArgs e)
        {
            try
            {
                //Sava as alteração realizadas, referentes ao vencimento e a situação da matrícula.
                novaMatricula = new Matriculas();

                novaMatricula.Alterar(Convert.ToInt32(dtgMatriculasAlunos.Rows[dtgMatriculasAlunos.CurrentRow.Index].Cells["ID_MATRICULA"].Value),
                Convert.ToInt32(dtgMatriculasAlunos.Rows[dtgMatriculasAlunos.CurrentRow.Index].Cells["VENCIMENTO"].Value),
                Convert.ToBoolean(dtgMatriculasAlunos.Rows[dtgMatriculasAlunos.CurrentRow.Index].Cells["SITUACAO"].Value));
                MessageBox.Show("Dados alterados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RetornarMatriculas();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluirMatricula_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja realmente excluir a matrícula?", "Deseja excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    novaMatricula = new Matriculas();
                    novaMatricula.Excluir(Convert.ToInt32(dtgMatriculasAlunos.Rows[dtgMatriculasAlunos.CurrentRow.Index].Cells["ID_MATRICULA"].Value));

                    MessageBox.Show("Matricula excluída com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RetornarMatriculas();

                    AtualizaVagas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
