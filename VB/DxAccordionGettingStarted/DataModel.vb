Imports System.Collections.Generic

Namespace DxAccordionGettingStarted

    Public Class Employee

        Public Property ID As Integer

        Public Property Name As String

        Public Property Position As String

        Public Property Department As String

        Public Overrides Function ToString() As String
            Return Name
        End Function
    End Class

    Public Module Staff

        Public Function GetStaff() As List(Of Employee)
            Dim employees As List(Of Employee) = New List(Of Employee)()
            employees.Add(New Employee() With {.ID = 1, .Name = "Gregory S. Price", .Department = "Management", .Position = "President"})
            employees.Add(New Employee() With {.ID = 2, .Name = "Irma R. Marshall", .Department = "Marketing", .Position = "Vice President"})
            employees.Add(New Employee() With {.ID = 3, .Name = "John C. Powell", .Department = "Operations", .Position = "Vice President"})
            employees.Add(New Employee() With {.ID = 4, .Name = "Christian P. Laclair", .Department = "Production", .Position = "Vice President"})
            employees.Add(New Employee() With {.ID = 5, .Name = "Karen J. Kelly", .Department = "Finance", .Position = "Vice President"})
            employees.Add(New Employee() With {.ID = 6, .Name = "Brian C. Cowling", .Department = "Marketing", .Position = "Manager"})
            employees.Add(New Employee() With {.ID = 7, .Name = "Thomas C. Dawson", .Department = "Marketing", .Position = "Manager"})
            employees.Add(New Employee() With {.ID = 8, .Name = "Angel M. Wilson", .Department = "Marketing", .Position = "Manager"})
            employees.Add(New Employee() With {.ID = 9, .Name = "Bryan R. Henderson", .Department = "Marketing", .Position = "Manager"})
            employees.Add(New Employee() With {.ID = 10, .Name = "Harold S. Brandes", .Department = "Operations", .Position = "Manager"})
            employees.Add(New Employee() With {.ID = 11, .Name = "Michael S. Blevins", .Department = "Operations", .Position = "Manager"})
            employees.Add(New Employee() With {.ID = 12, .Name = "Jan K. Sisk", .Department = "Operations", .Position = "Manager"})
            employees.Add(New Employee() With {.ID = 13, .Name = "Sidney L. Holder", .Department = "Operations", .Position = "Manager"})
            employees.Add(New Employee() With {.ID = 14, .Name = "James L. Kelsey", .Department = "Production", .Position = "Manager"})
            employees.Add(New Employee() With {.ID = 15, .Name = "Howard M. Carpenter", .Department = "Production", .Position = "Manager"})
            employees.Add(New Employee() With {.ID = 16, .Name = "Jennifer T. Tapia", .Department = "Production", .Position = "Manager"})
            employees.Add(New Employee() With {.ID = 17, .Name = "Judith P. Underhill", .Department = "Finance", .Position = "Manager"})
            employees.Add(New Employee() With {.ID = 18, .Name = "Russell E. Belton", .Department = "Finance", .Position = "Manager"})
            Return employees
        End Function
    End Module
End Namespace
