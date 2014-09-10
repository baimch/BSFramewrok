using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;

using BSF.Data;
using BSF.Core.Models;


namespace BSF.Core.Data.Configurations.Account
{
    partial class LoginLogConfiguration
    {
        partial void LoginLogConfigurationAppend()
        {
            HasRequired(m => m.Member).WithMany(n => n.LoginLogs);
        }
    }
}