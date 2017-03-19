﻿using System.Collections.Generic;
using Zoo_Animals_DAL.Entitites;

namespace Zoo_Animals_Api.Inrefaces
{
    public interface IZooService
    {
        void AddAnimal(Animal animal);
        Animal GetAnimal(int id);
        IEnumerable<Animal> GetAnimals();
        void RemoveAnimal(int id);
        IEnumerable<Species> GetAllSpecies();
        void Dispose();
    }
}