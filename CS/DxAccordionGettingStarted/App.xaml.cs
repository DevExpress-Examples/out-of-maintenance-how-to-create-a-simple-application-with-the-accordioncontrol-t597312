using System.Windows;

namespace DxAccordionGettingStarted {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        private void OnAppStartup_UpdateThemeName(object sender, StartupEventArgs e) {
            DevExpress.Xpf.Core.ApplicationThemeHelper.UpdateApplicationThemeName();
        }
    }
}
