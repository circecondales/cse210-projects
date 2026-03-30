public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    protected string _eventType; // Protected so children can access it

    public Event(string title, string description, string date, string time, Address address, string eventType)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType = eventType;
    }

    public string GetStandardDetails()
    {
        return "Title: " + _title + "\nDescription: " + _description + "\nDate: " + _date + " @ " + _time + "\nLocation: " + _address.GetFullAddress();
    }

    // Virtual so it can be overridden by specific event types
    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public string GetShortDescription()
    {
        return "Type: " + _eventType + "\nTitle: " + _title + "\nDate: " + _date;
    }
}