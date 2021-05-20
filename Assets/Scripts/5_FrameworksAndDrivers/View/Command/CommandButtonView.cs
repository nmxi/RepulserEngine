using ProjectBlue.RepulserEngine.Domain.DataModel;
using ProjectBlue.RepulserEngine.Presentation;
using TMPro;
using UniRx;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace ProjectBlue.RepulserEngine.View
{

    public class CommandButtonView : MonoBehaviour
    {

        [Inject] private ICommandTriggerPresenter _commandTriggerPresenter;
        
        [SerializeField] private Button button;
        [SerializeField] private TMP_Text text;

        private CommandSetting myCommand;
        
        public void Initialize(CommandSetting command)
        {
            SetButtonText($"{command.CommandName}\n{command.CommandArguments}\n{command.Memo}");
            myCommand = command;

            button.OnClickAsObservable().Subscribe(_ =>
            {
                _commandTriggerPresenter.Send(command);
            }).AddTo(this);
        }
        
        public void SetButtonText(string buttonText)
        {
            text.text = buttonText;
        }
    }

}