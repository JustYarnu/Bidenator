public class KeyboardTypeTextCommand : IMacroCommand
{
    public KeyCode[] TextKeys { get; }

    // Standard constructor for pre-mapped arrays
    public KeyboardTypeTextCommand(KeyCode[] textKeys)
    {
        TextKeys = textKeys;
    }

    // Helper constructor to quickly convert strings like "HELLO" into KeyCodes
    public KeyboardTypeTextCommand(string text)
    {
        var keys = new List<KeyCode>();
        
        foreach (char c in text.ToUpper())
        {
            // Simple mapping example, actual parser utility might need a more robust dictionary
            if (Enum.TryParse($"VK_{c}", out KeyCode parsedKey))
            {
                keys.Add(parsedKey);
            }
            else if (c == ' ')
            {
                keys.Add(KeyCode.Space);
            }
        }

        TextKeys = keys.ToArray();
    }

    public void Execute(InputController controller)
    {
        // Guard against null arrays
        if (TextKeys != null && TextKeys.Length > 0)
        {
            controller.KeyboardTypeText(TextKeys);
        }
    }
}