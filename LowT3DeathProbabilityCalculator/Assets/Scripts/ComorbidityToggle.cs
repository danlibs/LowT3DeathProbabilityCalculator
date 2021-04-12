using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Localization.Settings;

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
            if (LocalizationSettings.SelectedLocale == LocalizationSettings.AvailableLocales.Locales[0])
            {
                text.text = "Yes";
            }
            else if (LocalizationSettings.SelectedLocale == LocalizationSettings.AvailableLocales.Locales[1])
            {
                text.text = "Sim";
            }

        }
        else
        {
            x3 = 0;
            if (LocalizationSettings.SelectedLocale == LocalizationSettings.AvailableLocales.Locales[0])
            {
                text.text = "No";
            }
            else if (LocalizationSettings.SelectedLocale == LocalizationSettings.AvailableLocales.Locales[1])
            {
                text.text = "Não";
            }
        }
    }
}
