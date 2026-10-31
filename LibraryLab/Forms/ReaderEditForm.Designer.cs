#nullable disable

namespace LibraryLab.Forms;

partial class ReaderEditForm
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
        CardNumberTextBoxLabel = new Label();
        CardNumberTextBox = new TextBox();
        CardExpiresOnPickerLabel = new Label();
        CardExpiresOnPicker = new DateTimePicker();
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
        FullNameTextBox.Size = new Size(452, 30);
        FullNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

        CardNumberTextBoxLabel.Name = "CardNumberTextBoxLabel";
        CardNumberTextBoxLabel.TabIndex = 2;
        CardNumberTextBoxLabel.Location = new Point(16, 71);
        CardNumberTextBoxLabel.Size = new Size(190, 26);
        CardNumberTextBoxLabel.Text = "Номер билета";

        CardNumberTextBox.Name = "CardNumberTextBox";
        CardNumberTextBox.TabIndex = 3;
        CardNumberTextBox.Location = new Point(212, 68);
        CardNumberTextBox.Size = new Size(452, 30);
        CardNumberTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

        CardExpiresOnPickerLabel.Name = "CardExpiresOnPickerLabel";
        CardExpiresOnPickerLabel.TabIndex = 4;
        CardExpiresOnPickerLabel.Location = new Point(16, 119);
        CardExpiresOnPickerLabel.Size = new Size(190, 26);
        CardExpiresOnPickerLabel.Text = "Билет действителен до";

        CardExpiresOnPicker.Name = "CardExpiresOnPicker";
        CardExpiresOnPicker.TabIndex = 5;
        CardExpiresOnPicker.Location = new Point(212, 116);
        CardExpiresOnPicker.Size = new Size(452, 30);
        CardExpiresOnPicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        CardExpiresOnPicker.Format = DateTimePickerFormat.Short;

        SaveButton.Name = "SaveButton";
        SaveButton.TabIndex = 6;
        SaveButton.Location = new Point(12, 232);
        SaveButton.Size = new Size(140, 34);
        SaveButton.Text = "Сохранить";
        SaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        SaveButton.UseVisualStyleBackColor = true;
        SaveButton.Click += SaveButton_Click;

        CancelRecordButton.Name = "CancelRecordButton";
        CancelRecordButton.TabIndex = 7;
        CancelRecordButton.Location = new Point(162, 232);
        CancelRecordButton.Size = new Size(140, 34);
        CancelRecordButton.Text = "Отмена";
        CancelRecordButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        CancelRecordButton.DialogResult = DialogResult.Cancel;
        CancelRecordButton.UseVisualStyleBackColor = true;

        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        ClientSize = new Size(680, 280);
        Font = new Font("Segoe UI", 10F);
        MinimumSize = new Size(680, 280);
        Name = "ReaderEditForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Добавление читателя";
        AcceptButton = SaveButton;
        CancelButton = CancelRecordButton;
        Controls.Add(FullNameTextBoxLabel);
        Controls.Add(FullNameTextBox);
        Controls.Add(CardNumberTextBoxLabel);
        Controls.Add(CardNumberTextBox);
        Controls.Add(CardExpiresOnPickerLabel);
        Controls.Add(CardExpiresOnPicker);
        Controls.Add(SaveButton);
        Controls.Add(CancelRecordButton);
        ResumeLayout(false);
        PerformLayout();
    }

    private Label FullNameTextBoxLabel;
    private TextBox FullNameTextBox;
    private Label CardNumberTextBoxLabel;
    private TextBox CardNumberTextBox;
    private Label CardExpiresOnPickerLabel;
    private DateTimePicker CardExpiresOnPicker;
    private Button SaveButton;
    private Button CancelRecordButton;
}
