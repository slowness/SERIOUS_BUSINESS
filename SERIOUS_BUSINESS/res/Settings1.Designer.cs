﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SERIOUS_BUSINESS.res {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Settings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Settings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SERIOUS_BUSINESS.res.Settings", typeof(Settings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SBPS.
        /// </summary>
        internal static string app_title {
            get {
                return ResourceManager.GetString("app_title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data Source =(local); Database = DATABASE; Integrated Security = SSPI;.
        /// </summary>
        internal static string dbConn_ConnStr {
            get {
                return ResourceManager.GetString("dbConn_ConnStr", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data Source =(local);.
        /// </summary>
        internal static string dbConn_DataSource {
            get {
                return ResourceManager.GetString("dbConn_DataSource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Database = DATABASE;.
        /// </summary>
        internal static string dbConn_DbName {
            get {
                return ResourceManager.GetString("dbConn_DbName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Integrated Security = SSPI;.
        /// </summary>
        internal static string dbConn_IntSecurity {
            get {
                return ResourceManager.GetString("dbConn_IntSecurity", resourceCulture);
            }
        }
    }
}
