# FindUnusedFiles

###Latest Version: v1.3.2 :: [Download](https://github.com/itechnology/FindUnusedFiles/tree/master/dist)

Helps you find and eliminate unused files (images, css, js, etc) in web projects/applications

__FindUnusedFiles__ helps you parse a website solution or project to find and eliminate unused images or other orphaned file types that are not being referenced in your sourcecode anymore.

Files can be of any type, that you wish to remove from a website you are working on.

__Works as a Standalone Application, from the Windows Explorer context menu, from the Command Line, or as a Visual Studio extension.__


Thank's to the command line it can easily be integrated with your favorite development IDE too.

### Main Dialog
![Main Dialog](http://itechnology.github.io/FindUnusedFiles/media/findunusedfiles.png)


### Thumbnail Preview
![Thumbnail Preview](http://itechnology.github.io/FindUnusedFiles/media/findunusedfiles-thumb.png)

### Parsing Dialog

![Parsing Dialog](http://itechnology.github.io/FindUnusedFiles/media/findunusedfiles-parse.png)

### Visual Studio (context menu)

![Visual Studio (context menu)](http://itechnology.github.io/FindUnusedFiles/media/findunusedfiles-vs.png)


__Change Log__

__v1.3.3__ (*in progress*)

  * Made picturebox a little bigger, and moved outside of bounds of main window for better ergonomics
  * Added some extra checking for file path operations
  * Added "Launch External" to context menu to launch a file with it's associated external program

__v1.3.2__

  * Fixed problems with certain case insensitive searches
  * Made picturebox bigger


__v1.3.1__

* Added SVG, CSS, JS to default find list
* Added scss to default files list
* Made search culture-invariant / case-insensitive
* Added Visual Studio: Enterprise & Community to supported platform list
* Solution (.sln) will now only build with Visual Studio 2015
    * But plug-in will work with Visual Studio 2012 and up


__v1.3__

* Alt-Click in list will show image thumbnail if it's an image
* Double-Click on list will open & set focus to item in solution explorer (VSIX only)
* Shell integration (EXE only)
    * Add/Remove from Help menu, or register/unregister from command line with -s t
* More file stats


__v1.2__

* Changed UI a bit
* Context menus
    * Select All
    * Select Other
    * Export Selection
    * Delete Selection
    * Explore Here
    * Verify Existence (VSIX only: launches automated VS file search)
        * In Solution
        * In Project
* Command line parameters (EXE only)
    * -p path
    * -r report type
    * -f find regexp
    * -i inside regexp
* Help Menu
    * Manual
    * Change-log
    * Website
    * About
    * License
* More file stats
* More error handling


__v1.1__

* Disable delete button if no are files selected
* Enabled searching in website projects (VSIX)
* More error messages on invalid and/or unsuccessful operations


__v1.0__ (Visual Studio Plug-in)

* .EXE and VSIX versions now share same code-base
* Various modifications to accommodate different behavior in Visual Studio Mode & Standalone Mode
* Enabled searching in application projects


__v1.0__ (Application)

* Toggle between used/unused lists
* Export used/unused lists
* Delete file(s) with confirmation prompt
* Save search criteria after search
* Show errors on invalid regexps
* Restore search criteria on application launch
* Double click used/unused list opens containing directory
* Allow passing file/directory path via command line