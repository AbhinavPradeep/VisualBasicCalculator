Public Class Calculator
    Function IsInArray(stringToBeFound As String, arr As Object) As Boolean
        IsInArray = (UBound(Filter(arr, stringToBeFound)) > -1)
    End Function
    Dim MathematicalArray = New String() {"+", "-", "*", "/", "^", "(", ")"}
    ReadOnly Operators As Dictionary(Of String, SymbolType) = New Dictionary(Of String, SymbolType) From
    {
        {"^", New SymbolType("^", 4, True)},
        {"*", New SymbolType("*", 3, False)},
        {"/", New SymbolType("/", 3, False)},
        {"+", New SymbolType("+", 2, False)},
        {"-", New SymbolType("-", 2, False)}
    }
    Function ToPostfix(infix As String) As String
        Dim tokens = infix.Split(" ")
        Dim stack As New Stack(Of String)
        Dim output As New List(Of String)

        For Each token In tokens
            Dim iv As Integer
            Dim op1 As SymbolType
            Dim op2 As SymbolType
            If Integer.TryParse(token, iv) Then
                output.Add(token)
            ElseIf Operators.TryGetValue(token, op1) Then
                While stack.Count > 0 AndAlso Operators.TryGetValue(stack.Peek(), op2)
                    Dim c = op1.precedence.CompareTo(op2.precedence)
                    If c < 0 OrElse Not op1.rightAssociative AndAlso c <= 0 Then
                        output.Add(stack.Pop())
                    Else
                        Exit While
                    End If
                End While
                stack.Push(token)
            ElseIf token = "(" Then
                stack.Push(token)
            ElseIf token = ")" Then
                Dim top = ""
                While stack.Count > 0
                    top = stack.Pop()
                    If top <> "(" Then
                        output.Add(top)
                    Else
                        Exit While
                    End If
                End While
                If top <> "(" Then
                    Throw New ArgumentException("No matching left parenthesis.")
                End If
            End If
        Next
        While stack.Count > 0
            Dim top = stack.Pop()
            If Not Operators.ContainsKey(top) Then
                Throw New ArgumentException("No matching right parenthesis.")
            End If
            output.Add(top)
        End While
        Return String.Join(" ", output)
    End Function
    Private Sub InputButton1_Click(sender As Object, e As EventArgs) Handles InputButton1.Click
        Dim arr = InputTextBox.Text.ToCharArray
        Dim ReversedArray = arr.Reverse()
        Dim LastCharecter = ReversedArray(0).ToString

        If IsInArray(LastCharecter, MathematicalArray) Then
            InputTextBox.Text += " 1"
        Else
            InputTextBox.Text += "1"
        End If
    End Sub
    Private Sub InputButton2_Click(sender As Object, e As EventArgs) Handles InputButton2.Click
        Dim arr = InputTextBox.Text.ToCharArray
        Dim ReversedArray = arr.Reverse()
        Dim LastCharecter = ReversedArray(0).ToString

        If IsInArray(LastCharecter, MathematicalArray) Then
            InputTextBox.Text += " 2"
        Else
            InputTextBox.Text += "2"
        End If
    End Sub
    Private Sub InputButton3_Click(sender As Object, e As EventArgs) Handles InputButton3.Click
        Dim arr = InputTextBox.Text.ToCharArray
        Dim ReversedArray = arr.Reverse()
        Dim LastCharecter = ReversedArray(0).ToString

        If IsInArray(LastCharecter, MathematicalArray) Then
            InputTextBox.Text += " 3"
        Else
            InputTextBox.Text += "3"
        End If
    End Sub
    Private Sub InputButton4_Click(sender As Object, e As EventArgs) Handles InputButton4.Click
        Dim arr = InputTextBox.Text.ToCharArray
        Dim ReversedArray = arr.Reverse()
        Dim LastCharecter = ReversedArray(0).ToString

        If IsInArray(LastCharecter, MathematicalArray) Then
            InputTextBox.Text += " 4"
        Else
            InputTextBox.Text += "4"
        End If
    End Sub
    Private Sub InputButton5_Click(sender As Object, e As EventArgs) Handles InputButton5.Click
        Dim arr = InputTextBox.Text.ToCharArray
        Dim ReversedArray = arr.Reverse()
        Dim LastCharecter = ReversedArray(0).ToString

        If IsInArray(LastCharecter, MathematicalArray) Then
            InputTextBox.Text += " 5"
        Else
            InputTextBox.Text += "5"
        End If
    End Sub
    Private Sub InputButton6_Click(sender As Object, e As EventArgs) Handles InputButton6.Click
        Dim arr = InputTextBox.Text.ToCharArray
        Dim ReversedArray = arr.Reverse()
        Dim LastCharecter = ReversedArray(0).ToString

        If IsInArray(LastCharecter, MathematicalArray) Then
            InputTextBox.Text += " 6"
        Else
            InputTextBox.Text += "6"
        End If
    End Sub
    Private Sub InputButton7_Click(sender As Object, e As EventArgs) Handles InputButton7.Click
        Dim arr = InputTextBox.Text.ToCharArray
        Dim ReversedArray = arr.Reverse()
        Dim LastCharecter = ReversedArray(0).ToString

        If IsInArray(LastCharecter, MathematicalArray) Then
            InputTextBox.Text += " 7"
        Else
            InputTextBox.Text += "7"
        End If
    End Sub
    Private Sub InputButton8_Click(sender As Object, e As EventArgs) Handles InputButton8.Click
        Dim arr = InputTextBox.Text.ToCharArray
        Dim ReversedArray = arr.Reverse()
        Dim LastCharecter = ReversedArray(0).ToString

        If IsInArray(LastCharecter, MathematicalArray) Then
            InputTextBox.Text += " 8"
        Else
            InputTextBox.Text += "8"
        End If
    End Sub
    Private Sub InputButton9_Click(sender As Object, e As EventArgs) Handles InputButton9.Click
        Dim arr = InputTextBox.Text.ToCharArray
        Dim ReversedArray = arr.Reverse()
        Dim LastCharecter = ReversedArray(0).ToString

        If IsInArray(LastCharecter, MathematicalArray) Then
            InputTextBox.Text += " 9"
        Else
            InputTextBox.Text += "9"
        End If
    End Sub
    Private Sub InputButton0_Click(sender As Object, e As EventArgs) Handles InputButton0.Click
        Dim arr = InputTextBox.Text.ToCharArray
        Dim ReversedArray = arr.Reverse()
        Dim LastCharecter = ReversedArray(0).ToString

        If IsInArray(LastCharecter, MathematicalArray) Then
            InputTextBox.Text += " 0"
        Else
            InputTextBox.Text += "0"
        End If
    End Sub

    Private Sub InputButtonAdd_Click(sender As Object, e As EventArgs) Handles InputButtonAdd.Click
        InputTextBox.Text += " +"
    End Sub

    Private Sub InputButtonSubtract_Click(sender As Object, e As EventArgs) Handles InputButtonSubtract.Click
        InputTextBox.Text += " -"
    End Sub

    Private Sub InputButtonMultiply_Click(sender As Object, e As EventArgs) Handles InputButtonMultiply.Click
        InputTextBox.Text += " *"
    End Sub

    Private Sub InputButtonDivide_Click(sender As Object, e As EventArgs) Handles InputButtonDivide.Click
        InputTextBox.Text += " /"
    End Sub
    Private Sub InputButtonOpenParenthesis_Click(sender As Object, e As EventArgs) Handles InputButtonOpenParenthesis.Click
        InputTextBox.Text += " ("
    End Sub

    Private Sub InputButtonClosedParenthesis_Click(sender As Object, e As EventArgs) Handles InputButtonClosedParenthesis.Click
        InputTextBox.Text += " )"
    End Sub

    Private Sub InputButtonIndex_Click(sender As Object, e As EventArgs) Handles InputButtonIndex.Click
        InputTextBox.Text += " ^"
    End Sub
    Private Sub InputButtonCLR_Click(sender As Object, e As EventArgs) Handles InputButtonCLR.Click
        InputTextBox.Text = ""
    End Sub

    Private Sub EqualsButton_Click(sender As Object, e As EventArgs) Handles EqualsButton.Click

        Dim Input = InputTextBox.Text
        Dim PostfixString = ToPostfix(Input)
        Dim PostfixArray = PostfixString.Split(" ")
        Dim OutputStack = New Stack()

        For i As Int64 = 0 To PostfixArray.Length - 1
            If IsInArray(PostfixArray(i), MathematicalArray) Then
                Dim Val2 = OutputStack.Pop()
                Dim Val1 = OutputStack.Pop()
                Dim Output As Decimal
                If PostfixArray(i) = "+" Then
                    Output = Val1 + Val2
                End If
                If PostfixArray(i) = "-" Then
                    Output = Val1 - Val2
                End If
                If PostfixArray(i) = "*" Then
                    Output = Val1 * Val2
                End If
                If PostfixArray(i) = "/" Then
                    Output = Val1 / Val2
                End If
                If PostfixArray(i) = "^" Then
                    Output = Val1 ^ Val2
                End If
                OutputStack.Push(Output)
            Else
                Dim Value = Convert.ToInt32(PostfixArray(i))
                OutputStack.Push(Value)
            End If
        Next
        Dim EndValue = OutputStack.Pop()
        InputTextBox.Text = EndValue.ToString
        'Dim InputValueArray = Input.Split(MathematicalArray, StringSplitOptions.None)
        'Dim FunctionArray = Input.Split(InputValueArray, StringSplitOptions.RemoveEmptyEntries)
        'Dim OrderedInputArray = New String(InputValueArray.Length + FunctionArray.Length) {}
        'For j = 0 To FunctionArray.Length - 1
        'OrderedInputArray(j + 1) = FunctionArray(j)
        'OrderedInputArray(j + 2) = InputValueArray(j + 1)
        'Next
        'InputTextBox.Text = ""
        'For Each item In OrderedInputArray
        'InputTextBox.Text += item
        'Next
        'If Input.Contains("+") Then
        'Dim InputArray = Split(Input, "+")
        'Dim Value1 = Convert.ToInt64(InputArray(0))
        'Dim Value2 = Convert.ToInt64(InputArray(1))
        'Dim Result As Int64 = Value1 + Value2
        'InputTextBox.Text = Result
        'End If
        'If Input.Contains("-") Then
        'Dim InputArray = Split(Input, "-")
        'Dim Value1 = Convert.ToInt64(InputArray(0))
        'Dim Value2 = Convert.ToInt64(InputArray(1))
        'Dim Result As Int64 = Value1 - Value2
        'InputTextBox.Text = Result
        'End If
        'If Input.Contains("*") Then
        'Dim InputArray = Split(Input, "*")
        'Dim Value1 = Convert.ToInt64(InputArray(0))
        'Dim Value2 = Convert.ToInt64(InputArray(1))
        'Dim Result As Int64 = Value1 * Value2
        'InputTextBox.Text = Result
        'End If
        'If Input.Contains("/") Then
        'Dim InputArray = Split(Input, "/")
        'Dim Value1 = Convert.ToInt64(InputArray(0))
        'Dim Value2 = Convert.ToInt64(InputArray(1))
        'Dim Result As Int64 = Value1 / Value2
        'InputTextBox.Text = Result
        'End If
        'Dim MathematicalArray = New String() {"+", "-", "*", "/"}
        'Dim InputValueArray = Input.Split(MathematicalArray, StringSplitOptions.None)
        'Dim FunctionArray = Input.Split(InputValueArray, StringSplitOptions.RemoveEmptyEntries)

        'For i As Int16 = 1 To 4
        'If IsInArray("/", FunctionArray) = True Then
        'For j As Int16 = 0 To FunctionArray.Length - 1
        'If FunctionArray(j) = "/" Then
        'Dim Val1 = Convert.ToInt64(InputValueArray(j))
        'Dim Val2 = Convert.ToInt64(InputValueArray(j + 1))
        'Dim Result = Val1 / Val2
        'InputValueArray(j) = Result.ToString
        'End If
        'If j <> 0 Then
        '
        'End If
        'Next
        'End If
        'If IsInArray("*", FunctionArray) = True Then
        'For j As Int16 = 0 To FunctionArray.Length - 1
        'If FunctionArray(j) = "*" Then
        'Dim Val1 = Convert.ToInt64(InputValueArray(j))
        'Dim Val2 = Convert.ToInt64(InputValueArray(j + 1))
        'Dim Result = Val1 * Val2
        'InputTextBox.Text = Result
        'End If
        'Next
        'End If
        'Next

    End Sub
End Class
Class SymbolType
    Public ReadOnly symbol As String
    Public ReadOnly precedence As Integer
    Public ReadOnly rightAssociative As Boolean

    Public Sub New(symbol As String, precedence As Integer, rightAssociative As Boolean)
        Me.symbol = symbol
        Me.precedence = precedence
        Me.rightAssociative = rightAssociative
    End Sub
End Class