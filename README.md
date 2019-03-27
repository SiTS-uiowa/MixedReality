# Mixed Reality in Unity

## Project Setup

1. Ensure that the main camera's tag is MainCamera. This should be the default.
2. Set the "Clear Flags" property of the main camera to "Solid Color" instead of "Skybox"
3. Set the "Background" color to black (RGB = 0,0,0)
4. Set the camera transform to (0, 0, 0)
5. Set the lowest performance settings
6. Check Player settings > Capabilities > SpatialPerception
7. File > Build settings > Select UWP as platform, then "Switch Platform"
8. Change "Target Device" to "HoloLens"
9. Build Settings > Player Settings > XR Settings > enable Virtual Reality Supported and select Windows Mixed Reality as device
10. Build
11. Deploy from Visual Studio
