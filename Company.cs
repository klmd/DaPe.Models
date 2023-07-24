using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DaPe.Models;

public class Company
{
    public int Id { get; set; }
    [Required]
    public string CompanyName { get; set; }

    public string? StreetAddress { get; set; }
    public string? City { get; set; }
    public string? PostalCode { get; set; }
    public string? State { get; set; }
    public string? Phone { get; set; }
}