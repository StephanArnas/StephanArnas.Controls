using StephanArnas.Controls.Application.Common.Interfaces.Infrastructure;

namespace StephanArnas.Controls.Infrastructure.Displays;

public class DisplayService : IDisplayService
{
    public Task ShowPopupAsync(string title, string message, string accept = "OK")
    {
        return Microsoft.Maui.Controls.Application.Current!.Windows[0].Page!.DisplayAlert(title, message, accept);
    }
}