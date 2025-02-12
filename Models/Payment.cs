using System;
using System.ComponentModel.DataAnnotations.Schema;

public class Payment
{
    public int Id { get; set; }
    public int SaleId { get; set; } // foreign key
    public DateTime Date { get; set; }
    public string Login { get; set; }
    public double Amount { get; set; }

    [ForeignKey("SaleId")]
    public virtual Sale Sale { get; set; } // Navigation property
}