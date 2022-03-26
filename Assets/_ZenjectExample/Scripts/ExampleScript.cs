using System;
using UnityEngine;
using UnityEngine.Serialization;
using Zenject;

namespace _ZenjectExample
{
    public class ExampleScript : MonoBehaviour
    {
        [Inject] private IGameManager _gameManager;
        [SerializeField] private bool mayPrint = false;

        private void Update()
        {
            if (mayPrint)
            {
                _gameManager.Print("Example");
            }
        }

        private void OnGUI()
        {
            if (GUI.Button(new Rect(0, 0, 70, 20), "Click"))
            {
                mayPrint = true;
            }
        }
    }
}