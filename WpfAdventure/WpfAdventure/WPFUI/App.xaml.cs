using System.Windows.Threading;
using System.Windows;
using Engine.Services;

namespace WPFUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void App_OnDispatcherUnhandledException(object sender,DispatcherUnhandledExceptionEventArgs e)
        {
            string excetionMessageText =
                $"An exception occurred : {e.Exception.Message}\r\n\r\nat: {e.Exception.StackTrace}";

            LoggingService.Log(e.Exception);

            //TODO: Create a Window to display yhe exception information
            MessageBox.Show(excetionMessageText, "Unhandled Exception", MessageBoxButton.OK);
        }
    }
}
