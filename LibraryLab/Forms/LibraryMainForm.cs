using Unity;

namespace LibraryLab.Forms;

public partial class LibraryMainForm : Form
{
    private readonly IUnityContainer _container = null!;

    public LibraryMainForm()
    {
        InitializeComponent();
    }

    [InjectionConstructor]
    public LibraryMainForm(IUnityContainer container) : this()
    {
        _container = container ?? throw new ArgumentNullException(nameof(container));
    }

    private void OpenForm<T>() where T : Form
    {
        FormControls.Try(() =>
        {
            using var form = _container.Resolve<T>();
            form.ShowDialog(this);
        });
    }

    private void ReadersMenuItem_Click(object? sender, EventArgs e)
    {
        OpenForm<ReaderListForm>();
    }

    private void LibrariansMenuItem_Click(object? sender, EventArgs e)
    {
        OpenForm<LibrarianListForm>();
    }

    private void PublicationsMenuItem_Click(object? sender, EventArgs e)
    {
        OpenForm<PublicationListForm>();
    }

    private void LoansMenuItem_Click(object? sender, EventArgs e)
    {
        OpenForm<LoanListForm>();
    }

    private void ReturnsMenuItem_Click(object? sender, EventArgs e)
    {
        OpenForm<ReturnListForm>();
    }
}
