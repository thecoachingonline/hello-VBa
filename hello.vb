Imports System.Security.Cryptography
Imports System.Text

Module Module1

    Sub Main()
        Dim message As String = "สวัสดี ชาวโลก"
        Dim hashValue As Byte()

        Using hash As HashAlgorithm = SHA256.Create()
            hashValue = hash.ComputeHash(Encoding.UTF8.GetBytes(message))
        End Using

        Console.WriteLine("ข้อความรหัส: ")
        For Each b As Byte In hashValue
            Console.Write($"{b:x2}")
        Next
    End Sub

End Module