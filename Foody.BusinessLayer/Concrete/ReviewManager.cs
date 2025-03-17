
public class ReviewManager : IReviewService
{
    private readonly IReviewDal _reviewDal;

    public ReviewManager(IReviewDal reviewDal)
    {
        _reviewDal=reviewDal;
    }

    public void Add(Review entity)
    {
        _reviewDal.Add(entity);
    }

    public void Delete(int id)
    {
        _reviewDal.Delete(id);
    }

    public List<Review> GetAll()
    {
        return _reviewDal.GetAll();
    }

    public Review GetById(int id)
    {
        return _reviewDal.GetById(id);
    }

    public void Update(Review entity)
    {
        _reviewDal.Update(entity);
    }
}