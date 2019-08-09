# Overview

The Todo.md document serves to keep track of items *todo*.

## Todo / Nice to Have Items

- Use async/wait where applicable

- Put video in a grid for mkvmerge editing

- Add External audio

- Think about tackling the multiple vidoes in a single playlist (labyrinth)

- ExtensionMethods.NumberOfEpisodes needs to filter on summary.episodenumber != null as well for cases where isselected by no episode number.  Not changing it now due to not knowing what the effects are

- Default the MKVToolNixGUI Track Name to "Commentary" if commentary checkbox is checked

- When a single file contains multiple episodes :
	- Go by the actually episode number entered in the loop
	- Validate on the screen

- Create a batchguy log file that indicates how many files were processed and how long it took

- Rename EnumBluRayLineItemType to have eac3to in the title, to prepare for tsMuxeR OR Make the identifylineitem service generic to pass in any enum or a combo of these

- Research and start laying down the foundation for tsMuxeR
	- Understand the cli
	- Understand that you have to now introduce mkvmerge cli to mux the .h264 file into an mkv
	- Understand that 2 new exes have be tracked, mkvmerge and tsMuxeR
	- Understand that you will have to use eac3to for .wav

- Maybe add a check all checkbox to grids with is selected
	- http://dotnetvisio.blogspot.com/2015/08/create-select-all-checkbox-column.html

- Figure out a better solution to inform of the status of long running tasks

- Ability to create sample.avs/sample.encode.bat

- Ability to set the video variable for avisynth for advanced scripting