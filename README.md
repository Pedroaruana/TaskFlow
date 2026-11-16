# TaskFlow (fork com as contribuições de Pedro Aruanã)

Este é o meu fork de um projeto open source da comunidade Tecnologia da Informação BR, mantido por Flávio Pavim. O repositório original (`Tecnologia-da-Informacao-BR/TaskFlow`) ficou privado em novembro de 2026, então este fork guarda o histórico completo e é a referência pública do que eu fiz. O branch padrão aqui é `development`, que é onde está o código atual.

## O que eu fiz

Fluxo de recuperação de senha (esqueci a senha, verificação de OTP, nova senha) em três clientes, mais cadastro e login no mobile e no desktop. Tudo seguindo o fluxo do projeto: fork, branch `feat/...` a partir de `development`, Conventional Commits em inglês, PR para `development` e revisão do mantenedor antes do merge.

| Plataforma | Stack | O que entreguei | Commit | PR |
|---|---|---|---|---|
| Frontend | React, Vite, TypeScript, Tailwind | Páginas `/esqueci-minha-senha`, `/verificar-otp` e `/resetar-senha`; corrigi o link morto "Esqueci minha senha" do login | [8387aeb](https://github.com/Pedroaruana/TaskFlow/commit/8387aeb) | #13 |
| Mobile | React Native, Expo Router | Telas de cadastro e login, componentes reutilizáveis (`auth-input`, `auth-button`, `auth-header`) e tema de cores | [5eb21c3](https://github.com/Pedroaruana/TaskFlow/commit/5eb21c3) | #16 |
| Mobile | React Native, Expo Router | Telas `forgot-password`, `verify-otp` e `reset-password` | [f010a82](https://github.com/Pedroaruana/TaskFlow/commit/f010a82) | #18 |
| Desktop | C#, .NET 10, WinForms | Telas de cadastro e login | [c92a2f9](https://github.com/Pedroaruana/TaskFlow/commit/c92a2f9) | #21 |
| Desktop | C#, .NET 10, WinForms | Telas de recuperação de senha; componentes `BrandPanel` e `PasswordTextBox` | [dc23958](https://github.com/Pedroaruana/TaskFlow/commit/dc23958) | #22 |

Os números de PR são do repositório original, hoje privado. Os commits acima abrem normalmente aqui no fork. Para listar todos os meus commits: [histórico filtrado por autor](https://github.com/Pedroaruana/TaskFlow/commits/development/?author=Pedroaruana).

Total: 5 commits, cerca de 2.850 linhas adicionadas. Uma parte grande do desktop são arquivos `.Designer.cs` do WinForms, então o número de linhas exagera o esforço real; o código escrito à mão está nos `.cs` de cada tela e nos dois componentes.

## Decisões que valem olhar

- Desktop: `BrandPanel` (painel roxo com logo e estatísticas) e `PasswordTextBox` (campo de senha com botão de mostrar/ocultar) foram extraídos para serem reutilizados nas quatro telas, em vez de duplicar o layout. Arquivos: [BrandPanel.cs](desktop/TaskFlow/BrandPanel.cs) e [PasswordTextBox.cs](desktop/TaskFlow/PasswordTextBox.cs).
- Desktop: a navegação entre as telas de recuperação usa `ShowDialog` encadeado com `DialogResult`, e a tela de login só volta a aparecer quando o fluxo termina. Exemplo: [VerifyOtpForm.cs](desktop/TaskFlow/VerifyOtpForm.cs).
- Desktop: o rodapé de estatísticas ficava invisível nas telas novas por causa de `Anchor`; resolvi com `Dock = Bottom`.
- Validação nos três clientes: formato de email, OTP com exatamente 6 dígitos e senha com no mínimo 8 caracteres com confirmação.
- Mobile: rotas por arquivo no Expo Router, com o grupo `(tabs)` mantido separado das telas de autenticação. Exemplo: [verify-otp.tsx](mobile/src/app/verify-otp.tsx).

## Limites

- As telas são só de interface: não chamam a API de autenticação. O backend (cadastro, login e geração de OTP) foi feito por outros contribuidores do projeto, não por mim.
- Não escrevi testes automatizados para essas telas. Validei rodando cada tela localmente, com build, lint e type check.
- Cadastro e login do frontend web já existiam, feitos por outra pessoa; a minha parte no frontend foi a recuperação de senha.

## Papel no projeto

Ao longo do projeto, o mantenedor me convidou para Tech Lead do TaskFlow e recebi acesso de maintain no repositório da organização.

## Como rodar

Frontend:

```bash
cd frontend
npm install
npm run dev
```

Mobile:

```bash
cd mobile
npm install
npx expo start
```

Desktop (precisa do .NET 10 SDK no Windows):

```bash
cd desktop
dotnet run --project TaskFlow
```

O restante do projeto (backend, Docker, variáveis de ambiente) está descrito no README original abaixo.

---

# README original do projeto

TaskFlow is a project and activity management platform designed to help teams and individuals organize tasks, track progress, and improve productivity.

The goal of the project is to provide a simple and flexible workspace where users can create projects, manage activities, organize workflows, and collaborate efficiently.

## Features

- Project management
- Activity/task organization
- Kanban-style boards
- Task status tracking
- User collaboration
- Notifications and reminders
- Cross-platform support

## Project Structure

```
TaskFlow/
│
├── backend/   # API and server-side application
├── frontend/  # Web application
├── mobile/    # Mobile application
└── desktop/   # Desktop application
```

## Technologies

The project is being developed using modern technologies, including:

- Backend: Node.js / Express / Sequelize
- Frontend: React / TypeScript / Vite
- Mobile: React Native / Expo
- Desktop: C# / .NET / WinForms
- Database: MySQL

## Getting Started

Each application has its own setup instructions:

- Backend: `backend/README.md`
- Frontend: `frontend/README.md`
- Mobile: `mobile/README.md`
- Desktop: `desktop/README.md`

## Running with Docker

The `backend` and `frontend` can be run together with Docker Compose, along with a MySQL database.

> Mobile and desktop apps are not included in the Docker setup — they run on a device/simulator, not as containers.

### Prerequisites

- Docker Desktop installed and running

### Configure

Copy the root `.env.example` to `.env` and adjust the credentials if you don't want the defaults:

```bash
cp .env.example .env
cp backend/.env.example backend/.env
cp frontend/.env.example frontend/.env
```

### Start

```bash
docker compose up --build
```

### Ports

| Service  | URL                     | Port |
|----------|-------------------------|------|
| Frontend | http://localhost:5173   | 5173 |
| Backend  | http://localhost:3000   | 3000 |
| MySQL    | localhost:3306          | 3306 |

### Stop

```bash
docker compose down
```

To also remove the database volume (wipes stored data):

```bash
docker compose down -v
```

## License

This project is licensed under the terms described in the [LICENSE](./LICENSE) file.
