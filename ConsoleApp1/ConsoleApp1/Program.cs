﻿using System.Runtime.InteropServices.ComTypes;
using ConsoleApp1;

Container kontener = new Container(12, 12, 12, 12, 12, ContainerType.RefrigeratedContainer);
Container kontener1 = new Container(12, 12, 12, 12, 12, ContainerType.GasContainer);
RefrigeratedContainer liquidContainer = new RefrigeratedContainer(10,100,200,100,100,Products.Bananas);
Console.WriteLine(liquidContainer.temperature);
