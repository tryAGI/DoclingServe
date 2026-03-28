#!/usr/bin/env bash
set -euo pipefail

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
autosdk generate openapi.json \
  --namespace DoclingServe \
  --clientClassName DoclingServeClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
