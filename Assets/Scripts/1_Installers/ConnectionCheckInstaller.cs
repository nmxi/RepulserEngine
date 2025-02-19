﻿using ProjectBlue.RepulserEngine.DataStore;
using ProjectBlue.RepulserEngine.Domain.UseCase;
using ProjectBlue.RepulserEngine.Presentation;
using ProjectBlue.RepulserEngine.Repository;
using Zenject;

namespace ProjectBlue.RepulserEngine.Installers
{
    public class ConnectionCheckInstaller : Installer<ConnectionCheckInstaller>
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<ConnectionCheckDataStore>().AsSingle();
            Container.BindInterfacesAndSelfTo<ConnectionCheckRepository>().AsSingle();
            Container.BindInterfacesAndSelfTo<ConnectionCheckUseCase>().AsSingle();
            Container.BindInterfacesAndSelfTo<ConnectionCheckPresenter>().AsSingle();
        }
    }
}