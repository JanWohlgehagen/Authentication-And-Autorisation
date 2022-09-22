namespace Domain;

public class Cat
{
    public int _Id { set; get; }
    public string _name { set; get; }
    public int _age { set; get; }

    public string _colourTheme { set; get; }
    
    public string _gender { set; get; }
    

    public Cat(int Id, string name, int age, string colourTheme, string gender)
    {
        _Id = Id;
        _gender = gender;
        _name = name;
        _age = age;
        _colourTheme = colourTheme;
    }

    public Cat()
    {
        
    }
}