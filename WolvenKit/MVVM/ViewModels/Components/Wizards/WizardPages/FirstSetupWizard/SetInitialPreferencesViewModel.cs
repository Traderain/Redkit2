using Catel;
using Catel.Data;
using Catel.Fody;
using Catel.IoC;
using Catel.MVVM;
using WolvenKit.MVVM.Model.Wizards;

namespace WolvenKit.MVVM.ViewModels.Components.Wizards.WizardPages.FirstSetupWizard
{
    internal class SetInitialPreferencesViewModel : ViewModelBase
    {
        #region constructors

        public SetInitialPreferencesViewModel(IServiceLocator serviceLocator)
        {
            Argument.IsNotNull(() => serviceLocator);

            FirstSetupWizardModel = serviceLocator.ResolveType<FirstSetupWizardModel>();
        }

        #endregion constructors

        #region properties

        /// <summary>
        /// Register the FirstSetupWizardModel property so it is known in the class.
        /// </summary>
        public static readonly PropertyData ProjectWizardModelProperty = RegisterProperty("FirstSetupWizardModel", typeof(FirstSetupWizardModel));

        /// <summary>
        /// Gets or sets the FirstSetupWizardModel.
        /// </summary>
        [Model]
        [Expose("CreateModForW3")]
        [Expose("CreateModForCP77")]
        [Expose("AutoInstallMods")]
        [Expose("AutoUpdatesEnabled")]
        public FirstSetupWizardModel FirstSetupWizardModel
        {
            get => GetValue<FirstSetupWizardModel>(ProjectWizardModelProperty);
            set => SetValue(ProjectWizardModelProperty, value);
        }

        #endregion properties
    }
}
