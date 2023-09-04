// See https://aka.ms/new-console-template for more information


// lets define a button 
var button = new Button();

// every time this button is "clicked" it will call this function
button.OnClick += ButtonClick;

// define another button but it does different things when we "click it"
var button2 = new Button();
button2.OnClick += ButtonClick2;

button.OnClick.Invoke();
button2.OnClick.Invoke();

// we can attach more functions :
button.OnClick += ButtonClick2;
button.OnClick.Invoke();


void ButtonClick()
{
    Console.WriteLine("Hello World");
}

void ButtonClick2()
{
    Console.WriteLine("Hello World 2");
}

public class Button
{
    public delegate void ButtonClick();

    public ButtonClick OnClick;
}