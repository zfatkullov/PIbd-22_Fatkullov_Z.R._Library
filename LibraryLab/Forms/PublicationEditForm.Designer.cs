#nullable disable

namespace LibraryLab.Forms;

partial class PublicationEditForm
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
        PublicationTitleTextBoxLabel = new Label();
        PublicationTitleTextBox = new TextBox();
        InventoryNumberTextBoxLabel = new Label();
        InventoryNumberTextBox = new TextBox();
        PublicationKindComboLabel = new Label();
        PublicationKindCombo = new ComboBox();
        PublicationSubjectComboLabel = new Label();
        PublicationSubjectCombo = new ComboBox();
        SaveButton = new Button();
        CancelRecordButton = new Button();
        SuspendLayout();

        PublicationTitleTextBoxLabel.Name = "PublicationTitleTextBoxLabel";
        PublicationTitleTextBoxLabel.TabIndex = 0;
        PublicationTitleTextBoxLabel.Location = new Point(16, 23);
        PublicationTitleTextBoxLabel.Size = new Size(190, 26);
        PublicationTitleTextBoxLabel.Text = "Название";

        PublicationTitleTextBox.Name = "PublicationTitleTextBox";
        PublicationTitleTextBox.TabIndex = 1;
        PublicationTitleTextBox.Location = new Point(212, 20);
        PublicationTitleTextBox.Size = new Size(492, 30);
        PublicationTitleTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

        InventoryNumberTextBoxLabel.Name = "InventoryNumberTextBoxLabel";
        InventoryNumberTextBoxLabel.TabIndex = 2;
        InventoryNumberTextBoxLabel.Location = new Point(16, 71);
        InventoryNumberTextBoxLabel.Size = new Size(190, 26);
        InventoryNumberTextBoxLabel.Text = "Инвентарный номер";

        InventoryNumberTextBox.Name = "InventoryNumberTextBox";
        InventoryNumberTextBox.TabIndex = 3;
        InventoryNumberTextBox.Location = new Point(212, 68);
        InventoryNumberTextBox.Size = new Size(492, 30);
        InventoryNumberTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

        PublicationKindComboLabel.Name = "PublicationKindComboLabel";
        PublicationKindComboLabel.TabIndex = 4;
        PublicationKindComboLabel.Location = new Point(16, 119);
        PublicationKindComboLabel.Size = new Size(190, 26);
        PublicationKindComboLabel.Text = "Вид";

        PublicationKindCombo.Name = "PublicationKindCombo";
        PublicationKindCombo.TabIndex = 5;
        PublicationKindCombo.Location = new Point(212, 116);
        PublicationKindCombo.Size = new Size(492, 30);
        PublicationKindCombo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        PublicationKindCombo.DropDownStyle = ComboBoxStyle.DropDownList;
        PublicationKindCombo.FormattingEnabled = true;

        PublicationSubjectComboLabel.Name = "PublicationSubjectComboLabel";
        PublicationSubjectComboLabel.TabIndex = 6;
        PublicationSubjectComboLabel.Location = new Point(16, 167);
        PublicationSubjectComboLabel.Size = new Size(190, 26);
        PublicationSubjectComboLabel.Text = "Тематика";

        PublicationSubjectCombo.Name = "PublicationSubjectCombo";
        PublicationSubjectCombo.TabIndex = 7;
        PublicationSubjectCombo.Location = new Point(212, 164);
        PublicationSubjectCombo.Size = new Size(492, 30);
        PublicationSubjectCombo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        PublicationSubjectCombo.DropDownStyle = ComboBoxStyle.DropDownList;
        PublicationSubjectCombo.FormattingEnabled = true;

        SaveButton.Name = "SaveButton";
        SaveButton.TabIndex = 8;
        SaveButton.Location = new Point(12, 272);
        SaveButton.Size = new Size(140, 34);
        SaveButton.Text = "Сохранить";
        SaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        SaveButton.UseVisualStyleBackColor = true;
        SaveButton.Click += SaveButton_Click;

        CancelRecordButton.Name = "CancelRecordButton";
        CancelRecordButton.TabIndex = 9;
        CancelRecordButton.Location = new Point(162, 272);
        CancelRecordButton.Size = new Size(140, 34);
        CancelRecordButton.Text = "Отмена";
        CancelRecordButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        CancelRecordButton.DialogResult = DialogResult.Cancel;
        CancelRecordButton.UseVisualStyleBackColor = true;

        PublicationKindCombo.Items.AddRange(new object[] { "Книга", "Журнал" });
        PublicationSubjectCombo.Items.AddRange(new object[] { "Художественная литература", "Наука", "История", "Техника" });

        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        ClientSize = new Size(720, 320);
        Font = new Font("Segoe UI", 10F);
        MinimumSize = new Size(720, 320);
        Name = "PublicationEditForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Добавление источника";
        AcceptButton = SaveButton;
        CancelButton = CancelRecordButton;
        Controls.Add(PublicationTitleTextBoxLabel);
        Controls.Add(PublicationTitleTextBox);
        Controls.Add(InventoryNumberTextBoxLabel);
        Controls.Add(InventoryNumberTextBox);
        Controls.Add(PublicationKindComboLabel);
        Controls.Add(PublicationKindCombo);
        Controls.Add(PublicationSubjectComboLabel);
        Controls.Add(PublicationSubjectCombo);
        Controls.Add(SaveButton);
        Controls.Add(CancelRecordButton);
        ResumeLayout(false);
        PerformLayout();
    }

    private Label PublicationTitleTextBoxLabel;
    private TextBox PublicationTitleTextBox;
    private Label InventoryNumberTextBoxLabel;
    private TextBox InventoryNumberTextBox;
    private Label PublicationKindComboLabel;
    private ComboBox PublicationKindCombo;
    private Label PublicationSubjectComboLabel;
    private ComboBox PublicationSubjectCombo;
    private Button SaveButton;
    private Button CancelRecordButton;
}
