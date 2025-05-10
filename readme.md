# Synthalingua Wrapper

> A Windows GUI wrapper for Synthalingua, providing an easy-to-use interface for real-time audio transcription, translation, and subtitle generation.

---

## Features
- Windows Forms GUI for Synthalingua
- Supports microphone, file, and HLS stream audio sources
- Real-time transcription and translation
- Subtitle and caption file generation
- Discord webhook integration
- Word blocklist and repeat protection
- Web server for browser-based subtitle display
- Multiple device support (CPU/CUDA)
- Model directory selection and advanced configuration

## Requirements
- Windows 10 or later
- .NET 8.0 Desktop Runtime
- [Synthalingua](https://github.com/cyberofficial/Synthalingua) (Python or EXE backend)
- FFmpeg (included in release)

## Installation
1. Download and extract the latest release from [Itch.io](https://cyberofficial.itch.io/synthalingua).
2. Ensure you have the .NET 8.0 Desktop Runtime installed.
3. Place your Synthalingua backend (Python or EXE) in the same directory, or use the GUI to locate it.

## Usage
1. Launch `SynthalinguaGUI.exe`.
2. Select your audio source (microphone, file, or HLS stream).
3. Configure language, device, and other options as needed.
4. Click **Generate** to create the command/configuration.
5. Click **Run** to start transcription/translation.
6. Use the web server feature to display subtitles in a browser if desired.

### Command Generation
The wrapper generates batch scripts to run Synthalingua with your selected options. Advanced users can review or edit the generated script before running.

## Project Structure
- `MainUI.vb` - Main Windows Forms interface logic
- `CommandGenerator.vb` - Builds Synthalingua command lines
- `ConfigManager.vb` - Loads and saves user settings
- `FileOperations.vb` - File and folder utilities
- `WebManager.vb` - Web server and browser integration
- `assets/` - Icons and images
- `Resources/` - Additional resources

## License
This project is licensed under the GNU Affero General Public License v3.0. See [LICENSE](LICENSE) for details.

## Links
- [Synthalingua Backend](https://github.com/cyberofficial/Synthalingua)
- [Download Synthalingua Wrapper on Itch.io](https://cyberofficial.itch.io/synthalingua)
- [Support on Ko-fi](https://ko-fi.com/cyberofficial)

---

© 2025 cyberofficial. See LICENSE for details.
