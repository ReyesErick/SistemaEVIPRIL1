Public Class HTMLHelpClass
    Shared Function GetLocalHelpFileName(ByVal FileName As String) As String
        Dim ExName, DirName, HelpFileName As String
        ExName = Environment.GetCommandLineArgs(0)
        DirName = System.IO.Path.GetDirectoryName(ExName)
        HelpFileName = DirName + "\" + FileName
        Return HelpFileName
    End Function
End Class
