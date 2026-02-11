function toggleFavorito(btn, brinquedoId) {
    // 1. Verificação de Login
    var isAuth = $(btn).data('auth');

    if (!isAuth || isAuth.toString().toLowerCase() === "false") {
        window.location.href = "/Account/Login";
        return;
    }

    // Pega o ícone para mudar visualmente
    var icon = $(btn).find("i");
    // Verifica se estamos na página de "Meus Favoritos" (se for lixeira)
    var isTrash = icon.hasClass("bi-trash") || $(btn).hasClass("btn-remover");

    // 2. Chamada à API (Endereço Corrigido)
    // Atenção: A URL agora é /api/Favoritos/toggle/ + o ID
    $.post("/api/Favoritos/toggle/" + brinquedoId)
        .done(function (response) {

            if (response.success) {
                // === AÇÃO DE REMOVER (LIXEIRA) ===
                if (isTrash) {
                    // Seleciona o card pelo ID que colocamos no HTML
                    var card = $("#card-favorito-" + brinquedoId);

                    // Faz sumir suavemente
                    card.fadeOut(400, function () {
                        $(this).remove(); // Remove do HTML

                        // Se a lista ficar vazia, recarrega para mostrar a mensagem "Você não tem favoritos"
                        // Verifica quantos cards sobraram na div pai #lista-favoritos
                        if ($("#lista-favoritos").children(":visible").length === 0) {
                            location.reload();
                        }
                    });
                }
                // === AÇÃO DE TOGGLE (CORAÇÃO NA HOME/BUSCA) ===
                else {
                    if (response.action === "added") {
                        icon.removeClass("bi-heart").addClass("bi-heart-fill text-danger");
                    } else {
                        icon.removeClass("bi-heart-fill text-danger").addClass("bi-heart");
                    }
                }
            }
        })
        .fail(function (xhr) {
            console.error("Erro API:", xhr.responseText);
            if (xhr.status === 401) {
                window.location.href = "/Account/Login";
            } else {
                // Feedback visual de erro (opcional)
                alert("Não foi possível atualizar o favorito.");
            }
        });
}