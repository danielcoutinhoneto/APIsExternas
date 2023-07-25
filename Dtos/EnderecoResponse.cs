using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace IntegraBrasilApi.Dtos
{
  public class EnderecoResponse  // PERSONALIZANDO O RETORNO, PARA NÃO VIR IGUAL A API. 
  {
    public string? Cep { get; set; }
    public string? Estado { get; set; }
    public string? Cidade { get; set; }
    public string? Bairro { get; set; }
    public string? Rua { get; set; }

    [JsonIgnore] // ANNOTATION PARA SER IGNORAR, POIS NÃO NECESSÁRIO O USUÁRIO SABER DE ONDE VEM.  
    public string? Servico { get; set; }
  }
}