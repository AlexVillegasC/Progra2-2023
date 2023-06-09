public class Envios
{
    private Cotizaciones cotizaciones { get; set; }
    private Seguimiento seguimiento { get; set; }
    private Clientes clientes { get; set; }

    public Envios()
    {
        cotizaciones = new Cotizaciones();
        seguimiento = new Seguimiento();
        clientes = new Clientes();
    }

} 