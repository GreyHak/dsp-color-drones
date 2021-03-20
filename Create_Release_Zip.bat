@ECHO OFF
"%ProgramFiles%\7-Zip\7z" a ..\GreyHak-DSP_Color_Drones-9.zip icon.png LICENSE.txt manifest.json config\greyhak.dysonsphereprogram.colordrones.png
cd bin\Release
DEL plugins\DSPColorDrones.dll
MKDIR plugins
COPY DSPColorDrones.dll plugins
COPY ..\..\README-Thunderstore.md README.md
"%ProgramFiles%\7-Zip\7z" u ..\..\..\GreyHak-DSP_Color_Drones-9.zip README.md plugins\DSPColorDrones.dll
DEL README.md
DEL plugins\DSPColorDrones.dll
RMDIR plugins
