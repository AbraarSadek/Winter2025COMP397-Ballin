using UnityEngine;
using System;
using System.Collections.Generic;

public class Options : MonoBehaviour
{
    public GameObject mainOptionsPanel;
    public GameObject keybindsPanel;

    private void Start()
    {
        ShowMainOptions();
    }
    public void ShowMainOptions()
    {
        keybindsPanel.SetActive(false);
        mainOptionsPanel.SetActive(true);
    }

    public void ShowKeybinds()
    {
        mainOptionsPanel.SetActive(false);
        keybindsPanel.SetActive(true);
    }
}
