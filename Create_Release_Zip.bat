@ECHO OFF
"%ProgramFiles%\7-Zip\7z" a ..\GreyHak-DSP_Color_Drones-9.zip icon.png LICENSE.txt manifest.json README.md config\greyhak.dysonsphereprogram.colordrones.png
cd bin\Release
DEL plugins\DSPColorDrones.dll
MKDIR plugins
COPY DSPColorDrones.dll plugins
"%ProgramFiles%\7-Zip\7z" u ..\..\..\GreyHak-DSP_Color_Drones-9.zip plugins\DSPColorDrones.dll
DEL plugins\DSPColorDrones.dll
RMDIR plugins
