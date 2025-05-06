using Engine.Contracts;

internal class OpenGLRenderer2D : IRenderer2D { }
internal class Sdl2InputService : IInputService { }

public static class EngineBootstrapper
{
    public static void RegisterServices(IServiceCollection services)
    {
        // contracts → implementations
        services.AddSingleton<IRenderer2D, OpenGLRenderer2D>();
        services.AddSingleton<IInputService, Sdl2InputService>();
        services.AddSingleton<IAudioService, OpenALAudioService>();
        // finally register the game itself
        services.AddSingleton<IGame, PixelArtGame>();
    }
}
