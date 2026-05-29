# Command Reference
This documentation goes over command syntax and how to utilize this in a script using an example.

Note: Scripts are case-sensitive.   

## Command Syntax
`<input> <wait> <time> <action> <arguments>`

- `<input>`: Dictates which input device is used (keyboard or mouse).
- `<wait>`: Optional keyword stating a delay before execution.
- `<time>`: Required option after `wait` argument, defines the delay in milliseconds. Random times are denoted by an `R` prefix and a given time interval (e.g.: `R[500,1000]`).
- `<action>`: Determines the correlation action of the chosen input.
- `<arguments>`: Parameters given to the action.

### Using the Wait Modifier
Because your `InputController` explicitly supports static and randomized delayed actions (e.g., `MouseDelayedButtonDown`, `RandomDelayedKeyboardKeyPress`), the optional `wait` parameter can take either a static number or a random interval:
* **Static Delay:** `wait 500` (Pauses for exactly 500ms before executing the action)
* **Randomized Delay:** `wait R[100,500]` (Pauses for a random time between 100ms and 500ms before executing the action)

## List of Commands

### Mouse Commands

| Input | Action | Arguments | Description | Example |
| :--- | :--- | :--- | :--- | :--- |
| `mouse` | `move` | `<x> <y>` | Moves the cursor to the absolute screen coordinates. | `mouse move 1920 1080` |
| `mouse` | `moveby` | `<x> <y>` | Moves the cursor relative to its current position. | `mouse moveby 50 -50` |
| `mouse` | `scroll` | `<direction> <clicks>` | Scrolls the mouse wheel in the given direction. | `mouse scroll down 3` |
| `mouse` | `down` | `<button>` | Holds down the specified mouse button. | `mouse down left` |
| `mouse` | `up` | `<button>` | Releases the specified mouse button. | `mouse up left` |
| `mouse` | `press` | `<button>` | Clicks (presses and releases) the specified mouse button. | `mouse press right` |

**Mouse Examples with Wait:**
* `mouse wait 500 press left` *(Translates to: `DelayedMouseButtonPress`)*
* `mouse wait R[100,300] down right` *(Translates to: `RandomDelayedMouseButtonDown`)*

### Keyboard Commands

| Input | Action | Arguments | Description | Example |
| :--- | :--- | :--- | :--- | :--- |
| `keyboard` | `down` | `<key>` | Holds down the specified key. | `keyboard down shift` |
| `keyboard` | `up` | `<key>` | Releases the specified key. | `keyboard up shift` |
| `keyboard` | `press` | `<key>` | Presses and releases the specified key. | `keyboard press enter` |
| `keyboard` | `combo` | `<modifier> <key>` | Holds a modifier, taps a key, and releases the modifier. | `keyboard combo control c` |
| `keyboard` | `type` | `<text>` | Types out a sequence of keys automatically. | `keyboard type hello world` |

**Keyboard Examples with Wait:**
* `keyboard wait 1000 press space` *(Translates to: `KeyboardDelayedKeyPress`)*
* `keyboard wait R[50,150] press tab` *(Translates to: `RandomDelayedKeyboardKeyPress`)*

### Standalone Commands

While most actions are tied to a specific input device, the controller also supports independent execution delays.

| Input | Action | Arguments | Description | Example |
| :--- | :--- | :--- | :--- | :--- |
| `engine` | `wait` | `<time>` | Pauses the script for a static amount of time (ms). | `engine wait 1000` |
| `engine` | `wait` | `R[<min>,<max>]` | Pauses the script for a randomized amount of time (ms). | `engine wait R[500,1500]` |

*(Note: `engine` is used here as a placeholder for the `<input>` field to satisfy the strict syntax requirements for standalone thread delays).*

### Example Script
```text
# Move the mouse and double click with humanized variance
mouse move 500 500
mouse press left
mouse wait R[50,120] press left

# Wait exactly one second, then type text
engine wait 1000
keyboard type hello world

# Execute a delayed copy command
keyboard wait 500 combo control c