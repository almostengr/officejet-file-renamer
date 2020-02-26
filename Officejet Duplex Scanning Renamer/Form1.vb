Imports System.IO

Public Class Form1

    Dim dirPath As String = ""
    Dim numberOfFiles As Integer = 0
    Dim removeoriginal As Boolean = False

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        programStatusUpdate("Starting K Ram Duplex Scan File Renamer." + vbCrLf + _
        "Visit K Ram Computers at http://krcomputers.bravehost.com/kramscan" + vbCrLf + _
        "If you like this program please visit the website above and donate." + _
        vbCrLf + vbCrLf + _
        "STEP 1) Select the folder you wish to import your scanned images from. " + vbCrLf + _
        "Scanned images must be in 'JPG' format." + vbCrLf + _
        "STEP 2) Click the 'Rename Files' button" + vbCrLf + _
        "STEP 3) Open the containing folder to view your files.")

        RenameFilesButton.Enabled() = False
        OpenFolderButton.Enabled() = False
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        programStatusUpdate("Closing K Ram Duplex Scan File Renamer.")
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RenameFilesButton.Click

        Dim newFileName As String
        Dim midPoint As Integer
        Dim scanNumber As Integer = 1
        Dim counter As Integer = 0
        Dim evenFirstRun As Boolean = True

        If dirPath = "" Then
            'IF USER DOES NOT SELECT A DIRECTORY, THEN SHOW ERROR MESSAGE
            programStatusUpdate("ERROR! No directory selected. Please select a directory that contains the scanned files.")
        Else
            RenameFilesButton.Enabled = False

            Dim dirListing As New IO.DirectoryInfo(dirPath)
            Dim fileListing As IO.FileInfo
            Dim fileListingInfo As IO.FileInfo() = dirListing.GetFiles("*.jpg")

            If numberOfFiles > 0 Then
                ''IF AT LEAST ONE FILE IS FOUND, THEN START THE RENAMING PROCESS

                numberOfFiles = 0
                For Each fileListing In fileListingInfo
                    'COUNT THE NUMBER OF FILES IN THE DIRECTORY
                    numberOfFiles = numberOfFiles + 1
                Next

                midPoint = numberOfFiles / 2    'FIND THE MIDPOINT OF FILES
                programStatusUpdate("File renaming started. Here we go!")

                For Each fileListing In fileListingInfo

                    If counter < midPoint Then
                        'IF MIDPOINT HAS NOT BEEN PASSED

                        newFileName = dirPath + "\ScanDoc" + scanNumber.ToString + ".jpg"
                        renameFile(fileListing.FullName, newFileName)
                        scanNumber = scanNumber + 2     'INCREASE SCAN NUMBER
                        counter = counter + 1        'INCREMENT FILE COUNTER

                    ElseIf counter >= midPoint Then 'IF MIDPOINT HAS BEEN PASSED 

                        If evenFirstRun = True Then
                            'IF THIS IS THE FIRST RUN THEN CHANGE SCAN NUMBER FOR EVEN PAGES
                            scanNumber = numberOfFiles
                            evenFirstRun = False
                        End If

                        newFileName = dirPath + "\ScanDoc" + scanNumber.ToString + ".jpg"

                        renameFile(fileListing.FullName, newFileName)   'RENAME FILE

                        scanNumber = scanNumber - 2 'REDUCE SCAN NUMBER
                        counter = counter + 1    'INCREMENT FILE COUNTER 
                    End If
                Next

                programStatusUpdate("File renaming completed. End of the ride!")
            Else
                'IF NO FILES ARE FOUND
                programStatusUpdate("No files were found. :D")
            End If
        End If

    End Sub

    Public Sub programStatusUpdate(ByRef messageText)
        'UPDATE STATUS BOX WITH TIME AND INFO MESSAGE
        ProgramStatus.Text += DateAndTime.TimeOfDay() + ": " + messageText + vbCrLf
        ProgramStatus.SelectionStart = Len(ProgramStatus.Text)
        ProgramStatus.ScrollToCaret()
    End Sub

    Public Sub renameFile(ByRef originalFile, ByRef newFile)
        'COPY FILE AND UPDATE STATUS
        Try
            My.Computer.FileSystem.CopyFile(originalFile, newFile)
            programStatusUpdate("Renaming '" + originalFile + "' to '" + newFile + "'.")

            If removeoriginal = True Then
                My.Computer.FileSystem.DeleteFile(originalFile)
                programStatusUpdate("Deleting '" + originalFile + "'.")
            End If
        Catch ex As Exception
            programStatusUpdate("ERROR! An existing file already exists with the current name.")
        End Try
    End Sub

    Private Sub SelectFolder_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectFolder_Button.Click
        Try
            FolderBrowserDialog1.ShowDialog()
            dirPath = FolderBrowserDialog1.SelectedPath

            Dim dirListing As New IO.DirectoryInfo(dirPath)
            Dim fileListing As IO.FileInfo
            Dim fileListingInfo As IO.FileInfo() = dirListing.GetFiles("*.jpg")
            numberOfFiles = 0
            For Each fileListing In fileListingInfo
                'COUNT THE NUMBER OF FILES IN THE DIRECTORY
                numberOfFiles = numberOfFiles + 1
            Next

            If dirPath <> "" Then
                programStatusUpdate("The directory '" + dirPath + "' was selected. " + _
                                    numberOfFiles.ToString + " files were found.")
                OpenFolderButton.Enabled = True

                If numberOfFiles <> 0 Then
                    RenameFilesButton.Enabled = True
                End If

            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub OpenFolderButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenFolderButton.Click
        Process.Start("explorer.exe", dirPath)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim aboutInfo As New AboutBox1
        aboutInfo.Show()
    End Sub

    Private Sub DevelopersWebsiteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevelopersWebsiteToolStripMenuItem.Click
        Process.Start("http://krcomputers.bravehost.com/kramscan")
    End Sub

    Private Sub DonateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("http://krcomputers.bravehost.com/kramscan")
    End Sub

    Private Sub DonateLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles DonateLabel.LinkClicked
        Process.Start("http://krcomputers.bravehost.com/kramscan")
    End Sub

    Private Sub HowDoIUseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HowDoIUseToolStripMenuItem.Click
        Process.Start("help.html")
    End Sub

    Private Sub RemoveOriginalScansWhenFinishedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveOriginalScansWhenFinishedToolStripMenuItem.Click
        If removeoriginal = False Then
            removeoriginal = True
        Else
            removeoriginal = False
        End If
    End Sub

    Private Sub CutePDFWriterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutePDFWriterToolStripMenuItem.Click
        Process.Start("http://www.cutepdf.com/Products/CutePDF/writer.asp")
    End Sub

    Private Sub ClearLogToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearLogToolStripMenuItem.Click
        ProgramStatus.Clear()
        programStatusUpdate("Visit K Ram Computers at http://krcomputers.bravehost.com/kramscan")
    End Sub
End Class
