<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Btn_SP = New System.Windows.Forms.Button()
        Me.BtnChooseChartFile = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelSong = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SP_TextSeconds = New System.Windows.Forms.TextBox()
        Me.SP_TextBPM = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SP_TimesigBot = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SP_TimesigTop = New System.Windows.Forms.NumericUpDown()
        Me.SP_NumericMeasureSpacing = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox3.SuspendLayout
        CType(Me.SP_TimesigBot,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SP_TimesigTop,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SP_NumericMeasureSpacing,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Btn_SP
        '
        Me.Btn_SP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.Btn_SP.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Btn_SP.Location = New System.Drawing.Point(12, 470)
        Me.Btn_SP.Margin = New System.Windows.Forms.Padding(200, 3, 200, 3)
        Me.Btn_SP.Name = "Btn_SP"
        Me.Btn_SP.Size = New System.Drawing.Size(209, 34)
        Me.Btn_SP.TabIndex = 10
        Me.Btn_SP.Text = "Create star power"
        Me.Btn_SP.UseVisualStyleBackColor = true
        '
        'BtnChooseChartFile
        '
        Me.BtnChooseChartFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.BtnChooseChartFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.BtnChooseChartFile.Location = New System.Drawing.Point(123, 400)
        Me.BtnChooseChartFile.Name = "BtnChooseChartFile"
        Me.BtnChooseChartFile.Size = New System.Drawing.Size(40, 30)
        Me.BtnChooseChartFile.TabIndex = 9
        Me.BtnChooseChartFile.Text = "..."
        Me.BtnChooseChartFile.UseVisualStyleBackColor = true
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 403)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 26)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Chart file:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 348)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 26)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Song:"
        '
        'LabelSong
        '
        Me.LabelSong.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.LabelSong.AutoSize = true
        Me.LabelSong.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelSong.Location = New System.Drawing.Point(87, 348)
        Me.LabelSong.Name = "LabelSong"
        Me.LabelSong.Size = New System.Drawing.Size(122, 26)
        Me.LabelSong.TabIndex = 12
        Me.LabelSong.Text = "SongName"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.SP_TextSeconds)
        Me.GroupBox3.Controls.Add(Me.SP_TextBPM)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.SP_TimesigBot)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.SP_TimesigTop)
        Me.GroupBox3.Controls.Add(Me.SP_NumericMeasureSpacing)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(297, 297)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = false
        Me.GroupBox3.Text = "Star power distance"
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label8.Location = New System.Drawing.Point(55, 251)
        Me.Label8.Margin = New System.Windows.Forms.Padding(3, 0, 7, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 26)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Seconds"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.Location = New System.Drawing.Point(96, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 26)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "BPM"
        '
        'SP_TextSeconds
        '
        Me.SP_TextSeconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.SP_TextSeconds.Location = New System.Drawing.Point(162, 248)
        Me.SP_TextSeconds.Name = "SP_TextSeconds"
        Me.SP_TextSeconds.ReadOnly = true
        Me.SP_TextSeconds.Size = New System.Drawing.Size(100, 32)
        Me.SP_TextSeconds.TabIndex = 22
        Me.SP_TextSeconds.Text = "0"
        '
        'SP_TextBPM
        '
        Me.SP_TextBPM.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.SP_TextBPM.Location = New System.Drawing.Point(162, 59)
        Me.SP_TextBPM.Name = "SP_TextBPM"
        Me.SP_TextBPM.Size = New System.Drawing.Size(100, 32)
        Me.SP_TextBPM.TabIndex = 13
        Me.SP_TextBPM.Text = "120"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.Location = New System.Drawing.Point(111, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 26)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "MS"
        '
        'SP_TimesigBot
        '
        Me.SP_TimesigBot.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.SP_TimesigBot.Location = New System.Drawing.Point(162, 186)
        Me.SP_TimesigBot.Name = "SP_TimesigBot"
        Me.SP_TimesigBot.Size = New System.Drawing.Size(57, 32)
        Me.SP_TimesigBot.TabIndex = 20
        Me.SP_TimesigBot.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label7.Location = New System.Drawing.Point(117, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 26)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "TS"
        '
        'SP_TimesigTop
        '
        Me.SP_TimesigTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.SP_TimesigTop.Location = New System.Drawing.Point(162, 148)
        Me.SP_TimesigTop.Name = "SP_TimesigTop"
        Me.SP_TimesigTop.Size = New System.Drawing.Size(57, 32)
        Me.SP_TimesigTop.TabIndex = 19
        Me.SP_TimesigTop.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'SP_NumericMeasureSpacing
        '
        Me.SP_NumericMeasureSpacing.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.SP_NumericMeasureSpacing.Location = New System.Drawing.Point(162, 99)
        Me.SP_NumericMeasureSpacing.Name = "SP_NumericMeasureSpacing"
        Me.SP_NumericMeasureSpacing.Size = New System.Drawing.Size(100, 32)
        Me.SP_NumericMeasureSpacing.TabIndex = 18
        Me.SP_NumericMeasureSpacing.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 516)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.LabelSong)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn_SP)
        Me.Controls.Add(Me.BtnChooseChartFile)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MainForm"
        Me.Text = "Star Power Placer"
        Me.GroupBox3.ResumeLayout(false)
        Me.GroupBox3.PerformLayout
        CType(Me.SP_TimesigBot,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.SP_TimesigTop,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.SP_NumericMeasureSpacing,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Btn_SP As Button
    Friend WithEvents BtnChooseChartFile As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelSong As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SP_TextSeconds As TextBox
    Friend WithEvents SP_TextBPM As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents SP_TimesigBot As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents SP_TimesigTop As NumericUpDown
    Friend WithEvents SP_NumericMeasureSpacing As NumericUpDown
End Class
