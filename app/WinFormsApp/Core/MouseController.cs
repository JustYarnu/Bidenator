using System.Configuration.Assemblies;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using Microsoft.VisualBasic;
using WindowsInput;
using WindowsInput.Events;
using WindowsInput.Native;

internal class MouseController
{
    public void MoveTo(int x, int y) 
        => Simulate.Events().MoveTo(x, y).Invoke();

    public void MoveBy(int x, int y) 
        => Simulate.Events().MoveBy(x, y).Invoke();

    public void ButtonDown(ButtonCode button) 
        => Simulate.Events().Hold(button).Invoke();

    public void ButtonUp(ButtonCode button) 
        => Simulate.Events().Release(button).Invoke();

    public void Scroll(ButtonCode direction, int clicks)
    {
        Simulate.Events().Scroll(direction, clicks).Invoke();
    }

    public void XButton1Down() => ButtonDown(ButtonCode.XButton1);

    public void XButton1Up() => ButtonUp(ButtonCode.XButton1);
    public void XButton2Down() => ButtonDown(ButtonCode.XButton2);
    public void XButton2Up() => ButtonUp(ButtonCode.XButton2);
}