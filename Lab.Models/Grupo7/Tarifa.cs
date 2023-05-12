using System;

public class Tarifa
{
	public int ID { get; set; }
	public decimal CostoDia { get; set; }
	public int DiasMaximo { get; set; }
	public int DiasMinimo { get; set; }


	public Tarifa(int ID, decimal CostoDia, int DiasMaximo, int DiasMinimo)
	{
		this.ID = ID;
		this.CostoDia = CostoDia;
		this.DiasMaximo = DiasMaximo;
		this.DiasMinimo = DiasMinimo;
	}
}