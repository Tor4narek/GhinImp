namespace GhinImp;


// Класс для вычисления среднего показателя силы атаки
public class AttackCalculator
{
    // Метод для вычисления среднего показателя силы атаки
    public Func<IEnumerable<int>, int> AverageAttackCalculation = (attacks) =>
    {
        return attacks.Sum() / attacks.Count();
    };

    
    // Метод для вычисления среднего показателя силы атаки
    public int CalculateAverageAttack(Character character) //4
    {
        return AverageAttackCalculation(new List<int> { character.AttackPower });
    }
}