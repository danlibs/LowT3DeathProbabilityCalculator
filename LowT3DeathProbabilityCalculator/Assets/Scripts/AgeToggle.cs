using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AgeToggle : MonoBehaviour
{
    public static int x2;

    [SerializeField]
    private Text text;

    private Toggle toggle;

    private void Awake()
    {
        toggle = GetComponent<Toggle>();
    }

    public void ToggleOn(bool value)
    {
        toggle.isOn = value;
        if (toggle.isOn)
        {
            x2 = 1;
            text.text = "> 39";
        }
        else
        {
            x2 = 0;
            text.text = "\u2264 39";
        }
    }
}
