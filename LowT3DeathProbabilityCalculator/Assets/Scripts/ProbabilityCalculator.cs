using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProbabilityCalculator : MonoBehaviour
{
    private Text text;

    private void Awake()
    {
        text = GetComponent<Text>();
    }

    public void CalculateProbability ()
    {
        double logitPi = -3.1176 + (2.8899 * LenghtToggle.x1) + (2.6958 * AgeToggle.x2) + (0.6120 * ComorbidityToggle.x3) + (2.9073 * FT3Toggle.x4) + (1.9419 * RT3Toggle.x5);
        double p = 1 / (1 + Mathf.Exp((float)-logitPi));
        double probability = p * 100;
        text.text = probability.ToString("F2") + "%";
    }
}
