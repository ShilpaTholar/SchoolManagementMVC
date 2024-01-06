
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace project.data;
public class StudentMetaData{

     [StringLength(50)]
    [Display(Name="First Name")]

    public string FirstName { get; set; } = null!;

    [Display(Name="Last Name")]

    public string LastName { get; set; } = null!;

    [Display(Name="Date of Birth")]

    public DateOnly? Dateofbirth { get; set; }
    
}
[ModelMetadataType(typeof(StudentMetaData))]
public partial class Student{}

