#nullable disable

namespace LibraryLab.Forms;

partial class LibraryMainForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        LibraryMenu = new MenuStrip();
        LibraryHelpLabel = new Label();
        CatalogsMenuItem = new ToolStripMenuItem();
        ReadersMenuItem = new ToolStripMenuItem();
        LibrariansMenuItem = new ToolStripMenuItem();
        PublicationsMenuItem = new ToolStripMenuItem();
        OperationsMenuItem = new ToolStripMenuItem();
        LoansMenuItem = new ToolStripMenuItem();
        ReturnsMenuItem = new ToolStripMenuItem();
        ReportsMenuItem = new ToolStripMenuItem();
        SuspendLayout();

        LibraryMenu.Name = "LibraryMenu";
        LibraryMenu.TabIndex = 0;
        LibraryMenu.Location = new Point(0, 0);
        LibraryMenu.Size = new Size(900, 28);
        LibraryMenu.Dock = DockStyle.Top;

        LibraryHelpLabel.Name = "LibraryHelpLabel";
        LibraryHelpLabel.TabIndex = 1;
        LibraryHelpLabel.Location = new Point(24, 80);
        LibraryHelpLabel.Size = new Size(852, 340);
        LibraryHelpLabel.Text = "Учет выдачи книг и журналов в библиотеке";
        LibraryHelpLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        LibraryHelpLabel.TextAlign = ContentAlignment.MiddleCenter;

        CatalogsMenuItem.Name = "CatalogsMenuItem";
        CatalogsMenuItem.Text = "Справочники";

        ReadersMenuItem.Name = "ReadersMenuItem";
        ReadersMenuItem.Text = "Читатели";
        ReadersMenuItem.Click += ReadersMenuItem_Click;

        LibrariansMenuItem.Name = "LibrariansMenuItem";
        LibrariansMenuItem.Text = "Библиотекари";
        LibrariansMenuItem.Click += LibrariansMenuItem_Click;

        PublicationsMenuItem.Name = "PublicationsMenuItem";
        PublicationsMenuItem.Text = "Литературные источники";
        PublicationsMenuItem.Click += PublicationsMenuItem_Click;

        OperationsMenuItem.Name = "OperationsMenuItem";
        OperationsMenuItem.Text = "Операции";

        LoansMenuItem.Name = "LoansMenuItem";
        LoansMenuItem.Text = "Выдачи";
        LoansMenuItem.Click += LoansMenuItem_Click;

        ReturnsMenuItem.Name = "ReturnsMenuItem";
        ReturnsMenuItem.Text = "Возвраты";
        ReturnsMenuItem.Click += ReturnsMenuItem_Click;

        ReportsMenuItem.Name = "ReportsMenuItem";
        ReportsMenuItem.Text = "Отчеты";

        LibraryMenu.Items.AddRange(new ToolStripItem[] { CatalogsMenuItem, OperationsMenuItem, ReportsMenuItem });
        CatalogsMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ReadersMenuItem, LibrariansMenuItem, PublicationsMenuItem });
        OperationsMenuItem.DropDownItems.AddRange(new ToolStripItem[] { LoansMenuItem, ReturnsMenuItem });
        MainMenuStrip = LibraryMenu;

        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        ClientSize = new Size(900, 560);
        Font = new Font("Segoe UI", 10F);
        MinimumSize = new Size(900, 560);
        Name = "LibraryMainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Учет выдачи книг и журналов";
        Controls.Add(LibraryMenu);
        Controls.Add(LibraryHelpLabel);
        ResumeLayout(false);
        PerformLayout();
    }

    private MenuStrip LibraryMenu;
    private Label LibraryHelpLabel;
    private ToolStripMenuItem CatalogsMenuItem;
    private ToolStripMenuItem ReadersMenuItem;
    private ToolStripMenuItem LibrariansMenuItem;
    private ToolStripMenuItem PublicationsMenuItem;
    private ToolStripMenuItem OperationsMenuItem;
    private ToolStripMenuItem LoansMenuItem;
    private ToolStripMenuItem ReturnsMenuItem;
    private ToolStripMenuItem ReportsMenuItem;
}
