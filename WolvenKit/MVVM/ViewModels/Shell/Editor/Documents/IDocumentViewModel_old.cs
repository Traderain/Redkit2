namespace WolvenKit.MVVM.ViewModels.Shell.Editor.Documents
{
    /// <summary>
    /// Represents a viewmodel
    /// </summary>
    public interface Old_IDocumentViewModel/* : INotifyPropertyChanged, INotifyPropertyChanging*/
    {
        string FileName { get; }

        void SaveFile();

        object SaveTarget { get; set; }
        string Title { get; }

        void Close();
    }
}
