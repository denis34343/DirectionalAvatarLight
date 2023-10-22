# DirectionalAvatarLight

This is a fork of the [PiMaker/VRChatUnityThings](https://github.com/PiMaker/VRChatUnityThings) repository, focusing on the AvatarLight part. Instead of changing the indirect skybox color, this version uses a directional light.

## Usage

1. **Import the UnityPackage**: Download the UnityPackage provided in the [Releases](https://github.com/denis34343/DirectionalAvatarLight/releases).

2. **Add the Prefab to your Scene**:
   - Open your Unity project.
   - Import the UnityPackage you downloaded earlier.
   - Locate the Prefab and drag it into your Unity scene.

3. **Configure the Unlit_LoopRTBlit Material**:
   - Make sure you have a video player set up in your project.
   - Open the Unlit_LoopRTBlit Material.
   - Set your video player's RenderTexture to the appropriate field in the material.
   - This process depends on the video player you use.

4. **Align the Directional Light**:
   - Position the Directional Light to match the TV screen.

5. **Place the Camera and Quad**:
   - To prevent them from being visible in the VRChat world, position the camera and quad out of sight. For example, you can place them high up or in an area not visible to players.

## Dependencies

This project depends on [UdonSharp] please add it to your Project via the VrchatCreatorCompanion.

# License

All assets in this repository are licensed under the terms of 'CC BY-NC-SA 2.0' unless explicitly marked otherwise. For a complete copy of the license, please visit [Creative Commons BY-NC-SA 2.0](https://creativecommons.org/licenses/by-nc-sa/2.0/).

Feel free to reach out if you have any questions or need assistance.