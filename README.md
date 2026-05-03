# Sahaara AI

**Sahaara AI** is an AI-assisted NGO referral and outreach platform designed to help case workers record assistance requests, classify applicant needs, match cases with relevant NGOs, generate respectful outreach drafts, and track communication outcomes.

The system is built around a human-in-the-loop workflow where AI assists the case worker, but does not make final decisions, send messages automatically, or expose sensitive applicant information without review.

---

## Table of Contents

- [Project Overview](#project-overview)
- [Problem Statement](#problem-statement)
- [Core MVP Workflow](#core-mvp-workflow)
- [Key Features](#key-features)
  - [Applicant Management](#applicant-management)
  - [Case Management](#case-management)
  - [AI Case Classification](#ai-case-classification)
  - [NGO Management](#ngo-management)
  - [NGO Matching](#ngo-matching)
  - [Outreach Generation](#outreach-generation)
  - [Communication Tracking](#communication-tracking)
  - [Dashboard and Reporting](#dashboard-and-reporting)
- [User Roles](#user-roles)
  - [Admin](#admin)
  - [Case Worker](#case-worker)
  - [Applicant](#applicant)
  - [NGO Contact](#ngo-contact)
- [Architecture Overview](#architecture-overview)
- [Technology Stack](#technology-stack)
- [Solution Structure](#solution-structure)
- [Core Modules](#core-modules)
- [AI Design Principles](#ai-design-principles)
- [Privacy and Safety Principles](#privacy-and-safety-principles)
- [Getting Started](#getting-started)
- [Prerequisites](#prerequisites)
- [Local Development Setup](#local-development-setup)
- [Environment Variables](#environment-variables)
- [Database Setup](#database-setup)
- [Running the Application](#running-the-application)
- [Docker Development](#docker-development)
- [Testing Strategy](#testing-strategy)
- [API Documentation](#api-documentation)
- [Git Workflow](#git-workflow)
- [Branch Naming Convention](#branch-naming-convention)
- [Commit Message Convention](#commit-message-convention)
- [Security Notes](#security-notes)
- [Project Roadmap](#project-roadmap)
- [Current Status](#current-status)
- [License](#license)
- [Disclaimer](#disclaimer)

---

## Project Overview

Sahaara AI is a case referral and outreach management system for welfare organizations, NGOs, and social support teams.

When a person approaches an organization for help, their request is often unstructured and difficult to process quickly. A case worker may need to determine the type of assistance required, identify suitable NGOs, write professional outreach messages, and track whether any organization responds.

Sahaara AI supports that workflow by helping case workers:

- Record applicant details.
- Capture consent before sharing case information.
- Create assistance cases.
- Use AI to classify the type of need.
- Match the case with relevant NGOs.
- Generate outreach drafts for email, WhatsApp, and phone calls.
- Review and approve AI-generated communication.
- Track sent messages, responses, follow-ups, and outcomes.

The system is not intended to replace human judgment. It is designed to assist case workers while preserving privacy, dignity, and accountability.

---

## Problem Statement

Many people who approach welfare organizations have urgent needs, but case workers may not have a centralized system to classify those needs, find relevant NGOs, generate appropriate outreach messages, and track responses.

This can lead to:

- Slow manual processing.
- Missed referral opportunities.
- Inconsistent communication.
- Poor follow-up tracking.
- Repeated work across similar cases.
- Risk of exposing sensitive applicant information.

Sahaara AI addresses this by turning an unstructured assistance request into a structured case workflow supported by AI classification, deterministic NGO matching, human-reviewed outreach, and response tracking.

---

## Core MVP Workflow

The MVP focuses on one clear end-to-end workflow:

```text
Applicant requests help
        ↓
Case worker records applicant details
        ↓
Case worker records consent
        ↓
Case worker creates assistance case
        ↓
AI classifies the case
        ↓
Case worker reviews and edits classification
        ↓
System matches top relevant NGOs
        ↓
AI generates outreach drafts
        ↓
Case worker reviews and approves message
        ↓
Outreach is sent or manually logged
        ↓
NGO response is tracked
        ↓
Follow-up is performed if needed
        ↓
Case is completed, referred, rejected, or closed
```

---

## Key Features

### Applicant Management

- Create applicant profiles.
- Store basic contact and demographic information.
- Record consent status.
- Maintain consent history.
- Link applicants to one or more assistance cases.

### Case Management

- Create assistance cases.
- Store raw problem descriptions.
- Track case urgency, category, status, and outcome.
- Add case notes.
- View complete case timeline.
- Close or reopen cases with controlled status transitions.

### AI Case Classification

- Analyze raw case descriptions.
- Extract structured fields such as:
  - Category
  - Subcategory
  - Urgency
  - Summary
  - Required support
  - Suggested documents
  - Sensitivity level
  - Recommended NGO service types
- Allow human review and correction.
- Support manual fallback if AI is unavailable.

### NGO Management

- Create and manage NGO profiles.
- Store NGO contact information.
- Assign services to NGOs.
- Mark NGOs as active, inactive, or unreachable.
- Search NGOs by city, area, service category, and status.

### NGO Matching

- Match cases to relevant NGOs.
- Use deterministic backend scoring.
- Rank NGOs based on:
  - Category match
  - Subcategory match
  - City match
  - Area match
  - Active status
- Return top recommended NGOs with match reasons.

### Outreach Generation

- Generate AI-assisted outreach drafts.
- Support multiple channels:
  - Email
  - WhatsApp draft
  - Phone call script
- Require human approval before sending or logging.
- Prevent sensitive data from being included by default.

### Communication Tracking

- Track which NGO was contacted.
- Record communication channel.
- Store sent timestamps.
- Track NGO response status.
- Record response notes.
- Set follow-up dates.
- Maintain communication history.

### Dashboard and Reporting

- View active cases.
- Track urgent cases.
- Track cases waiting for NGO response.
- View follow-up-needed cases.
- Monitor completed, rejected, referred, and closed cases.
- Provide admin-level reporting in later iterations.

---

## User Roles

### Admin

Admins manage platform configuration and operational data.

Admin capabilities include:

- Manage users.
- Manage NGOs.
- Manage NGO services.
- Manage assistance categories and subcategories.
- View all cases.
- View reports and dashboards.
- Deactivate or reactivate NGO records.

### Case Worker

Case workers handle the main case workflow.

Case worker capabilities include:

- Create applicants.
- Record applicant consent.
- Create assistance cases.
- Analyze cases using AI.
- Manually classify cases.
- Generate NGO matches.
- Generate outreach drafts.
- Review and approve messages.
- Send or log communication.
- Track NGO responses.
- Add case notes.
- Close cases.

### Applicant

Applicants are people requesting assistance.

In the MVP, applicants do not log into the system. Their information is entered and managed by a case worker.

### NGO Contact

NGO contacts receive outreach messages by email, WhatsApp, or phone.

In the MVP, NGO contacts do not have a portal. Their responses are manually recorded by the case worker.

---

## Architecture Overview

Sahaara AI uses a **Clean Architecture-inspired Modular Monolith**.

This gives the project a production-grade structure without the operational complexity of microservices.

The backend is organized into four main projects:

```text
SahaaraAI.Api
SahaaraAI.Application
SahaaraAI.Domain
SahaaraAI.Infrastructure
```

### Dependency Direction

```text
SahaaraAI.Api
    ↓
SahaaraAI.Application
    ↓
SahaaraAI.Domain

SahaaraAI.Infrastructure
    ↓
SahaaraAI.Application
    ↓
SahaaraAI.Domain
```

The Domain layer does not depend on external frameworks, databases, AI providers, or web APIs.

---

## Technology Stack

### Backend

- ASP.NET Core Web API
- C#
- Entity Framework Core
- ASP.NET Core Identity
- JWT Authentication
- Clean Architecture-inspired modular structure

### Database

- PostgreSQL recommended for local and cloud development
- SQL Server also possible
- EF Core migrations

### Frontend

Planned frontend options:

- React
- Next.js
- Blazor
- ASP.NET MVC/Razor Pages

The frontend is intentionally kept separate from the backend so the API can evolve cleanly.

### AI

- Fake AI provider for local development and testing
- OpenAI provider planned for real AI integration
- Structured AI outputs
- Backend validation and privacy guardrails

### Email

- Fake email sender for development and testing
- SMTP, SendGrid, or similar provider planned for production

### DevOps

- Docker
- Docker Compose
- GitHub Actions planned
- Environment-based configuration

---

## Solution Structure

Recommended repository structure:

```text
SahaaraAI/
│
├── src/
│   ├── SahaaraAI.Api/
│   ├── SahaaraAI.Application/
│   ├── SahaaraAI.Domain/
│   └── SahaaraAI.Infrastructure/
│
├── tests/
│   ├── SahaaraAI.UnitTests/
│   ├── SahaaraAI.IntegrationTests/
│   └── SahaaraAI.ArchitectureTests/
│
├── docs/
│   ├── architecture.md
│   ├── api-endpoints.md
│   ├── database-design.md
│   ├── ai-prompts.md
│   └── setup-guide.md
│
├── scripts/
│   ├── seed-dev-data.sql
│   └── reset-db.sql
│
├── docker/
│   ├── docker-compose.yml
│   └── Dockerfile
│
├── .gitignore
├── README.md
└── .env.example
```

---

## Core Modules

### Authentication Module

Handles:

- User login
- JWT generation
- Role-based authorization
- Admin and case worker access control

### Applicant Module

Handles:

- Applicant creation
- Applicant search
- Applicant updates
- Consent recording
- Consent history

### Case Module

Handles:

- Case creation
- Case details
- Case notes
- Case lifecycle status
- Case closure

### AI Module

Handles:

- Case classification
- Outreach draft generation
- Follow-up message generation
- AI output validation
- Privacy scanning

### NGO Module

Handles:

- NGO profiles
- NGO services
- NGO activation/deactivation
- NGO search and filtering

### Matching Module

Handles:

- NGO match generation
- Match scoring
- Match ranking
- Match reason generation

### Outreach Module

Handles:

- Draft creation
- Message editing
- Approval workflow
- Sending or logging outreach

### Communication Module

Handles:

- Communication logs
- NGO response tracking
- Follow-up dates
- Response notes

### Dashboard Module

Handles:

- Case counts
- Urgent cases
- Follow-up-needed cases
- Pending NGO responses
- Admin reporting

### Audit Module

Handles:

- Applicant creation audit
- Consent changes
- Case updates
- AI generation events
- Outreach approval
- Sent/logged communication
- Case closure

---

## AI Design Principles

AI in Sahaara AI is designed as a controlled backend capability, not as a fully autonomous agent.

The AI must not:

- Decide whether an applicant deserves help.
- Automatically send outreach.
- Bypass human approval.
- Select final NGOs independently.
- Share sensitive applicant details without review.
- Close cases.
- Make eligibility decisions.

The backend remains responsible for:

- Building safe prompts.
- Limiting what data is sent to AI.
- Validating AI output.
- Enforcing allowed categories and urgency values.
- Detecting sensitive information.
- Requiring human review.
- Saving only approved or reviewed outputs.

### AI Classification Output

Expected structured output includes:

```json
{
  "category": "Marriage Assistance",
  "subcategory": "Jahez / Household Items",
  "urgency": "High",
  "summary": "Applicant is seeking support for her daughter's upcoming marriage and basic household items.",
  "requiredSupport": [
    "Jahez items",
    "Household items",
    "Financial assistance"
  ],
  "suggestedDocuments": [
    "CNIC",
    "Income proof",
    "Wedding date proof"
  ],
  "sensitivityLevel": "High",
  "recommendedNgoTypes": [
    "Marriage assistance",
    "Women welfare",
    "Zakat foundation"
  ]
}
```

---

## Privacy and Safety Principles

Sahaara AI handles sensitive applicant data. Privacy and dignity are core requirements.

The system should:

- Require consent before external outreach.
- Block sending if consent is missing, denied, or withdrawn.
- Avoid sharing CNIC by default.
- Avoid sharing full address by default.
- Avoid sharing exact income unless necessary.
- Avoid humiliating or pity-based language.
- Preserve applicant dignity in AI-generated messages.
- Keep AI-generated content reviewable.
- Maintain an audit trail of important actions.
- Avoid storing secrets or sensitive data in logs.

Example of preferred language:

```text
Applicant is seeking support for basic household items and marriage-related assistance.
```

Avoid language like:

```text
This helpless poor family desperately needs charity.
```

---

## Getting Started

These instructions assume you are setting up the project locally for development.

---

## Prerequisites

Install the following:

- .NET SDK 8 or later
- Git
- PostgreSQL or Docker Desktop
- Visual Studio, Rider, or VS Code
- Postman, Insomnia, or Swagger for API testing
- Node.js, if using a JavaScript frontend

Check installations:

```bash
dotnet --version
git --version
docker --version
```

---

## Local Development Setup

Clone the repository:

```bash
git clone https://github.com/saffikhawajalce/sahaara-ai.git
cd sahaara-ai
```

Restore backend dependencies:

```bash
dotnet restore
```

Build the solution:

```bash
dotnet build
```

Run the API:

```bash
dotnet run --project src/SahaaraAI.Api
```

If Swagger is enabled, open one of the following URLs:

```text
https://localhost:5001/swagger
```

```text
http://localhost:5000/swagger
```

The exact URL depends on your local launch settings.

---

## Environment Variables

Create a local `.env` file or use .NET user secrets for sensitive configuration.

Never commit real secrets to Git.

Example `.env.example`:

```env
# Database
POSTGRES_DB=sahaara_ai
POSTGRES_USER=sahaara
POSTGRES_PASSWORD=change_me_for_local

# Backend
ASPNETCORE_ENVIRONMENT=Development
ASPNETCORE_URLS=http://+:8080

JWT_ISSUER=SahaaraAI
JWT_AUDIENCE=SahaaraAI.Client
JWT_KEY=replace_with_a_long_local_dev_secret_at_least_32_chars

AI_PROVIDER=Fake
OPENAI_API_KEY=

EMAIL_PROVIDER=Fake
SMTP_HOST=
SMTP_PORT=587
SMTP_USERNAME=
SMTP_PASSWORD=

DATABASE_APPLY_MIGRATIONS_ON_STARTUP=true
DATABASE_SEED_ON_STARTUP=true

# Frontend
VITE_API_BASE_URL=http://localhost:8080
```

---

## Database Setup

If using EF Core migrations, run:

```bash
dotnet ef database update \
  --project src/SahaaraAI.Infrastructure \
  --startup-project src/SahaaraAI.Api
```

If you do not have the EF CLI installed:

```bash
dotnet tool install --global dotnet-ef
```

Then verify:

```bash
dotnet ef --version
```

---

## Running the Application

### Run Backend

```bash
dotnet run --project src/SahaaraAI.Api
```

### Run Tests

```bash
dotnet test
```

### Run Specific Test Project

```bash
dotnet test tests/SahaaraAI.UnitTests
```

---

## Docker Development

A Docker Compose setup is planned for local development.

Expected services:

```text
sahaara-db       PostgreSQL database
sahaara-api      ASP.NET Core API
sahaara-web      Frontend web application
sahaara-pgadmin  Optional database UI
```

Run the application stack:

```bash
docker compose up --build
```

Run in background:

```bash
docker compose up --build -d
```

Stop containers:

```bash
docker compose down
```

Stop containers and delete database volume:

```bash
docker compose down -v
```

View logs:

```bash
docker compose logs -f
```

View API logs:

```bash
docker compose logs -f sahaara-api
```

Open database shell:

```bash
docker exec -it sahaara-db psql -U sahaara -d sahaara_ai
```

---

## Testing Strategy

Sahaara AI should be tested at multiple levels.

### Unit Tests

Focus on:

- Matching score calculation.
- Consent rules.
- Case status transitions.
- AI output validation.
- Outreach privacy scanning.
- Match reason generation.

### Integration Tests

Focus on:

- API endpoints.
- EF Core database mappings.
- Repository behavior.
- Authentication and authorization.
- Applicant to case workflow.
- NGO to matching workflow.
- Outreach approval workflow.

### Architecture Tests

Focus on enforcing project boundaries:

- Domain must not depend on Infrastructure.
- Domain must not depend on API.
- Application must not depend on API.
- Controllers should not use DbContext directly.
- Infrastructure should implement Application interfaces.

### AI Evaluation Tests

AI tests should verify:

- JSON output is valid.
- Category belongs to allowed categories.
- Urgency belongs to allowed values.
- No sensitive data is leaked.
- Summary uses respectful language.
- AI does not make final eligibility decisions.

### End-to-End Tests

Future E2E tests should cover:

- Admin creates NGO and services.
- Case worker creates applicant and case.
- AI classifies case.
- System generates NGO matches.
- Case worker generates outreach draft.
- Case worker approves and sends/logs outreach.
- Case worker records NGO response.
- Case worker closes case.

---

## API Documentation

During development, API documentation is available through Swagger.

Common endpoint groups:

```text
/api/auth
/api/users
/api/applicants
/api/cases
/api/categories
/api/ngos
/api/matching
/api/outreach
/api/communications
/api/follow-ups
/api/dashboard
/api/reports
```

Example planned endpoints:

```text
POST   /api/auth/login
POST   /api/applicants
GET    /api/applicants/{id}
POST   /api/cases
GET    /api/cases/{id}
POST   /api/cases/{caseId}/analyze
POST   /api/cases/{caseId}/matches
GET    /api/cases/{caseId}/matches
POST   /api/cases/{caseId}/outreach-drafts
POST   /api/outreach/{id}/approve
POST   /api/outreach/{id}/send
POST   /api/cases/{caseId}/communications
```

---

## Git Workflow

Use feature branches for all non-trivial work.

Recommended workflow:

```bash
git checkout main
git pull origin main
git checkout -b feature/short-description
```

After making changes:

```bash
git status
git add .
git commit -m "type: short description"
git push -u origin feature/short-description
```

Then open a pull request into `main`.

---

## Branch Naming Convention

Use clear branch names:

```text
feature/project-skeleton
feature/authentication
feature/ngo-management
feature/applicant-management
feature/case-management
feature/manual-matching
feature/ai-classification
feature/outreach-drafts
feature/communication-tracking

fix/login-validation
fix/matching-score-bug
fix/consent-check

docs/update-readme
docs/api-endpoints

chore/setup-solution
chore/add-gitignore
chore/docker-compose
```

---

## Commit Message Convention

Use a simple conventional style:

```text
type: short description
```

Recommended types:

```text
feat      New feature
fix       Bug fix
docs      Documentation change
style     Formatting only
refactor  Code restructuring without behavior change
test      Tests added or updated
chore     Build, tooling, setup, maintenance
ci        CI/CD workflow changes
```

Examples:

```text
chore: initialize Sahaara AI repository
docs: add production README
feat: add base domain entities
feat: add applicant consent model
feat: add NGO management endpoints
feat: implement manual NGO matching
fix: block outreach when consent is withdrawn
test: add matching score unit tests
```

---

## Security Notes

Do not commit:

```text
.env
appsettings.Production.json
real database connection strings
JWT signing keys
OpenAI API keys
SMTP credentials
real applicant data
real CNIC values
private NGO contact data
production logs
```

Use environment variables, user secrets, or cloud secret managers.

Before pushing code, check:

```bash
git status
```

Search for accidental secrets:

```bash
git diff
```

---

## Project Roadmap

### Phase 1: Project Foundation

- Create repository.
- Add solution structure.
- Add documentation.
- Add base architecture.
- Add Git workflow.

### Phase 2: Backend Foundation

- Create ASP.NET Core solution.
- Add Domain, Application, Infrastructure, and API projects.
- Add EF Core.
- Add PostgreSQL.
- Add base entities and enums.
- Add Swagger.
- Add health checks.

### Phase 3: Authentication

- Add Identity or JWT authentication.
- Add Admin and CaseWorker roles.
- Seed default users.
- Protect endpoints.

### Phase 4: NGO and Category Management

- Add assistance categories.
- Add subcategories.
- Add NGO profiles.
- Add NGO services.
- Add search and filtering.

### Phase 5: Applicant and Consent Management

- Create applicant records.
- Record consent.
- Maintain consent history.
- Enforce consent rules.

### Phase 6: Case Management

- Create assistance cases.
- Add case notes.
- Add case lifecycle statuses.
- Add case detail view.
- Add case closure rules.

### Phase 7: Manual Matching

- Add manual classification.
- Implement deterministic NGO matching.
- Save match results.
- Generate match reasons.

### Phase 8: AI Classification

- Add fake AI provider.
- Add structured AI output model.
- Add case analysis service.
- Add validation and privacy guardrails.
- Integrate real AI provider later.

### Phase 9: Outreach Drafts

- Generate outreach drafts.
- Support email, WhatsApp, and phone script formats.
- Add human approval.
- Add privacy checks.

### Phase 10: Communication Tracking

- Track sent/logged outreach.
- Record NGO responses.
- Add follow-up dates.
- Add communication timeline.

### Phase 11: Email Sending

- Add fake email sender.
- Add SMTP or SendGrid integration.
- Handle failures safely.
- Log email results.

### Phase 12: Dashboard and Reporting

- Add case worker dashboard.
- Add admin dashboard.
- Add basic reports.
- Add recent activity.

### Phase 13: Deployment

- Add Dockerfile.
- Add Docker Compose.
- Add production configuration.
- Deploy backend.
- Deploy frontend.
- Deploy database.
- Run smoke tests.

---

## Current Status

Project is in early development.

Current focus:

```text
Repository setup
Clean architecture skeleton
Backend project scaffolding
Documentation
Initial development workflow
```

---

## License

No license has been selected yet.

Until a license is added, all rights are reserved by the repository owner. This means the source code may be visible if the repository is public, but reuse, modification, or redistribution is not automatically permitted.

---

## Disclaimer

Sahaara AI is a software project intended to assist case workers with referral and outreach workflows. It does not guarantee assistance, verify applicant eligibility, or replace human judgment.

AI-generated outputs must always be reviewed by an authorized human user before being used in communication with NGOs or external parties.
