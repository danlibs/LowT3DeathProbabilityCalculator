using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LenghtToggle : MonoBehaviour, IToggleCheck
{
    public static int x1;

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
            x1 = 1;
            text.text = "> 7";
        } else
        {
            x1 = 0;
            text.text = "\u2264 7";
        }
    }

}
