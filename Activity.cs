using System.Collections.Generic;

class Activity
{

    private string _name = "New Activity";
    private List<Exercise> _exercises = new List<Exercise>();

    public Activity(string name)
    {
        this._name = name;
    }

    //public string Name { get; }
    //public List<Exercise> Exercises { get; }

    string Name => _name;
    List<Exercise> Exercises => _exercises;

    public void AddExercise(Exercise exercise)
    {
        _exercises.Add(exercise);
    }

    public void RemoveExercise(Exercise exercise)
    {
        _exercises.Remove(exercise);
    }

    public void ChangeName(string name)
    {
       this._name = name.Trim();
    }

}

