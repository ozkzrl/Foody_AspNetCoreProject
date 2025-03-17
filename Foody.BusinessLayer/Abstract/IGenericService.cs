public interface IGenericService<T> where T : class
{

  void Add(T entity);
        void TDelete(T entity);

        void TUpdate(T entity);
        T TGetById(int id);
        List<T> TGetAll();

}