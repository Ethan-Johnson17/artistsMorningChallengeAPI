using System.ComponentModel.DataAnnotations;

namespace artistsMc.Models
{
  public class Artist
  {
    public Artist(string? name)
    {
      Id = Guid.NewGuid().ToString();
      Name = name;
    }

    public string? Id { get; set; }
    public string? Name { get; set; }
  }
}