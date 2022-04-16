using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Linq;

namespace Repository
{
  public class AnimalRepository : Repository<Animal>, IAnimalRepository
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="AnimalRepository"/> class.
    /// </summary>
    /// <param name="ctx">Database context.</param>
    public AnimalRepository(DbContext ctx)
        : base(ctx)
    {
    }

    /// <summary>
    /// Adds a new animal.
    /// </summary>
    /// <param name="animal">Animal to be added.</param>
    /// <returns>The newly added animals ID.</returns>
    public int Add(Animal animal)
    {
      if (animal == null)
      {
        throw new ArgumentNullException(nameof(animal));
      }

      this.ctx.Set<Animal>().Add(animal);
      this.ctx.SaveChanges();
      return animal.Id;
    }

    /// <summary>
    /// Changes the age of the animal specified in the arguments.
    /// </summary>
    /// <param name="id">ID of the animal.</param>
    /// <param name="newAge">New age of the animal.</param>
    public void ChangeAge(int id, int newAge)
    {
      var animal = this.GetOne(id);
      if (animal == null)
      {
        throw new InvalidOperationException("Animal not found " + nameof(animal));
      }

      animal.Age = newAge;
      this.ctx.SaveChanges();
    }

    /// <inheritdoc/>
    public bool ChangeAnimal(int id, Breed breed, string name, int age)
    {
      var animal = this.GetOne(id);
      if (animal == null)
      {
        throw new InvalidOperationException("Animal not found " + nameof(animal));
      }

      animal.Age = age;
      animal.Name = name;
      animal.Breed = breed;
      this.ctx.SaveChanges();
      return true;
    }

    /// <summary>
    /// Gets one animal specified in the ID.
    /// </summary>
    /// <param name="id">ID of the animal.</param>
    /// <returns>The searched animal.</returns>
    public override Animal GetOne(int id)
    {
      return this.GetAll().SingleOrDefault(x => x.Id == id);
    }

    /// <summary>
    /// Removes one animal specifien in the argument.
    /// </summary>
    /// <param name="id">ID of the animal, you wish to remove.</param>
    /// <returns>wther the removal was a success or not.</returns>
    public bool Remove(int id)
    {
      if (this.GetOne(id) != null)
      {
        this.ctx.Remove(this.GetOne(id));
        this.ctx.SaveChanges();
        return true;
      }

      return false;
    }
  }
}
