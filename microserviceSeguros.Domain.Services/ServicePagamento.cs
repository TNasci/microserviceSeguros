using microserviceSeguros.Domain.Core.Interfaces.Services;
using microserviceSeguros.Domain.Entities;

namespace microserviceSeguros.Domain.Services
{
    public class ServicePagamento : IServicePagamento
    {
        public ServicePagamento()
        {
        }

        public Pagamento CalcularJuros(Pagamento pagamento)
        {
            var dataDif = 0;
            if (pagamento.dataPago > pagamento.data_pagamento)
            {
                var timeSpan = pagamento.dataPago.Subtract(pagamento.data_pagamento);
                dataDif = timeSpan.Days;

                switch (pagamento.tipo)
                {
                    case "cartao":
                        pagamento.total_juros = dataDif * 3;
                        break;

                    case "boleto":
                        pagamento.total_juros = dataDif * 1;
                        break;

                    case "dinheiro":
                        pagamento.total_juros = dataDif * 5;
                        break;

                    default:
                        pagamento.total_juros = 0;
                        break;
                }
            }

            return pagamento;
        }
    }
}