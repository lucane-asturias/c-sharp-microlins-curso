using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /* Formulário login que verifica e autoriza o acesso ao sitema. Ele será aberto antes do frmPrincipal. */
            frmLogin formularioLogin = new frmLogin();
            formularioLogin.ShowDialog(); //Primeiramente, será aberto o formulário frmLogin.

            if (formularioLogin.DialogResult == DialogResult.OK) //Se o resultado para entrar no sistema for OK, poderá chamar o frmPrincipal.
            {
                Application.Run(new frmPrincipal(formularioLogin.idUsuario)); //Carrega os dados do usuário que entrou no sistema.
            }
            else //Senão for OK, a aplicação será fechada.
            {
                Application.Exit();
            }
        }
    }
}
