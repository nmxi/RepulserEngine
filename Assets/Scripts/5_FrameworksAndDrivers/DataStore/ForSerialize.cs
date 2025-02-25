﻿using System;
using System.Collections.Generic;
using ProjectBlue.RepulserEngine.Domain.DataModel;

namespace ProjectBlue.RepulserEngine.DataStore
{
    [Serializable]
    public class CommandSettingListForSerialize
    {
        public List<CommandSetting> Data = new List<CommandSetting>();

        public CommandSettingListForSerialize(){}
        
        public CommandSettingListForSerialize(IEnumerable<CommandSetting> data)
        {
            
            Data.Clear();
            
            foreach (var component in data)
            {
                Data.Add(component);
            }
        }
    }

    [Serializable]
    public class EndpointSettingListForSerialize
    {
        public List<EndpointSettingDataModel> Data = new List<EndpointSettingDataModel>();

        public EndpointSettingListForSerialize(){}
        
        public EndpointSettingListForSerialize(IEnumerable<EndpointSettingDataModel> data)
        {
            
            Data.Clear();
            
            foreach (var component in data)
            {
                if(component == null) continue;
                Data.Add(component);
            }
        }
    }
    
    [Serializable]
    public class TimecodeSettingListForSerialize
    {
        public List<TimecodeSetting> Data = new List<TimecodeSetting>();

        public TimecodeSettingListForSerialize(){}
        
        public TimecodeSettingListForSerialize(IEnumerable<TimecodeSetting> data)
        {
            
            Data.Clear();
            
            foreach (var component in data)
            {
                if(component == null) continue;
                Data.Add(component);
            }
            
        }
    }


}