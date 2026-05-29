public class KeyboardComboCommand : IMacroCommand{
    public KeyCode ModifierKey { get; set; }
    public KeyCode PrimaryKey { get; set; }

    public KeyboardComboCommand(KeyCode modifier, KeyCode primary){
        ModifierKey = modifier
        PrimaryKey = primary
    }

    public void Execute(InputController controller)
    {
        controller.KeyboardModifiedStroke(Modifier, Key);
    }
}