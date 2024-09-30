using UnityEngine;
using Zenject;

namespace BSUIR.Fitushka
{
    [DisallowMultipleComponent]
    public sealed class GameInstaller : MonoInstaller
    {
        [SerializeField] private BarsSystem barsSystem;

        public override void InstallBindings()
        {
            Container.Bind<BarsSystem>().FromInstance(barsSystem).AsSingle();
        }
    }
}