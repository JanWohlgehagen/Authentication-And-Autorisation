using Domain;

namespace Infrastructure;

public class CatMockDB
{
    List<Cat> _catList;

    public CatMockDB()
    {
        _catList = new List<Cat>();
        
        _catList.Add(new ( 1, "victor", 4, "male", "Tuxedo"));
        _catList.Add(new ( 2, "Dylan", 14, "male", "Orange/ white"));
        _catList.Add(new ( 3, "Nala", 2, "female", "Mixed colours"));
        _catList.Add(new ( 4, "Tiny Kitten", 5, "female", "black/ white"));
        _catList.Add(new ( 5, "Garfield", 14, "male", "orange/ white"));
        _catList.Add(new ( 6, "Hackerman", 13, "Unknown", "Unknown"));
        _catList.Add(new ( 7, "Gert", 7, "male", "Brown"));
        _catList.Add(new ( 8, "Snowball", 8, "female", "white"));
    }
    public List<Cat> GetCats()
    {
        return _catList;
    }

    public void AddCat(Cat cat)
    {
        _catList.Add(cat);
    }

    public void RemoveCat(Cat cat)
    {
        foreach (var c in _catList)
        {
            if (c._Id == cat._Id)
            {
                _catList.Remove(cat);
            }
        }
    }
}