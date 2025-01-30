namespace Test.Text_Adventure;

public class Room
{
    private string _roomName;
    public string roomDescription;
    public string explorationDescription;
    private Dictionary<string, Room> adjacentRooms = new Dictionary<string, Room>();
    
    // List of items within the room

    public Room(string roomName)
    {
        _roomName = roomName;
    }
    
}