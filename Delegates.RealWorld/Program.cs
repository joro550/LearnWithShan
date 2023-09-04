// See https://aka.ms/new-console-template for more information

using Ooui;

var button = new Button("Click me!");

// Add some logic to it
var count = 0;

// Adding a delegate to the button (the framework gets to decide on how it looks)
button.Click += (s, e) => {
    count++;
    button.Text = $"Clicked {count} times";
};

// Publishing makes an object available at a given URL
// The user should be directed to http://localhost:8080/shared-button

UI.Publish ("/shared-button", button);

// Don't exit the app until someone hits return
Console.ReadLine ();