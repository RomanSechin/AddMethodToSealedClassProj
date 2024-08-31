//Как только класс AmazeballsSerum будет добавлен в проект,
//у OrdinaryHuman появляется метод BreakWalls. Теперь вы можете
//использовать его в своем методе Main:
internal class Program
{
    private static void Main(string[] args)
    {
      OrdinaryHuman steve = new OrdinaryHuman(185);
      Console.WriteLine(steve.BreakWalls(84.2));
    }
}

sealed class OrdinaryHuman
{
  private int age;
  int weight;

  public OrdinaryHuman(int weight)
  {
    this.weight = weight;
  }
  public void GoToWork() { }
  public void PayBills() { }
}

static class AmazeballsSerum
{
  public static string BreakWalls(this OrdinaryHuman h, double wallDensity)
  {
    return $"I broke through a wall of {wallDensity} density!";
  }
}
