using ServiceReference1;
namespace wcf_assignment3_interface
{
    public class Singleton
    {
        private static readonly Singleton instance = new Singleton();
        public static FlowerDetails[] Flowers;
        public static int selectedFlower;
        private Singleton()
        {
            Flowers= Array.Empty<FlowerDetails>();
            UpdateSingleton();
            selectedFlower= -1;
        }

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }
        public  static void UpdateSingleton()
        {

                FlowerServiceClient client = new FlowerServiceClient();
                GetFlowersRequest getFlowers = new GetFlowersRequest();
                var value = client.GetFlowers(getFlowers);
                GetFlowersResponse flowersResponse = value;
                Flowers = new FlowerDetails[flowersResponse.GetFlowersResult.Length];
                for (int i = 0; i < flowersResponse.GetFlowersResult.Length; i++)
                {
                    Flowers[i] = flowersResponse.GetFlowersResult[i];
                }
        }
        public static string NameById(int id)
        {
            foreach (FlowerDetails flower in Flowers)
            {
                if (flower.FlowerId==id)
                {
                    return flower.Name;
                }
            }
            return "Not in Set";
        }
    }
}
