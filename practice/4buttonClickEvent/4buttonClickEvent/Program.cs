using System;

// Define a delegate for the event handler
public delegate void ButtonClickEventHandler(object sender, EventArgs e);

// Define a class for the button
public class Button
{
    // Declare an event using the delegate
    public event ButtonClickEventHandler Click;

    // Method to simulate a button click
    public void SimulateClick()
    {
        Console.WriteLine("Button clicked!");
        OnClick(EventArgs.Empty);
    }

    // Method to raise the Click event
    protected virtual void OnClick(EventArgs e)
    {
        if (Click != null)
        {
            Click(this, e);
        }
    }
}

// Class to demonstrate the usage of the button and event
public class Program
{
    public static void Main()
    {
        // Create an instance of the button
        Button myButton = new Button();

        // Subscribe to the Click event with a custom event handler
        myButton.Click += OnButtonClick;

        // Simulate a button click
        myButton.SimulateClick();

        Console.ReadLine();
    }

    // Custom event handler for the button click event
    public static void OnButtonClick(object sender, EventArgs e)
    {
        Console.WriteLine("Custom event handler: Button was clicked!");
    }
}
