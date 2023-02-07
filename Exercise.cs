class Exercise
{

    private string _name;
    private int _reps;
    private int _sets;
    private int _timer;  // Time between sets in seconds

    public Exercise(string name, int sets, int reps, int timer)
    {
        this._name = name;
        this._sets = sets;
        this._reps = reps;
        this._timer = timer;
    }
    
    public string Name => _name;
    public int Reps => _reps;
    public int Sets => _sets;
    public int Timer => _timer;

    public void ChangeName(string newName)
    {
        _name = newName.Trim();
    }

    public void EditSetsReps(int sets, int reps) 
    {
        this._sets = sets;
        this._reps = reps;
    }

    public void EditTimer(int seconds)
    {
        _timer = seconds;
    }

    private void _changeTime(int seconds)
    {
        _timer += seconds;
        if (_timer < 0)
        {
            _timer = 0;
        }
    }

    public void AddMinute()
    {
        _changeTime(60);
    }

    public void SubtractMinute()
    {
        _changeTime(-60);
    }

    public void AddHalfMinute()
    {
        _changeTime(30);
    }

    public void SubtractHalfMinute()
    {
        _changeTime(-30);
    }
}