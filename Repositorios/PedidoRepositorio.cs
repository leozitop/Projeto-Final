using System;
using System.Collections.Generic;
using System.IO;
using Projeto_Final.Models;

namespace Projeto_Final.Repositorios
{
    public class PedidoRepositorio : BaseRepositorio
    {
        public static uint CONT = 0;
        private const string PATH = "Database/Pedido.csv";
        private const string PATH_INDEX = "Database/Pedido_Id.csv";
        private List<Pedido> pedidos = new List<Pedido>();

        public PedidoRepositorio(){
            if (!File.Exists(PATH_INDEX))
            {
                File.Create(PATH_INDEX).Close();
            }

            var ultimoIndice = File.ReadAllText(PATH_INDEX);
            uint indice = 0;
            uint.TryParse(ultimoIndice, out indice);
            CONT = indice;
        }

        public bool Inserir(Pedido pedido){
            CONT++;
            File.WriteAllText(PATH_INDEX, CONT.ToString());

            string linha = PrepararRegistroCSV (pedido);
            File.AppendAllText (PATH, linha);

            return true;
        }

        public bool Atualizar(Pedido pedido){
            var pedidosRecuperados = ObterRegistrosCSV(PATH);
            var clienteString = PrepararRegistroCSV(pedido);
            var linhaPedido = -1;
            var resultado = false;

            for (int i = 0; i < pedidosRecuperados.Length; i++)
            {
                if (clienteString.Equals (pedidosRecuperados[i]))
                {
                    linhaPedido = i;
                    resultado = true;
                }
            }

            if (linhaPedido >= 0)
            {
                pedidosRecuperados[linhaPedido] = clienteString;
                File.WriteAllLines (PATH, pedidosRecuperados);
            }

            return resultado;
        } 

        public bool Apagar(ulong Id){
            var pedidosRecuperados = ObterRegistrosCSV (PATH);
            var linhaPedido = -1;
            var resultado = false;

            for (int i = 0; i < pedidosRecuperados.Length; i++) {
                if (Id.Equals (pedidosRecuperados[i])) {
                    linhaPedido = i;
                    resultado = true;
                }
            }

            if (linhaPedido >= 0) {
                pedidosRecuperados[linhaPedido] = "";
                File.WriteAllLines (PATH, pedidosRecuperados);
            }

            return resultado;
        }

        public Pedido ObterPor(ulong Id){
            foreach (var item in ObterRegistrosCSV(PATH))
            {
                if (Id.Equals(ExtrairCampo (Id.ToString(), item)))
                {
                    return ConverterEmObjeto(item);
                }
            }
            return null;
        }

        public Pedido ObterPor(string email){
            foreach (var item in ObterRegistrosCSV(PATH))
            {
                if (email.Equals(ExtrairCampo(email, item)))
                {
                    return ConverterEmObjeto(item);
                }
            }
            return null;
        }

        public List<Pedido> ListarTodos(){
            var linhas = ObterRegistrosCSV(PATH);
            foreach (var item in linhas)
            {
                Pedido pedido = ConverterEmObjeto(item);

                this.pedidos.Add(pedido);
            }
            return this.pedidos;
        }

        public List<Pedido> ListarTodosPorCliente(string nomeCliente){
            var linhas = ObterRegistrosCSV(PATH);
            foreach (var item in linhas)
            {
                Pedido pedido = ConverterEmObjeto(item);
                if (pedido.Cliente.Nome.Equals(nomeCliente))
                {
                    this.pedidos.Add(pedido);
                }
            }
            return this.pedidos;
        }

        private Pedido ConverterEmObjeto(string registro){
            Pedido pedido = new Pedido();
            pedido.Id = ulong.Parse(ExtrairCampo("Id", registro));
            pedido.Cliente.Nome = ExtrairCampo("clienteNome", registro);
            pedido.Cliente.Email = ExtrairCampo("clienteEmail", registro);
            pedido.Produto.Nome = ExtrairCampo("produtoNome", registro);
            pedido.Produto.Preco = double.Parse(ExtrairCampo("produtoPreco", registro));
            pedido.DataPedido = DateTime.Parse(ExtrairCampo("dataPedido", registro));
            pedido.PrecoTotal = double.Parse(ExtrairCampo("precoTotal", registro));
            
            return pedido;
        }


        private string PrepararRegistroCSV(Pedido pedido)
        {
            ulong id = pedido.Id == 0 ? CONT : pedido.Id;
            return $"id={id};clienteNome={pedido.Cliente.Nome};clienteEmail={pedido.Cliente.Email};hamburguerNome={pedido.Produto.Nome};hamburguerPreco={pedido.Produto.Preco};dataPedido={pedido.DataPedido};precoTotal={pedido.PrecoTotal}+\n";
        }
    }
}