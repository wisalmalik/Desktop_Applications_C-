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
                                          //code of the open the show box
                                          Form2 f2 = new Form2();
                                            f2.Show();
                                            
.)The showdialog method will create modeless form -> modeless form mean modeless form is opened , this method will create model form 

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
        



















