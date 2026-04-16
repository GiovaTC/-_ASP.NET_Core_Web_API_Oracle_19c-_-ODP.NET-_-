namespace Web_API_Oracle_19c_ODP.NET
{
    public class ProbabilidadEvento
    {
        public int Id { get; set; }
        public string Evento { get; set; }
        public string Descripcion { get; set; }
        public double ValorA { get; set; }
        public double ValorB { get; set; }
        public int TotalCasos { get; set; }
        public int CasosFavorables { get; set; }
        public double Probabilidad { get; set; }
        public DateTime FechaCalculo { get; set; }
        public string UsuarioCreacion { get; set; }
        public string Estado { get; set; }
        public string Metodo { get; set; }
        public double Variable1 { get; set; }
        public double Variable2 { get; set; }
        public double Variable3 { get; set; }
        public double Variable4 { get; set; }
        public double Variable5 { get; set; }
        public string ResultadoTexto { get; set; }
        public string Observaciones { get; set; }
    }   
}
