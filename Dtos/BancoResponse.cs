using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegraBrasilApi.Dtos
{
  public class BancoResponse // PERSONALIZANDO O RETORNO, PARA NÃO VIR IGUAL A API. 
  {
    public string? Ispb { get; set; }
    public string? NomeAbreviado { get; set; }
    public int? Codigo { get; set; }
    public string? NomeCompleto { get; set; }
  }
}