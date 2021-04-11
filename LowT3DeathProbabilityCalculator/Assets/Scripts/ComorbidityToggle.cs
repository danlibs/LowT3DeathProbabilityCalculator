using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComorbidityToggle : MonoBehaviour
{
    public static int x3;

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
            x3 = 1;
            text.text = "Yes";
        }
        else
        {
            x3 = 0;
            text.text = "No";
        }
    }
}
