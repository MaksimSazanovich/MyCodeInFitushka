using System;
using UnityEngine;
using UnityEngine.UI;

namespace BSUIR.Fitushka
{
    [DisallowMultipleComponent]
    public sealed class Bar : MonoBehaviour
    {
        [SerializeField] private int value;
        private int maxValue = 200;

        [SerializeField] private Image bar;

        private void Start()
        {
            ChangeValue(0);
        }

        public void ChangeValue(int deltaValue)
        {
            value += deltaValue;
            value = Mathf.Clamp(value, 0, maxValue);
            bar.fillAmount = (float) value / maxValue;
        }
    }
}