﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace exportaXML.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.0.3.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"User=SYSDBA;
Password=masterkey;
Database=C:\Users\yurii\Documents\Github\exporta-xml\ecodados.eco;
DataSource=localhost;
Port=3050;Dialect=3;
Charset=NONE;Role=;
Connection lifetime=15;
Pooling=true;
MinPoolSize=0;
MaxPoolSize=50;
Packet Size=8192;
ServerType=0;")]
        public string conexaoDB {
            get {
                return ((string)(this["conexaoDB"]));
            }
            set {
                this["conexaoDB"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Users\\yurii\\Documents\\Github\\exporta-xml\\xml")]
        public string processosExportar {
            get {
                return ((string)(this["processosExportar"]));
            }
            set {
                this["processosExportar"] = value;
            }
        }
    }
}