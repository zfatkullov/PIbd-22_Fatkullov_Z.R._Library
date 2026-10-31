#nullable disable

namespace LibraryLab.Forms;

partial class ReturnListForm
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
        ReturnsGrid = new DataGridView();
        ReturnsGridIdColumn = new DataGridViewTextBoxColumn();
        ReturnsGridReaderColumn = new DataGridViewTextBoxColumn();
        ReturnsGridPublicationColumn = new DataGridViewTextBoxColumn();
        ReturnsGridInventoryNumberColumn = new DataGridViewTextBoxColumn();
        ReturnsGridReturnedOnColumn = new DataGridViewTextBoxColumn();
        AddReturnButton = new Button();
        ((System.ComponentModel.ISupportInitialize)ReturnsGrid).BeginInit();
        SuspendLayout();

        ReturnsGrid.Name = "ReturnsGrid";
        ReturnsGrid.TabIndex = 0;
        ReturnsGrid.Location = new Point(12, 12);
        ReturnsGrid.Size = new Size(876, 396);
        ReturnsGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        ReturnsGrid.AllowUserToAddRows = false;
        ReturnsGrid.AllowUserToDeleteRows = false;
        ReturnsGrid.AllowUserToResizeRows = false;
        ReturnsGrid.AutoGenerateColumns = false;
        ReturnsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        ReturnsGrid.MultiSelect = false;
        ReturnsGrid.ReadOnly = true;
        ReturnsGrid.RowHeadersVisible = false;
        ReturnsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        ReturnsGrid.Columns.AddRange(new DataGridViewColumn[] { ReturnsGridIdColumn, ReturnsGridReaderColumn, ReturnsGridPublicationColumn, ReturnsGridInventoryNumberColumn, ReturnsGridReturnedOnColumn });
        ReturnsGridIdColumn.Name = "IdColumn";
        ReturnsGridIdColumn.HeaderText = "";
        ReturnsGridIdColumn.Visible = false;
        ReturnsGridIdColumn.ReadOnly = true;
        ReturnsGridReaderColumn.Name = "ReaderColumn";
        ReturnsGridReaderColumn.HeaderText = "Читатель";
        ReturnsGridReaderColumn.ReadOnly = true;
        ReturnsGridPublicationColumn.Name = "PublicationColumn";
        ReturnsGridPublicationColumn.HeaderText = "Источник";
        ReturnsGridPublicationColumn.ReadOnly = true;
        ReturnsGridInventoryNumberColumn.Name = "InventoryNumberColumn";
        ReturnsGridInventoryNumberColumn.HeaderText = "Инвентарный номер";
        ReturnsGridInventoryNumberColumn.ReadOnly = true;
        ReturnsGridReturnedOnColumn.Name = "ReturnedOnColumn";
        ReturnsGridReturnedOnColumn.HeaderText = "Дата возврата";
        ReturnsGridReturnedOnColumn.ReadOnly = true;

        AddReturnButton.Name = "AddReturnButton";
        AddReturnButton.TabIndex = 1;
        AddReturnButton.Location = new Point(12, 426);
        AddReturnButton.Size = new Size(140, 34);
        AddReturnButton.Text = "Добавить";
        AddReturnButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        AddReturnButton.UseVisualStyleBackColor = true;
        AddReturnButton.Click += AddReturnButton_Click;

        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        ClientSize = new Size(900, 480);
        Font = new Font("Segoe UI", 10F);
        MinimumSize = new Size(900, 480);
        Name = "ReturnListForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Возвраты";
        Controls.Add(ReturnsGrid);
        Controls.Add(AddReturnButton);
        Shown += ReturnListForm_Shown;
        ((System.ComponentModel.ISupportInitialize)ReturnsGrid).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private DataGridView ReturnsGrid;
    private DataGridViewTextBoxColumn ReturnsGridIdColumn;
    private DataGridViewTextBoxColumn ReturnsGridReaderColumn;
    private DataGridViewTextBoxColumn ReturnsGridPublicationColumn;
    private DataGridViewTextBoxColumn ReturnsGridInventoryNumberColumn;
    private DataGridViewTextBoxColumn ReturnsGridReturnedOnColumn;
    private Button AddReturnButton;
}
