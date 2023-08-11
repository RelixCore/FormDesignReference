namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings messageBoxSettings1 = new Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings();
            Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings pdfViewerPrinterSettings1 = new Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings textSearchSettings1 = new Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings();
            tbSurveyorname = new TextBox();
            tbEastings = new TextBox();
            tbClientNo = new TextBox();
            tbNorthings = new TextBox();
            tbElevations = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            tbAddress = new TextBox();
            comboBox1 = new ComboBox();
            btSave = new Button();
            btClear = new Button();
            btUpload = new Button();
            pdfViewerControl1 = new Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // tbSurveyorname
            // 
            tbSurveyorname.BackColor = SystemColors.Window;
            tbSurveyorname.BorderStyle = BorderStyle.None;
            tbSurveyorname.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            tbSurveyorname.Location = new Point(57, 168);
            tbSurveyorname.Name = "tbSurveyorname";
            tbSurveyorname.Size = new Size(247, 18);
            tbSurveyorname.TabIndex = 0;
            // 
            // tbEastings
            // 
            tbEastings.BackColor = SystemColors.Window;
            tbEastings.BorderStyle = BorderStyle.None;
            tbEastings.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            tbEastings.Location = new Point(57, 283);
            tbEastings.Name = "tbEastings";
            tbEastings.Size = new Size(164, 18);
            tbEastings.TabIndex = 1;
            // 
            // tbClientNo
            // 
            tbClientNo.BackColor = SystemColors.Window;
            tbClientNo.BorderStyle = BorderStyle.None;
            tbClientNo.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            tbClientNo.Location = new Point(57, 443);
            tbClientNo.Name = "tbClientNo";
            tbClientNo.Size = new Size(247, 18);
            tbClientNo.TabIndex = 2;
            // 
            // tbNorthings
            // 
            tbNorthings.BackColor = SystemColors.Window;
            tbNorthings.BorderStyle = BorderStyle.None;
            tbNorthings.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            tbNorthings.Location = new Point(57, 337);
            tbNorthings.Name = "tbNorthings";
            tbNorthings.Size = new Size(164, 18);
            tbNorthings.TabIndex = 3;
            // 
            // tbElevations
            // 
            tbElevations.BackColor = SystemColors.Window;
            tbElevations.BorderStyle = BorderStyle.None;
            tbElevations.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            tbElevations.Location = new Point(56, 390);
            tbElevations.Name = "tbElevations";
            tbElevations.Size = new Size(93, 18);
            tbElevations.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(54, 492);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 25);
            dateTimePicker1.TabIndex = 5;
            // 
            // tbAddress
            // 
            tbAddress.BackColor = SystemColors.Window;
            tbAddress.BorderStyle = BorderStyle.None;
            tbAddress.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            tbAddress.Location = new Point(56, 553);
            tbAddress.Multiline = true;
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(247, 51);
            tbAddress.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Cadastral Survey", "Engineering Survey" });
            comboBox1.Location = new Point(59, 224);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(245, 23);
            comboBox1.TabIndex = 7;
            // 
            // btSave
            // 
            btSave.BackColor = Color.Transparent;
            btSave.FlatAppearance.BorderSize = 0;
            btSave.FlatStyle = FlatStyle.Flat;
            btSave.Location = new Point(71, 630);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 8;
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // btClear
            // 
            btClear.BackColor = Color.Transparent;
            btClear.FlatAppearance.BorderSize = 0;
            btClear.FlatStyle = FlatStyle.Flat;
            btClear.Location = new Point(197, 630);
            btClear.Name = "btClear";
            btClear.Size = new Size(94, 29);
            btClear.TabIndex = 9;
            btClear.UseVisualStyleBackColor = false;
            btClear.Click += btClear_Click;
            // 
            // btUpload
            // 
            btUpload.BackColor = Color.Transparent;
            btUpload.FlatAppearance.BorderSize = 0;
            btUpload.FlatStyle = FlatStyle.Flat;
            btUpload.Location = new Point(377, 499);
            btUpload.Name = "btUpload";
            btUpload.Size = new Size(183, 29);
            btUpload.TabIndex = 10;
            btUpload.UseVisualStyleBackColor = false;
            btUpload.Click += btUpload_Click;
            // 
            // pdfViewerControl1
            // 
            pdfViewerControl1.CursorMode = Syncfusion.Windows.Forms.PdfViewer.PdfViewerCursorMode.SelectTool;
            pdfViewerControl1.EnableContextMenu = true;
            pdfViewerControl1.EnableNotificationBar = true;
            pdfViewerControl1.HorizontalScrollOffset = 0;
            pdfViewerControl1.IsBookmarkEnabled = true;
            pdfViewerControl1.IsTextSearchEnabled = true;
            pdfViewerControl1.IsTextSelectionEnabled = true;
            pdfViewerControl1.Location = new Point(365, 220);
            messageBoxSettings1.EnableNotification = true;
            pdfViewerControl1.MessageBoxSettings = messageBoxSettings1;
            pdfViewerControl1.MinimumZoomPercentage = 50;
            pdfViewerControl1.Name = "pdfViewerControl1";
            pdfViewerControl1.PageBorderThickness = 1;
            pdfViewerPrinterSettings1.Copies = 1;
            pdfViewerPrinterSettings1.PageOrientation = Syncfusion.Windows.PdfViewer.PdfViewerPrintOrientation.Auto;
            pdfViewerPrinterSettings1.PageSize = Syncfusion.Windows.PdfViewer.PdfViewerPrintSize.ActualSize;
            pdfViewerPrinterSettings1.PrintLocation = (PointF)resources.GetObject("pdfViewerPrinterSettings1.PrintLocation");
            pdfViewerPrinterSettings1.ShowPrintStatusDialog = true;
            pdfViewerControl1.PrinterSettings = pdfViewerPrinterSettings1;
            pdfViewerControl1.ReferencePath = null;
            pdfViewerControl1.ScrollDisplacementValue = 0;
            pdfViewerControl1.ShowHorizontalScrollBar = true;
            pdfViewerControl1.ShowToolBar = true;
            pdfViewerControl1.ShowVerticalScrollBar = true;
            pdfViewerControl1.Size = new Size(212, 260);
            pdfViewerControl1.SpaceBetweenPages = 8;
            pdfViewerControl1.TabIndex = 11;
            pdfViewerControl1.Text = "pdfViewerControl1";
            textSearchSettings1.CurrentInstanceColor = Color.FromArgb(127, 255, 171, 64);
            textSearchSettings1.HighlightAllInstance = true;
            textSearchSettings1.OtherInstanceColor = Color.FromArgb(127, 254, 255, 0);
            pdfViewerControl1.TextSearchSettings = textSearchSettings1;
            pdfViewerControl1.ThemeName = "Default";
            pdfViewerControl1.VerticalScrollOffset = 0;
            pdfViewerControl1.VisualStyle = Syncfusion.Windows.Forms.PdfViewer.VisualStyle.Default;
            pdfViewerControl1.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.FitPage;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Frame_2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(618, 693);
            Controls.Add(pdfViewerControl1);
            Controls.Add(btUpload);
            Controls.Add(btClear);
            Controls.Add(btSave);
            Controls.Add(comboBox1);
            Controls.Add(tbAddress);
            Controls.Add(dateTimePicker1);
            Controls.Add(tbElevations);
            Controls.Add(tbNorthings);
            Controls.Add(tbClientNo);
            Controls.Add(tbEastings);
            Controls.Add(tbSurveyorname);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbSurveyorname;
        private TextBox tbEastings;
        private TextBox tbClientNo;
        private TextBox tbNorthings;
        private TextBox tbElevations;
        private DateTimePicker dateTimePicker1;
        private TextBox tbAddress;
        private ComboBox comboBox1;
        private Button btSave;
        private Button btClear;
        private Button btUpload;
        private Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl pdfViewerControl1;
        private OpenFileDialog openFileDialog1;
    }
}