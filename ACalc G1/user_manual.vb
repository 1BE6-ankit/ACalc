Imports System.IO
Imports System.Drawing

Public Class user_manual

    Public page_counter As Integer = 1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub user_manual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call content_display()
    End Sub

    Private Sub content_display()

        Dim last_page As Integer = 7

        If page_counter < 1 Then page_counter = 1
        If page_counter > last_page Then page_counter = last_page

        content_box.Clear()
        previous_button.Enabled = True
        next_button.Enabled = True

        Select Case page_counter
            Case 1
                previous_button.Enabled = False
                topic_box.Text = "About This Software:"
                page_notice.Text = "Page 1 of " & last_page

                With content_box
                    .AppendText(Environment.NewLine & "ACalc is a calculator software which is capable of solving different mathematical problems." + Environment.NewLine + Environment.NewLine)

                    .SelectionColor = Color.GhostWhite
                    .AppendText("This software comprises of 4 main tools:" & Environment.NewLine)
                    .SelectionBullet = True
                    .AppendText("Main Calculator" & Environment.NewLine)
                    .AppendText("Quadratic Calculator" & Environment.NewLine)
                    .AppendText("Prime or Composite Finder" & Environment.NewLine)
                    .AppendText("HCF and LCM Finder" & Environment.NewLine)
                    .SelectionBullet = False

                    .SelectionColor = Color.Gold
                    .AppendText(Environment.NewLine & "  These Software tools not only give you the answer of your problem but also ")
                    .AppendText("provide you with the process that was required to accomplish the result.")

                    .SelectionColor = Color.MistyRose
                    .AppendText(Environment.NewLine & "Click the arrows on the either side ")
                    .AppendText("to get more information about these tools and this software")

                End With
            Case 2
                topic_box.Text = "About Main Calculator:"
                page_notice.Text = "Page 2 of " & last_page

                With content_box
                    .AppendText(Environment.NewLine & "This Main Calculator is the most noticable feature of ")
                    .AppendText("ACalc which you get everytime you start the program" + Environment.NewLine)

                    .SelectionColor = Color.GhostWhite
                    .AppendText("When it loads up you can see differed numbered boxes together with other arithmetic ")
                    .AppendText("operators. DO do a calculation you can either click those boxes or you can manually ")
                    .AppendText("enter your mathematical expression in the input box. You can enter only those characters ")
                    .AppendText("which you see in the red boxes for your calculation" & Environment.NewLine)

                    .SelectionColor = Color.Lime
                    .AppendText("When you are done entering the data and after you press enter you will see a new ")
                    .AppendText("window pop-up which displays the process of the calculation. Similarly in the other ")
                    .AppendText("two boxes below the input box will get the numeric answer and the word form of the ")
                    .AppendText("calculation result" & Environment.NewLine)

                    .SelectionColor = Color.Aqua
                    .AppendText("By default you will get the process window of the calculation. But you can turn it off ")
                    .AppendText("by clicking the Settings Sub Menu Which is present in the File Tab. From their you can ")
                    .AppendText("also change the form in which the word result is displayed ie: either international system ")
                    .AppendText("or Nepali System" & Environment.NewLine)

                End With

            Case 3
                topic_box.Text = "About Quadratic Calculator:"
                page_notice.Text = "Page 3 of " & last_page

                With content_box
                    .AppendText(Environment.NewLine & "Quadratic Calculator is the most powerful feature of the ACalc ")
                    .AppendText("which helps you to get answer of qudratic equations displaying the full process")
                    .AppendText("like you do in your notebook." + Environment.NewLine)

                    .SelectionColor = Color.Lime
                    .AppendText("When you are using this feature then you will see three boxes which let you enter the value ")
                    .AppendText("of a,b and c form the qudratic equation ax² + bx + c = 0 . In those boxes you can even enter ")
                    .AppendText("some mathematical expressoin like:   2+2(3+3)3.  After you are done entering in a box just press ")
                    .AppendText("enter and keep following it and finally press the EQUATE button to get the result" & Environment.NewLine)

                    .SelectionColor = Color.GhostWhite
                    .AppendText("After you press the EQUATE button and there are no errors in your input you will get a new ")
                    .AppendText("window where your quadratic equation is solved showing you the complete steps " & Environment.NewLine)

                    .SelectionColor = Color.Aqua
                    .AppendText("While entering value in the inputbox if you enter any other characters rather than the ")
                    .AppendText("calculation symbols that ACalc Understands then you will get the answer as 0" & Environment.NewLine)
                End With
            Case 4
                topic_box.Text = "About Prime/Composite Finder:"
                page_notice.Text = "Page 4 of " & last_page

                With content_box
                    .AppendText(Environment.NewLine & "This tool allows you to find whether a number is prime or ")
                    .AppendText("composite. You will be asked to enter a number and there you can also enter a valid ")
                    .AppendText("mathematical expresssion like in Quadratic Calculator" & Environment.NewLine)

                    .SelectionColor = Color.Aqua
                    .AppendText("After you entered the number just hit the enter button and in the big box just below ")
                    .AppendText("the input box you get all the factors of the entered number with the result showing ")
                    .AppendText("it is Prime or Composite" & Environment.NewLine)

                    .SelectionColor = Color.GhostWhite
                    .AppendText("You will get the full result only if your entered number is natural number or the ")
                    .AppendText("mathematical expression you entered has result as a natural number. Otherwise you ")
                    .AppendText("will get the error messages based on your input. Similarly characters other than ")
                    .AppendText("numbers, if entered will be treated as 0" & Environment.NewLine)
                End With
            Case 5
                topic_box.Text = "About HCF and LCM Finder:"
                page_notice.Text = "Page 5 of " & last_page

                With content_box
                    .AppendText(Environment.NewLine & "This tool allows you to find the HCF(Highest Common Factor) ")
                    .AppendText("and LCM(Lowest Common Multiple) from a group of more than a million numbers.")

                    .SelectionColor = Color.Lime
                    .AppendText("You will need to enter the numbers in the box where you are supposed to by seperating ")
                    .AppendText("the numbers with a comma. For eg like this: " & Environment.NewLine)
                    .AppendText(" 1,2,3,4,5,6,7,8,9 " & Environment.NewLine)

                    .SelectionColor = Color.GhostWhite
                    .AppendText("After you are done entering the numbers just hit the Find Now!! button then in result ")
                    .AppendText("you will get the factors of the entered number being displayed and the HCF and LCM of ")
                    .AppendText("the numbers wil be shown. " & Environment.NewLine)

                    .SelectionColor = Color.Aqua
                    .AppendText(" For more informatin about this tool you can click the (!!) button in HCF and LCM ")
                    .AppendText("Finder " & Environment.NewLine)
                End With
            Case 6
                topic_box.Text = "Using Built-In commands:"
                page_notice.Text = "Page 6 of " & last_page

                With content_box
                    .AppendText(Environment.NewLine & "In ACalc you can enter built-in commands to make your ")
                    .AppendText("word faster but entering commands is only allowed in the Main Calculator" & Environment.NewLine)

                    .SelectionColor = Color.Gainsboro
                    .AppendText("Commands are entered in the same box where you enter your mathematical expression in ")
                    .AppendText("the main calculator " & Environment.NewLine)
                    .AppendText("Here are the list of commands supported by ACalc " & Environment.NewLine)


                    .SelectionBullet = True
                    .SelectionColor = Color.White
                    .SelectionBackColor = Color.Black
                    .AppendText("history : Displays the calculation history " & Environment.NewLine)
                    .SelectionColor = Color.Yellow
                    .SelectionBackColor = Color.Black
                    .AppendText("delhistory : Deletes the calculation history " & Environment.NewLine)
                    .SelectionColor = Color.LightCoral
                    .SelectionBackColor = Color.Black
                    .AppendText("help or manual : Displays ACalc's user manual" & Environment.NewLine)
                    .SelectionColor = Color.LightYellow
                    .SelectionBackColor = Color.Black
                    .AppendText("settings:  Displays settings for Main Calculator " & Environment.NewLine)
                    .SelectionColor = Color.Tomato
                    .SelectionBackColor = Color.Black
                    .AppendText("quad : Displays quadratic calculator" & Environment.NewLine)
                    .SelectionColor = Color.Thistle
                    .SelectionBackColor = Color.Black
                    .AppendText("primeorcom : Displays prime or composite finder" & Environment.NewLine)
                    .SelectionColor = Color.Wheat
                    .SelectionBackColor = Color.Black
                    .AppendText("hcf_lcm : Displays hcf and lcm finder" & Environment.NewLine)
                    .SelectionColor = Color.RosyBrown
                    .SelectionBackColor = Color.Black
                    .AppendText("exit or off : Terminates the program" & Environment.NewLine)
                    .SelectionBullet = False

                End With
            Case last_page
                next_button.Enabled = False
                topic_box.Text = "From The Developer:"
                page_notice.Text = "Page " & last_page & " of " & last_page

                With content_box
                    .AppendText(Environment.NewLine & "We are very thankful to you for using this software. If you have ")
                    .AppendText("any problems with ACalc then  feel free to email us at: ")
                    .SelectionColor = Color.Lime
                    .AppendText(" akoirala9@gmail.com " & Environment.NewLine)

                    .SelectionColor = Color.Aqua
                    .AppendText("Similarly keep visiting our website: ")
                    .AppendText(" www.autosoft.890m.com ")
                    .SelectionColor = Color.Aqua
                    .AppendText(" for latest updates to ACalc." & Environment.NewLine)
                End With
        End Select

    End Sub

    Private Sub previous_button_Click(sender As Object, e As EventArgs) Handles previous_button.Click
        page_counter = page_counter - 1
        Call content_display()
    End Sub

    Private Sub next_button_Click(sender As Object, e As EventArgs) Handles next_button.Click
        page_counter = page_counter + 1
        Call content_display()
    End Sub


End Class