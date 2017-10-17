using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LosingWeightWithCSharp7Plus.Snippets.ExpressionBodiedMembersWithConstructorsFinalizersAndAccessors
{
    public class EmployeeBefore : INotifyPropertyChanged, IDisposable
    {
        public EmployeeBefore(int id)
        {
            Id = id;
        }

        ~EmployeeBefore()
        {
            ReleaseUnmanagedResources();
        }

        public int Id { get; }

        public string FullName => string.Concat(_firstName, " ", _lastName).Trim();

        public decimal GetYearlySalary() => 12*CalculateMonthlySalary();

        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set { SetProperty(value, ref _firstName); }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { SetProperty(value, ref _lastName); }
        }

        #region Some Boilerplate Code
        public event PropertyChangedEventHandler PropertyChanged;

        private void SetProperty<T>(T newValue, ref T currentValue, [CallerMemberName] string propertyName = "") where T : IEquatable<T>
        {
            if (newValue.Equals(currentValue)) return;

            currentValue = newValue;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void ReleaseUnmanagedResources()
        {
            // Let's pretend that we are releasing some unmanaged resources here ;-)
        }

        public void Dispose()
        {
            ReleaseUnmanagedResources();
            GC.SuppressFinalize(this);
        }

        private decimal CalculateMonthlySalary()
        {
            // Let's pretend that we have some really tough logic here ;-)
            return 0;
        }
        #endregion
    }
}