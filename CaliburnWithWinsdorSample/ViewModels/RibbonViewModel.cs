using Caliburn.Micro;
using System;

namespace CaliburnWithWinsdorSample.ViewModels
{
    //public class RibbonViewModel : PropertyChangedBase
    //{
    //    private bool _canDisplayNote;
    //    private string _note = string.Empty;
    //    private string _noteDisplay = string.Empty;
    //    private string _message;

    //    public RibbonViewModel()
    //    {
    //        Message = "Hello World";
    //        _pressCount = 0;
    //    }

    //    public string Message
    //    {
    //        get { return _message; }
    //        set
    //        {
    //            _message = value;
    //            NotifyOfPropertyChange(() => Message);
    //            NotifyOfPropertyChange(() => CanChangeMessage);
    //        }
    //    }

    //    public bool CanChangeMessage
    //    {
    //        get { return _pressCount < 10; }
    //    }

    //    private int _pressCount;


    //    public void ChangeMessage()
    //    {
    //        _pressCount++;

    //        Message = "Presses = " + _pressCount;
    //    }

    //    ///
    //    /// Indicates whether or not the Note can be displayed.
    //    ///
    //    public bool CanDisplayNote
    //    {
    //        get { return _canDisplayNote; }
    //        set
    //        {
    //            _canDisplayNote = value;
    //            NotifyOfPropertyChange(() => CanDisplayNote);
    //        }
    //    }

    //    ///
    //    /// The Journal's Note.
    //    ///
    //    public string Note
    //    {
    //        get { return _note; }
    //        set
    //        {
    //            _note = value;
    //            NotifyOfPropertyChange(() => Note);
    //        }
    //    }

    //    ///
    //    /// The note to display.
    //    ///
    //    public string NoteDisplay
    //    {
    //        get { return _noteDisplay; }
    //        set
    //        {
    //            _noteDisplay = value;
    //            NotifyOfPropertyChange(() => NoteDisplay);
    //        }
    //    }
    //    ViewType _currentType = ViewType.Map;
    //    public void ChangeView()
    //    {
    //        switch (_currentType)
    //        {
    //            case ViewType.Map:
    //                _currentType = ViewType.MapVideo;
    //                break;
    //            case ViewType.MapVideo:
    //                _currentType = ViewType.Video;
    //                break;
    //            case ViewType.Video:
    //                _currentType = ViewType.Map;
    //                break;
    //        }
            
    //        OnViewChanged(_currentType);
    //    }

    //    private bool CanChangeView()
    //    {
    //        return true;
    //    }

    //    public event EventHandler<ViewType> ViewChanged;

    //    ///
    //    /// Displays the note.
    //    ///
    //    public void DisplayNote()
    //    {
    //        NoteDisplay = Note;
    //    }


    //    protected virtual void OnViewChanged(ViewType e)
    //    {
    //        ViewChanged?.Invoke(this, e);
    //    }
    //}
}
