public interface IGenericService<T> where T : class
{

  void Add(T entity);
  void Delete(int id);

  void Update(T entity);
  T GetById(int id);
  List<T> GetAll();

}