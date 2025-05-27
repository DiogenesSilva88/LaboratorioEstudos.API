public class Pedido
{
    public int Id { get; set; }
    public string Descricao { get; set; }

    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; }
}
