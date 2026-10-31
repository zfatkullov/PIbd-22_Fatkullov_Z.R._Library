#nullable disable

namespace LibraryLab.Forms;

partial class LoanListForm
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
        AddLoanButton = new Button();
        OverdueOnlyCheckBox = new CheckBox();
        LoansGrid = new DataGridView();
        LoansGridIdColumn = new DataGridViewTextBoxColumn();
        LoansGridReaderColumn = new DataGridViewTextBoxColumn();
        LoansGridLibrarianColumn = new DataGridViewTextBoxColumn();
        LoansGridIssuedOnColumn = new DataGridViewTextBoxColumn();
        LoansGridDueOnColumn = new DataGridViewTextBoxColumn();
        LoansGridStateColumn = new DataGridViewTextBoxColumn();
        LoanItemsLabel = new Label();
        LoanItemsGrid = new DataGridView();
        LoanItemsGridIdColumn = new DataGridViewTextBoxColumn();
        LoanItemsGridPublicationColumn = new DataGridViewTextBoxColumn();
        LoanItemsGridInventoryNumberColumn = new DataGridViewTextBoxColumn();
        LoanItemsGridStateColumn = new DataGridViewTextBoxColumn();
        LoanItemsGridReturnedOnColumn = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)LoansGrid).BeginInit();
        ((System.ComponentModel.ISupportInitialize)LoanItemsGrid).BeginInit();
        SuspendLayout();

        AddLoanButton.Name = "AddLoanButton";
        AddLoanButton.TabIndex = 0;
        AddLoanButton.Location = new Point(12, 12);
        AddLoanButton.Size = new Size(130, 34);
        AddLoanButton.Text = "Добавить";
        AddLoanButton.UseVisualStyleBackColor = true;
        AddLoanButton.Click += AddLoanButton_Click;

        OverdueOnlyCheckBox.Name = "OverdueOnlyCheckBox";
        OverdueOnlyCheckBox.TabIndex = 1;
        OverdueOnlyCheckBox.Location = new Point(160, 17);
        OverdueOnlyCheckBox.Size = new Size(780, 26);
        OverdueOnlyCheckBox.Text = "Только просроченные выдачи (должники)";
        OverdueOnlyCheckBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        OverdueOnlyCheckBox.UseVisualStyleBackColor = true;
        OverdueOnlyCheckBox.CheckedChanged += OverdueOnlyCheckBox_CheckedChanged;

        LoansGrid.Name = "LoansGrid";
        LoansGrid.TabIndex = 2;
        LoansGrid.Location = new Point(12, 60);
        LoansGrid.Size = new Size(976, 260);
        LoansGrid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        LoansGrid.AllowUserToAddRows = false;
        LoansGrid.AllowUserToDeleteRows = false;
        LoansGrid.AllowUserToResizeRows = false;
        LoansGrid.AutoGenerateColumns = false;
        LoansGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        LoansGrid.MultiSelect = false;
        LoansGrid.ReadOnly = true;
        LoansGrid.RowHeadersVisible = false;
        LoansGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        LoansGrid.SelectionChanged += LoansGrid_SelectionChanged;
        LoansGrid.Columns.AddRange(new DataGridViewColumn[] { LoansGridIdColumn, LoansGridReaderColumn, LoansGridLibrarianColumn, LoansGridIssuedOnColumn, LoansGridDueOnColumn, LoansGridStateColumn });
        LoansGridIdColumn.Name = "IdColumn";
        LoansGridIdColumn.HeaderText = "";
        LoansGridIdColumn.Visible = false;
        LoansGridIdColumn.ReadOnly = true;
        LoansGridReaderColumn.Name = "ReaderColumn";
        LoansGridReaderColumn.HeaderText = "Читатель";
        LoansGridReaderColumn.ReadOnly = true;
        LoansGridLibrarianColumn.Name = "LibrarianColumn";
        LoansGridLibrarianColumn.HeaderText = "Библиотекарь";
        LoansGridLibrarianColumn.ReadOnly = true;
        LoansGridIssuedOnColumn.Name = "IssuedOnColumn";
        LoansGridIssuedOnColumn.HeaderText = "Дата выдачи";
        LoansGridIssuedOnColumn.ReadOnly = true;
        LoansGridDueOnColumn.Name = "DueOnColumn";
        LoansGridDueOnColumn.HeaderText = "Вернуть до";
        LoansGridDueOnColumn.ReadOnly = true;
        LoansGridStateColumn.Name = "StateColumn";
        LoansGridStateColumn.HeaderText = "Состояние";
        LoansGridStateColumn.ReadOnly = true;

        LoanItemsLabel.Name = "LoanItemsLabel";
        LoanItemsLabel.TabIndex = 3;
        LoanItemsLabel.Location = new Point(12, 332);
        LoanItemsLabel.Size = new Size(976, 24);
        LoanItemsLabel.Text = "Источники выбранной выдачи";
        LoanItemsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

        LoanItemsGrid.Name = "LoanItemsGrid";
        LoanItemsGrid.TabIndex = 4;
        LoanItemsGrid.Location = new Point(12, 366);
        LoanItemsGrid.Size = new Size(976, 262);
        LoanItemsGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        LoanItemsGrid.AllowUserToAddRows = false;
        LoanItemsGrid.AllowUserToDeleteRows = false;
        LoanItemsGrid.AllowUserToResizeRows = false;
        LoanItemsGrid.AutoGenerateColumns = false;
        LoanItemsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        LoanItemsGrid.MultiSelect = false;
        LoanItemsGrid.ReadOnly = true;
        LoanItemsGrid.RowHeadersVisible = false;
        LoanItemsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        LoanItemsGrid.Columns.AddRange(new DataGridViewColumn[] { LoanItemsGridIdColumn, LoanItemsGridPublicationColumn, LoanItemsGridInventoryNumberColumn, LoanItemsGridStateColumn, LoanItemsGridReturnedOnColumn });
        LoanItemsGridIdColumn.Name = "IdColumn";
        LoanItemsGridIdColumn.HeaderText = "";
        LoanItemsGridIdColumn.Visible = false;
        LoanItemsGridIdColumn.ReadOnly = true;
        LoanItemsGridPublicationColumn.Name = "PublicationColumn";
        LoanItemsGridPublicationColumn.HeaderText = "Источник";
        LoanItemsGridPublicationColumn.ReadOnly = true;
        LoanItemsGridInventoryNumberColumn.Name = "InventoryNumberColumn";
        LoanItemsGridInventoryNumberColumn.HeaderText = "Инвентарный номер";
        LoanItemsGridInventoryNumberColumn.ReadOnly = true;
        LoanItemsGridStateColumn.Name = "StateColumn";
        LoanItemsGridStateColumn.HeaderText = "Состояние";
        LoanItemsGridStateColumn.ReadOnly = true;
        LoanItemsGridReturnedOnColumn.Name = "ReturnedOnColumn";
        LoanItemsGridReturnedOnColumn.HeaderText = "Дата возврата";
        LoanItemsGridReturnedOnColumn.ReadOnly = true;

        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        ClientSize = new Size(1000, 640);
        Font = new Font("Segoe UI", 10F);
        MinimumSize = new Size(1000, 640);
        Name = "LoanListForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Выдачи";
        Controls.Add(AddLoanButton);
        Controls.Add(OverdueOnlyCheckBox);
        Controls.Add(LoansGrid);
        Controls.Add(LoanItemsLabel);
        Controls.Add(LoanItemsGrid);
        Shown += LoanListForm_Shown;
        ((System.ComponentModel.ISupportInitialize)LoansGrid).EndInit();
        ((System.ComponentModel.ISupportInitialize)LoanItemsGrid).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Button AddLoanButton;
    private CheckBox OverdueOnlyCheckBox;
    private DataGridView LoansGrid;
    private DataGridViewTextBoxColumn LoansGridIdColumn;
    private DataGridViewTextBoxColumn LoansGridReaderColumn;
    private DataGridViewTextBoxColumn LoansGridLibrarianColumn;
    private DataGridViewTextBoxColumn LoansGridIssuedOnColumn;
    private DataGridViewTextBoxColumn LoansGridDueOnColumn;
    private DataGridViewTextBoxColumn LoansGridStateColumn;
    private Label LoanItemsLabel;
    private DataGridView LoanItemsGrid;
    private DataGridViewTextBoxColumn LoanItemsGridIdColumn;
    private DataGridViewTextBoxColumn LoanItemsGridPublicationColumn;
    private DataGridViewTextBoxColumn LoanItemsGridInventoryNumberColumn;
    private DataGridViewTextBoxColumn LoanItemsGridStateColumn;
    private DataGridViewTextBoxColumn LoanItemsGridReturnedOnColumn;
}
