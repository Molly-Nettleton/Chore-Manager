namespace choremanager.Services;

public class ChoresService
{
  private readonly FakeDb _db;

  public List<Chore> GetChores()
  {
    return _db.Chores;
  }

  public Chore GetChore(int id)
  {
    var chore = _db.Chores.Find(c => c.Id == id);
    if (chore == null)
    {
      throw new Exception("Invalid Id");
    }
    return chore;
  }

// public Chore EditChore(int id, Chore choreData)
// {
//    var chore = _db.Chores.Find(c=> c.Id == id);
//     if( chore == null )
//     {
//       throw new Exception("Invalid Id");
//     }

//     _db.Chores.Edit(id, choreData);

//     return chore;
// }
public Chore RemoveChore(int id)
{
    var chore = _db.Chores.Find(c=> c.Id == id);
    if( chore == null )
    {
      throw new Exception("Invalid Id");
    }

    _db.Chores.Remove(chore);

    return chore;
  }

  public Chore AddChore(Chore choreData)
  {
    _db.Chores.Add(choreData);
    return choreData;
  }

  public ChoresService(FakeDb db)
  {
    _db = db;
  }
}