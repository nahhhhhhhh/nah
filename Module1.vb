Module Module1

    Sub Main(args As String())
        Dim Track As Integer
        Dim Album(0 To 12) As String
        Dim Song As String
        For counter = 1 To 12
            Album(0) = "Smells Like Teen Spirit"
            Album(1) = "In Bloom"
            Album(2) = "Come As You Are"
            Album(3) = "Breed"
            Album(4) = "Lithium"
            Album(5) = "Polly"
            Album(6) = "Territorial Pissings"
            Album(7) = "Drain You"
            Album(8) = "Lounge Act"
            Album(9) = "Stay Away"
            Album(10) = "On A Plain"
            Album(11) = "Something In The Way"
            Album(12) = "Endless, Nameless"
            Console.WriteLine("Enter the number of the track (1-12) : ")
            Track = Console.ReadLine()
            Track = Track - 1
            Song = Album(Track)
            Track = Track + 1
            Console.WriteLine("Track " & Track & " Is " & Song)
        Next
        Console.ReadLine()
    End Sub

End Module
