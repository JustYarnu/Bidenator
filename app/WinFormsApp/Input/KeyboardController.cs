using WindowsInput;
using WindowsInput.Events;

public class KeyboardController
{
    public void KeyDown(KeyCode key)
    {
        Simulate.Events().Hold(key).Invoke();
    }

    public void KeyUp(KeyCode key)
    {
        Simulate.Events().Release(key).Invoke();
    }

    public void KeyPress(KeyCode key)
    {
        Simulate.Events().Click(key).Invoke();
    }


    public void TypeText(KeyCode[] text)
    {
        foreach(KeyCode key in text)
        {
            KeyPress(key);
        }
    }

    // Handles combinations like Ctrl+C
    public void ModifiedStroke(KeyCode modifier, KeyCode key)
    {
        Simulate.Events()
            .Hold(modifier)
            .Click(key)
            .Release(modifier)
            .Invoke();
    }
}