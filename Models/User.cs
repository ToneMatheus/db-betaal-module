using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class User{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public string Login { get; set; } // use this as primary key because every email is unique
    public string Iban { get; set; }
    public bool Sms { get; set; }
    public bool Teams { get; set; }
    public bool Email { get; set; }
}