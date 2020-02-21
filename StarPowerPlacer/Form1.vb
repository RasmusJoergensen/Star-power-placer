Public Class MainForm

    '////////////////////////////////////////////
    'For calculations for the visual presentation
    Dim spMeasureSpacing As Double
    Dim TS_Top As Integer
    Dim TS_Bot As Integer
    Dim bpm As Double
    Dim seconds As Double
    '////////////////////////////////////////////

    Dim chartPath As String
    Dim writer As System.IO.StreamWriter


    Private Sub BtnChooseChartFile_Click(sender As Object, e As EventArgs) Handles BtnChooseChartFile.Click
       
        '/////////////////////////////////////////////
        'For when the user choses the chart file
        '
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.Filter = "chart files (*.chart)|*.chart" '|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 1 'select first file type (.txt) as default

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            chartPath = openFileDialog1.FileName
            LabelSong.Text = getSongName(chartPath)
        End If
    End Sub

    Private function getSongName(path As String)
        '/////////////////////////////////////////////
        'Get the name of the song from reading the ini

        Dim songName As String = ""
        'First figure out the folder
        'cut away the chart file in the path
        Dim cutPointPath As Integer = InStrRev(path, "\") 
        Dim folderPath As String = Microsoft.VisualBasic.Left(path, cutPointPath)

        'Then read the ini in the folder
        Dim iniText() As String = System.IO.File.ReadAllLines(folderPath + "song.ini")
        For i As Integer = 0 To iniText.Length
            If not InStr(iniText(i), "name") = 0 ' If "name" is in the line
                Dim cutPointName As Integer = InStrRev(iniText(i), "=") 'Get the amount of characters after the =
                songName = Trim(Microsoft.VisualBasic.Right(iniText(i), Len(iniText(i)) - cutPointName)) 'Set the song name to be that amount of characters from the right in the line
                Return songName
            End If
        Next
    Return songName
    End Function

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelSong.Text = ""
    End Sub


    '////////////////////////////////////////////////////////////////////////////////////////////////////
    'Star Power calculations for the visual presentation
    Private Sub SPNumericBPM_TextChanged(sender As Object, e As EventArgs) Handles SP_TextBPM.TextChanged
        
        If not (IsNumeric(SP_TextBPM.Text))
            Return
        Else
            bpm = SP_TextBPM.Text
        End If

        If (bpm <> 0 And spMeasureSpacing <> 0 And TS_Top <> 0)
            calculate_StarPowerDistance()
        End If
    End Sub

     Private Sub SPNumericMeasureSpacing_ValueChanged(sender As Object, e As EventArgs) Handles SP_NumericMeasureSpacing.TextChanged

        spMeasureSpacing = SP_NumericMeasureSpacing.Value

        If (bpm <> 0 And (IsNumeric(SP_TextBPM.Text)) And spMeasureSpacing <> 0 And TS_Top <> 0)
            calculate_StarPowerDistance()
        End If
    End Sub
    
    Private Sub SP_TimesigTop_ValueChanged(sender As Object, e As EventArgs) Handles SP_TimesigTop.TextChanged

        If SP_TimesigTop.Value = 0
            SP_TimesigTop.Value = 1
        End If

        TS_Top = SP_TimesigTop.Value

        If (bpm <> 0 And spMeasureSpacing <> 0 And TS_Top <> 0)
            calculate_StarPowerDistance()
        End If
    End Sub

     private sub calculate_StarPowerDistance()

        seconds = Math.Round(((60 / bpm) * spMeasureSpacing) * TS_Top, 3)

        If  (Convert.ToDouble(SP_TextSeconds.Text) <> seconds)
            SP_TextSeconds.Text = seconds
        End If

    End Sub
    '////////////////////////////////////////////////////////////////////////////////////////////////////

    '////////////////////////////////////////////////////////////////////////////////////////////////////
    'Star power calculations for the chart file

    Private Sub Btn_SP_Click(sender As Object, e As EventArgs) Handles Btn_SP.Click

        Dim chartFile() As String = System.IO.File.ReadAllLines(chartPath) 'Store the original file for backup

        'Try
            writeStarPower(chartFile)
        'Catch ex As Exception
        '    MsgBox("Something went wrong :(" & vbNewLine & vbNewLine & "Error message: """ & ex.Message & """")
        '    writer.Close()
        '    System.IO.File.WriteAllLines(chartPath, chartFile) 'Write the backup to the file
        'End Try
    End Sub

    Private Sub writeStarPower(chartText() As String)

        writer = My.Computer.FileSystem.OpenTextFileWriter(chartPath, False)

        'Set the tick number for the first SP phrase
        Dim tick_nextSPStart = spMeasureSpacing * 768

        Dim tick_SPLength = getSPLength()

        'Get the measure space in ticks
        'One measure is always 768 ticks
        Dim tick_measureSpace = spMeasureSpacing * 768

        'Get the line at which the expert chart starts
        Dim startLine As Integer = getStartLine(chartText, "ExpertSingle")

        'We don't change the beginning
        'Write it just as it was originally
        For i As Integer = LBound(chartText) To startLine - 1
             writer.WriteLine(chartText(i))
        Next i

        '////////////////////////////////////////////////////////
        'Go through the expert chart and add starpower
        For i As Integer = startLine To UBound(chartText)

            If stringOnLine(chartText, i, "}") 'If we reached the end of the chart of the specific difficulty which is denoted by a '}'
                writer.WriteLine(chartText(i))
                Exit For
            End If

            'All lines we get will look like this "x = N a b"
            'With 
            'x = number from 0 to inf (the tick number)
            'N = the letter N
            'a = a number from 0 to 6
            'b = a number from 0 to 6
            
            'Get the current tick for the current line
            Dim cutPointTick As Integer = InStr(chartText(i), "=") - 1 'Get the amount of characters before the equal sign
            Dim a As String = Trim(Microsoft.VisualBasic.Left(chartText(i), cutPointTick))
            Dim currentTick As Integer = Convert.toInt32(Trim(Microsoft.VisualBasic.Left(chartText(i), cutPointTick))) 'Set the tick number to be that amount of characters from the left to the empty space

            If currentTick > tick_nextSPStart
                'Insert a star power before writing the next line
                writer.WriteLine("  " & tick_nextSPStart & " = S 2 " & tick_SPLength)
                tick_nextSPStart += tick_measureSpace
            End If
            writer.WriteLine(chartText(i))
        Next i

        writer.Close()

    End Sub

    Private function getSPLength()
        '///////////////////////////////////////////////////
        'Return the length of the star power phrase in ticks

        Return 768 * 2
    End Function

    Private Function getStartLine(chartText() As String, difficulty As String)

        '////////////////////////////////////////////////////////
        'Find the line at which the 'difficulty' chart starts
        For i As Integer = LBound(chartText) To UBound(chartText)

            If not stringOnLine(chartText, i, difficulty)
                Continue for
            else
                Return i + 2
            End If
        Next i
        Return 0
    End Function

    Private Function stringOnLine(text() As string, lineNo As Integer, target As String)

        If InStr(text(lineNo), target) <> 0
            Return True
        End If
        Return False
    End Function
    '////////////////////////////////////////////////////////////////////////////////////////////////////
End Class
