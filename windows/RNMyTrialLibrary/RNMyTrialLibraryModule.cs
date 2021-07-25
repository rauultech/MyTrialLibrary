using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace My.Trial.Library.RNMyTrialLibrary
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNMyTrialLibraryModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNMyTrialLibraryModule"/>.
        /// </summary>
        internal RNMyTrialLibraryModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNMyTrialLibrary";
            }
        }
    }
}
