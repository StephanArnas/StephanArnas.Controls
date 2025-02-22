using SkiaSharp.Views.Maui.Controls.Hosting;
using StephanArnas.Controls.Maui.Controls.ProgressBars;
using ProgressBar = Microsoft.Maui.Controls.ProgressBar;

namespace StephanArnas.Controls.Maui;

public static class DependencyInjection
{
    public static MauiAppBuilder AddBlogComponents(this MauiAppBuilder builder)
    {
        builder.UseSkiaSharp();
        
        builder.ConfigureMauiHandlers(handlers =>
        {
            handlers.AddHandler<ProgressBar, SaProgressBarHandler>();
        });
        
        return builder;
    }
}