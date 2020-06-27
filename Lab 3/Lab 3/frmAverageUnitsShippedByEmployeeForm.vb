'Name: Dakota Parrish
'Student Number: 100764512
'Program Name: Average Units Shipped By Employee
'Date: June 26, 2020
'Description: This program is a continuation of 'AvgUnitsShipped' form which allowed for entry of 7 days of units to be entered one by one. In this continuation
'the company decided to find out the average units shipped for each employee. This program allows for 21 total units to be entered, 7 for each employee. For each 
'employee, once all 7 days have been entered, it will calculate the average for that employee. This repeats for the other two employees. Once all 3 employees
'have entered their units for all 7 days, the company average is totaled and displayed to the user. Each entry is validated for range, blank input, and non
'numeric data with a message for each instance. You can reset the form, enter units and close the form through the usage of 3 buttons. 

Option Strict On

Public Class frmAvgUnitsShippedByEmployee

#Region "Variable Declarations"
    Dim employees(2, 6) As Integer 'Declare employees as a two dimensional array with elements of 2 and 6.
    Dim currentDay As Integer = 0 'Declare the current day variale as an integer and initialize the value of 0.
    Dim currentEmployeeNumber As Integer = 0 'Declare the current employee numbers' units being shipped as an integer and set it as 0. 
    Dim avgTotal As Double 'Declare the average total as a double.
    Dim runningTotal As Integer 'Declare the running total as an integer.
    Dim employeeDisplay(2) As TextBox 'Declare a textbox array as a textbox with 3 elements. These are used to assign the textboxes on the form respectively.
    Dim averageLabels(3) As Label 'Declare a label array as a textbox with 4 elements. These are used to assign the labels on the form respectively.
    Dim companyAverage As Double 'Declare the company average variable as a double.
#End Region


