Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Linq

Namespace DxAccordionGettingStarted
    Public Class MainWindowViewModel
        Public Sub New()

            Dim employeeDepartments_Renamed = Stuff.GetStuff().GroupBy(Function(x) x.Department).Select(Function(x) New EmployeeDepartment(x.Key, x.ToArray()))
            EmployeeDepartments = New ObservableCollection(Of EmployeeDepartment)(employeeDepartments_Renamed.ToArray())
        End Sub
        Public Property EmployeeDepartments() As ObservableCollection(Of EmployeeDepartment)
    End Class

    Public Class EmployeeDepartment
        Public Property Name() As String
        Public Property Employees() As ObservableCollection(Of Employee)

        Public Sub New(ByVal name As String, ByVal employees As IEnumerable(Of Employee))
            Me.Name = name
            Me.Employees = New ObservableCollection(Of Employee)(employees)
        End Sub
        Public Overrides Function ToString() As String
            Return Name
        End Function
    End Class
End Namespace
