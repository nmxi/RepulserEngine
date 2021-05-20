

using ProjectBlue.RepulserEngine.Domain.DataModel;
using System;

namespace ProjectBlue.RepulserEngine.UseCaseInterfaces
{
    public interface ICommandTriggerUseCase
    {
        IObservable<CommandSetting> OnCommandTriggeredAsObservable { get; }
        void SendCommand(CommandSetting commandSetting);
    }
}