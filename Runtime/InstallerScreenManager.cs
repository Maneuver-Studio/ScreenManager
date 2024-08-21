using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Maneuver.ScreenManager
{
    public class InstallerScreenManager : MonoInstaller
    {
        // Prefab of Screen Manager
        [SerializeField] private ScreenManager _screenManager;

        /// <summary>
        /// Binding first systems in container
        /// </summary>
        public override void InstallBindings()
        {
            Container.BindFactory<UnityEngine.Object, ScreenBase, ScreenFactory>().FromFactory<PrefabScreenFactory>();

            Container.Bind<IScreenManager>().FromComponentInNewPrefab(_screenManager).AsSingle().NonLazy();
        }

    }
}