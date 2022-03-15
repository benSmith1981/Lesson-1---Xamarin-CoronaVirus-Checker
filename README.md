# Lesson 1 - Xamarin CoronaVirus Checker
Create a new visual studio project called Corona Virus Simulator, summary of this lesson: 

Create a single page app 

- Add a Label, Text Input Field and a Button 

- Connect the code to the button and the input field 

Write code to: 

- Get the value of the input field 

- Convert it to an integer 

- Check if it is over 36 degrees  

- If it is show a message saying you are positive for Rona 

- If it is not show a message saying you are negative for Rona 

 

1- You need to make sure the Xamarin frame work is added to your copy of Visual Studio, you can add it  by opening the visual studio installer and modifying the install to include Xamarin 

2 - Once this is added you can then proceed with creating a new BLANK Xamarin App (this might look different if you are using Visual Studio 2017 or 2019): 

3 - XAML files define the layout of the app. It is similar to HTML, it is a type of markup language. You can create any UI component in code just check the examples on Microsofts  Part 2. Essential XAML Syntax - Xamarin | Microsoft Docs  website. A XAML file will always have an accompanying cs file  

4- You need to edit the XAML so that you have a Label title. Look at the example here and add it changing the parts you need to so you have the title “Corona Virus Detector” Xamarin.Forms Label - Xamarin | Microsoft Docs 

Then you need to add a text input field use the example here and update it so you have a placeholder text and the ID is called temperatureInput Xamarin.Forms Entry - Xamarin | Microsoft Docs 

Then we need to add a button, so that when we press the button it connects to our code and checks the temperature we entered, giving feedback, check here to add a button: Xamarin.Forms Button - Xamarin | Microsoft Docs 

Your final XAML for the mainpage should look something like this: 

 <?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="CoronaVIrus.MainPage">

    <StackLayout>
        <Frame BackgroundColor="#2196F3" Padding="24" CornerRadius="0">
            <Label Text="COVID-19 Temperture App" HorizontalTextAlignment="Center" TextColor="White" FontSize="36"/>
        </Frame>
        <Entry x:Name="tempInput" Placeholder="Enter Temp"/>
        <Button x:Name="SubmitButton" Text="Submit Temp" Clicked="Submit"></Button>
    </StackLayout>

</ContentPage>

6 - Now we want to connect the button in the XAML file to the Code that controls this view. Add a function with the same name as in the Clicked attribute: 

Then when the button is pressed you need to get the temperature from the textbox using it’s ID (tempInput)  
        public void Submit(object sender, EventArgs args)
        {
            var temp = tempInput.Text;
        }
X:Name always holds the ID of that component, important to remember this 

7 - Now you need to write the code in the function for the button to check the value entered in the input entry field, and show and alert... here is the first part of the function, getting the temperature and storing it in a variable, you will need to write the rest, good luck!

 
EXTRAS: 

- To make it more complex maybe you can show an image on the screen depending on the diagnosis 

- Try and use a function for the temperature check… 

- Make it play a warning sound if you are sick 

 
