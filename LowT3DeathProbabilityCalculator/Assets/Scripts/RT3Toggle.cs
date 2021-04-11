using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RT3Toggle : MonoBehaviour
{
    public static int x5;

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
            x5 = 1;
            text.text = "> 0,87 ng/mL";
        }
        else
        {
            x5 = 0;
            text.text = "\u2264 0,87 ng/mL";
        }
    }
}
