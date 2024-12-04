namespace pet_register_table.Models
{
    public class Pet
    {
        public int Id { get; set; } 
        public string Name { get; set; } 
        public string Species { get; set; } 
        public string Breed { get; set; } 
        public DateTime DateOfBirth { get; set; }
        public string OwnerName { get; set; } 
        public string ContactNumber { get; set; } 
        public bool IsVaccinated { get; set; } 
        public DateTime RegisteredAt { get; set; } = DateTime.Now; 
        public DateTime? ChangedAt { get; set; } = null; 
        public int Age => DateTime.Now.Year - DateOfBirth.Year -
                          (DateTime.Now.Date < DateOfBirth.AddYears(DateTime.Now.Year - DateOfBirth.Year) ? 1 : 0);

    }
}
