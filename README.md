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
