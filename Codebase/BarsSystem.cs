using UnityEngine;

namespace BSUIR.Fitushka
{
    [DisallowMultipleComponent]
    public sealed class BarsSystem : MonoBehaviour
    {
        [SerializeField] private Bar[] bars;
        
        public void UpdateBar(Properties property, int value)
        {
            bars[(int)property].ChangeValue(value);
        }
    }
}