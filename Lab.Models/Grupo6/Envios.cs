public class Envios
{
    private Cotizaciones cotizaciones { get; set; }
    private Seguimiento seguimiento { get; set; }
    private Paquete paquete { get; set; }

    public Envios()
    {
        cotizaciones = new Cotizaciones();
        seguimiento = new Seguimiento();
        paquete = new Paquete();

    }

}