using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
  public class Breed
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="Breed"/> class.
    /// </summary>
    public Breed()
    {
      this.Animals = new HashSet<Animal>();
    }

    /// <summary>
    /// Gets or sets unique identificator of the breed.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets name of the breed.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets collection of animal entities in the breed.
    /// </summary>
    public virtual ICollection<Animal> Animals { get; set; }

    /// <summary>
    /// ToString override.
    /// </summary>
    /// <returns>A formatted string which contains all the relevant information about the breed.</returns>
    public override string ToString()
    {
      return $"Name: {this.Name}";
    }
  }
}
