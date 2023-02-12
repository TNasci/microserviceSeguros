using microserviceSeguros.Domain.Entities;

namespace microserviceSeguros.Domain.Core.Interfaces.Services
{
    public interface IServicePagamento
    {
        Pagamento CalcularJuros(Pagamento pagamento);
    }
}