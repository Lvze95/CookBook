namespace CookBook.ViewModels
{
    public class RecipeItemViewModel
    {
        public RecipeItemViewModel(string name, string shortDescription, string image)
        {
            Title = name;
            Description = shortDescription;
            Image = image;
        }

        public string Title { get; }
        public string Description { get; }
        public string Image { get; }
    }
}