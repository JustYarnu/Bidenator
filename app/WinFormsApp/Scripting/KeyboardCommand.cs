using WindowsInput;
using WindowsInput.Events;

public class KeyboardCommand : IMacroCommand
{
    public KeyCode Key { get; }   
    public KeyAction Action { get; }

    public KeyboardCommand(KeyCode key, KeyAction action)
    {
        Key = key;
        Action = action;
    }

    public void Execute(InputController controller)
    {
        switch (Action)
        {
            case KeyAction.Down:
                controller.KeyboardKeyDown(Key);
                break;
            case KeyAction.Up:
                controller.KeyboardKeyUp(Key);
                break;
            case KeyAction.Press:
                controller.KeyboardKeyPress(Key);
                break;
        }
    }
}