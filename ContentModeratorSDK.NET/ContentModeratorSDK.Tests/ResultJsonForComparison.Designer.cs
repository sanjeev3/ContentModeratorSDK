﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ContentModeratorSDK.Tests {
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
    internal class ResultJsonForComparison {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ResultJsonForComparison() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ContentModeratorSDK.Tests.ResultJsonForComparison", typeof(ResultJsonForComparison).Assembly);
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
        ///   Looks up a localized string similar to {&quot;Status&quot;:{&quot;Code&quot;:3000,&quot;Description&quot;:null,&quot;Exception&quot;:null},&quot;TrackingId&quot;:&quot;WUS_90920_551f20262703740db8eaa3df_014d34bec5874797b7ef74c2cbcabe0a&quot;,&quot;Language&quot;:&quot;eng&quot;,&quot;Terms&quot;:[{&quot;Term&quot;:&quot;freaking&quot;,&quot;Index&quot;:134,&quot;OriginalIndex&quot;:128}],&quot;Misrepresentation&quot;:null,&quot;NormalizedText&quot;:&quot;The &lt;a her=\&quot; www.bunnies.com\&quot; &gt;Qu! cu&lt;\/ a&gt; brown &lt;a her=\&quot; b.suspiciousdomain.com\&quot; &gt;f0x&lt;\/ a&gt; jumps over the lazy dog www. benign. net. freaking awesome.&quot;,&quot;OriginalText&quot;:&quot;The &lt;a href=\&quot;www.bunnies.com\&quot;&gt;qu!ck&lt;\/a&gt; brown  &lt;a href=\&quot;b.suspicious [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TextV2_ScreenTextTest {
            get {
                return ResourceManager.GetString("TextV2_ScreenTextTest", resourceCulture);
            }
        }
    }
}
