# FindUnusedFiles


### Main Dialog
![Main Dialog](http://itechnology.github.io/FindUnusedFiles/media/findunusedfiles.png)


### Thumbnail Preview
![Thumbnail Preview](http://itechnology.github.io/FindUnusedFiles/media/findunusedfiles-thumb.png)

### Parsing Dialog

![Parsing Dialog](http://itechnology.github.io/FindUnusedFiles/media/findunusedfiles-parse.png)

### Visual Studio (context menu)

![Visual Studio (context menu)](http://itechnology.github.io/FindUnusedFiles/media/findunusedfiles-vs.png)


Change log

v1.3

    Alt-Click in list will show image thumbnail if it's an image
    Double-Click on list will open & set focus to item in solution explorer (VSIX only)
    Shell integration (EXE only)
        Add/Remove from Help menu, or register/unregister from command line with -s t 
    More file stats 


v1.2

    Changed UI a bit
    Context menus
        Select All
        Select Other
        Export Selection
        Delete Selection
        Explore Here
        Verify Existence (VSIX only: launches automated VS file search)
            In Solution
            In Project 
    Command line parameters (EXE only)
        -p path
        -r report type
        -f find regexp
        -i inside regexp 
    Help Menu
        Manual
        Change-log
        Website
        About
        License 
    More file stats
    More error handling 

v1.1

    Disable delete button if no are files selected
    Enabled searching in website projects (VSIX)
    More error messages on invalid and/or unsuccessful operations 


v1.0 (Visual Studio Plug-in)

    .EXE and VSIX versions now share same code-base
    Various modifications to accommodate different behavior in Visual Studio Mode & Standalone Mode
    Enabled searching in application projects 


v1.0 (Application)

    Toggle between used/unused lists
    Export used/unused lists
    Delete file(s) with confirmation prompt
    Save search criteria after search
    Show errors on invalid regexps
    Restore search criteria on application launch
    Double click used/unused list opens containing directory
    Allow passing file/directory path via command line 