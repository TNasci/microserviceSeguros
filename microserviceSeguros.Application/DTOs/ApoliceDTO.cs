namespace microserviceSeguros.Application.DTOs
{
    public class ApoliceDTO
    {
        public int Id { get; set; }
        public string descricao { get; set; }
        public int cpf { get; set; }
        public string situacao { get; set; }
        public float premio_total { get; set; }
        public DateTime data_criacao_registro { get; set; }
        public DateTime data_alteracao_registro { get; set; }
        public int usuario_criacao_registro { get; set; }
        public int usuario_alteracao_registro { get; set; }
        public IEnumerable<ParcelaDTO> parcelas { get; set; } = new List<ParcelaDTO>();
    }
}