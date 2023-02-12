namespace microserviceSeguros.Application.DTOs
{
    public class PagamentoDTO
    {
        public DateTime dataPago { get; set; }
        public DateTime data_pagamento { get; set; }
        public string tipo { get; set; }
        public decimal total_juros { get; set; }
    }
}