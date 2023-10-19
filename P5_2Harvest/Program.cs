using System.Diagnostics.CodeAnalysis;

Wheat wheat = new Wheat();
Grain grain = new Grain();
Plant plant = new Plant();

wheat.CanBeProcessedToBread();
wheat.CanBeHarvested();
wheat.CanGrow();
grain.CanBeHarvested();
grain.CanGrow();
plant.CanGrow();