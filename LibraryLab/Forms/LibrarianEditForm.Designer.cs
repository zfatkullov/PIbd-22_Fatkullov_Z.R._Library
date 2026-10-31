#nullable disable

namespace LibraryLab.Forms;

partial class LibrarianEditForm
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
        FullNameTextBoxLabel = new Label();
        FullNameTextBox = new TextBox();
        AllowedSubjectsLabel = new Label();
        AllowedSubjectsList = new CheckedListBox();
        SaveButton = new Button();
        CancelRecordButton = new Button();
        SuspendLayout();

        FullNameTextBoxLabel.Name = "FullNameTextBoxLabel";
        FullNameTextBoxLabel.TabIndex = 0;
        FullNameTextBoxLabel.Location = new Point(16, 23);
        FullNameTextBoxLabel.Size = new Size(190, 26);
        FullNameTextBoxLabel.Text = "ФИО";

        FullNameTextBox.Name = "FullNameTextBox";
        FullNameTextBox.TabIndex = 1;
        FullNameTextBox.Location = new Point(212, 20);
        FullNameTextBox.Size = new Size(492, 30);
        FullNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

        AllowedSubjectsLabel.Name = "AllowedSubjectsLabel";
        AllowedSubjectsLabel.TabIndex = 2;
        AllowedSubjectsLabel.Location = new Point(16, 74);
        AllowedSubjectsLabel.Size = new Size(190, 26);
        AllowedSubjectsLabel.Text = "Разрешенные тематики";

        AllowedSubjectsList.Name = "AllowedSubjectsList";
        AllowedSubjectsList.TabIndex = 3;
        AllowedSubjectsList.Location = new Point(212, 70);
        AllowedSubjectsList.Size = new Size(492, 150);
        AllowedSubjectsList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        AllowedSubjectsList.CheckOnClick = true;
        AllowedSubjectsList.FormattingEnabled = true;

        SaveButton.Name = "SaveButton";
        SaveButton.TabIndex = 4;
        SaveButton.Location = new Point(12, 272);
        SaveButton.Size = new Size(140, 34);
        SaveButton.Text = "Сохранить";
        SaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        SaveButton.UseVisualStyleBackColor = true;
        SaveButton.Click += SaveButton_Click;

        CancelRecordButton.Name = "CancelRecordButton";
        CancelRecordButton.TabIndex = 5;
        CancelRecordButton.Location = new Point(162, 272);
        CancelRecordButton.Size = new Size(140, 34);
        CancelRecordButton.Text = "Отмена";
        CancelRecordButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        CancelRecordButton.DialogResult = DialogResult.Cancel;
        CancelRecordButton.UseVisualStyleBackColor = true;

        AllowedSubjectsList.Items.AddRange(new object[] { "Художественная литература", "Наука", "История", "Техника" });

        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        ClientSize = new Size(720, 320);
        Font = new Font("Segoe UI", 10F);
        MinimumSize = new Size(720, 320);
        Name = "LibrarianEditForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Добавление библиотекаря";
        AcceptButton = SaveButton;
        CancelButton = CancelRecordButton;
        Controls.Add(FullNameTextBoxLabel);
        Controls.Add(FullNameTextBox);
        Controls.Add(AllowedSubjectsLabel);
        Controls.Add(AllowedSubjectsList);
        Controls.Add(SaveButton);
        Controls.Add(CancelRecordButton);
        ResumeLayout(false);
        PerformLayout();
    }

    private Label FullNameTextBoxLabel;
    private TextBox FullNameTextBox;
    private Label AllowedSubjectsLabel;
    private CheckedListBox AllowedSubjectsList;
    private Button SaveButton;
    private Button CancelRecordButton;
}
