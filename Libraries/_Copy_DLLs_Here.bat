@ECHO OFF
COPY "%ProgramFiles(x86)%\Steam\steamapps\common\Dyson Sphere Program\BepInEx\core\0Harmony.dll" .
COPY "%ProgramFiles(x86)%\Steam\steamapps\common\Dyson Sphere Program\BepInEx\core\BepInEx.dll" .
COPY "%ProgramFiles(x86)%\Steam\steamapps\common\Dyson Sphere Program\DSPGAME_Data\Managed\UnityEngine.UI.dll" .
COPY "%ProgramFiles(x86)%\Steam\steamapps\common\Dyson Sphere Program\DSPGAME_Data\Managed\UnityEngine.CoreModule.dll" .
COPY "%ProgramFiles(x86)%\Steam\steamapps\common\Dyson Sphere Program\DSPGAME_Data\Managed\UnityEngine.ImageConversionModule.dll" .

ECHO Assembly-CSharp.dll is obtained from https://nuget.bepinex.dev/packages/DysonSphereProgram.GameLibs

ECHO UnityEngine.dll from this post https://discord.com/channels/806549677209944084/806556447885623336/809242935073832970
ECHO Direct link: https://cdn.discordapp.com/attachments/806556447885623336/809242933433598002/UnityEngine.refstub.dll

PAUSE
