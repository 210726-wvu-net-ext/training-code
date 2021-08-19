using System.Collections.Generic;

using Models;

namespace DL
{
    public interface IPetRepo
    {
        List<Cat> GetAllCats();

        Cat AddACat(Cat cat);

        Meal AddAMeal(Meal meal);

        Cat SearchCatByName(string name);

        List<Meal> GetMealsByCatId(int catId);
    }
}