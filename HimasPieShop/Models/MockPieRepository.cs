namespace BethanysPieShop.Models
{
    public class MockPieRepository: IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Pie> AllPies =>
            new List<Pie>
            {
                new Pie {PieId = 1, PieName="Strawberry Pie", Price=15.95M, ShortDescription="Delicious Classic Strawberry Pie", LongDescription="This classic Strawberry Pie is the perfect summer dessert recipe made with an all-butter crust and fresh strawberries.", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg", InStock=true, IsPieOfTheWeek=false, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg"},
                new Pie {PieId = 2, PieName="Cheese cake", Price=18.95M, ShortDescription="Mesmerizing New York-style cheesecake", LongDescription="Classic New York-style cheesecake with a buttery graham cracker crust and rich, dense filling made from cream cheese, eggs, sugar, sour cream, vanilla, a hint of lemon, and a few tablespoons of flour.", Category = _categoryRepository.AllCategories.ToList()[1],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", InStock=true, IsPieOfTheWeek=false, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg"},
                new Pie {PieId = 3, PieName="Rhubarb Pie", Price=15.95M, ShortDescription="Mouth-watering Rhubarb Pie", LongDescription="Nothing says summer more than rhubarb pie! The filing is intensely pink and sweet tart, encased in a golden pastry crust and sprinkled with a buttery crumble topping. It’s like a rhubarb crisp and pie, all in one! Watching the sun set with a slice of this pie will make all your summer dreams complete.", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg", InStock=true, IsPieOfTheWeek=true, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg"},
                new Pie {PieId = 4, PieName="Pumpkin Pie", Price=12.95M, ShortDescription="Our signature Pumpkin Pie", LongDescription="Bursting with flavor, this pumpkin pie is our very favorite. It’s rich, smooth, and tastes incredible on our homemade pie crust and served with whipped cream.", Category = _categoryRepository.AllCategories.ToList()[2],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg", InStock=true, IsPieOfTheWeek=true, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg"}
            };

        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
