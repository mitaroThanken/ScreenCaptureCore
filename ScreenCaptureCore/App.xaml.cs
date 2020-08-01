using Composition.WindowsRuntimeHelpers;
using System.Windows;
using Windows.System;

namespace ScreenCaptureCore
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private DispatcherQueueController controller;

        public App()
        {
            controller = CoreMessagingHelper.CreateDispatcherQueueControllerForCurrentThread();
        }
    }
}
