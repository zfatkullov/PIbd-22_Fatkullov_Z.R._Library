using LibraryLab.Forms;
using LibraryLab.Repositories;
using LibraryLab.Interfaces;
using Unity;

namespace LibraryLab;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        using var container = CreateContainer();
        Application.Run(container.Resolve<LibraryMainForm>());
    }

    public static IUnityContainer CreateContainer()
    {
        var container = new UnityContainer();
        container.RegisterInstance<IUnityContainer>(container);
        container.RegisterType<IReaderRepository, ReaderRepository>();
        container.RegisterType<ILibrarianRepository, LibrarianRepository>();
        container.RegisterType<IPublicationRepository, PublicationRepository>();
        container.RegisterType<ILoanRepository, LoanRepository>();
        container.RegisterType<ILoanItemRepository, LoanItemRepository>();
        container.RegisterType<IReturnRecordRepository, ReturnRecordRepository>();
        return container;
    }
}
