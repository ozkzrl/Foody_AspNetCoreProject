namespace Foody.DataAccessLayer.Abstract
{
    public interface IGenericDal<T>
    {
        // Metodlar ve parametreler doğru şekilde tanımlanmalıdır
        void Add(T entity);
        void Delete(int id);

        void Update(T entity);
        T GetById(int id);
        List<T> GetAll();
    }
}
