using Microsoft.Extensions.DependencyInjection;
namespace Engine.Contracts
{


    /// <summary>
    /// The core game interface that the host will drive.
    /// </summary>
    public interface IGame
    {

        void Initialize(IServiceProvider services);

        /// <summary>
        /// Called every frame before Render().
        /// </summary>
        /// <param name="deltaTime">Time (in seconds) since last Update.</param>
        void Update(float deltaTime);

        /// <summary>
        /// Called every frame after Update().
        /// </summary>
        void Render();


        void Shutdown();
    }

    /// <summary>
    /// A simple bootstrapper for wiring up engine services.
    /// </summary>
    public static class EngineBootstrapper
    {
        /// <summary>
        /// Registers all engine subsystems into the provided DI container.
        /// </summary>
        public static void RegisterServices(IServiceCollection services) { /* no-op stub */ }
    }

    public interface IRenderer2D
    {
        /// <summary>
        /// Queue a textured quad for drawing next frame.
        /// </summary>
        void DrawSprite(TextureHandle handle, Vector2 position, RectangleF sourceRect);

        /// <summary>
        /// Flushes all queued sprites to the screen.
        /// </summary>
        void Flush();
    }

    public interface IInputService
    {
        bool IsActionPressed(string actionName);
        event Action<string> OnActionPressed;
    }

    public interface IAudioService
    {
        SoundHandle LoadSound(string path);
        void PlaySound(SoundHandle sound, float volume = 1f);
    }


}
