
namespace carFixMgr0611.ui
{
    partial class ReceiptView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.viewList = new System.Windows.Forms.ListView();
            this.viewGrid = new Sunny.UI.UIDataGridView();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.viewSelect = new Sunny.UI.UIComboBox();
            this.vSearchItem = new Sunny.UI.UISymbolButton();
            this.vSearchAll = new Sunny.UI.UISymbolButton();
            this.vDelete = new Sunny.UI.UISymbolButton();
            this.vModify = new Sunny.UI.UISymbolButton();
            this.vConfirm = new Sunny.UI.UISymbolButton();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.viewExit = new Sunny.UI.UISymbolButton();
            this.viewSearch = new CxFlatUI.CxFlatTextBox();
            this.lCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.linDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lTotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lStaffName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lCustName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.viewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // viewList
            // 
            this.viewList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lCount,
            this.linDate,
            this.lTotalPrice,
            this.lStaffName,
            this.lCustName});
            this.viewList.HideSelection = false;
            this.viewList.Location = new System.Drawing.Point(21, 136);
            this.viewList.Name = "viewList";
            this.viewList.Size = new System.Drawing.Size(856, 193);
            this.viewList.TabIndex = 0;
            this.viewList.UseCompatibleStateImageBehavior = false;
            this.viewList.View = System.Windows.Forms.View.Details;
            // 
            // viewGrid
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.viewGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.viewGrid.BackgroundColor = System.Drawing.Color.White;
            this.viewGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.viewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewGrid.EnableHeadersVisualStyles = false;
            this.viewGrid.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.viewGrid.Location = new System.Drawing.Point(21, 400);
            this.viewGrid.Name = "viewGrid";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.viewGrid.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.viewGrid.RowTemplate.Height = 29;
            this.viewGrid.SelectedIndex = -1;
            this.viewGrid.ShowGridLine = true;
            this.viewGrid.Size = new System.Drawing.Size(856, 212);
            this.viewGrid.TabIndex = 1;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(21, 86);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(143, 44);
            this.uiSymbolLabel1.Symbol = 61484;
            this.uiSymbolLabel1.TabIndex = 2;
            this.uiSymbolLabel1.Text = "검색항목";
            // 
            // viewSelect
            // 
            this.viewSelect.FillColor = System.Drawing.Color.White;
            this.viewSelect.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewSelect.Location = new System.Drawing.Point(180, 92);
            this.viewSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewSelect.MinimumSize = new System.Drawing.Size(63, 0);
            this.viewSelect.Name = "viewSelect";
            this.viewSelect.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.viewSelect.Size = new System.Drawing.Size(144, 29);
            this.viewSelect.TabIndex = 3;
            this.viewSelect.Text = "검색항목 선택";
            this.viewSelect.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // vSearchItem
            // 
            this.vSearchItem.BackColor = System.Drawing.Color.Transparent;
            this.vSearchItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vSearchItem.FillColor = System.Drawing.Color.Transparent;
            this.vSearchItem.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.vSearchItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.vSearchItem.Location = new System.Drawing.Point(591, 92);
            this.vSearchItem.MinimumSize = new System.Drawing.Size(1, 1);
            this.vSearchItem.Name = "vSearchItem";
            this.vSearchItem.Size = new System.Drawing.Size(109, 30);
            this.vSearchItem.Style = Sunny.UI.UIStyle.Custom;
            this.vSearchItem.Symbol = 61454;
            this.vSearchItem.TabIndex = 5;
            this.vSearchItem.Text = "검색";
            // 
            // vSearchAll
            // 
            this.vSearchAll.BackColor = System.Drawing.Color.Transparent;
            this.vSearchAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vSearchAll.FillColor = System.Drawing.Color.Transparent;
            this.vSearchAll.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.vSearchAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.vSearchAll.Location = new System.Drawing.Point(715, 91);
            this.vSearchAll.MinimumSize = new System.Drawing.Size(1, 1);
            this.vSearchAll.Name = "vSearchAll";
            this.vSearchAll.Size = new System.Drawing.Size(109, 30);
            this.vSearchAll.Style = Sunny.UI.UIStyle.Custom;
            this.vSearchAll.Symbol = 61442;
            this.vSearchAll.TabIndex = 6;
            this.vSearchAll.Text = "전체 검색";
            // 
            // vDelete
            // 
            this.vDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vDelete.FillColor = System.Drawing.Color.SandyBrown;
            this.vDelete.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.vDelete.Location = new System.Drawing.Point(757, 338);
            this.vDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.vDelete.Name = "vDelete";
            this.vDelete.RectColor = System.Drawing.Color.SandyBrown;
            this.vDelete.Size = new System.Drawing.Size(109, 30);
            this.vDelete.Style = Sunny.UI.UIStyle.Custom;
            this.vDelete.Symbol = 62005;
            this.vDelete.TabIndex = 7;
            this.vDelete.Text = "삭제";
            // 
            // vModify
            // 
            this.vModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vModify.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.vModify.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.vModify.Location = new System.Drawing.Point(633, 338);
            this.vModify.MinimumSize = new System.Drawing.Size(1, 1);
            this.vModify.Name = "vModify";
            this.vModify.RectColor = System.Drawing.Color.MediumSeaGreen;
            this.vModify.Size = new System.Drawing.Size(109, 30);
            this.vModify.Style = Sunny.UI.UIStyle.Custom;
            this.vModify.Symbol = 61508;
            this.vModify.TabIndex = 7;
            this.vModify.Text = "수정";
            // 
            // vConfirm
            // 
            this.vConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vConfirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.vConfirm.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.vConfirm.Location = new System.Drawing.Point(507, 338);
            this.vConfirm.MinimumSize = new System.Drawing.Size(1, 1);
            this.vConfirm.Name = "vConfirm";
            this.vConfirm.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.vConfirm.Size = new System.Drawing.Size(109, 30);
            this.vConfirm.Style = Sunny.UI.UIStyle.Custom;
            this.vConfirm.Symbol = 61639;
            this.vConfirm.TabIndex = 7;
            this.vConfirm.Text = "완료";
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(21, 350);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(143, 44);
            this.uiSymbolLabel2.Symbol = 61613;
            this.uiSymbolLabel2.TabIndex = 2;
            this.uiSymbolLabel2.Text = "상세 수리내역";
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel3.ForeColor = System.Drawing.Color.White;
            this.uiSymbolLabel3.Location = new System.Drawing.Point(12, 12);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(186, 43);
            this.uiSymbolLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel3.Symbol = 61508;
            this.uiSymbolLabel3.SymbolColor = System.Drawing.Color.White;
            this.uiSymbolLabel3.SymbolSize = 36;
            this.uiSymbolLabel3.TabIndex = 10;
            this.uiSymbolLabel3.Text = "접수 내역";
            // 
            // viewExit
            // 
            this.viewExit.BackColor = System.Drawing.Color.Transparent;
            this.viewExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewExit.FillColor = System.Drawing.Color.Transparent;
            this.viewExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewExit.ForeColor = System.Drawing.Color.Red;
            this.viewExit.Location = new System.Drawing.Point(837, 12);
            this.viewExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.viewExit.Name = "viewExit";
            this.viewExit.RectColor = System.Drawing.Color.Red;
            this.viewExit.Size = new System.Drawing.Size(40, 30);
            this.viewExit.Style = Sunny.UI.UIStyle.Custom;
            this.viewExit.Symbol = 61453;
            this.viewExit.TabIndex = 9;
            this.viewExit.Click += new System.EventHandler(this.viewExit_Click);
            // 
            // viewSearch
            // 
            this.viewSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.viewSearch.Hint = "검색어를 입력하세요.";
            this.viewSearch.Location = new System.Drawing.Point(338, 86);
            this.viewSearch.MaxLength = 32767;
            this.viewSearch.Multiline = false;
            this.viewSearch.Name = "viewSearch";
            this.viewSearch.PasswordChar = '\0';
            this.viewSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.viewSearch.SelectedText = "";
            this.viewSearch.SelectionLength = 0;
            this.viewSearch.SelectionStart = 0;
            this.viewSearch.Size = new System.Drawing.Size(238, 38);
            this.viewSearch.TabIndex = 11;
            this.viewSearch.TabStop = false;
            this.viewSearch.UseSystemPasswordChar = false;
            // 
            // lCount
            // 
            this.lCount.Text = "번호";
            // 
            // linDate
            // 
            this.linDate.Text = "접수날짜";
            this.linDate.Width = 100;
            // 
            // lTotalPrice
            // 
            this.lTotalPrice.Text = "총결제금액";
            this.lTotalPrice.Width = 120;
            // 
            // lStaffName
            // 
            this.lStaffName.Text = "담당자";
            this.lStaffName.Width = 100;
            // 
            // lCustName
            // 
            this.lCustName.Text = "고객명";
            this.lCustName.Width = 100;
            // 
            // ReceiptView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 659);
            this.ControlBox = false;
            this.Controls.Add(this.viewSearch);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.viewExit);
            this.Controls.Add(this.vConfirm);
            this.Controls.Add(this.vModify);
            this.Controls.Add(this.vDelete);
            this.Controls.Add(this.vSearchAll);
            this.Controls.Add(this.vSearchItem);
            this.Controls.Add(this.viewSelect);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.viewGrid);
            this.Controls.Add(this.viewList);
            this.Name = "ReceiptView";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.ReceiptView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView viewList;
        private Sunny.UI.UIDataGridView viewGrid;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UIComboBox viewSelect;
        private Sunny.UI.UISymbolButton vSearchItem;
        private Sunny.UI.UISymbolButton vSearchAll;
        private Sunny.UI.UISymbolButton vDelete;
        private Sunny.UI.UISymbolButton vModify;
        private Sunny.UI.UISymbolButton vConfirm;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UISymbolButton viewExit;
        private CxFlatUI.CxFlatTextBox viewSearch;
        private System.Windows.Forms.ColumnHeader lCount;
        private System.Windows.Forms.ColumnHeader linDate;
        private System.Windows.Forms.ColumnHeader lTotalPrice;
        private System.Windows.Forms.ColumnHeader lStaffName;
        private System.Windows.Forms.ColumnHeader lCustName;
    }
}