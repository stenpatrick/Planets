namespace Planets;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("Montserrat-Bold.ttf", "BoldFont");
				fonts.AddFont("Montserrat-Medium.ttf", "MediumFont");
                fonts.AddFont("Montserrat-Semibold.ttf", "SemiboldFont");
            });

		return builder.Build();
	}
}
