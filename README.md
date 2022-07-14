# Desktop_Applications_C-
This repo is for the small desktop application build in the c#





#####################################################################################

-------------------------------ReadMe about the 04 simple app-------------------------------------------------------------

premium start form 50.5

if age is grater than 30 then 50 else 100

country if usa then 40 else 50

premium Insurance if yes then 100 else 0

no claim Discount if yes then - 25 else 50

sick cover if yes then 50 else 0

#######################################################################################

--------------------------------------------------ReadMe about 05 simple app--------------------------------------------

In c# we use the integer of the button , but in the future if commit some changes in the app then we don't know about the integer that we declear from our self , so the better way to declear the enum 



#######################################################################################


--------------------------------------------------ReadMe about 06 simple app--------------------------------------------

In this app i learn and apply that how to open one form with the other form 

.) To open one form with the another . we need one button-> double click on the button in the visual studio the code is open 
.)To active button create the object of the form who you want to open by clicking the button
.) The question arise that why we create the object , answer ; we create the object because the form is also in the form of the class 



#######################################################################################

--------------------------------------------------ReadMe about 07 simple app--------------------------------------------

In this app i learn and apply tha how to open the show and showdialog box by clicking the button 

.)The show method will create model form -> model form mean model form is opened then you can't use the rest of the app till model form is closed
                                          
                                            
.)The showdialog method will create modeless form -> modeless form mean modeless form is opened , this method will create model form 
                                   
                                   //code of the open the show box
                                          Form2 f2 = new Form2();
                                            f2.Show();
                                            
                                    //code of the open the showdialog show box
                                    Form2 f2 = new Form2();
                                    f2.ShowDialog();


#######################################################################################


--------------------------------------------------ReadMe about 12 simple app--------------------------------------------

In this app i learn and apply that how to allow the drap and drop opetion in the textbox  

.)first go to the properties and True the drap option
.)second go to event and select the drap Enter->and  write the code


            // this line of code till us that what effect is created,
            e.Effect = DragDropEffects.Copy;
            //what add in the textbox1.Text -> add the text in the  box 
            textBox1.Text  = e.Data.GetData(DataFormats.Text).ToString();
        


#######################################################################################


--------------------------------------------------ReadMe about 15 simple app--------------------------------------------


In this app i learn and build the smile app which take the current date and time of the computer 

.) firt drop the datetimepicker or label tool after that write the following code.

                    // the following code is for the label
                    label1.Text = DateTime.Now.ToLongDateString();
                    label2.Text = DateTime.Now.ToLongTimeString();
                    
                    // the following code is for the datetimepicker
                    dateTimePicker1.Text = DateTime.Now.ToLongDateString();


#######################################################################################


--------------------------------------------------ReadMe about 16 simple app--------------------------------------------

In this app i learn and build the simle app which contain and tooltip control the menustrip 

.) Menustrip is a tool which is present in the toool bar drap and drop the menustrip
.)add shortcut with the help of the properties
.)write some certain code 

===> Tooltip control

.) for the tooltip control firt add picturebox and add the quesstion mark icon 
.) After that add tooltip in the form from the toolbar
.)After that click on the image/Icon and write the massage you what to show 



#######################################################################################


--------------------------------------------------ReadMe about 19 simple app--------------------------------------------

In this app i learn and build the smile app which i restrict the ueser to enter the right input in the textbox

.)First select the textbox ->go to event section-> select key press .
.)write the following code 

          //cod for the restrict user input
           if ((!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
                      {
                      //this line of code:restrict to not enter any type of key 
                          e.Handled= true;

            }
            
  .)In the following code the first check is for the letter , the second check is for the whitespac , the 3RD check i for the controle (mean delete button etc)
  
      //following code is for the Interger enter
      
            if ((!char.IsNumber(e.KeyChar)  &&(!char.IsControl(e.KeyChar))))
            {
                e.Handled = true;

            }
  .)For the email we need three thing letter, digits, @ and dot, for the dot and @ we use the assicc value 
  
            //The Following code is for the email
             if ((!char.IsLetter(e.KeyChar)) && ( e.KeyChar !=46) &&(e.KeyChar !=64)&& (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;

            }






#######################################################################################


--------------------------------------------------ReadMe about 20 simple app--------------------------------------------


In this app i lean and build the app , this app is about the to store the username so user have easy to login 

.)the username is save in the bin folder of the project 
.)i write the code to read the text form the txt box 
.)if the useranme is correct and user are successful login then it save the user name in the file 

                     //this line the code check the username and password
                                if(usernamebox.Text == "admin" && Passwordbox.Text == "password")
                                {
                                    //if the username and password are correct then it create the  file in the bin folder 

                                    using (StreamWriter streamwriter = new StreamWriter("username.txt"))
                                    {
                                        //read the text from the usertextbox
                                        streamwriter.WriteLine(usernamebox.Text);
                                    }

                                    this.Hide();

                                    Form2 f2 = new Form2();
                                    f2.Visible = true;
                                }
                                else
                                {
                                    MessageBox.Show("the user name or password are wrong","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                    usernamebox.Clear();
                                    Passwordbox.Clear();    
                                    usernamebox.Focus();

                                }




.)for the read the file write the code in the form , 


                             //this code is inplment in the form 
                                        // this line of code read the username for the username.txt file 
                                        using (StreamReader streamReader = new StreamReader("username.Txt"))
                                        {
                                            usernamebox.Text = streamReader.ReadLine();
                                        }

































