using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FT3Toggle : MonoBehaviour
{
    public static int x4;

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
            x4 = 1;
            text.text = "< 1,6 pg/mL";
        }
        else
        {
            x4 = 0;
            text.text = "\u2265 1,6 pg/mL";
        }
    }
}