using System.Collections.Generic;
using System.Runtime.InteropServices;

/// <summary>
/// Generic interface with all basic Database operations.
/// </summary>
/// <typeparam name="T">Type of the entity/entities being operated.</typeparam>
public interface IGenericDAO<T>
{
    /// <summary>
    /// Adds a specified entity.
    /// </summary>
    /// <param name="e">Entity to be saved to the Database.</param>
    /// <returns>Returns the added entity.</returns>
    T Add(T e);

    /// <summary>
    /// Adds a specified list of entities.
    /// </summary>
    /// <param name="e">List of entities to be saved to the Database.</param>
    /// <returns>Returns the amount of added entities from the Database.</returns>
    int AddRange(IEnumerable<T> e);

    /// <summary>
    /// Gets a entity by it's specified INT primary key field.
    /// </summary>
    /// <param name="id">INT Id of the entity to be found on the Database.</param>
    /// <returns>Returns the found entity or null if not found.</returns>
    T Get(int id);

    /// <summary>
    /// Get all entities of a specified type.
    /// </summary>
    /// <param name="i">Relationed entities to be included on the query.</param>
    /// <returns>Returns all the entities found on the Database or null if not found.</returns>
    IEnumerable<T> All([Optional]params string[] i);

    /// <summary>
    /// Updates a specified entity.
    /// </summary>
    /// <param name="e">Entity to be updated to the Database.</param>
    /// <returns>Returns true if updated or false if not updated.</returns>
    bool Update(T e);

    /// <summary>
    /// Deletes a specified entity.
    /// </summary>
    /// <param name="e">Entity to be deleted from the Database.</param>
    /// <returns>Returns true if deleted or false if not deleted.</returns>
    bool Remove(T e);

    /// <summary>
    /// Deletes a specified list of entities.
    /// </summary>
    /// <param name="e">List of entities to be deleted from the Database.</param>
    /// <returns>Returns the amount of deleted entities from the Database.</returns>
    int RemoveRange(IEnumerable<T> e);
}