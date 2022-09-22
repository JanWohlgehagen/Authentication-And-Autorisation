using Domain;
using Infrastructure;

namespace Application;

public class CatService
{
    private CatRepository _catRepository;

    public CatService()
    {
        _catRepository = new CatRepository();
    }

    public List<Cat> GetCats()
    {
        return _catRepository.GetCats();
    }

    public void RemoveCat(Cat cat)
    {
        _catRepository.RemoveCat(cat);
    }
    
}