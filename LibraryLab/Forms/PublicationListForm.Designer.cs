#nullable disable

namespace LibraryLab.Forms;

partial class PublicationListForm
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
        RecordsGrid = new DataGridView();
        RecordsGridIdColumn = new DataGridViewTextBoxColumn();
        RecordsGridTitleColumn = new DataGridViewTextBoxColumn();
        RecordsGridInventoryNumberColumn = new DataGridViewTextBoxColumn();
        RecordsGridKindColumn = new DataGridViewTextBoxColumn();
        RecordsGridSubjectColumn = new DataGridViewTextBoxColumn();
        AddRecordButton = new Button();
        EditRecordButton = new Button();
        DeleteRecordButton = new Button();
        ((System.ComponentModel.ISupportInitialize)RecordsGrid).BeginInit();
        SuspendLayout();

        RecordsGrid.Name = "RecordsGrid";
        RecordsGrid.TabIndex = 0;
        RecordsGrid.Location = new Point(12, 12);
        RecordsGrid.Size = new Size(876, 396);
        RecordsGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        RecordsGrid.AllowUserToAddRows = false;
        RecordsGrid.AllowUserToDeleteRows = false;
        RecordsGrid.AllowUserToResizeRows = false;
        RecordsGrid.AutoGenerateColumns = false;
        RecordsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        RecordsGrid.MultiSelect = false;
        RecordsGrid.ReadOnly = true;
        RecordsGrid.RowHeadersVisible = false;
        RecordsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        RecordsGrid.Columns.AddRange(new DataGridViewColumn[] { RecordsGridIdColumn, RecordsGridTitleColumn, RecordsGridInventoryNumberColumn, RecordsGridKindColumn, RecordsGridSubjectColumn });
        RecordsGridIdColumn.Name = "IdColumn";
        RecordsGridIdColumn.HeaderText = "";
        RecordsGridIdColumn.Visible = false;
        RecordsGridIdColumn.ReadOnly = true;
        RecordsGridTitleColumn.Name = "TitleColumn";
        RecordsGridTitleColumn.HeaderText = "Название";
        RecordsGridTitleColumn.ReadOnly = true;
        RecordsGridInventoryNumberColumn.Name = "InventoryNumberColumn";
        RecordsGridInventoryNumberColumn.HeaderText = "Инвентарный номер";
        RecordsGridInventoryNumberColumn.ReadOnly = true;
        RecordsGridKindColumn.Name = "KindColumn";
        RecordsGridKindColumn.HeaderText = "Вид";
        RecordsGridKindColumn.ReadOnly = true;
        RecordsGridSubjectColumn.Name = "SubjectColumn";
        RecordsGridSubjectColumn.HeaderText = "Тематика";
        RecordsGridSubjectColumn.ReadOnly = true;

        AddRecordButton.Name = "AddRecordButton";
        AddRecordButton.TabIndex = 1;
        AddRecordButton.Location = new Point(12, 426);
        AddRecordButton.Size = new Size(140, 34);
        AddRecordButton.Text = "Добавить";
        AddRecordButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        AddRecordButton.UseVisualStyleBackColor = true;
        AddRecordButton.Click += AddRecordButton_Click;

        EditRecordButton.Name = "EditRecordButton";
        EditRecordButton.TabIndex = 2;
        EditRecordButton.Location = new Point(162, 426);
        EditRecordButton.Size = new Size(140, 34);
        EditRecordButton.Text = "Редактировать";
        EditRecordButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        EditRecordButton.UseVisualStyleBackColor = true;
        EditRecordButton.Click += EditRecordButton_Click;

        DeleteRecordButton.Name = "DeleteRecordButton";
        DeleteRecordButton.TabIndex = 3;
        DeleteRecordButton.Location = new Point(312, 426);
        DeleteRecordButton.Size = new Size(140, 34);
        DeleteRecordButton.Text = "Удалить";
        DeleteRecordButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        DeleteRecordButton.UseVisualStyleBackColor = true;
        DeleteRecordButton.Click += DeleteRecordButton_Click;

        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        ClientSize = new Size(900, 480);
        Font = new Font("Segoe UI", 10F);
        MinimumSize = new Size(900, 480);
        Name = "PublicationListForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Литературные источники";
        Controls.Add(RecordsGrid);
        Controls.Add(AddRecordButton);
        Controls.Add(EditRecordButton);
        Controls.Add(DeleteRecordButton);
        Shown += PublicationListForm_Shown;
        ((System.ComponentModel.ISupportInitialize)RecordsGrid).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private DataGridView RecordsGrid;
    private DataGridViewTextBoxColumn RecordsGridIdColumn;
    private DataGridViewTextBoxColumn RecordsGridTitleColumn;
    private DataGridViewTextBoxColumn RecordsGridInventoryNumberColumn;
    private DataGridViewTextBoxColumn RecordsGridKindColumn;
    private DataGridViewTextBoxColumn RecordsGridSubjectColumn;
    private Button AddRecordButton;
    private Button EditRecordButton;
    private Button DeleteRecordButton;
}
