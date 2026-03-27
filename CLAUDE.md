# CLAUDE.md — DoclingServe SDK

## Overview

Auto-generated C# SDK for [Docling Serve](https://github.com/docling-project/docling-serve) — self-hosted document conversion and chunking service (v1.15.1) powered by IBM's Docling. Converts files and URLs to structured formats (Markdown, JSON, HTML, text, doctags) and chunks documents using hierarchical or hybrid chunkers.
OpenAPI spec is locally maintained at `openapi.json` (OpenAPI 3.1.0).

## Build & Test

```bash
dotnet build DoclingServe.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth (optional for local instances, may be required for deployed services):

```csharp
var client = new DoclingServeClient(apiKey); // DOCLINGSERVE_API_KEY env var
```

Default base URL: `http://localhost:5001` (local Docling Serve instance).

## Key Files

- `src/libs/DoclingServe/openapi.json` — OpenAPI spec (locally maintained, OpenAPI 3.1.0)
- `src/libs/DoclingServe/generate.sh` — Runs autosdk to generate client code (no spec download or auth fixes needed)
- `src/libs/DoclingServe/Generated/` — **Never edit** — auto-generated code (702 files)
- `src/tests/IntegrationTests/Tests.cs` — Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)

## Spec Notes

- Spec is **locally maintained** — `generate.sh` does not download it (no `curl`)
- Spec already includes proper `securitySchemes` (http/bearer), `servers`, and top-level `security` — no `jq`/`yq` fixes needed
- Per-operation `security` uses `APIKeyAuth` references; top-level uses `Bearer` scheme
- Uses `--exclude-deprecated-operations` flag

## Sub-client Pattern

DoclingServe API has tagged operations generating sub-clients:
- `client.Convert.*` — Convert files and URLs to structured formats (sync + async task variants)
- `client.Chunk.*` — Chunk files and sources with hierarchical or hybrid chunkers (sync + async task variants)
- `client.Tasks.*` — Poll async task status and retrieve results
- `client.Health.*` — Health check, readiness probe, version info
- `client.Clear.*` — Clear cached converters and results
- `client.Management.*` — Memory usage counts and statistics

## Async Task Pattern

Long-running operations (convert, chunk) support two modes:
1. **Synchronous:** `client.Convert.ProcessFileV1ConvertFilePostAsync(...)` — blocks until complete
2. **Async task:** `client.Convert.ProcessFileAsyncV1ConvertFileAsyncPostAsync(...)` — returns a task ID immediately
   - Poll status: `client.Tasks.TaskStatusPollV1StatusPollTaskIdGetAsync(taskId)`
   - Get result: `client.Tasks.TaskResultV1ResultTaskIdGetAsync(taskId)`

## MEAI Integration

No MEAI interface (`IChatClient`, `IEmbeddingGenerator`, `ISpeechToTextClient`) is implemented — DoclingServe is a document processing service with no matching MEAI interface.
