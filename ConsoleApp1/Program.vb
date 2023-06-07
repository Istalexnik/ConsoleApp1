Imports System

Module Program

    Public Function CountChars(input As String) As Dictionary(Of Char, Integer)
        Dim charCount As New Dictionary(Of Char, Integer)

        For Each c As Char In input
            If charCount.ContainsKey(c) Then
                charCount(c) += 1
            Else
                charCount(c) = 1
            End If
        Next
        Return charCount
    End Function

    'Dim charCount As Dictionary(Of Char, Integer) = CountChars(Hello, World!)
    'For Each kvp As KeyValuePair(Of Char, Integer) In charCount
    '    Console.WriteLine(kvp.Key & " " & kvp.Value)
    'Next

    Public Function FindNonDuplicateChars(input As String) As List(Of Char)
        Dim nonMatchingChars As New List(Of Char)
        Dim charCount As New Dictionary(Of Char, Integer)

        For Each c As Char In input
            If charCount.ContainsKey(c) Then
                charCount(c) += 1
            Else
                charCount(c) = 1
            End If
        Next

        For Each kvp As KeyValuePair(Of Char, Integer) In charCount
            If kvp.Value = 1 Then
                nonMatchingChars.Add(kvp.Key)
            End If
        Next

        Return nonMatchingChars.Distinct().ToList()
    End Function

    'Console.WriteLine(String.Join(", ", FindNonDuplicateChars("Kapusta")))

    Public Function FindDuplicateChars(input As String) As List(Of Char)
        Dim duplicatedChars As New List(Of Char)
        Dim charCount As New Dictionary(Of Char, Integer)

        For Each c As Char In input
            If charCount.ContainsKey(c) Then
                duplicatedChars.Add(c)
            Else
                charCount(c) = 1
            End If
        Next

        Return duplicatedChars.Distinct().ToList()
    End Function

    'Console.WriteLine(String.Join(", ", FindDuplicateChars("Kapusta")))

    Function GetMatchingCharacters(str As String, referenceChars As String) As List(Of Char)
        Dim matchingChars As New List(Of Char)

        For Each c As Char In str
            If referenceChars.Contains(c) Then
                matchingChars.Add(c)
            End If
        Next

        Return matchingChars.Distinct().ToList()
    End Function

    'Console.WriteLine(String.Join(", ", GetMatchingCharacters("Kapusta", "Bananyta")))

    Function GetNonMatchingCharacters(str As String, referenceChars As String) As List(Of Char)
        Dim nonMatchingChars As New List(Of Char)

        For Each c As Char In str
            If Not referenceChars.Contains(c) Then
                nonMatchingChars.Add(c)
            End If
        Next

        Return nonMatchingChars.Distinct().ToList()
    End Function

    'Console.WriteLine(String.Join(", ", GetNonMatchingCharacters("Kapusta", "Bananyta")))

    Function ReverseString(str As String) As String
        Dim charString As Char() = str.ToCharArray()
        Array.Reverse(charString)
        Return New String(charString)
        'Return New String(input.Reverse().ToArray())
    End Function

    'Console.WriteLine(ReverseString("Hello"))

    Function IsPalindrome(str As String) As Boolean
        'str = str.ToLower()
        Dim left = 0
        Dim right = str.Length - 1
        While left < right
            If str(left) <> str(right) Then
                Return False
            End If
            left += 1
            right -= 1
        End While
        Return True
    End Function

    'Console.WriteLine(IsPalindrome("Madam"))

    Function IsLeapYear(year As Integer) As Boolean
        Return year Mod 4 = 0 AndAlso (year Mod 100 <> 0 OrElse year Mod 400 = 0)
    End Function

    'Console.WriteLine(IsLeapYear(2024))

    Sub Main(args As String())
        Console.WriteLine(String.Join(", ", FindNonDuplicateChars("Kapusta")))

    End Sub



End Module
