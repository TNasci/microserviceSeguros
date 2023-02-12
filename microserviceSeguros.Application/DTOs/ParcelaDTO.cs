namespace microserviceSeguros.Application.DTOs
{
    public class ParcelaDTO
    {
        public int Id { get; set; }
        public int apoliceId { get; set; }
        public decimal premio { get; set; }
        public string forma_pagamento { get; set; }
        public DateTime data_pagamento { get; set; }
        public DateTime data_pago { get; set; }
        public decimal juros { get; set; }
        public string situacao { get; set; }
        public DateTime data_criacao_registro { get; set; }
        public DateTime data_alteracao_registro { get; set; }
        public int usuario_criacao_registro { get; set; }
        public int usuario_alteracao_registro { get; set; }
    }
}