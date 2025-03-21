
public class ReviewManager : IReviewService
{
    private readonly IReviewDal _reviewDal;

    public ReviewManager(IReviewDal reviewDal)
    {
        _reviewDal=reviewDal;
    }

    public void TAdd(Review entity)
    {
        _reviewDal.Add(entity);
    }

    public void TDelete(int id)
    {
        _reviewDal.Delete(id);
    }

    public List<Review> TGetAll()
    {
        return _reviewDal.GetAll();
    }

    public Review TGetById(int id)
    {
        return _reviewDal.GetById(id);
    }

    public void TUpdate(Review entity)
    {
        _reviewDal.Update(entity);
    }
}