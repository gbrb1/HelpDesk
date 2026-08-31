## Progresso

### v0.1.0 — Initial API

Primeira versão funcional da API do HelpDesk, contemplando a estrutura inicial do backend e as operações básicas de tickets e usuários.

#### Concluído

- [x] Estrutura inicial do backend
- [x] Implementação da Clean Architecture
- [x] Camada `HelpDesk.Domain`
  - [x] Entidade `Ticket`
  - [x] Entidade `User`
  - [x] Enums de domínio
- [x] Camada `HelpDesk.Application`
  - [x] Interfaces de repositórios
  - [x] Services
  - [x] Dependency Injection
- [x] Camada `HelpDesk.Infrastructure`
  - [x] Entity Framework Core
  - [x] PostgreSQL
  - [x] `HelpDeskDbContext`
  - [x] Repositories
  - [x] Configuração dos relacionamentos entre `Ticket` e `User`
  - [x] Migrations
- [x] Camada `HelpDesk.API`
  - [x] Controllers
  - [x] CRUD de Tickets
  - [x] CRUD de Usuários
  - [x] Dependency Injection
  - [x] OpenAPI
  - [x] Swagger
  - [x] Documentação XML dos endpoints
- [x] Configuração inicial de Git e branches
- [x] Primeira release da API

#### Próximos passos

- [ ] Implementar DTOs
- [ ] Implementar validações
- [ ] Implementar autenticação
- [ ] Implementar autorização e controle de permissões
- [ ] Implementar tratamento global de exceções
- [ ] Criar testes unitários
- [ ] Criar testes de integração
- [ ] Dockerizar a aplicação
- [ ] Configurar CI/CD
- [ ] Implementar sistema de notificações/mensageria
- [ ] Desenvolver frontend


# 🎫 HelpDesk

> Sistema de gerenciamento de chamados desenvolvido para estudos de arquitetura de software, desenvolvimento de APIs e aplicações web modernas.

![Status](https://img.shields.io/badge/status-em%20desenvolvimento-yellow)
![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-14-239120?logo=csharp&logoColor=white)
![React](https://img.shields.io/badge/React-TypeScript-61DAFB?logo=react&logoColor=black)
![PostgreSQL](https://img.shields.io/badge/PostgreSQL-17-4169E1?logo=postgresql&logoColor=white)

---

## 📋 Sobre o projeto

O **HelpDesk** é uma aplicação para gerenciamento de chamados de suporte.

A ideia do projeto é simular um sistema utilizado por uma empresa para que usuários possam abrir chamados e agentes de suporte possam acompanhá-los, atribuí-los, alterar seus status e resolvê-los.

Além de desenvolver a aplicação, o projeto tem como objetivo praticar conceitos utilizados no desenvolvimento profissional de software, como:

- Arquitetura em camadas
- Clean Architecture
- APIs REST
- Entity Framework Core
- PostgreSQL
- Autenticação e autorização
- Testes automatizados
- Docker
- CI/CD
- Git e GitHub
- React + TypeScript

---

## 🚧 Status

**Em desenvolvimento**

O projeto está sendo desenvolvido incrementalmente, com commits organizados por funcionalidade.


# 🏗️ Arquitetura

O backend utiliza uma arquitetura baseada em camadas, seguindo princípios da **Clean Architecture**.

```text
                         ┌──────────────────┐
                         │   HelpDesk.Api   │
                         │                  │
                         │ Controllers      │
                         │ HTTP             │
                         │ Authentication   │
                         └────────┬─────────┘
                                  │
                                  ▼
                    ┌─────────────────────────┐
                    │  HelpDesk.Application  │
                    │                         │
                    │ Use Cases               │
                    │ Services                │
                    │ DTOs                    │
                    │ Interfaces              │
                    └────────────┬────────────┘
                                 │
                                 ▼
                       ┌─────────────────┐
                       │ HelpDesk.Domain │
                       │                 │
                       │ Entities        │
                       │ Enums           │
                       │ Business Rules  │
                       └────────┬────────┘
                                ▲
                                │
                    ┌───────────┴────────────┐
                    │ HelpDesk.Infrastructure│
                    │                        │
                    │ EF Core                │
                    │ PostgreSQL             │
                    │ Repositories           │
                    └────────────────────────┘
