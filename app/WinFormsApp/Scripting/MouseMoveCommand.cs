public class MouseMoveCommand : IMacroCommand
{
    public int X { get; }
    public int Y { get; }
    public bool IsRelative { get; } // true = MoveBy, false = MoveTo

    public MouseMoveCommand(int x, int y, bool isRelative = false)
    {
        X = x;
        Y = y;
        IsRelative = isRelative;
    }

    public void Execute(InputController controller)
    {
        if (IsRelative)
            controller.MouseMoveBy(X, Y);
        else
            controller.MouseMoveTo(X, Y);
    }
}