# AutoExecPrograms
Hello! This is my first public C# App.
This app is designed to make it easier to run multiple programs at the same time.
## About Project
For example, you are streaming on Twitch, but you need to prepare before streaming.
You need to run: 
* OBS
* the game you will be playing
* any other tools.

But after all so sometimes decisional laziness this all launch.
This application should simplify this difficulty for you and run several programs you need at the same time.
____
## How to use app
Just download app from [Releases](https://github.com/deVDem/AutoExecPrograms/releases) `(AutoExecPrograms.exe)` and move or copy to convenient folder (ex. Program Files, create folder "AutoExec")

After for convenience you can create link to desktop and open this program.

In the first window, you can add, delete, or execute the processes you need.

### Adding a process
To add a process to list just click "Add". App open second window with title "Add process".
You can choose not to enter a name process. Click to folder icon and choose executable file.

If Text Box "Name" is empty app automatically type name by the rules "%path%/`NAME`.exe"

If need you can write arguments to launch app (ex. launch CS:GO with argument -console).

By the way, the application can run not only .exe files!

After setting up, click on the "Add" button"

### Remove a processes
To remove a proccess(-es) just select need name process(-es) and click "Remove". **Please read [Bugs](https://github.com/deVDem/AutoExecPrograms#known-bugs)**
### Execute a processes
For execute a processes just click "Execute" button
### Saving processes
After adding process app automatically save this on file "%path_to_app%/processes.json"

`Maybe if the app doesn't have permissions, it might crash`

## Known bugs
* Method `removeProcess` work on search by the name. It create bug with selected processes.
    * If you have two or more processes with the same name, the program can delete a random process with that name instead of the one you want.
## Contacts
If necessary you can contact me on social networks
* [VK](https://vk.com/pdevdem)
* Telegram: @devdem
