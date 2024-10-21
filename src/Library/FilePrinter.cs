using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(IGetRecipe recipe)
        {
            File.WriteAllText("Recipe.txt", recipe.RecipeToPrint());
        }
    }
}