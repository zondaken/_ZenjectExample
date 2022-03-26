using Unity.Mathematics;
using Zenject;

namespace _ZenjectExample
{
    public class Cooldown
    {
        private float _time = 0f;
        
        public void Tick(float deltaTime)
        {
            _time += deltaTime;
        }
    }
}