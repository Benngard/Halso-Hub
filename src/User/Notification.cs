using System;

/// <summary>
/// Mattias Benngård
/// </summary>
namespace Halso_Hub
{
    public class Notification
    {
        public string Title { get; private set; }
        public string Message { get; private set; }

        public Notification(string title, string message)
        {
            Title = title;
            Message = message;
        }
    }
}