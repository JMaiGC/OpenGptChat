﻿using System.Windows.Controls;
using System.Windows.Input;

namespace OpenGptChat.Services
{
    public class SmoothScrollingService
    {
        public void Register(ScrollViewer scrollViewer)
        {
            scrollViewer.PreviewMouseWheel += ScrollViewer_PreviewMouseWheel;
        }

        public void Unregister(ScrollViewer scrollViewer)
        {
            scrollViewer.PreviewMouseWheel -= ScrollViewer_PreviewMouseWheel;
        }

        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer scrollViewer = (ScrollViewer)sender;

            scrollViewer.ScrollToVerticalOffset(
                scrollViewer.VerticalOffset - e.Delta);
            e.Handled = true;
        }
    }
}
