using AYellowpaper.SerializedCollections;
using UnityEngine;

namespace BSUIR.Fitushka
{
    [CreateAssetMenu(fileName = "ButtonConfig", menuName = "StaticData/ButtonConfig", order = 0)]
    public class ButtonConfig : ScriptableObject
    {
        [field: SerializeField] public int Lvl { get; private set; }

        [SerializedDictionary("ValueProperties", "Properties")]
        [field: SerializeField] public SerializedDictionary<Properties, int> Properties { get; private set; }
    }
}