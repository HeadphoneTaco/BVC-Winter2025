namespace Test.Text_Adventure;

    // Where the player is currently
    // Wil need rooms for the player to explore
    // Player will need inventory ro check
    // Inventory will have a list of items
    // Rooms will also have items within them
public class TextAdventure
{
    private Room currentRoom;
    
    public void PlayGame()
    {
        currentRoom = new Room("Kitchen");
        currentRoom.roomDescription = "A room for cooking food";
        currentRoom.explorationDescription = "You find some moldy cheese";
        Console.WriteLine(currentRoom.ToString());

        Room bedRoom = new Room("Bedroom");
        bedRoom.roomDescription = "A room for sleeping";
        bedRoom.explorationDescription = "You find a moldy condom";
    }
}