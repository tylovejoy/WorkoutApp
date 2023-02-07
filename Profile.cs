using System.Collections.Generic;

class Profile
{

    private string _firstName = "";
    private string _lastName = "";
    private List<Activity> _activities = new List<Activity>();

    public Profile(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }

    public Profile(string firstName)
    {
        _firstName = firstName;
    }

    public string FirstName => _firstName;
    public string LastName => _lastName;
    public string FullName => FirstName + " " + LastName;
    public List<Activity> Activities => _activities;

    public void AddActivity(Activity activity) { _activities.Add(activity); }

    public void RemoveActivity(Activity activity) { _activities.Remove(activity); }

    public void ChangeFirstName(string firstName) { _firstName = firstName; }
    public void ChangeLastName(string lastName) { _lastName = lastName; }
    public void ChangeFullName(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }

}