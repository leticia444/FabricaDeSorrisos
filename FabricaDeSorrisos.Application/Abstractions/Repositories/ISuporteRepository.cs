using FabricaDeSorrisos.Domain.Entities;

namespace FabricaDeSorrisos.Application.Abstractions.Repositories;

public interface ISuporteRepository
{
    // Para o Cliente: Ver suas próprias mensagens
    Task<List<MensagemSuporte>> GetMensagensDoUsuarioAsync(int usuarioId);

    // Para o Admin: Ver quem mandou mensagem (Lista de IDs de usuários com chat aberto)
    Task<List<int>> GetUsuariosComMensagensPendentesAsync();

    // Enviar mensagem
    Task SalvarMensagemAsync(MensagemSuporte mensagem);

    // Marcar como lida/respondida (opcional, mas bom ter)
    Task MarcarComoRespondidaAsync(int usuarioId);
}
