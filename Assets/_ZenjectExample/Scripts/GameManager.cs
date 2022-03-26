using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zenject;

namespace _ZenjectExample
{
    public class GameManager : MonoBehaviour, IGameManager
    {
        [Inject] private Cooldown _cooldown;
        
        private float _printRate = 1f;
        private float _lastPrinted = float.NaN;

        private void Awake()
        {
            _lastPrinted = -_printRate - 0.1f;
        }

        private void Start()
        {
            Debug.Log("started");
        }

        public void Print(string x)
        {
            float timestamp = Time.time;
            
            if (timestamp > (_lastPrinted + _printRate))
            {
                Debug.Log(x);
                _lastPrinted = timestamp;
            }
        }
    }
}
