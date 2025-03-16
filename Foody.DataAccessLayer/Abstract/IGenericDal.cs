public interface  IGenericDal<T> where T : class
{
    void Insert(T, entity);
    void Update(T, entity);
    void delete(int id);

    List<T> GetAll(); 

    T GetById(int id);

    
}