using System.Collections.Generic;
using System.IO;
using Projeto_Final.Models;

namespace Projeto_Final.Repositorios
{
    public class AdministradorRepositorio : BaseRepositorio
    {
        public static uint CONT = 0;
        private const string PATH = "Database/Administrador.csv";
        private const string PATH_INDEX = "Database/Administrador.csv";
        private List<Administrador> administradores = new List<Administrador>();

        public AdministradorRepositorio()
        {
            if (!File.Exists(PATH_INDEX))
            {
                File.Create(PATH_INDEX).Close();
            }

            var ultimoIndice = File.ReadAllText(PATH_INDEX);
            uint indice = 0;
            uint.TryParse(ultimoIndice, out indice);
            CONT = indice;
        }

        public bool Inserir (Administrador administrador) {
            CONT++;
            File.WriteAllText(PATH_INDEX, CONT.ToString());

            string linha = PrepararRegistroCSV (administrador);
            File.AppendAllText (PATH, linha);

            return true;
        }

        public bool Atualizar (Administrador administrador) {
            var administradoresRecuperados = ObterRegistrosCSV (PATH);
            var administradorestring = PrepararRegistroCSV (administrador);
            var linhaAdministrador = -1;
            var resultado = false;

            for (int i = 0; i < administradoresRecuperados.Length; i++) {
                if (administradorestring.Equals (administradoresRecuperados[i])) {
                    linhaAdministrador = i;
                    resultado = true;
                }
            }
            if (linhaAdministrador >= 0) {
                administradoresRecuperados[linhaAdministrador] = administradorestring;
                File.WriteAllLines (PATH, administradoresRecuperados);
            }

            return resultado;

        }

        public bool Apagar (ulong id) {

            var administradoresRecuperados = ObterRegistrosCSV (PATH);
            var linhaAdministrador = -1;
            var resultado = false;

            for (int i = 0; i < administradoresRecuperados.Length; i++) {
                if (id.Equals (administradoresRecuperados[i])) {
                    linhaAdministrador = i;
                    resultado = true;
                }
            }

            if (linhaAdministrador >= 0) {
                administradoresRecuperados[linhaAdministrador] = "";
                try {
                    File.WriteAllLines (PATH, administradoresRecuperados);

                } catch(DirectoryNotFoundException dnfe) {
                    System.Console.WriteLine("Diretório não encontrado. Favor verificar.");
                } catch (PathTooLongException ptle) {
                    System.Console.WriteLine("Nome do arquivo é muito grande.");
                }
            }

            return resultado;
        }

        public Administrador ObterPor (ulong Id) {

            foreach (var item in ObterRegistrosCSV (PATH)) 
            {
                if (Id.Equals (ExtrairCampo (Id.ToString(), item))) 
                {
                    return ConverterEmObjeto (item);
                }
            }
            return null;
        }

        public Administrador ObterPor (string email) {

            foreach (var item in ObterRegistrosCSV (PATH)) 
            {
                if (email.Equals (ExtrairCampo (email, item))) 
                {
                    return ConverterEmObjeto (item);
                }
            }
            return null;
        }

        public List<Administrador> ListarTodos () {
            var linhas = ObterRegistrosCSV (PATH);
            foreach (var item in linhas) {

                Administrador administrador = ConverterEmObjeto (item);

                this.administradores.Add (administrador);
            }
            return this.administradores;
        }

        private Administrador ConverterEmObjeto (string registro) {

            Administrador administrador = new Administrador();
            System.Console.WriteLine("REGISTRO:" + registro);
            administrador.Id = ulong.Parse(ExtrairCampo("id", registro));
            administrador.Nome = ExtrairCampo("nome", registro);
            administrador.Email = ExtrairCampo("email", registro);
            administrador.Senha = ExtrairCampo("senha", registro);

            return administrador;
        }

        private string PrepararRegistroCSV (Administrador administrador) {
            return $"id={CONT};nome={administrador.Nome};email={administrador.Email};senha={administrador.Senha};\n";
        }
    }
}    