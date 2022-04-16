namespace Models
{
  public class Animal
  {
    /// <summary>
    /// Sex of the Animal. It can only be male or female.
    /// </summary>
    public enum Sex
    {
      /// <summary>
      /// Male animal.
      /// </summary>
      Male,

      /// <summary>
      /// Female animal.
      /// </summary>
      Female,
    }

    /// <summary>
    /// Gets or sets unique identificator of the animal.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets name of the animal.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets sex of the animal.
    /// </summary>
    public Sex MF { get; set; }

    /// <summary>
    /// Gets or sets age of the animal.
    /// </summary>
    public int Age { get; set; }

    /// <summary>
    /// Gets or sets id of the breed, where the animal belongs.
    /// </summary>
    public int BreedId { get; set; }

    /// <summary>
    /// Gets or sets the breed of the animal.
    /// </summary>
    public virtual Breed Breed { get; set; }

    /// <summary>
    /// ToString override.
    /// </summary>
    /// <returns>A formatted string which contains all the relevant information about the animal.</returns>
    public override string ToString()
    {
      return $"[{this.Id}] Name: {this.Name}, Age: {this.Age}, Sex: {this.MF}, BreedId: {this.BreedId}, Breed: {this.Breed.Name}";
    }
  }
}