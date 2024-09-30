using System;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace BSUIR.Fitushka
{
    [RequireComponent(typeof(Button))]
    public class BuyButton : MonoBehaviour
    {
        [SerializeField] private Button button;
        [SerializeField] private ButtonConfig config;
        private BarsSystem barsSystem;

        public event Action<Properties, int> OnClicked;

        [Inject]
        private void Constructor(BarsSystem barsSystem)
        {
            this.barsSystem = barsSystem;
        }

        private void OnEnable()
        {
            button.onClick.AddListener(ApplyUpdates);
        }

        private void ApplyUpdates()
        {
            foreach (var property in config.Properties)
            {
                barsSystem.UpdateBar(property.Key, property.Value);
            }
        }
    }
}
