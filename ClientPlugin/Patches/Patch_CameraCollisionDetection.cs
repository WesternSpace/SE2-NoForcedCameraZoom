using HarmonyLib;
using Keen.Game2.Client.GameSystems.CameraSystems.Modes;

namespace ClientPlugin.Patches;

[HarmonyPatch(typeof(ThirdPersonCameraComponent), "CameraCollisionDetection")]
internal class Patch_CameraCollisionDetection
{
    private static bool Prefix() => false;
}
