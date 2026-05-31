using System.Collections.Generic;
using Sailock.Helpers;
using Sailock.Models;
using Sailock.Services;

namespace Sailock.ViewModels
{
    public class ChangelogViewModel : ViewModelBase
    {
        public string CurrentVersion { get; } = $"v{VersionService.Current}";
        public List<ChangelogEntry> Entries { get; } = ChangelogService.GetEntries();
        public System.Action OnClose { get; set; }
        public RelayCommand CloseCommand { get; }

        public ChangelogViewModel()
        {
            CloseCommand = new RelayCommand(_ => OnClose?.Invoke());
        }
    }
}