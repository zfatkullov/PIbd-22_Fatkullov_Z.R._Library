#nullable disable

namespace LibraryLab.Forms;

partial class ReturnCreateForm
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
        OutstandingLoanItemComboLabel = new Label();
        OutstandingLoanItemCombo = new ComboBox();
        SaveButton = new Button();
        CancelRecordButton = new Button();
        SuspendLayout();

        OutstandingLoanItemComboLabel.Name = "OutstandingLoanItemComboLabel";
        OutstandingLoanItemComboLabel.TabIndex = 0;
        OutstandingLoanItemComboLabel.Location = new Point(16, 23);
        OutstandingLoanItemComboLabel.Size = new Size(190, 26);
        OutstandingLoanItemComboLabel.Text = "Возвращаемый источник";

        OutstandingLoanItemCombo.Name = "OutstandingLoanItemCombo";
        OutstandingLoanItemCombo.TabIndex = 1;
        OutstandingLoanItemCombo.Location = new Point(212, 20);
        OutstandingLoanItemCombo.Size = new Size(772, 30);
        OutstandingLoanItemCombo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        OutstandingLoanItemCombo.DropDownStyle = ComboBoxStyle.DropDownList;
        OutstandingLoanItemCombo.FormattingEnabled = true;

        SaveButton.Name = "SaveButton";
        SaveButton.TabIndex = 2;
        SaveButton.Location = new Point(12, 192);
        SaveButton.Size = new Size(140, 34);
        SaveButton.Text = "Сохранить";
        SaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        SaveButton.UseVisualStyleBackColor = true;
        SaveButton.Click += SaveButton_Click;

        CancelRecordButton.Name = "CancelRecordButton";
        CancelRecordButton.TabIndex = 3;
        CancelRecordButton.Location = new Point(162, 192);
        CancelRecordButton.Size = new Size(140, 34);
        CancelRecordButton.Text = "Отмена";
        CancelRecordButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        CancelRecordButton.DialogResult = DialogResult.Cancel;
        CancelRecordButton.UseVisualStyleBackColor = true;

        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        ClientSize = new Size(1000, 240);
        Font = new Font("Segoe UI", 10F);
        MinimumSize = new Size(1000, 240);
        Name = "ReturnCreateForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Добавление возврата";
        AcceptButton = SaveButton;
        CancelButton = CancelRecordButton;
        Controls.Add(OutstandingLoanItemComboLabel);
        Controls.Add(OutstandingLoanItemCombo);
        Controls.Add(SaveButton);
        Controls.Add(CancelRecordButton);
        ResumeLayout(false);
        PerformLayout();
    }

    private Label OutstandingLoanItemComboLabel;
    private ComboBox OutstandingLoanItemCombo;
    private Button SaveButton;
    private Button CancelRecordButton;
}
