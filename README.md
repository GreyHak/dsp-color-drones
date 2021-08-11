# Color Drones for Dyson Sphere Program

**DSP Color Drones** is a mod for the Unity game Dyson Sphere Program developed by Youthcat Studio and published by Gamera Game.  The game is available on [here](https://store.steampowered.com/app/1366540/Dyson_Sphere_Program/).

Color your drones.  Create and share your own skins.

A template is provided with the mod in `BepInEx/config/greyhak.dysonsphereprogram.colordrones.png`.

<img alt="Flag Template" src="https://raw.githubusercontent.com/GreyHak/dsp-color-drones/main/config/greyhak.dysonsphereprogram.colordrones.png" width="220" height="220"/> ![Flag Template Appearance In-Game](https://raw.githubusercontent.com/GreyHak/dsp-color-drones/main/TemplateAppearance.jpg)

Pre-built configurations are also available on [GitHub](https://github.com/GreyHak/dsp-color-drones/tree/main/config).

<img alt="Aqua Example" src="https://raw.githubusercontent.com/GreyHak/dsp-color-drones/main/config/greyhak.dysonsphereprogram.colordrones_aqua.png" width="128" height="128"/> <img alt="Bat Example" src="https://raw.githubusercontent.com/GreyHak/dsp-color-drones/main/config/greyhak.dysonsphereprogram.colordrones_bat.png" width="128" height="128"/> <img alt="Super Example" src="https://raw.githubusercontent.com/GreyHak/dsp-color-drones/main/config/greyhak.dysonsphereprogram.colordrones_super.png" width="128" height="128"/> <img alt="Wonder Example" src="https://raw.githubusercontent.com/GreyHak/dsp-color-drones/main/config/greyhak.dysonsphereprogram.colordrones_wonder.png" width="128" height="128"/>

Looking for nice color combinations, check out [ColorHunt's popular palettes](https://colorhunt.co/palettes/popular).

The Windows 10 full default path, whether installed manually or through r2modman, is `C:\Program Files (x86)\Steam\steamapps\common\Dyson Sphere Program\BepInEx\config\greyhak.dysonsphereprogram.colordrones.png`.  The mod looks specifically in the `BepInEx/config` folder.

If you like this mod, please click the thumbs up at the [top of the page](https://dsp.thunderstore.io/package/GreyHak/DSP_Color_Drones/) (next to the Total rating).  That would be a nice thank you for me, and help other people to find a mod you enjoy.

If you have issues with this mod, please report them on [GitHub](https://github.com/GreyHak/dsp-color-drones/issues).  You can also contact me at GreyHak#2995 on the [DSP Modding](https://discord.gg/XxhyTNte) Discord #tech-support channel.

## Installation
This mod uses the BepInEx mod patch framework.  So BepInEx must be installed to use this mod.  Find details for installing BepInEx [in their user guide](https://bepinex.github.io/bepinex_docs/master/articles/user_guide/installation/index.html#installing-bepinex-1).  This mod was tested with BepInEx x64 5.4.11.0 and Dyson Sphere Program 0.8.19.7863 on Windows 10.

To manually install this mod, add the `DSPColorDrones.dll` to your `%PROGRAMFILES(X86)%\Steam\steamapps\common\Dyson Sphere Program\BepInEx\plugins\` folder, and place at `BepInEx\config\greyhak.dysonsphereprogram.colordrones.png`.

This mod can also be installed using ebkr's [r2modman](https://dsp.thunderstore.io/package/ebkr/r2modman/) mod manager by clicking "Install with Mod Manager" on the [DSP Modding](https://dsp.thunderstore.io/package/GreyHak/DSP_Color_Drones/) site.

## Open Source
The source code for this mod is available for download, review and forking on GitHub [here](https://github.com/GreyHak/dsp-color-drones) under the BSD 3 clause license.

## Change Log
### v1.0.2
 - Fixed compatability with the latest r2modman (ebkr-r2modman-3.1.17).  When DSP is run with this mod using r2modman 3.1.17 it will now use the location of the file which gets installed by the mod manager `AppData\Roaming\r2modmanPlus-local\DysonSphereProgram\profiles\Default\BepInEx\config`.  It will only use the `C:\Program Files (x86)\Steam\steamapps\common\Dyson Sphere Program\BepInEx\config` folder when run manually.  None of these paths are hard-coded.  Basically this change the template file directory comes from BepInEx directly, consistent with other mods.
### v1.0.1
 - Improved template.
 - Reload skin on unpause.
 - Added log entries when skin is successfully loaded or not found.
 - README cleanup.
### v1.0.0
 - Initial release.
