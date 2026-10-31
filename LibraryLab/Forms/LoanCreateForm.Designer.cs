#nullable disable

namespace LibraryLab.Forms;

partial class LoanCreateForm
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
        ReaderComboLabel = new Label();
        ReaderCombo = new ComboBox();
        LibrarianComboLabel = new Label();
        LibrarianCombo = new ComboBox();
        DueOnPickerLabel = new Label();
        DueOnPicker = new DateTimePicker();
        AvailablePublicationsLabel = new Label();
        PublicationsSelectionGrid = new DataGridView();
        PublicationsSelectionGridIdColumn = new DataGridViewTextBoxColumn();
        PublicationsSelectionGridSelectedColumn = new DataGridViewCheckBoxColumn();
        PublicationsSelectionGridTitleColumn = new DataGridViewTextBoxColumn();
        PublicationsSelectionGridKindColumn = new DataGridViewTextBoxColumn();
        PublicationsSelectionGridSubjectColumn = new DataGridViewTextBoxColumn();
        PublicationsSelectionGridInventoryNumberColumn = new DataGridViewTextBoxColumn();
        SaveButton = new Button();
        CancelRecordButton = new Button();
        ((System.ComponentModel.ISupportInitialize)PublicationsSelectionGrid).BeginInit();
        SuspendLayout();

        ReaderComboLabel.Name = "ReaderComboLabel";
        ReaderComboLabel.TabIndex = 0;
        ReaderComboLabel.Location = new Point(16, 23);
        ReaderComboLabel.Size = new Size(190, 26);
        ReaderComboLabel.Text = "Читатель";

        ReaderCombo.Name = "ReaderCombo";
        ReaderCombo.TabIndex = 1;
        ReaderCombo.Location = new Point(212, 20);
        ReaderCombo.Size = new Size(772, 30);
        ReaderCombo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        ReaderCombo.DropDownStyle = ComboBoxStyle.DropDownList;
        ReaderCombo.FormattingEnabled = true;

        LibrarianComboLabel.Name = "LibrarianComboLabel";
        LibrarianComboLabel.TabIndex = 2;
        LibrarianComboLabel.Location = new Point(16, 71);
        LibrarianComboLabel.Size = new Size(190, 26);
        LibrarianComboLabel.Text = "Библиотекарь";

        LibrarianCombo.Name = "LibrarianCombo";
        LibrarianCombo.TabIndex = 3;
        LibrarianCombo.Location = new Point(212, 68);
        LibrarianCombo.Size = new Size(772, 30);
        LibrarianCombo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        LibrarianCombo.DropDownStyle = ComboBoxStyle.DropDownList;
        LibrarianCombo.FormattingEnabled = true;

        DueOnPickerLabel.Name = "DueOnPickerLabel";
        DueOnPickerLabel.TabIndex = 4;
        DueOnPickerLabel.Location = new Point(16, 119);
        DueOnPickerLabel.Size = new Size(190, 26);
        DueOnPickerLabel.Text = "Вернуть до";

        DueOnPicker.Name = "DueOnPicker";
        DueOnPicker.TabIndex = 5;
        DueOnPicker.Location = new Point(212, 116);
        DueOnPicker.Size = new Size(772, 30);
        DueOnPicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        DueOnPicker.Format = DateTimePickerFormat.Short;

        AvailablePublicationsLabel.Name = "AvailablePublicationsLabel";
        AvailablePublicationsLabel.TabIndex = 6;
        AvailablePublicationsLabel.Location = new Point(16, 172);
        AvailablePublicationsLabel.Size = new Size(950, 24);
        AvailablePublicationsLabel.Text = "Доступные литературные источники";
        AvailablePublicationsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

        PublicationsSelectionGrid.Name = "PublicationsSelectionGrid";
        PublicationsSelectionGrid.TabIndex = 7;
        PublicationsSelectionGrid.Location = new Point(16, 206);
        PublicationsSelectionGrid.Size = new Size(968, 330);
        PublicationsSelectionGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        PublicationsSelectionGrid.AllowUserToAddRows = false;
        PublicationsSelectionGrid.AllowUserToDeleteRows = false;
        PublicationsSelectionGrid.AllowUserToResizeRows = false;
        PublicationsSelectionGrid.AutoGenerateColumns = false;
        PublicationsSelectionGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        PublicationsSelectionGrid.MultiSelect = false;
        PublicationsSelectionGrid.ReadOnly = false;
        PublicationsSelectionGrid.RowHeadersVisible = false;
        PublicationsSelectionGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        PublicationsSelectionGrid.Columns.AddRange(new DataGridViewColumn[] { PublicationsSelectionGridIdColumn, PublicationsSelectionGridSelectedColumn, PublicationsSelectionGridTitleColumn, PublicationsSelectionGridKindColumn, PublicationsSelectionGridSubjectColumn, PublicationsSelectionGridInventoryNumberColumn });
        PublicationsSelectionGridIdColumn.Name = "IdColumn";
        PublicationsSelectionGridIdColumn.HeaderText = "";
        PublicationsSelectionGridIdColumn.Visible = false;
        PublicationsSelectionGridIdColumn.ReadOnly = true;
        PublicationsSelectionGridSelectedColumn.Name = "SelectedColumn";
        PublicationsSelectionGridSelectedColumn.HeaderText = "Выдать";
        PublicationsSelectionGridSelectedColumn.FillWeight = 45F;
        PublicationsSelectionGridTitleColumn.Name = "TitleColumn";
        PublicationsSelectionGridTitleColumn.HeaderText = "Название";
        PublicationsSelectionGridTitleColumn.ReadOnly = true;
        PublicationsSelectionGridKindColumn.Name = "KindColumn";
        PublicationsSelectionGridKindColumn.HeaderText = "Вид";
        PublicationsSelectionGridKindColumn.ReadOnly = true;
        PublicationsSelectionGridSubjectColumn.Name = "SubjectColumn";
        PublicationsSelectionGridSubjectColumn.HeaderText = "Тематика";
        PublicationsSelectionGridSubjectColumn.ReadOnly = true;
        PublicationsSelectionGridInventoryNumberColumn.Name = "InventoryNumberColumn";
        PublicationsSelectionGridInventoryNumberColumn.HeaderText = "Инвентарный номер";
        PublicationsSelectionGridInventoryNumberColumn.ReadOnly = true;

        SaveButton.Name = "SaveButton";
        SaveButton.TabIndex = 8;
        SaveButton.Location = new Point(12, 552);
        SaveButton.Size = new Size(140, 34);
        SaveButton.Text = "Сохранить";
        SaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        SaveButton.UseVisualStyleBackColor = true;
        SaveButton.Click += SaveButton_Click;

        CancelRecordButton.Name = "CancelRecordButton";
        CancelRecordButton.TabIndex = 9;
        CancelRecordButton.Location = new Point(162, 552);
        CancelRecordButton.Size = new Size(140, 34);
        CancelRecordButton.Text = "Отмена";
        CancelRecordButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        CancelRecordButton.DialogResult = DialogResult.Cancel;
        CancelRecordButton.UseVisualStyleBackColor = true;

        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        ClientSize = new Size(1000, 600);
        Font = new Font("Segoe UI", 10F);
        MinimumSize = new Size(1000, 600);
        Name = "LoanCreateForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Добавление выдачи";
        AcceptButton = SaveButton;
        CancelButton = CancelRecordButton;
        Controls.Add(ReaderComboLabel);
        Controls.Add(ReaderCombo);
        Controls.Add(LibrarianComboLabel);
        Controls.Add(LibrarianCombo);
        Controls.Add(DueOnPickerLabel);
        Controls.Add(DueOnPicker);
        Controls.Add(AvailablePublicationsLabel);
        Controls.Add(PublicationsSelectionGrid);
        Controls.Add(SaveButton);
        Controls.Add(CancelRecordButton);
        ((System.ComponentModel.ISupportInitialize)PublicationsSelectionGrid).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label ReaderComboLabel;
    private ComboBox ReaderCombo;
    private Label LibrarianComboLabel;
    private ComboBox LibrarianCombo;
    private Label DueOnPickerLabel;
    private DateTimePicker DueOnPicker;
    private Label AvailablePublicationsLabel;
    private DataGridView PublicationsSelectionGrid;
    private DataGridViewTextBoxColumn PublicationsSelectionGridIdColumn;
    private DataGridViewCheckBoxColumn PublicationsSelectionGridSelectedColumn;
    private DataGridViewTextBoxColumn PublicationsSelectionGridTitleColumn;
    private DataGridViewTextBoxColumn PublicationsSelectionGridKindColumn;
    private DataGridViewTextBoxColumn PublicationsSelectionGridSubjectColumn;
    private DataGridViewTextBoxColumn PublicationsSelectionGridInventoryNumberColumn;
    private Button SaveButton;
    private Button CancelRecordButton;
}
