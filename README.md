# ArenaGame
Made for a class project. Though I was originally intending to make a simple game, getting the hang of MVC
coding took a bit more work than I expected. That's fine though! I can get this figured out first before
going into further depth.

So I focused my effort on coding up a database manipulation tool that can be used to read from the database,
create new entries, edit them, and delete them. I showcased how this could apply to a database of weapons
that the player might purchase from shops and then equip. Future versions will also have armor, potions,
and enemies.

To run, clone the project and run (in Visual Studio) ArenaGame.sln
Open the Package Manager Console (Tools -> NuGet Package Manager -> Package Manager Console)
and type update-database
This should populate the database with some initial seed data.
Then you can simply start it up in your browser.

The tool I created for manipulating the weapons database will be found by simply clicking the Weapon Database button
or following the navigation link at the top of the page.

Now you should be able to see the database. Play around with it, add new entries, edit and delete existing ones.
