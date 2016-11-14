namespace AngleSharp.Demos.Indotnet
{
    using System;
    using System.Windows.Input;

    sealed class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        readonly Action _run;

        public RelayCommand(Action run)
        {
            _run = run;
        }

        public Boolean CanExecute(Object parameter)
        {
            return true;
        }

        public void Execute(Object parameter)
        {
            _run();
        }
    }
}
