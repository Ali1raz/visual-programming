using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace mid_proj.Helpers
{
    public static class PasswordBoxHelper
    {
        public static readonly DependencyProperty BoundPasswordProperty =
            DependencyProperty.RegisterAttached(
                "BoundPassword",
                typeof(string),
                typeof(PasswordBoxHelper),
                new FrameworkPropertyMetadata(string.Empty, OnBoundPasswordChanged)
                {
                    BindsTwoWayByDefault = true, // Enable two-way binding
                    // Ensure VM property updates as user types in PasswordBox
                    DefaultUpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
                });

        private static bool _isUpdating; // Flag to prevent recursive updates

        public static string GetBoundPassword(DependencyObject dp)
        {
            return (string)dp.GetValue(BoundPasswordProperty);
        }

        public static void SetBoundPassword(DependencyObject dp, string value)
        {
            dp.SetValue(BoundPasswordProperty, value);
        }

        private static void OnBoundPasswordChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is PasswordBox passwordBox)
            {
                // Avoid recursive updates when the PasswordBox's Password property changes
                passwordBox.PasswordChanged -= PasswordBox_PasswordChanged;

                if (!_isUpdating)
                {
                    passwordBox.Password = (string)e.NewValue;
                }
                // Always re-attach the handler
                passwordBox.PasswordChanged += PasswordBox_PasswordChanged;
            }
        }

        private static void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            // When the PasswordBox's actual Password changes (user types), update the attached property
            if (sender is PasswordBox passwordBox)
            {
                _isUpdating = true;
                SetBoundPassword(passwordBox, passwordBox.Password);
                _isUpdating = false;
            }
        }
    }
}
