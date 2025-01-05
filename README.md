# Visual ADB
Visual ADB is a program to use some ADB functions without the command line. It is written in C# using WinForms.

> [!IMPORTANT]  
> Visual ADB does not include many of the features of regular ADB, but some features will be added in the future.

## Installation
1. Download ADB from <https://dl.google.com/android/repository/platform-tools-latest-windows.zip?hl=ru>
2. Create a new folder 
3. Move Visual ADB.exe into this folder and extract the contents of the platform-tools folder from the downloaded platform-tools-latest-windows.zip folder


> [!CAUTION]
> If you already have ADB installed, copy the files into the folder anyway. Visual ADB calls ADB ***in a relative path*** (not "adb", but "adb.exe"). 
