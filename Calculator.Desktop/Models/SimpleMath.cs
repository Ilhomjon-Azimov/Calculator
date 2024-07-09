using System.Windows;

namespace Calculator.Desktop.Models
{
    public class SimpleMath
    {
        #region SimpleCalculator
        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static double Substract(double x, double y)
        {
            return x - y;
        }

        public static double Multiply(double x, double y)
        {
            return x * y;
        }

        public static double Divide(double x, double y)
        {
            if (y == 0)
            {
                MessageBox.Show("Cannot divide by zero", "Wrong operation", MessageBoxButton.OK, MessageBoxImage.Error);
                return 0;
            }
            return x / y;
        }

        #endregion
    }
}
