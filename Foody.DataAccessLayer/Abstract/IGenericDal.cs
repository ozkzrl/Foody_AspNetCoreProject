namespace Foody.DataAccessLayer.Abstract
{
    public interface IGenericDal<T>
    {
        // Metodlar ve parametreler doğru şekilde tanımlanmalıdır
        void Add(T entity);
        void Delete(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
}
