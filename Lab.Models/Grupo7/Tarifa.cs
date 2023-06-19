namespace Lab.Models.Grupo7;

public class Tarifa
{ 
    public int Id { get; set; }

    public decimal CostoDia { get; set; }

    public int DiasMaximos { get; set; }

    public int DiasMinimos { get; set; }
}