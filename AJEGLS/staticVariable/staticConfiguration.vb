Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Module staticConfiguration
    Dim myServer As String = "JOHN\MULA"
    Dim dbAse As String = "JournalEntry"
    Dim UpName As String = "sa"
    Dim Pass As String = "mula"

    Public Function dbconn(ByVal myServer As String)

        Dim con As New SqlConnection("Data Source='" & myServer & "';Initial Catalog='" & dbAse & "';User ID='" & UpName & "';Password='" & Pass & "'")
        Return myServer
    End Function



    'Database Configuration to interact with Sql Server
    'Sql Event's 
    Public con As New SqlConnection("Data Source='" & myServer & "';Initial Catalog='" & dbAse & "';User ID='" & UpName & "';Password='" & Pass & "'")
    'Public con As New SqlConnection("Data Source=JOHN\MULA;Initial Catalog=JournalEntry;User ID=sa;Password=mula")
    ' Public con As New SqlConnection("Data Source=192.168.25.25;Initial Catalog=JournalEntry;User ID=sa;Password=mula;Integrated Security=false")
    Public sda As New SqlDataAdapter("", con)
    Public sdaa As SqlDataAdapter
    Public cmd As New SqlCommand
    Public cmd1 As New SqlCommand
    Public cmd2 As New SqlCommand
    Public cmd3 As New SqlCommand
    Public dr As SqlDataReader
    Public bs As BindingSource
    Public dt As DataTable
    Public dt2 As DataTable
    Public ds As DataSet


    'Save Button toolStrip text = New Record :)' 


    Public salesJournal As String = "New Sales[F3]"
    Public purchaseJournal As String = "New Purchase[F3]"
    Public cashDisburse As String = "New Disbursement[F3]"
    Public cashReceipt As String = "New Receipt[F3]"
    Public generalJournal As String = "New Journal[F3]"
    Public supplierfrm As String = "New Supplier[F3]"
    Public customer As String = "New Customer[F3]"
    Public chartOfAccount As String = "New Chart of Account[F3]"
    Public trialbalance As String = "Trial Balance"
    Public income As String = "New Income Statement[F3]"
    Public owner As String = "New Owner's Equity Statement[F3]"
    Public balancesheet As String = "Balance Sheet"
    Public specialjournal As String = "New Entry[F3]"
    Public journaltype As String = "New Journal Type[F3]"
    'Save Button toolStrip text = New Record :)'

    'Save Button toolStrip text = Save Record :)'
    Public salesJournal3 As String = "Save Sales[F4]"
    Public purchaseJournal3 As String = "Save Purchase[F4]"
    Public cashDisburse3 As String = "Save Disbursement[F4]"
    Public cashReceipt3 As String = "Save Receipt[F4]"
    Public generalJournal3 As String = "Save Journal[F4]"
    Public supplierfrm3 As String = "Save Supplier[F4]"
    Public customerfrm3 As String = "Save Customer[F4]"
    Public chartOfAccount3 As String = "Save Chart of Account[F4]"
    Public jlSummarizing3 As String = "Save GLSummarizing[F4]"
    Public tlSummarizing3 As String = "Save TBSummarizing[F4]"
    Public income3 As String = "Save Income Income Statement[F4]"
    Public owner3 As String = "Save Owner's Equity Statement[F4]"
    Public specialjournal1 As String = "Save Entry[F4]"
    Public journaltype1 As String = "Save Journal Type[F4]"
    'Save Button toolStrip text = Save Record :)


    'Save Button toolStrip text = Update Record :)'
    Public salesJournal1 As String = "Update Sales[F5]"
    Public purchaseJournal1 As String = "Update Purchase[F5]"
    Public cashDisburse1 As String = "Update Disbursement[F5]"
    Public cashReceipt1 As String = "Update Receipt[F5]"
    Public generalJournal1 As String = "Update Journal[F5]"
    Public supplierfrm1 As String = "Update Supplier[F5]"
    Public customerfrm1 As String = "Update Customer[F5]"
    Public chartOfAccount1 As String = "Update Chart of Account[F5]"
    Public jlSummarizing1 As String = "Update GLSummarizing[F5]"
    Public tlSummarizing1 As String = "Update TBSummarizing[F5]"
    Public income1 As String = "Update Income[F5]"
    Public specialjournal2 As String = "Update Entry[F5]"
    Public journaltype2 As String = "Update Journal Type[F5]"
    'Save Button toolStrip text = Update Record :)'


    'Save Button toolStrip text = Search Record :)'
    Public salesJournal2 As String = "Search Sales"
    Public purchaseJournal2 As String = "Search Purchase"
    Public cashDisburse2 As String = "Search DisbursefrmMainnt"
    Public cashReceipt2 As String = "Search Receipt"
    Public generalJournal2 As String = "Search Journal"
    Public supplierfrm2 As String = "Search Supplier"
    Public customerfrm2 As String = "Search Customer"
    Public chartOfAccount2 As String = "Search Chart of Account"
    Public jlSummarizing2 As String = "Search GLSummarizing"
    Public tlSummarizing2 As String = "Search TBSummarizing"
    'Save Button toolStrip text = Search Record :)'

    'Cancel Button
    Public salesJournalCancel As String = "Cancel Sales[Esc]"
    Public purchaseJournalCancel As String = "Cancel Purchase[Esc]"
    Public cashDisburseCancel As String = "Cancel Disbursement[Esc]"
    Public cashReceiptCancel As String = "Cancel Receipt[Esc]"
    Public generalJournalCancel As String = "Cancel Journal[Esc]"
    Public supplierfrmCancel As String = "Cancel Supplier[Esc]"
    Public customerCancel As String = "Cancel Customer[Esc]"
    Public chartOfAccountCancel As String = "Cancel Chart of Account[Esc]"
    Public trialbalanceCancel As String = "Trial Balance"
    Public incomeCancel As String = "Cancel Income Statement[Esc]"
    Public ownerCancel As String = "Cancel Owner's Equity Statement[Esc]"
    Public balancesheetCancel As String = "Balance Sheet"
    Public specialjournal3 As String = "Cancel Entry[Esc]"
    Public journaltype3 As String = "Cancel Journal Type[Esc]"
    'For Picture Browse
    Public picStr As String
    'Create new Image
    'Image declaration
    Public IMG As Image
    Public MyStream As New MemoryStream
    Public Pic As Byte

End Module
