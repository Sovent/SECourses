namespace MovieAdviser.Domain
{
    public interface IRepository<T>
    {
        T[] GetAllEntities();

        T GetEntity(int id);

        void SaveEntity(T entity);
    }
}
