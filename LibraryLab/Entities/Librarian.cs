using LibraryLab.Entities.Enums;

namespace LibraryLab.Entities;

public sealed class Librarian : Entity
{
    public string FullName { get; private set; }
    public Subject AllowedSubjects { get; private set; }

    private Librarian(string fullName, Subject allowedSubjects, Guid? id) : base(id)
    {
        FullName = Validation.Required(fullName, "ФИО");
        AllowedSubjects = Validation.Subjects(allowedSubjects, false);
    }

    public static Librarian Create(string fullName, Subject allowedSubjects, Guid? id = null)
    {
        return new Librarian(fullName, allowedSubjects, id);
    }
}
