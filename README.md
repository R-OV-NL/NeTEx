# R-OV NeTEx Parser
This repository contains a parser for the NeTEx format. It is based on the [Nederlands NeTEx Profiel 9.2.X](https://bison.dova.nu/standaarden/nederlands-netex-profiel).

## Project structure
NeTEx files are loaded in the `program.cs` file. You can edit the file name to load any NeTEx file into memory.

The file `NetexXml.cs` contains all original NeTEx classes from the XSD schema. These classes are generated using the `xsd.exe` tool from the .NET framework. The `NetexXml.cs` file is not meant to be edited. Editing this file may break the automatic mapping.

### Mapping

As the original XML schema is not meant for easy importing into a database, AutoMapper is used to map the original `NetexXml.cs` to new classes. These classes and enumerations are found in the `Models/NeTEx` folder. All files are named after the original XML element name. For example, the `NetexXml.cs` class `GeneralFrameItems` is mapped to the `Models/NeTEx/Frames/General/GeneralFrameItems.cs` class.

More changes will be made in future versions. For now this version only maps the `GeneralFrame` and `TimeTableFrame` elements of the `CompositeFrame` correctly.

## Installation

Installation & Usage documentation will be added in the future. For now, you can use the code as a reference for your own project.