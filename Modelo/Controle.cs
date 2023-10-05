using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winforms_correios.Correios;

namespace winforms_correios.Modelo
{
    public class Controle
    {
        public String mensagem;

        public Endereco pesquisarEndereco(String cep)
        {
            this.mensagem = "";
            AtendeClienteClient atendeCliente = new AtendeClienteClient();
            Endereco endereco = new Endereco();
            try
            {
                Task<consultaCEPResponse> address = atendeCliente.consultaCEPAsync(cep);
                endereco.logradouro = "Logradouro: " + address.Result.@return.end;
                endereco.bairro = "Bairro: " + address.Result.@return.bairro;
                endereco.cidade = "Cidade: " + address.Result.@return.cidade;
            }
            catch (System.Exception e)
            {
                this.mensagem = "CEP inválido";
            }
            return endereco;
        }
    }
}
