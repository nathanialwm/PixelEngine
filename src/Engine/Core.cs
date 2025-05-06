using Engine.Contracts;
using Microsoft.Extensions.DependencyInjection;

internal class PixelRenderer2D : IRenderer2D
{
    public void DrawSprite(TextureHandle texture, Vector2 position, RectangleF sourceRectangle)
    {
        // TODO: Implement the logic to draw a sprite
        throw new NotImplementedException();
    }

    public void Flush()
    {
        // TODO: Implement the logic to flush the renderer
        throw new NotImplementedException();
    }
}
internal class PixelInputHandle : IInputService
{
    public bool IsActionPressed(string action)
    {
        // TODO: Implement the logic to check if an action is pressed
        throw new NotImplementedException();
    }

    public event Action<string> OnActionPressed;
}
internal class PixelAudioHandle : IAudioService
{
    public SoundHandle LoadSound(string path)
    {
        // TODO: Implement the logic to load a sound
        throw new NotImplementedException();
    }
    public void PlaySound(SoundHandle sound, float volume = 1f)
    {
        // TODO: Implement the logic to play a sound
        throw new NotImplementedException();
    }
}

internal class PixelGame : IGame
{
    public void Initialize(IServiceProvider services)
    {
        // TODO: Implement the logic to initialize the game
        throw new NotImplementedException();
    }
    public void Update(float deltaTime)
    {
        // TODO: Implement the logic to update the game
        throw new NotImplementedException();
    }
    public void Render()
    {
        // TODO: Implement the logic to render the game
        throw new NotImplementedException();
    }
    public void Shutdown()
    {
        // TODO: Implement the logic to shut down the game
        throw new NotImplementedException();
    }
}


public static class EngineBootstrapper
{
    public static void RegisterServices(IServiceCollection services)
    {
        // contracts → implementations
        services.AddSingleton<IRenderer2D, PixelRenderer2D>();
        services.AddSingleton<IInputService, PixelInputHandle>();
        services.AddSingleton<IAudioService, PixelAudioHandle>();
        // finally register the game itself
        services.AddSingleton<IGame, PixelGame>();
    }
}
