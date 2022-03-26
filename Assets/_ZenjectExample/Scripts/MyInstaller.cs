using System.ComponentModel;
using Zenject;

namespace _ZenjectExample
{
    public class MyInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            //Container.Bind<IGameManager>().FromComponentInHierarchy().AsSingle();
            HierachyInstaller<IGameManager>.Install(Container);
        }
    }
}