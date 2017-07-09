using MondorPlan.Foods;

namespace MondorPlan.Factory
{
    public class FoodFactory
    {
        public Food CreateInstace(string type)
        {
            type = type.ToLower();
            switch (type)
            {
                case "cram":
                    return new Cream();
                case "lembas":
                    return new Lembas();
                case "apple":
                    return new Apple();
                case "melon":
                    return new Melon();
                case "honeycake":
                    return new HoneyCake();
                case "mushrooms":
                    return new Mushrooms();
                default:
                    return new BaseFood();
            }
        }
    }
}
