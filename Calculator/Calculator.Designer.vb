<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Me.CalculatorLabel = New System.Windows.Forms.Label()
        Me.InputButtonAdd = New System.Windows.Forms.Button()
        Me.InputButtonSubtract = New System.Windows.Forms.Button()
        Me.InputButtonMultiply = New System.Windows.Forms.Button()
        Me.InputButtonDivide = New System.Windows.Forms.Button()
        Me.InputButtonCLR = New System.Windows.Forms.Button()
        Me.InputButton9 = New System.Windows.Forms.Button()
        Me.InputButton6 = New System.Windows.Forms.Button()
        Me.InputButton3 = New System.Windows.Forms.Button()
        Me.InputButton2 = New System.Windows.Forms.Button()
        Me.InputButton5 = New System.Windows.Forms.Button()
        Me.InputButton8 = New System.Windows.Forms.Button()
        Me.InputButton1 = New System.Windows.Forms.Button()
        Me.InputButton4 = New System.Windows.Forms.Button()
        Me.InputButton7 = New System.Windows.Forms.Button()
        Me.InputButton0 = New System.Windows.Forms.Button()
        Me.InputTextBox = New System.Windows.Forms.TextBox()
        Me.EqualsButton = New System.Windows.Forms.Button()
        Me.InputButtonOpenParenthesis = New System.Windows.Forms.Button()
        Me.InputButtonClosedParenthesis = New System.Windows.Forms.Button()
        Me.InputButtonIndex = New System.Windows.Forms.Button()
        Me.ImportantInformationLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CalculatorLabel
        '
        Me.CalculatorLabel.AutoSize = True
        Me.CalculatorLabel.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculatorLabel.Location = New System.Drawing.Point(61, 9)
        Me.CalculatorLabel.Name = "CalculatorLabel"
        Me.CalculatorLabel.Size = New System.Drawing.Size(165, 32)
        Me.CalculatorLabel.TabIndex = 0
        Me.CalculatorLabel.Text = "Calculator"
        '
        'InputButtonAdd
        '
        Me.InputButtonAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputButtonAdd.Location = New System.Drawing.Point(208, 111)
        Me.InputButtonAdd.Name = "InputButtonAdd"
        Me.InputButtonAdd.Size = New System.Drawing.Size(52, 45)
        Me.InputButtonAdd.TabIndex = 1
        Me.InputButtonAdd.Text = "+"
        Me.InputButtonAdd.UseVisualStyleBackColor = True
        '
        'InputButtonSubtract
        '
        Me.InputButtonSubtract.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputButtonSubtract.Location = New System.Drawing.Point(208, 162)
        Me.InputButtonSubtract.Name = "InputButtonSubtract"
        Me.InputButtonSubtract.Size = New System.Drawing.Size(52, 45)
        Me.InputButtonSubtract.TabIndex = 2
        Me.InputButtonSubtract.Text = "-"
        Me.InputButtonSubtract.UseVisualStyleBackColor = True
        '
        'InputButtonMultiply
        '
        Me.InputButtonMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputButtonMultiply.Location = New System.Drawing.Point(208, 213)
        Me.InputButtonMultiply.Name = "InputButtonMultiply"
        Me.InputButtonMultiply.Size = New System.Drawing.Size(52, 45)
        Me.InputButtonMultiply.TabIndex = 3
        Me.InputButtonMultiply.Text = "*"
        Me.InputButtonMultiply.UseVisualStyleBackColor = True
        '
        'InputButtonDivide
        '
        Me.InputButtonDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputButtonDivide.Location = New System.Drawing.Point(208, 264)
        Me.InputButtonDivide.Name = "InputButtonDivide"
        Me.InputButtonDivide.Size = New System.Drawing.Size(52, 45)
        Me.InputButtonDivide.TabIndex = 4
        Me.InputButtonDivide.Text = "/"
        Me.InputButtonDivide.UseVisualStyleBackColor = True
        '
        'InputButtonCLR
        '
        Me.InputButtonCLR.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputButtonCLR.Location = New System.Drawing.Point(34, 366)
        Me.InputButtonCLR.Name = "InputButtonCLR"
        Me.InputButtonCLR.Size = New System.Drawing.Size(168, 44)
        Me.InputButtonCLR.TabIndex = 5
        Me.InputButtonCLR.Text = "CLEAR"
        Me.InputButtonCLR.UseVisualStyleBackColor = True
        '
        'InputButton9
        '
        Me.InputButton9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputButton9.Location = New System.Drawing.Point(150, 263)
        Me.InputButton9.Name = "InputButton9"
        Me.InputButton9.Size = New System.Drawing.Size(52, 45)
        Me.InputButton9.TabIndex = 6
        Me.InputButton9.Text = "9"
        Me.InputButton9.UseVisualStyleBackColor = True
        '
        'InputButton6
        '
        Me.InputButton6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputButton6.Location = New System.Drawing.Point(150, 212)
        Me.InputButton6.Name = "InputButton6"
        Me.InputButton6.Size = New System.Drawing.Size(52, 45)
        Me.InputButton6.TabIndex = 7
        Me.InputButton6.Text = "6"
        Me.InputButton6.UseVisualStyleBackColor = True
        '
        'InputButton3
        '
        Me.InputButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputButton3.Location = New System.Drawing.Point(150, 161)
        Me.InputButton3.Name = "InputButton3"
        Me.InputButton3.Size = New System.Drawing.Size(52, 45)
        Me.InputButton3.TabIndex = 8
        Me.InputButton3.Text = "3"
        Me.InputButton3.UseVisualStyleBackColor = True
        '
        'InputButton2
        '
        Me.InputButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputButton2.Location = New System.Drawing.Point(92, 161)
        Me.InputButton2.Name = "InputButton2"
        Me.InputButton2.Size = New System.Drawing.Size(52, 45)
        Me.InputButton2.TabIndex = 11
        Me.InputButton2.Text = "2"
        Me.InputButton2.UseVisualStyleBackColor = True
        '
        'InputButton5
        '
        Me.InputButton5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputButton5.Location = New System.Drawing.Point(92, 212)
        Me.InputButton5.Name = "InputButton5"
        Me.InputButton5.Size = New System.Drawing.Size(52, 45)
        Me.InputButton5.TabIndex = 10
        Me.InputButton5.Text = "5"
        Me.InputButton5.UseVisualStyleBackColor = True
        '
        'InputButton8
        '
        Me.InputButton8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputButton8.Location = New System.Drawing.Point(92, 263)
        Me.InputButton8.Name = "InputButton8"
        Me.InputButton8.Size = New System.Drawing.Size(52, 45)
        Me.InputButton8.TabIndex = 9
        Me.InputButton8.Text = "8"
        Me.InputButton8.UseVisualStyleBackColor = True
        '
        'InputButton1
        '
        Me.InputButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputButton1.Location = New System.Drawing.Point(34, 161)
        Me.InputButton1.Name = "InputButton1"
        Me.InputButton1.Size = New System.Drawing.Size(52, 45)
        Me.InputButton1.TabIndex = 14
        Me.InputButton1.Text = "1"
        Me.InputButton1.UseVisualStyleBackColor = True
        '
        'InputButton4
        '
        Me.InputButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputButton4.Location = New System.Drawing.Point(34, 212)
        Me.InputButton4.Name = "InputButton4"
        Me.InputButton4.Size = New System.Drawing.Size(52, 45)
        Me.InputButton4.TabIndex = 13
        Me.InputButton4.Text = "4"
        Me.InputButton4.UseVisualStyleBackColor = True
        '
        'InputButton7
        '
        Me.InputButton7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputButton7.Location = New System.Drawing.Point(34, 263)
        Me.InputButton7.Name = "InputButton7"
        Me.InputButton7.Size = New System.Drawing.Size(52, 45)
        Me.InputButton7.TabIndex = 12
        Me.InputButton7.Text = "7"
        Me.InputButton7.UseVisualStyleBackColor = True
        '
        'InputButton0
        '
        Me.InputButton0.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputButton0.Location = New System.Drawing.Point(92, 314)
        Me.InputButton0.Name = "InputButton0"
        Me.InputButton0.Size = New System.Drawing.Size(52, 45)
        Me.InputButton0.TabIndex = 15
        Me.InputButton0.Text = "0"
        Me.InputButton0.UseVisualStyleBackColor = True
        '
        'InputTextBox
        '
        Me.InputTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputTextBox.Location = New System.Drawing.Point(14, 55)
        Me.InputTextBox.Name = "InputTextBox"
        Me.InputTextBox.Size = New System.Drawing.Size(265, 38)
        Me.InputTextBox.TabIndex = 16
        '
        'EqualsButton
        '
        Me.EqualsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EqualsButton.Location = New System.Drawing.Point(208, 366)
        Me.EqualsButton.Name = "EqualsButton"
        Me.EqualsButton.Size = New System.Drawing.Size(52, 44)
        Me.EqualsButton.TabIndex = 18
        Me.EqualsButton.Text = "="
        Me.EqualsButton.UseVisualStyleBackColor = True
        '
        'InputButtonOpenParenthesis
        '
        Me.InputButtonOpenParenthesis.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputButtonOpenParenthesis.Location = New System.Drawing.Point(34, 314)
        Me.InputButtonOpenParenthesis.Name = "InputButtonOpenParenthesis"
        Me.InputButtonOpenParenthesis.Size = New System.Drawing.Size(52, 45)
        Me.InputButtonOpenParenthesis.TabIndex = 20
        Me.InputButtonOpenParenthesis.Text = "("
        Me.InputButtonOpenParenthesis.UseVisualStyleBackColor = True
        '
        'InputButtonClosedParenthesis
        '
        Me.InputButtonClosedParenthesis.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputButtonClosedParenthesis.Location = New System.Drawing.Point(150, 314)
        Me.InputButtonClosedParenthesis.Name = "InputButtonClosedParenthesis"
        Me.InputButtonClosedParenthesis.Size = New System.Drawing.Size(52, 45)
        Me.InputButtonClosedParenthesis.TabIndex = 21
        Me.InputButtonClosedParenthesis.Text = ")"
        Me.InputButtonClosedParenthesis.UseVisualStyleBackColor = True
        '
        'InputButtonIndex
        '
        Me.InputButtonIndex.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputButtonIndex.Location = New System.Drawing.Point(208, 315)
        Me.InputButtonIndex.Name = "InputButtonIndex"
        Me.InputButtonIndex.Size = New System.Drawing.Size(52, 45)
        Me.InputButtonIndex.TabIndex = 22
        Me.InputButtonIndex.Text = "^"
        Me.InputButtonIndex.UseVisualStyleBackColor = True
        '
        'ImportantInformationLabel
        '
        Me.ImportantInformationLabel.Font = New System.Drawing.Font("Consolas", 7.5!)
        Me.ImportantInformationLabel.Location = New System.Drawing.Point(34, 111)
        Me.ImportantInformationLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.ImportantInformationLabel.Name = "ImportantInformationLabel"
        Me.ImportantInformationLabel.Size = New System.Drawing.Size(168, 45)
        Me.ImportantInformationLabel.TabIndex = 23
        Me.ImportantInformationLabel.Text = "Note - In case of directly typing into textbox, add spaces between values and ope" &
    "rators"
        Me.ImportantInformationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 424)
        Me.Controls.Add(Me.ImportantInformationLabel)
        Me.Controls.Add(Me.InputButtonIndex)
        Me.Controls.Add(Me.InputButtonClosedParenthesis)
        Me.Controls.Add(Me.InputButtonOpenParenthesis)
        Me.Controls.Add(Me.EqualsButton)
        Me.Controls.Add(Me.InputTextBox)
        Me.Controls.Add(Me.InputButton0)
        Me.Controls.Add(Me.InputButton1)
        Me.Controls.Add(Me.InputButton4)
        Me.Controls.Add(Me.InputButton7)
        Me.Controls.Add(Me.InputButton2)
        Me.Controls.Add(Me.InputButton5)
        Me.Controls.Add(Me.InputButton8)
        Me.Controls.Add(Me.InputButton3)
        Me.Controls.Add(Me.InputButton6)
        Me.Controls.Add(Me.InputButton9)
        Me.Controls.Add(Me.InputButtonCLR)
        Me.Controls.Add(Me.InputButtonDivide)
        Me.Controls.Add(Me.InputButtonMultiply)
        Me.Controls.Add(Me.InputButtonSubtract)
        Me.Controls.Add(Me.InputButtonAdd)
        Me.Controls.Add(Me.CalculatorLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Calculator"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CalculatorLabel As Label
    Friend WithEvents InputButtonAdd As Button
    Friend WithEvents InputButtonSubtract As Button
    Friend WithEvents InputButtonMultiply As Button
    Friend WithEvents InputButtonDivide As Button
    Friend WithEvents InputButtonCLR As Button
    Friend WithEvents InputButton9 As Button
    Friend WithEvents InputButton6 As Button
    Friend WithEvents InputButton3 As Button
    Friend WithEvents InputButton2 As Button
    Friend WithEvents InputButton5 As Button
    Friend WithEvents InputButton8 As Button
    Friend WithEvents InputButton1 As Button
    Friend WithEvents InputButton4 As Button
    Friend WithEvents InputButton7 As Button
    Friend WithEvents InputButton0 As Button
    Friend WithEvents InputTextBox As TextBox
    Friend WithEvents EqualsButton As Button
    Friend WithEvents InputButtonOpenParenthesis As Button
    Friend WithEvents InputButtonClosedParenthesis As Button
    Friend WithEvents InputButtonIndex As Button
    Friend WithEvents ImportantInformationLabel As Label
End Class
