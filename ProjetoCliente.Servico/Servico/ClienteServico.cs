using ProjetoCliente.Data.Repositorio.Interface;
using ProjetoCliente.Dominio.Dominio;
using ProjetoCliente.Servico.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCliente.Servico.Servico
{
    public class ClienteServico : IClienteServico
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteServico(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public void AdicionarCliente(Cliente cliente)
        {
            _clienteRepositorio.AdicionarCliente(cliente);
        }
    }
}
