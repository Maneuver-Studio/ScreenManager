using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Maneuver.ScreenManager
{
    public class ScreenInstaller : MonoInstaller
    {
        [SerializeField] private ScreenBase _view;
        public ScreenBase View => _view;
    }
}