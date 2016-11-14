namespace AngleSharp.Demos.Indotnet
{
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    sealed class MainViewModel : INotifyPropertyChanged
    {
        private readonly IBrowsingContext _context;
        private String _source;
        private String _title;
        private String _result;
        private Task _current;

        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel()
        {
            _context = BrowsingContext.New(Configuration.Default.WithJavaScript());
            _source = String.Empty;
            _title = String.Empty;
            _result = String.Empty;
            _current = Task.FromResult<Boolean>(true);
        }

        public String Title
        {
            get { return _title; }
            set { _title = value; RaisePropertyChanged(); }
        }

        public String Source
        {
            get { return _source; }
            set { _source = value; RaisePropertyChanged(); _current.ContinueWith(_ => ParseAsync(value)); }
        }

        public String Result
        {
            get { return _result; }
            private set { _result = value; RaisePropertyChanged(); }
        }

        private async Task ParseAsync(String source)
        {
            var document = await _context.OpenAsync(res => res.Content(source));

            Result = document.ToHtml();
            Title = document.Title;
        }

        private void RaisePropertyChanged([CallerMemberName] String propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
