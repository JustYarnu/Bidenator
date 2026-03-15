using System.Security.Permissions;
using WindowsInput.Events;

public class InputController
{
    private MouseController mouse;
    private KeyboardController keyboard;

    private Random rnd;
    public InputController()
    {
        mouse = new MouseController();
        keyboard = new KeyboardController();
        rnd = new Random();

        void MouseButtonDown(ButtonCode button)
        {
            mouse.ButtonDown(button);
        }

        void MouseButtonUp(ButtonCode button)
        {
            mouse.ButtonUp(button);
        }

        void MouseButtonPress(ButtonCode button)
        {
            mouse.ButtonPress(button);
        }

        void KeyboardKeyDown(KeyCode key)
        {
            keyboard.KeyDown(key);
        }
        
        void KeyboardKeyUp(KeyCode key)
        {
            keyboard.KeyUp(key);
        }

        void KeyboardKeyPress(KeyCode key)
        {
            keyboard.KeyPress(key);
        }

        void MouseDelayedButtonDown(ButtonCode button, int delay)
        {
            Thread.Sleep(delay);
            MouseButtonDown(button);
        }

        void RandomDelayedMouseButtonDown(ButtonCode button, int upperBound, int lowerBound)
        {
            Thread.Sleep(rnd.Next(lowerBound, upperBound+1));
            MouseButtonDown(button);
        }

        void MouseDelayedButtonUp(ButtonCode button, int delay)
        {
            Thread.Sleep(delay);
            MouseButtonUp(button);
        }

        void RandomDelayedMouseButtonUp(ButtonCode button, int upperBound, int lowerBound)
        {
            Thread.Sleep(rnd.Next(lowerBound, upperBound+1));
            MouseButtonUp(button);
        }

        void DelayedMouseButtonPress(ButtonCode button, int delay)
        {
            Thread.Sleep(delay);
            MouseButtonPress(button);
        }
        
        void RandomDelayedMouseButtonPress(ButtonCode button, int upperBound, int lowerBound)
        {
            Thread.Sleep(rnd.Next(lowerBound, upperBound+1));
        }

        
    }
}