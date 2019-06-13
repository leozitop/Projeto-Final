using System;
using System.Collections.Generic;
using System.IO;
using Projeto_Final.Models;

namespace Projeto_Final.Repositorios
{
    public class DepoimentoRepositorio
    {
        public static uint CONT = 0;
        
        public Depoimento Inserir(Depoimento comentario){
            List<Depoimento> listaDeComentarios = Listar();

            if (listaDeComentarios != null)
            {
                CONT++;
            }

            comentario.Id = CONT;

            StreamWriter sw = new StreamWriter("depoimentos.csv");
            sw.WriteLine($"{comentario.Id};{comentario.NomeCliente}:{comentario.Comentario};{comentario.DataComentario}");
            sw.Close();

            return comentario;
        }

        public List<Depoimento> Listar(){
            List<Depoimento> listaDeComentarios = new List<Depoimento>();
            Depoimento comentario;

            if (!File.Exists("depoimentos.csv"))
            {
                return null;
            }

            string[] depoimentos = File.ReadAllLines("depoimentos.csv");

            foreach (var item in depoimentos)
            {
                if (item != null)
                {
                    string[] dadosComentario = item.Split(";");
                    comentario = new Depoimento();
                    comentario.Id = ulong.Parse(dadosComentario[0]);
                    comentario.NomeCliente = dadosComentario[1];
                    comentario.Comentario = dadosComentario[2];
                    comentario.DataComentario = DateTime.Parse(dadosComentario[3]);
                    listaDeComentarios.Add(comentario);
                }
            }
            return listaDeComentarios;
        }
    }
}