<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.KanaOutput = New System.Windows.Forms.Label()
        Me.AnswerInput = New System.Windows.Forms.TextBox()
        Me.TimerNextKana = New System.Windows.Forms.Timer(Me.components)
        Me.KanaSelector = New System.Windows.Forms.CheckedListBox()
        Me.Success1 = New System.Windows.Forms.PictureBox()
        Me.Success2 = New System.Windows.Forms.PictureBox()
        Me.Success3 = New System.Windows.Forms.PictureBox()
        Me.Success4 = New System.Windows.Forms.PictureBox()
        Me.Success5 = New System.Windows.Forms.PictureBox()
        Me.Success10 = New System.Windows.Forms.PictureBox()
        Me.Success9 = New System.Windows.Forms.PictureBox()
        Me.Success8 = New System.Windows.Forms.PictureBox()
        Me.Success7 = New System.Windows.Forms.PictureBox()
        Me.Success6 = New System.Windows.Forms.PictureBox()
        CType(Me.Success1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Success2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Success3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Success4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Success5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Success10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Success9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Success8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Success7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Success6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KanaOutput
        '
        Me.KanaOutput.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KanaOutput.Font = New System.Drawing.Font("Yu Mincho", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.KanaOutput.Location = New System.Drawing.Point(12, 45)
        Me.KanaOutput.Name = "KanaOutput"
        Me.KanaOutput.Size = New System.Drawing.Size(776, 124)
        Me.KanaOutput.TabIndex = 0
        Me.KanaOutput.Text = "あ"
        Me.KanaOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AnswerInput
        '
        Me.AnswerInput.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AnswerInput.BackColor = System.Drawing.Color.White
        Me.AnswerInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AnswerInput.Font = New System.Drawing.Font("Microsoft YaHei", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AnswerInput.Location = New System.Drawing.Point(12, 172)
        Me.AnswerInput.Name = "AnswerInput"
        Me.AnswerInput.Size = New System.Drawing.Size(776, 47)
        Me.AnswerInput.TabIndex = 1
        Me.AnswerInput.Text = "a"
        Me.AnswerInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TimerNextKana
        '
        Me.TimerNextKana.Interval = 500
        '
        'KanaSelector
        '
        Me.KanaSelector.BackColor = System.Drawing.SystemColors.Window
        Me.KanaSelector.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.KanaSelector.CheckOnClick = True
        Me.KanaSelector.FormattingEnabled = True
        Me.KanaSelector.Items.AddRange(New Object() {"Hiragana", "Hiragana Dakuten", "Hiragana Combo", "Katakana", "Katakana Dakuten", "Katakana Combo", "Katakana Extended"})
        Me.KanaSelector.Location = New System.Drawing.Point(16, 308)
        Me.KanaSelector.Name = "KanaSelector"
        Me.KanaSelector.Size = New System.Drawing.Size(138, 126)
        Me.KanaSelector.TabIndex = 114
        '
        'Success1
        '
        Me.Success1.BackColor = System.Drawing.Color.Gray
        Me.Success1.Location = New System.Drawing.Point(322, 419)
        Me.Success1.Name = "Success1"
        Me.Success1.Size = New System.Drawing.Size(10, 10)
        Me.Success1.TabIndex = 115
        Me.Success1.TabStop = False
        '
        'Success2
        '
        Me.Success2.BackColor = System.Drawing.Color.Gray
        Me.Success2.Location = New System.Drawing.Point(338, 419)
        Me.Success2.Name = "Success2"
        Me.Success2.Size = New System.Drawing.Size(10, 10)
        Me.Success2.TabIndex = 116
        Me.Success2.TabStop = False
        '
        'Success3
        '
        Me.Success3.BackColor = System.Drawing.Color.Gray
        Me.Success3.Location = New System.Drawing.Point(354, 419)
        Me.Success3.Name = "Success3"
        Me.Success3.Size = New System.Drawing.Size(10, 10)
        Me.Success3.TabIndex = 117
        Me.Success3.TabStop = False
        '
        'Success4
        '
        Me.Success4.BackColor = System.Drawing.Color.Gray
        Me.Success4.Location = New System.Drawing.Point(370, 419)
        Me.Success4.Name = "Success4"
        Me.Success4.Size = New System.Drawing.Size(10, 10)
        Me.Success4.TabIndex = 118
        Me.Success4.TabStop = False
        '
        'Success5
        '
        Me.Success5.BackColor = System.Drawing.Color.Gray
        Me.Success5.Location = New System.Drawing.Point(386, 419)
        Me.Success5.Name = "Success5"
        Me.Success5.Size = New System.Drawing.Size(10, 10)
        Me.Success5.TabIndex = 119
        Me.Success5.TabStop = False
        '
        'Success10
        '
        Me.Success10.BackColor = System.Drawing.Color.Gray
        Me.Success10.Location = New System.Drawing.Point(466, 419)
        Me.Success10.Name = "Success10"
        Me.Success10.Size = New System.Drawing.Size(10, 10)
        Me.Success10.TabIndex = 124
        Me.Success10.TabStop = False
        '
        'Success9
        '
        Me.Success9.BackColor = System.Drawing.Color.Gray
        Me.Success9.Location = New System.Drawing.Point(450, 419)
        Me.Success9.Name = "Success9"
        Me.Success9.Size = New System.Drawing.Size(10, 10)
        Me.Success9.TabIndex = 123
        Me.Success9.TabStop = False
        '
        'Success8
        '
        Me.Success8.BackColor = System.Drawing.Color.Gray
        Me.Success8.Location = New System.Drawing.Point(434, 419)
        Me.Success8.Name = "Success8"
        Me.Success8.Size = New System.Drawing.Size(10, 10)
        Me.Success8.TabIndex = 122
        Me.Success8.TabStop = False
        '
        'Success7
        '
        Me.Success7.BackColor = System.Drawing.Color.Gray
        Me.Success7.Location = New System.Drawing.Point(418, 419)
        Me.Success7.Name = "Success7"
        Me.Success7.Size = New System.Drawing.Size(10, 10)
        Me.Success7.TabIndex = 121
        Me.Success7.TabStop = False
        '
        'Success6
        '
        Me.Success6.BackColor = System.Drawing.Color.Gray
        Me.Success6.Location = New System.Drawing.Point(402, 419)
        Me.Success6.Name = "Success6"
        Me.Success6.Size = New System.Drawing.Size(10, 10)
        Me.Success6.TabIndex = 120
        Me.Success6.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Success10)
        Me.Controls.Add(Me.Success9)
        Me.Controls.Add(Me.Success8)
        Me.Controls.Add(Me.Success7)
        Me.Controls.Add(Me.Success6)
        Me.Controls.Add(Me.Success5)
        Me.Controls.Add(Me.Success4)
        Me.Controls.Add(Me.Success3)
        Me.Controls.Add(Me.Success2)
        Me.Controls.Add(Me.Success1)
        Me.Controls.Add(Me.KanaSelector)
        Me.Controls.Add(Me.AnswerInput)
        Me.Controls.Add(Me.KanaOutput)
        Me.MaximumSize = New System.Drawing.Size(816, 489)
        Me.MinimumSize = New System.Drawing.Size(816, 489)
        Me.Name = "Form1"
        Me.Text = "KanaTrainer"
        CType(Me.Success1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Success2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Success3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Success4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Success5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Success10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Success9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Success8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Success7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Success6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents KanaOutput As Label
    Friend WithEvents AnswerInput As TextBox
    Friend WithEvents TimerNextKana As Timer
    Friend WithEvents KanaSelector As CheckedListBox
    Friend WithEvents Success1 As PictureBox
    Friend WithEvents Success2 As PictureBox
    Friend WithEvents Success3 As PictureBox
    Friend WithEvents Success4 As PictureBox
    Friend WithEvents Success5 As PictureBox
    Friend WithEvents Success10 As PictureBox
    Friend WithEvents Success9 As PictureBox
    Friend WithEvents Success8 As PictureBox
    Friend WithEvents Success7 As PictureBox
    Friend WithEvents Success6 As PictureBox
End Class
