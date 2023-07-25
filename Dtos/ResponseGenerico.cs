using System.Dynamic;
using System.Net;

namespace IntegraBrasilApi.Dtos
{
  public class ResponseGenerico<T> where T : class
  {
    public HttpStatusCode CodigoHttp { get; set; }
    public T? DadosRetorno { get; set; }
    public ExpandoObject? ErroRetorno { get; set; }  //É UM OBJETO DINAMICO QUE INFORMA EM TEMPO DE EXECUÇÃO O ERRO CONFORME VEM DAR API, OU SEJA, VAI O MODELO DA API.
  }
}