#Region "Event Handlers"

    'Event Handlers'
    ''' <summary>
    ''' The ButtonEnterClick event handler handles the input from the user. Whenever the user enters the employees units number, it is validated and if valid
    ''' adds it to the average for the employee, company average, and the running total for the employee. Once all 21 units have been entered, split up by 7
    ''' per employee, the company average is displayed to the user. 
    ''' </summary>
    Private Sub ButtonEnterClick(sender As Object, e As EventArgs) Handles btnEnter.Click

        'If the currentEmployeeNumber is less than 4.
        If currentEmployeeNumber < 4 Then
            'If the currentDay is less than 7.
            If currentDay < 7 Then
                'First, checks if the units entered number is a whole number for whichever employee.
                If Integer.TryParse(txtInput.Text, employees(currentEmployeeNumber, currentDay)) Then

                    'Checks to see if number entered is within the range of 0-5000.
                    If employees(currentEmployeeNumber, currentDay) >= 0 And employees(currentEmployeeNumber, currentDay) <= 5000 Then

                        'The unit number entered is within the range.
                        'The number entered for units is appended to the input display textbox.
                        FindDisplay().AppendText(employees(currentEmployeeNumber, currentDay) & Environment.NewLine)
                        'Clears the text box for input.
                        txtInput.Clear()
                        'Sets focus on the input text box so the user can type in another number.
                        txtInput.Focus()
                        'Adds the units entered to the average total for whichever employee.
                        runningTotal += employees(currentEmployeeNumber, currentDay)
                        'We increment the day number variable by one.
                        currentDay = currentDay + 1
                        'Changes the label to display and keep track of the day number for the user as they are entering units.
                        lblDays.Text = "Day " & (currentDay + 1)

                        'If the day number is equal to 7.
                        If currentDay = 7 Then
                            'Set the text for the days label to say 'Day 7'
                            lblDays.Text = "Day 1"
                            'Calculates the average total by taking the running total and dividing it by 7 to give the average number for the employee.
                            avgTotal = runningTotal / 7
                            'Displays the average units per day and rounds it to 2 decimal places.
                            FindLabel().Text = "Average:" & CStr(Math.Round(avgTotal, 2))
                            'Adds the avgTotal for whichever employee to the companyAverage variable.
                            companyAverage += avgTotal
                            'Increments the employee number by 1 to start entering the next set of 7 units for the next employee.
                            currentEmployeeNumber += 1
                            'Reset the currentDay value to 0.
                            currentDay = 0
                            'Reset the avgTotal value to 0.
                            avgTotal = 0
                            'Reset the runningTotal value to 0.
                            runningTotal = 0

                            'If the currentEmployeeNumber is equal to 3.
                            If currentEmployeeNumber = 3 Then
                                'Set the text for the days label to say 'Done'.
                                lblDays.Text = "Done"
                                'Sets the ReadOnly property of the input textbox to true so the user can not enter any more numbers.
                                txtInput.ReadOnly = True
                                'Sets the Enabled property of the enter button to false so the user can't hit the enter button anymore.
                                btnEnter.Enabled = False
                                'Calculates the company average value by dividing the company average variable by 3.
                                companyAverage = companyAverage / 3
                                'Displays the average units per day and rounds it to 2 decimal places.
                                lblCompanyAverage.Text = "Average per day:" & CStr(Math.Round(companyAverage, 2))
                                'Sets the employee number back to 0.
                                currentEmployeeNumber = 0
                            End If
                        End If
                    Else
                        'The unit numbered entered is NOT within the range.
                        MessageBox.Show("The number entered must be between the range of 0-5000!")
                        'Focuses the input text box for re-entry.
                        txtInput.Focus()
                    End If
                Else
                    'The number entered was not a whole number!
                    MessageBox.Show("The number entered must be a whole number.")
                    'Focuses the input text box for re-entry.
                    txtInput.Focus()
                End If
            End If
        End If
    End Sub
    ''' <summary>
    ''' The ResetButtonClick event handler handles resetting the form to it's default state. Whenever the user clicks on the reset button, the form will 
    ''' call the ResetForm() method which clears all textboxes and output labels as well as re-enables the enter button and the input textbox. The input textbox
    ''' is also focused once the reset button is clicked.
    ''' </summary>
    Private Sub ResetButtonClick(sender As Object, e As EventArgs) Handles btnReset.Click
        'Calls the ResetForm() sub procedure.
        Call ResetForm()
    End Sub
    ''' <summary>
    ''' The ExitButtonClick event handler handles closing the form. Whenever the user clicks on the exit button, it will gracefully close the form.
    ''' </summary>
    Private Sub ExitButtonClick(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the form.
        Application.Exit()
    End Sub

    ''' <summary>
    ''' The FormAverageUnitsShippedByEmployeeLoad event handler handles the action whenever the form loads up. This event handler calls the AssignedDisplays() 
    ''' sub procedure which assigns the textboxes and output labels to it's respective location.
    ''' </summary>
    Private Sub FormAverageUnitsShippedByEmployeeLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        'Calls the PopulateArrays() sub procedure.
        Call AssignedDisplays()
    End Sub
#End Region

#Region "Sub Procedures"

    'Sub Procedures'
    ''' <summary>
    ''' The AssignedDisplays() sub procedure assigns each array element to it's respective form control. The employeeDisplay's array elements are assigned 
    ''' to the employees units entered display textboxes. The averageLabels' array elements are assigned to the average for each 
    ''' employee as well as the company's average output label.
    ''' </summary>
    Public Sub AssignedDisplays()
        'Sets the first element of the textbox array to the first employee display textbox.
        employeeDisplay(0) = txtEmployee1Display
        'Sets the second element of the textbox array to the second employee display textbox.
        employeeDisplay(1) = txtEmployee2Display
        'Sets the third element of the textbox array to the third employee display textbox.
        employeeDisplay(2) = txtEmployee3Display
        'Sets the first element of the label array to the employee 1 average label.
        averageLabels(0) = lblAverageUnitsEmp1
        'Sets the second element of the label array to the employee 2 average label.
        averageLabels(1) = lblAverageUnitsEmp2
        'Sets the third element of the label array to the employee 3 average label.
        averageLabels(2) = lblAverageUnitsEmp3
        'Sets the fourth element of the label array to the company average label.
        averageLabels(3) = lblCompanyAverage

    End Sub
    ''' <summary>
    ''' The ResetForm() sub procedure resets the windows form back to it's default state. It clears and sets the average values back to 0 as well as clears all
    ''' employee display textboxes along with the output labels. It also sets the focus back to the input textbox for re-entry of data.
    ''' </summary>

    Public Sub ResetForm()
        'Sets the company average value to 0.
        companyAverage = 0
        'Sets the days label text to Day 1.
        lblDays.Text = "Day 1"
        'Sets the ReadOnly property of the input textbox to false.
        txtInput.ReadOnly = False
        'Sets the Enabled property of the enter button to true.
        btnEnter.Enabled = True

        'Resets the employee number and the day number back to it's default values.
        For employee As Integer = 0 To 1
            For day As Integer = 0 To 6
                employees(employee, day) = 0
            Next
        Next

        For Each textbox As TextBox In employeeDisplay
            textbox.Clear()
        Next

        For Each label As Label In averageLabels
            label.Text = String.Empty
        Next
        'Sets the focus back to the input textbox.
        txtInput.Focus()
    End Sub
#End Region

#Region "Functions"

    'Functions'

    ''' <summary>
    ''' The FindDisplay() function finds and returns the employee's numbers to it's respective display textbox.
    ''' </summary>
    Public Function FindDisplay() As TextBox
        'If the current employee number is 0
        If currentEmployeeNumber = 0 Then
            'Assigns the employee 1 display textbox.
            Return txtEmployee1Display
            'Else If the current employee number is 1
        ElseIf currentEmployeeNumber = 1 Then
            'Assigns the employee 2 display textbox.
            Return txtEmployee2Display
            'Else If the current employee number is 2
        ElseIf currentEmployeeNumber = 2 Then
            'Assigns the employee 3 display textbox.
            Return txtEmployee3Display
        End If
    End Function
    ''' <summary>
    ''' The FindLabel() function finds and returns the employee's numbers to it's respective average output label as well as the company's average output label.
    ''' </summary>
    Public Function FindLabel() As Label
        'If the current employee number is 0.
        If currentEmployeeNumber = 0 Then
            'Assigns the employee 1 average label.
            Return lblAverageUnitsEmp1
            'If the current employee number is 1.
        ElseIf currentEmployeeNumber = 1 Then
            'Assigns the employee 2 average label.
            Return lblAverageUnitsEmp2
            'If the current employee number is 2.
        ElseIf currentEmployeeNumber = 2 Then
            'Assigns the employee 3 average label.
            Return lblAverageUnitsEmp3
            'If the current employee number is 3.
        ElseIf currentEmployeeNumber = 3 Then
            'Assigns the company average label.
            Return lblCompanyAverage
        End If
    End Function
#End Region
End Class
