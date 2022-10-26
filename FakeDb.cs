
namespace choremanager.Data;
using ChoreType.Enums;

public class FakeDb
{
  public List<Chore> Chores = new List<Chore>()
  {
    new Chore("Make Bed", 2, false, ChoreType.Bedroom, 0),
    new Chore("Wash Dishes", 10, false, ChoreType.Kitchen, 1),
    new Chore("Empty Dishwasher", 5, false, ChoreType.Kitchen, 2),
    new Chore("Rake Leaves", 6, true, ChoreType.Yard, 3),
    new Chore("Clean Litterbox", 4, true, ChoreType.Pet, 4),
    new Chore("Clean Bathtub", 4, false, ChoreType.Bathroom, 5),
  };
}