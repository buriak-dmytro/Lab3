using System;
using System.Windows;
using System.Windows.Controls;

namespace Lab3
{
    internal static class AdditPanel
    {
        private static bool IsShowAddPanel = false;

        public static void ShowHidePanel(MainWindow mainWindow)
        {
            mainWindow.GridCalcButtons.ColumnDefinitions[4].Width = 
                new GridLength(IsShowAddPanel ? 1 : 0, GridUnitType.Star);
            IsShowAddPanel = !IsShowAddPanel;
        }
    }
}
