namespace microserviceSeguros.Domain.Entities
{
    public class Apolice : Base
    {
        public string descricao { get; set; }
        public int cpf { get; set; }
        public string situacao { get; set; }
        public decimal premio_total { get; set; }
        public DateTime data_criacao_registro { get; set; } 
        public DateTime data_alteracao_registro { get; set; } 
        public int usuario_criacao_registro { get; set; }
        public int usuario_alteracao_registro { get; set; }
        public virtual List<Parcela> parcelas { get; set; }
    }
}