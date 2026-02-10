async function toggleFavorito(btn, brinquedoId) {
    // Verifica se o usuário está logado (truque visual rápido)
    // Se o botão tiver a classe 'disabled' ou atributo data-auth="false", redireciona
    const isAuthenticated = btn.getAttribute("data-auth") === "true";

    if (!isAuthenticated) {
        window.location.href = "/Account/Login";
        return;
    }

    try {
        // Chama a nossa API interna
        const response = await fetch(`/api/favoritos/toggle/${brinquedoId}`, {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            }
        });

        if (response.status === 401) {
            window.location.href = "/Account/Login";
            return;
        }

        const data = await response.json();

        if (data.success) {
            // Acha o ícone dentro do botão
            const icon = btn.querySelector("i");

            if (data.action === "added") {
                // Virou Favorito: Coração Cheio e Vermelho
                icon.classList.remove("bi-heart");
                icon.classList.add("bi-heart-fill", "text-danger");
                // Animaçãozinha opcional
                icon.style.transform = "scale(1.2)";
                setTimeout(() => icon.style.transform = "scale(1)", 200);
            } else {
                // Removeu Favorito: Coração Vazio e Preto/Cinza
                icon.classList.remove("bi-heart-fill", "text-danger");
                icon.classList.add("bi-heart");
            }
        } else {
            alert(data.message || "Erro ao favoritar.");
        }
    } catch (error) {
        console.error("Erro:", error);
        alert("Ocorreu um erro ao processar sua solicitação.");
    }
}