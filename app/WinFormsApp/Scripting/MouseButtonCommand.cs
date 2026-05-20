using WindowsInput;
using WindowsInput.Events;

public class MouseButtonCommand : IMacroCommand
{
    public ButtonCode Button { get; }
    public ButtonAction Action { get; }

    // One constructor to rule them all
    public MouseButtonCommand(ButtonCode button, ButtonAction action)
    {
        Button = button;
        Action = action;
    }

    public void Execute(InputController controller)
    {
        switch (Action)
        {
            case ButtonAction.Down:
                controller.MouseButtonDown(Button);
                break;
            case ButtonAction.Up:
                controller.MouseButtonUp(Button);
                break;
            case ButtonAction.Press:
                controller.MouseButtonPress(Button);
                break;
        }
    }
}