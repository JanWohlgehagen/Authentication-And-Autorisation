using Domain;

namespace Infrastructure;

public class CatRepository
{
    private CatMockDB _mockobject;

    public CatRepository()
    {
        _mockobject = new CatMockDB();
    }

    public List<Cat> GetCats()
    {
        return _mockobject.GetCats();
    }

    public void RemoveCat(Cat cat)
    {
        _mockobject.RemoveCat(cat);
    }

}