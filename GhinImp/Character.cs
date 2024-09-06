namespace GhinImp;

// Record для хранения данных о персонаже

public record Character
{
    public string Name { get; init; }
    public string Element { get; }
    public int AttackPower { get; init; }//2
    public List<Skill> Skills;

    public Character(string name, string element, int attackPower, List<Skill> skills)
    {
        Name = name;
        Element = element;
        AttackPower = attackPower;
        Skills = skills;
    }

    // Метод для проверки силы атаки
    public Boolean IsPowerful() //1
    {
        return AttackPower > 80;
    }
}