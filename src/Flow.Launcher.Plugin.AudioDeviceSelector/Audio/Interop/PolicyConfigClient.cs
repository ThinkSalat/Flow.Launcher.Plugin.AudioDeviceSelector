﻿using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow.Launcher.Plugin.AudioDeviceSelector.Audio.Interop
{
    [ComImport]
    [Guid("870AF99C-171D-4F9E-AF0D-E63DF40C2BC9")]
    public class PolicyConfigClient { }

    public class PolicyConfigClientWin7
    {
        IPolicyConfigWin7 _policyClient = (IPolicyConfigWin7)new PolicyConfigClient();

        public void SetEndpointVisibility(string deviceId, bool isVisible)
        {
            _policyClient.SetEndpointVisibility(deviceId, isVisible ? (short)1 : (short)0);
        }

        public void SetDefaultEndpoint(string deviceId, ERole role = ERole.eMultimedia)
        {
            _policyClient.SetDefaultEndpoint(deviceId, role);
        }
    }
}
