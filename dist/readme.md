# Downloads


* .zip file contains the Application
    * Works as a Standalone Application
        * Integrates with the windows context menu
    * Works from the command line
        * Integrates with 3rd party IDE's
* .vsix file contains the Visual Studio Extension (for 2012, 2013, 2015)
    * [More info @ https://visualstudiogallery.msdn.microsoft.com](https://visualstudiogallery.msdn.microsoft.com/28650fe9-f41e-4db9-9d61-4e3f59c85b5e)


__Change Log__

__v1.4__

  * Made picturebox a little bigger, and moved outside of bounds of main window for better ergonomics
  * Added image-preview checkbox to not have to alt-click on an image to trigger display
  * Added some extra checking for file path operations
  * Fixed some thread-safety issues
  * Added "Launch External" to context menu to launch a file with it's associated external program
  * Switched search method, 2x faster, especially on extra large folders (2000+ files)
  * Ordered files in list
  * Prevent from searching for a reference of oneself (foo.css inside foo.css)
  * Made form resizable
  * Added button to cancel a search in progress in case of long running instance
  * Added pseudo-dropdown to pattern textboxes
	* Items are auto-added after a sucessful search
	* Items can be deleted via a right-click on the textbox
  * Added update check in help menu
  * Added auto-update check to option panel
  * Added exclusion list to option panel
    * Can be file names or folders (backslash).
	* Anything matched will be ignored
  * Added a treeview pane to see in which files ressources are used in
    * Has some context menus, but some things like multi-select do not work in treeviews, thus the Flat View pane that remains
  * Fixed Visual Studio from crashing when double-clicking a file
    * This was happeneing when "track active item in solution explorer" was already checked in VS options
  * Switched .csproj back to VS2013 temporarily to fix some issues on 2013. Has no impact on 2015

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