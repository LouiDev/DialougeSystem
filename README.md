# Dialouge system for GTA V scripting
Simple dialouge system for GTA V scripting

This is a very simple dialouge system to enhance the immersion of your GTA V script.
Just copy DialougeSystem.cs in your project and don't forget to rename the namespace.

The class has the following methods:
- ``void Progress()``                 - Progresses the dialouge
- ``void Reset()``                    - Resets the dialouge
- ``void AddActionToIndex``           - Adds an Action that will be executed once the dialouge reaches the specified index 
- ``string GetCurrentMessage()``      - Gets the current message of the dialouge
- ``bool Isrunning()``                - Checks if dialouge is running
- ``bool HasStarted()``               - Checks if dialouge has started
- ``bool HasFinished()``              - checks if dialouge has finished

# Example usage
Creating a dialouge:
```
DialougeSystem dialougeSystem = new DialougeSystem(new string[]
{
    "~g~You: ~w~Hey there, what's up!,
    "~b~Friend: ~w~Sup, dude! How's it going?"
});
```

Adding an action:
```
dialougeSystem.AddActionToIndex(1, () =>
{
    // This would be executed once the dialouge reaches the index of 1
    // Do Something
});
```

Updating the dialouge:
```
// In some form of an Update method
public void Update()
{
    // Check input
    if (PlayerCanInteract())
    {
        // Use Progress() to progress the dialouge
        dialougeSystem.Progress();
    }

    // Display the current message
    // Use GetCurrentMessage() to get the current message
    ShowMessageToPlayer(dialougeSystem.GetCurrentMessage());
}
```
