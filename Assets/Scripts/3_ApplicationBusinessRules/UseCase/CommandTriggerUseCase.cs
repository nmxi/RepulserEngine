using System;
using ProjectBlue.RepulserEngine.Domain.DataModel;
using ProjectBlue.RepulserEngine.Presentation;
using ProjectBlue.RepulserEngine.UseCaseInterfaces;
using UniRx;

namespace ProjectBlue.RepulserEngine.Domain.UseCase
{

    public class CommandTriggerUseCase : ICommandTriggerUseCase, IDisposable
    {
        private ICommandTriggerPresenter commandTriggerPresenter;

        public IObservable<CommandSetting> OnCommandTriggeredAsObservable => onCommandTriggeredSubject;
        
        private Subject<CommandSetting> onCommandTriggeredSubject = new Subject<CommandSetting>();

        private CompositeDisposable disposable = new CompositeDisposable();

        public CommandTriggerUseCase(ICommandTriggerPresenter commandTriggerPresenter)
        {
            this.commandTriggerPresenter = commandTriggerPresenter;

            commandTriggerPresenter.OnTriggerAsObservable.Subscribe(SendCommand).AddTo(disposable);
        }

        public void SendCommand(CommandSetting commandSetting)
        {
            onCommandTriggeredSubject.OnNext(commandSetting);
        }

        public void Dispose()
        {
            disposable.Dispose();
            onCommandTriggeredSubject.Dispose();
        }
    }

}