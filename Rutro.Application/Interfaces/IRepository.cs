using System.Linq.Expressions;

namespace Rutro.Application.Interfaces;

public interface IRepository<T> where T : class
{

    #region NON-Asynchronous Methods
    // NON-Asynchronous Add method
    /// <summary>
    /// Adds a new entity to the repository.
    /// </summary>
    /// <param name="entity">The entity to be added. This is the object that will be inserted into the data source.</param>
    void Add(T entity);

    /// <summary>
    /// Deletes a single entity from the repository.
    /// </summary>
    /// <param name="entity">The entity to be removed. This entity will be deleted from the data source.</param>
    void DeleteNormal(T entity);

    /// <summary>
    /// Deletes a range of entities from the repository.
    /// </summary>
    /// <param name="entities">A collection of entities to be removed. All entities in the collection will be deleted from the data source.</param>
    void DeleteRange(IEnumerable<T> entities);

    /// <summary>
    /// Updates an existing entity in the repository.
    /// </summary>
    /// <param name="entity">The entity with updated data. This entity will replace the existing one in the data source.</param>
    void Update(T entity);

    /// <summary>
    /// Retrieves an entity by its identifier from the repository.
    /// </summary>
    /// <param name="id">The unique identifier of the entity to be retrieved.</param>
    /// <returns>The entity with the specified ID, or <c>null</c> if no entity is found.</returns>
    T Get(int id);

    /// <summary>
    /// Retrieves a single entity that matches the specified filter from the repository.
    /// </summary>
    /// <param name="filter">The filter expression used to find the entity. This is a predicate that evaluates to <see langword="true"/> for the desired entity.</param>
    /// <param name="includeProps">A comma-separated list of related properties to include in the query (optional).</param>
    /// <returns>The first entity that matches the filter condition, or <c>null</c> if no entity is found.</returns>
    T Get(Expression<Func<T, bool>> filter, string? includeProps = null);

    /// <summary>
    /// Retrieves all entities from the repository.
    /// </summary>
    /// <param name="includeProps">A comma-separated list of related properties to include in the query (optional).</param>
    /// <returns>A collection of all entities in the repository.</returns>
    IEnumerable<T> GetAll(string? includeProps = null);
    #endregion


}