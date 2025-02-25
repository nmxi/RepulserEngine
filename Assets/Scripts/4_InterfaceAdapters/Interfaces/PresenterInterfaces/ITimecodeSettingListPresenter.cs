﻿using System;
using System.Collections.Generic;
using ProjectBlue.RepulserEngine.Domain.DataModel;

namespace ProjectBlue.RepulserEngine.Presentation
{
    public interface ITimecodeSettingListPresenter
    {
        void Save(IEnumerable<TimecodeSetting> settingList);
        IEnumerable<TimecodeSetting> Load();
    }
}