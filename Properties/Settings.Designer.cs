﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NotepadMinimal.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.5.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("150, 150")]
        public global::System.Drawing.Point MyLocation {
            get {
                return ((global::System.Drawing.Point)(this["MyLocation"]));
            }
            set {
                this["MyLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Consolas, 12pt")]
        public global::System.Drawing.Font MyFont {
            get {
                return ((global::System.Drawing.Font)(this["MyFont"]));
            }
            set {
                this["MyFont"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool MyStatusBar {
            get {
                return ((bool)(this["MyStatusBar"]));
            }
            set {
                this["MyStatusBar"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool MyWordWrap {
            get {
                return ((bool)(this["MyWordWrap"]));
            }
            set {
                this["MyWordWrap"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Black")]
        public global::System.Drawing.Color MyTextColor {
            get {
                return ((global::System.Drawing.Color)(this["MyTextColor"]));
            }
            set {
                this["MyTextColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("White")]
        public global::System.Drawing.Color MyBackgroundColor {
            get {
                return ((global::System.Drawing.Color)(this["MyBackgroundColor"]));
            }
            set {
                this["MyBackgroundColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool MyAutoSave {
            get {
                return ((bool)(this["MyAutoSave"]));
            }
            set {
                this["MyAutoSave"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1200, 800")]
        public global::System.Drawing.Size MySize {
            get {
                return ((global::System.Drawing.Size)(this["MySize"]));
            }
            set {
                this["MySize"] = value;
            }
        }
    }
}
