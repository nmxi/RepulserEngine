﻿using ProjectBlue.RepulserEngine.Presentation;
using TMPro;
using UniRx;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace ProjectBlue.RepulserEngine.View
{
    public class OnAirButtonView : MonoBehaviour
    {

        [Inject] private IOnAirSettingPresenter onAirSettingPresenter;
        
        [SerializeField] private Button button;
        [SerializeField] private Image buttonBackground;

        [SerializeField] private TMP_Text text;

        [SerializeField] private Color onAirColor;
        [SerializeField] private Color standbyColor;

        private void Start()
        {
            button.OnClickAsObservable().Subscribe(_ =>
            {
                Toggle();
            }).AddTo(this);

            onAirSettingPresenter.OnAirSettingViewModel.isOnAir.Subscribe(SetBackground).AddTo(this);
            
            
        }

        private void Toggle()
        {
            onAirSettingPresenter.OnAirSettingViewModel.isOnAir.Value =
                !onAirSettingPresenter.OnAirSettingViewModel.IsOnAir;
        }

        private void SetBackground(bool isOnAir)
        {
            if (isOnAir)
            {
                SetOnAir();
            }
            else
            {
                SetStandby();
            }
        }

        private void SetStandby()
        {
            buttonBackground.color = standbyColor;
            text.text = "STAND\nBY";
        }
        
        private void SetOnAir()
        {
            buttonBackground.color = onAirColor;
            text.text = "ON AIR";
        }
    }

}