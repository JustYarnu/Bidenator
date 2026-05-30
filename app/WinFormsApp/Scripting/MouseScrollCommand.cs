using WindowsInput.Events;

public class MouseScrollCommand : IMacroCommand
{
    public ButtonCode button {get; set;}
    public int clicks {get; set;}

    public MouseScrollCommand(ButtonCode Button, int Clicks)
    {
        button = Button;
        clicks = Clicks;
    }

    public void Execute(InputController controller)
    {
        controller.MouseScroll(button, clicks);
    }

}