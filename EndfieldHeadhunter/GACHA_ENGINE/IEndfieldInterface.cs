using Discord.Interactions;

namespace GACHA_ENGINE
{
    namespace ENGINE_INTERFACE
    {
        public interface IEndfieldCommand
        {
            string Name { get; }
            string Description { get; }
            void Execute(SocketInteractionContext SOCKET_INTERACTION_CONTEXT_CTX);
        }
    }
}
