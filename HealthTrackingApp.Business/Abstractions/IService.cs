using HealthTrackingApp.Entity.Abstractions;

namespace HealthTrackingApp.Business.Abstractions;

public interface IService<T> where T : BaseEntity
{
    void Add(T entity);
    void Update(T entity);
    void Delete(Guid id);
    T? GetByID(Guid id);
    IEnumerable<T>? GetAll();
}
