public class Usuario
{
    public int Id { get; set; }
    public string Nome { get; set; }

    public List<Pedido> Pedidos { get; set; }
}
