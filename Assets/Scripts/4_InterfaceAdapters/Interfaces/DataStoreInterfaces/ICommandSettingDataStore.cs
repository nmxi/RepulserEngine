﻿using System;
using System.Collections.Generic;
using ProjectBlue.RepulserEngine.Domain.DataModel;

namespace ProjectBlue.RepulserEngine.DataStore
{

    public interface ICommandSettingDataStore
    {
        void Save(IEnumerable<CommandSetting> commandSettingList);
        IEnumerable<CommandSetting> Load();
        IObservable<IEnumerable<CommandSetting>> OnDataChangedAsObservable { get; }
    }
    
}