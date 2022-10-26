namespace choremanager.Models;
using ChoreType.Enums;

public class Chore
{
public int Id { get; private set; }
public string Name { get; private set; }
public int Difficulty { get; private set; }
public bool IsCompleted { get; private set; }

public ChoreType Type  { get; private set; }

  public Chore(string name, int difficulty, bool isCompleted, ChoreType type, int id)
{
    Id = id;
    Name = name;
  Difficulty = difficulty;
  IsCompleted = isCompleted;
  Type = type;
  }


}