using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorTasker.Models;

public class TaskerItem
{
  public Guid Id { get; set; }
  [Required(ErrorMessage = "Name is required")]
  public string Name { get; set; } = string.Empty;
  public bool IsComplete { get; set; } = false;
}