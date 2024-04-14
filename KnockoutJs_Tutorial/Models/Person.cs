namespace KnockoutJs_Tutorial.Models
{
    public class Person
    { 
        public string? firstName {  get; set; }
        public string? lastName { get; set; }
        public ICollection<Friend>? friends { get; set;}
    }
}
