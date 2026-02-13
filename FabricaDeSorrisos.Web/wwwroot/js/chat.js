// Localizado em wwwroot/js/chat.js no projeto WEB
// Usamos um caminho relativo para que ele use automaticamente a mesma porta do site (5179)
const API_URL = "/api/Suporte";

var chatAberto = false;
var intervaloAtualizacao = null;

function toggleChat() {
    var janela = document.getElementById("janelaChat");

    if (chatAberto) {
        janela.classList.add("d-none");
        chatAberto = false;
        clearInterval(intervaloAtualizacao);
    } else {
        janela.classList.remove("d-none");
        chatAberto = true;
        carregarMensagens();
        // Atualiza a conversa a cada 5 segundos
        intervaloAtualizacao = setInterval(carregarMensagens, 5000);

        setTimeout(() => {
            const input = document.getElementById("msgInput");
            if (input) input.focus();
        }, 100);
    }
}

async function carregarMensagens() {
    try {
        // Agora não precisamos de 'https://localhost...' nem de 'credentials'
        const response = await fetch(`${API_URL}/historico`);

        if (!response.ok) {
            console.warn("Usuário possivelmente não autenticado ou rota inexistente.");
            return;
        }

        const mensagens = await response.json();
        renderizarMensagens(mensagens);

    } catch (error) {
        console.error("Erro ao carregar chat:", error);
    }
}

function renderizarMensagens(lista) {
    const chatBody = document.getElementById("chatBody");
    if (!chatBody) return;

    chatBody.innerHTML = "";

    if (!lista || lista.length === 0) {
        chatBody.innerHTML = '<p class="text-center text-muted small mt-5">Olá! Como podemos ajudar hoje?</p>';
        return;
    }

    lista.forEach(msg => {
        const isAdmin = msg.respondidoPorAdmin;

        const divRow = document.createElement("div");
        divRow.className = isAdmin ? "msg-row msg-admin" : "msg-row msg-me";

        const divBala = document.createElement("div");
        divBala.className = "msg-bala shadow-sm";
        divBala.innerText = msg.texto;

        const smallHora = document.createElement("div");
        smallHora.className = "text-end mt-1";
        smallHora.style.fontSize = "0.6rem";
        smallHora.style.opacity = "0.7";
        const data = new Date(msg.dataEnvio);
        smallHora.innerText = data.toLocaleTimeString([], { hour: '2-digit', minute: '2-digit' });

        divBala.appendChild(smallHora);
        divRow.appendChild(divBala);
        chatBody.appendChild(divRow);
    });

    chatBody.scrollTop = chatBody.scrollHeight;
}

async function enviarMensagem(e) {
    e.preventDefault();
    const input = document.getElementById("msgInput");
    const texto = input.value.trim();

    if (!texto) return;

    input.value = "";

    try {
        const payload = {
            texto: texto,
            destinatarioId: 0
        };

        const response = await fetch(`${API_URL}/enviar`, {
            method: "POST",
            headers: { "Content-Type": "application/json" },
            body: JSON.stringify(payload)
        });

        if (response.ok) {
            carregarMensagens();
        } else {
            console.error("Falha ao enviar mensagem.");
        }

    } catch (error) {
        console.error("Erro no envio:", error);
    }
}