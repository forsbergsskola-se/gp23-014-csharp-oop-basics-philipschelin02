﻿House redHouse = new House();
House blueHouse = new House();

Console.WriteLine(blueHouse.isDoorOpen);
Console.WriteLine(redHouse.isDoorOpen);

blueHouse.OpenDoor();

Console.WriteLine(blueHouse.isDoorOpen);
Console.WriteLine(redHouse.isDoorOpen);

redHouse.OpenDoor();

Console.WriteLine(blueHouse.isDoorOpen);
Console.WriteLine(redHouse.isDoorOpen);