using Models;

namespace Repository
{
  public interface IAnimalRepository : IRepository<Animal>
  {
    /// <summary>
    /// Adds one animal.
    /// </summary>
    /// <param name="animal">The animal you wish to add.</param>
    /// <returns>The ID of the newly added animal.</returns>
    public int Add(Animal animal);

    /// <summary>
    /// Change animal.
    /// </summary>
    /// <param name="id">ID of the animal.</param>
    /// <param name="breed">Breed of the animal.</param>
    /// <param name="name">Name of the animal.</param>
    /// <param name="age">Age of the animal.</param>
    /// <returns>The result of the change.</returns>
    public bool ChangeAnimal(int id, Breed breed, string name, int age);

    /// <summary>
    /// Removes the animal specified in the argument.
    /// </summary>
    /// <param name="id">ID of the animal.</param>
    /// <returns>wether the removal was a success or not.</returns>
    public bool Remove(int id);

    /// <summary>
    /// Changes the age of the animal specified in the argument.
    /// </summary>
    /// <param name="id">The ID of the animal.</param>
    /// <param name="newAge">The new ade of the animal.</param>
    void ChangeAge(int id, int newAge);
  }
}
