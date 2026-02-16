using CommandTerminal;
using System.Collections.Generic;
using UnityEngine;

public class About : MonoBehaviour
{
    [Tooltip("Text to display in the Terminal at start up about the example.")]
    public List<string> aboutText;

    [Tooltip("Initial state of the Terminal (open/closed)")]
    public TerminalState initialTerminalState = TerminalState.OpenSmall;

    void Start()
    {
        foreach (string text in aboutText)
        {
            Terminal.Log(text);
        }

        Terminal terminal = GetComponent<Terminal>();
        terminal.ToggleState(initialTerminalState);
    }
}
