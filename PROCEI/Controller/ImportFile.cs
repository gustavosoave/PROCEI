using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using PROCEI.Model;

namespace PROCEI.Controller
{
    class ImportFile
    {
        private const String caminhoArquivo = "banco_de_usuarios.txt";
        private List<Usuarios> usuarios = new List<Usuarios>();

        public ImportFile() {
            if (!File.Exists(caminhoArquivo))
                criaArquivo();
        }

        private void criaArquivo()
        {

            List<Login> logins = new List<Login>();

            logins.Add(new Login() { Usuario = "master", Senha = "masterkey" });
            logins.Add(new Login() { Usuario = "user", Senha = "userkey" });
            logins.Add(new Login() { Usuario = "admin", Senha = "adminkey" });

            foreach (Login l in logins)
            {

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(caminhoArquivo, true))
                {
                    file.WriteLine("{0}:{1}", l.Usuario, l.Senha);
                }

            }
        }

        private void lerArquivo() {
            String linha = "";
            
            StreamReader file =   new StreamReader(caminhoArquivo);
            while ((linha = file.ReadLine()) != null)
            {
                String[] linhaTexto = linha.Split(':');
                usuarios.Add(new Usuarios() { Usuario = linhaTexto [0], Senha = linhaTexto[1] });
            }

            file.Close();
        }


        public Usuarios getUsuarioSenha(String usuarioParametro)
        {

            lerArquivo();

            foreach (Usuarios u in usuarios)
            {
                if (usuarioParametro.ToUpper() == u.Usuario.ToUpper())
                {
                    return u;
                }
            }

            throw new Exception("Usuario Não Encontrado");

        }

    }
}
