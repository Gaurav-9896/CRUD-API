
namespace API_crud.Models;

public class Student
{
    [Key]
    public int ID { get; set; }
    public string Name { get; set; }

    public string Division { get; set; }
    [DataType(DataType.PhoneNumber)]
    public string Contact { get; set; }
    
    [DataType(DataType.EmailAddress)]
    
    public string Email { get; set; }
}
