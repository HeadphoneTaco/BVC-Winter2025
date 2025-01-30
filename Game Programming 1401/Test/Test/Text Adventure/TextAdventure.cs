namespace Test.Text_Adventure;

public class TextAdventure
{
    Room currentRoom = new Room();

    public Room CurrentRoom
    {
        get => currentRoom;
        set => currentRoom = value ?? throw new ArgumentNullException(nameof(value));
    }
    // Where the player is currently
    // Wil need rooms for the player to explore
    // Player will need inventory ro check
    // Inventory will have a list of items
    // Rooms will also have items within them
}