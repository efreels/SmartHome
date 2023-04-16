Public Class frmSmartHome
    Private _intArraySize As Integer = 11
    Private _strSavings(_intArraySize) As String
    Private _decBill(_intArraySize) As Decimal

    Private Sub frmSmartHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnDisplay.Visible = False
        lblMonthlyAverage.Visible = False
        lblSignificant.Visible = False
        lblTotalSavings.Visible = False

        Dim objReader As IO.StreamReader
        Dim strSavingsAmount As String
        Dim intCount As Integer = 0
        Dim intFill As Integer

        lblTotalSavings.Text = ""
        lblMonthlyAverage.Text = ""
        lblSignificant.Text = ""

        If IO.File.Exists("C:\VB\savings.txt") = True Then
            objReader = IO.File.OpenText("C:\VB\savings.txt")
            Do While objReader.Peek <> -1
                _strSavings(intCount) = objReader.ReadLine()
                strSavingsAmount = objReader.ReadLine()
                _decBill(intCount) = Convert.ToDecimal(strSavingsAmount)
                intCount += 1
            Loop
            objReader.Close()

            For intFill = 0 To (_strSavings.Length - 1)
                cboMonth.Items.Add(_strSavings(intFill))
            Next
        Else
            MsgBox("The file is not available.  Restart the program when the file is available",, "Error")
            Close()
        End If
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ComputeAverage()
        ComputeMaxSavings()
        lblSignificant.Visible = True
        lblMonthlyAverage.Visible = True
    End Sub

    Private Sub cboMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonth.SelectedIndexChanged
        Dim intSelectedMonth As Integer

        intSelectedMonth = cboMonth.SelectedIndex
        lblTotalSavings.Text = "The electric savings for " & _strSavings(intSelectedMonth) & " is $" & _decBill(intSelectedMonth).ToString()
        btnDisplay.Visible = True
        lblTotalSavings.Visible = True
    End Sub

    Private Sub ComputeMaxSavings()
        Dim intMonths As Integer
        Dim intLargestSavings As Integer = 0
        Dim intIndexValue As Integer
        Dim strYearValue As String = ""

        For Each intMonths In _decBill
            intLargestSavings = Math.Max(intLargestSavings, intMonths)
            If (intMonths >= intLargestSavings) Then
                strYearValue = _strSavings(intIndexValue)
            End If
            intIndexValue += 1
        Next
        lblSignificant.Text = strYearValue & " had the most significant monthly savings."
    End Sub

    Private Sub ComputeAverage()
        Dim intCountYears As Integer
        Dim intYears As Integer = 0
        Dim decTotal As Decimal = 0
        Dim decAverage As Decimal = 0D

        For Each intCountYears In _decBill
            decTotal += _decBill(intYears)
            intYears += 1
        Next
        decAverage = decTotal / Convert.ToDecimal(_decBill.Length())
        lblMonthlyAverage.Text = "The average monthly savings: " & decAverage.ToString("C2")
    End Sub
End Class
