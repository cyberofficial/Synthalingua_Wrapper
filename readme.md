# Synthalingua Wrapper

A Windows-only GUI companion for [Synthalingua](https://github.com/cyberofficial/Synthalingua), designed to assemble and launch the exact command-line workflow you need for real-time translation, transcription, and subtitle generation. This project provides an approachable front end while preserving every advanced option available in the upstream Python tool.

---

## Table of Contents
- [Project Overview](#project-overview)
- [How the Wrapper Works](#how-the-wrapper-works)
- [Feature Highlights](#feature-highlights)
- [System Requirements](#system-requirements)
- [Getting Started](#getting-started)
  - [Option A: Use the Portable Release](#option-a-use-the-portable-release)
  - [Option B: Link to a Local Synthalingua Checkout](#option-b-link-to-a-local-synthalingua-checkout)
- [User Interface Tour](#user-interface-tour)
  - [Basic Mode](#basic-mode)
  - [Advanced Mode (Main UI)](#advanced-mode-main-ui)
- [Input Workflows](#input-workflows)
  - [Microphone Mode](#microphone-mode)
  - [HLS / Livestream Mode](#hls--livestream-mode)
  - [Captions & Subtitle Generation](#captions--subtitle-generation)
- [Model, Device, and Performance Settings](#model-device-and-performance-settings)
- [Web, Discord, and Remote Features](#web-discord-and-remote-features)
- [Command Generation & Automation](#command-generation--automation)
- [Configuration Storage & Resetting](#configuration-storage--resetting)
- [Troubleshooting](#troubleshooting)
- [Developing and Building From Source](#developing-and-building-from-source)
- [Support & Contributing](#support--contributing)
- [License](#license)

---

## Project Overview
Synthalingua Wrapper ships the same command-line superpowers as the core Synthalingua project, but wraps them with a VB.NET Windows Forms experience. It helps you:

- Discover your local Synthalingua installation (portable EXE or Python source).
- Compose valid argument combinations without memorizing flags.
- Persist preferred settings between sessions.
- Launch the generated workflow in an environment-aware batch script.

The wrapper lives in its own repository so that the upstream Python project can evolve independently. When a new Synthalingua release lands, simply point the GUI at the updated backend and regenerate your commands.

## How the Wrapper Works
```
┌───────────────┐     ┌──────────────────────┐     ┌─────────────────────┐
│ Windows Forms │ ─▶ │ CommandGenerator.vb   │ ─▶ │ Synthalingua Backend │
│ (MainUI.vb)   │     │  • Builds batch file │     │  • synthalingua.py   │
│               │     │  • Activates venv    │     │  • Synthalingua.exe  │
└──────┬────────┘     │  • Calls set_up_env  │     │  • set_up_env.exe    │
   │              └──────────────────────┘     └─────────────────────┘
   │                         │
   │                         ▼
   │              tmp.bat (per run)
   │                         │
   ▼                         ▼
 ConfigManager          Persisted user settings
 (My.Settings)          under %LOCALAPPDATA%
```

1. You select options in the GUI.
2. `CommandGenerator` validates selections, then assembles a batch script that sets up environment variables, activates the virtual environment (source mode), or launches the portable executable.
3. The script is saved as `tmp.bat` within the Synthalingua folder and immediately executed.
4. `ConfigManager` mirrors every checkbox and textbox into `My.Settings`, meaning your preferences load automatically the next time you open the app.

## Feature Highlights
- **Multiple operating modes** – choose between an approachable Basic Mode and the fully featured Advanced view.
- **All Synthalingua inputs** – microphone, HLS livestreams, and offline caption generation are available with tailored controls.
- **One-click environment prep** – runs `set_up_env.exe` and `ffmpeg_path.bat` before launching Synthalingua, mirroring the official workflow.
- **Model awareness** – choose Whisper, FasterWhisper, or OpenVINO backends and pick a Demucs isolation model when captions demand it.
- **Web & Discord integrations** – launch a local subtitle server, configure remote HTTPS, or push output to a Discord webhook without touching the CLI.
- **Robust persistence** – toggle advanced toggles such as silent detection, intelligent mode, batch jobs, timeout, or subtitle styling and reuse them later.
- **Safety nets** – language drop-down validation, path normalization, IP sanitation, and optional password masking reduce misconfiguration.

## System Requirements
| Component | Minimum | Recommended |
|-----------|---------|-------------|
| Operating System | Windows 10 (x64) | Windows 11 (latest updates) |
| .NET Runtime | [.NET 8 Desktop Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/8.0/runtime) | Same |
| Synthalingua Backend | `synthalingua.exe` portable build **or** Python source checkout | Latest [release](https://github.com/cyberofficial/Synthalingua/releases) |
| GPU | Optional; CUDA acceleration mirrors Synthalingua requirements | NVIDIA GPU with CUDA 12.8 for best performance |
| Storage | 6 GB free (portable package bundles models & FFmpeg) | SSD with 10+ GB free |

Additional dependencies:
- FFmpeg is bundled with the portable build. When running from source, follow the [main project instructions](https://github.com/cyberofficial/Synthalingua#installation).
- Ensure Python 3.12 is installed if you plan to use the source workflow.

## Getting Started

### Option A: Use the Portable Release
1. Download the latest **Synthalingua Windows x64 Portable + GUI** archive from [Itch.io](https://cyberofficial.itch.io/synthalingua).
2. Extract the archive to `C:\Tools\Synthalingua` (avoid paths with spaces for smoother CLI execution).
3. Launch `SynthalinguaGUI.exe`. The wrapper auto-detects the adjacent `Synthalingua.exe` portable backend and fills the **Program File** field.
4. Click **Generate** in Advanced Mode or use Basic Mode for a guided experience.

### Option B: Link to a Local Synthalingua Checkout
1. Clone the backend repository and install dependencies:

   ```powershell
   git clone https://github.com/cyberofficial/Synthalingua.git
   cd Synthalingua
   python -m venv data_whisper
   data_whisper\Scripts\activate
   pip install -r requirements.txt
   ```
2. Run `setup.bat` once to download models and helper binaries.
3. Open **Synthalingua Wrapper** and browse to `synthalingua.py` via **Program File**.
4. The wrapper switches to **Source** mode automatically and will activate the virtual environment before every run.

## User Interface Tour

### Basic Mode
Designed for casual use, Basic Mode surfaces the most common toggles:
- Choose between microphone, streaming, or file captioning workflows.
- Enable translation to English or select a secondary target language.
- Paste a Discord webhook URL (hidden by default—toggle visibility via the eye icon).
- Save and load presets for repeat sessions.

### Advanced Mode (Main UI)
The main window (`MainUI.vb`) exposes the complete Synthalingua CLI surface:
- **Program File** – path to `synthalingua.exe` or `synthalingua.py`.
- **Audio Source tabs** – configure microphone thresholds, HLS cookies/passwords, or caption file inputs.
- **Language panel** – set stream language, toggle translation/transcription, and optional secondary output language.
- **Device & RAM** – pick CUDA or CPU, select RAM profile, enable FP16 precision, and force RAM/VRAM locking.
- **Model Source** – Whisper, FasterWhisper, or OpenVINO radio buttons determine `--model_source`.
- **Caption Enhancements** – isolate vocals via Demucs, enable silent detection, word timestamps, or intelligent mode.
- **Integrations** – configure the internal Flask web server, HTTPS port, remote IP, and Discord webhook.
- **Command Block** – optionally reveal the generated batch script for inspection before running.

Tooltips are embedded throughout and can be refreshed via `ToolTipManager`. Hovering icons (e.g., JetBrains, GitHub Sponsors) surfaces additional context or quick links.

## Input Workflows

### Microphone Mode
1. Pick **Microphone** as the input source.
2. Optional: click **List Microphones** to run Synthalingua with `--list_microphones` and discover IDs.
3. Adjust:

   - `--energy_threshold`
   - `--mic_calibration_time`
   - `--record_timeout`
   - `--phrase_timeout`
   - `--mic_chunk_size`
4. Enable padding audio if you want overlapping buffers for smoother context stitching.
5. (Optional) Launch the web server to mirror captions in a browser.

### HLS / Livestream Mode
1. Enter the HLS `.m3u8` URL.
2. Supply cookies if the stream requires authentication (files are managed via `FileOperations`).
3. Tune chunk size and enable **Auto HLS** for adaptive latency.
4. Protect remote access by setting `--remote_hls_password_id` and `--remote_hls_password`.
5. Activate **Stream Original Text** to render the untranslated text alongside translations.

### Captions & Subtitle Generation
1. Choose **Captions** and load the media file.
2. Pick the output folder and file name; defaults mirror the selected file.
3. Optional enhancements:

    - `--makecaptions compare` to benchmark all RAM tiers.
    - `--isolate_vocals` + Demucs model selection for noisy sources.
    - `--silent_detect`, `--silent_threshold`, `--silent_duration` for speedups.
    - `--word_timestamps` for precise subtitle timing.
    - `--subtype burn` or `--subtype embed` with `--substyle` customization (font, size, color).
4. The command saves SRT files, and you can send them to Discord or print them to the console with `--print_srt_to_console`.

## Model, Device, and Performance Settings
- **RAM Profile** — maps to preset model bundles (1 GB through 11 GB variations). Combine with **Force RAM** to pin the choice.
- **Device Selection** — toggle between CUDA and CPU; CUDA requires an NVIDIA GPU with CUDA 12.8.
- **Model Source** — pick Whisper (official), FasterWhisper (CTranslate2), or OpenVINO for Intel acceleration.
- **Demucs Model** — choose from the curated list to balance quality vs. speed:

| Model | Description | Best For |
|-------|-------------|----------|
| `htdemucs` | Hybrid Transformer (default) | General separation |
| `htdemucs_ft` | Fine-tuned, higher fidelity | Highest quality |
| `mdx_q` / `mdx_extra_q` | Quantized MDX variants | Fastest separation |
| `htdemucs_6s` | 6-source split | Instrument-heavy audio |
| `demucs` / `hdemucs` | Legacy wave-domain models | Compatibility |

- **Batch Jobs & Timeout** — process files in parallel during caption workflows; configure safety timeout when batch mode is active.
- **Precision** — toggle FP16 for GPU runs on supported hardware.

## Web, Discord, and Remote Features
- **Web Server Toggle** – enables Synthalingua’s Flask server through `--portnumber`.
- **HTTPS Port** – numeric up/down configures `--https` for secure websockets when paired with the backend cert flow.
- **Server IP** – input is sanitized so only valid IPv4 addresses (or `127.0.0.1` fallback) are accepted.
- **Subtitle Window Overlay** – launch the bundled `subtitlewindow` form for an on-screen overlay.
- **Discord Webhook** – paste a Discord URL to forward translated lines; the wrapper remembers it securely if you allow saving.

## Command Generation & Automation
- Press **Generate** to populate the command block. Validation ensures:
  - Program file is selected.
  - Language choices exist in the curated drop-down.
  - Captions mode has required file paths.
  - Demucs model selection is valid.
- Use **Save Config** to persist settings and the last generated command.
- Use **Save Config to File** to export the batch script for automation or scheduled tasks.
- **Run** executes the temporary batch file immediately. Logs appear in a new console window.

## Configuration Storage & Resetting
- User preferences are stored under `%LOCALAPPDATA%\Synthalingua_Wrapper` via VB `My.Settings`.
- Click **Save Settings** anytime to snapshot the current state.
- Use **Wipe Settings** (with confirmation) to reset everything and close the app—handy when upgrading between major releases.
- Word blocklists are editable via `Edit Block List` and can be replaced with custom files.

## Troubleshooting
- **Program file missing** – ensure the wrapper points to either `Synthalingua.exe` (portable) or `synthalingua.py` (source). The app shows a red label when not detected.
- **Python dependency errors** – activate the correct virtual environment (`data_whisper\Scripts\activate`) and re-run `setup.bat` in the backend directory.
- **CUDA not available** – confirm CUDA 12.8 is installed and the GPU meets Synthalingua requirements. Switch to CPU mode if not.
- **Web server unreachable** – verify the Windows firewall prompt was accepted and that the chosen port is open. For remote access, set the IP to your LAN address and configure HTTPS credentials per Synthalingua’s wiki.
- **Stale settings** – use **Wipe Settings** to clear cache, or manually delete the `%LOCALAPPDATA%\Synthalingua_Wrapper` folder.
- **FFmpeg missing** – portable builds include FFmpeg; source installations must follow the [official guide](https://github.com/cyberofficial/Synthalingua/issues/2#issuecomment-1491098222).

## Developing and Building From Source
The solution targets `.NET 8.0-windows`. To build:

```powershell
dotnet restore
dotnet build Synthalingua_Wrapper.sln -c Release
```

Or open `Synthalingua_Wrapper.sln` in Visual Studio 2022 with the **.NET Desktop Development** workload installed. The WinForms designer remains fully functional thanks to the VB project structure.

Key source files:
- `MainUI.vb` – advanced interface logic and event wiring.
- `BasicMode.vb` – simplified configuration panel for new users.
- `CommandGenerator.vb` – translates UI state into Synthalingua CLI arguments.
- `ConfigManager.vb` – reads/writes persisted user settings.
- `WebManager.vb` & `WebBrowserConfig.vb` – clipboard helpers and browser embedding utilities.

## Support & Contributing
- Visit the [Synthalingua Wiki](https://github.com/cyberofficial/Synthalingua/wiki) for upstream documentation, advanced tutorials, and feature deep dives.
- Report wrapper-specific issues or feature requests via this repository’s GitHub issues.
- Support ongoing development through [Itch.io](https://cyberofficial.itch.io/synthalingua), [Ko-fi](https://ko-fi.com/cyberofficial), or [GitHub Sponsors](https://github.com/sponsors/cyberofficial).

Contributions are welcome! Fork the repo, make your changes, and submit a PR. Please ensure localization strings, tooltips, and accessibility helpers remain intact when modifying UI elements.

## License
Synthalingua Wrapper is licensed under the [GNU Affero General Public License v3.0](LICENSE), matching the main Synthalingua project. By using the GUI, you agree to the same responsible-use guidelines outlined in the upstream README.

---

© 2025 cyberofficial. All rights reserved under the AGPL-3.0 license.
