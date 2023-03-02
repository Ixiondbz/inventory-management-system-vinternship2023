using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.Models;

public class Student
{
    [Required]
    public int Id{get;set;}

    [Required]
    public string? UserName { get; set; }
    [Required]
    public string? Password { get; set; }
    [Required]
    public string? UserFirstName { get; set; }
    [Required]
    public string? UserLastName { get; set; }

    [EmailAddress]
    public string? Email { get; set; }
    [Phone]
    public string? Phone { get; set; }
    
    public string? Address { get; set; }

    public string? Role { get; set; }
}