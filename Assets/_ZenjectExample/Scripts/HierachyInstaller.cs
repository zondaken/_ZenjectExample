using Zenject;

namespace _ZenjectExample
{
    public class HierachyInstaller<TContractType> : Installer<HierachyInstaller<TContractType>>
    {
        public override void InstallBindings()
        {
            Container.Bind<TContractType>().FromComponentInHierarchy().AsSingle();
        }
    }
}