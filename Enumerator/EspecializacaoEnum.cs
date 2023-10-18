using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Sistema_de_Cadastro_de_Fornecedor.Enumerator
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EspecializacaoEnum
    {
        Comércio = 0,
        Serviço = 1,
        Indústria = 2
    }
}
